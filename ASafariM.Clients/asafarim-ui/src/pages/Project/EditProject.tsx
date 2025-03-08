import React, { useEffect, useState } from "react";
import { IField } from "@/interfaces/IField";
import ViewForm from "@/components/crud/ViewForm";
import { getVisibilityLabel, getStatusLabel } from "@/interfaces/ProjectEnums";
import { IProject } from "@/interfaces/IProject";
import { useParams } from "react-router-dom";
import dashboardServices from "@/api/entityServices";
import Loading from "@/components/Loading/Loading";
import Wrapper from "@/layout/Wrapper/Wrapper";
import Notification from "@/components/Notification/Notification";

const EditProject: React.FC = () => {
  const [project, setProject] = useState<IProject | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const { id } = useParams();

  useEffect(() => {
    if (!id) {
      setError("Invalid project ID");
      setLoading(false);
      return;
    }

    const fetchProject = async () => {
      try {
        const response = await dashboardServices.fetchEntityById("project",id);
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

  useEffect(() => {
    if (!project) return;
    console.log(project);   
  }, [project]);

  const fields: IField[] = [
    { name: "name", label: "Name", type: "text" },
    { name: "description", label: "Description", type: "textarea" },
    { name: "startDate", label: "Start Date", type: "date" },
    { name: "endDate", label: "End Date", type: "date" },
    { name: "budget", label: "Budget", type: "number" },
    { name: "visibilityLabel", label: "Visibility", type: "text" },
    { name: "statusLabel", label: "Status", type: "text" },
  ];

  const transformProject = (project: IProject | null) => {
    if (!project) {
      return {
        name: ["Loading..."],
        description: [""],
        startDate: [""],
        endDate: [""],
        budget: [""],
        visibilityLabel: [""],
        statusLabel: [""],
      };
    }

    return {
      name: [project.name ?? "No Name Available"],
      description: [project.description ?? "No Description"],
      startDate: [
        project.startDate
          ? new Date(project.startDate).toLocaleDateString()
          : "N/A",
      ],
      endDate: [
        project.endDate
          ? new Date(project.endDate).toLocaleDateString()
          : "N/A",
      ],
      budget: [project.budget?.toLocaleString() || "0"],
      visibilityLabel: [getVisibilityLabel(project.visibility ?? 0)],
      statusLabel: [getStatusLabel(project.status ?? 0)],
    };
  };

  if (loading)
    return (
      <Wrapper>
        <Loading />
      </Wrapper>
    );
  if (error)
    return (
      <Wrapper>
        <Notification type="error" text={error} />
      </Wrapper>
    );
  if (!project)
    return (
      <Wrapper>
        <Notification type="warning" text="Project not found" />
      </Wrapper>
    );

  return (
    <ViewForm
      entityName="Project"
      fields={fields}
      data={transformProject(project)}
    />
  );
};

export default EditProject;
