import { useEffect, useState, useCallback } from "react";

function useAuth() {
  const [authState, setAuthState] = useState(() => {
    const localAuth = localStorage.getItem('auth');
    return localAuth ? JSON.parse(localAuth) : null;
  });

  const checkAuthState = useCallback(() => {
    const localAuth = localStorage.getItem('auth');
    setAuthState(localAuth ? JSON.parse(localAuth) : null);
  }, []);

  const logout = useCallback(() => {
    localStorage.removeItem('auth');
    setAuthState(null);
    window.dispatchEvent(new Event('authStateChange'));
  }, []);

  useEffect(() => {
    // Initial check
    checkAuthState();

    // Listen for storage events (for cross-tab synchronization)
    window.addEventListener('storage', checkAuthState);

    // Create a custom event for auth state changes
    window.addEventListener('authStateChange', checkAuthState);

    return () => {
      window.removeEventListener('storage', checkAuthState);
      window.removeEventListener('authStateChange', checkAuthState);
    };
  }, [checkAuthState]);

  useEffect(() => {
    // Check if user is deleted
    if (authState?.authState?.authenticatedUser?.isDeleted) {
      localStorage.removeItem('auth');
      setAuthState(null);
    }
  }, [authState]);

  return { ...authState, logout, checkAuthState};
}


export default useAuth;