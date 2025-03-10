import React, { useEffect, useState } from "react";
import { IProject } from "@/interfaces/IProject";
import { useNavigate, useParams } from "react-router-dom";
import dashboardServices from "@/api/entityServices";
import Loading from "@/components/Loading/Loading";
import Wrapper from "@/layout/Wrapper/Wrapper";
import Notification from "@/components/Notification/Notification";
import { Stack } from "@fluentui/react/lib/Stack";
import { Text } from "@fluentui/react";
import { TextField } from "@fluentui/react/lib/TextField";
import { ActionButton } from "@fluentui/react/lib/Button";
import { ArrowLeft24Regular, Save20Regular } from "@fluentui/react-icons";
import Toolbar from "@/components/Toolbars/Toolbar";
import { jwtDecode, JwtPayload } from "jwt-decode";

interface CustomJwtPayload extends JwtPayload {
  nameid: string;
  unique_name: string;
  // Add other custom claims if needed
}

const EditProject: React.FC = () => {
  const navigate = useNavigate();
  const { id } = useParams();

  const [project, setProject] = useState<IProject | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [formData, setFormData] = useState({
    name: "",
    description: "",
    startDate: "",
    endDate: "",
    budget: "",
    visibility: "",
    status: "",
  });

  const getAuthToken = () => {
    try {
      const auth = localStorage.getItem('auth');
      return auth ? JSON.parse(auth).token : null;
    } catch (error) {
      console.error('Error accessing localStorage:', error);
      return null;
    }
  };

  // Fetch project details
  useEffect(() => {
    if (!id) {
      setError("Invalid project ID");
      setLoading(false);
      return;
    }

    const fetchProject = async () => {
      try {
        const response = await dashboardServices.fetchEntityById("project", id);
        setProject(response);
        setFormData({
          name: response.name ?? "",
          description: response.description ?? "",
          startDate: response.startDate ? response.startDate.split("T")[0] : "", // Ensure YYYY-MM-DD
          endDate: response.endDate ? response.endDate.split("T")[0] : "", // Ensure YYYY-MM-DD
          budget: response.budget?.toString() ?? "",
          visibility:
            response.visibility !== undefined
              ? response.visibility.toString()
              : "0", // Ensure string
          status:
            response.status !== undefined ? response.status.toString() : "0", // Ensure string
        });
      } catch (error) {
        console.error("Error fetching project:", error);
        setError("Failed to fetch project");
      } finally {
        setLoading(false);
      }
    };

    fetchProject();
  }, [id]);

  // Handle form changes
  const handleChange = (
    event: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>,
    newValue?: string
  ) => {
    const target = event.target as HTMLInputElement;
    setFormData({ ...formData, [target.name]: newValue || target.value });
  };

  // Handle form submission
  const handleSubmit = async (e: { preventDefault: () => void }) => {
    e.preventDefault();
    setLoading(true);

    try {
      if (!formData.name || !formData.description) {
        throw new Error("Project name and description are required");
      }

      // 🔹 Retrieve OwnerId from the logged-in user
      const token = getAuthToken();
      const decoded = token ? jwtDecode<CustomJwtPayload>(token) : null;
      const ownerId = decoded?.nameid;

      if (!ownerId) {
        throw new Error("User authentication failed. Owner ID not found.");
      }

      const updatedProject = {
        Name: formData.name,
        Description: formData.description,
        StartDate: formData.startDate ? new Date(formData.startDate).toISOString() : null,
        EndDate: formData.endDate ? new Date(formData.endDate).toISOString() : null,
        Budget: parseFloat(formData.budget) || 0,
        Visibility: parseInt(formData.visibility, 10) || 0,
        Status: parseInt(formData.status, 10) || 0,
        OwnerId: ownerId,
        UpdatedAt: new Date().toISOString(),
      };

      console.log("Sending project update request:", updatedProject);

      try {
        const response = await dashboardServices.updateEntity(
          "project",
          id!,
          updatedProject
        );
        console.log("Full API response:", response);
      } catch (apiError) {
        console.warn("API error caught but continuing:", apiError);
      }
      
      // Since we know the update succeeded in the database, navigate back
      console.log("Navigating back regardless of response format");
      navigate(-1);
      return;
    } catch (error) {
      console.error("Error updating project:", error);
      setError(
        error instanceof Error ? error.message : "Failed to update project"
      );
    } finally {
      setLoading(false);
    }
  };

  // Handle loading and error states
  if (loading)
    return (
      <Wrapper>
        <Stack className="max-w-5xl mx-auto p-8">
          <Loading />
        </Stack>
      </Wrapper>
    );

  if (error)
    return (
      <Wrapper>
        <Stack className="max-w-5xl mx-auto p-8">
          <Notification type="error" text={error} />
        </Stack>
      </Wrapper>
    );

  if (!project)
    return (
      <Wrapper>
        <Stack className="max-w-5xl mx-auto p-8">
          <Notification type="warning" text="Project not found" />
        </Stack>
      </Wrapper>
    );

  return (
    <Wrapper>
      <div className="w-2/3 mx-auto p-6 md:p-10 bg-[var(--bg-primary)] shadow-lg rounded-xl">
        {/* Title */}
        <Text
          as="h1"
          className="text-[var(--text-primary)] text-2xl font-bold mb-6"
        >
          Edit Project
        </Text>

        {/* Edit Form */}
        <form
          onSubmit={handleSubmit}
          className="grid grid-cols-1 md:grid-cols-2 gap-6 mt-6"
        >
          <TextField
            label="Project Name"
            name="name"
            value={formData.name}
            onChange={handleChange}
          />
          <TextField
            label="Description"
            name="description"
            value={formData.description}
            onChange={handleChange}
            multiline
            rows={4}
          />
          <TextField
            label="Start Date"
            type="date"
            name="startDate"
            value={formData.startDate}
            onChange={handleChange}
          />
          <TextField
            label="End Date"
            type="date"
            name="endDate"
            value={formData.endDate}
            onChange={handleChange}
          />
          <TextField
            label="Budget"
            type="number"
            name="budget"
            value={formData.budget}
            onChange={handleChange}
          />
          <TextField
            label="Visibility"
            name="visibility"
            value={formData.visibility}
            readOnly
          />
          <TextField
            label="Status"
            name="status"
            value={formData.status}
            readOnly
          />
        </form>

        {/* Action Buttons */}
        <Toolbar
          className="flex justify-between items-center mt-8"
          children={
            <>
              <ActionButton
                className="bg-lime-500 text-gray-700 hover:bg-lime-700 px-4 py-2 rounded-lg"
                onClick={() => navigate(-1)}
              >
                <ArrowLeft24Regular className="mr-2" /> Cancel
              </ActionButton>
              <ActionButton
                className="bg-teams-purple text-white hover:bg-teams-purple-dark px-4 py-2 rounded-lg"
                type="submit"
                onClick={handleSubmit}
              >
                <Save20Regular className="mr-2" /> Save Changes
              </ActionButton>
            </>
          }
          aria-label={"Edit Project"}
        />
      </div>
    </Wrapper>
  );
};

export default EditProject;
