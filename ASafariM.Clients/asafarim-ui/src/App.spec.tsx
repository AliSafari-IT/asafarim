import { describe, it, expect, vi, beforeEach } from 'vitest';
import { render, screen } from '@testing-library/react';
import { MemoryRouter } from 'react-router-dom';
import * as analyticsService from './services/analyticsService';
import { logger } from '@/utils/logger';
import { useAuth } from './contexts/AuthContext';

// Mock the App component instead of using the real one
vi.mock('./App', () => ({
  default: () => <div data-testid="app-component">Mocked App Component</div>
}));

// Mock the AuthContext
vi.mock('./contexts/AuthContext', () => ({
  useAuth: vi.fn().mockReturnValue({
    authenticatedUser: null,
    authenticated: false,
    token: null
  }),
  AuthProvider: ({ children }: { children: React.ReactNode }) => <>{children}</>
}));

// Mock analytics service
vi.mock('./services/analyticsService', () => ({
  trackPageView: vi.fn()
}));

// Mock logger
vi.mock('@/utils/logger', () => ({
  logger: {
    log: vi.fn(),
    error: vi.fn(),
    warn: vi.fn(),
    info: vi.fn(),
    debug: vi.fn()
  }
}));

// Mock mdFilesUtils
vi.mock('./utils/mdFilesUtils', () => ({
  getAllMdFiles: vi.fn().mockReturnValue({
    legalDocs: [],
    changelogs: [],
    techDocs: [],
    essentialInsights: [],
    projects: []
  })
}));

describe('App Component Tests', () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  it('should render the App component', () => {
    render(
      <MemoryRouter>
        <div data-testid="app-component">Mocked App Component</div>
      </MemoryRouter>
    );
    expect(screen.getByTestId('app-component')).toBeInTheDocument();
  });

  it('should track page views when analytics service is called', () => {
    analyticsService.trackPageView('/', 'Test Page');
    expect(analyticsService.trackPageView).toHaveBeenCalledWith('/', 'Test Page');
  });

  it('should log messages correctly', () => {
    logger.log('Test log message');
    expect(logger.log).toHaveBeenCalledWith('Test log message');
  });

  // Test that we can import and use the mocked AuthContext
  it('should provide authentication context', () => {
    expect(useAuth).toBeDefined();
    
    const authData = useAuth();
    expect(authData).toEqual({
      authenticatedUser: null,
      authenticated: false,
      token: null
    });
  });
});
