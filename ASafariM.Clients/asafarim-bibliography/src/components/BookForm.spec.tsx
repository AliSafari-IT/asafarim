import { render, screen, fireEvent, waitFor } from '@testing-library/react';
import BookForm from '../components/BookForm'; // adjust path if needed
import { vi } from 'vitest';
import { useNavigate } from 'react-router-dom';
import { useAppDispatch } from '../hooks/reduxHooks';

// Mocks
vi.mock('react-router-dom', () => ({
  useNavigate: vi.fn(),
}));
vi.mock('../hooks/reduxHooks', () => ({
  useAppDispatch: vi.fn(),
}));

describe('<BookForm />', () => {
  const mockDispatch = vi.fn();
  const mockNavigate = vi.fn();

  beforeEach(() => {
    (useAppDispatch as any).mockReturnValue(mockDispatch);
    (useNavigate as any).mockReturnValue(mockNavigate);
    mockDispatch.mockClear();
  });

  it('renders form fields correctly', () => {
    render(<BookForm />);

    expect(screen.getByLabelText(/title/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/author/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/year/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/genre/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/i have read this book/i)).toBeInTheDocument();
  });

  it('updates input values on change', () => {
    render(<BookForm />);
    const titleInput = screen.getByLabelText(/title/i);
    fireEvent.change(titleInput, { target: { value: 'Test Book' } });
    expect(titleInput).toHaveValue('Test Book');
  });

  it('submits the form and dispatches addBook', async () => {
    const mockUnwrap = vi.fn().mockResolvedValue({});
    mockDispatch.mockReturnValue({ unwrap: mockUnwrap });

    render(<BookForm />);
    fireEvent.change(screen.getByLabelText(/title/i), { target: { value: 'Test Book' } });
    fireEvent.change(screen.getByLabelText(/author/i), { target: { value: 'Jane Doe' } });
    fireEvent.change(screen.getByLabelText(/year/i), { target: { value: '2023' } });
    fireEvent.change(screen.getByLabelText(/genre/i), { target: { value: 'Fiction' } });

    const submitButtons = screen.getAllByRole('button', { name: /add book/i });
    const submitButton = submitButtons.find(button => 
      button.getAttribute('type') === 'submit' && 
      button.closest('form')
    );
    expect(submitButton).toBeDefined();
    
    if (submitButton) {
      fireEvent.click(submitButton);
    }

    await waitFor(() => {
      expect(mockDispatch).toHaveBeenCalled();
      expect(mockNavigate).toHaveBeenCalledWith('/');
    });
  });

  it('shows error message if addBook fails', async () => {
    const mockUnwrap = vi.fn().mockRejectedValue({ message: 'Failed to add' });
    mockDispatch.mockReturnValue({ unwrap: mockUnwrap });

    render(<BookForm />);
    fireEvent.change(screen.getByLabelText(/title/i), { target: { value: 'Error Book' } });
    fireEvent.change(screen.getByLabelText(/author/i), { target: { value: 'Error Author' } });
    fireEvent.change(screen.getByLabelText(/year/i), { target: { value: '2024' } });
    fireEvent.change(screen.getByLabelText(/genre/i), { target: { value: 'Drama' } });

    const submitButtons = screen.getAllByRole('button', { name: /add book/i });
    const submitButton = submitButtons.find(button => 
      button.getAttribute('type') === 'submit' && 
      button.closest('form')
    );
    expect(submitButton).toBeDefined();
    
    if (submitButton) {
      fireEvent.click(submitButton);
    }

    await screen.findByText(/failed to add/i);
  });

  it('navigates on cancel', () => {
    render(<BookForm />);
    
    const cancelButtons = screen.getAllByRole('button', { name: /cancel/i });
    const cancelButton = cancelButtons.find(button => 
      button.getAttribute('type') === 'button' && 
      button.closest('form')
    );
    expect(cancelButton).toBeDefined();
    
    if (cancelButton) {
      fireEvent.click(cancelButton);
    }
    
    expect(mockNavigate).toHaveBeenCalledWith('/');
  });
});
