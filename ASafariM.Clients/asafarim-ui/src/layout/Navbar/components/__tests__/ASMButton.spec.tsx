import React from 'react';
import { render, screen, fireEvent } from '@testing-library/react';
import { describe, it, expect, vi, beforeEach } from 'vitest';
import { expect as extendedExpect } from '@/test-utils/setup-test-env';
import ASMButton from '../ASMButton';

// Mock window.open
const mockOpen = vi.fn();
vi.stubGlobal('open', mockOpen);

describe('ASMButton', () => {
  beforeEach(() => {
    // Clear mock before each test
    mockOpen.mockClear();
  });

  it('renders the button with correct text', () => {
    render(<ASMButton />);
    
    const buttonText = screen.getByText('Resume');
    extendedExpect(buttonText).toBeInTheDocument();
  });

  it('renders the SVG icon', () => {
    render(<ASMButton />);
    
    // Check for the SVG element
    const svgElement = document.querySelector('svg');
    extendedExpect(svgElement).toBeInTheDocument();
    
    // Check for the CV text inside the SVG
    const textElement = document.querySelector('svg text');
    extendedExpect(textElement).toBeInTheDocument();
    extendedExpect(textElement).toHaveTextContent('CV');
  });

  it('has the correct styling classes', () => {
    render(<ASMButton />);
    
    const button = screen.getByRole('button');
    extendedExpect(button).toHaveClass('bg-gradient-to-r');
    extendedExpect(button).toHaveClass('rounded-md');
    extendedExpect(button).toHaveClass('shadow-md');
    extendedExpect(button).toHaveClass('hover:scale-105');
    extendedExpect(button).toHaveClass('transition-transform');
  });

  it('opens the correct URL in a new tab when clicked', () => {
    render(<ASMButton />);
    
    const button = screen.getByRole('button');
    fireEvent.click(button);
    
    // Verify that window.open was called with the correct URL and target
    expect(mockOpen).toHaveBeenCalledTimes(1);
    expect(mockOpen).toHaveBeenCalledWith(
      'https://sites.google.com/view/asafarim-it',
      '_blank'
    );
  });
});