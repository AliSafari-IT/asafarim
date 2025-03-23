---
sidebar_position: 1 
---

# Handle Data from API

## XMLHttpRequest &amp; Ajax
`XMLHttpRequest` (XHR) objects are meant to interact with servers by retrieving data from a URL without refreshing the page. This is good when only part of the page needs to be updated. XMLHttpRequest has been used in `AJAX` programming.


## Fetch API
Fetch API is Promise based, resulting a more concise syntax compared to the ajax method.  
A basic fetch request is really simple to set up. Have a look at the following code:
```javascript title="Fetch basic request"
fetch('http://localhost:5000/api/books')
  .then(response => response.json())
  .then(data => console.log(data));

```

:::danger Note

By default, `fetch()` will not send or receive any ***cookies*** from the server, resulting in <u>unauthenticated</u> requests.

:::

### Supplying request options
The *fetch()* method can optionally accept a second parameter, an `init` object that allows you to control a number of different settings:

``` javascript title="An example of POST method implementation for adding a book"
async function addBook(url = 'http://localhost:5000/api/books', bookData = {}) {
  // Default options are marked with *
  const response = await fetch(url, {
    method: 'POST', // *GET, POST, PUT, DELETE, etc.
    mode: 'cors', // no-cors, *cors, same-origin
    cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
    credentials: 'same-origin', // include, *same-origin, omit
    headers: {
      'Content-Type': 'application/json'
      // 'Content-Type': 'application/x-www-form-urlencoded',
    },
    redirect: 'follow', // manual, *follow, error
    referrerPolicy: 'no-referrer', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
    body: JSON.stringify(bookData) // body data type must match "Content-Type" header
  });
  return response.json(); // parses JSON response into native JavaScript objects
}

addBook('http://localhost:5000/api/books', { 
  title: 'Clean Code',
  author: 'Robert C. Martin',
  year: 2008,
  genre: 'Programming',
  isRead: true,
  createdBy: 'Frontend User',
  isActive: true
})
  .then(data => {
    console.log(data); // JSON data parsed by `data.json()` call
  });

```

## Real-world Example: ASafariM Bibliography

For a real-world implementation, check out our [Bibliography application](https://bibliography.asafarim.com) which uses Redux Toolkit with TypeScript to manage API calls. The application demonstrates:

1. Handling loading states
2. Error management
3. Data transformation
4. Retry mechanisms

In our Bibliography application, we use a combination of Fetch API, Axios, and Redux Toolkit to handle data fetching and state management. You can see how we implement these patterns by exploring the [live application](https://bibliography.asafarim.com).

For example, our book listing page uses Redux Toolkit's `createAsyncThunk` to fetch data from the API:

```typescript title="Example from Bibliography App"
// Simplified version of our actual implementation
export const fetchBooks = createAsyncThunk(
  'books/fetchBooks',
  async (_, { rejectWithValue }) => {
    try {
      const response = await fetch('/api/books');
      
      if (!response.ok) {
        throw new Error(`HTTP error! Status: ${response.status}`);
      }
      
      const data = await response.json();
      return data.$values || data; // Handle API response format
    } catch (error) {
      return rejectWithValue(error.message);
    }
  }
);
```

You can find detailed documentation about the Redux implementation in our [Redux Basics guide](/docs/React/Redux/Redux-Basic-Example), the custom `useFetch` hook in our [useFetch guide](/docs/React/Hooks/useFetch), and Axios integration in our [React Axios guide](/docs/React/Axios/react-axios).