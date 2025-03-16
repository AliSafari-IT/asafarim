import { useState } from 'react';
import Wrapper from '../../layout/Wrapper/Wrapper';
import { useNavigate } from 'react-router-dom';
import { login } from '../../api/authapi';
import { isAxiosError } from 'axios';
import DeletedAccountMessage from '../../components/DeletedAccountMessage';
import { logger } from '@/utils/logger';

const LoginPage = () => {
  logger.info('LoginPage component mounted');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [rememberMe, setRememberMe] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState(false);
  const [showDeletedMessage, setShowDeletedMessage] = useState(false);
  const navigate = useNavigate();

  const demoCredentials = [
    {
      email: "demo_admin@example.com",
      password: "Demo+123456/",
      label: "Demo Admin"
    },
    {
      email: "demo_user@example.com",
      password: "Demo+123456/",
      label: "Demo User"
    }
  ];

  const handleLogin = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    logger.info('Login button clicked');
  
    if (!email || !password) {
      setError('Email and password are required');
      return;
    }
  
    setError(null);
    setLoading(true);
    logger.info('Calling login API with email: ' + email);
  
    try {
      // Clear any existing tokens first
      localStorage.removeItem('auth');
      sessionStorage.removeItem('auth');
      
      const auth = await login({ email, password });
      logger.info('Login API call successful');
      logger.info('Login API response:', auth);
  
      // The response is now normalized in the API function
      // Check if the user account is deleted
      if (auth.authenticatedUser?.isDeleted) {
        logger.info('Attempted login to deleted account');
        setShowDeletedMessage(true);
        setLoading(false);
        return;
      }
      
      // Create auth data object - using the normalized response
      const authData = {
        authenticated: auth.authenticated !== false, // Default to true if not explicitly false
        authenticatedUser: auth.authenticatedUser,
        token: auth.token,
      };
      
      logger.info('Storing auth data:', authData);
      
      // Store in appropriate storage
      try {
        if (rememberMe) {
          localStorage.setItem('auth', JSON.stringify(authData));
          logger.info('Auth data stored in localStorage');
        } else {
          sessionStorage.setItem('auth', JSON.stringify(authData));
          logger.info('Auth data stored in sessionStorage');
        }
        
        // Notify other components about auth state change
        window.dispatchEvent(new Event('authStateChange'));
        logger.info('Auth state change event dispatched');
        
        // Redirect to home page
        logger.info('Redirecting to home page...');
        setTimeout(() => {
          window.location.href = '/';
        }, 500);
      } catch (e) {
        logger.error('Error storing auth data:', e);
        setError('Error storing authentication data');
        setLoading(false);
      }
    } catch (err: unknown) {
      logger.error('Login error: ' + JSON.stringify(err, null, 2));
      logger.error('Login error details:', err);
  
      if (isAxiosError(err)) {
        if (err.response) {
          const { status, data } = err.response;
          if (status === 401) {
            setError(data?.message || 'Invalid credentials.');
          } else if (status === 403) {
            if (data?.isDeleted) {
              setShowDeletedMessage(true);
              return;
            }
            setError(data?.message || 'Your account is locked. Try again later.');
          } else {
            setError('An unexpected error occurred.');
          }
        } else {
          setError('Network error. Please try again.');
        }
      } else {
        setError('An unexpected error occurred.');
      }
      setLoading(false);
    }
  };
  

  if (showDeletedMessage) {
    return (
      <Wrapper header={<div className="w-full text-center py-8 text-2xl text-primary border-b border-primary z-10">Account Deleted</div>}>
        <DeletedAccountMessage email={email} onClose={() => setShowDeletedMessage(false)} />
      </Wrapper>
    );
  }

  return (
    <Wrapper>
      <div className="min-h-screen flex items-center justify-center bg-gray-50 py-12 px-4 sm:px-6 lg:px-8">
        <div className="max-w-md w-full space-y-8">
          <div>
            <h2 className="mt-6 text-center text-3xl font-extrabold text-gray-900">
              Sign in to your account
            </h2>
          </div>
          <form className="mt-8 space-y-6" onSubmit={handleLogin}>
            <div className="rounded-md shadow-sm -space-y-px">
              <div>
                <label htmlFor="email-address" className="sr-only">
                  Email address
                </label>
                <input
                  id="email-address"
                  name="email"
                  type="email"
                  autoComplete="email"
                  required
                  className="appearance-none rounded-none relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 rounded-t-md focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm"
                  placeholder="Email address"
                  value={email}
                  onChange={(e) => setEmail(e.target.value)}
                />
              </div>
              <div>
                <label htmlFor="password" className="sr-only">
                  Password
                </label>
                <input
                  id="password"
                  name="password"
                  type="password"
                  autoComplete="current-password"
                  required
                  className="appearance-none rounded-none relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 rounded-b-md focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm"
                  placeholder="Password"
                  value={password}
                  onChange={(e) => setPassword(e.target.value)}
                />
              </div>
            </div>

            <div className="flex items-center justify-between">
              <div className="flex items-center">
                <input
                  id="remember-me"
                  name="remember-me"
                  type="checkbox"
                  checked={rememberMe}
                  onChange={(e) => setRememberMe(e.target.checked)}
                  className="h-4 w-4 text-indigo-600 focus:ring-indigo-500 border-gray-300 rounded"
                />
                <label htmlFor="remember-me" className="ml-2 block text-sm text-gray-900">
                  Remember me
                </label>
              </div>

              <div className="text-sm">
                <a 
                  href="/forgot-password" 
                  className="font-medium text-indigo-600 hover:text-indigo-500"
                  onClick={(e) => {
                    e.preventDefault();
                    navigate('/forgot-password');
                  }}
                >
                  Forgot your password?
                </a>
              </div>
            </div>

            {error && (
              <div className="text-red-500 text-sm text-center">{error}</div>
            )}

            <div>
              <button
                type="submit"
                disabled={loading}
                className="group relative w-full flex justify-center py-2 px-4 border border-transparent text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
              >
                {loading ? 'Signing in...' : 'Sign in'}
              </button>
            </div>

            {/* Demo login buttons - separated from the form to prevent form submission */}
            <div className="flex flex-col space-y-2">
              <div className="text-center text-sm text-gray-500 mb-2">Or use a demo account</div>
              {demoCredentials.map((demo, index) => (
                <button
                  key={index}
                  type="button"
                  onClick={() => {
                    setLoading(true);
                    setError(null);
                    logger.info('Attempting demo login with email: ' + demo.email);
                    
                    // Clear any existing tokens first
                    localStorage.removeItem('auth');
                    sessionStorage.removeItem('auth');
                    
                    // Attempt login
                    login(demo)
                      .then(auth => {
                        logger.info('Demo login API response:', auth);
                        
                        // The response is now normalized in the API function
                        // Create auth data object - using the normalized response
                        const authData = {
                          authenticated: auth.authenticated !== false, // Default to true if not explicitly false
                          authenticatedUser: auth.authenticatedUser,
                          token: auth.token,
                        };
                        
                        logger.info('Storing auth data:', authData);
                        
                        // Store in appropriate storage
                        try {
                          if (rememberMe) {
                            localStorage.setItem('auth', JSON.stringify(authData));
                            logger.info('Auth data stored in localStorage');
                          } else {
                            sessionStorage.setItem('auth', JSON.stringify(authData));
                            logger.info('Auth data stored in sessionStorage');
                          }
                          
                          // Notify other components about auth state change
                          window.dispatchEvent(new Event('authStateChange'));
                          logger.info('Auth state change event dispatched');
                          
                          // Redirect to home page
                          logger.info('Redirecting to home page...');
                          setTimeout(() => {
                            window.location.href = '/';
                          }, 500);
                        } catch (e) {
                          logger.error('Error storing auth data:', e);
                          setError('Error storing authentication data');
                          setLoading(false);
                        }
                      })
                      .catch(err => {
                        logger.error('Demo login error: ' + JSON.stringify(err, null, 2));
                        logger.error('Demo login error details:', err);
                        
                        // Display a more specific error message
                        if (isAxiosError(err)) {
                          if (err.response) {
                            const { status, data } = err.response;
                            logger.error(`Demo login failed with status ${status}:`, data);
                            setError(data?.message || `Error ${status}: ${data?.error || 'Unknown error'}`);
                          } else if (err.request) {
                            logger.error('Demo login request made but no response received:', err.request);
                            setError('No response received from server. Please check your connection.');
                          } else {
                            logger.error('Demo login error during request setup:', err.message);
                            setError(`Error setting up request: ${err.message}`);
                          }
                        } else {
                          logger.error('Non-Axios demo login error:', err);
                          setError('Failed to login with demo account. Please try again.');
                        }
                        
                        setLoading(false);
                      });
                  }}
                  disabled={loading}
                  className="group relative w-full flex justify-center py-2 px-4 border border-gray-300 text-sm font-medium rounded-md text-gray-700 bg-white hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                >
                  Login as {demo.label}
                </button>
              ))}
            </div>
          </form>
        </div>
      </div>
    </Wrapper>
  );
};

export default LoginPage;
