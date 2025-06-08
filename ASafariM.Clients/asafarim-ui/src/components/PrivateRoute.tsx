import React from 'react';
import { Navigate, useNavigate } from 'react-router-dom';
import { useEffect } from 'react';
import { useAuth } from '@/contexts/AuthContext';
import AccessDenied from '../pages/AccessDenied';
import {logger} from '@/utils/logger';


interface PrivateRouteProps {
  children: JSX.Element;
  requireAdmin?: boolean;
}

const PrivateRoute = ({ children, requireAdmin = false }: PrivateRouteProps) => {
  const { authenticatedUser, authenticated, token } = useAuth();
  const navigate = useNavigate();

  useEffect(() => {
    logger.log("PrivateRoute Debug:", { authenticated, authenticatedUser, token, requireAdmin });
    // If user not authenticated, or is deleted, or token is missing, log them out and redirect to login
    if (!authenticated || authenticatedUser?.isDeleted || !token) {
      logger.warn("User not authenticated or deleted. Redirecting to login.");
      localStorage.removeItem('auth');
      sessionStorage.removeItem('auth');
      window.dispatchEvent(new Event('authStateChange'));
      navigate('/login');
    }
  }, [authenticated, authenticatedUser, authenticatedUser?.isDeleted, navigate, requireAdmin, token]);

  if (!authenticated || !token) {
    logger.log("PrivateRoute: Not authenticated, redirecting to login");
    return <Navigate to="/login" />;
  }

  // Admin-only routes validation
  if (requireAdmin && !authenticatedUser?.isAdmin) {
    logger.warn("Access denied: User is not an admin.");
    return <AccessDenied />;
  }

  logger.log("PrivateRoute: User is authenticated, rendering protected content");
  return children;
};

export default PrivateRoute;
