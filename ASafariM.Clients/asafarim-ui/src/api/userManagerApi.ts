import { ICreateUserModel } from '@/interfaces/ICreateUserModel';
import { logger } from '@/utils/logger';
import axios from 'axios';
import { getApiConfig } from '@/config/apiConfig';
import { handleApiError, retryRequest } from '@/utils/apiErrorHandler';

// Get current API configuration
const apiConfig = getApiConfig();
const isDevelopment = import.meta.env.VITE_ENVIRONMENT === 'development';
const BASE_API_URL = isDevelopment ? 'http://localhost:5000/api' : 'https://asafarim.com/api';
const USERS_URL = `${BASE_API_URL}/users`;

const api = axios.create({
    baseURL: BASE_API_URL,
    timeout: apiConfig.timeout, // Use configurable timeout
    headers: {
        'Content-Type': 'application/json',
        'Accept': '*/*'
    },
    withCredentials: false
});

// Add request interceptor for handling errors
api.interceptors.request.use(
    (config) => {
        return config;
    },
    (error) => {
        logger.error('Request error:', error);
        return Promise.reject(error);
    }
);

// Add response interceptor for handling errors
api.interceptors.response.use(
    (response) => {
        return response;
    },
    (error) => {
        if (error.code === 'ECONNABORTED') {
            logger.error('Request timeout - The server took too long to respond');
        } else if (error.message === 'Network Error') {
            logger.error('Network Error - Please check if the API server is running and CORS is properly configured');
        } else if (error.response) {
            logger.error(`API Error ${error.response.status}: ${error.response.data?.message || error.response.statusText}`);
        } else if (error.request) {
            logger.error('No response received from server');
        } else {
            logger.error('Error setting up request:', error.message);
        }
        return Promise.reject(error);
    }
);

// Create User
export const createUser = async (userData: ICreateUserModel) => {
    try {
        logger.debug("userManagerApi.ts createUser", userData);
        const response = await api.post(USERS_URL, userData, {
            headers: {
                'Accept': '*/*',
                'Content-Type': 'application/json'
            }
        });
        logger.debug("userManagerApi.ts createUser: response", response);
        
        if (response.status === 201 || response.status === 200) {
            return { success: true, data: response.data };
        }
        
        return { success: false, message: 'Unexpected response status' };
    } catch (error) {
        logger.error('Error creating user:', error);
        throw new Error(handleApiError(error));
    }
};

// Create User by Admin
export const addUserByAdmin = async (userData: ICreateUserModel) => {
    try {
        logger.debug("userManagerApi.ts addUserByAdmin", userData);
        const response = await api.post(`${USERS_URL}/admin`, userData, {
            headers: {
                'Accept': '*/*',
                'Content-Type': 'application/json'
            }
        });
        logger.debug("userManagerApi.ts addUserByAdmin: response", response);
        
        if (response.status === 201 || response.status === 200) {
            return { success: true, data: response.data };
        }
        
        return { success: false, message: 'Unexpected response status' };
    } catch (error) {
        logger.error('Error in addUserByAdmin:', error);
        throw new Error(handleApiError(error));
    }
};

// Fetch Users (with retry for better reliability)
export const getUsers = async () => {
    try {
        return await retryRequest(
            async () => {
                const response = await api.get('/users');
                logger.debug("userManagerApi.ts getUsers: response.data", response.data);
                return response.data;
            },
            'getUsers'
        );
    } catch (error) {
        logger.error('Error fetching users:', error);
        throw new Error(handleApiError(error));
    }
};

// Get User by ID
export const getUserById = async (id: string) => {
    try {
        const response = await api.get(`/users/${id}`);
        logger.debug("userManagerApi.ts getUserById: response.data", response.data);
        return response.data;
    } catch (error) {
        logger.error('Error fetching user by ID:', error);
        throw new Error(handleApiError(error));
    }
};

// Update User
export const updateUser = async (id: string, userData: { fullName: string, isAdmin: boolean }) => {
    try {
        logger.debug("userManagerApi.ts updateUser: userData", userData);
        const response = await api.put(`/users/${id}`, userData);
        logger.debug("userManagerApi.ts updateUser: response.data", response.data);
        return response.data;
    } catch (error) {
        logger.error('Error updating user:', error);
        throw new Error(handleApiError(error));
    }
};

// Delete User
export const deleteUser = async (id: string) => {
    try {
        const response = await api.delete(`/users/${id}`);
        logger.debug("userManagerApi.ts deleteUser: response.data", response.data);
        return response.data;
    } catch (error) {
        logger.error('Error deleting user:', error);
        throw new Error(handleApiError(error));
    }
};
