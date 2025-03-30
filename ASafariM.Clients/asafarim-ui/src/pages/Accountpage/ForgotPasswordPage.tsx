import { useState } from 'react';
import Wrapper from '../../layout/Wrapper/Wrapper';
import { useNavigate } from 'react-router-dom';
import { requestPasswordReset } from '../../api/authapi';
import { isAxiosError } from 'axios';
import { logger } from '@/utils/logger';

const ForgotPasswordPage = () => {
  logger.info('ForgotPasswordPage component mounted');
  const [email, setEmail] = useState('');
  const [error, setError] = useState<string | null>(null);
  const [success, setSuccess] = useState<string | null>(null);
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate();

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    logger.info('Forgot password button clicked');
  
    if (!email) {
      setError('Email is required');
      return;
    }
  
    setError(null);
    setSuccess(null);
    setLoading(true);
    logger.info('Calling requestPasswordReset API with email: ' + email);
  
    try {
      await requestPasswordReset(email);
      logger.info('Password reset request successful');
      setSuccess('Password reset instructions have been sent to your email. Please check your inbox.');
      
      // Clear the email field after success
      setEmail('');
    } catch (err: unknown) {
      logger.error('Password reset error: ' + JSON.stringify(err, null, 2));
  
      if (isAxiosError(err)) {
        if (err.response) {
          const { status, data } = err.response;
          if (status === 404) {
            setError(data?.message || 'Email not found.');
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
            <h2 className="mt-6 text-center text-3xl font-extrabold text-gray-900" data-testid="forgot-password-heading">
              Forgot Password
            </h2>
            <p className="mt-2 text-center text-sm text-gray-600">
              Enter your email address and we'll send you instructions to reset your password.
            </p>
          </div>
          <form className="mt-8 space-y-6" onSubmit={handleSubmit} role="form">
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
                  className="appearance-none rounded-md relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm"
                  placeholder="Email address"
                  value={email}
                  onChange={(e) => setEmail(e.target.value)}
                  data-testid="email-input"
                />
              </div>
            </div>

            {error && (
              <div className="text-red-500 text-sm text-center" data-testid="error-message">{error}</div>
            )}

            {success && (
              <div className="text-green-500 text-sm text-center" data-testid="success-message">{success}</div>
            )}

            <div>
              <button
                type="submit"
                disabled={loading}
                className="group relative w-full flex justify-center py-2 px-4 border border-transparent text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                data-testid="reset-button"
              >
                {loading ? 'Sending...' : 'Send Reset Instructions'}
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
                data-testid="back-to-login-link"
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

export default ForgotPasswordPage;
