import { describe, it, vi, expect, beforeEach } from 'vitest';
import {render, fireEvent, screen} from '@testing-library/react';
import ExportData from '../User/ExportData';
import { useAuth } from '@/contexts/AuthContext';
import React from 'react';

vi.mock('@/contexts/AuthContext', () => ({
  useAuth: vi.fn()
}));

vi.mock('@/utils/logger', () => ({
  logger: {
    log: vi.fn(),
    info: vi.fn(),
    debug: vi.fn(),
    error: vi.fn()
  }
}));

describe('ExportData component', () => {
  const mockUserInfo = {
    fullName: 'Ali Safari',
    email: 'ali@example.com'
  };

  const renderComponent = () => render(<ExportData currentUserInfo={mockUserInfo as any} />);

  beforeEach(() => {
    vi.clearAllMocks();
  });

  it('shows error if unauthenticated or user is deleted', async () => {
    (useAuth as any).mockReturnValue({
      authenticated: false,
      authenticatedUser: null,
    });
  
    renderComponent();
  
    const exportButton = screen.getByText(/export my data/i);
    fireEvent.click(exportButton);
  
    expect(await screen.findByText(/you are not eligible to export data/i)).toBeInTheDocument();
  });

  it('shows error if user is deleted', async () => {
    (useAuth as any).mockReturnValue({
      authenticated: true,
      authenticatedUser: { isDeleted: true },
    });
  
    renderComponent();
  
    const exportButton = screen.getByText(/export my data/i);
    fireEvent.click(exportButton);
  
    expect(await screen.findByText(/you are not eligible to export data/i)).toBeInTheDocument();
  });
});
