import { useEffect, useState } from "react";
import Wrapper from "../../layout/Wrapper";
import { Button, Toolbar, Tooltip } from "@fluentui/react-components";
import {
  Edit20Regular,
  Delete20Regular,
  Eye20Regular,
  AppsAddIn24Regular as AddNewIcon,
  EyeOff20Regular,
  People20Regular,
  Earth20Regular,
  LockClosed20Regular,
} from "@fluentui/react-icons";
import { useNavigate } from "react-router-dom";
import { IProject } from "../../interfaces/IProject";
import Notification from "@/components/Notification/Notification";
import { logger } from "@/utils/logger";
import dashboardServices from "@/api/entityServices";
import { useAuth } from '@/contexts/AuthContext';

const ProjectHome: React.FC = () => {
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [notification, setNotification] = useState<{type: string, message: string} | null>(null);
  const [projects, setProjects] = useState<IProject[]>([]);
  const [isMobile, setIsMobile] = useState(window.innerWidth < 768);
  const navigate = useNavigate();
  const { authenticated, authenticatedUser } = useAuth();

  // Function to check if user is admin
  const isAdmin = authenticatedUser?.role === "Admin" || 
                 authenticatedUser?.role === "SuperAdmin" || 
                 authenticatedUser?.isAdmin === true;

  // Function to check if user is the owner of a project
  const isProjectOwner = (projectOwnerId: string) => {
    return authenticatedUser?.id === projectOwnerId;
  };

  // Function to determine if user can edit/delete a project
  const canModifyProject = (projectOwnerId: string) => {
    return authenticated && (isAdmin || isProjectOwner(projectOwnerId));
  };

  // Function to determine if user can view sensitive project details
  const canViewSensitiveDetails = (project: IProject) => {
    // Admin and project owner can always see details
    if (isAdmin || isProjectOwner(project.ownerId)) {
      return true;
    }

    // For public projects, everyone can see details
    if (project.visibility === 0) { // Public
      return true;
    }

    // For private and members-only projects, only authenticated users with proper access can see
    return false;
  };

  // Check for notification from sessionStorage (e.g., when redirected from AddProject)
  useEffect(() => {
    const storedNotification = sessionStorage.getItem('projectNotification');
    if (storedNotification) {
      try {
        const parsedNotification = JSON.parse(storedNotification);
        // Ensure type and message are present
        if (parsedNotification.type && parsedNotification.message) {
          setNotification({
            type: parsedNotification.type,
            message: parsedNotification.message
          });
          // Remove the notification from sessionStorage after displaying it
          sessionStorage.removeItem('projectNotification');
        }
      } catch (e) {
        logger.error('Error parsing notification from sessionStorage:', e);
      }
    }
  }, []);

  // Add resize listener for responsive behavior
  useEffect(() => {
    const handleResize = () => {
      setIsMobile(window.innerWidth < 768);
    };

    window.addEventListener("resize", handleResize);
    return () => window.removeEventListener("resize", handleResize);
  }, []);

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
    // Check if user is authenticated
    if (!authenticated) {
      setError("You must be logged in to delete projects");
      return;
    }
    
    // Find the project to check ownership
    const projectToDelete = projects.find(p => p.id === id);
    if (!projectToDelete) {
      setError("Project not found");
      return;
    }
    
    // Check if user has permission to delete
    if (!isAdmin && !isProjectOwner(projectToDelete.ownerId)) {
      setError("You don't have permission to delete this project");
      return;
    }
    
    if (window.confirm("Are you sure you want to delete this project?")) {
      try {
        logger.info(`Attempting to delete project with id: ${id}`);
        await dashboardServices.deleteEntity("projects", id);
        logger.info(`Successfully deleted project with id: ${id}`);
        fetchProjects();
      } catch (error) {
        logger.error(`Failed to delete project: ${error}`);
        setError("Failed to delete project. Please try again later.");
      }
    }
  };

  const calculateDaysActive = (startDate: Date, endDate?: Date) => {
    const today = new Date();

    // If the project has an end date and it's in the past (project is expired)
    if (endDate && new Date(endDate) < today) {
      // Calculate days between start date and end date
      return Math.ceil(
        (new Date(endDate).getTime() - startDate.getTime()) / (1000 * 3600 * 24)
      );
    }

    // Otherwise, calculate days between start date and today
    return Math.ceil(
      (today.getTime() - startDate.getTime()) / (1000 * 3600 * 24)
    );
  };

  const calculateDaysRemaining = (endDate: Date | undefined) => {
    if (!endDate) return null;
    const today = new Date();
    return Math.ceil(
      (new Date(endDate).getTime() - today.getTime()) / (1000 * 3600 * 24)
    );
  };

  const getStatusLabel = (status: number | undefined) => {
    switch (status) {
      case 0:
        return "In Progress";
      case 1:
        return "Completed";
      case 2:
        return "Cancelled";
      case 3:
        return "Paused";
      case 4:
        return "Extended";
      default:
        return "Unknown";
    }
  };

  // This function is replaced by getVisibilityIcon for display purposes
  // but kept for reference and potential future use
  /* 
  const getVisibilityLabel = (visibility: number | undefined) => {
    switch (visibility) {
      case 0:
        return "Public";
      case 1:
        return "Members Only";
      case 2:
        return "Private";
      default:
        return "Unknown";
    }
  };
  */

  const getVisibilityIcon = (visibility: number | undefined) => {
    switch (visibility) {
      case 0: // Public
        return (
          <Tooltip content="Public - Visible to everyone" relationship="label">
            <span className="flex items-center">
              <Earth20Regular className="text-green-500" />
            </span>
          </Tooltip>
        );
      case 1: // Members Only
        return (
          <Tooltip content="Members Only - Visible to project members" relationship="label">
            <span className="flex items-center">
              <People20Regular className="text-blue-500" />
            </span>
          </Tooltip>
        );
      case 2: // Private
        return (
          <Tooltip content="Private - Only visible to owner and admins" relationship="label">
            <span className="flex items-center">
              <LockClosed20Regular className="text-red-500" />
            </span>
          </Tooltip>
        );
      default:
        return (
          <Tooltip content="Unknown visibility" relationship="label">
            <span className="flex items-center">
              <EyeOff20Regular className="text-gray-500" />
            </span>
          </Tooltip>
        );
    }
  };

  // Format days remaining with expiration message
  const formatDaysRemaining = (daysRemaining: number | null) => {
    if (daysRemaining === null) return "Not set";

    if (daysRemaining >= 0) {
      return daysRemaining.toString();
    } else {
      // Project is expired
      const daysAgo = Math.abs(daysRemaining);

      if (daysAgo >= 730) {
        // More than 2 years (approximation)
        const years = Math.floor(daysAgo / 365);
        const remainingDays = daysAgo % 365;
        return `Expired (${years} ${
          years === 1 ? "year" : "years"
        } and ${remainingDays} ${remainingDays === 1 ? "day" : "days"} ago)`;
      } else if (daysAgo >= 365) {
        // More than 1 year
        const years = Math.floor(daysAgo / 365);
        const remainingDays = daysAgo % 365;
        return `Expired (${years} year and ${remainingDays} ${
          remainingDays === 1 ? "day" : "days"
        } ago)`;
      } else {
        return `Expired (${daysAgo} ${daysAgo === 1 ? "day" : "days"} ago)`;
      }
    }
  };

  // Format days active to show years and days when appropriate
  const formatDaysActive = (daysActive: number | null) => {
    if (daysActive === null) return "Not set";

    if (daysActive < 365) {
      return `${daysActive} ${daysActive === 1 ? "day" : "days"}`;
    } else if (daysActive < 730) {
      // Between 1 and 2 years
      const years = Math.floor(daysActive / 365);
      const remainingDays = daysActive % 365;

      if (remainingDays === 0) {
        return `${years} year`;
      } else {
        return `${years} year, ${remainingDays} ${
          remainingDays === 1 ? "day" : "days"
        }`;
      }
    } else {
      // 2 or more years
      const years = Math.floor(daysActive / 365);
      const remainingDays = daysActive % 365;

      if (remainingDays === 0) {
        return `${years} years`;
      } else {
        return `${years} years, ${remainingDays} ${
          remainingDays === 1 ? "day" : "days"
        }`;
      }
    }
  };

  // Render project card for mobile view
  const renderProjectCard = (project: IProject) => {
    return (
      <div
        key={project.id}
        className="bg-white dark:bg-gray-800 rounded-lg shadow-md p-4 mb-4 border border-gray-200 dark:border-gray-700"
      >
        <h3 className="text-lg font-semibold mb-2">{project.name}</h3>

        <div className="grid grid-cols-2 gap-2 mb-3">
          <div>
            <p className="text-sm text-gray-500 dark:text-gray-400">Status</p>
            <p>{getStatusLabel(project.status)}</p>
          </div>
          <div>
            <p className="text-sm text-gray-500 dark:text-gray-400">
              Visibility
            </p>
            <div className="flex items-center">
              {getVisibilityIcon(project.visibility)}
            </div>
          </div>
        </div>

        <div className="grid grid-cols-2 gap-2 mb-3">
          <div>
            <p className="text-sm text-gray-500 dark:text-gray-400">
              Start Date
            </p>
            <p
              className={`p-2 ${!canViewSensitiveDetails(project) ? "opacity-50 blur-sm" : ""}`}
            >
              {project.startDate
                ? new Date(project.startDate).toLocaleDateString()
                : "Not set"}
            </p>
          </div>
          <div>
            <p className="text-sm text-gray-500 dark:text-gray-400">End Date</p>
            <p>
              {project.endDate
                ? new Date(project.endDate).toLocaleDateString()
                : "Not set"}
            </p>
          </div>
        </div>

        <div className="grid grid-cols-2 gap-2 mb-4">
          <div>
            <p className="text-sm text-gray-500 dark:text-gray-400">
              Days Active
            </p>
            <p
              className={`p-1 text-center font-bold rounded ${
                project.startDate
                  ? calculateDaysActive(
                      new Date(project.startDate),
                      project.endDate
                    ) < 0
                    ? "bg-red-300"
                    : calculateDaysActive(
                        new Date(project.startDate),
                        project.endDate
                      ) < 30
                    ? "bg-yellow-800"
                    : "bg-green-100"
                  : "bg-gray-100"
              } ${!canViewSensitiveDetails(project) ? "opacity-50 blur-sm" : ""}`}
            >
              {project.startDate
                ? formatDaysActive(
                    calculateDaysActive(
                      new Date(project.startDate),
                      project.endDate
                    )
                  )
                : "Not set"}
            </p>
          </div>
          <div>
            <p className="text-sm text-gray-500 dark:text-gray-400">
              Days Left
            </p>
            <p
              className={`p-1 text-center font-bold ${
                project.endDate
                  ? calculateDaysRemaining(project.endDate) !== null
                    ? calculateDaysRemaining(project.endDate)! < 0
                      ? "bg-red-300"
                      : calculateDaysRemaining(project.endDate)! < 30
                      ? "bg-yellow-800"
                      : "bg-green-100"
                    : "bg-gray-100"
                  : "bg-gray-100"
              } ${!canViewSensitiveDetails(project) ? "opacity-50 blur-sm" : ""}`}
            >
              {project.endDate
                ? calculateDaysRemaining(project.endDate) !== null
                  ? formatDaysRemaining(calculateDaysRemaining(project.endDate))
                  : "Error"
                : "Not set"}
            </p>
          </div>
        </div>

        <div className="flex justify-center space-x-2 pt-2 border-t border-gray-200 dark:border-gray-700">
          <Tooltip content="View Project" relationship="label">
            <Button
              icon={<Eye20Regular />}
              onClick={() => handleView(project.id)}
              appearance="subtle"
              className="bg-teal-100 hover:bg-teal-200 dark:bg-transparent dark:hover:bg-teal-900 text-teal-700 dark:text-teal-400 p-2 rounded-md border border-teal-200 dark:border-teal-800"
              style={{
                color: "var(--teal-700, #0f766e) !important",
                backgroundColor: "var(--teal-100, #ccfbf1) !important",
                fontWeight: "bold !important",
              }}
              aria-label="View Project"
            >
              <span
                className="ml-1 text-xs sm:text-sm font-medium"
                style={{
                  color: "var(--teal-700, #0f766e) !important",
                  fontWeight: "bold !important",
                }}
              >
                View
              </span>
            </Button>
          </Tooltip>
          {canModifyProject(project.ownerId) && (
            <Tooltip content="Edit Project" relationship="label">
              <Button
                icon={<Edit20Regular />}
                onClick={() => handleEdit(project.id)}
                appearance="subtle"
                className="bg-blue-100 hover:bg-blue-200 dark:bg-transparent dark:hover:bg-blue-900 text-blue-700 dark:text-blue-400 p-2 rounded-md border border-blue-200 dark:border-blue-800"
                style={{
                  color: "var(--blue-700, #1d4ed8) !important",
                  backgroundColor: "var(--blue-100, #dbeafe) !important",
                  fontWeight: "bold !important",
                }}
                aria-label="Edit Project"
              >
                <span
                  className="ml-1 text-xs sm:text-sm font-medium"
                  style={{
                    color: "var(--blue-700, #1d4ed8) !important",
                    fontWeight: "bold !important",
                  }}
                >
                  Edit
                </span>
              </Button>
            </Tooltip>
          )}
          {canModifyProject(project.ownerId) && (
            <Tooltip content="Delete Project" relationship="label">
              <Button
                icon={<Delete20Regular />}
                onClick={() => handleDelete(project.id)}
                appearance="subtle"
                className="bg-red-100 hover:bg-red-200 dark:bg-transparent dark:hover:bg-red-900 text-red-700 dark:text-red-400 p-2 rounded-md border border-red-200 dark:border-red-800"
                style={{
                  color: "var(--red-700, #b91c1c) !important",
                  backgroundColor: "var(--red-100, #fee2e2) !important",
                  fontWeight: "bold !important",
                }}
                aria-label="Delete Project"
              >
                <span
                  className="ml-1 text-xs sm:text-sm font-medium"
                  style={{
                    color: "var(--red-700, #b91c1c) !important",
                    fontWeight: "bold !important",
                  }}
                >
                  Delete
                </span>
              </Button>
            </Tooltip>
          )}
        </div>
      </div>
    );
  };

  if (loading) {
    return (
      <Wrapper header={headerBlock}>
        <div className="p-4">Loading projects...</div>
      </Wrapper>
    );
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

  if (notification) {
    return (
      <Wrapper header={headerBlock}>
        <div className="p-4">
          <Notification 
            type={notification.type} 
            text={notification.message} 
            data-testid={`notification-${notification.type}`} 
          />
        </div>
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
        ) : isMobile ? (
          // Mobile card view
          <div className="space-y-4">
            {projects.map((project) => renderProjectCard(project))}
          </div>
        ) : (
          // Desktop table view with responsive design
          <div className="overflow-x-auto">
            <table className="w-full shadow-md rounded-lg">
              <thead className="bg-gray-100 dark:bg-gray-800">
                <tr>
                  <th className="p-2 text-left font-bold">Project Name</th>
                  <th className="p-2 text-left font-bold">Status</th>
                  <th className="p-2 text-left font-bold">Visibility</th>
                  <th className="p-2 text-left font-bold">Start Date</th>
                  <th className="p-2 text-center font-bold">Days Active</th>
                  <th className="p-2 text-center font-bold">Days Left</th>
                  <th className="p-2 text-center font-bold">Actions</th>
                </tr>
              </thead>
              <tbody className="bg-white dark:bg-gray-700">
                {projects?.map((project) => (
                  <tr key={project.id} className="border-t">
                    <td className="p-2">{project.name}</td>
                    <td className="p-2">{getStatusLabel(project.status)}</td>
                    <td className="p-2">{getVisibilityIcon(project.visibility)}</td>
                    <td
                      className={`p-2 ${!canViewSensitiveDetails(project) ? "opacity-50 blur-sm" : ""}`}
                    >
                      {project.startDate
                        ? new Date(project.startDate).toLocaleDateString()
                        : "Not set"}
                    </td>
                    <td
                      className={`p-2 text-center font-bold ${
                        project.startDate
                          ? calculateDaysActive(
                              new Date(project.startDate),
                              project.endDate
                            ) < 0
                            ? "bg-red-300"
                            : calculateDaysActive(
                                new Date(project.startDate),
                                project.endDate
                              ) < 30
                            ? "bg-yellow-800"
                            : "bg-green-100"
                          : "bg-gray-100"
                      } ${!canViewSensitiveDetails(project) ? "opacity-50 blur-sm" : ""}`}
                    >
                      {project.startDate
                        ? formatDaysActive(
                            calculateDaysActive(
                              new Date(project.startDate),
                              project.endDate
                            )
                          )
                        : "Not set"}
                    </td>
                    <td
                      className={`p-2 text-center font-bold ${
                        project.endDate
                          ? calculateDaysRemaining(project.endDate) !== null
                            ? calculateDaysRemaining(project.endDate)! < 0
                              ? "bg-red-300"
                              : calculateDaysRemaining(project.endDate)! < 30
                              ? "bg-yellow-800"
                              : "bg-green-100"
                            : "bg-gray-100"
                          : "bg-gray-100"
                      } ${!canViewSensitiveDetails(project) ? "opacity-50 blur-sm" : ""}`}
                    >
                      {project.endDate
                        ? calculateDaysRemaining(project.endDate) !== null
                          ? formatDaysRemaining(
                              calculateDaysRemaining(project.endDate)
                            )
                          : "Error"
                        : "Not set"}
                    </td>
                    <td className="p-2 text-center">
                      <div className="flex justify-center space-x-1">
                        <Tooltip content="View Project" relationship="label">
                          <Button
                            icon={<Eye20Regular />}
                            onClick={() => handleView(project.id)}
                            appearance="subtle"
                            className="bg-teal-100 hover:bg-teal-200 dark:bg-transparent dark:hover:bg-teal-900 text-teal-700 dark:text-teal-400 p-1 min-w-0 rounded-md border border-teal-200 dark:border-teal-800"
                            style={{
                              color: "var(--teal-700, #0f766e) !important",
                              backgroundColor:
                                "var(--teal-100, #ccfbf1) !important",
                              fontWeight: "bold !important",
                            }}
                            aria-label="View Project"
                          >
                            <span
                              className="hidden sm:inline ml-1 text-xs font-medium"
                              style={{
                                color: "var(--teal-700, #0f766e) !important",
                                fontWeight: "bold !important",
                              }}
                            >
                              View
                            </span>
                          </Button>
                        </Tooltip>
                        {canModifyProject(project.ownerId) && (
                          <Tooltip content="Edit Project" relationship="label">
                            <Button
                              icon={<Edit20Regular />}
                              onClick={() => handleEdit(project.id)}
                              appearance="subtle"
                              className="bg-blue-100 hover:bg-blue-200 dark:bg-transparent dark:hover:bg-blue-900 text-blue-700 dark:text-blue-400 p-1 min-w-0 rounded-md border border-blue-200 dark:border-blue-800"
                              style={{
                                color: "var(--blue-700, #1d4ed8) !important",
                                backgroundColor:
                                  "var(--blue-100, #dbeafe) !important",
                                fontWeight: "bold !important",
                              }}
                              aria-label="Edit Project"
                            >
                              <span
                                className="hidden sm:inline ml-1 text-xs font-medium"
                                style={{
                                  color: "var(--blue-700, #1d4ed8) !important",
                                  fontWeight: "bold !important",
                                }}
                              >
                                Edit
                              </span>
                            </Button>
                          </Tooltip>
                        )}
                        {canModifyProject(project.ownerId) && (
                          <Tooltip content="Delete Project" relationship="label">
                            <Button
                              icon={<Delete20Regular />}
                              onClick={() => handleDelete(project.id)}
                              appearance="subtle"
                              className="bg-red-100 hover:bg-red-200 dark:bg-transparent dark:hover:bg-red-900 text-red-700 dark:text-red-400 p-1 min-w-0 rounded-md border border-red-200 dark:border-red-800"
                              style={{
                                color: "var(--red-700, #b91c1c) !important",
                                backgroundColor:
                                  "var(--red-100, #fee2e2) !important",
                                fontWeight: "bold !important",
                              }}
                              aria-label="Delete Project"
                            >
                              <span
                                className="hidden sm:inline ml-1 text-xs font-medium"
                                style={{
                                  color: "var(--red-700, #b91c1c) !important",
                                  fontWeight: "bold !important",
                                }}
                              >
                                Delete
                              </span>
                            </Button>
                          </Tooltip>
                        )}
                      </div>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        )}
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
        ) : isMobile ? (
          // Mobile card view
          <div className="space-y-4">
            {projects.map((project) => renderProjectCard(project))}
          </div>
        ) : (
          // Desktop table view with responsive design
          <div className="overflow-x-auto">
            <table className="w-full shadow-md rounded-lg">
              <thead className="bg-gray-100 dark:bg-gray-800">
                <tr>
                  <th className="p-2 text-left font-bold">Project Name</th>
                  <th className="p-2 text-left font-bold">Status</th>
                  <th className="p-2 text-left font-bold">Visibility</th>
                  <th className="p-2 text-left font-bold">Start Date</th>
                  <th className="p-2 text-center font-bold">Days Active</th>
                  <th className="p-2 text-center font-bold">Days Left</th>
                  <th className="p-2 text-center font-bold">Actions</th>
                </tr>
              </thead>
              <tbody className="bg-white dark:bg-gray-700">
                {projects?.map((project) => (
                  <tr key={project.id} className="border-t">
                    <td className="p-2">{project.name}</td>
                    <td className="p-2">{getStatusLabel(project.status)}</td>
                    <td className="p-2">{getVisibilityIcon(project.visibility)}</td>
                    <td
                      className={`p-2 ${!canViewSensitiveDetails(project) ? "opacity-50 blur-sm" : ""}`}
                    >
                      {project.startDate
                        ? new Date(project.startDate).toLocaleDateString()
                        : "Not set"}
                    </td>
                    <td
                      className={`p-2 text-center font-bold ${
                        project.startDate
                          ? calculateDaysActive(
                              new Date(project.startDate),
                              project.endDate
                            ) < 0
                            ? "bg-red-300"
                            : calculateDaysActive(
                                new Date(project.startDate),
                                project.endDate
                              ) < 30
                            ? "bg-yellow-800"
                            : "bg-green-100"
                          : "bg-gray-100"
                      } ${!canViewSensitiveDetails(project) ? "opacity-50 blur-sm" : ""}`}
                    >
                      {project.startDate
                        ? formatDaysActive(
                            calculateDaysActive(
                              new Date(project.startDate),
                              project.endDate
                            )
                          )
                        : "Not set"}
                    </td>
                    <td
                      className={`p-2 text-center font-bold ${
                        project.endDate
                          ? calculateDaysRemaining(project.endDate) !== null
                            ? calculateDaysRemaining(project.endDate)! < 0
                              ? "bg-red-300"
                              : calculateDaysRemaining(project.endDate)! < 30
                              ? "bg-yellow-800"
                              : "bg-green-100"
                            : "bg-gray-100"
                          : "bg-gray-100"
                      } ${!canViewSensitiveDetails(project) ? "opacity-50 blur-sm" : ""}`}
                    >
                      {project.endDate
                        ? calculateDaysRemaining(project.endDate) !== null
                          ? formatDaysRemaining(
                              calculateDaysRemaining(project.endDate)
                            )
                          : "Error"
                        : "Not set"}
                    </td>
                    <td className="p-2 text-center">
                      <div className="flex justify-center space-x-1">
                        <Tooltip content="View Project" relationship="label">
                          <Button
                            icon={<Eye20Regular />}
                            onClick={() => handleView(project.id)}
                            appearance="subtle"
                            className="bg-teal-100 hover:bg-teal-200 dark:bg-transparent dark:hover:bg-teal-900 text-teal-700 dark:text-teal-400 p-1 min-w-0 rounded-md border border-teal-200 dark:border-teal-800"
                            style={{
                              color: "var(--teal-700, #0f766e) !important",
                              backgroundColor:
                                "var(--teal-100, #ccfbf1) !important",
                              fontWeight: "bold !important",
                            }}
                            aria-label="View Project"
                          >
                            <span
                              className="hidden sm:inline ml-1 text-xs font-medium"
                              style={{
                                color: "var(--teal-700, #0f766e) !important",
                                fontWeight: "bold !important",
                              }}
                            >
                              View
                            </span>
                          </Button>
                        </Tooltip>
                        {canModifyProject(project.ownerId) && (
                          <Tooltip content="Edit Project" relationship="label">
                            <Button
                              icon={<Edit20Regular />}
                              onClick={() => handleEdit(project.id)}
                              appearance="subtle"
                              className="bg-blue-100 hover:bg-blue-200 dark:bg-transparent dark:hover:bg-blue-900 text-blue-700 dark:text-blue-400 p-1 min-w-0 rounded-md border border-blue-200 dark:border-blue-800"
                              style={{
                                color: "var(--blue-700, #1d4ed8) !important",
                                backgroundColor:
                                  "var(--blue-100, #dbeafe) !important",
                                fontWeight: "bold !important",
                              }}
                              aria-label="Edit Project"
                            >
                              <span
                                className="hidden sm:inline ml-1 text-xs font-medium"
                                style={{
                                  color: "var(--blue-700, #1d4ed8) !important",
                                  fontWeight: "bold !important",
                                }}
                              >
                                Edit
                              </span>
                            </Button>
                          </Tooltip>
                        )}
                        {canModifyProject(project.ownerId) && (
                          <Tooltip content="Delete Project" relationship="label">
                            <Button
                              icon={<Delete20Regular />}
                              onClick={() => handleDelete(project.id)}
                              appearance="subtle"
                              className="bg-red-100 hover:bg-red-200 dark:bg-transparent dark:hover:bg-red-900 text-red-700 dark:text-red-400 p-1 min-w-0 rounded-md border border-red-200 dark:border-red-800"
                              style={{
                                color: "var(--red-700, #b91c1c) !important",
                                backgroundColor:
                                  "var(--red-100, #fee2e2) !important",
                                fontWeight: "bold !important",
                              }}
                              aria-label="Delete Project"
                            >
                              <span
                                className="hidden sm:inline ml-1 text-xs font-medium"
                                style={{
                                  color: "var(--red-700, #b91c1c) !important",
                                  fontWeight: "bold !important",
                                }}
                              >
                                Delete
                              </span>
                            </Button>
                          </Tooltip>
                        )}
                      </div>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        )}
      </div>
    </Wrapper>
  );
};

export default ProjectHome;
