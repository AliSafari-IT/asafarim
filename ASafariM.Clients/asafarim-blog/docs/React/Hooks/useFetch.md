---
sidebar_position: 1 
---

# useFetch()

The `useFetch` hook is a custom React hook that simplifies data fetching in functional components. It handles loading states, errors, and provides a clean interface for making HTTP requests. This hook is used in our [ASafariM Bibliography application](https://bibliography.asafarim.com) to handle API requests for book data.

## Basic Implementation

Here's a TypeScript implementation of the `useFetch` hook that can be used in our ASafariM Bibliography project:

```typescript
import { useState, useEffect, useCallback, useRef } from 'react';

interface UseFetchState<T> {
  data: T | null;
  loading: boolean;
  error: Error | null;
}

interface UseFetchOptions {
  headers?: HeadersInit;
  method?: 'GET' | 'POST' | 'PUT' | 'DELETE' | 'PATCH';
  body?: any;
  credentials?: RequestCredentials;
  cache?: RequestCache;
  mode?: RequestMode;
  immediate?: boolean;
}

function useFetch<T = any>(url: string, options: UseFetchOptions = {}) {
  const [state, setState] = useState<UseFetchState<T>>({
    data: null,
    loading: options.immediate !== false,
    error: null,
  });

  const [fetchCount, setFetchCount] = useState(0);

  const controllerRef = useRef<AbortController | null>(null);

  const fetchData = useCallback(async (fetchOptions: UseFetchOptions = {}) => {
    // Abort any in-flight requests
    if (controllerRef.current) {
      controllerRef.current.abort();
    }

    // Create a new AbortController instance
    const controller = new AbortController();
    controllerRef.current = controller;
    const signal = controller.signal;
    
    // Combine the original options with any new options
    const combinedOptions = { ...options, ...fetchOptions };
    
    // Don't fetch if URL is empty
    if (!url) return;

    setState(prev => ({ ...prev, loading: true, error: null }));

    try {
      // Prepare the request options
      const requestOptions: RequestInit = {
        method: combinedOptions.method || 'GET',
        headers: combinedOptions.headers || {
          'Content-Type': 'application/json',
        },
        credentials: combinedOptions.credentials,
        cache: combinedOptions.cache,
        mode: combinedOptions.mode,
        signal // Add the signal to the fetch options
      };

      // Add body for non-GET requests
      if (combinedOptions.body && requestOptions.method !== 'GET') {
        requestOptions.body = 
          typeof combinedOptions.body === 'string' 
            ? combinedOptions.body 
            : JSON.stringify(combinedOptions.body);
      }

      const response = await fetch(url, requestOptions);

      // Handle non-2xx responses
      if (!response.ok) {
        throw new Error(`HTTP error! Status: ${response.status}`);
      }

      // Parse the response based on content type
      const contentType = response.headers.get('content-type');
      let data: T;

      if (contentType && contentType.includes('application/json')) {
        data = await response.json();
      } else if (contentType && contentType.includes('text/')) {
        data = await response.text() as unknown as T;
      } else {
        data = await response.blob() as unknown as T;
      }

      setState({
        data,
        loading: false,
        error: null,
      });

      return { data, response };
    } catch (error) {
      setState({
        data: null,
        loading: false,
        error: error instanceof Error ? error : new Error(String(error)),
      });

      return { error };
    }
  }, [url, options]);

  // Trigger fetch on mount or when dependencies change
  useEffect(() => {
    if (options.immediate !== false) {
      fetchData();
    }
  }, [url, fetchCount]);

  // Function to manually trigger a fetch
  const refetch = useCallback((fetchOptions: UseFetchOptions = {}) => {
    setFetchCount(count => count + 1);
    return fetchData(fetchOptions);
  }, [fetchData]);

  // Clean up function to abort any in-flight requests when the component unmounts
  useEffect(() => {
    return () => {
      if (controllerRef.current) {
        controllerRef.current.abort();
      }
    };
  }, []);

  return {
    ...state,
    refetch,
  };
}

export default useFetch;
```

## Usage with Redux

The `useFetch` hook can be used alongside Redux in our ASafariM Bibliography project. Here's how they can work together:

### 1. Direct Usage in Components

```tsx
import React from 'react';
import useFetch from '../hooks/useFetch';
import { Book } from '../types/Book';

const BookSearch: React.FC = () => {
  const { data, loading, error, refetch } = useFetch<Book[]>('/api/books');

  if (loading) return <div>Loading books...</div>;
  if (error) return <div>Error: {error.message}</div>;

  return (
    <div>
      <h2>Book Search Results</h2>
      <button onClick={() => refetch()}>Refresh</button>
      {data && data.map(book => (
        <div key={book.id}>
          <h3>{book.title}</h3>
          <p>By {book.author}, {book.year}</p>
        </div>
      ))}
    </div>
  );
};
```

### 2. Integration with Redux Thunks

```typescript
// src/store/slices/bookSlice.ts
import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import useFetch from '../../hooks/useFetch';

// Custom fetch function using our hook logic
const fetchWithHook = async (url: string, options = {}) => {
  // Extract the fetch logic from our hook
  try {
    const response = await fetch(url, options);
    if (!response.ok) throw new Error(`HTTP error! Status: ${response.status}`);
    return await response.json();
  } catch (error) {
    throw error;
  }
};

export const fetchBooks = createAsyncThunk(
  'books/fetchBooks',
  async (_, { rejectWithValue }) => {
    try {
      return await fetchWithHook('/api/books');
    } catch (error) {
      return rejectWithValue(error.message);
    }
  }
);
```

## Advanced Features

### 1. Request Cancellation

We can enhance our `useFetch` hook to support request cancellation using AbortController, which is particularly useful in our Bibliography app when users navigate between pages quickly:

```typescript
function useFetch<T = any>(url: string, options: UseFetchOptions = {}) {
  // ... existing code
  const controllerRef = useRef<AbortController | null>(null);

  const fetchData = useCallback(async (fetchOptions: UseFetchOptions = {}) => {
    // Abort any in-flight requests
    if (controllerRef.current) {
      controllerRef.current.abort();
    }

    // Create a new AbortController instance
    const controller = new AbortController();
    controllerRef.current = controller;
    const signal = controller.signal;
    
    // Combine options
    const combinedOptions = { 
      ...options, 
      ...fetchOptions,
      signal // Add the signal to the fetch options
    };
    
    // ... rest of the fetch logic

    // Return the controller so it can be used to abort the request
    return { data, response, controller };
  }, [url, options]);

  // Clean up function to abort any in-flight requests when the component unmounts
  useEffect(() => {
    return () => {
      if (controllerRef.current) {
        controllerRef.current.abort();
      }
    };
  }, []);

  // ... rest of the hook
}
```

### 2. Caching

In our Bibliography app, we implement caching to reduce API calls when viewing the same book multiple times:

```typescript
// A simple cache outside the hook
const cache = new Map<string, { data: any; timestamp: number }>();

function useFetch<T = any>(url: string, options: UseFetchOptions = {}) {
  // ... existing code

  const fetchData = useCallback(async (fetchOptions: UseFetchOptions = {}) => {
    // Combine options first
    const combinedOptions = { ...options, ...fetchOptions };
    
    // Check cache if caching is enabled
    if (combinedOptions.cache === 'force-cache' || combinedOptions.cache === 'default') {
      const cacheKey = `${url}-${JSON.stringify(combinedOptions)}`;
      const cachedData = cache.get(cacheKey);
      
      // Use cached data if it exists and is not expired (e.g., 5 minutes)
      if (cachedData && Date.now() - cachedData.timestamp < 5 * 60 * 1000) {
        setState({
          data: cachedData.data,
          loading: false,
          error: null
        });
        return { data: cachedData.data };
      }
    }
    
    // ... fetch logic
    
    // Store in cache if successful
    if (data) {
      const cacheKey = `${url}-${JSON.stringify(combinedOptions)}`;
      cache.set(cacheKey, { data, timestamp: Date.now() });
    }
  }, [url, options]);

  // ... rest of the hook
}
```

## Real-world Example: ASafariM Bibliography

Our [ASafariM Bibliography application](https://bibliography.asafarim.com) demonstrates how the `useFetch` hook works in a production environment. The application showcases:

1. **Efficient Data Fetching**: Using the hook to load book data with minimal code
2. **Loading States**: Displaying loading indicators while data is being fetched
3. **Error Handling**: Gracefully handling API errors with user-friendly messages
4. **TypeScript Integration**: Full type safety with generics for request and response data

When you visit the Bibliography app, you can see these patterns in action as you browse and interact with the book collection.

## Integration with the Bibliography Project

In our ASafariM Bibliography project at [bibliography.asafarim.com](https://bibliography.asafarim.com), we use the `useFetch` hook in multiple ways:

### 1. Fetching Book Details

```tsx
// src/components/BookDetails.tsx
import React from 'react';
import useFetch from '../hooks/useFetch';
import { Book } from '../types/Book';

interface BookDetailsProps {
  bookId: string;
}

const BookDetails: React.FC<BookDetailsProps> = ({ bookId }) => {
  const { data: book, loading, error } = useFetch<Book>(
    `/api/books/${bookId}`,
    { immediate: !!bookId }
  );

  if (!bookId) return <div>Select a book to view details</div>;
  if (loading) return <div>Loading book details...</div>;
  if (error) return <div>Error: {error.message}</div>;
  if (!book) return <div>Book not found</div>;

  return (
    <div className="book-details">
      <h2>{book.title}</h2>
      <p><strong>Author:</strong> {book.author}</p>
      <p><strong>Year:</strong> {book.year}</p>
      <p><strong>Genre:</strong> {book.genre}</p>
      <p><strong>Status:</strong> {book.isRead ? 'Read' : 'Unread'}</p>
    </div>
  );
};
```

### 2. Creating a New Book

```tsx
// src/components/BookForm.tsx
import React, { useState } from 'react';
import useFetch from '../hooks/useFetch';
import { BookFormData } from '../types/Book';

const initialFormData: BookFormData = {
  title: '',
  author: '',
  year: new Date().getFullYear(),
  genre: '',
  isRead: false
};

const BookForm: React.FC = () => {
  const [formData, setFormData] = useState<BookFormData>(initialFormData);
  const { loading, error, refetch } = useFetch<any>('/api/books', {
    method: 'POST',
    immediate: false
  });

  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>) => {
    const { name, value, type } = e.target;
    setFormData(prev => ({
      ...prev,
      [name]: type === 'checkbox' 
        ? (e.target as HTMLInputElement).checked 
        : name === 'year' ? parseInt(value, 10) : value
    }));
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    await refetch({ body: formData });
    setFormData(initialFormData);
  };

  return (
    <form onSubmit={handleSubmit}>
      <h2>Add New Book</h2>
      {error && <div className="error">Error: {error.message}</div>}
      
      <div>
        <label htmlFor="title">Title:</label>
        <input
          type="text"
          id="title"
          name="title"
          value={formData.title}
          onChange={handleChange}
          required
        />
      </div>
      
      {/* Other form fields */}
      
      <button type="submit" disabled={loading}>
        {loading ? 'Adding...' : 'Add Book'}
      </button>
    </form>
  );
};
```

## Conclusion

The `useFetch` hook provides a clean, reusable way to handle API requests in React applications. When used alongside Redux:

1. **Local Component State**: Use `useFetch` for component-specific data needs
2. **Global Application State**: Use Redux for state that needs to be shared across components
3. **Optimized Performance**: The hook includes features like caching and request cancellation
4. **TypeScript Integration**: Full type safety with generics for request and response data

This approach gives you flexibility in your ASafariM Bibliography project, allowing you to choose the right tool for each specific data fetching need.

For more information on related topics, check out:
- [Axios Integration](/docs/React/Axios/axios)
- [React with Axios](/docs/React/Axios/react-axios)
- [Handling API Data](/docs/React/Basics/handle-data-from-api)
- [Redux Basics](/docs/React/Redux/Redux-Basic-Example)
