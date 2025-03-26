import { useAppDispatch, useAppSelector } from "./reduxHooks";
import { describe, it, expect, vi, beforeEach, afterEach } from "vitest";
import { renderHook, act } from '@testing-library/react-hooks';
import { Provider } from 'react-redux';
import { configureStore, createSlice, PayloadAction } from '@reduxjs/toolkit';
import React from 'react';

// This comment suppresses the React 18 warnings during tests
// @ts-ignore
global.IS_REACT_ACT_ENVIRONMENT = true;

// Define a more comprehensive BookState that matches your actual implementation
interface Book {
  id: string;
  title: string;
  author: string;
}

interface BookState {
  books: Book[];
  selectedBook: Book | null;
  loading: boolean;
  error: string | null;
}

// Create a more realistic initial state
const initialState: BookState = {
  books: [],
  selectedBook: null,
  loading: false,
  error: null
};

// Create a mock slice with more actions to test different scenarios
const bookSlice = createSlice({
  name: 'books',
  initialState,
  reducers: {
    setLoading: (state: BookState) => {
      state.loading = true;
    },
    setError: (state: BookState, action: PayloadAction<string>) => {
      state.error = action.payload;
      state.loading = false;
    },
    addBook: (state: BookState, action: PayloadAction<Book>) => {
      state.books.push(action.payload);
      state.loading = false;
    },
    selectBook: (state: BookState, action: PayloadAction<string>) => {
      state.selectedBook = state.books.find(book => book.id === action.payload) || null;
    },
    clearSelectedBook: (state: BookState) => {
      state.selectedBook = null;
    }
  }
});

// Create a mock store that matches the actual store structure
const createMockStore = () => configureStore({
  reducer: {
    books: bookSlice.reducer
  }
});

// Type for our mock store state
type MockStoreState = ReturnType<ReturnType<typeof createMockStore>['getState']>;

// Extract action creators for easier testing
const { setLoading, setError, addBook, selectBook, clearSelectedBook } = bookSlice.actions;

describe("Redux Hooks", () => {
  // Test useAppDispatch hook
  describe("useAppDispatch", () => {
    let store: ReturnType<typeof createMockStore>;
    
    beforeEach(() => {
      store = createMockStore();
    });
    
    afterEach(() => {
      vi.clearAllMocks();
    });
    
    it("should return a dispatch function", () => {
      const wrapper = ({ children }: { children: React.ReactNode }) => (
        <Provider store={store}>{children}</Provider>
      );
      
      const { result } = renderHook(() => useAppDispatch(), { wrapper });
      
      expect(result.current).toBeDefined();
      expect(typeof result.current).toBe("function");
    });
    
    it("should correctly dispatch actions", () => {
      // Create a spy on the store's dispatch method instead of replacing it
      const dispatchSpy = vi.spyOn(store, 'dispatch');
      
      const wrapper = ({ children }: { children: React.ReactNode }) => (
        <Provider store={store}>{children}</Provider>
      );
      
      const { result } = renderHook(() => useAppDispatch(), { wrapper });
      
      act(() => {
        result.current(setLoading());
      });
      
      expect(dispatchSpy).toHaveBeenCalledTimes(1);
      expect(dispatchSpy).toHaveBeenCalledWith(setLoading());
    });
    
    it("should dispatch actions with payloads", () => {
      // Create a spy on the store's dispatch method
      const dispatchSpy = vi.spyOn(store, 'dispatch');
      
      const wrapper = ({ children }: { children: React.ReactNode }) => (
        <Provider store={store}>{children}</Provider>
      );
      
      const { result } = renderHook(() => useAppDispatch(), { wrapper });
      
      const testBook: Book = { id: '1', title: 'Test Book', author: 'Test Author' };
      
      act(() => {
        result.current(addBook(testBook));
      });
      
      expect(dispatchSpy).toHaveBeenCalledTimes(1);
      expect(dispatchSpy).toHaveBeenCalledWith(addBook(testBook));
    });
  });
  
  // Test useAppSelector hook
  describe("useAppSelector", () => {
    let store: ReturnType<typeof createMockStore>;
    
    beforeEach(() => {
      store = createMockStore();
    });
    
    it("should select loading state from the store", () => {
      const wrapper = ({ children }: { children: React.ReactNode }) => (
        <Provider store={store}>{children}</Provider>
      );
      
      const { result } = renderHook(
        () => useAppSelector((state: MockStoreState) => state.books.loading), 
        { wrapper }
      );
      
      expect(result.current).toBe(false);
      
      // Update the store directly to test if selector updates
      act(() => {
        store.dispatch(setLoading());
      });
      
      expect(result.current).toBe(true);
    });
    
    it("should select books array from the store", () => {
      const wrapper = ({ children }: { children: React.ReactNode }) => (
        <Provider store={store}>{children}</Provider>
      );
      
      const { result } = renderHook(
        () => useAppSelector((state: MockStoreState) => state.books.books), 
        { wrapper }
      );
      
      expect(result.current).toEqual([]);
      
      const testBook: Book = { id: '1', title: 'Test Book', author: 'Test Author' };
      
      // Add a book to the store
      act(() => {
        store.dispatch(addBook(testBook));
      });
      
      expect(result.current).toEqual([testBook]);
    });
    
    it("should select error state from the store", () => {
      const wrapper = ({ children }: { children: React.ReactNode }) => (
        <Provider store={store}>{children}</Provider>
      );
      
      const { result } = renderHook(
        () => useAppSelector((state: MockStoreState) => state.books.error), 
        { wrapper }
      );
      
      expect(result.current).toBeNull();
      
      const errorMessage = "Failed to fetch books";
      
      // Set an error in the store
      act(() => {
        store.dispatch(setError(errorMessage));
      });
      
      expect(result.current).toBe(errorMessage);
    });
    
    it("should select selectedBook from the store", () => {
      const testBook: Book = { id: '1', title: 'Test Book', author: 'Test Author' };
      
      // Add a book first
      store.dispatch(addBook(testBook));
      
      const wrapper = ({ children }: { children: React.ReactNode }) => (
        <Provider store={store}>{children}</Provider>
      );
      
      const { result } = renderHook(
        () => useAppSelector((state: MockStoreState) => state.books.selectedBook), 
        { wrapper }
      );
      
      expect(result.current).toBeNull();
      
      // Select the book
      act(() => {
        store.dispatch(selectBook(testBook.id));
      });
      
      expect(result.current).toEqual(testBook);
      
      // Clear the selection
      act(() => {
        store.dispatch(clearSelectedBook());
      });
      
      expect(result.current).toBeNull();
    });
    
    it("should handle complex selectors with derived data", () => {
      const wrapper = ({ children }: { children: React.ReactNode }) => (
        <Provider store={store}>{children}</Provider>
      );
      
      // Add multiple books
      const books: Book[] = [
        { id: '1', title: 'Book 1', author: 'Author 1' },
        { id: '2', title: 'Book 2', author: 'Author 2' },
        { id: '3', title: 'Book 3', author: 'Author 1' }
      ];
      
      books.forEach((book: Book) => {
        store.dispatch(addBook(book));
      });
      
      // Test a selector that filters and transforms data
      const { result } = renderHook(
        () => useAppSelector((state: MockStoreState) => {
          // Get books by a specific author
          return state.books.books
            .filter((book: Book) => book.author === 'Author 1')
            .map((book: Book) => book.title);
        }),
        { wrapper }
      );
      
      expect(result.current).toEqual(['Book 1', 'Book 3']);
    });
  });
});
