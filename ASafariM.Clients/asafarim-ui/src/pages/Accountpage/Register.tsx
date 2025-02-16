import React, { useState } from 'react';
import { register } from '../../api/authapi';
import Wrapper from '../../layout/Wrapper/Wrapper';
import { useNavigate } from 'react-router-dom';
import { IRegisterModel } from '../../interfaces/IRegisterModel';
import { logger } from '@/utils/logger';

const Register: React.FC = () => {
  const [model, setModel] = useState<IRegisterModel>({
    email: '',
    password: '',
    firstName: '',
    lastName: '',
    userName: '',
    isAdmin: false,
    dateOfBirth: undefined,
    profilePicture: undefined
  });
  const [error, setError] = useState<string | null>(null);
  const [successMessage, setSuccessMessage] = useState<string | null>(null);
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate();

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    try {
      logger.info('Registration started');
      
      // Validate all required fields
      if (!model.email || !model.password || !model.firstName || !model.lastName || !model.userName) {
        setError('All fields are required');
        return;
      }

      // Validate email format
      const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
      if (!emailRegex.test(model.email)) {
        setError('Please enter a valid email address');
        return;
      }

      // Validate password strength
      if (model.password.length < 6) {
        setError('Password must be at least 6 characters long');
        return;
      }

      // Validate username
      if (model.userName.length < 3) {
        setError('Username must be at least 3 characters long');
        return;
      }

      // Convert dateOfBirth string to Date if present
      const registrationData = {
        ...model,
        dateOfBirth: model.dateOfBirth ? new Date(model.dateOfBirth) : undefined,
        isAdmin: false // Always set to false for security
      };

      setLoading(true);
      logger.info(`Calling register API with model: ${JSON.stringify(registrationData)}`);
      const data = await register(registrationData);
      logger.info('Register API call completed');
      console.log('Registration successful:', data);
      setError(null);
      setSuccessMessage('Registration successful!');
      logger.info('Registration successful. Navigating to /login');
      setTimeout(() => {
        navigate('/login');
      }, 2000);
    } catch (error) {
      console.error('Registration error:', error);
      logger.error(`Registration failed: ${error}`);
      if (error instanceof Error) {
        const errorMessage = error.message;
        if (errorMessage.toLowerCase().includes('already')) {
          setError(
            'This email is already associated with an account. Please <a href="/login">log in</a> or use a different email.'
          );
        } else {
          setError(errorMessage);
        }
      } else {
        setError('An unexpected error occurred during registration.');
      }
    } finally {
      setLoading(false);
      logger.info('Registration process completed');
    }
  };

  return (
    <Wrapper header={<div className="w-full text-center py-8 text-2xl text-primary border-b border-primary z-10">Register</div>}>
      <div className="flex items-center justify-center min-h-[calc(100vh-var(--navbar-height)-200px)]">
        <form
          onSubmit={handleSubmit}
          className="login-form flex flex-col items-center justify-center space-y-6 w-full max-w-md mx-auto px-4 py-8 bg-white dark:bg-gray-800 shadow-md rounded-lg"
        >
          {/* First Name Input */}
          <div className="w-full">
            <label htmlFor="firstName" className="block mb-2 font-semibold text-gray-700 dark:text-gray-300">
              First Name:
            </label>
            <input
              type="text"
              id="firstName"
              value={model.firstName}
              onChange={(e) => setModel({ ...model, firstName: e.target.value })}
              placeholder="Enter your first name"
              className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
              required
            />
          </div>

          {/* Last Name Input */}
          <div className="w-full">
            <label htmlFor="lastName" className="block mb-2 font-semibold text-gray-700 dark:text-gray-300">
              Last Name:
            </label>
            <input
              type="text"
              id="lastName"
              value={model.lastName}
              onChange={(e) => setModel({ ...model, lastName: e.target.value })}
              placeholder="Enter your last name"
              className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
              required
            />
          </div>

          {/* Username Input */}
          <div className="w-full">
            <label htmlFor="userName" className="block mb-2 font-semibold text-gray-700 dark:text-gray-300">
              Username:
            </label>
            <input
              type="text"
              id="userName"
              value={model.userName}
              onChange={(e) => setModel({ ...model, userName: e.target.value })}
              placeholder="Enter your username"
              className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
              required
            />
          </div>

          {/* Date of Birth Input */}
          <div className="w-full">
            <label htmlFor="dateOfBirth" className="block mb-2 font-semibold text-gray-700 dark:text-gray-300">
              Date of Birth:
            </label>
            <input
              type="date"
              id="dateOfBirth"
              value={model.dateOfBirth ? model.dateOfBirth.toISOString().split('T')[0] : ''}
              onChange={(e) => setModel({ ...model, dateOfBirth: e.target.value ? new Date(e.target.value) : undefined })}
              className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
            />
          </div>

          {/* Profile Picture Input */}
          <div className="w-full">
            <label htmlFor="profilePicture" className="block mb-2 font-semibold text-gray-700 dark:text-gray-300">
              Profile Picture URL:
            </label>
            <input
              type="text"
              id="profilePicture"
              value={model.profilePicture || ''}
              onChange={(e) => setModel({ ...model, profilePicture: e.target.value })}
              placeholder="Enter a profile picture URL"
              className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
            />
          </div>
          
          {/* Email Input */}
          <div className="w-full">
            <label htmlFor="email" className="block mb-2 font-semibold text-gray-700 dark:text-gray-300">
              Email:
            </label>
            <input
              type="email"
              id="email"
              value={model.email}
              onChange={(e) => setModel({ ...model, email: e.target.value })}
              placeholder="Enter your email"
              className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
              required
            />
          </div>

          {/* Password Input */}
          <div className="w-full">
            <label htmlFor="password" className="block mb-2 font-semibold text-gray-700 dark:text-gray-300">
              Password:
            </label>
            <input
              type="password"
              id="password"
              value={model.password}
              onChange={(e) => setModel({ ...model, password: e.target.value })}
              placeholder="Enter your password"
              className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
              autoComplete="new-password"
              required
            />
          </div>

          {/* Error and Success Messages */}
          {error && <div className="text-red-500">{error}</div>}
          {successMessage && <div className="text-green-500">{successMessage}</div>}

          {/* Submit Button */}
          <button
            type="submit"
            disabled={loading}
            className="w-full py-3 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors disabled:opacity-50"
          >
            {loading ? 'Registering...' : 'Register'}
          </button>
        </form>
      </div>
    </Wrapper>
  );
};

export default Register;
