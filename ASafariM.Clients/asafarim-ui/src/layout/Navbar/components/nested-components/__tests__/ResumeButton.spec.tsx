// ResumeButton.spec.tsx
import { render, screen, fireEvent } from '@testing-library/react';
import { describe, it, expect, vi, beforeEach } from 'vitest';
import { expect as extendedExpect } from '@/test-utils/setup-test-env';
import ResumeButton from '../../ResumeButton';

describe('ResumeButton', () => {
  // Mock window.open
  const windowOpenSpy = vi.fn();

  beforeEach(() => {
    // Setup window.open mock
    vi.stubGlobal('open', windowOpenSpy);
  });

  afterEach(() => {
    // Clear mocks
    vi.clearAllMocks();
  });

  it('renders with text display by default', () => {
    render(<ResumeButton />);
    
    // Check that the button is rendered with text
    const button = screen.getByRole('button');
    extendedExpect(button).toBeInTheDocument();
    extendedExpect(button).toHaveTextContent('Resume');
    
    // Check that the SVG icon is not rendered
    const svg = button.querySelector('svg');
    extendedExpect(svg).not.toBeInTheDocument();
  });

  it('renders with icon when displayType is "icon"', () => {
    render(<ResumeButton displayType="icon" />);
    
    // Check that the button is rendered with an icon
    const button = screen.getByRole('button');
    extendedExpect(button).toBeInTheDocument();
    extendedExpect(button).not.toHaveTextContent('Resume');
    
    // Check that the SVG icon is rendered
    const svg = button.querySelector('svg');
    extendedExpect(svg).toBeInTheDocument();
  });

  it('applies custom className', () => {
    render(<ResumeButton className="custom-class" />);
    
    const button = screen.getByRole('button');
    extendedExpect(button).toHaveClass('custom-class');
    
    // Should also have the default classes
    extendedExpect(button).toHaveClass('bg-teams-purple');
    extendedExpect(button).toHaveClass('text-white');
    extendedExpect(button).toHaveClass('rounded-md');
  });

  it('opens resume URL in new tab when clicked', () => {
    render(<ResumeButton />);
    
    const button = screen.getByRole('button');
    fireEvent.click(button);
    
    // Check that window.open was called with the correct URL and target
    expect(windowOpenSpy).toHaveBeenCalledTimes(1);
    expect(windowOpenSpy).toHaveBeenCalledWith(
      'https://sites.google.com/view/asafarim-it',
      '_blank'
    );
  });
});