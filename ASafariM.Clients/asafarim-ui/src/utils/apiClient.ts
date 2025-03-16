import axios from 'axios';
import { logger } from "@/utils/logger";

const url = import.meta.env.VITE_API_URL || 'http://localhost:5000';
const isDevelopment = import.meta.env.VITE_ENVIRONMENT === 'development';
const BASE_URL = isDevelopment ? 'http://localhost:5000' : 'https://asafarim.com';

logger.debug("apiClient url is:", url);
export const apiClient = axios.create({
    baseURL: url || BASE_URL,
    headers: {
        'Content-Type': 'application/json'
    }
});

// Add request interceptor to include auth token
apiClient.interceptors.request.use((config) => {
    const token = localStorage.getItem('token');
    if (token) {
        config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
});

// Add response interceptor to handle errors
apiClient.interceptors.response.use(
    (response) => response,
    (error) => {
        if (error.response?.status === 401) {
            // Handle unauthorized access
            localStorage.removeItem('token');
            window.location.href = '/login';
        }
        return Promise.reject(error);
    }
);
