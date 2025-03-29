import React, { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import entityServices from "@/api/entityServices";
import Wrapper from "@/layout/Wrapper/Wrapper";
import Notification from "@/components/Notification/Notification";
import { Stack } from "@fluentui/react/lib/Stack";
import { Text } from "@fluentui/react/lib/Text";
import { Spinner, SpinnerSize } from "@fluentui/react/lib/Spinner";
import { List } from "@fluentui/react/lib/List";
import { Dialog, DialogType, DialogFooter } from "@fluentui/react/lib/Dialog";
import { TextField } from "@fluentui/react/lib/TextField";
import { Dropdown, IDropdownOption } from "@fluentui/react/lib/Dropdown";
import { ActionButton, DefaultButton, PrimaryButton, IconButton } from "@fluentui/react/lib/Button";
import { ArrowLeft24Regular, Save20Regular, Add20Regular, Delete24Regular, Search24Regular } from "@fluentui/react-icons";
import Toolbar from "@/components/Toolbars/Toolbar";
import { logger } from "@/utils/logger";
import axios from "axios";
import { useAuth } from '@/contexts/AuthContext';

const EditProject: React.FC = () => {
  const navigate = useNavigate();
  const { id } = useParams();
  const { authenticated, authenticatedUser } = useAuth();

  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [showAuthErrorNotification, setShowAuthErrorNotification] = useState(false);
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
  
  // Repository links state
  const [repoLinks, setRepoLinks] = useState<string[]>([]);
  const [newRepoLink, setNewRepoLink] = useState("");
  
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

  // Check authentication on component mount
  useEffect(() => {
    if (!authenticated) {
      setShowAuthErrorNotification(true);
      setLoading(false);
      
      // Redirect to login after 3 seconds
      const timer = setTimeout(() => {
        navigate("/login", { state: { returnUrl: `/projects/edit/${id}` } });
      }, 3000);
      
      return () => clearTimeout(timer);
    }
  }, [navigate, id, authenticated]);

  // Get user ID from JWT token - same as in AddProject
  const getUserId = () => {
    try {
      if (!authenticated || !authenticatedUser) {
        return null;
      }
      
      return authenticatedUser.id;
    } catch (error) {
      logger.error("Error getting user ID: " + error);
      return null;
    }
  };

  // Fetch project details and repository links
  useEffect(() => {
    if (!id) {
      setError("Invalid project ID");
      setLoading(false);
      return;
    }

    const fetchProjectData = async () => {
      try {
        // First check if user is authenticated
        if (!authenticated) {
          setShowAuthErrorNotification(true);
          return;
        }
        
        // Fetch project details
        const projectResponse = await entityServices.fetchEntityById("project", id);
        setFormData({
          name: projectResponse.name ?? "",
          description: projectResponse.description ?? "",
          startDate: projectResponse.startDate ? projectResponse.startDate.split("T")[0] : "",
          endDate: projectResponse.endDate ? projectResponse.endDate.split("T")[0] : "",
          budget: projectResponse.budget?.toString() ?? "",
          visibility: projectResponse.visibility?.toString() ?? "0",
          status: projectResponse.status?.toString() ?? "0",
        });
        
        // Set initial description character count
        setDescriptionCharCount(projectResponse.description?.length || 0);
        
        // Fetch repository links
        const linksResponse = await entityServices.fetchEntityRepoLinks("project", id);
        setRepoLinks(linksResponse || []);
      } catch (error: any) {
        logger.error("Error fetching project data:", error);
        
        // Check for authentication errors
        if (error?.response?.status === 401) {
          setError("Authentication required. Please log in to view or edit projects.");
          setShowAuthErrorNotification(true);
          
          // Redirect to login after 3 seconds
          setTimeout(() => {
            navigate("/login", { state: { returnUrl: `/projects/edit/${id}` } });
          }, 3000);
        } else {
          setError("Failed to fetch project data. Please try again later.");
        }
      } finally {
        setLoading(false);
      }
    };

    fetchProjectData();
  }, [id, authenticated]);

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
        // Ensure repoLinks is an array before spreading
        const currentLinks = Array.isArray(repoLinks) ? repoLinks : [];
        setRepoLinks([...currentLinks, newRepoLink]);
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
  
  const handleRemoveRepoLink = (index?: number) => {
    if (linkToDeleteIndex !== null || index !== undefined) {
      // Ensure repoLinks is an array before spreading
      const currentLinks = Array.isArray(repoLinks) ? repoLinks : [];
      const updatedLinks = [...currentLinks];
      updatedLinks.splice(index !== undefined ? index : linkToDeleteIndex!, 1);
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
  const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    setLoading(true);
    setError(null);

    try {
      // Validate description length before submission
      if (formData.description && formData.description.length > maxDescriptionLength) {
        setError(`Description must be ${maxDescriptionLength} characters or less`);
        setLoading(false);
        return;
      }

      if (!formData.name) {
        setError("Project name is required");
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

      // Validate repository links
      const currentLinks = Array.isArray(repoLinks) ? repoLinks : [];
      const validLinks = currentLinks.filter(link => {
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
      
      if (validLinks.length !== currentLinks.length) {
        logger.warn(`Filtered out ${currentLinks.length - validLinks.length} invalid repository links`);
      }

      // Ensure description is properly trimmed and doesn't exceed max length
      const trimmedDescription = formData.description ? formData.description.trim() : "";
      if (trimmedDescription.length > maxDescriptionLength) {
        setError(`Description must be ${maxDescriptionLength} characters or less`);
        setLoading(false);
        return;
      }

      const updatedProject = {
        Name: formData.name.trim(),
        Description: trimmedDescription,
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
        RepoLinks: validLinks // Send only valid repository links
      };

      logger.info("Sending project update request: " + JSON.stringify(updatedProject));
      
      try {
        await entityServices.updateEntity("project", id!, updatedProject);
        logger.info("Project updated successfully");
        navigate("/projects");
      } catch (updateError: any) {
        logger.error("Error updating project: " + updateError);
        
        if (updateError?.response?.status === 400) {
          // Handle validation errors from the API
          const errorMessage = updateError?.response?.data?.title || 
                               updateError?.response?.data?.message || 
                               "Invalid project data";
          setError(errorMessage);
        } else {
          setError("Failed to update project. Please try again.");
        }
        setLoading(false);
      }
    } catch (error: any) {
      logger.error("Error in form submission: " + error);
      setError("An unexpected error occurred. Please try again.");
      setLoading(false);
    }
  };

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

  if (loading) {
    return (
      <Wrapper>
        <Stack className="max-w-5xl mx-auto p-8">
          <Spinner size={SpinnerSize.large} label="Loading project data..." />
        </Stack>
      </Wrapper>
    );
  }

  if (showAuthErrorNotification) {
    return (
      <Wrapper>
        <Stack className="max-w-5xl mx-auto p-8">
          <Notification 
            type="error" 
            text="You must be logged in to edit projects. Redirecting to login..." 
          />
        </Stack>
      </Wrapper>
    );
  }

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
          Edit Project
        </Text>
        
        <form onSubmit={handleSubmit}>
          {/* Project Name */}
          <div className="mb-6 p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md">
            <Text
              as="label"
              className="block text-[var(--text-primary)] font-medium mb-2"
            >
              Project Name:
            </Text>
            <TextField
              name="name"
              value={formData.name}
              onChange={handleChange}
              required
            />
          </div>
          
          {/* Project Description */}
          <div className="mb-6 p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md">
            <Text
              as="label"
              className="block text-[var(--text-primary)] font-medium mb-2"
            >
              Description:
              <span className={`ml-2 text-sm ${descriptionCharCount > maxDescriptionLength ? 'text-red-500 font-bold' : 'text-gray-500'}`}>
                {descriptionCharCount}/{maxDescriptionLength}
              </span>
            </Text>
            <TextField
              name="description"
              value={formData.description}
              onChange={handleChange}
              multiline
              rows={4}
              errorMessage={descriptionCharCount > maxDescriptionLength 
                ? `Description must be ${maxDescriptionLength} characters or less` 
                : undefined}
              className={descriptionCharCount > maxDescriptionLength ? 'error-field' : ''}
            />
            {descriptionCharCount > maxDescriptionLength && (
              <Text className="text-red-500 text-sm mt-1">
                Please shorten your description to {maxDescriptionLength} characters or less.
              </Text>
            )}
          </div>
          
          {/* Project Dates */}
          <div className="grid grid-cols-1 md:grid-cols-2 gap-6 mb-6">
            {/* Start Date */}
            <div className="p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md">
              <Text
                as="label"
                className="block text-[var(--text-primary)] font-medium mb-2"
              >
                Start Date:
              </Text>
              <TextField
                name="startDate"
                type="date"
                value={formData.startDate}
                onChange={handleChange}
              />
            </div>
            
            {/* End Date */}
            <div className="p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md">
              <Text
                as="label"
                className="block text-[var(--text-primary)] font-medium mb-2"
              >
                End Date:
              </Text>
              <TextField
                name="endDate"
                type="date"
                value={formData.endDate}
                onChange={handleChange}
              />
            </div>
          </div>
          
          {/* Project Details */}
          <div className="grid grid-cols-1 md:grid-cols-3 gap-6 mb-6">
            {/* Budget */}
            <div className="p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md">
              <Text
                as="label"
                className="block text-[var(--text-primary)] font-medium mb-2"
              >
                Budget:
              </Text>
              <TextField
                name="budget"
                type="number"
                value={formData.budget}
                onChange={handleChange}
              />
            </div>
            
            {/* Visibility */}
            <div className="p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md">
              <Text
                as="label"
                className="block text-[var(--text-primary)] font-medium mb-2"
              >
                Visibility:
              </Text>
              <Dropdown
                selectedKey={formData.visibility}
                options={visibilityOptions}
                onChange={(e, option) => handleDropdownChange(e, option, "visibility")}
              />
            </div>
            
            {/* Status */}
            <div className="p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md">
              <Text
                as="label"
                className="block text-[var(--text-primary)] font-medium mb-2"
              >
                Status:
              </Text>
              <Dropdown
                selectedKey={formData.status}
                options={statusOptions}
                onChange={(e, option) => handleDropdownChange(e, option, "status")}
              />
            </div>
          </div>
          
          {/* Repository Links Section */}
          <div className="mb-6 p-4 bg-[var(--bg-secondary)] border border-[var(--border-primary)] rounded-lg shadow-md">
            <Text as="h2" className="text-[var(--text-primary)] text-xl font-bold mb-3">
              Repository & Gist Links
            </Text>
            
            {/* List of existing links */}
            {repoLinks && repoLinks.length > 0 ? (
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
                placeholder="Enter repository or gist URL" 
                value={newRepoLink}
                onChange={(_, newValue) => setNewRepoLink(newValue || '')}
                className="flex-grow"
              />
              <PrimaryButton 
                onClick={handleAddRepoLink}
                className="ml-2 bg-teal-500 hover:bg-teal-600"
                title="Add Link"
              >
                <Add20Regular className="mr-1" /> Add Link
              </PrimaryButton>
            </div>
            
            {/* Buttons to open GitHub modals */}
            <div className="flex mt-4 space-x-2">
              <DefaultButton 
                onClick={() => {
                  setIsModalOpen(true);
                  fetchGithubRepos();
                }}
                className="bg-gray-100 hover:bg-gray-200 text-gray-700"
              >
                Browse Repositories
              </DefaultButton>
              <DefaultButton 
                onClick={handleAddGistLink}
                className="bg-gray-100 hover:bg-gray-200 text-gray-700"
              >
                Browse Gists
              </DefaultButton>
            </div>
          </div>
          
          {/* Action Buttons */}
          <Toolbar
            className="flex justify-between items-center mt-8"
            aria-label={"Edit-Project"}
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
              <Save20Regular className="mr-2" /> Save Changes
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
                      onClick={() => {
                        if (item) {
                          // Add the URL directly to the repoLinks array
                          const currentLinks = Array.isArray(repoLinks) ? repoLinks : [];
                          if (!currentLinks.includes(item.html_url)) {
                            setRepoLinks([...currentLinks, item.html_url]);
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
                      onClick={() => {
                        if (item) {
                          // Add the URL directly to the repoLinks array
                          const currentLinks = Array.isArray(repoLinks) ? repoLinks : [];
                          if (!currentLinks.includes(item.html_url)) {
                            setRepoLinks([...currentLinks, item.html_url]);
                          }
                          setIsGistModalOpen(false);
                        }
                      }}
                    >
                      <div className="flex-shrink-0 mr-3 text-teal-500 hover:text-teal-600">
                        <Add20Regular />
                      </div>
                      <div className="flex-grow min-w-0">
                        <Text className="font-medium">
                          {item?.description || 'Untitled Gist'}
                        </Text>
                        <Text className="text-sm text-[var(--text-secondary)] truncate">{item?.html_url}</Text>
                        {item?.files && (
                          <Text className="text-xs text-[var(--text-secondary)] truncate mt-1">
                            Files: {Object.keys(item.files).join(', ')}
                          </Text>
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
            subText: linkToDeleteIndex !== null && repoLinks && repoLinks[linkToDeleteIndex] 
              ? `Are you sure you want to delete this repository link?`
              : 'Are you sure you want to delete this repository link?'
          }}
          modalProps={{
            isBlocking: true,
            styles: { main: { maxWidth: 450 } }
          }}
        >
          {linkToDeleteIndex !== null && repoLinks && repoLinks[linkToDeleteIndex] && (
            <div className="mb-4 p-3 bg-gray-100 border border-gray-200 rounded-md break-all">
              <Text className="text-sm text-gray-700">{repoLinks[linkToDeleteIndex]}</Text>
            </div>
          )}
          <DialogFooter>
            <PrimaryButton 
              onClick={() => handleRemoveRepoLink()} 
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

export default EditProject;
