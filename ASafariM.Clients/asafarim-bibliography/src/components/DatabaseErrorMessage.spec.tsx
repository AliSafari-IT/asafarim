import { render, screen, fireEvent } from '@testing-library/react';
import DatabaseErrorMessage from './DatabaseErrorMessage';
import { vi } from 'vitest';

describe('<DatabaseErrorMessage />', () => {
  it('renders generic database error message', () => {
    render(<DatabaseErrorMessage error="Something went wrong" />);
    expect(screen.getByText(/database error/i)).toBeInTheDocument();
    expect(screen.getByText(/something went wrong/i)).toBeInTheDocument();
  });

  it('renders missing table error message with extra hints', () => {
    render(<DatabaseErrorMessage error="Table 'Books' doesn't exist" />);
    expect(screen.getByText(/database tables not found/i)).toBeInTheDocument();
    expect(
      screen.getByText(/the required database tables for the bibliography feature/i)
    ).toBeInTheDocument();
    expect(screen.getByText(/table 'books' doesn't exist/i)).toBeInTheDocument();
  });

  it('calls onRetry when retry button is clicked', () => {
    const onRetry = vi.fn();
    render(
      <DatabaseErrorMessage error="Some DB error" onRetry={onRetry} />
    );
    fireEvent.click(screen.getByRole('button', { name: /try again/i }));
    expect(onRetry).toHaveBeenCalled();
  });

  it('does not show button if onRetry is not passed', () => {
    render(<DatabaseErrorMessage error="DB is down" />);
    expect(screen.queryByRole('button')).not.toBeInTheDocument();
  });
});
