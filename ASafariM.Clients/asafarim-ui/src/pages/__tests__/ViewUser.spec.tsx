import { render, screen, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import ViewUser from "../User/ViewUser";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import { AuthProvider } from "@/contexts/AuthContext";
import { ThemeProvider } from "@/contexts/ThemeContext";
import * as userService from "@/api/userService";
import { IUser, IUserRole, IRoleEnum, IApiResponse, IRole } from "@/interfaces";
import { ReactNode } from "react";
import React from "react";

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

// Mock localStorage
Object.defineProperty(window, 'localStorage', {
  value: {
    getItem: vi.fn(() => JSON.stringify({ token: 'fake-token' })),
    setItem: vi.fn(),
    removeItem: vi.fn()
  },
  writable: true
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

// Mock the router hooks
vi.mock("react-router-dom", async () => {
  const actual = await vi.importActual("react-router-dom");
  return {
    ...actual,
    useParams: () => ({ id: "123" }),
    useNavigate: () => vi.fn()
  };
});

// Mock user data
const mockUser: IUser = {
  id: "123",
  firstName: "John",
  lastName: "Doe",
  email: "john@example.com",
  userName: "johndoe",
  dateOfBirth: "1990-01-01",
  isAdmin: false,
  isActive: true,
  isDeleted: false,
  profilePicture: "",
  createdAt: "2023-01-01T00:00:00Z",
  updatedAt: "2023-01-01T00:00:00Z",
  roles: ["1"]
};

// Mock roles data
const mockRoles: IRole[] = [
  { id: "1", name: "User" },
  { id: "2", name: "Admin" }
];

// Mock user roles
const mockUserRoles: IUserRole[] = [
  { userId: "123", roleId: "1", role: IRoleEnum.StandardUser }
];

// Mock the components used by Wrapper to avoid context issues
vi.mock("@/layout/Wrapper/Wrapper", () => ({
  default: ({ children, header, footer, error }: { children: ReactNode; header?: ReactNode; footer?: ReactNode; error?: string }) => (
    <div data-testid="mocked-wrapper">
      {header}
      {error && <div>{error}</div>}
      <div data-testid="wrapper-content">{children}</div>
      {footer}
    </div>
  )
}));

vi.mock("@/layout/Footer/Footer", () => ({
  default: () => <div data-testid="mocked-footer">Footer Content</div>
}));

vi.mock("@/layout/Header/Header", () => ({
  default: () => <div data-testid="mocked-header">Header Content</div>
}));

vi.mock("@/layout/Navbar/ModernNavbar", () => ({
  default: () => <div data-testid="mocked-navbar">Navbar Content</div>
}));

// Mock the userService module
vi.mock("@/api/userService", () => ({
  getUserById: vi.fn(),
  getRoles: vi.fn(),
  getRolesByUserId: vi.fn()
}));

beforeEach(() => {
  vi.clearAllMocks();
  
  // Mock getUserById
  vi.mocked(userService.getUserById).mockResolvedValue(mockUser);
  
  // Mock getRoles
  vi.mocked(userService.getRoles).mockImplementation(() => {
    const apiResponse: IApiResponse<IRole> = {
      $values: mockRoles
    };
    return Promise.resolve(apiResponse as any);
  });
  
  // Mock getRolesByUserId
  vi.mocked(userService.getRolesByUserId).mockImplementation((userId: string) => {
    const roles = mockUserRoles.filter(role => role.userId === userId);
    const apiResponse: IApiResponse<IUserRole> = {
      $values: roles
    };
    return Promise.resolve(apiResponse as any);
  });
});

describe("ViewUser", () => {
  it("renders loading state initially", () => {
    render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <Routes>
              <Route path="/" element={<ViewUser />} />
            </Routes>
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    expect(screen.getByTestId("wrapper-content").querySelector(".animate-spin")).toBeInTheDocument();
  });

  it("displays user avatar initials when no profile picture", async () => {
    render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <Routes>
              <Route path="/" element={<ViewUser />} />
            </Routes>
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      const avatarElement = screen.getByText("JD");
      expect(avatarElement).toBeInTheDocument();
    });
  });

  it("displays profile picture when available", async () => {
    const userWithPicture = {
      ...mockUser,
      profilePicture: "https://example.com/profile.jpg"
    };
    
    vi.mocked(userService.getUserById).mockResolvedValue(userWithPicture);

    render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <Routes>
              <Route path="/" element={<ViewUser />} />
            </Routes>
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      const profileImage = screen.getByAltText("John Doe");
      expect(profileImage).toBeInTheDocument();
      expect(profileImage).toHaveAttribute("src", "https://example.com/profile.jpg");
    });
  });

  it("handles error when user data cannot be loaded", async () => {
    vi.mocked(userService.getUserById).mockRejectedValue(new Error("Failed to fetch user"));

    render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <Routes>
              <Route path="/" element={<ViewUser />} />
            </Routes>
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      expect(screen.getByText(/User not found/i)).toBeInTheDocument();
    });
  });
});
