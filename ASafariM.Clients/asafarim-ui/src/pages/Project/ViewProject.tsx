import React, { useEffect, useState } from "react";
import { IField } from "@/interfaces/IField";
import { getVisibilityLabel, getStatusLabel } from "@/interfaces/ProjectEnums";
import { IProject } from "@/interfaces/IProject";
import { useNavigate, useParams } from "react-router-dom";
import dashboardServices from "@/api/entityServices";
import Loading from "@/components/Loading/Loading";
import Wrapper from "@/layout/Wrapper/Wrapper";
import Notification from "@/components/Notification/Notification";
import { Stack } from "@fluentui/react/lib/Stack";
import { Text } from "@fluentui/react";
import { ActionButton } from "@fluentui/react/lib/Button";
import { ArrowLeft24Regular, Edit20Regular } from "@fluentui/react-icons";
import useAuth from "@/hooks/useAuth";
import Toolbar from "@/components/Toolbars/Toolbar";

const ViewProject: React.FC = () => {
  const navigate = useNavigate();
  const isAuthenticated = useAuth()?.authenticated;

  const [project, setProject] = useState<IProject | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [showAuthErrorNotification, setShowAuthErrorNotification] = useState(false);
  const { id } = useParams();

  const [repoLinks, setRepoLinks] = useState<string[]>([]);

  // Check authentication on component mount
  useEffect(() => {
    if (!isAuthenticated) {
      setShowAuthErrorNotification(true);
      setLoading(false);
      
      // Redirect to login after 3 seconds
      const timer = setTimeout(() => {
        navigate("/login", { state: { returnUrl: `/projects/view/${id}` } });
      }, 3000);
      
      return () => clearTimeout(timer);
    }
  }, [isAuthenticated, navigate, id]);

  useEffect(() => {
    if (!id) {
      setError("Invalid project ID");
      setLoading(false);
      return;
    }

    if (!isAuthenticated) {
      setShowAuthErrorNotification(true);
      setLoading(false);
      return;
    }

    const fetchProjectData = async () => {
      try {
        const projectResponse = await dashboardServices.fetchEntityById(
          "project",
          id
        );
        setProject(projectResponse);

        // Fetch repo links
        try {
          const linksResponse = await dashboardServices.fetchEntityRepoLinks(
            "project",
            id
          );
          console.log('Repository links response:', JSON.stringify(linksResponse));
          setRepoLinks(linksResponse || []);
        } catch (linkError: any) {
          // Check if it's an authentication error (401)
          if (linkError?.response?.status === 401) {
            console.error("Authentication error fetching repository links:", linkError);
            // Redirect to login if not authenticated
            setShowAuthErrorNotification(true);
            setTimeout(() => {
              navigate("/login", { state: { returnUrl: `/projects/view/${id}` } });
            }, 3000);
            return;
          }
          // For other errors, just log them but continue showing the project
          console.error("Error fetching repository links:", linkError);
        }
      } catch (error: any) {
        console.error("Error fetching project data:", error);
        
        // Check for authentication errors
        if (error?.response?.status === 401) {
          setShowAuthErrorNotification(true);
          setTimeout(() => {
            navigate("/login", { state: { returnUrl: `/projects/view/${id}` } });
          }, 3000);
        } else {
          setError("Failed to fetch project data. Please try again later.");
        }
      } finally {
        setLoading(false);
      }
    };

    fetchProjectData();
  }, [id, isAuthenticated, navigate]);

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
            onDismiss={() => setError(null)}
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
          children={
            <>
              <ActionButton
                className="bg-lime-500 text-gray-700 hover:bg-lime-700  px-4 py-2 rounded-lg"
                iconProps={{ iconName: "Back" }}
                onClick={() => navigate(-1)}
              >
                <ArrowLeft24Regular className="mr-2" /> Back
              </ActionButton>
              <ActionButton
                className="bg-teal-500 dark:text-primary hover:bg-success dark:hover:bg-success text-[var(--text-primary)]  px-4 py-2 rounded-lg"
                onClick={() => navigate(`/projects/edit/${id}`)}
              >
                <Edit20Regular className="mr-2" /> Edit Project
              </ActionButton>
            </>
          }
          aria-label={""}
        />
      </div>
    </Wrapper>
  );
};

export default ViewProject;
