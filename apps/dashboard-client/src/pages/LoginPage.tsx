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
    <Wrapper>
      <form onSubmit={handleLogin} className="flex flex-col items-center justify-center space-y-4">
        <h1 className="text-3xl font-bold">Login</h1>

        {/* Input for username */}
        <input
          type="text"
          value={username}
          onChange={(e) => setUsername(e.target.value)}
          placeholder="Username"
          className="p-2 border rounded-md w-full max-w-xs"
          required
        />

        {/* Input for password */}
        <input
          type="password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
          placeholder="Password"
          className="p-2 border rounded-md w-full max-w-xs"
          required
        />

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
