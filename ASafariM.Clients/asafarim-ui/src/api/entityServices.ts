import axios, { AxiosError } from "axios";
import { apiConfig } from "@/config/api";
import { logger } from '@/utils/logger';
import { jwtDecode } from "jwt-decode";

interface JwtPayload {
    role?: string;
    exp?: number;
}

const api = axios.create({
    baseURL: apiConfig.baseURL,
    headers: {
        'Content-Type': 'application/json'
    }
});

// Add request interceptor to include auth token
api.interceptors.request.use((config) => {
    const authData = JSON.parse(localStorage.getItem('auth') || '{}');
    const token = authData?.token;
    
    if (token) {
        config.headers.Authorization = `Bearer ${token}`;
        logger.info(`Added authorization header to request`);
    } else {
        logger.warn('No auth token found in localStorage');        
    }
    return config;
}, (error) => {
    logger.error('Error making request: ' + JSON.stringify(error));
    return Promise.reject(error);
});

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
    const endpoint = tableName.endsWith('s') ? tableName : `${tableName}s`;
    logger.info(`Checking table existence: ${endpoint} in ${apiConfig.baseURL}`);
    try {
        const response = await api.get(`/${endpoint}`);
        return response.status === 200;
    } catch (error) {
        logger.error(`Error checking table existence: ${error}`);
        return false;
    }
}

// CRUD operations for entities from the API
const fetchEntities = async (entityTableName: string) => {
    // Convert singular to plural for API endpoints
    const endpoint = entityTableName.endsWith('s') ? entityTableName : `${entityTableName}s`;
    logger.info(`Fetching entities from endpoint: /${endpoint}`);

    try {
        const response = await api.get(`/${endpoint}`);
        logger.info(`API Response for ${endpoint}:` + JSON.stringify(response.data));
        return response.data;
    } catch (error) {
        const axiosError = error as AxiosError;
        logger.error(`Error fetching entities: ${axiosError.message}`);
        if (axiosError.response) {
            logger.error('Response data:' + JSON.stringify(axiosError.response.data));
            logger.error('Response status:' + axiosError.response.status);
        }
        throw new Error(`Failed to fetch entities from ${entityTableName}`);
    }
};

const fetchEntityById = async (entityTableName: string, id: string) => {
    const endpoint = entityTableName.endsWith('s') ? entityTableName : `${entityTableName}s`;
    try {
        const response = await api.get(`/${endpoint}/${id}`);
        return response.data;
    } catch (error) {
        logger.error(`Error fetching entity by ID: ${error}`);
        throw new Error(`Failed to fetch entity from ${entityTableName}`);
    }
};

const addEntity = async (entityTableName: string, data: Record<string, unknown>) => {
    const endpoint = entityTableName.endsWith('s') ? entityTableName : `${entityTableName}s`;
    try {
        const response = await api.post(`/${endpoint}`, data);
        return response.data;
    } catch (error) {
        logger.error(`Error adding entity: ${error}`);
        throw new Error(`Failed to add entity to ${entityTableName}`);
    }
};

const updateEntity = async (entityTableName: string, id: string, data: Record<string, unknown>) => {
    const endpoint = entityTableName.endsWith('s') ? entityTableName : `${entityTableName}s`;
    try {
        const response = await api.put(`/${endpoint}/${id}`, data);
        return response.data;
    } catch (error) {
        logger.error(`Error updating entity: ${error}`);
        throw new Error(`Failed to update entity in ${entityTableName}`);
    }
};

const deleteEntity = async (entityTableName: string, id: string) => {
    const endpoint = entityTableName.endsWith('s') ? entityTableName : `${entityTableName}s`;
    try {
        const response = await api.delete(`/${endpoint}/${id}`);
        return response.data;
    } catch (error) {
        logger.error(`Error deleting entity: ${error}`);
        throw new Error(`Failed to delete entity from ${entityTableName}`);
    }
};

const dashboardServices = {
    fetchEntities,
    fetchEntityById,
    addEntity,
    updateEntity,
    deleteEntity,
    hasAdminRole,
    tableExistsInDb
};

export default dashboardServices;
