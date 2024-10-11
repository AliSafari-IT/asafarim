# Step-by-Step Guide: Authentication and Authorization in a React App

This guide walks you through how to implement authentication and authorization in your React app. We’ll allow only logged-in users to access certain routes like the Dashboard and UserProfile pages.

## Prerequisites

- Basic understanding of React, Express (or ASP.NET for backend), and API communication.
- Backend API that supports JWT authentication (assumed to be running on `https://localhost:44337`).

---

## Step 1: Backend Setup for Authentication

In the backend, implement the authentication mechanism (e.g., login, JWT generation) using your framework (Node.js, ASP.NET, etc.).

**Example Login Route (POST `/api/auth/login`):**
```json
{
  "username": "ali",
  "password": "Ali+123456/"
}
```

Upon successful login, the API returns a JWT token.

---

## Step 2: Create AuthService to Handle Login

We need a service in our frontend to send login requests and manage the authentication state (store the token).

```javascript
// src/api/authService.ts

const API_URL = 'https://localhost:44337/api/auth';

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
      throw new Error('Login failed');
    }

    const data = await response.json();
    localStorage.setItem('token', data.token);  // Save JWT in localStorage
    return data;
  } catch (error) {
    throw new Error('Login failed');
  }
};

const authService = { login };
export default authService;
```

---

## Step 3: Create Protected Route for Authorization

We will create a `PrivateRoute` component that checks if a user is authenticated (i.e., if the JWT token is present) and protects the Dashboard and UserProfile routes.

```javascript
// src/components/PrivateRoute.tsx

import React from 'react';
import { Navigate } from 'react-router-dom';

const PrivateRoute = ({ children }: { children: JSX.Element }) => {
  const token = localStorage.getItem('token');  // Check if the token exists
  return token ? children : <Navigate to="/login" />;
};

export default PrivateRoute;
```

---

## Step 4: Implement the Login Page

We will create a login page that interacts with the backend to authenticate users and save their tokens.

```javascript
// src/pages/LoginPage.tsx

import { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import authService from '../api/authService';

const LoginPage = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState<string | null>(null);
  const navigate = useNavigate();

  const handleLogin = async () => {
    try {
      await authService.login(username, password);
      navigate('/dashboard');  // Redirect to dashboard after login
    } catch (error) {
      setError('Login failed. Please check your credentials.');
    }
  };

  return (
    <div>
      <h2>Login</h2>
      <input
        type="text"
        value={username}
        onChange={(e) => setUsername(e.target.value)}
        placeholder="Username"
      />
      <input
        type="password"
        value={password}
        onChange={(e) => setPassword(e.target.value)}
        placeholder="Password"
      />
      <button onClick={handleLogin}>Login</button>
      {error && <p>{error}</p>}
    </div>
  );
};

export default LoginPage;
```

---

## Step 5: Protect Routes with `PrivateRoute`

In your `App.tsx` or routing configuration, protect the routes that require authentication using `PrivateRoute`.

```javascript
// src/App.tsx

import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import LoginPage from './pages/LoginPage';
import Dashboard from './pages/Dashboard';
import UserProfile from './pages/UserProfile';
import PrivateRoute from './components/PrivateRoute';

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/login" element={<LoginPage />} />
        
        {/* Protect Dashboard and UserProfile routes */}
        <Route path="/dashboard" element={<PrivateRoute><Dashboard /></PrivateRoute>} />
        <Route path="/user-profile" element={<PrivateRoute><UserProfile /></PrivateRoute>} />
        
        {/* Default route */}
        <Route path="/" element={<LoginPage />} />
      </Routes>
    </Router>
  );
}

export default App;
```

---

## Step 6: Display User-Specific Data (Example: Dashboard)

Use the token stored in `localStorage` to access protected API endpoints for logged-in users.

```javascript
// src/pages/Dashboard.tsx

import { useEffect, useState } from 'react';
import sitemapService from '../api/sitemapService';  // Service to get sitemap data

const Dashboard = () => {
  const [data, setData] = useState<any[]>([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const result = await sitemapService.getSitemap();  // Fetch data
        setData(result);
      } catch (error) {
        console.error('Error fetching sitemap data', error);
      }
    };

    fetchData();
  }, []);

  return (
    <div>
      <h2>Dashboard</h2>
      <ul>
        {data.map((item) => (
          <li key={item.id}>{item.pageName}</li>
        ))}
      </ul>
    </div>
  );
};

export default Dashboard;
```

---

## Step 7: Create `sitemapService` for Fetching Protected Data

```javascript
// src/api/sitemapService.ts

const API_URL = 'https://localhost:44337/api/sitemap';

const getSitemap = async () => {
  const token = localStorage.getItem('token');
  
  const response = await fetch(`${API_URL}?userRole=Admin`, {
    method: 'GET',
    headers: {
      'Authorization': `Bearer ${token}`,
      'Accept': 'application/json',
    },
  });

  if (!response.ok) {
    throw new Error('Failed to fetch sitemap');
  }

  return response.json();
};

const sitemapService = { getSitemap };
export default sitemapService;
```

---

## Step 8: Testing the Application

1. Start your backend server (`https://localhost:44337`).
2. Start your React app (`http://localhost:5173`).
3. Visit the login page and authenticate with valid credentials.
4. After login, you should be redirected to the Dashboard.
5. Ensure the token is stored in `localStorage` and used in subsequent API calls.

---

## Conclusion

You now have a React app with full authentication and authorization using JWT. Logged-in users can access protected routes like Dashboard and UserProfile, while unauthenticated users are redirected to the login page.

