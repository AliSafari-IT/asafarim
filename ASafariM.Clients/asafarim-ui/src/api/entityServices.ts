import axios, { AxiosError } from "axios";
import { apiConfig } from "@/config/api";
import { logger } from "@/utils/logger";
import { jwtDecode } from "jwt-decode";

const ClaimTypes = {
  NameIdentifier: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"
} as const;

interface JwtPayload {
  role?: string;
  exp?: number;
  [ClaimTypes.NameIdentifier]?: string;
}

// Get auth token from either localStorage or sessionStorage
const getAuthToken = () => {
  try {
    // Check localStorage first
    const localAuth = localStorage.getItem('auth');
    if (localAuth) {
      const parsedAuth = JSON.parse(localAuth);
      return parsedAuth.token || parsedAuth.Token;
    }

    // Then check sessionStorage
    const sessionAuth = sessionStorage.getItem('auth');
    if (sessionAuth) {
      const parsedAuth = JSON.parse(sessionAuth);
      return parsedAuth.token || parsedAuth.Token;
    }

    return null;
  } catch (error) {
    logger.error("Error getting auth token: " + error);
    return null;
  }
};

const api = axios.create({
  baseURL: apiConfig.baseURL,
  headers: {
    "Content-Type": "application/json",
  },
});

// Add request interceptor to include auth token
api.interceptors.request.use(
  (config) => {
    const token = getAuthToken();

    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
      logger.info(`Added authorization header to request`);
    } else {
      logger.info("No auth token found - request will be unauthenticated");
      // Still allow the request to proceed without auth token
      // This is important for public resources that don't require authentication
    }
    return config;
  },
  (error) => {
    logger.error("Error making request: " + JSON.stringify(error));
    return Promise.reject(error);
  }
);

// Add response interceptor to handle errors
api.interceptors.response.use(
  (response) => response,
  (error: AxiosError) => {
    if (error.response) {
      logger.error(
        `API Error ${error.response.status}: ${JSON.stringify(
          error.response.data
        )}`
      );
    } else if (error.request) {
      logger.error("No response received from API");
    } else {
      logger.error("Error setting up request:" + error.message);
    }
    return Promise.reject(error);
  }
);

const hasAdminRole = (): boolean => {
  try {
    const token = getAuthToken();
    if (token) {
      const decodedToken = jwtDecode<JwtPayload>(token);
      logger.info("Decoded Token:", decodedToken);

      // Check for the ClaimTypes.NameIdentifier claim
      const userIdClaim = decodedToken[ClaimTypes.NameIdentifier];
      logger.info("User ID Claim:", userIdClaim);
      return decodedToken.role === "Admin";
    } else {
      logger.error("No token found.");
      return false; // Return false if no token is found
    }
  } catch (error) {
    logger.error("Error checking admin role: " + JSON.stringify(error));
    return false;
  }
};

const tableExistsInDb = async (tableName: string): Promise<boolean> => {
  const endpoint = tableName.endsWith("s") ? tableName : `${tableName}s`;
  logger.info(`Checking table existence: ${endpoint} in ${apiConfig.baseURL}`);
  try {
    const response = await api.get(`/${endpoint}`);
    return response.status === 200;
  } catch (error) {
    logger.error(`Error checking table existence: ${error}`);
    return false;
  }
};

const fetchEntities = async (entityTableName: string) => {
  const endpoint = entityTableName.endsWith("s")
    ? entityTableName
    : `${entityTableName}s`;
  try {
    const response = await api.get(`/${endpoint}`);
    logger.info(`Raw API response for ${endpoint}: ${JSON.stringify(response.data)}`);
    // Handle both array and object responses
    const data = response.data;
    if (Array.isArray(data)) {
      return data;
    } else if (data && typeof data === 'object') {
      // If it's a single object, wrap it in an array
      if (data.id) {
        return [data];
      }
      // If it's a collection with $values property (common in .NET)
      if (data.$values) {
        return data.$values;
      }
      // If it has a value property
      if (data.value) {
        return data.value;
      }
    }

    return [];
  } catch (error) {
    logger.error(`Error fetching ${entityTableName}s: ${error}`);
    throw error;
  }
};

const fetchProjects = async () => {
  const endpoint = "projects";
  try {
    const response = await api.get(`/${endpoint}`);
    logger.info(`Raw API response for ${endpoint}: ${JSON.stringify(response.data)}`);
    // Handle both array and object responses
    const data = response.data;
    if (Array.isArray(data)) {
      return data;
    } else if (data && typeof data === 'object') {
      // If it's a single object, wrap it in an array
      if (data.id) {
        return [data];
      }
      // If it's a collection with $values property (common in .NET)
      if (data.$values) {
        return data.$values;
      }
      // If it has a value property
      if (data.value) {
        return data.value;
      }
    }

    return [];
  } catch (error) {
    logger.error(`Error fetching projects: ${error}`);
    throw error;
  }
};

const fetchEntityById = async (entityTableName: string, id: string) => {
  const endpoint = entityTableName.endsWith("s")
    ? entityTableName
    : `${entityTableName}s`;
  try {
    // The baseURL already includes /api/, so we should NOT add it again
    const response = await api.get(`/${endpoint}/${id}`);
    logger.info(`fetchEntityById: Raw API response for ${endpoint}/${id}: ${JSON.stringify(response.data)}`);
    return response.data;
  } catch (error) {
    logger.error(`Error fetching ${entityTableName} by id: ${error}`);
    throw error;
  }
};

const addEntity = async (
  entityTableName: string,
  data: Record<string, unknown>
) => {
  const endpoint = entityTableName.endsWith("s")
    ? entityTableName
    : `${entityTableName}s`;
  try {
    logger.info(`Adding ${entityTableName} with data: ${JSON.stringify(data)}`);
    const response = await api.post(`/${endpoint}`, data);
    logger.info(`Successfully added ${entityTableName}`);
    return response.data;
  } catch (error) {
    logger.error(`Error adding ${entityTableName}: ${error}`);
    throw error;
  }
};

const updateEntity = async (
  entityTableName: string,
  id: string,
  data: Record<string, unknown>
) => {
  const endpoint = entityTableName.endsWith("s")
    ? entityTableName
    : `${entityTableName}s`;
  try {
    // Log the payload for debugging
    if (data.RepoLinks) {
      logger.info(`Updating ${entityTableName} with repository links. Links count: ${(data.RepoLinks as string[]).length}`);
      // Format repository links as objects with required properties for Link entity
      if (Array.isArray(data.RepoLinks)) {
        // Transform repo links into proper objects with required fields for the Link entity
        const formattedLinks = (data.RepoLinks as string[]).map(url => ({
          Url: url,
          Name: "Repository", // Required field in Link entity
          Description: "Project repository link"
        }));

        // Create a separate property for the formatted links
        data = {
          ...data,
          FormattedRepoLinks: formattedLinks
        };

        logger.info(`Formatted ${formattedLinks.length} repository links for update request`);
      }
    }

    const response = await api.put(`/${endpoint}/${id}`, data);
    return response.data;
  } catch (error: any) {
    // Enhanced error logging
    if (error.response) {
      logger.error(`API Error ${error.response.status}: ${JSON.stringify(error.response.data)}`);

      // If it's a validation error, extract more details
      if (error.response.status === 400 && error.response.data) {
        logger.error(`Validation error: ${JSON.stringify(error.response.data)}`);
      }
    } else if (error.request) {
      logger.error(`No response received: ${error.request}`);
    } else {
      logger.error(`Error setting up request: ${error.message}`);
    }

    logger.error(`Error updating ${entityTableName}: ${error}`);
    throw error;
  }
};

const deleteEntity = async (entityTableName: string, id: string) => {
  const endpoint = entityTableName.endsWith("s")
    ? entityTableName
    : `${entityTableName}s`;
  try {
    await api.delete(`/${endpoint}/${id}`);
    return true;
  } catch (error) {
    logger.error(`Error deleting ${entityTableName}: ${error}`);
    throw error;
  }
};

const addProjectWithLinks = async (projectData: Record<string, unknown>) => {
  try {
    // Extract repository links from the project data
    const repoLinks = projectData.RepoLinks as string[];

    // Remove RepoLinks from the project data as it's not part of the ProjectCreateDto
    const { RepoLinks, ...projectDataWithoutLinks } = projectData as { RepoLinks: string[], [key: string]: unknown };

    logger.info(`Adding project with data: ${JSON.stringify(projectDataWithoutLinks)}`);
    logger.info(`Repository links: ${JSON.stringify(repoLinks)}`);

    // First create the project
    const response = await api.post('/projects', projectDataWithoutLinks);
    const createdProject = response.data;
    logger.info(`Successfully added project with ID: ${createdProject.id}`);

    // If there are repository links, add them to the project
    if (repoLinks && repoLinks.length > 0) {
      logger.info(`Adding ${repoLinks.length} repository links to project ${createdProject.id}`);

      // Add each repository link to the project
      for (const link of repoLinks) {
        try {
          await api.post(`/projects/${createdProject.id}/links`, { url: link });
          logger.info(`Added repository link ${link} to project ${createdProject.id}`);
        } catch (linkError) {
          logger.error(`Error adding repository link ${link} to project ${createdProject.id}: ${linkError}`);
          // Continue with other links even if one fails
        }
      }
    }

    return createdProject;
  } catch (error) {
    logger.error(`Error adding project: ${error}`);
    throw error;
  }
};

const fetchEntityRepoLinks = async (entityTableName: string, entityId: string) => {
  const endpoint = entityTableName.endsWith("s")
    ? entityTableName
    : `${entityTableName}s`;
  try {
    logger.info(`Fetching repository links for ${entityTableName} with ID ${entityId}`);
    // The baseURL already includes /api/, so we should NOT add it again
    const response = await api.get(`/${endpoint}/${entityId}/links`);
    logger.info(`Successfully fetched repository links: ${JSON.stringify(response.data)}`);
    logger.log('Raw API response data:', response.data);
    logger.log('Type of response data:', typeof response.data);
    logger.log('Is Array?', Array.isArray(response.data));
    if (response.data && response.data.$values) {
      logger.log('Found $values property:', response.data.$values);
      return response.data.$values;
    }

    // If the response is already an array, return it
    if (Array.isArray(response.data)) {
      logger.log('Response is an array with length:', response.data.length);
      return response.data;
    }

    // Otherwise, return an empty array
    logger.log('Returning empty array as fallback');
    return [];
  } catch (error) {
    const axiosError = error as AxiosError;

    // If it's an authentication error, we should propagate it
    if (axiosError.response?.status === 401) {
      logger.error(`Authentication error when fetching repository links: ${axiosError.message}`);
      throw error; // Re-throw authentication errors to be handled by caller
    }

    // For other errors, log and return empty array
    logger.error(`Failed to fetch repository links: ${error}`);
    return [];
  }
};

const dashboardServices = {
  fetchEntities,
  fetchEntityById,
  addEntity,
  updateEntity,
  deleteEntity,
  fetchEntityRepoLinks,
  hasAdminRole,
  tableExistsInDb,
  fetchProjects,
  addProjectWithLinks,
};

export default dashboardServices;
