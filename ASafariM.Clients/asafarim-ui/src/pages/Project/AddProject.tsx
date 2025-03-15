// src/pages/Project/AddProject.tsx
import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import { IField } from "@/interfaces/IField";
import Wrapper from "@/layout/Wrapper/Wrapper";
import entityServices from "@/api/entityServices";
import { logger } from "@/utils/logger";
import { jwtDecode } from "jwt-decode";
import Notification from "@/components/Notification/Notification";
import { TextField } from "@fluentui/react/lib/TextField";
import { PrimaryButton, DefaultButton, IconButton, ActionButton } from "@fluentui/react/lib/Button";
import { Text } from "@fluentui/react/lib/Text";
import { Dialog, DialogType, DialogFooter } from "@fluentui/react/lib/Dialog";
import { Spinner, SpinnerSize } from "@fluentui/react/lib/Spinner";
import { List } from "@fluentui/react/lib/List";
import { Stack } from "@fluentui/react/lib/Stack";
import { Dropdown, IDropdownOption } from "@fluentui/react/lib/Dropdown";
import { Add20Regular, Delete24Regular, Search24Regular, ArrowLeft24Regular, Save20Regular } from "@fluentui/react-icons";
import axios from "axios";
import Toolbar from "@/components/Toolbars/Toolbar";
import useAuth from "@/hooks/useAuth";

interface JwtPayload {
  nameid?: string;
  unique_name?: string;
  role?: string;
  exp?: number;
}

const AddProject: React.FC = () => {
  const navigate = useNavigate();
  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState(false);
  const [repoLinks, setRepoLinks] = useState<string[]>([]);
  const [newRepoLink, setNewRepoLink] = useState("");
  const { authenticated, authenticatedUser } = useAuth();
  
  // Form state
  const [formData, setFormData] = useState({
    name: "",
    description: "",
    startDate: "",
    endDate: "",
    budget: "",
    visibility: "0",
    status: "0",
  });
  
  // Description character count state
  const [descriptionCharCount, setDescriptionCharCount] = useState(0);
  const maxDescriptionLength = 500;
  
  // Modal state
  const [isModalOpen, setIsModalOpen] = useState(false);
  const [isGistModalOpen, setIsGistModalOpen] = useState(false);
  const [githubRepos, setGithubRepos] = useState<{name: string, html_url: string, description?: string}[]>([]);
  const [githubGists, setGithubGists] = useState<{description: string, html_url: string, files?: any}[]>([]);
  const [isLoadingRepos, setIsLoadingRepos] = useState(false);
  const [isLoadingGists, setIsLoadingGists] = useState(false);
  const [searchQuery, setSearchQuery] = useState("");
  const [gistSearchQuery, setGistSearchQuery] = useState("");
  
  // State for delete confirmation dialog
  const [showDeleteDialog, setShowDeleteDialog] = useState(false);
  const [linkToDeleteIndex, setLinkToDeleteIndex] = useState<number | null>(null);
  
  // Handle form changes
  const handleChange = (
    event: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>,
    newValue?: string
  ) => {
    const target = event.target as HTMLInputElement;
    const name = target.name;
    const value = newValue || target.value;
    
    // Update character count for description field
    if (name === "description") {
      setDescriptionCharCount(value.length);
    }
    
    setFormData({ ...formData, [name]: value });
  };

  const handleDropdownChange = (
    _event: React.FormEvent<HTMLDivElement>,
    option?: IDropdownOption,
    name?: string
  ) => {
    if (option && name) {
      setFormData({ ...formData, [name]: option.key.toString() });
    }
  };
  
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
  
  const handleAddGistLink = () => {
    setIsGistModalOpen(true);
    fetchGithubGists();
  };
  
  const confirmDeleteLink = (index: number) => {
    setLinkToDeleteIndex(index);
    setShowDeleteDialog(true);
  };
  
  const handleRemoveRepoLink = () => {
    if (linkToDeleteIndex !== null) {
      const updatedLinks = [...repoLinks];
      updatedLinks.splice(linkToDeleteIndex, 1);
      setRepoLinks(updatedLinks);
      setShowDeleteDialog(false);
      setLinkToDeleteIndex(null);
    }
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
  
  // GitHub gists handlers
  const fetchGithubGists = async () => {
    try {
      setIsLoadingGists(true);
      const response = await axios.get('https://api.github.com/users/AliSafari-IT/gists');
      setGithubGists(response.data);
      logger.info(`Fetched ${response.data.length} GitHub gists`);
    } catch (error) {
      logger.error('Error fetching GitHub gists: ' + error);
      setError('Failed to fetch GitHub gists');
    } finally {
      setIsLoadingGists(false);
    }
  };
  
  // Filter repositories based on search query
  const filteredRepos = searchQuery
    ? githubRepos.filter(repo => 
        repo.name.toLowerCase().includes(searchQuery.toLowerCase()))
    : githubRepos;
    
  // Filter gists based on search query
  const filteredGists = gistSearchQuery
    ? githubGists.filter(gist => {
        const description = gist.description || '';
        const fileNames = gist.files ? Object.keys(gist.files).join(' ') : '';
        return description.toLowerCase().includes(gistSearchQuery.toLowerCase()) || 
               fileNames.toLowerCase().includes(gistSearchQuery.toLowerCase());
      })
    : githubGists;
    
  // Handle form submission
  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setLoading(true);
    setError(null); // Clear any previous errors

    try {
      if (!formData.name) {
        setError("Project name is required");
        setLoading(false);
        return;
      }
      
      // Check description length
      if (formData.description && formData.description.length > maxDescriptionLength) {
        setError(`Description must be ${maxDescriptionLength} characters or less`);
        setLoading(false);
        return;
      }

      // Check if user is authenticated using the useAuth hook
      if (!authenticated || !authenticatedUser) {
        logger.error("No authenticated user found");
        setError("You must be logged in to create a project");
        setLoading(false);
        return;
      }

      // Use the user ID from the authenticated user object
      const userId = authenticatedUser.id;
      if (!userId) {
        logger.error("User ID not found in authenticated user object");
        setError("Unable to determine user ID. Please try logging out and back in.");
        setLoading(false);
        return;
      }

      // Validate repository links
      const validLinks = repoLinks.filter(link => {
        if (!link || !link.trim()) return false;
        
        // Basic URL validation
        try {
          new URL(link);
          return true;
        } catch (e) {
          logger.warn(`Invalid repository URL: ${link}`);
          return false;
        }
      });
      
      if (validLinks.length !== repoLinks.length) {
        logger.warn(`Filtered out ${repoLinks.length - validLinks.length} invalid repository links`);
      }

      const projectData = {
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
        OwnerId: userId,
        RepoLinks: validLinks // Add validated repository links to the project data
      };

      logger.info("Sending project data: " + JSON.stringify(projectData));
      
      // Use the standard addEntity function now that the backend supports repository links
      const result = await entityServices.addEntity("project", projectData);

      if (result) {
        logger.info("Project created successfully: " + JSON.stringify(result));
        window.location.href = "/projects";
      } else {
        throw new Error("Failed to create project - no result returned");
      }
    } catch (error) {
      logger.error("Error creating project: " + error);
      setError(error instanceof Error ? error.message : "Failed to create project");
    } finally {
      setLoading(false);
    }
  };

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
          {field.name === "description" && (
            <span className={`ml-2 text-sm ${descriptionCharCount > maxDescriptionLength ? 'text-red-500 font-bold' : 'text-gray-500'}`}>
              {descriptionCharCount}/{maxDescriptionLength}
            </span>
          )}
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
            errorMessage={field.name === "description" && descriptionCharCount > maxDescriptionLength 
              ? `Description must be ${maxDescriptionLength} characters or less` 
              : undefined}
          />
        )}
      </div>
    );
  };

  if (loading) {
    return (
      <Wrapper>
        <Stack className="max-w-5xl mx-auto p-8">
          <Spinner size={SpinnerSize.large} label="Creating project..." />
        </Stack>
      </Wrapper>
    );
  }

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

  return (
    <Wrapper>
      {error && (
        <Stack className="max-w-5xl mx-auto p-8">
          <Notification type="error" text={error} />
        </Stack>
      )}
      
      <div className="w-2/3 mx-auto p-6 md:p-10 bg-[var(--bg-primary)] shadow-lg rounded-xl">
        <Text
          as="h1"
          className="text-[var(--text-primary)] text-2xl font-bold mb-6"
        >
          Create New Project
        </Text>
        
        <form onSubmit={handleSubmit}>
          {/* Project Fields in Two Columns */}
          <div className="grid grid-cols-1 md:grid-cols-2 gap-6 mt-6">
            {fields.map(renderField)}
          </div>

          {/* Repository Links Section */}
          <div className="mt-6 p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md">
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
                    <IconButton 
                      onClick={() => confirmDeleteLink(index)}
                      className="ml-2 bg-red-100 hover:bg-red-200 text-red-600 hover:text-red-700 rounded-md transition-colors duration-200"
                      title="Remove Link"
                      ariaLabel="Delete repository link"
                    >
                      <Delete24Regular />
                    </IconButton>
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
              <PrimaryButton 
                onClick={handleAddGistLink}
                className="ml-2 bg-teal-500 hover:bg-teal-600"
                title="Add GitHub Gist Link"
              >
                <Add20Regular className="mr-1" /> Add Gist
              </PrimaryButton>
            </div>
          </div>
          
          {/* Action Buttons */}
          <Toolbar
            className="flex justify-between items-center mt-8"
            aria-label={"Add-Project"}
          >
            <ActionButton
              className="bg-lime-500 text-gray-700 hover:bg-lime-700 px-4 py-2 rounded-lg"
              onClick={() => navigate(-1)}
              type="button"
            >
              <ArrowLeft24Regular className="mr-2" /> Cancel
            </ActionButton>
            <ActionButton
              className="bg-teams-purple text-white hover:bg-teams-purple-dark px-4 py-2 rounded-lg"
              type="submit"
            >
              <Save20Regular className="mr-2" /> Create Project
            </ActionButton>
          </Toolbar>
        </form>
        
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
        
        {/* GitHub Gists Modal */}
        <Dialog
          hidden={!isGistModalOpen}
          onDismiss={() => setIsGistModalOpen(false)}
          dialogContentProps={{
            type: DialogType.normal,
            title: 'Select GitHub Gist',
            subText: 'Choose a gist to add as a link to your project'
          }}
          modalProps={{
            isBlocking: true,
            styles: { main: { maxWidth: 600 } }
          }}
        >
          <div className="mb-4">
            <div className="flex items-center mb-4">
              <TextField
                placeholder="Search gists..."
                value={gistSearchQuery}
                onChange={(_, newValue) => setGistSearchQuery(newValue || '')}
                className="flex-grow"
              />
              <PrimaryButton className="ml-2" type="button">
                <Search24Regular />
              </PrimaryButton>
            </div>
            
            {isLoadingGists ? (
              <div className="flex justify-center py-4">
                <Spinner size={SpinnerSize.large} label="Loading gists..." />
              </div>
            ) : filteredGists.length > 0 ? (
              <div className="max-h-80 overflow-y-auto border border-[var(--border-primary)] rounded-md">
                <List
                  items={filteredGists}
                  onRenderCell={(item?: {description: string, html_url: string, files?: any}) => (
                    <div 
                      className="p-3 border-b border-[var(--border-primary)] hover:bg-[var(--bg-secondary)] flex items-center cursor-pointer"
                      onClick={(e) => {
                        e.preventDefault();
                        e.stopPropagation();
                        if (item) {
                          console.log('Selected gist:', item.description);
                          // Add the URL directly to the repoLinks array
                          const newLinks = [...repoLinks];
                          if (!newLinks.includes(item.html_url)) {
                            newLinks.push(item.html_url);
                            setRepoLinks(newLinks);
                            console.log('Added gist:', item.description);
                            console.log('New links array:', newLinks);
                          }
                          setIsGistModalOpen(false);
                        }
                      }}
                    >
                      <div className="flex-shrink-0 mr-3 text-teal-500 hover:text-teal-600">
                        <Add20Regular />
                      </div>
                      <div className="flex-grow min-w-0">
                        <Text className="font-medium">{item?.description}</Text>
                        <Text className="text-sm text-[var(--text-secondary)] truncate">{item?.html_url}</Text>
                        {item?.files && (
                          <Text className="text-xs text-[var(--text-secondary)] truncate mt-1">{Object.keys(item.files).join(', ')}</Text>
                        )}
                      </div>
                    </div>
                  )}
                />
              </div>
            ) : (
              <Text className="text-center py-4 text-[var(--text-secondary)]">
                No gists found
              </Text>
            )}
          </div>
          
          <DialogFooter>
            <PrimaryButton onClick={() => setIsGistModalOpen(false)} text="Close" type="button" />
          </DialogFooter>
        </Dialog>
        
        {/* Delete Confirmation Dialog */}
        <Dialog
          hidden={!showDeleteDialog}
          onDismiss={() => setShowDeleteDialog(false)}
          dialogContentProps={{
            type: DialogType.normal,
            title: 'Confirm Delete',
            subText: linkToDeleteIndex !== null && repoLinks[linkToDeleteIndex] 
              ? `Are you sure you want to delete this repository link?`
              : 'Are you sure you want to delete this repository link?'
          }}
          modalProps={{
            isBlocking: true,
            styles: { main: { maxWidth: 450 } }
          }}
        >
          {linkToDeleteIndex !== null && repoLinks[linkToDeleteIndex] && (
            <div className="mb-4 p-3 bg-gray-100 border border-gray-200 rounded-md break-all">
              <Text className="text-sm text-gray-700">{repoLinks[linkToDeleteIndex]}</Text>
            </div>
          )}
          <DialogFooter>
            <PrimaryButton 
              onClick={handleRemoveRepoLink} 
              text="Delete" 
              className="bg-red-500 hover:bg-red-600 border-0"
            />
            <DefaultButton onClick={() => setShowDeleteDialog(false)} text="Cancel" />
          </DialogFooter>
        </Dialog>
      </div>
    </Wrapper>
  );
};

export default AddProject;
