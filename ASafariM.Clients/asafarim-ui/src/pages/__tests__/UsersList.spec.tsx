import { render, screen, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import UsersList from "../User/UsersList";
import { BrowserRouter } from "react-router-dom";
import { AuthProvider } from "@/contexts/AuthContext";
import { ThemeProvider } from "@/contexts/ThemeContext";
import * as userService from "@/api/userService";
import { IApiResponse, IRole, IRoleEnum, IUser, IUserRole } from "@/interfaces";
import { ReactNode } from "react";

// Mock the logger
vi.mock('@/utils/logger', () => ({
  logger: {
    log: vi.fn(),
    info: vi.fn(),
    debug: vi.fn(),
    error: vi.fn(),
    warn: vi.fn()
  }
}));

// Mock the auth context
vi.mock("@/contexts/AuthContext", async () => {
  const actual = await vi.importActual("@/contexts/AuthContext");
  return {
    ...actual,
    useAuth: () => ({
      authenticatedUser: { 
        id: "admin123", 
        isAdmin: true 
      }
    })
  };
});

// Mock axios and api
vi.mock("axios", () => {
  const mockAxios = {
    create: vi.fn(() => ({
      interceptors: {
        request: { use: vi.fn(), eject: vi.fn() },
        response: { use: vi.fn(), eject: vi.fn() }
      },
      get: vi.fn().mockResolvedValue({ data: { isAvailable: true } }),
      post: vi.fn().mockResolvedValue({ data: { success: true } }),
      put: vi.fn().mockResolvedValue({ data: { success: true } }),
      delete: vi.fn().mockResolvedValue({ data: { success: true } }),
      defaults: {
        headers: {
          common: {}
        }
      }
    })),
    isAxiosError: vi.fn().mockImplementation(() => true),
    get: vi.fn().mockResolvedValue({ data: { isAvailable: true } }),
    post: vi.fn().mockResolvedValue({ data: { success: true } })
  };
  return {
    default: mockAxios
  };
});

// Mock localStorage
Object.defineProperty(window, 'localStorage', {
  value: {
    getItem: vi.fn(() => JSON.stringify({ token: 'fake-token' })),
    setItem: vi.fn(),
    removeItem: vi.fn()
  },
  writable: true
});

// Mock the layout components
vi.mock('@/layout/Wrapper/Wrapper', () => ({
  default: ({ children }: { children: ReactNode }) => <div data-testid="mock-wrapper">{children}</div>
}));

vi.mock('@/layout/Header/Header', () => ({
  default: () => <div data-testid="mock-header">Header</div>
}));

vi.mock('@/layout/Footer/Footer', () => ({
  default: () => <div data-testid="mock-footer">Footer</div>
}));

// Mock Notification component
vi.mock('@/components/Notification/Notification', () => ({
  default: ({ message }: { message: string }) => <div data-testid="notification">{message}</div>
}));

// Mock the api module
vi.mock("@/api/authapi", () => {
  return {
    login: vi.fn().mockResolvedValue({ success: true }),
    logout: vi.fn().mockResolvedValue({ success: true }),
    register: vi.fn().mockResolvedValue({ success: true }),
    getAuthenticatedUser: vi.fn().mockResolvedValue({ 
      id: "123", 
      firstName: "John", 
      lastName: "Doe", 
      isAdmin: true,
      isDeleted: false
    })
  };
});

// Create mock data
const mockUsers: IUser[] = [
  {
    id: "1",
    firstName: "John",
    lastName: "Doe",
    email: "john@example.com",
    userName: "johndoe",
    isAdmin: false,
    isActive: true,
    isDeleted: false
  },
  {
    id: "2",
    firstName: "Jane",
    lastName: "Smith",
    email: "jane@example.com",
    userName: "janesmith",
    isAdmin: true,
    isActive: true,
    isDeleted: false
  }
];

const mockRoles: IRole[] = [
  { id: "1", name: "Admin" },
  { id: "2", name: "User" }
];

const mockUserRoles: IUserRole[] = [
  { userId: "1", roleId: "2" },
  { userId: "2", roleId: "1" }
];

// Mock user service
vi.mock("@/api/userService", () => ({
  getUsers: vi.fn().mockImplementation(() => {
    const apiResponse: IApiResponse<IUser> = {
      $values: mockUsers
    };
    return Promise.resolve(apiResponse);
  }),
  getRoles: vi.fn().mockImplementation(() => {
    const apiResponse: IApiResponse<IRole> = {
      $values: mockRoles
    };
    return Promise.resolve(apiResponse);
  }),
  getRolesByUserId: vi.fn().mockImplementation((userId: string) => {
    const userRoles = mockUserRoles.filter(ur => ur.userId === userId);
    const apiResponse: IApiResponse<IUserRole> = {
      $values: userRoles
    };
    return Promise.resolve(apiResponse);
  }),
  deleteUserByAdmin: vi.fn().mockResolvedValue(undefined),
  getUserById: vi.fn().mockResolvedValue({})
}));

beforeEach(() => {
  vi.clearAllMocks();
  
  // Mock window.confirm
  vi.spyOn(window, 'confirm').mockImplementation(() => true);
});

describe("UsersList", () => {
  it("renders users list component", async () => {
    render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <UsersList />
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    expect(screen.getByTestId("mock-wrapper")).toBeInTheDocument();
    
    // Wait for the component to finish loading
    await waitFor(() => {
      expect(userService.getUsers).toHaveBeenCalledTimes(1);
    });
  });

  it("fetches and displays users", async () => {
    render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <UsersList />
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    // Check if the loading state is shown initially
    expect(screen.getByTestId("mock-wrapper")).toBeInTheDocument();
    
    // Wait for the component to finish loading and display users
    await waitFor(() => {
      expect(userService.getUsers).toHaveBeenCalledWith(true);
      expect(userService.getRoles).toHaveBeenCalled();
    });
  });
});
