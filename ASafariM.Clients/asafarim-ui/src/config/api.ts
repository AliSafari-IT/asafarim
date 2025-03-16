
import {logger} from '@/utils/logger';

const getApiConfig = () => {
    const isDevelopment = import.meta.env.VITE_ENVIRONMENT === 'development';

    const BASE_URL = isDevelopment ? 'http://localhost:5000' : 'https://asafarim.com';
    const API_URL = `${BASE_URL}/api`;
    logger.log('api.ts API_URL:', API_URL);

    return {
        baseURL: API_URL,
        isDevelopment
    };
};

export const apiConfig = getApiConfig();
