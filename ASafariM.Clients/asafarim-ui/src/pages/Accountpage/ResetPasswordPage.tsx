import { useState, useEffect } from 'react';
import Wrapper from '../../layout/Wrapper/Wrapper';
import { useNavigate, useLocation } from 'react-router-dom';
import { resetPassword } from '../../api/authapi';
import { isAxiosError } from 'axios';
import { logger } from '@/utils/logger';

const ResetPasswordPage = () => {
  logger.info('ResetPasswordPage component mounted');
  const [email, setEmail] = useState('');
  const [token, setToken] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const [error, setError] = useState<string | null>(null);
  const [success, setSuccess] = useState<string | null>(null);
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate();
  const location = useLocation();

  useEffect(() => {
    // Extract token and email from URL query parameters
    const queryParams = new URLSearchParams(location.search);
    const tokenParam = queryParams.get('token');
    const emailParam = queryParams.get('email');

    if (tokenParam) {
      setToken(tokenParam);
    }
    
    if (emailParam) {
      setEmail(emailParam);
    }
  }, [location]);

  const validatePassword = (password: string): boolean => {
    // Password must be at least 8 characters long and contain at least one uppercase letter,
    // one lowercase letter, one number, and one special character
    const passwordRegex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;
    return passwordRegex.test(password);
  };

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    logger.info('Reset password button clicked');
  
    if (!email || !token) {
      setError('Invalid reset link. Please request a new password reset.');
      return;
    }

    if (!password || !confirmPassword) {
      setError('Password and confirmation are required');
      return;
    }

    if (password !== confirmPassword) {
      setError('Passwords do not match');
      return;
    }

    if (!validatePassword(password)) {
      setError('Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one number, and one special character');
      return;
    }
  
    setError(null);
    setSuccess(null);
    setLoading(true);
    logger.info('Calling resetPassword API with email: ' + email);
  
    try {
      await resetPassword(email, password, token);
      logger.info('Password reset successful');
      setSuccess('Your password has been reset successfully. You can now log in with your new password.');
      
      // Clear the form after success
      setPassword('');
      setConfirmPassword('');

      // Redirect to login page after 3 seconds
      setTimeout(() => {
        navigate('/login');
      }, 3000);
    } catch (err: unknown) {
      logger.error('Password reset error: ' + JSON.stringify(err, null, 2));
  
      if (isAxiosError(err)) {
        if (err.response) {
          const { status, data } = err.response;
          if (status === 400) {
            setError(data?.message || 'Invalid reset token or email.');
          } else {
            setError(data?.message || 'An unexpected error occurred.');
          }
        } else {
          setError('Network error. Please try again.');
        }
      } else {
        setError('An unexpected error occurred.');
      }
    } finally {
      setLoading(false);
      logger.info('Password reset process completed. Loading state: ' + loading);
    }
  };

  return (
    <Wrapper>
      <div className="min-h-screen flex items-center justify-center bg-gray-50 py-12 px-4 sm:px-6 lg:px-8">
        <div className="max-w-md w-full space-y-8">
          <div>
            <h2 className="mt-6 text-center text-3xl font-extrabold text-gray-900">
              Reset Your Password
            </h2>
            <p className="mt-2 text-center text-sm text-gray-600">
              Please enter your new password below.
            </p>
          </div>
          <form className="mt-8 space-y-6" onSubmit={handleSubmit}>
            <div className="rounded-md shadow-sm space-y-4">
              <div>
                <label htmlFor="email-address" className="block text-sm font-medium text-gray-700">
                  Email address
                </label>
                <input
                  id="email-address"
                  name="email"
                  type="email"
                  autoComplete="email"
                  required
                  className="mt-1 appearance-none rounded-md relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm"
                  placeholder="Email address"
                  value={email}
                  onChange={(e) => setEmail(e.target.value)}
                  readOnly={!!email}
                />
              </div>
              <div>
                <label htmlFor="password" className="block text-sm font-medium text-gray-700">
                  New Password
                </label>
                <input
                  id="password"
                  name="password"
                  type="password"
                  autoComplete="new-password"
                  required
                  className="mt-1 appearance-none rounded-md relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm"
                  placeholder="New password"
                  value={password}
                  onChange={(e) => setPassword(e.target.value)}
                />
              </div>
              <div>
                <label htmlFor="confirm-password" className="block text-sm font-medium text-gray-700">
                  Confirm New Password
                </label>
                <input
                  id="confirm-password"
                  name="confirm-password"
                  type="password"
                  autoComplete="new-password"
                  required
                  className="mt-1 appearance-none rounded-md relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm"
                  placeholder="Confirm new password"
                  value={confirmPassword}
                  onChange={(e) => setConfirmPassword(e.target.value)}
                />
              </div>
            </div>

            {error && (
              <div className="text-red-500 text-sm text-center">{error}</div>
            )}

            {success && (
              <div className="text-green-500 text-sm text-center">{success}</div>
            )}

            <div>
              <button
                type="submit"
                disabled={loading}
                className="group relative w-full flex justify-center py-2 px-4 border border-transparent text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
              >
                {loading ? 'Resetting...' : 'Reset Password'}
              </button>
            </div>

            <div className="text-center">
              <a 
                href="/login" 
                className="font-medium text-indigo-600 hover:text-indigo-500"
                onClick={(e) => {
                  e.preventDefault();
                  navigate('/login');
                }}
              >
                Back to Login
              </a>
            </div>
          </form>
        </div>
      </div>
    </Wrapper>
  );
};

export default ResetPasswordPage;
