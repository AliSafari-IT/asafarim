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
import useAuth from "@/hooks/useAuth";
import { useTheme } from "@fluentui/react";

const ViewProject: React.FC = () => {
  const navigate = useNavigate();
  const isAuthenticated = useAuth()?.authenticated;
  const theme = useTheme();

  useEffect(() => {
    if (!isAuthenticated) {
      navigate("/login", { replace: true });
    }
  }, [isAuthenticated, navigate]);

  const [project, setProject] = useState<IProject | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const { id } = useParams();

  // Styles using theme variables
  const containerStyles = {
    root: {
      maxWidth: 800,
      width: "95%",
      margin: "0 auto",
      padding: 20,
      backgroundColor: "var(--background-color)",
      borderRadius: "var(--border-radius-large)",
      boxShadow: "var(--shadow-medium)",
      selectors: {
        "@media screen and (max-width: 768px)": {
          width: "100%",
          padding: 15,
        },
      },
    },
  };

  const headerStyles = {
    root: {
      color: "var(--text-color)",
      fontSize: theme.fonts.xxLarge.fontSize,
      fontWeight: 600,
      marginBottom: 20,
      borderBottom: "1px solid var(--border-color)",
      paddingBottom: 10,
      selectors: {
        "@media screen and (max-width: 768px)": {
          fontSize: theme.fonts.xLarge.fontSize,
        },
      },
    },
  };

  const fieldContainerStyles = {
    backgroundColor: "var(--surface-color)",
    border: "1px solid var(--border-color)",
    borderRadius: "var(--border-radius-medium)",
    padding: "var(--spacing-medium)",
    marginBottom: "var(--spacing-medium)",
    transition: "all 0.3s ease",
    ":hover": {
      boxShadow: "var(--shadow-small)",
    },
  };

  const labelStyles = {
    color: "var(--text-color)",
    fontSize: "var(--font-size-medium)",
    fontWeight: "500",
    marginBottom: "var(--spacing-small)",
  };

  const valueStyles = {
    color: "var(--text-color-secondary)",
    fontSize: "var(--font-size-medium)",
    padding: "var(--spacing-small)",
    backgroundColor: "var(--background-color-secondary)",
    borderRadius: "var(--border-radius-small)",
    wordBreak: "break-word" as const,
  };

  // Fetch project data on component mount
  useEffect(() => {
    if (!id) {
      setError("Invalid project ID");
      setLoading(false);
      return;
    }

    const fetchProject = async () => {
      try {
        const response = await dashboardServices.fetchProject(id);
        setProject(response);
      } catch (error) {
        console.error("Error fetching project:", error);
        setError("Failed to fetch project");
      } finally {
        setLoading(false);
      }
    };

    fetchProject();
  }, [id]);

  // Log project data when it changes
  useEffect(() => {
    if (!project) return;
    console.log(project);
  }, [project]);

  // Define form fields
  const fields: IField[] = [
    { name: "name", label: "Name", type: "text" },
    { name: "description", label: "Description", type: "textarea" },
    { name: "startDate", label: "Start Date", type: "date" },
    { name: "endDate", label: "End Date", type: "date" },
    { name: "budget", label: "Budget", type: "number" },
    { name: "visibilityLabel", label: "Visibility", type: "text" },
    { name: "statusLabel", label: "Status", type: "text" },
  ];

  // Render loading state
  if (loading) {
    return (
      <Wrapper>
        <Stack styles={containerStyles}>
          <Loading />
        </Stack>
      </Wrapper>
    );
  }

  // Render error state
  if (error) {
    return (
      <Wrapper>
        <Stack styles={containerStyles}>
          <Notification type="error" text={error} />
        </Stack>{" "}
      </Wrapper>
    );
  }

  // Render project not found state
  if (!project) {
    return (
      <Wrapper>
        <Stack styles={containerStyles}>
          <Notification type="warning" text="Project not found" />
        </Stack>
      </Wrapper>
    );
  }

  // First, let's create a type-safe way to access project properties
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
        return getVisibilityLabel(project.Visibility ?? 0);
      case "statusLabel":
        return getStatusLabel(project.Status ?? 0);
      default:
        return "Information not available";
    }
  };

  return (
    <Wrapper>
      <Stack styles={containerStyles}>
        <Text as="h1" style={headerStyles.root}>
          View Project Details
        </Text>
        <div className="view-entity-form">
          {fields.map((field) => (
            <div key={field.name} style={fieldContainerStyles}>
              {field.label && (
                <Text as="label" style={labelStyles}>
                  {field.label}:
                </Text>
              )}
              <div style={valueStyles}>
                {field.type === "file" ? (
                  <a
                    href={getFieldValue(field)}
                    target="_blank"
                    rel="noopener noreferrer"
                    className="link-primary"
                  >
                    View File
                  </a>
                ) : Array.isArray(getFieldValue(field)) ? (
                  <ul className="list-inside">
                    {(getFieldValue(field) as unknown as any[])?.map(
                      (item, index: number) => (
                        <li key={index}>{item}</li>
                      )
                    )}
                  </ul>
                ) : (
                  <span>{getFieldValue(field)}</span>
                )}
              </div>
            </div>
          ))}
        </div>
      </Stack>
    </Wrapper>
  );
};

export default ViewProject;
