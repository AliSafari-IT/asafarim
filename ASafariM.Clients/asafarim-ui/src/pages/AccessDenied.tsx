import { useNavigate } from "react-router-dom";
import React from "react";

const AccessDenied: React.FC = () => {
  const navigate = useNavigate();

  return (
    <div className="min-h-screen flex items-center justify-center bg-red-500 dark:bg-red-700">
      <div className="max-w-md w-full bg-white dark:bg-gray-800 rounded-lg shadow-2xl overflow-hidden mx-4">
        <div className="p-8 text-center">
          <h1 className="text-3xl font-bold text-red-600 dark:text-red-400 mb-4">
            Access Denied
          </h1>
          
          <p className="text-gray-600 dark:text-gray-300 mb-8">
            You do not have permission to view the requested page.
          </p>
          
          <div className="flex flex-col space-y-3">
            <button
              onClick={() => navigate('/')}
              className="w-full px-6 py-3 bg-red-600 hover:bg-red-700 text-white rounded-md transition-colors duration-200 font-medium"
            >
              Go to Home
            </button>
            
            <button
              onClick={() => navigate(-1)}
              className="w-full px-6 py-3 bg-gray-200 hover:bg-gray-300 dark:bg-gray-700 dark:hover:bg-gray-600 text-gray-700 dark:text-gray-200 rounded-md transition-colors duration-200 font-medium"
            >
              Go Back
            </button>
            
            <button
              onClick={() => navigate('/login')}
              className="w-full px-6 py-3 border border-red-500 text-red-600 hover:bg-red-50 dark:border-red-400 dark:text-red-400 dark:hover:bg-red-900/20 rounded-md transition-colors duration-200 font-medium"
            >
              Log in as Admin
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default AccessDenied;