import React, { createContext, useContext, ReactNode, useState, useCallback } from 'react';
import { logout as apiLogout, login as apiLogin } from "../api/authapi";
import { ILoginModel } from "@/interfaces/ILoginModel";
import { logger } from '@/utils/logger';

// Define the shape of our auth context
interface AuthContextType {
  authenticated: boolean;
  authenticatedUser: any | null;
  token: string | null;
  login: (credentials: ILoginModel, rememberMe: boolean) => Promise<boolean>;
  logout: () => Promise<void>;
  refreshToken: () => Promise<boolean>;
}

// Create the context with a default value
const AuthContext = createContext<AuthContextType | undefined>(undefined);

// Provider component
export const AuthProvider: React.FC<{ children: ReactNode }> = ({ children }) => {
  const [authState, setAuthState] = useState(() => {
    // Check both localStorage and sessionStorage for auth data
    const localAuth = localStorage.getItem('auth');
    const sessionAuth = sessionStorage.getItem('auth');
    
    logger.log('Initial auth check - localStorage:', localAuth ? 'present' : 'not present');
    logger.log('Initial auth check - sessionStorage:', sessionAuth ? 'present' : 'not present');
    
    // Prefer localStorage (remember me) over sessionStorage
    if (localAuth) {
      try {
        const parsedAuth = JSON.parse(localAuth);
        logger.log('Initial state using localStorage auth data:', parsedAuth);
        
        // Check for case-sensitive property names
        if (parsedAuth.Token && !parsedAuth.token) {
          parsedAuth.token = parsedAuth.Token;
        }
        if (parsedAuth.Authenticated !== undefined && parsedAuth.authenticated === undefined) {
          parsedAuth.authenticated = parsedAuth.Authenticated;
        }
        if (parsedAuth.AuthenticatedUser && !parsedAuth.authenticatedUser) {
          parsedAuth.authenticatedUser = parsedAuth.AuthenticatedUser;
        }
        
        return parsedAuth;
      } catch (e) {
        logger.error('Error parsing localStorage auth data:', e);
        return { authenticated: false, authenticatedUser: null, token: null };
      }
    } else if (sessionAuth) {
      try {
        const parsedAuth = JSON.parse(sessionAuth);
        logger.log('Initial state using sessionStorage auth data:', parsedAuth);
        
        // Check for case-sensitive property names
        if (parsedAuth.Token && !parsedAuth.token) {
          parsedAuth.token = parsedAuth.Token;
        }
        if (parsedAuth.Authenticated !== undefined && parsedAuth.authenticated === undefined) {
          parsedAuth.authenticated = parsedAuth.Authenticated;
        }
        if (parsedAuth.AuthenticatedUser && !parsedAuth.authenticatedUser) {
          parsedAuth.authenticatedUser = parsedAuth.AuthenticatedUser;
        }
        
        return parsedAuth;
      } catch (e) {
        logger.error('Error parsing sessionStorage auth data:', e);
        return { authenticated: false, authenticatedUser: null, token: null };
      }
    }
    
    logger.log('No auth data found, using default state');
    return { authenticated: false, authenticatedUser: null, token: null };
  });

  // Login function
  const login = useCallback(async (credentials: ILoginModel, rememberMe: boolean): Promise<boolean> => {
    try {
      logger.log('Attempting login with credentials:', { ...credentials, password: '[REDACTED]' });
      const response = await apiLogin(credentials);
      
      if (response && response.token) {
        const newAuthState = {
          authenticated: true,
          authenticatedUser: response.authenticatedUser,
          token: response.token
        };
        
        logger.log('Login successful, setting auth state:', { ...newAuthState, token: '[REDACTED]' });
        setAuthState(newAuthState);
        
        // Store in the appropriate storage based on rememberMe
        const storage = rememberMe ? localStorage : sessionStorage;
        storage.setItem('auth', JSON.stringify(newAuthState));
        
        return true;
      } else {
        logger.error('Login failed - invalid response:', response);
        return false;
      }
    } catch (error) {
      logger.error('Login error:', error);
      return false;
    }
  }, []);

  // Logout function
  const logout = useCallback(async (): Promise<void> => {
    try {
      logger.log('Attempting logout');
      
      // No need to pass token, the API will use cookies/headers
      await apiLogout();
      
      // Clear auth state regardless of API call success
      setAuthState({ authenticated: false, authenticatedUser: null, token: null });
      
      // Remove from both storages to be safe
      localStorage.removeItem('auth');
      sessionStorage.removeItem('auth');
      
      logger.log('Logout successful');
    } catch (error) {
      logger.error('Logout error:', error);
      
      // Still clear local state even if API call fails
      setAuthState({ authenticated: false, authenticatedUser: null, token: null });
      localStorage.removeItem('auth');
      sessionStorage.removeItem('auth');
    }
  }, []);

  // Token refresh function (placeholder - implement actual refresh logic)
  const refreshToken = useCallback(async (): Promise<boolean> => {
    // This would typically call an API endpoint to refresh the token
    // For now, just return true if we have a token
    return !!authState.token;
  }, [authState.token]);

  // Create the context value object
  const contextValue: AuthContextType = {
    authenticated: authState.authenticated,
    authenticatedUser: authState.authenticatedUser,
    token: authState.token,
    login,
    logout,
    refreshToken
  };

  return (
    <AuthContext.Provider value={contextValue}>
      {children}
    </AuthContext.Provider>
  );
};

// Custom hook to use the auth context
export const useAuth = (): AuthContextType => {
  const context = useContext(AuthContext);
  if (context === undefined) {
    throw new Error('useAuth must be used within an AuthProvider');
  }
  return context;
};

export default useAuth;
