import React from 'react';
import ModernNavbar from '@/layout/Navbar/ModernNavbar';
import { ThemeProvider } from '@/contexts/ThemeContext';
import { trackPageView } from '@/services/analyticsService';
import { useEffect } from 'react';
import { useLocation } from 'react-router-dom';

const NavbarDemo: React.FC = () => {
  const location = useLocation();

  // Track page views when route changes
  useEffect(() => {
    trackPageView(location.pathname, 'Navbar Demo');
    document.title = 'Navbar Demo | ASafariM';
  }, [location]);

  return (
    <ThemeProvider>
      <div className="min-h-screen bg-gray-50 dark:bg-gray-900">
        <ModernNavbar />
        
        <div className="pt-28 px-4 sm:px-6 lg:px-8 max-w-7xl mx-auto">
          <div className="text-center">
            <h1 className="text-3xl font-extrabold text-gray-900 dark:text-white sm:text-4xl">
              Modern Navbar Demo
            </h1>
            <p className="mt-3 max-w-2xl mx-auto text-xl text-gray-500 dark:text-gray-300 sm:mt-4">
              This page demonstrates the new responsive navbar with theme support
            </p>
          </div>

          <div className="mt-12 bg-white dark:bg-gray-800 overflow-hidden shadow rounded-lg">
            <div className="px-4 py-5 sm:p-6">
              <h2 className="text-lg font-medium text-gray-900 dark:text-white">Features</h2>
              <ul className="mt-4 space-y-2 text-gray-600 dark:text-gray-300">
                <li className="flex items-start">
                  <svg className="flex-shrink-0 h-5 w-5 text-green-500" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20" fill="currentColor">
                    <path fillRule="evenodd" d="M10 18a8 8 0 100-16 8 8 0 000 16zm3.707-9.293a1 1 0 00-1.414-1.414L9 10.586 7.707 9.293a1 1 0 00-1.414 1.414l2 2a1 1 0 001.414 0l4-4z" clipRule="evenodd" />
                  </svg>
                  <span className="ml-2">Fully responsive design that works on all screen sizes</span>
                </li>
                <li className="flex items-start">
                  <svg className="flex-shrink-0 h-5 w-5 text-green-500" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20" fill="currentColor">
                    <path fillRule="evenodd" d="M10 18a8 8 0 100-16 8 8 0 000 16zm3.707-9.293a1 1 0 00-1.414-1.414L9 10.586 7.707 9.293a1 1 0 00-1.414 1.414l2 2a1 1 0 001.414 0l4-4z" clipRule="evenodd" />
                  </svg>
                  <span className="ml-2">Dark/light theme support with smooth transitions</span>
                </li>
                <li className="flex items-start">
                  <svg className="flex-shrink-0 h-5 w-5 text-green-500" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20" fill="currentColor">
                    <path fillRule="evenodd" d="M10 18a8 8 0 100-16 8 8 0 000 16zm3.707-9.293a1 1 0 00-1.414-1.414L9 10.586 7.707 9.293a1 1 0 00-1.414 1.414l2 2a1 1 0 001.414 0l4-4z" clipRule="evenodd" />
                  </svg>
                  <span className="ml-2">Multi-level dropdown menus with smooth animations</span>
                </li>
                <li className="flex items-start">
                  <svg className="flex-shrink-0 h-5 w-5 text-green-500" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20" fill="currentColor">
                    <path fillRule="evenodd" d="M10 18a8 8 0 100-16 8 8 0 000 16zm3.707-9.293a1 1 0 00-1.414-1.414L9 10.586 7.707 9.293a1 1 0 00-1.414 1.414l2 2a1 1 0 001.414 0l4-4z" clipRule="evenodd" />
                  </svg>
                  <span className="ml-2">Mobile-optimized navigation with collapsible sections</span>
                </li>
              </ul>
            </div>
          </div>

          <div className="mt-8 grid gap-6 lg:grid-cols-2">
            <div className="bg-white dark:bg-gray-800 overflow-hidden shadow rounded-lg">
              <div className="px-4 py-5 sm:p-6">
                <h2 className="text-lg font-medium text-gray-900 dark:text-white">Nested Submenu Support</h2>
                <p className="mt-2 text-gray-600 dark:text-gray-300">
                  The ModernNavbar component now supports multi-level nested submenus. Try clicking on the "Essential Insights" or "Learning Projects" items in the navbar to see the nested dropdown menus in action.
                </p>
                <div className="mt-4 bg-gray-50 dark:bg-gray-700 p-4 rounded-md">
                  <h3 className="text-sm font-medium text-gray-900 dark:text-white">Implementation Details:</h3>
                  <ul className="mt-2 list-disc pl-5 text-sm text-gray-600 dark:text-gray-300 space-y-1">
                    <li>Recursive component structure for unlimited nesting levels</li>
                    <li>Proper focus management and keyboard navigation</li>
                    <li>Automatic positioning of submenus to prevent overflow</li>
                    <li>Mobile-optimized collapsible sections for nested items</li>
                    <li>Smooth animations for opening and closing menus</li>
                  </ul>
                </div>
              </div>
            </div>

            <div className="bg-white dark:bg-gray-800 overflow-hidden shadow rounded-lg">
              <div className="px-4 py-5 sm:p-6">
                <h2 className="text-lg font-medium text-gray-900 dark:text-white">Mobile Responsiveness</h2>
                <p className="mt-2 text-gray-600 dark:text-gray-300">
                  The navbar automatically adapts to different screen sizes. On mobile devices, it transforms into a hamburger menu with collapsible sections for nested navigation.
                </p>
                <div className="mt-4">
                  <h3 className="text-sm font-medium text-gray-900 dark:text-white">Try it out:</h3>
                  <p className="mt-1 text-sm text-gray-600 dark:text-gray-300">
                    Resize your browser window or use the browser's device emulation to see how the navbar responds to different screen sizes.
                  </p>
                  <div className="mt-4 flex flex-wrap gap-2">
                    <span className="inline-flex items-center px-3 py-0.5 rounded-full text-sm font-medium bg-blue-100 text-blue-800 dark:bg-blue-800 dark:text-blue-100">
                      Desktop
                    </span>
                    <span className="inline-flex items-center px-3 py-0.5 rounded-full text-sm font-medium bg-purple-100 text-purple-800 dark:bg-purple-800 dark:text-purple-100">
                      Tablet
                    </span>
                    <span className="inline-flex items-center px-3 py-0.5 rounded-full text-sm font-medium bg-green-100 text-green-800 dark:bg-green-800 dark:text-green-100">
                      Mobile
                    </span>
                  </div>
                </div>
              </div>
            </div>
          </div>

          <div className="mt-8 bg-white dark:bg-gray-800 overflow-hidden shadow rounded-lg">
            <div className="px-4 py-5 sm:p-6">
              <h2 className="text-lg font-medium text-gray-900 dark:text-white">Theme Integration</h2>
              <p className="mt-2 text-gray-600 dark:text-gray-300">
                The ModernNavbar seamlessly integrates with the application's theme system. Click the theme toggle button in the navbar to switch between light and dark modes.
              </p>
              <div className="mt-4 flex space-x-4">
                <button className="inline-flex items-center px-4 py-2 border border-transparent text-sm font-medium rounded-md shadow-sm text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500">
                  View Source Code
                </button>
                <button className="inline-flex items-center px-4 py-2 border border-gray-300 dark:border-gray-600 shadow-sm text-sm font-medium rounded-md text-gray-700 dark:text-gray-200 bg-white dark:bg-gray-700 hover:bg-gray-50 dark:hover:bg-gray-600 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500">
                  Documentation
                </button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </ThemeProvider>
  );
};

export default NavbarDemo;
