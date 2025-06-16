// src/pages/Project/AddProject.tsx
import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import Wrapper from "@/layout/Wrapper";
import entityServices from "@/api/entityServices";
import { logger } from "@/utils/logger";
import { TextField } from "@fluentui/react/lib/TextField";
import { PrimaryButton, DefaultButton, IconButton, ActionButton } from "@fluentui/react/lib/Button";
import { Text } from "@fluentui/react/lib/Text";
import { Dialog, DialogType, DialogFooter } from "@fluentui/react/lib/Dialog";
import { Spinner, SpinnerSize } from "@fluentui/react/lib/Spinner";
import { Stack } from "@fluentui/react/lib/Stack";
import { Dropdown, IDropdownOption } from "@fluentui/react/lib/Dropdown";
import { 
  Add20Regular, 
  Delete24Regular, 
  Search24Regular, 
  ArrowLeft24Regular, 
  Save20Regular,
  CheckmarkCircle24Regular,
  DismissCircle24Regular} from "@fluentui/react-icons";
import axios from "axios";
import Toolbar from "@/components/Toolbars/Toolbar";
import { useAuth } from '@/contexts/AuthContext';
import { motion } from "framer-motion";

interface FieldError {
  name: string;
  message: string;
}

const AddProject: React.FC = () => {
  const navigate = useNavigate();
  const [error, setError] = useState<string | null>(null);
  const [success, setSuccess] = useState<string | null>(null);
  const [loading, setLoading] = useState(false);
  const [repoLinks, setRepoLinks] = useState<string[]>([]);
  const [newRepoLink, setNewRepoLink] = useState("");
  const { authenticated, authenticatedUser } = useAuth();
  const [fieldErrors, setFieldErrors] = useState<FieldError[]>([]);
  const [touchedFields, setTouchedFields] = useState<Set<string>>(new Set());
  
  // Check authentication when component mounts
  useEffect(() => {
    if (!authenticated) {
      logger.warn("Unauthenticated user attempted to access AddProject page");
      // Store notification message in sessionStorage to display it on the projects page
      sessionStorage.setItem('projectNotification', JSON.stringify({
        type: 'warning',
        message: 'You must be logged in to add or edit a project'
      }));
      // Redirect to projects list page
      navigate('/projects');
    }
  }, [authenticated, navigate]);
  
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
  
  // Validate a single field
  const validateField = (name: string, value: any): string | null => {
    switch(name) {
      case 'name':
        return !value || value.trim() === '' 
          ? 'Project name is required' 
          : null;
      case 'description':
        return value && value.length > maxDescriptionLength 
          ? `Description must be ${maxDescriptionLength} characters or less` 
          : null;
      case 'startDate':
        if (formData.endDate && value) {
          const start = new Date(value);
          const end = new Date(formData.endDate);
          return start > end 
            ? 'Start date cannot be after end date' 
            : null;
        }
        return null;
      case 'endDate':
        if (formData.startDate && value) {
          const start = new Date(formData.startDate);
          const end = new Date(value);
          return end < start 
            ? 'End date cannot be before start date' 
            : null;
        }
        return null;
      case 'budget':
        return value && isNaN(parseFloat(value)) 
          ? 'Budget must be a valid number' 
          : null;
      default:
        return null;
    }
  };
  
  // Validate all fields
  const validateForm = (): boolean => {
    const errors: FieldError[] = [];
    
    // Required fields
    if (!formData.name || formData.name.trim() === '') {
      errors.push({ name: 'name', message: 'Project name is required' });
    }
    
    // Description length
    if (formData.description && formData.description.length > maxDescriptionLength) {
      errors.push({ 
        name: 'description', 
        message: `Description must be ${maxDescriptionLength} characters or less` 
      });
    }
    
    // Date validation
    if (formData.startDate && formData.endDate) {
      const start = new Date(formData.startDate);
      const end = new Date(formData.endDate);
      if (start > end) {
        errors.push({ name: 'startDate', message: 'Start date cannot be after end date' });
        errors.push({ name: 'endDate', message: 'End date cannot be before start date' });
      }
    }
    
    // Budget validation
    if (formData.budget && isNaN(parseFloat(formData.budget))) {
      errors.push({ name: 'budget', message: 'Budget must be a valid number' });
    }
    
    setFieldErrors(errors);
    return errors.length === 0;
  };
  
  // Get error message for a field
  const getFieldError = (fieldName: string): string | undefined => {
    if (!touchedFields.has(fieldName)) return undefined;
    const error = fieldErrors.find(err => err.name === fieldName);
    return error?.message;
  };
  
  // Handle form changes
  const handleChange = (
    event: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>,
    newValue?: string
  ) => {
    const target = event.target as HTMLInputElement;
    const name = target.name;
    const value = newValue || target.value;
    
    // Mark field as touched
    setTouchedFields(prev => new Set(prev).add(name));
    
    // Update character count for description field
    if (name === "description") {
      setDescriptionCharCount(value.length);
    }
    
    // Update form data
    setFormData(prev => {
      const updated = { ...prev, [name]: value };
      
      // Validate the field
      const errorMessage = validateField(name, value);
      
      // Update field errors
      setFieldErrors(prev => {
        const filtered = prev.filter(err => err.name !== name);
        return errorMessage ? [...filtered, { name, message: errorMessage }] : filtered;
      });
      
      return updated;
    });
  };

  const handleDropdownChange = (
    _event: React.FormEvent<HTMLDivElement>,
    option?: IDropdownOption,
    name?: string
  ) => {
    if (option && name) {
      // Mark field as touched
      setTouchedFields(prev => new Set(prev).add(name));
      
      setFormData(prev => {
        const updated = { ...prev, [name]: option.key.toString() };
        
        // Validate the field
        const errorMessage = validateField(name, option.key.toString());
        
        // Update field errors
        setFieldErrors(prev => {
          const filtered = prev.filter(err => err.name !== name);
          return errorMessage ? [...filtered, { name, message: errorMessage }] : filtered;
        });
        
        return updated;
      });
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
        logger.debug('Adding manual link:', newRepoLink);
        logger.debug('New links array:', newLinks);
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
      let allRepos: any[] = [];
      let page = 1;
      const perPage = 100; // Maximum allowed per page
      
      while (true) {
        const response = await axios.get(`https://api.github.com/users/AliSafari-IT/repos?page=${page}&per_page=${perPage}&sort=updated`);
        const repos = response.data;
        
        if (repos.length === 0) {
          // No more repositories to fetch
          break;
        }
        
        allRepos = [...allRepos, ...repos];
        
        // If we got less than perPage repos, we've reached the end
        if (repos.length < perPage) {
          break;
        }
        
        page++;
      }
      
      setGithubRepos(allRepos);
      logger.info(`Fetched ${allRepos.length} GitHub repositories across ${page} pages`);
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
      let allGists: any[] = [];
      let page = 1;
      const perPage = 100; // Maximum allowed per page
      
      while (true) {
        const response = await axios.get(`https://api.github.com/users/AliSafari-IT/gists?page=${page}&per_page=${perPage}`);
        const gists = response.data;
        
        if (gists.length === 0) {
          // No more gists to fetch
          break;
        }
        
        allGists = [...allGists, ...gists];
        
        // If we got less than perPage gists, we've reached the end
        if (gists.length < perPage) {
          break;
        }
        
        page++;
      }
      
      setGithubGists(allGists);
      logger.info(`Fetched ${allGists.length} GitHub gists across ${page} pages`);
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
    setError(null);
    setSuccess(null);
    setFieldErrors([]);

    try {
      // Enhanced authentication check with detailed logging
      if (!authenticated || !authenticatedUser) {
        logger.error("Authentication check failed:", { authenticated, authenticatedUser });
        setError("You must be logged in to create a project. Please log in and try again.");
        setLoading(false);
        return;
      }

      // Enhanced user ID validation with multiple fallback options
      let userId = authenticatedUser.id || authenticatedUser.Id || authenticatedUser.userId || authenticatedUser.UserId;
      
      if (!userId) {
        logger.error("User ID extraction failed. Available user properties:", Object.keys(authenticatedUser));
        logger.error("Full authenticated user object:", authenticatedUser);
        setError("Unable to determine user ID. Please log out and log back in, then try again.");
        setLoading(false);
        return;
      }

      logger.info("Creating project with user ID:", userId);

      // Check if auth token is available
      const token = localStorage.getItem('auth') || sessionStorage.getItem('auth');
      if (!token) {
        logger.error("No authentication token found in storage");
        setError("Authentication token not found. Please log in again.");
        setLoading(false);
        return;
      }

      // Validate form data before sending
      if (!formData.name.trim()) {
        setError("Project name is required");
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

      // Get current date in ISO format (YYYY-MM-DD)
      const today = new Date();
      const todayFormatted = today.toISOString().split('T')[0];

      const projectData = {
        Name: formData.name.trim(),
        Description: formData.description.trim(),
        // Use today's date as default if not provided
        StartDate: formData.startDate ? formData.startDate : todayFormatted,
        // Set EndDate to null if not provided (optional field)
        EndDate: formData.endDate || null,
        Budget: parseFloat(formData.budget) || 0,
        Visibility: parseInt(formData.visibility, 10) || 0,
        Status: parseInt(formData.status, 10) || 0,
        OwnerId: userId,
        RepoLinks: validLinks // Add validated repository links to the project data
      };

      // Format dates properly for the API
      try {
        // Always ensure StartDate is properly formatted
        const startDate = new Date(projectData.StartDate);
        if (isNaN(startDate.getTime())) {
          // If invalid, use today's date
          projectData.StartDate = todayFormatted;
        } else {
          // Format date as yyyy-MM-dd to avoid timezone issues
          projectData.StartDate = startDate.toISOString().split('T')[0];
        }
        
        // Format EndDate if provided
        if (projectData.EndDate) {
          const endDate = new Date(projectData.EndDate);
          if (isNaN(endDate.getTime())) {
            // If invalid, set to null (optional field)
            projectData.EndDate = null;
          } else {
            // Format date as yyyy-MM-dd to avoid timezone issues
            projectData.EndDate = endDate.toISOString().split('T')[0];
          }
        }
        
        logger.info("Sending project data with formatted dates:", JSON.stringify(projectData, null, 2));
        
        // Show a temporary success message
        setSuccess("Creating your project...");
        
        // Use the standard addEntity function now that the backend supports repository links
        const result = await entityServices.addEntity("project", projectData);

        if (result) {
          logger.info("Project created successfully:", JSON.stringify(result));
          setSuccess("Project created successfully! Redirecting...");
          
          // Redirect after a short delay to show the success message
          setTimeout(() => {
            window.location.href = "/projects";
          }, 1500);
        } else {
          throw new Error("Failed to create project - no result returned");
        }
      } catch (formatError) {
        // Handle date formatting errors gracefully
        setError("There was an issue with the date format. Using today's date for start date.");
        logger.warn("Date formatting error, using defaults:", formatError);
        
        // Try again with today's date
        projectData.StartDate = todayFormatted;
        projectData.EndDate = null;
        
        try {
          const result = await entityServices.addEntity("project", projectData);
          if (result) {
            logger.info("Project created successfully with default dates:", JSON.stringify(result));
            setSuccess("Project created successfully! Redirecting...");
            
            // Redirect after a short delay to show the success message
            setTimeout(() => {
              window.location.href = "/projects";
            }, 1500);
          } else {
            throw new Error("Failed to create project - no result returned");
          }
        } catch (retryError) {
          throw retryError; // Re-throw to be handled by the outer catch block
        }
      }
    } catch (error) {
      logger.error("Error creating project:", error);
      logger.error("Error details:", {
        message: error instanceof Error ? error.message : 'Unknown error',
        stack: error instanceof Error ? error.stack : undefined,
        response: axios.isAxiosError(error) ? error.response : undefined
      });
      setSuccess(null);
      
      // Enhanced error handling with more specific messages
      if (axios.isAxiosError(error)) {
        const { response, request, message } = error;
        
        if (response) {
          // Server responded with error status
          const { status, data } = response;
          logger.error(`API Error Response - Status: ${status}, Data:`, data);
          
          if (status === 400) {
            // Handle validation errors from the API
            if (data.errors) {
              // If we have a structured validation errors object
              const apiFieldErrors: FieldError[] = [];
              
              Object.entries(data.errors).forEach(([field, messages]) => {
                const fieldName = field.toLowerCase();
                const message = Array.isArray(messages) ? messages.join(', ') : String(messages);
                
                // Clean up technical error messages
                let userFriendlyMessage = message;
                if (message.includes("JSON value could not be converted to System.DateTime")) {
                  userFriendlyMessage = "Please enter a valid date format";
                } else if (message.includes("projectDto field is required")) {
                  userFriendlyMessage = "This field is required";
                }
                
                // Add to field errors
                apiFieldErrors.push({ name: fieldName, message: userFriendlyMessage });
                
                // Mark field as touched
                setTouchedFields(prev => new Set(prev).add(fieldName));
              });
              
              setFieldErrors(apiFieldErrors);
              
              // Create a summary error message
              const errorFields = apiFieldErrors.map(err => {
                const fieldLabel = err.name.charAt(0).toUpperCase() + err.name.slice(1);
                return fieldLabel;
              }).join(', ');
              
              setError(`Please fix the following fields: ${errorFields}`);
              
              // Scroll to the first field with an error
              if (apiFieldErrors.length > 0) {
                const firstErrorField = document.getElementsByName(apiFieldErrors[0].name)[0];
                if (firstErrorField) {
                  firstErrorField.scrollIntoView({ behavior: 'smooth', block: 'center' });
                  firstErrorField.focus();
                }
              }
            } else if (data.message) {
              // If we have a single error message
              setError(data.message);
            } else if (typeof data === 'string') {
              // If the response is a string
              setError(data);
            } else {
              // Fallback for other 400 errors
              setError("Please check your input and try again.");
            }
          } else if (status === 401) {
            setError("Your session has expired. Please log in again to continue.");
          } else if (status === 403) {
            setError("You don't have permission to create projects.");
          } else if (status === 500) {
            setError("We're experiencing technical difficulties. Please try again later.");
          } else {
            // Generic error with status code
            setError(`Something went wrong (${status}). Please try again.`);
          }
        } else if (request) {
          // Request was made but no response received - this is the "Network Error" case
          logger.error("Network Error - No response received:", request);
          setError("Network Error: Unable to connect to the server. Please check your internet connection and ensure the API service is running. If you're in development mode, make sure the backend API is started on the correct port.");
        } else {
          // Something else happened
          logger.error("Request setup error:", message);
          setError(`Request Error: ${message}. Please try again.`);
        }
      } else {
        // Non-Axios error
        const errorMessage = error instanceof Error ? error.message : "Unable to create project. Please try again.";
        logger.error("Non-Axios error:", errorMessage);
        setError(errorMessage);
      }
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
    const errorMessage = getFieldError(field.name);
    const hasError = !!errorMessage;
    
    return (
      <div
        key={field.name}
        className={`p-4 bg-[var(--bg-secondary)] border ${hasError ? 'border-red-400' : 'border-[var(--border-primary)]'} rounded-lg shadow-md transition-all duration-200 ${hasError ? 'shadow-red-100' : ''}`}
      >
        <div className="flex justify-between items-center mb-2">
          <Text
            as="label"
            className={`block font-medium ${hasError ? 'text-red-600' : 'text-[var(--text-primary)]'}`}
          >
            {field.label}{field.name === 'name' && <span className="text-red-500 ml-1">*</span>}:
            {field.name === "description" && (
              <span className={`ml-2 text-sm ${descriptionCharCount > maxDescriptionLength ? 'text-red-500 font-bold' : 'text-gray-500'}`}>
                {descriptionCharCount}/{maxDescriptionLength}
              </span>
            )}
          </Text>
          
          {hasError && (
            <motion.div
              initial={{ opacity: 0, y: -10 }}
              animate={{ opacity: 1, y: 0 }}
              className="flex items-center text-red-600 text-sm"
            >
              <DismissCircle24Regular className="mr-1" />
              <span>{errorMessage}</span>
            </motion.div>
          )}
        </div>
        
        {field.type === "select" ? (
          <Dropdown
            placeholder="Select an option"
            options={
              field.name === "visibility" ? visibilityOptions : statusOptions
            }
            selectedKey={formData[field.name as keyof typeof formData]}
            onChange={(e, option) => handleDropdownChange(e, option, field.name)}
            styles={{
              root: { 
                borderColor: hasError ? 'var(--red-400)' : undefined,
                selectors: {
                  ':hover': {
                    borderColor: hasError ? 'var(--red-500)' : undefined
                  }
                }
              }
            }}
          />
        ) : (
          <TextField
            name={field.name}
            type={field.type}
            value={formData[field.name as keyof typeof formData]}
            onChange={handleChange}
            multiline={field.type === "textarea"}
            rows={field.type === "textarea" ? 4 : undefined}
            errorMessage={errorMessage}
            className={hasError ? 'error-field' : ''}
            styles={{
              fieldGroup: { 
                borderColor: hasError ? 'var(--red-400)' : undefined,
                selectors: {
                  ':hover': {
                    borderColor: hasError ? 'var(--red-500)' : undefined
                  }
                }
              }
            }}
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
        <motion.div
          initial={{ opacity: 0, y: -20 }}
          animate={{ opacity: 1, y: 0 }}
          className="max-w-5xl mx-auto p-4 mb-4 bg-red-50 border-l-4 border-red-500 rounded-md shadow-md"
        >
          <div className="flex items-start">
            <div className="flex-shrink-0 pt-0.5">
              <DismissCircle24Regular className="h-5 w-5 text-red-500" />
            </div>
            <div className="ml-3">
              <h3 className="text-sm font-medium text-red-800">
                There was an error creating your project
              </h3>
              <div className="mt-2 text-sm text-red-700">
                {error}
              </div>
            </div>
          </div>
        </motion.div>
      )}

      {success && (
        <motion.div
          initial={{ opacity: 0, y: -20 }}
          animate={{ opacity: 1, y: 0 }}
          className="max-w-5xl mx-auto p-4 mb-4 bg-green-50 border-l-4 border-green-500 rounded-md shadow-md"
        >
          <div className="flex items-start">
            <div className="flex-shrink-0 pt-0.5">
              <CheckmarkCircle24Regular className="h-5 w-5 text-green-500" />
            </div>
            <div className="ml-3">
              <h3 className="text-sm font-medium text-green-800">
                Success
              </h3>
              <div className="mt-2 text-sm text-green-700">
                {success}
              </div>
            </div>
          </div>
        </motion.div>
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
                {filteredRepos.map((item, index) => (
                  <div 
                    key={`${item.name}-${index}`}
                    className="p-3 border-b border-[var(--border-primary)] hover:bg-[var(--bg-secondary)] flex items-center cursor-pointer"
                    onClick={(e) => {
                      e.preventDefault();
                      e.stopPropagation();
                      logger.debug('Selected repository:', item.name);
                      // Add the URL directly to the repoLinks array
                      const newLinks = [...repoLinks];
                      if (!newLinks.includes(item.html_url)) {
                        newLinks.push(item.html_url);
                        setRepoLinks(newLinks);
                        logger.debug('Added repository:', item.name);
                        logger.debug('New links array:', newLinks);
                      }
                      setIsModalOpen(false);
                    }}
                  >
                    <div className="flex-shrink-0 mr-3 text-teal-500 hover:text-teal-600">
                      <Add20Regular />
                    </div>
                    <div className="flex-grow min-w-0">
                      <Text className="font-medium">{item.name}</Text>
                      <Text className="text-sm text-[var(--text-secondary)] truncate">{item.html_url}</Text>
                      {item.description && (
                        <Text className="text-xs text-[var(--text-secondary)] truncate mt-1">{item.description}</Text>
                      )}
                    </div>
                  </div>
                ))}
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
                <div className="max-h-80 overflow-y-auto">
                  {filteredGists.map((item, index) => (
                    <div 
                      key={`${item.description}-${index}`}
                      className="p-3 border-b border-[var(--border-primary)] hover:bg-[var(--bg-secondary)] flex items-center cursor-pointer"
                      onClick={(e) => {
                        e.preventDefault();
                        e.stopPropagation();
                        logger.debug('Selected gist:', item.description);
                        // Add the URL directly to the repoLinks array
                        const newLinks = [...repoLinks];
                        if (!newLinks.includes(item.html_url)) {
                          newLinks.push(item.html_url);
                          setRepoLinks(newLinks);
                          logger.debug('Added gist:', item.description);
                          logger.debug('New links array:', newLinks);
                        }
                        setIsGistModalOpen(false);
                      }}
                    >
                      <div className="flex-shrink-0 mr-3 text-teal-500 hover:text-teal-600">
                        <Add20Regular />
                      </div>
                      <div className="flex-grow min-w-0">
                        <Text className="font-medium">{item.description}</Text>
                        <Text className="text-sm text-[var(--text-secondary)] truncate">{item.html_url}</Text>
                        {item.files && (
                          <Text className="text-xs text-[var(--text-secondary)] truncate mt-1">{Object.keys(item.files).join(', ')}</Text>
                        )}
                      </div>
                    </div>
                  ))}
                </div>
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
