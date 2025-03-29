import { render, screen } from '@testing-library/react';
import { describe, it, expect } from 'vitest';
import Header from './Header';
import { expect as extendedExpect } from '@/test-utils/setup-test-env';

describe('DefaultHeader', () => {
  it('should render successfully with children', () => {
    const { container } = render(<Header>Header Content</Header>);
    const headerElement = container.querySelector('header');
    const textElement = screen.getByText('Header Content');
    
    extendedExpect(textElement).toBeInTheDocument();
    extendedExpect(headerElement).toHaveClass('h-16', 'flex', 'text-md');
  });

  it('should not render when children are not provided', () => {
    const { container } = render(<Header />);
    expect(container.firstChild).toBeNull();
  });

  it('should apply custom className', () => {
    const { container } = render(<Header className="custom-class">Header Content</Header>);
    const headerElement = container.querySelector('header');
    
    extendedExpect(headerElement).toHaveClass('custom-class');
  });

  it('should apply custom color', () => {
    const { container } = render(<Header color="red">Header Content</Header>);
    const headerElement = container.querySelector('header');
    
    expect(headerElement?.style.color).toBe('red');
  });

  it('should apply custom size', () => {
    const { container } = render(<Header size="text-xl">Header Content</Header>);
    const headerElement = container.querySelector('header');
    
    extendedExpect(headerElement).toHaveClass('text-xl');
  });

  it('should apply custom id', () => {
    const { container } = render(<Header id="custom-id">Header Content</Header>);
    const headerElement = container.querySelector('header');
    
    expect(headerElement?.id).toBe('custom-id');
  });
});