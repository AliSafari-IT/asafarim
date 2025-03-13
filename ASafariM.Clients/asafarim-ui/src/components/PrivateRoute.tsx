import { Navigate, useNavigate } from 'react-router-dom';
import { useEffect } from 'react';
import useAuth from '../hooks/useAuth';
import AccessDenied from '../pages/AccessDenied';

interface PrivateRouteProps {
  children: JSX.Element;
  requireAdmin?: boolean;
}

const PrivateRoute = ({ children, requireAdmin = false }: PrivateRouteProps) => {
  const { authenticatedUser, authenticated, token } = useAuth();
  const navigate = useNavigate();

  useEffect(() => {
    console.log("PrivateRoute Debug:", { authenticated, authenticatedUser, token, requireAdmin });
    // If user not authenticated, or is deleted, or token is missing, log them out and redirect to login
    if (!authenticated || authenticatedUser?.isDeleted || !token) {
      console.warn("User not authenticated or deleted. Redirecting to login.");
      localStorage.removeItem('auth');
      window.dispatchEvent(new Event('authStateChange'));
      navigate('/login');
    }
  }, [authenticated, authenticatedUser, authenticatedUser?.isDeleted, navigate, requireAdmin, token]);

  if (!authenticated) {
    return <Navigate to="/login" />;
  }

  // Admin-only routes validation
  if (requireAdmin && !authenticatedUser?.isAdmin) {
    console.warn("Access denied: User is not an admin.");
    return <AccessDenied />;
  }

  return children;
};

export default PrivateRoute;
