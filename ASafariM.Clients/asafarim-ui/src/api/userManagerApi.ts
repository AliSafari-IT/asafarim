import { ICreateUserModel } from '@/interfaces/ICreateUserModel';
import axios from 'axios';
const isDevelopment = import.meta.env.VITE_ENVIRONMENT === 'development';
const BASE_API_URL = isDevelopment ? 'https://localhost:5001/api' : 'https://asafarim.com/api';
const USERS_URL = `${BASE_API_URL}/users`;  // Changed to lowercase to match backend route

const api = axios.create({
    baseURL: BASE_API_URL,  // Adjust according to your backend URL
    headers: {
        'Content-Type': 'application/json',
        'Accept': '*/*'  // Match the curl request
    },
    withCredentials: false // Changed to false since the backend doesn't require credentials
});

// Add request interceptor for handling errors
api.interceptors.request.use(
    (config) => {
        return config;
    },
    (error) => {
        console.error('Request error:', error);
        return Promise.reject(error);
    }
);

// Add response interceptor for handling errors
api.interceptors.response.use(
    (response) => {
        return response;
    },
    (error) => {
        if (error.message === 'Network Error') {
            console.error('Network Error - Please check if the API server is running and CORS is properly configured');
        }
        return Promise.reject(error);
    }
);

// Create User
export const createUser = async (userData: ICreateUserModel) => {
    try {
        console.log("ASafariM.Clients/asafarim-ui/src/api/userManagerApi.ts createUser", userData);
        const response = await api.post(USERS_URL, userData, {
            headers: {
                'Accept': '*/*',
                'Content-Type': 'application/json'
            }
        });
        console.log("userManagerApi.ts createUser: response", response);
        
        // Check if the response status indicates success (200 or 201)
        if (response.status === 201 || response.status === 200) {
            return { success: true, data: response.data };
        }
        
        throw new Error(`Failed to create user. Server returned status: ${response.status}`);
    } catch (error) {
        console.error("Error in createUser:", error);
        if (axios.isAxiosError(error)) {
            if (error.message === 'Network Error') {
                throw new Error('Unable to connect to the server. Please check if the API server is running.');
            }
            throw new Error(error.response?.data?.message || 'Failed to create user');
        }
        throw error; // Re-throw to handle in component
    }
};

// Create User by Admin
export const addUserByAdmin = async (userData: ICreateUserModel) => {
    try {
        console.log("ASafariM.Clients/asafarim-ui/src/api/userManagerApi.ts addUserByAdmin", userData);
        const response = await api.post(`${USERS_URL}/admin`, userData, {
            headers: {
                'Accept': '*/*',
                'Content-Type': 'application/json'
            }
        });
        console.log("userManagerApi.ts addUserByAdmin: response", response);
        
        if (response.status === 201 || response.status === 200) {
            return { success: true, data: response.data };
        }
        
        throw new Error(`Failed to create user. Server returned status: ${response.status}`);
    } catch (error) {
        console.error("Error in addUserByAdmin:", error);
        if (axios.isAxiosError(error)) {
            if (error.message === 'Network Error') {
                throw new Error('Unable to connect to the server. Please check if the API server is running.');
            }
            throw new Error(error.response?.data?.message || 'Failed to create user');
        }
        throw error;
    }
};

// Fetch Users
export const getUsers = async () => {
    const response = await api.get('/users');
    console.log("userManagerApi.ts getUsers: response.data", response.data);
    return response.data;
};

// Get User by ID
export const getUserById = async (id: string) => {
    const response = await api.get(`/users/${id}`);
    console.log("getUserById: response.data", response.data);
    return response.data;
};

// Update User
export const updateUser = async (id: string, userData: { fullName: string, isAdmin: boolean }) => {
    console.log("updateUser: userData", userData);
    const response = await api.put(`/users/${id}`, userData);
    console.log("userManagerApi.ts updateUser: response.data", response.data);
    return response.data;
};

// Delete User
export const deleteUser = async (id: string) => {
    const response = await api.delete(`/users/${id}`);
    console.log("userManagerApi.ts deleteUser: response.data", response.data);
    return response.data;
};
