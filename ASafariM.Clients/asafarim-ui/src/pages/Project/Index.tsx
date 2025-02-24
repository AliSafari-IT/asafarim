import { useEffect, useState } from "react";
import Wrapper from "../../layout/Wrapper/Wrapper";
import { Button, Toolbar, Tooltip } from "@fluentui/react-components";
import { Edit20Regular, Delete20Regular, Eye20Regular, AppsAddIn24Regular as AddNewIcon } from "@fluentui/react-icons";
import { useNavigate } from "react-router-dom";
import dashboardServices from "../../api/entityServices";
import { IProject } from "../../interfaces/IProject";
import Notification from "@/components/Notification/Notification";
import { logger } from "@/utils/logger";

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
            const data = await dashboardServices.fetchEntities("project");
            logger.info("Projects data received:" + JSON.stringify(data));
            if (Array.isArray(data)) {
                setProjects(data);
            } else {
                logger.error("Invalid data format received:" + JSON.stringify(data));
                setError("Invalid data format received from server");
            }
        } catch (err) {
            logger.error("Error fetching projects:" + JSON.stringify(err));
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

    const handleDelete = (id: string) => {
        if (window.confirm("Are you sure you want to delete this project?")) {
            console.log(`Delete project with id: ${id}`);
        }
    };

    const calculateDaysLeft = (startDate: Date) => {
        const today = new Date();
        return Math.ceil((today.getTime() - startDate.getTime()) / (1000 * 3600 * 24));
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
                                <th className="p-2 text-left">Description</th>
                                <th className="p-2 text-left">Start Date</th>
                                <th className="p-2 text-center">Days Active</th>
                                <th className="p-2 text-center">Actions</th>
                            </tr>
                        </thead>
                        <tbody>
                            {projects?.map((project) => (
                                <tr key={project.id} className="border-t">
                                    <td className="p-2">{project.name}</td>
                                    <td className="p-2">{project.description}</td>
                                    <td className="p-2">{new Date(project.startDate).toLocaleDateString()}</td>
                                    <td className={`p-2 text-center font-bold ${
                                        calculateDaysLeft(new Date(project.startDate)) < 0 
                                            ? "bg-danger" 
                                            : calculateDaysLeft(new Date(project.startDate)) < 30 
                                                ? "bg-warning" 
                                                : "bg-info"
                                    }`}>
                                        {calculateDaysLeft(new Date(project.startDate))}
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
