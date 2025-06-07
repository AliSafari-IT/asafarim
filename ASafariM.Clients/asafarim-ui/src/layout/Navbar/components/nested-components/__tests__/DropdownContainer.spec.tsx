import { render, screen } from '@testing-library/react';
import { describe, it } from 'vitest';
import { expect as extendedExpect } from '@/test-utils/setup-test-env';
import DropdownContainer from '../DropdownContainer';

describe('DropdownContainer', () => {
  it('renders children when isOpen is true', () => {
    render(
      <DropdownContainer isOpen={true}>
        <div data-testid="test-child">Test Content</div>
      </DropdownContainer>
    );
    
    const childElement = screen.getByTestId('test-child');
    extendedExpect(childElement).toBeInTheDocument();
    extendedExpect(childElement).toHaveTextContent('Test Content');
    
    // Check that the container has the correct classes
    const containerElement = childElement.parentElement;
    extendedExpect(containerElement).toHaveClass('absolute');
    extendedExpect(containerElement).toHaveClass('left-0');
    extendedExpect(containerElement).toHaveClass('mt-2');
    extendedExpect(containerElement).toHaveClass('w-48');
    extendedExpect(containerElement).toHaveClass('bg-[var(--bg-primary)]');
    extendedExpect(containerElement).toHaveClass('shadow-lg');
    extendedExpect(containerElement).toHaveClass('rounded-md');
    extendedExpect(containerElement).toHaveClass('z-10');
  });

  it('does not render anything when isOpen is false', () => {
    render(
      <DropdownContainer isOpen={false}>
        <div data-testid="test-child">Test Content</div>
      </DropdownContainer>
    );
    
    // Child element should not be in the document
    const childElement = screen.queryByTestId('test-child');
    extendedExpect(childElement).not.toBeInTheDocument();
  });

  it('renders multiple children when isOpen is true', () => {
    render(
      <DropdownContainer isOpen={true}>
        <div data-testid="child-1">First Child</div>
        <div data-testid="child-2">Second Child</div>
        <div data-testid="child-3">Third Child</div>
      </DropdownContainer>
    );
    
    // All children should be in the document
    const firstChild = screen.getByTestId('child-1');
    const secondChild = screen.getByTestId('child-2');
    const thirdChild = screen.getByTestId('child-3');
    
    extendedExpect(firstChild).toBeInTheDocument();
    extendedExpect(secondChild).toBeInTheDocument();
    extendedExpect(thirdChild).toBeInTheDocument();
    
    extendedExpect(firstChild).toHaveTextContent('First Child');
    extendedExpect(secondChild).toHaveTextContent('Second Child');
    extendedExpect(thirdChild).toHaveTextContent('Third Child');
  });
});