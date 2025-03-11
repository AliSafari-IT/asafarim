import { useEffect, useState } from "react";
import Wrapper from "../../layout/Wrapper/Wrapper";
import { Button, Toolbar, Tooltip } from "@fluentui/react-components";
import { Edit20Regular, Delete20Regular, Eye20Regular, AppsAddIn24Regular as AddNewIcon } from "@fluentui/react-icons";
import { useNavigate } from "react-router-dom";
import { IProject } from "../../interfaces/IProject";
import Notification from "@/components/Notification/Notification";
import { logger } from "@/utils/logger";
import dashboardServices from "@/api/entityServices";

const ProjectHome: React.FC = () => {
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState<string | null>(null);
    const [projects, setProjects] = useState<IProject[]>([]);
    const navigate = useNavigate();

    const headerBlock = (
        <header className="w-full text-center mx-auto m-0 flex justify-between items-center">
            <Toolbar aria-label="Project Toolbar" className="mt-4">
                <h1 className="text-3xl font-bold p-6">
                    <span className="mx-3">Projects</span>
                    <Button
                        appearance="primary"
                        icon={<AddNewIcon />}
                        onClick={() => navigate("/projects/add")}
                        className="ml-5 pl-3 pr-3"
                        aria-label={"Add New Project"}
                        title="Add New Project"
                    />
                </h1>
            </Toolbar>
        </header>
    );

    const fetchProjects = async () => {
        setLoading(true);
        setError(null);
        try {
            const data = await dashboardServices.fetchProjects();
            logger.info("Projects data received: " + JSON.stringify(data));
            
            if (Array.isArray(data)) {
                setProjects(data);
                if (data.length === 0) {
                    logger.info("No projects found in the response");
                }
            } else {
                logger.error("Invalid data format received: " + JSON.stringify(data));
                setError("Invalid data format received from server");
            }
        } catch (err) {
            logger.error("Error fetching projects: " + JSON.stringify(err));
            setError("Failed to load projects. Please try again later.");
        } finally {
            setLoading(false);
        }
    };

    useEffect(() => {
        fetchProjects();
    }, []);

    const handleView = (id: string) => {
        navigate(`/projects/${id}`);
    };

    const handleEdit = (id: string) => {
        navigate(`/projects/edit/${id}`);
    };

    const handleDelete = async (id: string) => {
        if (window.confirm("Are you sure you want to delete this project?")) {
            try {
                logger.info(`Attempting to delete project with id: ${id}`);
                await dashboardServices.deleteEntity("projects", id);
                logger.info(`Successfully deleted project with id: ${id}`);
                fetchProjects();
            } catch (error) {
                logger.error(`Failed to delete project: ${error}`);
            }
        }
    };

    const calculateDaysActive = (startDate: Date, endDate?: Date) => {
        const today = new Date();
        
        // If the project has an end date and it's in the past (project is expired)
        if (endDate && new Date(endDate) < today) {
            // Calculate days between start date and end date
            return Math.ceil((new Date(endDate).getTime() - startDate.getTime()) / (1000 * 3600 * 24));
        }
        
        // Otherwise, calculate days between start date and today
        return Math.ceil((today.getTime() - startDate.getTime()) / (1000 * 3600 * 24));
    };

    const calculateDaysRemaining = (endDate: Date | undefined) => {
        if (!endDate) return null;        
        const today = new Date();
        return Math.ceil((new Date(endDate).getTime() - today.getTime()) / (1000 * 3600 * 24));
    };

    const getStatusLabel = (status: number | undefined) => {
        switch (status) {
            case 0: return "In Progress";
            case 1: return "Completed";
            case 2: return "Cancelled";
            case 3: return "Paused";
            case 4: return "Extended";
            default: return "Unknown";
        }
    };

    const getVisibilityLabel = (visibility: number | undefined) => {
        switch (visibility) {
            case 0: return "Public";
            case 1: return "Members Only";
            case 2: return "Private";
            default: return "Unknown";
        }
    };

    // Format days remaining with expiration message
    const formatDaysRemaining = (daysRemaining: number | null) => {
        if (daysRemaining === null) return 'Not set';
        
        if (daysRemaining >= 0) {
            return daysRemaining.toString();
        } else {
            // Project is expired
            const daysAgo = Math.abs(daysRemaining);
            
            if (daysAgo >= 730) { // More than 2 years (approximation)
                const years = Math.floor(daysAgo / 365);
                const remainingDays = daysAgo % 365;
                return `Expired (${years} ${years === 1 ? 'year' : 'years'} and ${remainingDays} ${remainingDays === 1 ? 'day' : 'days'} ago)`;
            } else if (daysAgo >= 365) { // More than 1 year
                const years = Math.floor(daysAgo / 365);
                const remainingDays = daysAgo % 365;
                return `Expired (${years} year and ${remainingDays} ${remainingDays === 1 ? 'day' : 'days'} ago)`;
            } else {
                return `Expired (${daysAgo} ${daysAgo === 1 ? 'day' : 'days'} ago)`;
            }
        }
    };

    // Format days active to show years and days when appropriate
    const formatDaysActive = (daysActive: number | null) => {
        if (daysActive === null) return 'Not set';
        
        if (daysActive < 365) {
            return `${daysActive} ${daysActive === 1 ? 'day' : 'days'}`;
        } else if (daysActive < 730) { // Between 1 and 2 years
            const years = Math.floor(daysActive / 365);
            const remainingDays = daysActive % 365;
            
            if (remainingDays === 0) {
                return `${years} year`;
            } else {
                return `${years} year, ${remainingDays} ${remainingDays === 1 ? 'day' : 'days'}`;
            }
        } else { // 2 or more years
            const years = Math.floor(daysActive / 365);
            const remainingDays = daysActive % 365;
            
            if (remainingDays === 0) {
                return `${years} years`;
            } else {
                return `${years} years, ${remainingDays} ${remainingDays === 1 ? 'day' : 'days'}`;
            }
        }
    };

    if (loading) {
        return <Wrapper header={headerBlock}><div className="p-4">Loading projects...</div></Wrapper>;
    }

    if (error) {
        return (
            <Wrapper header={headerBlock}>
                <div className="p-4">
                    <Notification type="error" text={error} />
                    <Button 
                        appearance="primary" 
                        onClick={() => fetchProjects()}
                        className="mt-4"
                    >
                        Retry
                    </Button>
                </div>
            </Wrapper>
        );
    }

    return (
        <Wrapper header={headerBlock}>
            <div className="w-full p-4">
                {projects.length === 0 ? (
                    <div className="text-center p-4">
                        <p>No projects found.</p>
                        <Button
                            appearance="primary"
                            icon={<AddNewIcon />}
                            onClick={() => navigate("/projects/add")}
                            className="mt-4"
                        >
                            Create Your First Project
                        </Button>
                    </div>
                ) : (
                    <table className="w-full shadow-md rounded-lg">
                        <thead>
                            <tr>
                                <th className="p-2 text-left">Project Name</th>
                                <th className="p-2 text-left">Status</th>
                                <th className="p-2 text-left">Visibility</th>
                                <th className="p-2 text-left">Start Date</th>
                                <th className="p-2 text-center">Days Active</th>
                                <th className="p-2 text-center">Days Left</th>
                                <th className="p-2 text-center">Actions</th>
                            </tr>
                        </thead>
                        <tbody>
                            {projects?.map((project) => (
                                <tr key={project.id} className="border-t">
                                    <td className="p-2">{project.name}</td>
                                    <td className="p-2">{getStatusLabel(project.status)}</td>
                                    <td className="p-2">{getVisibilityLabel(project.visibility)}</td>
                                    <td className="p-2">
                                        {project.startDate 
                                            ? new Date(project.startDate).toLocaleDateString()
                                            : 'Not set'}
                                    </td>
                                    <td className={`p-2 text-center font-bold ${
                                        project.startDate 
                                            ? calculateDaysActive(new Date(project.startDate), project.endDate) < 0 
                                                ? "bg-danger" 
                                                : calculateDaysActive(new Date(project.startDate), project.endDate) < 30 
                                                    ? "bg-success" 
                                                    : "bg-info"
                                            : "bg-info"
                                    }`}>
                                        {project.startDate 
                                            ? formatDaysActive(calculateDaysActive(new Date(project.startDate), project.endDate))
                                            : 'Not set'}
                                    </td>
                                    <td className={`p-2 text-center font-bold ${
                                        project.endDate 
                                            ? calculateDaysRemaining(project.endDate) !== null
                                                ? calculateDaysRemaining(project.endDate)! < 0 
                                                    ? "bg-red-300" 
                                                    : calculateDaysRemaining(project.endDate)! < 30 
                                                        ? "bg-yellow-800" 
                                                        : "bg-green-100"
                                                : "bg-gray-100"
                                            : "bg-gray-100"
                                    }`}>
                                        {project.endDate 
                                            ? calculateDaysRemaining(project.endDate) !== null
                                                ? formatDaysRemaining(calculateDaysRemaining(project.endDate))
                                                : 'Error'
                                            : 'Not set'}
                                    </td>
                                    <td className="p-2 text-center">
                                        <Tooltip content="View Project" relationship="label">
                                            <Button
                                                icon={<Eye20Regular />}
                                                onClick={() => handleView(project.id)}
                                                appearance="subtle"
                                            />
                                        </Tooltip>
                                        <Tooltip content="Edit Project" relationship="label">
                                            <Button
                                                icon={<Edit20Regular />}
                                                onClick={() => handleEdit(project.id)}
                                                appearance="subtle"
                                            />
                                        </Tooltip>
                                        <Tooltip content="Delete Project" relationship="label">
                                            <Button
                                                icon={<Delete20Regular />}
                                                onClick={() => handleDelete(project.id)}
                                                appearance="subtle"
                                            />
                                        </Tooltip>
                                    </td>
                                </tr>
                            ))}
                        </tbody>
                    </table>
                )}
            </div>
        </Wrapper>
    );
};

export default ProjectHome;
