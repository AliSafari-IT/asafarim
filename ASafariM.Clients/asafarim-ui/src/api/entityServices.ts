// E:\asm\apps\dashboard-client\src\api\dashboardServices.ts
import axios, { AxiosError } from "axios";
import apiUrls from "./getApiUrls";
import { logger } from '@/utils/logger';
import { jwtDecode } from "jwt-decode";

interface JwtPayload {
    role?: string;
    exp?: number;
}

const api = axios.create({
    baseURL: apiUrls(window.location.hostname)
});

// Add request interceptor to include auth token
api.interceptors.request.use((config) => {
    const authData = JSON.parse(localStorage.getItem('auth') || '{}');
    const token = authData?.token;
    
    if (token) {
        config.headers.Authorization = `Bearer ${token}`;
        logger.info(`Added authorization header to request: ${config.headers.Authorization}`);
    } else {
        logger.warn('No auth token found in localStorage');        
    }
    return config;
}, (error) => {
    logger.error('Error making request: ' + JSON.stringify(error));
    return Promise.reject(error);
});

api.defaults.headers.post['Content-Type'] = 'application/json';
api.defaults.headers.put['Content-Type'] = 'application/json';
api.defaults.headers.patch['Content-Type'] = 'application/json';
api.defaults.headers.delete['Content-Type'] = 'application/json';
api.defaults.headers.get['Content-Type'] = 'application/json';

const hasAdminRole = (): boolean => {
    try {
        const authData = JSON.parse(localStorage.getItem('auth') || '{}');
        const token = authData?.token;
        
        if (!token) {
            logger.warn('No token found when checking admin role');
            return false;
        }

        const decoded = jwtDecode(token) as JwtPayload;
        return decoded.role === 'Admin';
    } catch (error) {
        logger.error('Error checking admin role: ' + JSON.stringify(error));
        return false;
    }
};

const tableExistsInDb = async (tableName: string): Promise<boolean> => {
    logger.info(`Checking table existence: ${tableName} in ${apiUrls(window.location.hostname)}`);
    try {
        const response = await api.get(`${tableName}`);
        return response.status === 200;
    } catch {
        return false;
    }
}
// CRUD operations for entities from the API
const fetchEntities = async (entityTableName: string) => {
    // Validate the entity table name
    if (!tableExistsInDb(`${entityTableName}`)) {
        throw new Error(`Entity does not exist: ${entityTableName}`);
    }
    try {
        // Convert singular to plural for API endpoints
        const endpoint = entityTableName.endsWith('s') ? entityTableName : `${entityTableName}s`;
        logger.info(`Fetching entities from endpoint: /${endpoint}`);

        const response = await api.get(`/${endpoint}`);
        logger.info(`Response from ${endpoint}: ${JSON.stringify(response.data)}`);

        return {
            success: true,
            data: response.data
        };
    } catch (error) {
        logger.error(`Error fetching ${entityTableName}: ${JSON.stringify(error)}`);
        throw error;
    }
};

/**
 * Fetch a single entity by its ID from the specified table in the API.
 * @param {string} entityTableName The name of the table in the API to fetch the entity from.
 * @param {string} id The ID of the entity to fetch.
 * @returns {Promise<any>} A promise that resolves to the fetched entity.
 * @throws {Error} If the fetch operation fails, an error is thrown with a message indicating the failure.
 */
const fetchEntityById = async (entityTableName: string, id: string): Promise<unknown> => {
    // Validate the entity table name
    if (!tableExistsInDb(`${entityTableName}`)) {
        throw new Error(`Entity does not exist: ${entityTableName}`);
    }

    if (!id) {
        throw new Error('No ID provided');
    }

    const url = `/${entityTableName}/${id}`;

    logger.info(`Fetching entity by ID from ${entityTableName} ${id}`);
    return api.get(url)
        .then(response => {
            logger.info(`Fetched entity by ID from ${entityTableName}: ${JSON.stringify(response.data)}`);
            return response.data;
        })
        .catch(error => {
            logger.error(`Error fetching entity by ID from ${entityTableName}: ${JSON.stringify(error)}`);
            throw new Error('Failed to fetch entity: ' + entityTableName);
        });
}

const addEntity = async (entityTableName: string, data: Record<string, unknown>) => {
    logger.info(`Initiating addEntity function for table: ${entityTableName} with data: ${JSON.stringify(data)}`);

    // Validate the entity table name
    if (!await tableExistsInDb(entityTableName)) {
        logger.error(`Entity table does not exist: ${entityTableName}`);
        throw new Error(`Entity does not exist: ${entityTableName}`);
    }

    const url = `/${entityTableName}`;
    logger.info(`Constructed URL for adding entity: ${url}`);

    const sanitizedData = { ...data, id: undefined };
    logger.info(`Sanitized data for POST request: ${JSON.stringify(sanitizedData)}`);

    try {
        const response = await api.post(url, sanitizedData);
        logger.info(`Successfully added entity to ${entityTableName}: ${JSON.stringify(response.data)}`);
        return response.data;
    } catch (error) {
        logger.error(`Error adding entity to ${entityTableName}: ${JSON.stringify(error)}`);
        throw new Error(`Failed to add entity: ${entityTableName}`);
    }
}


const updateEntity = async (entityTableName: string, id: string, data: Record<string, unknown>) => {
    try {
        const endpoint = entityTableName.endsWith('s') ? entityTableName : `${entityTableName}s`;
        logger.info(`Updating entity in ${endpoint}: ${JSON.stringify({ id, data })}`);

        const url = `/${endpoint}/${id}`;
        logger.info(`Constructed URL for updating entity: ${url}`);

        const sanitizedData = { ...data };
        delete sanitizedData.id;

        logger.info(`Sanitized data for PUT request: ${JSON.stringify(sanitizedData)}`);

        // Send the PUT request to update the entity
        const response = await api.put(url, sanitizedData);
        logger.info(`Successfully updated entity in ${endpoint}: ${JSON.stringify(response.data)}`);

        return {
            success: true,
            data: response.data
        };
    } catch (error: unknown) {
        if (error instanceof AxiosError) {
            if (error.response?.status === 404) {
                logger.error(`Entity not found: ${entityTableName}`);
                throw new Error(`Entity not found: ${entityTableName}`);
            } else if (error.response?.status === 400) {
                logger.error(`Invalid data for update: ${JSON.stringify(error.response.data)}`);
                throw new Error(error.response.data || `Invalid data for update: ${entityTableName}`);
            } else {
                logger.error(`Error updating entity in ${entityTableName}: ${JSON.stringify(error.response?.data)}`);
                throw error;
            }
        } else {
            logger.error(`Error updating entity in ${entityTableName}: ${JSON.stringify(error)}`);
            throw error;
        }
    }
}

const deleteEntity = async (entityTableName: string, id: string) => {
    if (entityTableName === 'topics' && !hasAdminRole()) {
        logger.error('Unauthorized: Admin role required to delete topics');
        throw new Error('You must be an administrator to delete topics.');
    }

    const url = `/${entityTableName}/${id}`;
    logger.info(`Deleting entity from ${entityTableName}: ${id}`);
    logger.info(`Constructed URL for deleting entity: ${url}`);
    logger.info(`Sending DELETE request to delete entity: ${url}`);
    
    try {
        const response = await api.delete(url);
        logger.info(`Successfully deleted entity from ${entityTableName}: ${JSON.stringify(response.data)}`);
        return response.data;
    } catch (error) {
        const err = error as AxiosError;
        if (err.response?.status === 401) {
            logger.error('Authentication error: User is not authorized');
            throw new Error('You are not authorized to perform this action. Please log in again.');
        } else if (err.response?.status === 403) {
            logger.error('Authorization error: User does not have required permissions');
            throw new Error('You do not have permission to perform this action. Admin access required.');
        } else {
            logger.error('Error deleting entity: ' + JSON.stringify(error));
            throw error;
        }
    }
}

const createEntity = async (entityTableName: string, data: Record<string, unknown>) => {
    const url = `/${entityTableName}/create`;
    logger.info('Creating entity at ' + url + ' with data: ' + JSON.stringify(data));
    try {
        const response = await api.post(url, data);
        logger.info('Successfully created entity at ' + url);
        return {
            success: true,
            data: response.data
        };
    } catch (error) {
        logger.error('Error creating entity: ' + JSON.stringify(error));
        return {
            success: false,
            error: error
        };
    }
};

const dashboardServices = {
    fetchEntities, fetchEntityById, addEntity, updateEntity, deleteEntity, createEntity,
}

export default dashboardServices;
