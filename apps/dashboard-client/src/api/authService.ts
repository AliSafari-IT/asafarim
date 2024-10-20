import API_URL from "./getApiUrls";

const login = async (username: string, password: string) => {
  console.debug('API_URL in authService: ' + API_URL);
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
      const { message } = await response.json();
      throw new Error(`Login failed with status: ${response.status}, message: ${message}`);
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

