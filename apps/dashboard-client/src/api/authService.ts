const API_URL = (import.meta as any).env.VITE_API_URL
  ? `${(import.meta as any).env.VITE_API_URL}/api/auth`
  : 'https://asafarim.com/api/auth';
console.log(`API URL is: ${API_URL}`, `import.meta.env.VITE_API_URL is: ${(import.meta as any).env.VITE_API_URL}`);

const login = async (username: string, password: string) => { 
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
      // If the status is 401, capture it as an error.
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
