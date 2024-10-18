// Determine the correct API URL based on the current hostname
let API_URL = (import.meta as any).env.VITE_API_URL || 'https://asafarim.com/api';

// Dynamically update the API URL if the user is on a subdomain like preview.asafarim.com
if (window.location.hostname === 'preview.asafarim.com') {
  API_URL = 'https://preview.asafarim.com/api';
} else if (window.location.hostname === 'asafarim.com') {
  API_URL = 'https://asafarim.com/api';
}

// Log the final API URL for debugging
console.log(`API URL in Home: ${API_URL}`);

// Continue with your login function
const login = async (username: string, password: string) => { 
  try {
    const response = await fetch(`${API_URL}/auth/login`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
        'Accept': 'application/json',
      },
      body: JSON.stringify({ username, password }),
    });

    if (!response.ok) {
      const errorResponse = await response.json();
      const error = new Error(`Login failed with status: ${response.status}`);
      (error as any).response = { status: response.status, message: errorResponse.message };
      throw error;
    }

    const data = await response.json();
    if (data.token) {
      localStorage.setItem('user', JSON.stringify(data));
    }

    return data;
  } catch (error) {
    console.error('Login failed', error);
    throw error;
  }
};

export default { login };
