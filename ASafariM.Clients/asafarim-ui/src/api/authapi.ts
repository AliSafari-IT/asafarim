// D:\repos\ASafariM\ASafariM.Clients\asafarim-ui\src\api\authapi.ts
import axios, { AxiosError, isAxiosError } from 'axios';
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

logger.log('Using API base URL:', baseURL);

const api = axios.create({
  baseURL: baseURL,
  timeout: 15000, // Increase timeout to 15 seconds
  withCredentials: true, // Send cookies with requests
});

// Add a function to get auth token from both storage locations
const getAuthToken = () => {
  try {
    // Check localStorage first
    const localAuth = localStorage.getItem('auth');
    if (localAuth) {
      const parsedAuth = JSON.parse(localAuth);
      return parsedAuth.token || parsedAuth.Token;
    }

    // Then check sessionStorage
    const sessionAuth = sessionStorage.getItem('auth');
    if (sessionAuth) {
      const parsedAuth = JSON.parse(sessionAuth);
      return parsedAuth.token || parsedAuth.Token;
    }

    return null;
  } catch (error) {
    logger.error("Error getting auth token:", error);
    return null;
  }
};

// Add a response interceptor to log errors
api.interceptors.response.use(
  (response) => {
    return response;
  },
  (error) => {
    logger.error('API Error Response:', error.message);
    if (error.response) {
      logger.error('Status:', error.response.status);
      logger.error('Data:', error.response.data);
      logger.error('Headers:', error.response.headers);
    } else if (error.request) {
      logger.error('No response received:', error.request);
    }
    return Promise.reject(error);
  }
);

api.interceptors.request.use(
  (config) => {
    // Get auth token from storage using the helper function
    const token = getAuthToken();

    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
      logger.log('Added authorization header to request');
    } else {
      logger.log('No auth token found - request will be unauthenticated');
    }
    return config;
  },
  (error) => {
    logger.error('Request error:', error);
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
    logger.log('Login API request:', credentials);

    const response = await api.post('auth/login', credentials, {
      headers: { 'Content-Type': 'application/json' },
    });

    logger.info(`Login successful, response received: ${JSON.stringify(response.data)}`);
    logger.log('Login API raw response:', response);
    logger.log('Login API response data:', response.data);

    // Normalize the response to ensure consistent property names
    const normalizedResponse = {
      token: response.data.Token || response.data.token,
      authenticatedUser: response.data.AuthenticatedUser || response.data.authenticatedUser || response.data.user,
      authenticated: response.data.Authenticated !== undefined ? response.data.Authenticated :
        (response.data.authenticated !== undefined ? response.data.authenticated : true)
    };

    logger.log('Normalized login response:', normalizedResponse);

    // Validate the response structure
    if (!normalizedResponse.token) {
      logger.error('Login API response missing token:', response.data);
      throw new Error('Invalid response from server: missing authentication token');
    }

    if (!normalizedResponse.authenticatedUser) {
      logger.error('Login API response missing user data:', response.data);
      throw new Error('Invalid response from server: missing user data');
    }

    return normalizedResponse;
  } catch (error) {
    logger.error('Login API error:', error);
    if (isAxiosError(error)) {
      if (error.response) {
        logger.error('Login API error response:', error.response.data);
      } else if (error.request) {
        logger.error('Login API no response received:', error.request);
      } else {
        logger.error('Login API error during setup:', error.message);
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
    const response = await axios.post(`${baseURL}/auth/reset-password`, {
      Email: email,
      NewPassword: newPassword,
      Token: token
    });
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
export const updateUserProfile = async (user: any): Promise<any> => {
  try {
    // Get auth token from storage
    const authData = localStorage.getItem('auth') || sessionStorage.getItem('auth');

    if (!authData) {
      logger.error('No auth data found in storage');
      throw new Error('No authentication data found');
    }

    // Log the auth data for debugging (hide sensitive data)
    const parsedAuthData = JSON.parse(authData);
    logger.log('Auth data found:', {
      hasToken: !!parsedAuthData.token,
      tokenLength: parsedAuthData.token ? parsedAuthData.token.length : 0,
      hasUser: !!parsedAuthData.authenticatedUser,
      userId: parsedAuthData.authenticatedUser?.id
    });

    // Create request data with all available profile fields
    const requestData = {
      userId: user.id,
      firstName: user.firstName,
      lastName: user.lastName,
      email: user.email,
      phoneNumber: user.phoneNumber || undefined,
      userName: user.userName || undefined,
      profilePicture: user.profilePicture || undefined,
      biography: user.biography || undefined
    };

    // Log request details
    logger.log('Updating profile with request:', {
      endpoint: 'auth/update-profile',
      method: 'POST',
      data: requestData
    });

    // Use the api instance which already has the auth interceptor
    // that adds the Authorization header automatically
    const response = await api.post('auth/update-profile', requestData);

    logger.log('Profile update successful:', response.data);
    return response.data;
  } catch (error) {
    logger.error('Error updating profile:', error);
    throw error;
  }
};

// Logout a user
export const logout = async () => {
  try {
    logger.info('Attempting to logout user');
    logger.log('Logout API request sent');

    const response = await api.post('auth/logout');

    logger.info(`Logout successful, response received: ${JSON.stringify(response.data)}`);
    logger.log('Logout API response:', response.data);

    // ✅ Clear storage on success
    localStorage.clear();
    sessionStorage.clear();

    return response.data;
  } catch (error) {
    logger.error('Logout API error:', error);

    if (isAxiosError(error)) {
      if (error.response) {
        logger.error('Logout API error response:', error.response.data);
      } else if (error.request) {
        logger.error('Logout API no response received:', error.request);
      } else {
        logger.error('Logout API error during setup:', error.message);
      }
    }

    // ✅ Clear storage even if logout fails
    localStorage.clear();
    sessionStorage.clear();

    return { message: 'Logged out locally' };
  }
};

export function getAuthenticatedUser() {
  logger.info('Getting authenticated user from session storage');
  try {
    const authData = sessionStorage.getItem('auth');
    if (!authData) {
      logger.info('No auth data found in session storage');
      return null;
    }
    return JSON.parse(authData).authenticatedUser;
  } catch (error) {
    logger.error('Error getting authenticated user:', error);
    return null;
  }
}
