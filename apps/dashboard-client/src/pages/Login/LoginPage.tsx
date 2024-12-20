import { useState } from 'react';
import authService from '../../api/authService';
import Wrapper from '../../layout/Wrapper/Wrapper';
import { useNavigate } from 'react-router-dom';
import AlertContainer from '../../components/AlertContainer';

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
    } catch (error: any) {
      if (error?.response && error.response.status === 401) {
        setError(`Invalid username or password: (Error ${error.response.status})`);
      } else {
        console.error('An unexpected error occurred:', error);
        setError('An unexpected error occurred. Please try again later. (Error 500: Internal Server Error)');
      }
    } finally {
      setLoading(false);
    }
  };

  return (
    <Wrapper header={<div className="w-full text-center py-8 text-2xl border z-10">Login</div>}>
      <AlertContainer theme="info" className="w-1/2 mx-auto my-10 px-4 py-3 rounded relative">
        <form onSubmit={handleLogin} className="flex flex-col items-center justify-center space-y-4">
          
          {/* Input for username */}
          <div className="w-full max-w-xs">
            <label htmlFor="username" className="block mb-2  font-bold">Username:</label>
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
            <label htmlFor="password" className='block mb-2 font-bold'>Password:</label>
            <input
              type="password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              placeholder="Add your password"
              className="p-2 border rounded-md w-full max-w-xs"
              autoComplete='current-password'
              required
            />
          </div>

          {/* Display error with alert info style */}
          {error && (
            <div className="max-w-xs w-full p-4 mb-2 danger  border border-red-200  rounded-lg shadow text-center">
              <p className="text-sm font-medium">{error}</p>
            </div>
          )}

          {/* Login button */}
          <button
            type="submit" // Change to type="submit" to trigger form submission
            disabled={loading}
            className="p-2 bg-blue-500 hover:bg-blue-700 text-white rounded-md"
          >
            {loading ? 'Logging in...' : 'Login'}
          </button>
        </form>
      </AlertContainer>
    </Wrapper>
  );
};

export default LoginPage;
