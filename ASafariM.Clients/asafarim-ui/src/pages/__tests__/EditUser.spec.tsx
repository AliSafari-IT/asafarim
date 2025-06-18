import { render, screen, waitFor } from '@testing-library/react';
import EditUser from '../User/EditUser';
import { BrowserRouter } from 'react-router-dom';
import { describe, it, beforeEach, vi, expect } from 'vitest';
import * as userService from '@/api/userService';
import { ThemeProvider } from '@/contexts/ThemeContext';
import React from 'react';

// Mock all dependencies
vi.mock('@/contexts/AuthContext', () => ({
  useAuth: () => ({ 
    authenticatedUser: { 
      isAdmin: true,
      id: 'admin123',
      firstName: 'Admin',
      lastName: 'User'
    } 
  })
}));

vi.mock('react-router-dom', async () => {
  const actual = await vi.importActual('react-router-dom');
  return {
    ...actual,
    useParams: () => ({ id: 'user123' }),
    useNavigate: () => vi.fn()
  };
});

vi.mock('@/utils/logger', () => ({
  logger: {
    log: vi.fn(),
    info: vi.fn(),
    error: vi.fn(),
    debug: vi.fn(),
    warn: vi.fn()
  }
}));

vi.mock('axios', () => ({
  default: {
    create: vi.fn(() => ({
      interceptors: {
        request: { use: vi.fn(), eject: vi.fn() },
        response: { use: vi.fn(), eject: vi.fn() }
      },
      get: vi.fn().mockResolvedValue({ data: { isAvailable: true } }),
      post: vi.fn().mockResolvedValue({ data: {} }),
      put: vi.fn().mockResolvedValue({ data: {} }),
      defaults: {
        headers: {
          common: {
            'Content-Type': 'application/json',
            'Accept': 'application/json'
          }
        }
      }
    })),
    get: vi.fn().mockResolvedValue({ data: { isAvailable: true } }),
    isAxiosError: vi.fn(() => false)
  }
}));

// Mock localStorage
const localStorageMock = (() => {
  let store: Record<string, string> = {};
  return {
    getItem: (key: string) => store[key] || null,
    setItem: (key: string, value: string) => {
      store[key] = value.toString();
    },
    removeItem: (key: string) => {
      delete store[key];
    },
    clear: () => {
      store = {};
    }
  };
})();

Object.defineProperty(window, 'localStorage', {
  value: localStorageMock
});

// Set up auth in localStorage
localStorage.setItem('auth', JSON.stringify({ token: 'test-token' }));

vi.mock('@/api/userService', () => ({
  getUserById: vi.fn(() =>
    Promise.resolve({
      id: 'user123',
      firstName: 'Ali',
      lastName: 'Safari',
      email: 'ali@example.com',
      userName: 'alisafari',
      dateOfBirth: '1990-01-01T00:00:00Z',
      roles: [],
      isDeleted: false,
      isAdmin: true,
      isActive: true
    })
  ),
  getRoles: vi.fn(() =>
    Promise.resolve({
      $values: [{ id: '1', name: 'Admin' }, { id: '2', name: 'User' }]
    })
  ),
  getRolesByUserId: vi.fn(() =>
    Promise.resolve({
      $values: [{ roleId: '1' }]
    })
  ),
  updateUserByAdmin: vi.fn(() => Promise.resolve({ id: 'user123' })),
  assignRolesToUser: vi.fn(),
  removeRolesFromUser: vi.fn()
}));

const renderWithRouter = () =>
  render(
    <BrowserRouter>
      <ThemeProvider>
        <EditUser />
      </ThemeProvider>
    </BrowserRouter>
  );

describe('EditUser', () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  it('renders the edit form with user data', async () => {
    renderWithRouter();

    await waitFor(() => {
      expect(screen.getByDisplayValue('Ali')).toBeInTheDocument();
      expect(screen.getByDisplayValue('Safari')).toBeInTheDocument();
      expect(screen.getByDisplayValue('ali@example.com')).toBeInTheDocument();
    });
  });

  it('displays error message on API error', async () => {
    // Use vi.mocked to properly type the mocked function
    vi.mocked(userService.getUserById).mockRejectedValueOnce(new Error('User fetch error'));

    renderWithRouter();

    await waitFor(() => {
      expect(screen.getByText(/failed to load user data/i)).toBeInTheDocument();
    });
  });
});
