import { useEffect, useState, useCallback } from "react";
import { logout as apiLogout, login as apiLogin } from "../api/authapi";
import { ILoginModel } from "@/interfaces/ILoginModel";

function useAuth() {
  const [authState, setAuthState] = useState(() => {
    // Check both localStorage and sessionStorage for auth data
    const localAuth = localStorage.getItem('auth');
    const sessionAuth = sessionStorage.getItem('auth');
    
    console.log('Initial auth check - localStorage:', localAuth ? 'present' : 'not present');
    console.log('Initial auth check - sessionStorage:', sessionAuth ? 'present' : 'not present');
    
    // Prefer localStorage (remember me) over sessionStorage
    if (localAuth) {
      try {
        const parsedAuth = JSON.parse(localAuth);
        console.log('Initial state using localStorage auth data:', parsedAuth);
        
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
        console.error('Error parsing localStorage auth data:', e);
        return { authenticated: false, authenticatedUser: null, token: null };
      }
    } else if (sessionAuth) {
      try {
        const parsedAuth = JSON.parse(sessionAuth);
        console.log('Initial state using sessionStorage auth data:', parsedAuth);
        
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
        console.error('Error parsing sessionStorage auth data:', e);
        return { authenticated: false, authenticatedUser: null, token: null };
      }
    } else {
      console.log('Initial state - no auth data found');
      return { authenticated: false, authenticatedUser: null, token: null };
    }
  });

  const checkAuthState = useCallback(() => {
    // Check both localStorage and sessionStorage for auth data
    const localAuth = localStorage.getItem('auth');
    const sessionAuth = sessionStorage.getItem('auth');
    
    console.log('checkAuthState - localStorage:', localAuth ? 'present' : 'not present');
    console.log('checkAuthState - sessionStorage:', sessionAuth ? 'present' : 'not present');
    
    // Prefer localStorage (remember me) over sessionStorage
    if (localAuth) {
      try {
        const parsedAuth = JSON.parse(localAuth);
        console.log('Using localStorage auth data:', parsedAuth);
        
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
        
        setAuthState(parsedAuth);
      } catch (e) {
        console.error('Error parsing localStorage auth data:', e);
        setAuthState({ authenticated: false, authenticatedUser: null, token: null });
      }
    } else if (sessionAuth) {
      try {
        const parsedAuth = JSON.parse(sessionAuth);
        console.log('Using sessionStorage auth data:', parsedAuth);
        
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
        
        setAuthState(parsedAuth);
      } catch (e) {
        console.error('Error parsing sessionStorage auth data:', e);
        setAuthState({ authenticated: false, authenticatedUser: null, token: null });
      }
    } else {
      console.log('No auth data found, setting to unauthenticated state');
      setAuthState({ authenticated: false, authenticatedUser: null, token: null });
    }
  }, []);

  const login = useCallback(async (credentials: ILoginModel) => {
    try {
      const response = await apiLogin(credentials);
      
      // Store auth data in localStorage
      const authData = {
        authenticated: true,
        authenticatedUser: response.authenticatedUser,
        token: response.token
      };
      
      localStorage.setItem('auth', JSON.stringify(authData));
      sessionStorage.setItem('auth', JSON.stringify(authData));
      
      setAuthState(authData);
      window.dispatchEvent(new Event('authStateChange'));
      
      return authData;
    } catch (error) {
      console.error('Login failed:', error);
      throw error;
    }
  }, []);

  const logout = useCallback(async () => {
    console.log('Logging out - calling backend logout API');
    await apiLogout();
    console.log('Logged out - clearing auth data from both storage locations');
    // Clear auth data from both storage locations
    localStorage.removeItem('auth');
    sessionStorage.removeItem('auth');
    setAuthState({ authenticated: false, authenticatedUser: null, token: null });
    window.dispatchEvent(new Event('authStateChange'));
    
    // Redirect to login page after logout
    window.location.href = '/login';
  }, []);

  useEffect(() => {
    // Initial check
    checkAuthState();

    // Listen for storage events (for cross-tab synchronization)
    window.addEventListener('storage', checkAuthState);
    window.addEventListener('authStateChange', checkAuthState);

    return () => {
      window.removeEventListener('storage', checkAuthState);
      window.removeEventListener('authStateChange', checkAuthState);
    };
  }, [checkAuthState]);

  useEffect(() => {
    // Check if user is deleted
    if (authState?.authenticatedUser?.isDeleted) {
      localStorage.removeItem('auth');
      sessionStorage.removeItem('auth');
      setAuthState({ authenticated: false, authenticatedUser: null, token: null });
    }
    console.log('Auth state updated:', authState);
    
    // Debug the authenticated property specifically
    console.log('Is authenticated?', Boolean(authState?.authenticatedUser));
    console.log('authenticated property value:', authState?.authenticated);
    console.log('authenticatedUser value:', authState?.authenticatedUser);
    console.log('token value:', authState?.token);
  }, [authState]);

  return {
    authenticated: Boolean(authState?.authenticated) && Boolean(authState?.authenticatedUser),
    authenticatedUser: authState?.authenticatedUser,
    token: authState?.token,
    login,
    logout,
    checkAuthState
  };
}

export default useAuth;
