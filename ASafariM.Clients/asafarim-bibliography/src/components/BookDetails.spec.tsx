// tests/BookDetails.test.tsx
import { render, screen } from '@testing-library/react';
import BookDetails from '../components/BookDetails'; // Adjust path as needed
import { useAppSelector } from '../hooks/reduxHooks';
import useFetch from '../hooks/useFetch';
import { vi } from 'vitest';

// Mock redux hook
vi.mock('../hooks/reduxHooks', () => ({
  useAppSelector: vi.fn(),
}));

// Mock custom fetch hook
vi.mock('../hooks/useFetch', () => ({
  __esModule: true,
  default: vi.fn(),
}));

const mockBook = {
  title: 'Mocked Book',
  author: 'John Doe',
  year: 2020,
  genre: 'Fiction',
  isRead: true,
};

describe('<BookDetails />', () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  it('renders fallback when no bookId is provided', () => {
    (useAppSelector as any).mockReturnValue({ selectedBook: null });
    (useFetch as any).mockReturnValue({ data: null, loading: false, error: null });

    render(<BookDetails bookId="" />);
    expect(screen.getByText(/select a book/i)).toBeInTheDocument();
  });

  it('renders loading state', () => {
    (useAppSelector as any).mockReturnValue({ selectedBook: null });
    (useFetch as any).mockReturnValue({ data: null, loading: true, error: null });

    render(<BookDetails bookId="1" />);
    expect(screen.getByText(/loading/i)).toBeInTheDocument();
  });

  it('renders error state', () => {
    (useAppSelector as any).mockReturnValue({ selectedBook: null });
    (useFetch as any).mockReturnValue({ data: null, loading: false, error: { message: 'Failed' } });

    render(<BookDetails bookId="1" />);
    expect(screen.getByText(/error: failed/i)).toBeInTheDocument();
  });

  it('renders BookDetails with fetched data', () => {
    (useAppSelector as any).mockReturnValue({ selectedBook: null });
    (useFetch as any).mockReturnValue({ data: mockBook, loading: false, error: null });

    render(<BookDetails bookId="1" />);
    const bookTitles = screen.getAllByTestId('book-title');
    expect(bookTitles.length).toBeGreaterThan(0);
    expect(bookTitles[0]).toHaveTextContent('Mocked Book');
    expect(screen.getByText('John Doe')).toBeInTheDocument();
    expect(screen.getByText('2020')).toBeInTheDocument();
    expect(screen.getByText('Fiction')).toBeInTheDocument();
    expect(screen.getByText('Read')).toBeInTheDocument();
  });

  it('falls back to Redux store when fetch has no data', () => {
    (useAppSelector as any).mockReturnValue({ selectedBook: mockBook });
    (useFetch as any).mockReturnValue({ data: null, loading: false, error: null });

    render(<BookDetails bookId="1" />);
    const bookTitles = screen.getAllByTestId('book-title');
    expect(bookTitles.length).toBeGreaterThan(0);
    expect(bookTitles[0]).toHaveTextContent('Mocked Book');
  });
});
