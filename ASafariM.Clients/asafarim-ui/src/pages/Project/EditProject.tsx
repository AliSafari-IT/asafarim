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
import { Dropdown, IDropdownOption } from "@fluentui/react/lib/Dropdown";
import { ActionButton } from "@fluentui/react/lib/Button";
import { ArrowLeft24Regular, Save20Regular } from "@fluentui/react-icons";
import Toolbar from "@/components/Toolbars/Toolbar";
import { jwtDecode } from "jwt-decode";
import { logger } from "@/utils/logger";

interface JwtPayload {
  nameid?: string;
  unique_name?: string;
  role?: string;
  exp?: number;
}

const EditProject: React.FC = () => {
  const navigate = useNavigate();
  const { id } = useParams();

  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [formData, setFormData] = useState({
    name: "",
    description: "",
    startDate: "",
    endDate: "",
    budget: "",
    visibility: "0",
    status: "0",
  });

  // Get user ID from JWT token - same as in AddProject
  const getUserId = () => {
    try {
      const token = localStorage.getItem('auth') ? JSON.parse(localStorage.getItem('auth')!).token : null;
      if (!token) return null;

      const decoded = jwtDecode<JwtPayload>(token);
      return decoded.nameid; // User ID is stored in nameid claim
    } catch (error) {
      logger.error("Error decoding JWT token:" + error);
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
        setFormData({
          name: response.name ?? "",
          description: response.description ?? "",
          startDate: response.startDate ? response.startDate.split("T")[0] : "",
          endDate: response.endDate ? response.endDate.split("T")[0] : "",
          budget: response.budget?.toString() ?? "",
          visibility: response.visibility?.toString() ?? "0",
          status: response.status?.toString() ?? "0",
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

  const handleDropdownChange = (
    event: React.FormEvent<HTMLDivElement>,
    option?: IDropdownOption,
    name?: string
  ) => {
    if (option && name) {
      setFormData({ ...formData, [name]: option.key.toString() });
    }
  };

  // Handle form submission
  const handleSubmit = async (e: { preventDefault: () => void }) => {
    e.preventDefault();
    setLoading(true);
    setError(null); // Clear any previous errors

    try {
      if (!formData.name || !formData.description) {
        setError("Project name and description are required");
        setLoading(false);
        return;
      }

      const ownerId = getUserId();
      if (!ownerId) {
        logger.error("No authenticated user found");
        setError("You must be logged in to update a project");
        setLoading(false);
        return;
      }

      const updatedProject = {
        Name: formData.name,
        Description: formData.description,
        StartDate: formData.startDate
          ? new Date(formData.startDate).toISOString()
          : null,
        EndDate: formData.endDate
          ? new Date(formData.endDate).toISOString()
          : null,
        Budget: parseFloat(formData.budget) || 0,
        Visibility: parseInt(formData.visibility, 10) || 0,
        Status: parseInt(formData.status, 10) || 0,
        OwnerId: ownerId,
        UpdatedAt: new Date().toISOString(),
      };

      logger.info("Sending project update request: " + JSON.stringify(updatedProject));
      await dashboardServices.updateEntity("project", id!, updatedProject);
      navigate(-1);
    } catch (error) {
      logger.error("Error updating project: " + error);
      setError(
        error instanceof Error ? error.message : "Failed to update project"
      );
    } finally {
      setLoading(false);
    }
  };

  // Define form fields array
  const fields = [
    { name: "name", label: "Project Name", type: "text" },
    { name: "description", label: "Description", type: "textarea" },
    { name: "startDate", label: "Start Date", type: "date" },
    { name: "endDate", label: "End Date", type: "date" },
    { name: "budget", label: "Budget", type: "number" },
    { name: "visibility", label: "Visibility", type: "select" },
    { name: "status", label: "Status", type: "select" },
  ];

  // Dropdown options
  const visibilityOptions: IDropdownOption[] = [
    { key: "0", text: "Public" },
    { key: "1", text: "Members Only" },
    { key: "2", text: "Private" },
  ];

  const statusOptions: IDropdownOption[] = [
    { key: "0", text: "In Progress" },
    { key: "1", text: "Completed" },
    { key: "2", text: "Cancelled" },
    { key: "3", text: "Paused" },
    { key: "4", text: "Extended" },
  ];

  // Function to render input fields dynamically
  const renderField = (field: {
    name: string;
    label: string;
    type: string;
  }) => {
    return (
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
        {field.type === "select" ? (
          <Dropdown
            placeholder="Select an option"
            options={
              field.name === "visibility" ? visibilityOptions : statusOptions
            }
            selectedKey={formData[field.name as keyof typeof formData]}
            onChange={(e, option) => handleDropdownChange(e, option, field.name)}
          />
        ) : (
          <TextField
            name={field.name}
            type={field.type}
            value={formData[field.name as keyof typeof formData]}
            onChange={handleChange}
            multiline={field.type === "textarea"}
            rows={field.type === "textarea" ? 4 : undefined}
          />
        )}
      </div>
    );
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

  return (
    <Wrapper>
      <div className="w-2/3 mx-auto p-6 md:p-10 bg-[var(--bg-primary)] shadow-lg rounded-xl">
        <Text
          as="h1"
          className="text-[var(--text-primary)] text-2xl font-bold mb-6"
        >
          Edit Project
        </Text>

        {/* Project Fields in Two Columns */}
        <div className="grid grid-cols-1 md:grid-cols-2 gap-6 mt-6">
          {fields.map(renderField)}
        </div>

        {/* Action Buttons */}
        <Toolbar
          className="flex justify-between items-center mt-8"
          aria-label={"Edit-Project"}
        >
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
        </Toolbar>
      </div>
    </Wrapper>
  );
};

export default EditProject;
