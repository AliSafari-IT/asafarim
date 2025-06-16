import { AxiosError } from 'axios';
import { logger } from '@/utils/logger';

export interface RetryConfig {
    maxRetries: number;
    baseDelay: number;
    maxDelay: number;
}

export const defaultRetryConfig: RetryConfig = {
    maxRetries: 3,
    baseDelay: 1000, // 1 second
    maxDelay: 5000   // 5 seconds
};

export const handleApiError = (error: unknown): string => {
    if (error instanceof AxiosError) {
        if (error.code === 'ECONNABORTED') {
            return 'Request timed out. The server is taking too long to respond. Please try again.';
        }
        if (error.message === 'Network Error') {
            return 'Unable to connect to the server. Please check your internet connection and try again.';
        }
        if (error.response) {
            const status = error.response.status;
            const message = error.response.data?.message || error.response.statusText;
            
            switch (status) {
                case 400:
                    return `Bad request: ${message}`;
                case 401:
                    return 'Unauthorized. Please log in again.';
                case 403:
                    return 'Access denied. You do not have permission to perform this action.';
                case 404:
                    return 'Resource not found.';
                case 409:
                    return `Conflict: ${message}`;
                case 422:
                    return `Validation error: ${message}`;
                case 429:
                    return 'Too many requests. Please wait a moment and try again.';
                case 500:
                    return 'Internal server error. Please try again later.';
                case 502:
                    return 'Bad gateway. The server is temporarily unavailable.';
                case 503:
                    return 'Service unavailable. Please try again later.';
                case 504:
                    return 'Gateway timeout. The server is taking too long to respond.';
                default:
                    return `Server error (${status}): ${message}`;
            }
        }
        if (error.request) {
            return 'No response received from server. Please check your connection and try again.';
        }
        return `Request error: ${error.message}`;
    }
    
    if (error instanceof Error) {
        return error.message;
    }
    
    return 'An unexpected error occurred. Please try again.';
};

export const sleep = (ms: number): Promise<void> => {
    return new Promise(resolve => setTimeout(resolve, ms));
};

export const withRetry = async <T>(
    operation: () => Promise<T>,
    config: RetryConfig = defaultRetryConfig
): Promise<T> => {
    let lastError: unknown;
    
    for (let attempt = 1; attempt <= config.maxRetries; attempt++) {
        try {
            return await operation();
        } catch (error) {
            lastError = error;
            
            // Don't retry on certain errors
            if (error instanceof AxiosError) {
                if (error.response && [400, 401, 403, 404, 422].includes(error.response.status)) {
                    throw error; // Don't retry client errors
                }
            }
            
            if (attempt === config.maxRetries) {
                break; // Last attempt, don't wait
            }
            
            // Calculate delay with exponential backoff
            const delay = Math.min(
                config.baseDelay * Math.pow(2, attempt - 1),
                config.maxDelay
            );
            
            logger.warn(`Request failed (attempt ${attempt}/${config.maxRetries}), retrying in ${delay}ms...`, error);
            await sleep(delay);
        }
    }
    
    throw lastError;
};

export const isTimeoutError = (error: unknown): boolean => {
    return error instanceof AxiosError && error.code === 'ECONNABORTED';
};

export const isNetworkError = (error: unknown): boolean => {
    return error instanceof AxiosError && error.message === 'Network Error';
};

export const isServerError = (error: unknown): boolean => {
    return error instanceof AxiosError && 
           error.response !== undefined && 
           error.response.status >= 500;
};

// Convenience function for retrying API requests with operation names
export const retryRequest = async <T>(
    operation: () => Promise<T>,
    operationName: string,
    config: RetryConfig = defaultRetryConfig
): Promise<T> => {
    try {
        return await withRetry(operation, config);
    } catch (error) {
        logger.error(`${operationName} failed after ${config.maxRetries} attempts:`, error);
        throw error;
    }
};
