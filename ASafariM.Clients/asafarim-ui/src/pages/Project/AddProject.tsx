// src/pages/Project/AddProject.tsx
import AddForm from "../../components/crud/AddForm";
import { IField } from "@/interfaces/IField";
import Wrapper from "@/layout/Wrapper/Wrapper";
import entityServices from "@/api/entityServices";
import { logger } from "@/utils/logger";
import { jwtDecode } from "jwt-decode";
import { useState } from "react";
import Notification from "@/components/Notification/Notification";
import { TextField } from "@fluentui/react/lib/TextField";
import { PrimaryButton } from "@fluentui/react/lib/Button";
import { Text } from "@fluentui/react/lib/Text";
import { Dialog, DialogType, DialogFooter } from "@fluentui/react/lib/Dialog";
import { Spinner, SpinnerSize } from "@fluentui/react/lib/Spinner";
import { List } from "@fluentui/react/lib/List";
import { Add20Regular, Delete20Regular, Search24Regular } from "@fluentui/react-icons";
import axios from "axios";

interface JwtPayload {
  nameid?: string;
  unique_name?: string;
  role?: string;
  exp?: number;
}

const AddProject: React.FC = () => {
  const [error, setError] = useState<string | null>(null);
  const [repoLinks, setRepoLinks] = useState<string[]>([]);
  const [newRepoLink, setNewRepoLink] = useState("");
  
  // Modal state
  const [isModalOpen, setIsModalOpen] = useState(false);
  const [githubRepos, setGithubRepos] = useState<{name: string, html_url: string, description?: string}[]>([]);
  const [isLoadingRepos, setIsLoadingRepos] = useState(false);
  const [searchQuery, setSearchQuery] = useState("");
  
  // Repository links handlers
  const handleAddRepoLink = () => {
    if (newRepoLink && newRepoLink.trim() !== '') {
      // Basic URL validation
      try {
        new URL(newRepoLink); // Will throw if invalid URL
        const newLinks = [...repoLinks];
        newLinks.push(newRepoLink);
        console.log('Adding manual link:', newRepoLink);
        console.log('New links array:', newLinks);
        setRepoLinks(newLinks);
        setNewRepoLink('');
      } catch (e) {
        setError('Please enter a valid URL');
        setTimeout(() => setError(null), 3000); // Clear error after 3 seconds
      }
    } else {
      // Open the modal if no URL is entered
      setIsModalOpen(true);
      fetchGithubRepos();
    }
  };
  
  const handleRemoveRepoLink = (index: number) => {
    const updatedLinks = [...repoLinks];
    updatedLinks.splice(index, 1);
    setRepoLinks(updatedLinks);
  };

  // GitHub repositories handlers
  const fetchGithubRepos = async () => {
    try {
      setIsLoadingRepos(true);
      const response = await axios.get('https://api.github.com/users/AliSafari-IT/repos');
      setGithubRepos(response.data);
      logger.info(`Fetched ${response.data.length} GitHub repositories`);
    } catch (error) {
      logger.error('Error fetching GitHub repositories: ' + error);
      setError('Failed to fetch GitHub repositories');
    } finally {
      setIsLoadingRepos(false);
    }
  };
  
  // Filter repositories based on search query
  const filteredRepos = searchQuery
    ? githubRepos.filter(repo => 
        repo.name.toLowerCase().includes(searchQuery.toLowerCase()))
    : githubRepos;
    
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
      
      <div className="max-w-5xl mx-auto p-6 bg-[var(--bg-primary)] shadow-lg rounded-xl">
        {/* Repository Links Section */}
        <div className="mb-6 p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md">
          <Text as="h2" className="text-[var(--text-primary)] text-xl font-bold mb-3">
            Repository Links
          </Text>
          
          {/* List of existing links */}
          {repoLinks.length > 0 ? (
            <ul className="list-disc list-inside mb-4">
              {repoLinks.map((link, index) => (
                <li key={index} className="flex items-center mb-2">
                  <a 
                    href={link} 
                    target="_blank" 
                    rel="noopener noreferrer"
                    className="text-teal-500 underline hover:text-teal-700 flex-grow"
                  >
                    {link}
                  </a>
                  <PrimaryButton 
                    onClick={() => handleRemoveRepoLink(index)}
                    className="ml-2 bg-red-500 hover:bg-red-600"
                    title="Remove Link"
                  >
                    <Delete20Regular />
                  </PrimaryButton>
                </li>
              ))}
            </ul>
          ) : (
            <Text className="text-[var(--text-secondary)] italic mb-4">
              No repository links added yet
            </Text>
          )}
          
          {/* Add new link form */}
          <div className="flex items-center mt-4">
            <TextField 
              placeholder="Enter repository URL" 
              value={newRepoLink}
              onChange={(_, newValue) => setNewRepoLink(newValue || '')}
              className="flex-grow"
            />
            <PrimaryButton 
              onClick={handleAddRepoLink}
              className="ml-2 bg-teal-500 hover:bg-teal-600"
              title="Add Repository Link"
            >
              <Add20Regular className="mr-1" /> Add Link
            </PrimaryButton>
          </div>
          
          {/* GitHub Repositories Modal */}
          <Dialog
            hidden={!isModalOpen}
            onDismiss={() => setIsModalOpen(false)}
            dialogContentProps={{
              type: DialogType.normal,
              title: 'Select GitHub Repository',
              subText: 'Choose a repository to add as a link to your project'
            }}
            modalProps={{
              isBlocking: true,
              styles: { main: { maxWidth: 600 } }
            }}
          >
            <div className="mb-4">
              <div className="flex items-center mb-4">
                <TextField
                  placeholder="Search repositories..."
                  value={searchQuery}
                  onChange={(_, newValue) => setSearchQuery(newValue || '')}
                  className="flex-grow"
                />
                <PrimaryButton className="ml-2" type="button">
                  <Search24Regular />
                </PrimaryButton>
              </div>
              
              {isLoadingRepos ? (
                <div className="flex justify-center py-4">
                  <Spinner size={SpinnerSize.large} label="Loading repositories..." />
                </div>
              ) : filteredRepos.length > 0 ? (
                <div className="max-h-80 overflow-y-auto border border-[var(--border-primary)] rounded-md">
                  <List
                    items={filteredRepos}
                    onRenderCell={(item?: {name: string, html_url: string, description?: string}) => (
                      <div 
                        className="p-3 border-b border-[var(--border-primary)] hover:bg-[var(--bg-secondary)] flex items-center cursor-pointer"
                        onClick={(e) => {
                          e.preventDefault();
                          e.stopPropagation();
                          if (item) {
                            console.log('Selected repository:', item.name);
                            // Add the URL directly to the repoLinks array
                            const newLinks = [...repoLinks];
                            if (!newLinks.includes(item.html_url)) {
                              newLinks.push(item.html_url);
                              setRepoLinks(newLinks);
                              console.log('Added repository:', item.name);
                              console.log('New links array:', newLinks);
                            }
                            setIsModalOpen(false);
                          }
                        }}
                      >
                        <div className="flex-shrink-0 mr-3 text-teal-500 hover:text-teal-600">
                          <Add20Regular />
                        </div>
                        <div className="flex-grow min-w-0">
                          <Text className="font-medium">{item?.name}</Text>
                          <Text className="text-sm text-[var(--text-secondary)] truncate">{item?.html_url}</Text>
                          {item?.description && (
                            <Text className="text-xs text-[var(--text-secondary)] truncate mt-1">{item.description}</Text>
                          )}
                        </div>
                      </div>
                    )}
                  />
                </div>
              ) : (
                <Text className="text-center py-4 text-[var(--text-secondary)]">
                  No repositories found
                </Text>
              )}
            </div>
            
            <DialogFooter>
              <PrimaryButton onClick={() => setIsModalOpen(false)} text="Close" type="button" />
            </DialogFooter>
          </Dialog>
        </div>
        
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
                OwnerId: userId,
                RepoLinks: repoLinks // Add repository links to the project data
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
      </div>
    </Wrapper>
  );
};

export default AddProject;
