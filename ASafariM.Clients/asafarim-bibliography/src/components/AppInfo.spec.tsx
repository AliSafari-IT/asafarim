import { describe, it, expect, beforeEach, vi } from 'vitest';
import { render, screen, fireEvent } from '@testing-library/react';
import '@testing-library/jest-dom';
import { act } from 'react-dom/test-utils';
import AppInfo from './AppInfo';

describe('AppInfo Component', () => {
  beforeEach(() => {
    // JSDOM lacks animation support — skip timers
    vi.useFakeTimers();
  });

  it('should render collapsed by default', () => {
    render(<AppInfo />);
    expect(screen.getByText(/documentation & resources/i)).toBeInTheDocument();
    expect(screen.queryByText(/ASafariM Bibliography/i)).not.toBeInTheDocument();
  });

  it('expands on header click', () => {
    render(<AppInfo />);
    fireEvent.click(screen.getByText(/documentation & resources/i));

    expect(screen.getByText(/ASafariM Bibliography/i)).toBeInTheDocument();
    expect(screen.getByText(/This application demonstrates/i)).toBeInTheDocument();
  });

  it('toggles collapse and expand on click', () => {
    render(<AppInfo />);
    const header = screen.getByText(/documentation & resources/i);

    // Expand
    fireEvent.click(header);
    expect(screen.getByText(/ASafariM Bibliography/i)).toBeInTheDocument();

    // Collapse
    fireEvent.click(header);
    expect(screen.queryByText(/ASafariM Bibliography/i)).not.toBeInTheDocument();
  });

  it('renders all tabs and switches active tab on click', () => {
    render(<AppInfo />);
    
    act(() => {
      fireEvent.click(screen.getByText(/documentation & resources/i));
      vi.advanceTimersByTime(300);
    });

    act(() => {
      fireEvent.click(screen.getByText('API Data'));
      vi.advanceTimersByTime(300);
    });

    // Look for content in the API Data tab
    expect(screen.getByText(/API Data Handling/i)).toBeInTheDocument();
    expect(screen.getByText(/View Documentation/i)).toHaveAttribute(
      'href',
      'https://blog.asafarim.com/docs/React/Basics/handle-data-from-api'
    );
  });

  it('renders correct example code per tab', () => {
    render(<AppInfo />);
    
    act(() => {
      fireEvent.click(screen.getByText(/documentation & resources/i));
      vi.advanceTimersByTime(300);
    });

    act(() => {
      fireEvent.click(screen.getByText('useFetch'));
      vi.advanceTimersByTime(300);
    });

    expect(screen.getByText(/useFetch Hook/i)).toBeInTheDocument();

    act(() => {
      fireEvent.click(screen.getByText('Axios'));
      vi.advanceTimersByTime(300);
    });

    expect(screen.getByText(/Axios Configuration/i)).toBeInTheDocument();
  });

  it('applies fade-in and fade-out classes when toggling', () => {
    render(<AppInfo />);
    const header = screen.getByText(/documentation & resources/i);

    fireEvent.click(header); // expand
    const content = screen.getByText(/ASafariM Bibliography/i).parentElement?.parentElement;
    expect(content?.className).toContain('fade-in');

    fireEvent.click(header); // collapse
    const container = document.querySelector('.app-info-container');
    expect(container?.className).toContain('collapsed');
  });
});
