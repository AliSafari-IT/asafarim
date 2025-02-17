// src/pages/LogoutPage.tsx
import { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { logger } from '@/utils/logger';
const LogoutPage = () => {
  const navigate = useNavigate();
  const previousLocation = localStorage.getItem('returnTo');

  useEffect(() => {
    // Clear user data from localStorage
    logger.info('Logging out user');
    localStorage.removeItem('auth');
    localStorage.removeItem('user'); // Clear the user data from localStorage
    window.dispatchEvent(new Event('authStateChange'));

    // Get and clear the returnTo value before navigating
    const returnPath = previousLocation;
    localStorage.removeItem('returnTo');
    logger.info('Redirecting to previous location: ' + returnPath);
    // Redirect to the previous page or home if no previous location
    navigate(returnPath || '/', { replace: true });
  }, [navigate, previousLocation]);

  return null; // or a loading spinner/message
};

export default LogoutPage;
