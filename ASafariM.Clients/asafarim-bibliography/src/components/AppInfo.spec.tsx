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
    const headerElements = screen.getAllByTestId('doc-tab-0');
    expect(headerElements[0]).toBeInTheDocument();
    expect(screen.queryByText(/ASafariM Bibliography/i)).not.toBeInTheDocument();
  });

  it('expands on header click', () => {
    render(<AppInfo />);
    const headerElements = screen.getAllByTestId('doc-tab-0');
    fireEvent.click(headerElements[0]);

    expect(screen.getByText(/ASafariM Bibliography/i)).toBeInTheDocument();
    expect(screen.getByText(/This application demonstrates/i)).toBeInTheDocument();
  });

  it('toggles collapse and expand on click', () => {
    render(<AppInfo />);
    const headerElements = screen.getAllByTestId('doc-tab-0');
    const header = headerElements[0];

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
      const headerElements = screen.getAllByTestId('doc-tab-0');
      fireEvent.click(headerElements[0]);
      vi.advanceTimersByTime(300);
    });

    act(() => {
      // Get the tab by its data-testid
      const apiDataTabs = screen.getAllByTestId('tab-1');
      fireEvent.click(apiDataTabs[0]);
      vi.advanceTimersByTime(300);
    });

    // Verify the API Data tab content is visible by checking for a unique element
    const tabContent = screen.getAllByText(/API Data/i)[1]; // Get the second occurrence (tab header)
    expect(tabContent).toBeInTheDocument();
    
    // Check for the documentation link
    expect(screen.getByText(/View Documentation/i)).toHaveAttribute(
      'href',
      'https://blog.asafarim.com/docs/React/Basics/handle-data-from-api'
    );
  });

  it('renders correct example code per tab', () => {
    render(<AppInfo />);
    
    act(() => {
      const headerElements = screen.getAllByTestId('doc-tab-0');
      fireEvent.click(headerElements[0]);
      vi.advanceTimersByTime(300);
    });

    act(() => {
      // Click on the useFetch tab
      const useFetchTabs = screen.getAllByTestId('tab-2');
      fireEvent.click(useFetchTabs[0]);
      vi.advanceTimersByTime(300);
    });

    // Look for text in the code block that's unique to the useFetch tab
    expect(screen.getByText(/useFetch Hook/i)).toBeInTheDocument();

    act(() => {
      // Click on the Axios tab
      const axiosTabs = screen.getAllByTestId('tab-3');
      fireEvent.click(axiosTabs[0]);
      vi.advanceTimersByTime(300);
    });

    // Look for text in the code block that's unique to the Axios tab
    expect(screen.getByText(/Axios Configuration/i)).toBeInTheDocument();
  });

  it('applies fade-in and fade-out classes when toggling', () => {
    render(<AppInfo />);
    const headerElements = screen.getAllByTestId('doc-tab-0');
    const header = headerElements[0];

    fireEvent.click(header); // expand
    const content = screen.getByText(/ASafariM Bibliography/i).parentElement?.parentElement;
    expect(content?.className).toContain('fade-in');

    fireEvent.click(header); // collapse
    const container = document.querySelector('.app-info-container');
    expect(container?.className).toContain('collapsed');
  });
});
