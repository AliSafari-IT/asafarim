import axios, { AxiosError } from "axios";
import { apiConfig } from "@/config/api";
import { logger } from "@/utils/logger";
import { jwtDecode } from "jwt-decode";

interface JwtPayload {
  role?: string;
  exp?: number;
}

// Get auth token
const token = localStorage.getItem('auth') ? JSON.parse(localStorage.getItem('auth')!).token : null;

const api = axios.create({
  baseURL: apiConfig.baseURL,
  headers: {
    "Content-Type": "application/json",
  },
});
if (token) {
  api.defaults.headers.common['Authorization'] = `Bearer ${token}`;
}

// Add request interceptor to include auth token
api.interceptors.request.use(
  (config) => {
    const authData = JSON.parse(localStorage.getItem("auth") || "{}");
    const token = authData?.token;

    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
      logger.info(`Added authorization header to request`);
    } else {
      logger.warn("No auth token found in localStorage");
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
    const authData = JSON.parse(localStorage.getItem("auth") || "{}");
    const token = authData?.token;

    if (!token) {
      logger.warn("No token found when checking admin role");
      return false;
    }

    const decoded = jwtDecode(token) as JwtPayload;
    return decoded.role === "Admin";
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

const fetchEntityById = async (entityTableName: string, id: string) => {
  const endpoint = entityTableName.endsWith("s")
    ? entityTableName
    : `${entityTableName}s`;
  try {
    const response = await api.get(`/${endpoint}/${id}`);
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
    const response = await api.put(`/${endpoint}/${id}`, data);
    return response.data;
  } catch (error) {
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

const dashboardServices = {
  fetchEntities,
  fetchEntityById,
  addEntity,
  updateEntity,
  deleteEntity,
  hasAdminRole,
  tableExistsInDb,
};

export default dashboardServices;
