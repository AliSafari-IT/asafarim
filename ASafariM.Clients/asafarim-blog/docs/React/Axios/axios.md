---
sidebar_position: 1 
title: "Axios"
---

# Axios: A Comprehensive Guide

## What is Axios?
Axios is a promise-based HTTP client for JavaScript that works in both browser and Node.js environments. It provides a simple and elegant API for making HTTP requests, handling responses, and managing errors. Axios has become the go-to solution for many developers due to its rich feature set and ease of use.

## Key Features

- **Promise-based API**: Works seamlessly with async/await for cleaner code
- **Request and response interceptors**: Modify requests or responses before they're handled
- **Automatic JSON data transformation**: Automatically transforms request and response data
- **Client-side protection against XSRF**: Built-in security features
- **Request cancellation**: Ability to cancel requests when needed
- **Timeout configuration**: Set timeouts for requests
- **Concurrent requests**: Make multiple requests simultaneously

## Basic Usage

### Installation

```bash
# Using npm
npm install axios

# Using yarn
yarn add axios
```

### Making Requests

```jsx
import axios from 'axios';

// GET request
axios.get('https://api.example.com/data')
  .then(response => {
    console.log(response.data);
  })
  .catch(error => {
    console.error('Error fetching data:', error);
  });

// Using async/await
async function fetchData() {
  try {
    const response = await axios.get('https://api.example.com/data');
    console.log(response.data);
    return response.data;
  } catch (error) {
    console.error('Error fetching data:', error);
    throw error;
  }
}
```

### Request Methods

Axios supports all standard HTTP methods:

```jsx
// POST request
axios.post('https://api.example.com/data', {
  name: 'John Doe',
  email: 'john@example.com'
});

// PUT request
axios.put('https://api.example.com/data/1', {
  name: 'Updated Name'
});

// DELETE request
axios.delete('https://api.example.com/data/1');

// PATCH request
axios.patch('https://api.example.com/data/1', {
  name: 'Partially Updated Name'
});
```

## Advanced Usage

### Creating an Axios Instance

You can create a custom instance with specific configuration:

```jsx
const api = axios.create({
  baseURL: 'https://api.example.com',
  timeout: 5000,
  headers: {
    'Content-Type': 'application/json',
    'Accept': 'application/json'
  }
});

// Now use the instance
api.get('/users')
  .then(response => console.log(response.data));
```

### Interceptors

Interceptors allow you to intercept requests or responses before they are handled:

```jsx
// Request interceptor
axios.interceptors.request.use(
  config => {
    // Add authorization token to headers
    const token = localStorage.getItem('token');
    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  error => {
    return Promise.reject(error);
  }
);

// Response interceptor
axios.interceptors.response.use(
  response => {
    // Do something with response data
    return response;
  },
  error => {
    // Handle error responses
    if (error.response && error.response.status === 401) {
      // Redirect to login page or refresh token
    }
    return Promise.reject(error);
  }
);
```

## Axios Plugins and Extensions

Axios plugins are pieces of code that extend Axios functionality by adding new features or modifying existing ones. They can add request/response interceptors, global settings, custom headers, and more.

### Creating an Axios Plugin

Here's an example of creating a plugin that adds authentication headers to all requests:

```jsx
// authPlugin.js
export default {
  install(app, options) {
    // Create axios instance
    const api = axios.create({
      baseURL: options.baseURL || 'https://api.example.com'
    });
    
    // Add request interceptor
    api.interceptors.request.use(config => {
      const token = localStorage.getItem('token');
      if (token) {
        config.headers.Authorization = `Bearer ${token}`;
      }
      return config;
    });
    
    // Make the instance available in the app
    app.config.globalProperties.$api = api;
  }
};

// In your main.js
import authPlugin from './plugins/authPlugin';
app.use(authPlugin, { baseURL: 'https://api.myservice.com' });
```

### Using with Vue.js

```jsx
// plugin.js
import axios from 'axios';

export default {
  install(Vue) {
    // Create an axios instance
    const api = axios.create({
      baseURL: process.env.VUE_APP_API_URL,
      timeout: 10000
    });
    
    // Add to Vue prototype for global access
    Vue.prototype.$api = api;
    
    // Add default headers
    api.defaults.headers.common['Authorization'] = 'Bearer ' + localStorage.getItem('token');
    api.defaults.headers.common['Content-Type'] = 'application/json';
  }
};

// In your main.js
import ApiPlugin from './plugins/api';
Vue.use(ApiPlugin);
```

### Using with React

In React, you typically wouldn't create a plugin in the same way as Vue, but you can create a custom hook:

```jsx
// useAxios.js
import { useState, useEffect } from 'react';
import axios from 'axios';

// Create a configured instance
const api = axios.create({
  baseURL: process.env.REACT_APP_API_URL,
  timeout: 10000,
  headers: {
    'Content-Type': 'application/json'
  }
});

// Add request interceptor
api.interceptors.request.use(config => {
  const token = localStorage.getItem('token');
  if (token) {
    config.headers.Authorization = `Bearer ${token}`;
  }
  return config;
});

// Custom hook for data fetching
export function useAxios(url, options = {}) {
  const [data, setData] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        setLoading(true);
        const response = await api(url, options);
        setData(response.data);
      } catch (err) {
        setError(err);
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, [url, options.method, options.data]);

  return { data, loading, error };
}

// Export the configured axios instance
export default api;
```

## Error Handling

Axios provides comprehensive error handling:

```jsx
axios.get('/user/12345')
  .catch(error => {
    if (error.response) {
      // The request was made and the server responded with a status code
      // that falls out of the range of 2xx
      console.log(error.response.data);
      console.log(error.response.status);
      console.log(error.response.headers);
    } else if (error.request) {
      // The request was made but no response was received
      console.log(error.request);
    } else {
      // Something happened in setting up the request that triggered an Error
      console.log('Error', error.message);
    }
    console.log(error.config);
  });
```

## Cancellation

Axios supports request cancellation using AbortController:

```jsx
// Modern approach (axios v0.22.0+)
const controller = new AbortController();

axios.get('/api/data', {
  signal: controller.signal
}).catch(error => {
  if (axios.isCancel(error)) {
    console.log('Request canceled:', error.message);
  } else {
    // handle error
  }
});

// Cancel the request
controller.abort();
```

## Conclusion

Axios is a powerful and flexible HTTP client that simplifies making API requests in JavaScript applications. Its rich feature set, including interceptors, request cancellation, and automatic transforms, makes it an excellent choice for handling HTTP communication in modern web applications.

For more information, check out the [official Axios documentation](https://axios-http.com/docs/intro).

You can also explore our other guides on API integration:
- [Handling API Data in React](/docs/React/Basics/handle-data-from-api)
- [Custom Hooks for API Calls](/docs/React/Hooks/useFetch)
- [Redux with API Integration](/docs/React/Redux/Redux-Basic-Example)