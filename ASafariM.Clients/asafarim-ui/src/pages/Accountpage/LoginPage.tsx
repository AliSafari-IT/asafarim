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
      const auth = await login({ email, password });
      logger.info('Login API call successful');
  
      // Check if the user account is deleted
      if (auth.user?.isDeleted) {
        logger.info('Attempted login to deleted account');
        setShowDeletedMessage(true);
        return;
      }
  
      if (auth.token) {
        // Save the authenticated user and token properly
        const authData = {
          authenticatedUser: auth.user, // Store user details
          token: auth.token,
        };
        localStorage.setItem('auth', JSON.stringify(authData));
        window.dispatchEvent(new Event('authStateChange')); // Notify other components
        console.log('Auth data stored:', authData);
        const returnTo = localStorage.getItem('returnTo') || '/';
        localStorage.removeItem('returnTo');
        navigate(returnTo);
      }
    } catch (err: unknown) {
      logger.error('Login error: ' + JSON.stringify(err, null, 2));
  
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
    } finally {
      setLoading(false);
      logger.info('Login process completed. Loading state: ' + loading);
    }
  };
  

  const handleDemoLogin = async (credentials: { email: string; password: string }) => {
    setEmail(credentials.email);
    setPassword(credentials.password);
    try {
      setLoading(true);
      logger.info('Attempting demo login with email: ' + credentials.email);
      const auth = await login(credentials);
      if (auth.token) {
        localStorage.setItem('auth', JSON.stringify(auth));
        const returnTo = localStorage.getItem('returnTo') || '/';
        localStorage.removeItem('returnTo');
        navigate(returnTo);
      }
    } catch (err) {
      logger.error('Demo login error: ' + JSON.stringify(err, null, 2));
      setError('Failed to login with demo account');
    } finally {
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
            <input type="hidden" name="remember" value="true" />
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

            <div className="flex flex-col space-y-2">
              {demoCredentials.map((demo, index) => (
                <button
                  key={index}
                  type="button"
                  onClick={() => handleDemoLogin(demo)}
                  disabled={loading}
                  className="group relative w-full flex justify-center py-2 px-4 border border-gray-300 text-sm font-medium rounded-md text-gray-700 bg-white hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                >
                  Login as {demo.label}
                </button>
              ))}
            </div>
          </form>

          {showDeletedMessage && <DeletedAccountMessage email={email} onClose={() => setShowDeletedMessage(false)}/>}
        </div>
      </div>
    </Wrapper>
  );
};

export default LoginPage;
