// apps/frontends/asafarim-client/src/api/authapi.ts
// 
import axios, { AxiosError, isAxiosError } from 'axios';
import { ILoginModel } from '../interfaces/ILoginModel';
import { IRegisterModel } from '../interfaces/IRegisterModel';
import { logger } from '@/utils/logger';
import apiUrls from './getApiUrls';
import { IUserModelUpdate } from '@/interfaces';

interface ErrorResponse {
  message?: string;
  error?: string;
}

const host = window.location.hostname;
const baseURL = apiUrls(host);  // Get the base URL from getApiUrls

const api = axios.create({
  baseURL: baseURL,
  timeout: 5000, // Timeout in milliseconds
  withCredentials: true, // Send cookies with requests
});

api.interceptors.request.use(
  (config) => {
    return config;
  },
  (error) => {
    console.error('Request error:', error);
    return Promise.reject(error);
  }
);

api.interceptors.response.use(
  (response) => response,
  (error) => {
    console.error('Response error:', error);
    return Promise.reject(error);
  }
);

// Register a new user
export const register = async (model: IRegisterModel) => {
  logger.info(`Attempting to register user with model: ${JSON.stringify(model)}`);
  const response = await api.post('auth/register', model);
  logger.info(`Registration successful, response received: ${JSON.stringify(response.data)}`);
  return response.data;
};
// Login a user
export const login = async (credentials: ILoginModel) => {
  try {
    logger.info(`Attempting to login user with credentials: ${JSON.stringify(credentials)}`);
    console.log('Login API request:', credentials);
    
    const response = await api.post('auth/login', credentials, {
        headers: { 'Content-Type': 'application/json' },
    });
    
    logger.info(`Login successful, response received: ${JSON.stringify(response.data)}`);
    console.log('Login API raw response:', response);
    console.log('Login API response data:', response.data);
    
    // Normalize the response to ensure consistent property names
    const normalizedResponse = {
      token: response.data.Token || response.data.token,
      authenticatedUser: response.data.AuthenticatedUser || response.data.authenticatedUser || response.data.user,
      authenticated: response.data.Authenticated !== undefined ? response.data.Authenticated : 
                    (response.data.authenticated !== undefined ? response.data.authenticated : true)
    };
    
    console.log('Normalized login response:', normalizedResponse);
    
    // Validate the response structure
    if (!normalizedResponse.token) {
      console.error('Login API response missing token:', response.data);
      throw new Error('Invalid response from server: missing authentication token');
    }
    
    if (!normalizedResponse.authenticatedUser) {
      console.error('Login API response missing user data:', response.data);
      throw new Error('Invalid response from server: missing user data');
    }
    
    return normalizedResponse;
  } catch (error) {
    console.error('Login API error:', error);
    if (isAxiosError(error)) {
      if (error.response) {
        console.error('Login API error response:', error.response.data);
      } else if (error.request) {
        console.error('Login API no response received:', error.request);
      } else {
        console.error('Login API error during setup:', error.message);
      }
    }
    throw error;
  }
};
export const requestAccountReactivation = async (email: string) => {
  try {
    logger.info(`Attempting to request account reactivation for email: ${email}`);
    const response = await axios.post(`${baseURL}/auth/request-account-reactivation`, { 
      email,
      reactivationReason: "User requested account reactivation"
    });
    logger.info(`Account reactivation request successful, response received: ${JSON.stringify(response.data)}`);
    return response.data;
  } catch (error) {
    const err = error as AxiosError<ErrorResponse>;
    logger.error(`Error during account reactivation request: ${err.message}`);
    
    const errorMessage = err.response?.data?.message || err.response?.data?.error;
    if (errorMessage) {
      throw errorMessage;
    } else if (err.message.includes('SMTP error') || err.message.includes('email')) {
      throw 'Unable to send reactivation email. Our team has been notified.';
    } else {
      throw 'Failed to process reactivation request. Please try again later.';
    }
  }
};
export const requestPasswordReset = async (email: string) => {
  try {
    logger.info(`Attempting to request password reset for email: ${email}`);
    const response = await axios.post(`${baseURL}/auth/forgot-password`, { email });
    logger.info(`Password reset request successful, response received: ${JSON.stringify(response.data)}`);
    return response.data;
  } catch (error) {
    const err = error as AxiosError<{ error?: string }>;
    if (err.message) {
      logger.error(`Error during password reset request: ${err.message}`);
      throw err.message;
    }
    if (err.response?.data?.error) {
      logger.error(`Error during password reset request: ${err.response.data.error}`);
      throw err.response.data.error;
    }
    logger.error(`Error during password reset request: ${JSON.stringify(err.response?.data)}`);
    throw 'Failed to send password reset request.';
  }
};

// Reset password for a user
export const resetPassword = async (email: string, newPassword: string, token: string) => {
  try {
    logger.info(`Attempting to reset password for email: ${email}`);
    const response = await axios.post(`${baseURL}/auth/reset-password`, { email, newPassword, token });
    logger.info(`Password reset successful, response received: ${JSON.stringify(response.data)}`);
    return response.data;
  } catch (error) {
    const err = error as AxiosError<{ error?: string }>;
    if (err.message) {
      logger.error(`Error during password reset: ${err.message}`);
      throw err.message;
    }
    if (err.response?.data?.error) {
      logger.error(`Error during password reset: ${err.response.data.error}`);
      throw err.response.data.error;
    }
    logger.error(`Error during password reset: ${JSON.stringify(err.response?.data)}`);
    throw 'Failed to send password reset request';
  }
};

// Get user profile by ID
export const getUserProfile = async (userId: string | undefined) => {
  try {
    logger.info(`Attempting to get user profile for user ID: ${userId}`);
    const response = await axios.get(`${baseURL}/Users/${userId}`);
    logger.info(`User profile retrieved successfully, response received: ${JSON.stringify(response.data)}`);
    return response.data;
  } catch (error) {
    const err = error as AxiosError<{ error?: string }>;
    if (err.message) {
      logger.error(`Error during user profile retrieval: ${err.message}`);
      throw err.message;
    }
    if (err.response?.data?.error) {
      logger.error(`Error during user profile retrieval: ${err.response.data.error}`);
      throw err.response.data.error;
    }
    logger.error(`Error during user profile retrieval: ${JSON.stringify(err.response?.data)}`);
    throw 'Failed to retrieve user profile.';
  }
};

// Update user profile by ID
export const updateUserProfile = async (user: IUserModelUpdate): Promise<IUserModelUpdate> => {
    const targetUrl = `/users/${user.id}`; // Use PUT to existing user endpoint
    
    try {
        // Validate required fields
        if (!user.id || !user.firstName || !user.lastName) {
            throw new Error('Missing required fields: id, firstName, and lastName are required');
        }

        // Send PUT request with all necessary fields
        const response = await api.put(targetUrl, {
            id: user.id,
            firstName: user.firstName,
            lastName: user.lastName,
            email: user.email,
            userName: user.userName,
            isActive: true // Default to active
        });
        
        console.log("Profile update successful:", response.data);
        return response.data;
    } catch (error) {
        console.error('Error updating profile:', error);
        throw error;
    }
};

// Logout a user
export const logout = async () => {
  try {
    logger.info('Attempting to logout user');
    console.log('Logout API request sent');
    
    const response = await api.post('auth/logout');
    
    logger.info(`Logout successful, response received: ${JSON.stringify(response.data)}`);
    console.log('Logout API response:', response.data);
    
    return response.data;
  } catch (error) {
    console.error('Logout API error:', error);
    if (isAxiosError(error)) {
      if (error.response) {
        console.error('Logout API error response:', error.response.data);
      } else if (error.request) {
        console.error('Logout API no response received:', error.request);
      } else {
        console.error('Logout API error during setup:', error.message);
      }
    }
    // Even if the API call fails, we should still clear local storage
    return { message: 'Logged out locally' };
  }
};