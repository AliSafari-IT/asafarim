import React, { useEffect } from 'react';
import { useAppDispatch, useAppSelector } from '../hooks/reduxHooks';
import { fetchBooks, selectBook } from '../store/slices/bookSlice';
import DatabaseErrorMessage from './DatabaseErrorMessage';

interface BookListProps {
  onSelectBook: (id: string) => void;
}

const BookList: React.FC<BookListProps> = ({ onSelectBook }) => {
  const dispatch = useAppDispatch();
  const { books, loading, error } = useAppSelector(state => state.books);

  useEffect(() => {
    dispatch(fetchBooks());
  }, [dispatch]);

  const handleSelectBook = (id: string) => {
    dispatch(selectBook(id));
    onSelectBook(id);
  };

  const handleRetry = () => {
    dispatch(fetchBooks());
  };

  if (loading) return <div className="p-4 text-center">Loading books...</div>;
  
  // Check for database-related errors
  if (error) {
    const isTableMissingError = error.toLowerCase().includes("table") && 
                               error.toLowerCase().includes("doesn't exist");
    
    if (isTableMissingError || error.toLowerCase().includes("database")) {
      return <DatabaseErrorMessage error={error} onRetry={handleRetry} />;
    }
    
    return (
      <div className="p-4 text-center text-red-500 border border-red-200 rounded-md bg-red-50">
        <p className="font-semibold">Error loading books</p>
        <p className="text-sm mt-2">{error}</p>
        <button 
          onClick={handleRetry}
          className="mt-4 px-4 py-2 bg-red-600 text-white rounded hover:bg-red-700 transition-colors"
        >
          Try Again
        </button>
      </div>
    );
  }

  return (
    <div className="book-list">
      <h2 className="text-2xl font-bold mb-4">My Bibliography</h2>
      {books.length === 0 ? (
        <p className="text-gray-400 text-center py-8">No books in your bibliography yet.</p>
      ) : (
        <ul className="divide-y divide-gray-700">
          {books.map(book => (
            <li 
              key={book.id} 
              onClick={() => handleSelectBook(book.id)}
              className="py-4 px-2 hover:bg-gray-700 cursor-pointer rounded transition-colors"
            >
              <div className="flex justify-between items-start">
                <div>
                  <h3 className="text-lg font-semibold">{book.title}</h3>
                  <p className="text-gray-400">by {book.author} ({book.year})</p>
                  <p className="text-sm text-gray-500">{book.genre}</p>
                </div>
                <span className={`px-2 py-1 text-xs rounded-full ${book.isRead ? 'bg-green-800 text-green-200' : 'bg-yellow-800 text-yellow-200'}`}>
                  {book.isRead ? 'Read' : 'Unread'}
                </span>
              </div>
            </li>
          ))}
        </ul>
      )}
    </div>
  );
};

export default BookList;
