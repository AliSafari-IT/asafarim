import { describe, it, expect, vi, beforeEach } from 'vitest';
import { render, screen, fireEvent } from '@testing-library/react';
import '@testing-library/jest-dom';
import { MemoryRouter } from 'react-router-dom';
import Navbar from './Navbar';

// Mock matchMedia for Headless UI
beforeEach(() => {
  window.matchMedia = vi.fn().mockImplementation(query => ({
    matches: false,
    media: query,
    onchange: null,
    addListener: vi.fn(),
    removeListener: vi.fn(),
    addEventListener: vi.fn(),
    removeEventListener: vi.fn(),
    dispatchEvent: vi.fn(),
  }));
});

describe('Navbar component', () => {
  it('renders navbar with navigation links', () => {
    render(<Navbar />, { wrapper: MemoryRouter });

    expect(screen.getByText('ASafariM Bibliography')).toBeInTheDocument();
    expect(screen.getByText('Bibliography')).toBeInTheDocument();
    expect(screen.getByText('Add Book')).toBeInTheDocument();
  });

  it('activates "Bibliography" link by default', () => {
    render(<Navbar />, { wrapper: MemoryRouter });

    // Use querySelector to find the first Bibliography link in the desktop menu
    const bibLink = document.querySelector('.hidden.sm\\:ml-6.sm\\:block a[href="/"]');
    expect(bibLink).toHaveClass('bg-gray-900');
  });

  it('activates clicked navigation item', () => {
    render(<Navbar />, { wrapper: MemoryRouter });

    const addBookLink = screen.getAllByText('Add Book')[0]; // One in desktop, one in mobile panel
    fireEvent.click(addBookLink);

    expect(addBookLink).toHaveClass('bg-gray-900');
  });

  it('toggles mobile menu when Disclosure button is clicked', () => {
    render(<Navbar />, { wrapper: MemoryRouter });

    // Use querySelector to find the first mobile menu button
    const menuButton = document.querySelector('.absolute.inset-y-0.left-0 button');
    expect(menuButton).not.toBeNull();

    // Click to open
    if (menuButton) {
      fireEvent.click(menuButton);
      expect(screen.getAllByText('Add Book').length).toBeGreaterThan(1);
    }
  });

  it('renders Add button with Plus icon', () => {
    render(<Navbar />, { wrapper: MemoryRouter });

    // Use a more specific query to find the Add button with the Plus icon
    // First find the container with the right classes
    const addButton = document.querySelector('a.rounded-full.bg-indigo-600');
    expect(addButton).toHaveAttribute('href', '/add');
  });
});
