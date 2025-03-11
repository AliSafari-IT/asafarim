// src/pages/Project/AddProject.tsx
import AddForm from "../../components/crud/AddForm";
import { IField } from "@/interfaces/IField";
import Wrapper from "@/layout/Wrapper/Wrapper";
import entityServices from "@/api/entityServices";
import { logger } from "@/utils/logger";
import { jwtDecode } from "jwt-decode";
import { useState } from "react";
import Notification from "@/components/Notification/Notification";

interface JwtPayload {
  nameid?: string;
  unique_name?: string;
  role?: string;
  exp?: number;
}

const AddProject: React.FC = () => {
  const [error, setError] = useState<string | null>(null);

  // Get user ID from JWT token
  const getUserId = () => {
    try {
      const token = localStorage.getItem('auth') ? JSON.parse(localStorage.getItem('auth')!).token : null;
      if (!token) return null;

      const decoded = jwtDecode<JwtPayload>(token);
      return decoded.nameid; // User ID is stored in nameid claim
    } catch (error) {
      logger.error("Error decoding JWT token:"+ error);
      return null;
    }
  };

  const fields: IField[] = [
    {
      name: "name",
      label: "Project Name",
      type: "text",
      required: true,
      placeholder: "Enter project name",
    },
    {
      name: "description",
      label: "Description",
      type: "textarea",
      placeholder: "Enter project description",
    },
    { name: "startdate", label: "Start Date", type: "date", required: true },
    { name: "enddate", label: "End Date", type: "date" },
    {
      name: "budget",
      label: "Budget",
      type: "number",
      placeholder: "Enter project budget",
    },
    {
      name: "visibility",
      label: "Visibility",
      type: "select",
      required: true,
      options: [
        { value: "0", label: "Public" },
        { value: "1", label: "Members Only" },
        { value: "2", label: "Private" },
      ],
    },
    {
      name: "status",
      label: "Status",
      type: "select",
      required: true,
      options: [
        { value: "0", label: "In Progress" },
        { value: "1", label: "Completed" },
        { value: "2", label: "Cancelled" },
        { value: "3", label: "Paused" },
        { value: "4", label: "Extended" },
      ],
    },
  ];

  return (
    <Wrapper>
      {error && <Notification type="error" text={error} />}
      
      <AddForm
        entityName={"Project"}
        fields={fields}
        onCancel={() => {
          window.history.back();
        }}
        submitHandler={async (formData: FormData) => {
          try {
            setError(null); // Clear any previous errors
            
            const userId = getUserId();
            if (!userId) {
              logger.error("No authenticated user found");
              setError("You must be logged in to create a project");
              throw new Error("You must be logged in to create a project");
            }

            const projectData = {
              Name: formData.get("name")?.toString() || '',
              Description: formData.get("description")?.toString() || '',
              StartDate: new Date(formData.get("startdate")?.toString() || '').toISOString(),
              EndDate: formData.get("enddate") 
                ? new Date(formData.get("enddate")?.toString() || '').toISOString()
                : new Date(0).toISOString(),
              Budget: parseFloat(formData.get("budget")?.toString() || '0'),
              Visibility: parseInt(formData.get("visibility")?.toString() || '0', 10),
              Status: parseInt(formData.get("status")?.toString() || '0', 10),
              OwnerId: userId
            };

            logger.info("Sending project data: " + JSON.stringify(projectData));
            const result = await entityServices.addEntity(
              "project",
              projectData
            );

            if (result) {
              logger.info("Project created successfully: " + JSON.stringify(result));
              window.location.href = "/projects";
            } else {
              throw new Error("Failed to create project - no result returned");
            }
          } catch (error) {
            logger.error("Error creating project: " + error);
            setError(error instanceof Error ? error.message : "Failed to create project");
            throw error;
          }
        }}
      />
    </Wrapper>
  );
};

export default AddProject;
