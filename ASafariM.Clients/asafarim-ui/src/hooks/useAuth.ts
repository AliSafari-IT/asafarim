import { useEffect, useState, useCallback } from "react";

function useAuth() {
  const [authState, setAuthState] = useState(() => {
    const localAuth = localStorage.getItem('auth');
    return localAuth ? JSON.parse(localAuth) : { authenticatedUser: null, token: null };
  });

  const checkAuthState = useCallback(() => {
    const localAuth = localStorage.getItem('auth');
    setAuthState(localAuth ? JSON.parse(localAuth) : { authenticatedUser: null, token: null });
  }, []);

  const logout = useCallback(() => {
    localStorage.removeItem('auth');
    setAuthState({ authenticatedUser: null, token: null });
    window.dispatchEvent(new Event('authStateChange'));
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
      setAuthState({ authenticatedUser: null, token: null });
    }
    console.log('Auth state updated:', authState);
  }, [authState]);

  return {
    authenticated: Boolean(authState?.authenticatedUser),
    authenticatedUser: authState?.authenticatedUser,
    token: authState?.token,
    logout,
    checkAuthState
  };
}

export default useAuth;
