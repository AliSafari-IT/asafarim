import React, { useEffect, useState } from "react";
import { IField } from "@/interfaces/IField";
import { getVisibilityLabel, getStatusLabel } from "@/interfaces/ProjectEnums";
import { IProject } from "@/interfaces/IProject";
import { useNavigate, useParams } from "react-router-dom";
import Loading from "@/components/Loading/Loading";
import Wrapper from "@/layout/Wrapper/Wrapper";
import Notification from "@/components/Notification/Notification";
import { Stack } from "@fluentui/react/lib/Stack";
import { Text } from "@fluentui/react";
import { ActionButton } from "@fluentui/react/lib/Button";
import { ArrowLeft24Regular, Edit20Regular } from "@fluentui/react-icons";
import { useAuth } from '@/contexts/AuthContext';
import Toolbar from "@/components/Toolbars/Toolbar";
import { logger } from "@/utils/logger";
import entityServices from "@/api/entityServices";

const ViewProject: React.FC = () => {
  const navigate = useNavigate();
  const { id } = useParams();
  const { authenticated, authenticatedUser } = useAuth();

  const [project, setProject] = useState<IProject | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [showAuthErrorNotification, setShowAuthErrorNotification] =
    useState(false);

  const [repoLinks, setRepoLinks] = useState<string[]>([]);

  // Function to fetch repository links
  const fetchRepoLinks = async (projectId: string) => {
    try {
      logger.debug(
        `Attempting to fetch repository links for project ID: ${projectId}`
      );

      // Use the entityServices to fetch repository links
      const links = await entityServices.fetchEntityRepoLinks(
        "project",
        projectId
      );

      if (links && Array.isArray(links)) {
        setRepoLinks(links);
        logger.debug("Repository links fetched successfully:", links);
      } else if (links && links.$values) {
        // Handle .NET serialization format if needed
        setRepoLinks(links.$values);
        logger.debug(
          "Repository links fetched successfully (from $values):",
          links.$values
        );
      } else {
        logger.debug("No repository links found or empty response");
        setRepoLinks([]);
      }
    } catch (error) {
      logger.error("Error fetching repository links:", error);
      // Don't set error state for repository links - they're optional
      setRepoLinks([]);
    }
  };

  // Check authentication and project visibility on component mount
  useEffect(() => {
    // Check if project ID is valid
    if (!id) {
      setError("Invalid project ID");
      setLoading(false);
      return;
    }

    // -- COMMENTED OUT to avoid errors if tableExistsInDb doesn't exist --
    // const projectExists = async () => await entityServices.tableExistsInDb("project");
    // const getProjectResponse = async () => await entityServices.fetchEntityById("project", id);

    const fetchProjectData = async () => {
      // If you do have the function, uncomment these lines:
      // if (!(await projectExists())) {
      //   setError("Project table not found!");
      //   setLoading(false);
      //   return;
      // }

      logger.debug(`Fetching project data for project ID: ${id}`);
      try {
        // Direct call without tableExistsInDb check:
        const projectResponse = await entityServices.fetchEntityById(
          "project",
          id
        );

        // Check if project exists
        if (!projectResponse) {
          setError("Project not found");
          setLoading(false);
          return;
        }

        // Set the project data first
        setProject(projectResponse);

        // Always fetch repository links for public projects, regardless of authentication
        if (projectResponse.visibility === 0) {
          try {
            await fetchRepoLinks(id);
          } catch (error) {
            logger.error(
              "Error fetching repository links for public project:",
              error
            );
          }
        }
      } catch (error: any) {
        logger.error("Error fetching project data:", error);

        // Check for authentication errors
        if (error?.response?.status === 401) {
          setShowAuthErrorNotification(true);
          setTimeout(() => {
            navigate("/login", {
              state: { returnUrl: `/projects/view/${id}` },
            });
          }, 3000);
        } else {
          setError("Failed to fetch project data. Please try again later.");
        }
      } finally {
        setLoading(false);
      }
    };

    fetchProjectData();
  }, [id, authenticated, navigate, authenticatedUser]);

  // Now handle permission logic + fetch repo links for non-public
  useEffect(() => {
    const getRepoLinks = async () => {
      if (project && project.id) {
        await fetchRepoLinks(project.id);
      }
    };

    if (project && project.id) {
      // For public projects, we already fetched in fetchProjectData
      if (project.visibility === 0) {
        return; // done
      }

      // For non-public projects, check authentication
      if (project.visibility !== 0) {
        // Not public
        if (!authenticated) {
          setShowAuthErrorNotification(true);
          setError("Authentication required to view this project");

          // Redirect to login after 3 seconds
          const timer = setTimeout(() => {
            navigate("/login", {
              state: { returnUrl: `/projects/view/${id}` },
            });
          }, 4000);

          setLoading(false);
          return () => clearTimeout(timer);
        }

        // If user is authenticated but not admin or owner, check project visibility
        // If user’s real admin property is `isAdmin`, check that:
        const userIsAdmin = !!authenticatedUser?.isAdmin;
        // If user’s real admin property is `role === "Admin"`, do:
        // const userIsAdmin = authenticatedUser?.role === "Admin";

        if (
          project.visibility !== 0 && // Not public
          project.ownerId !== authenticatedUser?.id && // Not owner
          !userIsAdmin
        ) {
          // For members-only projects
          if (project.visibility === 1) {
            setError("You don't have permission to view this project");
            setLoading(false);
            return;
          }
          // For private
          if (project.visibility === 2) {
            setError("You don't have permission to view this project");
            setLoading(false);
            return;
          }
        }
        // If we get here, user is allowed, fetch links
        getRepoLinks();
      }
    }
  }, [project, authenticated, authenticatedUser, navigate, id]);

  // Define form fields
  const fields: IField[] = [
    { name: "name", label: "Project Name", type: "text" },
    { name: "description", label: "Description", type: "textarea" },
    { name: "startDate", label: "Start Date", type: "date" },
    { name: "endDate", label: "End Date", type: "date" },
    { name: "budget", label: "Budget", type: "number" },
    { name: "visibilityLabel", label: "Visibility", type: "text" },
    { name: "statusLabel", label: "Status", type: "text" },
  ];

  // Get field value dynamically
  const getFieldValue = (field: IField) => {
    if (!project) return "Loading...";

    switch (field.name) {
      case "name":
        return project.name || "No Name Available";
      case "description":
        return project.description || "No Description";
      case "startDate":
        return project.startDate
          ? new Date(project.startDate).toLocaleDateString()
          : "N/A";
      case "endDate":
        return project.endDate
          ? new Date(project.endDate).toLocaleDateString()
          : "N/A";
      case "budget":
        return project.budget?.toLocaleString() || "0";
      case "visibilityLabel":
        return getVisibilityLabel(project.visibility ?? 0);
      case "statusLabel":
        return getStatusLabel(project.status ?? 0);
      default:
        return "Information not available";
    }
  };

  // Remove the mock repository links approach and use the real API
  useEffect(() => {
    if (project && project.id) {
      // Always fetch repository links for public projects, regardless of authentication
      fetchRepoLinks(project.id);
    }
  }, [project]);

  // Show loading spinner
  if (loading) {
    return <Loading message="Loading project details..." />;
  }

  // Show auth error notification
  if (showAuthErrorNotification) {
    return (
      <Wrapper>
        <Stack className="max-w-5xl mx-auto p-8">
          <Notification
            text="Authentication required. You must be logged in to view project details. Redirecting to login page..."
            type="error"
            onDismiss={() => setShowAuthErrorNotification(false)}
          />
        </Stack>
      </Wrapper>
    );
  }

  // Show error message
  if (error) {
    return (
      <Wrapper>
        <Stack className="max-w-5xl mx-auto p-8">
          <Notification
            text={error}
            type="error"
            onDismiss={() => {
              setError(null);
              setShowAuthErrorNotification(false);
              navigate("/projects");
            }}
          />
        </Stack>
      </Wrapper>
    );
  }

  // Render project not found state
  if (!project) {
    return (
      <Wrapper>
        <Stack className="max-w-5xl mx-auto p-8">
          <Notification type="warning" text="Project not found" />
        </Stack>
      </Wrapper>
    );
  }

  const isPermitted =
    showAuthErrorNotification ||
    (authenticated &&
      (authenticatedUser?.role !== "Admin" ||
        authenticatedUser?.id !== project?.ownerId));

        return (
          <Wrapper>
            <div className="w-2/3 mx-auto p-6 md:p-10 bg-[var(--bg-primary)] shadow-lg rounded-xl">
              {/* Title */}
              <Text
                as="h1"
                className="text-[var(--text-primary)] text-2xl font-bold mb-6"
              >
                Project Details
              </Text>
      
              {/* Project Fields in Two Columns */}
              <div className="grid grid-cols-1 md:grid-cols-2 gap-6 mt-6">
                {fields.map((field) => (
                  <div
                    key={field.name}
                    className="p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md"
                  >
                    <Text
                      as="label"
                      className="block text-[var(--text-primary)] font-medium mb-2"
                    >
                      {field.label}:
                    </Text>
                    <Text className="text-[var(--text-secondary)] font-semibold">
                      {getFieldValue(field)}
                    </Text>
                  </div>
                ))}
              </div>
      
              {/* Repository Links Section */}
              {repoLinks.length > 0 && (
                <div className="mt-6 p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md">
                  <Text
                    as="h2"
                    className="text-[var(--text-primary)] text-xl font-bold mb-3"
                  >
                    Repository Links
                  </Text>
                  <ul className="list-disc list-inside">
                    {repoLinks.map((repo, index) => (
                      <li key={index}>
                        <a
                          href={repo}
                          target="_blank"
                          rel="noopener noreferrer"
                          className="text-teal-500 underline hover:text-teal-700"
                        >
                          {repo}
                        </a>
                      </li>
                    ))}
                  </ul>
                </div>
              )}
      
              {/* Buttons moved to the bottom */}
              <Toolbar
                className="flex justify-between items-center mt-8"
                aria-label=""
              >
                <>
                  <ActionButton
                    className="bg-lime-500 text-gray-700 hover:bg-lime-700  px-4 py-2 rounded-lg"
                    iconProps={{ iconName: "Back" }}
                    onClick={() => navigate(-1)}
                  >
                    <ArrowLeft24Regular className="mr-2" /> Back
                  </ActionButton>
      
                  {/* Only show Edit button for authenticated users who are admins or project owners */}
                  {authenticated &&
                    (authenticatedUser?.isAdmin ||
                      authenticatedUser?.id === project?.ownerId) && (
                      <ActionButton
                        className="bg-teal-500 dark:text-primary hover:bg-success dark:hover:bg-success text-[var(--text-primary)]  px-4 py-2 rounded-lg"
                        onClick={() => navigate(`/projects/edit/${id}`)}
                      >
                        <Edit20Regular className="mr-2" /> Edit Project
                      </ActionButton>
                    )}
                </>
              </Toolbar>
            </div>
          </Wrapper>
        );
      };
      
      export default ViewProject;
