import { renderHook, act } from '@testing-library/react';
import useAuth from '@/hooks/useAuth';
import { describe, beforeEach, afterEach, it, expect, vi } from 'vitest';
import { ILoginModel } from '@/interfaces/ILoginModel';

// Mock the authapi module
vi.mock('@/api/authapi', () => ({
  login: vi.fn().mockImplementation(async (credentials: ILoginModel) => {
    // Mock successful login response
    return {
      token: 'mock-token',
      authenticatedUser: {
        id: credentials.userName === 'admin' ? 'admin-id' : 'user-id',
        email: `${credentials.userName}@example.com`,
        firstName: 'Ali',
        lastName: 'Safari'
      }
    };
  }),
  logout: vi.fn().mockResolvedValue(undefined)
}));

// Mock window.location
const mockLocation = {
  href: window.location.href
};
Object.defineProperty(window, 'location', {
  value: mockLocation,
  writable: true
});

// Mock logger
vi.mock('@/utils/logger', () => ({
  logger: {
    log: vi.fn(),
    error: vi.fn(),
    debug: vi.fn(),
    warn: vi.fn()
  }
}));

describe('useAuth', () => {
  // Mock storage event
  const dispatchStorageEvent = () => {
    window.dispatchEvent(new Event('storage'));
  };

  // Mock auth state change event
  const dispatchAuthStateChangeEvent = () => {
    window.dispatchEvent(new Event('authStateChange'));
  };

  beforeEach(() => {
    // Clear storage before each test
    localStorage.clear();
    sessionStorage.clear();
    
    // Reset mocked location
    mockLocation.href = 'http://localhost/';
  });

  afterEach(() => {
    vi.clearAllMocks();
  });

  it('should default to unauthenticated state', () => {
    const { result } = renderHook(() => useAuth());
    
    expect(result.current.authenticated).toBe(false);
    expect(result.current.authenticatedUser).toBeNull();
    expect(result.current.token).toBeNull();
  });

  it('should set auth state on login', async () => {
    const testCredentials: ILoginModel = {
      userName: 'admin',
      password: 'password123',
      rememberMe: true
    };

    const { result } = renderHook(() => useAuth());

    await act(async () => {
      await result.current.login(testCredentials);
    });

    // Check the hook state
    expect(result.current.authenticated).toBe(true);
    expect(result.current.authenticatedUser).toEqual({
      id: 'admin-id',
      email: 'admin@example.com',
      firstName: 'Ali',
      lastName: 'Safari'
    });
    expect(result.current.token).toBe('mock-token');

    // Check localStorage
    const storedAuth = JSON.parse(localStorage.getItem('auth') || '{}');
    expect(storedAuth.authenticated).toBe(true);
    expect(storedAuth.token).toBe('mock-token');
    
    // Check sessionStorage
    const sessionAuth = JSON.parse(sessionStorage.getItem('auth') || '{}');
    expect(sessionAuth.authenticated).toBe(true);
    expect(sessionAuth.token).toBe('mock-token');
  });

  it('should clear auth state on logout', async () => {
    // Setup initial authenticated state
    const authData = {
      authenticated: true,
      authenticatedUser: {
        id: 'test-id',
        email: 'test@example.com',
        firstName: 'Ali',
        lastName: 'Safari'
      },
      token: 'test-token'
    };
    
    localStorage.setItem('auth', JSON.stringify(authData));
    sessionStorage.setItem('auth', JSON.stringify(authData));

    const { result } = renderHook(() => useAuth());
    
    // Verify initial state is authenticated
    expect(result.current.authenticated).toBe(true);
    
    // Perform logout
    await act(async () => {
      await result.current.logout();
    });

    // Check the hook state
    expect(result.current.authenticated).toBe(false);
    expect(result.current.authenticatedUser).toBeNull();
    expect(result.current.token).toBeNull();
    
    // Check localStorage and sessionStorage are cleared
    expect(localStorage.getItem('auth')).toBeNull();
    expect(sessionStorage.getItem('auth')).toBeNull();
    
    // Check redirect to login page
    expect(mockLocation.href).toBe('/login');
  });

  it('should initialize from localStorage if auth exists', () => {
    // Setup stored auth data
    const storedAuth = {
      authenticated: true,
      authenticatedUser: {
        id: 'stored-id',
        email: 'stored@example.com',
        firstName: 'Stored',
        lastName: 'User'
      },
      token: 'stored-token'
    };
    
    localStorage.setItem('auth', JSON.stringify(storedAuth));

    const { result } = renderHook(() => useAuth());

    // Check the hook initialized with stored data
    expect(result.current.authenticated).toBe(true);
    expect(result.current.authenticatedUser).toEqual(storedAuth.authenticatedUser);
    expect(result.current.token).toBe('stored-token');
  });
  
  it('should prefer localStorage over sessionStorage', () => {
    // Setup different auth data in localStorage and sessionStorage
    const localAuth = {
      authenticated: true,
      authenticatedUser: {
        id: 'local-id',
        email: 'local@example.com',
        firstName: 'Local',
        lastName: 'User'
      },
      token: 'local-token'
    };
    
    const sessionAuth = {
      authenticated: true,
      authenticatedUser: {
        id: 'session-id',
        email: 'session@example.com',
        firstName: 'Session',
        lastName: 'User'
      },
      token: 'session-token'
    };
    
    localStorage.setItem('auth', JSON.stringify(localAuth));
    sessionStorage.setItem('auth', JSON.stringify(sessionAuth));

    const { result } = renderHook(() => useAuth());

    // Check the hook initialized with localStorage data
    expect(result.current.authenticatedUser?.id).toBe('local-id');
    expect(result.current.token).toBe('local-token');
  });
  
  it('should handle case-sensitive property names in stored auth data', () => {
    // Setup auth data with capitalized property names
    const storedAuth = {
      Authenticated: true,
      AuthenticatedUser: {
        id: 'case-id',
        email: 'case@example.com',
        firstName: 'Case',
        lastName: 'Sensitive'
      },
      Token: 'case-token'
    };
    
    localStorage.setItem('auth', JSON.stringify(storedAuth));

    const { result } = renderHook(() => useAuth());

    // Check the hook normalized the property names
    expect(result.current.authenticated).toBe(true);
    expect(result.current.authenticatedUser?.id).toBe('case-id');
    expect(result.current.token).toBe('case-token');
  });
  
  it('should update auth state when storage changes', () => {
    const { result } = renderHook(() => useAuth());
    
    // Initially unauthenticated
    expect(result.current.authenticated).toBe(false);
    
    // Set auth data in localStorage
    const newAuthData = {
      authenticated: true,
      authenticatedUser: {
        id: 'new-id',
        email: 'new@example.com',
        firstName: 'New',
        lastName: 'User'
      },
      token: 'new-token'
    };
    
    act(() => {
      localStorage.setItem('auth', JSON.stringify(newAuthData));
      dispatchStorageEvent();
    });
    
    // Check that auth state was updated
    expect(result.current.authenticated).toBe(true);
    expect(result.current.authenticatedUser?.id).toBe('new-id');
    expect(result.current.token).toBe('new-token');
  });
  
  it('should update auth state when authStateChange event is fired', () => {
    const { result } = renderHook(() => useAuth());
    
    // Initially unauthenticated
    expect(result.current.authenticated).toBe(false);
    
    // Set auth data in localStorage
    const newAuthData = {
      authenticated: true,
      authenticatedUser: {
        id: 'event-id',
        email: 'event@example.com',
        firstName: 'Event',
        lastName: 'User'
      },
      token: 'event-token'
    };
    
    act(() => {
      localStorage.setItem('auth', JSON.stringify(newAuthData));
      dispatchAuthStateChangeEvent();
    });
    
    // Check that auth state was updated
    expect(result.current.authenticated).toBe(true);
    expect(result.current.authenticatedUser?.id).toBe('event-id');
    expect(result.current.token).toBe('event-token');
  });
});
