// Set the API URL for your auth service
const API_URL = 'https://localhost:44337/api/auth';

// Use fetch instead of axios for the login function
const login = async (username: string, password: string) => {
  console.log(`Attempting to login with username: ${username} and password: ${password}`);
  
  try {
    const response = await fetch(`${API_URL}/login`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
        'Accept': 'application/json'
      },
      body: JSON.stringify({ username, password }),
      // Optional: disable SSL certificate verification in development mode
      // Note: fetch API doesn't directly support disabling SSL verification in the browser
    });

    if (!response.ok) {
      throw new Error(`Login failed with status: ${response.status}`);
    }

    const data = await response.json();
    console.log(`Login response: ${JSON.stringify(data)}`);

    if (data.token) {
      localStorage.setItem('user', JSON.stringify(data));
    }

    return data;
  } catch (error) {
    console.error('Login failed', error);
    throw error;
  }
};

const authService = { login };
export default authService;
