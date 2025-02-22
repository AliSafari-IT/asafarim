// src/pages/Project/AddProject.tsx
import AddForm from "../../components/crud/AddForm";
import { IField } from "@/interfaces/IField";
import Wrapper from "@/layout/Wrapper/Wrapper";
import entityServices from "@/api/entityServices";
import { logger } from "@/utils/logger";
import { jwtDecode } from "jwt-decode";

interface JwtPayload {
  nameid?: string;
  unique_name?: string;
  role?: string;
  exp?: number;
}

const AddProject: React.FC = () => {

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
    { name: "startDate", label: "Start Date", type: "date", required: true },
    { name: "endDate", label: "End Date", type: "date" },
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
        { value: "Public", label: "Public" },
        { value: "MembersOnly", label: "Members Only" },
        { value: "Private", label: "Private" },
      ],
    },
    {
      name: "status",
      label: "Status",
      type: "select",
      required: true,
      options: [
        { value: "InProgress", label: "In Progress" },
        { value: "Completed", label: "Completed" },
        { value: "Cancelled", label: "Cancelled" },
        { value: "Paused", label: "Paused" },
        { value: "Extended", label: "Extended" },
      ],
    },
  ];

  return (
    <Wrapper>
      <AddForm
        entityName={"Project"}
        fields={fields}
        onCancel={() => {
          window.history.back();
        }}
        submitHandler={async (formData: FormData) => {
          try {
            const userId = getUserId();
            if (!userId) {
              logger.error("No authenticated user found");
              throw new Error("You must be logged in to create a project");
            }

            const projectData = {
              Name: formData.get("name"),
              Description: formData.get("description") || "",
              StartDate: formData.get("startDate"),
              EndDate: formData.get("endDate") || formData.get("startDate"), // Default to startDate if not provided
              Budget: formData.get("budget") ? Number(formData.get("budget")) : 0,
              Visibility: formData.get("visibility") === "Private" ? 2 : formData.get("visibility") === "MembersOnly" ? 1 : 0,
              Status: formData.get("status") === "InProgress" ? 0 : 
                     formData.get("status") === "Completed" ? 1 : 
                     formData.get("status") === "Cancelled" ? 2 :
                     formData.get("status") === "Paused" ? 3 : 4,
              OwnerId: userId
            };

            console.log("Project data being sent:", projectData);
            const result = await entityServices.addEntity(
              "projects",
              projectData
            );

            if (result) {
              logger.info(
                "Project created successfully:" + JSON.stringify(result)
              );
              window.history.back();
            } else {
              const error = "Failed to create project";
              logger.error(error);
              throw new Error(error);
            }
          } catch (error) {
            logger.error("Error creating project:" + error);
            throw error;
          }
        }}
      />
    </Wrapper>
  );
};

export default AddProject;
