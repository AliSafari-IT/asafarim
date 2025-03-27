import { render, screen, fireEvent } from '@testing-library/react';
import { vi } from 'vitest';
import BookList from '../components/BookList';
import { useAppDispatch, useAppSelector } from '../hooks/reduxHooks';
import { fetchBooks, selectBook } from '../store/slices/bookSlice';

// Mocks
vi.mock('../hooks/reduxHooks', () => ({
  useAppDispatch: vi.fn(),
  useAppSelector: vi.fn(),
}));
vi.mock('../store/slices/bookSlice', () => ({
  fetchBooks: vi.fn(),
  selectBook: vi.fn(),
}));

describe('<BookList />', () => {
  const mockDispatch = vi.fn();

  const defaultState = {
    books: [],
    loading: false,
    error: null,
  };

  beforeEach(() => {
    vi.clearAllMocks();
    (useAppDispatch as any).mockReturnValue(mockDispatch);
  });

  it('displays loading message', () => {
    (useAppSelector as any).mockReturnValue({ ...defaultState, loading: true });

    render(<BookList onSelectBook={() => {}} />);
    expect(screen.getByText(/loading books/i)).toBeInTheDocument();
  });

  it('displays general error and retry button', () => {
    const errorMsg = 'Something went wrong';
    (useAppSelector as any).mockReturnValue({ ...defaultState, error: errorMsg });

    render(<BookList onSelectBook={() => {}} />);
    expect(screen.getByText(/error loading books/i)).toBeInTheDocument();
    expect(screen.getByText(errorMsg)).toBeInTheDocument();

    fireEvent.click(screen.getByText(/try again/i));
    expect(mockDispatch).toHaveBeenCalledWith(fetchBooks());
  });

  it('renders <DatabaseErrorMessage /> for DB-related errors', () => {
    (useAppSelector as any).mockReturnValue({
      ...defaultState,
      error: "table 'Books' doesn't exist",
    });

    render(<BookList onSelectBook={() => {}} />);
    expect(screen.getByText(/try again/i)).toBeInTheDocument();
    expect(mockDispatch).not.toHaveBeenCalledWith(selectBook);
  });

  it('renders empty list message', () => {
    (useAppSelector as any).mockReturnValue({ ...defaultState, books: [] });

    render(<BookList onSelectBook={() => {}} />);
    expect(screen.getByText(/no books in your bibliography/i)).toBeInTheDocument();
  });

  it('renders list of books and handles click', () => {
    const books = [
      {
        id: '1',
        title: 'Test Book',
        author: 'Ali Safari',
        year: 2024,
        genre: 'Education',
        isRead: true,
      },
    ];

    const onSelectBook = vi.fn();
    (useAppSelector as any).mockReturnValue({ ...defaultState, books });

    render(<BookList onSelectBook={onSelectBook} />);
    expect(screen.getByText('Test Book')).toBeInTheDocument();

    fireEvent.click(screen.getByText('Test Book'));

    expect(mockDispatch).toHaveBeenCalledWith(selectBook('1'));
    expect(onSelectBook).toHaveBeenCalledWith('1');
  });
});
