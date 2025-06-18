// src/pages/LogoutPage.tsx
import { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { logger } from '@/utils/logger';
import { useAuth } from '@/contexts/AuthContext';
import React from 'react';

const LogoutPage = () => {
  const navigate = useNavigate();
  const previousLocation = localStorage.getItem('returnTo');
  const { logout } = useAuth();

  useEffect(() => {
    const performLogout = async () => {
      try {
        logger.info('Logging out user');
        
        // Call the enhanced logout function from useAuth
        await logout();
        
        logger.info('User logged out successfully');
        
        // Get and clear the returnTo value before navigating
        const returnPath = previousLocation;
        localStorage.removeItem('returnTo');
        
        logger.info(`Redirecting to previous location: ${returnPath || '/'}`);
        
        // Redirect to the previous page or home if no previous location
        navigate(returnPath || '/', { replace: true });
      } catch (error) {
        logger.error(`Error during logout: ${error instanceof Error ? error.message : String(error)}`);
        // Even if there's an error, redirect to login
        navigate('/login', { replace: true });
      }
    };
    
    performLogout();
  }, [navigate, previousLocation, logout]);

  return (
    <div className="flex items-center justify-center min-h-screen bg-gray-100" data-testid="logout-page">
      <div className="p-8 bg-white rounded shadow-md">
        <h1 className="text-2xl font-bold mb-4" data-testid="logout-heading">Logging out...</h1>
        <p data-testid="logout-message">Please wait while we log you out.</p>
      </div>
    </div>
  );
};

export default LogoutPage;
