// apps/frontends/asafarim-client/src/api/authapi.ts
// 
import axios, { AxiosError } from 'axios';
import { ILoginModel } from '../interfaces/ILoginModel';
import { IRegisterModel } from '../interfaces/IRegisterModel';
import { logger } from '@/utils/logger';
import apiUrls from './getApiUrls';

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
  logger.info(`Attempting to login user with credentials: ${JSON.stringify(credentials)}`);
  const response = await api.post('auth/login', credentials, {
      headers: { 'Content-Type': 'application/json' },
  });
  logger.info(`Login successful, response received: ${JSON.stringify(response.data)}`);
  return response.data;
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
    const response = await axios.post(`${baseURL}/Users/request-password-reset`, { email });
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
export const resetPassword = async (email: string, newPassword: string) => {
  try {
    logger.info(`Attempting to reset password for email: ${email}`);
    const response = await axios.post(`${baseURL}/Users/reset-password`, { email, newPassword });
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
    throw 'Failed to send password reset request.';
  }
};

// Get user profile by ID
export const getUserProfile = async (userId: string) => {
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
export const updateUserProfile = async (userId: string, model: IRegisterModel) => {
  try {
    logger.info(`Attempting to update user profile for user ID: ${userId}`);
    const response = await axios.put(`${baseURL}/Users/${userId}`, model);
    logger.info(`User profile updated successfully, response received: ${JSON.stringify(response.data)}`);
    return response.data;
  } catch (error) {
    const err = error as AxiosError<{ error?: string }>;
    if (err.message) {
      logger.error(`Error during user profile update: ${err.message}`);
      throw err.message;
    }
    if (err.response?.data?.error) {
      logger.error(`Error during user profile update: ${err.response.data.error}`);
      throw err.response.data.error;
    }
    logger.error(`Error during user profile update: ${JSON.stringify(err.response?.data)}`);
    throw 'Failed to update user profile.';
  }  
};