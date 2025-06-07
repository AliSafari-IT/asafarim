import { render, screen, fireEvent } from '@testing-library/react';
import { describe, it, expect, vi } from 'vitest';
import { expect as extendedExpect } from '@/test-utils/setup-test-env';
import DropdownButton from '../DropdownButton';

// Mock FontAwesomeIcon to avoid issues with SVG rendering in tests
vi.mock('@fortawesome/react-fontawesome', () => ({
  FontAwesomeIcon: ({ className }: { className: string }) => (
    <span data-testid="icon" className={className}></span>
  )
}));

describe('DropdownButton', () => {
  it('renders with the correct title', () => {
    const title = 'Test Dropdown';
    render(
      <DropdownButton
        title={title}
        isOpen={false}
        onClick={vi.fn()}
      />
    );
    
    const buttonElement = screen.getByRole('button', { name: /Test Dropdown/i });
    extendedExpect(buttonElement).toBeInTheDocument();
    extendedExpect(buttonElement).toHaveTextContent(title);
  });

  it('renders icon with correct rotation class when closed', () => {
    render(
      <DropdownButton
        title="Test Dropdown"
        isOpen={false}
        onClick={vi.fn()}
      />
    );
    
    const iconElement = screen.getByTestId('icon');
    extendedExpect(iconElement).toHaveClass('ml-2');
    extendedExpect(iconElement).toHaveClass('transform');
    extendedExpect(iconElement).not.toHaveClass('rotate-180');
  });

  it('renders icon with correct rotation class when open', () => {
    render(
      <DropdownButton
        title="Test Dropdown"
        isOpen={true}
        onClick={vi.fn()}
      />
    );
    
    const iconElement = screen.getByTestId('icon');
    extendedExpect(iconElement).toHaveClass('ml-2');
    extendedExpect(iconElement).toHaveClass('transform');
    extendedExpect(iconElement).toHaveClass('rotate-180');
  });

  it('calls onClick handler when button is clicked', () => {
    const handleClick = vi.fn();
    render(
      <DropdownButton
        title="Test Dropdown"
        isOpen={false}
        onClick={handleClick}
      />
    );
    
    const buttonElement = screen.getByRole('button', { name: /Test Dropdown/i });
    fireEvent.click(buttonElement);
    
    expect(handleClick).toHaveBeenCalledTimes(1);
  });
});