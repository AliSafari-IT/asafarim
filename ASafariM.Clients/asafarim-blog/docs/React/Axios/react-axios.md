---
sidebar_position: 2
title: "React with Axios"
---

# Using Axios in React Applications

This guide demonstrates how to effectively integrate Axios with React applications, using our [ASafariM Bibliography](https://bibliography.asafarim.com) app as a practical example.

## Setting Up Axios in React

### Installation

First, install Axios in your React project:

```bash
# Using npm
npm install axios

# Using yarn
yarn add axios
```

### Basic Configuration

Create a centralized Axios instance with custom configuration:

```jsx
// src/api/axios.js
import axios from 'axios';

// Create a custom instance
const api = axios.create({
  baseURL: process.env.REACT_APP_API_URL || 'https://api.example.com',
  timeout: 10000,
  headers: {
    'Content-Type': 'application/json',
    'Accept': 'application/json'
  }
});

export default api;
```

## React Hooks with Axios

### Custom Hook for API Calls

Create a reusable hook for making API requests:

```jsx
// src/hooks/useAxios.js
import { useState, useEffect } from 'react';
import api from '../api/axios';

function useAxios(url, options = {}) {
  const [data, setData] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const [refetchIndex, setRefetchIndex] = useState(0);

  useEffect(() => {
    const fetchData = async () => {
      try {
        setLoading(true);
        const response = await api(url, options);
        setData(response.data);
        setError(null);
      } catch (err) {
        setError(err.response?.data?.message || err.message);
        setData(null);
      } finally {
        setLoading(false);
      }
    };

    if (options.skip !== true) {
      fetchData();
    }
    
    return () => {
      // Cleanup if needed
    };
  }, [url, refetchIndex, options.skip]);

  // Function to manually trigger a refetch
  const refetch = () => setRefetchIndex(prev => prev + 1);

  return { data, loading, error, refetch };
}

export default useAxios;
```

### Using the Hook in Components

```jsx
// src/components/BookList.jsx
import React from 'react';
import useAxios from '../hooks/useAxios';

function BookList() {
  const { data, loading, error, refetch } = useAxios('/books');

  if (loading) return <div>Loading books...</div>;
  if (error) return <div>Error: {error}</div>;

  return (
    <div>
      <h2>My Bibliography</h2>
      <button onClick={refetch}>Refresh</button>
      <ul>
        {data?.map(book => (
          <li key={book.id}>
            <strong>{book.title}</strong> by {book.author}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default BookList;
```

## Real-world Example: ASafariM Bibliography

In our [Bibliography application](https://bibliography.asafarim.com), we use Axios with React to manage book data. Here's how we implement key features:

### API Service Layer

```jsx
// src/services/bookService.js
import api from '../api/axios';

export const BookService = {
  getAll: async () => {
    const response = await api.get('/books');
    return response.data;
  },
  
  getById: async (id) => {
    const response = await api.get(`/books/${id}`);
    return response.data;
  },
  
  create: async (bookData) => {
    const response = await api.post('/books', bookData);
    return response.data;
  },
  
  update: async (id, bookData) => {
    const response = await api.put(`/books/${id}`, bookData);
    return response.data;
  },
  
  delete: async (id) => {
    await api.delete(`/books/${id}`);
  }
};
```

### Handling Authentication

```jsx
// src/api/axios.js
import axios from 'axios';

const api = axios.create({
  baseURL: process.env.REACT_APP_API_URL,
  timeout: 10000
});

// Request interceptor for adding auth token
api.interceptors.request.use(
  config => {
    const token = localStorage.getItem('token');
    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  error => Promise.reject(error)
);

// Response interceptor for handling token expiration
api.interceptors.response.use(
  response => response,
  error => {
    if (error.response?.status === 401) {
      // Token expired, redirect to login
      localStorage.removeItem('token');
      window.location.href = '/login';
    }
    return Promise.reject(error);
  }
);

export default api;
```

## Advanced Patterns

### Cancelling Requests

```jsx
function BookSearch() {
  const [query, setQuery] = useState('');
  const [results, setResults] = useState([]);
  
  useEffect(() => {
    // Create a cancel token
    const cancelToken = axios.CancelToken.source();
    
    const searchBooks = async () => {
      try {
        const response = await api.get('/books/search', {
          params: { q: query },
          cancelToken: cancelToken.token
        });
        setResults(response.data);
      } catch (error) {
        if (!axios.isCancel(error)) {
          console.error('Search error:', error);
        }
      }
    };
    
    if (query) searchBooks();
    
    // Cleanup function to cancel request when component unmounts or query changes
    return () => cancelToken.cancel('Request cancelled');
  }, [query]);
  
  // Component JSX
}
```

### Error Handling with React Error Boundaries

```jsx
// src/components/ErrorBoundary.jsx
import React from 'react';

class ErrorBoundary extends React.Component {
  constructor(props) {
    super(props);
    this.state = { hasError: false, error: null };
  }

  static getDerivedStateFromError(error) {
    return { hasError: true, error };
  }

  componentDidCatch(error, errorInfo) {
    console.error('API Error:', error, errorInfo);
    // You could also log to an error reporting service
  }

  render() {
    if (this.state.hasError) {
      return this.props.fallback || <h2>Something went wrong with the API request.</h2>;
    }

    return this.props.children;
  }
}

// Usage
<ErrorBoundary fallback={<BookListErrorDisplay />}>
  <BookList />
</ErrorBoundary>
```

### Combining with React Query

For more advanced data fetching capabilities, you can combine Axios with React Query:

```jsx
// src/hooks/useBooks.js
import { useQuery, useMutation, useQueryClient } from 'react-query';
import { BookService } from '../services/bookService';

export function useBooks() {
  const queryClient = useQueryClient();
  
  const booksQuery = useQuery('books', BookService.getAll);
  
  const addBookMutation = useMutation(BookService.create, {
    onSuccess: () => {
      queryClient.invalidateQueries('books');
    }
  });
  
  const updateBookMutation = useMutation(
    ({ id, data }) => BookService.update(id, data),
    {
      onSuccess: () => {
        queryClient.invalidateQueries('books');
      }
    }
  );
  
  const deleteBookMutation = useMutation(BookService.delete, {
    onSuccess: () => {
      queryClient.invalidateQueries('books');
    }
  });
  
  return {
    books: booksQuery.data || [],
    isLoading: booksQuery.isLoading,
    error: booksQuery.error,
    addBook: addBookMutation.mutate,
    updateBook: updateBookMutation.mutate,
    deleteBook: deleteBookMutation.mutate
  };
}

// Usage in component
function BookManager() {
  const { books, isLoading, error, addBook, updateBook, deleteBook } = useBooks();
  
  // Component logic and JSX
}
```

## Performance Optimization

### Request Caching

```jsx
// Simple in-memory cache
const cache = new Map();

async function fetchWithCache(url, options = {}) {
  const cacheKey = `${url}-${JSON.stringify(options)}`;
  
  // Check if we have a cached response and it's not expired
  const cachedResponse = cache.get(cacheKey);
  if (cachedResponse && Date.now() < cachedResponse.expiry) {
    return cachedResponse.data;
  }
  
  // If not cached or expired, make the request
  const response = await api.get(url, options);
  
  // Cache the new response for 5 minutes
  cache.set(cacheKey, {
    data: response.data,
    expiry: Date.now() + 5 * 60 * 1000
  });
  
  return response.data;
}
```

### Debouncing Requests

```jsx
import { useState, useEffect, useCallback } from 'react';
import debounce from 'lodash/debounce';
import api from '../api/axios';

function SearchComponent() {
  const [query, setQuery] = useState('');
  const [results, setResults] = useState([]);
  
  // Create a debounced search function
  const debouncedSearch = useCallback(
    debounce(async (searchTerm) => {
      if (searchTerm.trim() === '') return;
      
      try {
        const response = await api.get('/search', { params: { q: searchTerm } });
        setResults(response.data);
      } catch (error) {
        console.error('Search failed:', error);
      }
    }, 500),
    []
  );
  
  useEffect(() => {
    debouncedSearch(query);
    
    // Cleanup
    return () => {
      debouncedSearch.cancel();
    };
  }, [query, debouncedSearch]);
  
  return (
    <div>
      <input 
        type="text" 
        value={query} 
        onChange={(e) => setQuery(e.target.value)} 
        placeholder="Search books..." 
      />
      <ul>
        {results.map(item => (
          <li key={item.id}>{item.title}</li>
        ))}
      </ul>
    </div>
  );
}
```

## Testing Axios in React

### Mocking Axios for Tests

```jsx
// __tests__/BookList.test.jsx
import React from 'react';
import { render, screen, waitFor } from '@testing-library/react';
import axios from 'axios';
import BookList from '../components/BookList';

// Mock axios
jest.mock('axios');

describe('BookList Component', () => {
  test('fetches and displays books', async () => {
    // Mock data
    const books = [
      { id: 1, title: 'React Testing', author: 'Test Author' },
      { id: 2, title: 'Advanced Axios', author: 'API Expert' }
    ];
    
    // Mock the axios get method
    axios.get.mockResolvedValueOnce({ data: books });
    
    // Render component
    render(<BookList />);
    
    // Verify loading state
    expect(screen.getByText(/loading/i)).toBeInTheDocument();
    
    // Wait for books to be displayed
    await waitFor(() => {
      expect(screen.getByText('React Testing')).toBeInTheDocument();
      expect(screen.getByText('Advanced Axios')).toBeInTheDocument();
    });
    
    // Verify axios was called correctly
    expect(axios.get).toHaveBeenCalledWith('/books');
  });
});
```

## Conclusion

Axios provides a powerful and flexible way to handle HTTP requests in React applications. By creating custom hooks, service layers, and implementing advanced patterns like request cancellation and caching, you can build robust and maintainable React applications that efficiently communicate with APIs.

For a real-world implementation, explore our [ASafariM Bibliography application](https://bibliography.asafarim.com), which demonstrates these patterns in a production environment.

For more information on related topics, check out:
- [Axios Basics](/docs/React/Axios/axios)
- [Handling API Data in React](/docs/React/Basics/handle-data-from-api)
- [Redux with API Integration](/docs/React/Redux/Redux-Basic-Example)
- [Custom Hooks for API Calls](/docs/React/Hooks/useFetch)
