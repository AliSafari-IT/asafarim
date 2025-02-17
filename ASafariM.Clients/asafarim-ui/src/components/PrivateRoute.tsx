import { Navigate, useNavigate } from 'react-router-dom';
import { useEffect } from 'react';
import useAuth from '../hooks/useAuth';

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
  if (requireAdmin) {
    if (!authenticatedUser?.isAdmin) {
      console.warn("Access denied: User is not an admin.");
      return (
        <div className="flex items-center justify-center h-screen w-screen bg-gradient-to-r from-red-400 to-red-600">
            <div className="bg-white dark:bg-gray-800 rounded-lg shadow-2xl p-10 text-center transform transition-transform duration-300 hover:scale-105">
                <h1 className="text-5xl font-extrabold text-red-600 mb-6">Access Denied</h1>
                <p className="text-lg text-gray-700 dark:text-gray-300 mb-6">
                    You do not have permission to view the requested page.
                </p>
                <p className="w-full mx-auto px-4 py-2 text-lg mt-4">
                    <a href="/login" className="bg-red-600 text-white font-semibold py-2 px-4 rounded shadow hover:bg-red-700 transition duration-300">
                        Please log in as an admin.
                    </a>
                </p>
            </div>
        </div>
      );
    }
  }

  return children;
};

export default PrivateRoute;
