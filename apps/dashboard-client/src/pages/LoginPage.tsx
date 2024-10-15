// src/pages/LoginPage.tsx

import { useState } from 'react';
import authService from '../api/authService';
import Wrapper from '../layout/Wrapper/Wrapper';
import { useNavigate } from 'react-router-dom';

const LoginPage = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate(); // use for redirection after login

  const handleLogin = async (e: React.FormEvent) => {
    e.preventDefault(); // Prevent the default form submission behavior

    if (!username || !password) {
      setError('Username and password are required');
      return;
    }

    setLoading(true);
    setError(null);

    try {
      const user = await authService.login(username, password);
      if (user.token) {
        // Save token to localStorage
        localStorage.setItem('token', user.token);
        console.log('Logged in successfully, token saved');
        // Optionally redirect to a dashboard or home page after login
        navigate('/dashboard');
      }
    } catch (error) {
      setError('Login failed. Please check your credentials.');
      console.error('Login failed', error);
    } finally {
      setLoading(false);
    }
  };

  return (
    <Wrapper header={<h1 className="text-3xl font-bold mt-16 mb-4">Login</h1>}>
      <form onSubmit={handleLogin} className="flex flex-col items-center justify-center space-y-4">
        

        {/* Input for username */}
        <div className="w-full max-w-xs">
        <label htmlFor="username" className="block mb-2 text-gray-700 font-bold">Username:</label>
        <input
          type="text"
          value={username}
          onChange={(e) => setUsername(e.target.value)}
          placeholder="Add your username"
          className="p-2 border rounded-md w-full max-w-xs"
          required
        />
        </div>

        {/* Input for password */}
        <div className='w-full max-w-xs'>
        <label htmlFor="password" className='block mb-2 text-gray-700 font-bold'>Password:</label>
        <input
          type="password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
          placeholder="Add your password"
          className="p-2 border rounded-md w-full max-w-xs"
          required
        />
        </div>

        {/* Display error if any */}
        {error && <p className="text-red-500">{error}</p>}

        {/* Login button */}
        <button
          type="submit" // Change to type="submit" to trigger form submission
          disabled={loading}
          className="p-2 bg-blue-500 hover:bg-blue-700 text-white rounded-md"
        >
          {loading ? 'Logging in...' : 'Login'}
        </button>
      </form>
    </Wrapper>
  );
};

export default LoginPage;
