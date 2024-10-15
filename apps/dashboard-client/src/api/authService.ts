const API_URL = import.meta.env.VITE_API_URL ? `${import.meta.env.VITE_API_URL}/api/auth` : 'https://asafarim.com/api/auth';
console.log(`API URL is: ${API_URL}`, `import.meta.env.VITE_API_URL is: ${import.meta.env.VITE_API_URL}`);

const login = async (username: string, password: string) => {
  console.log(`Attempting to login with username: ${username} and password: ${password}`);
  
  try {
    const response = await fetch(`${API_URL}/login`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
        'Accept': 'application/json',
      },
      body: JSON.stringify({ username, password }),
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

export default { login };
