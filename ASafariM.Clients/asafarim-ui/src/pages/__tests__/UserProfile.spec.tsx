import { render, screen, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import UserProfile from "../User/UserProfile";
import { BrowserRouter } from "react-router-dom";
import { AuthProvider } from "@/contexts/AuthContext";
import * as userService from "@/api/userService";
import { IUser } from "@/interfaces";
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

// Mock the layout components
vi.mock('@/layout/Wrapper/Wrapper', () => ({
  default: ({ children, header, footer }: { children: ReactNode, header: ReactNode, footer: ReactNode }) => (
    <div data-testid="mock-wrapper">
      {header}
      <div data-testid="wrapper-content">{children}</div>
      {footer}
    </div>
  )
}));

vi.mock('@/layout/Header/Header', () => ({
  default: () => <div data-testid="mock-header">Header</div>
}));

vi.mock('@/layout/Footer/Footer', () => ({
  default: () => <div data-testid="mock-footer">Footer</div>
}));

// Mock the router hooks
vi.mock("react-router-dom", async () => {
  const actual = await vi.importActual("react-router-dom");
  return {
    ...actual,
    useNavigate: () => vi.fn()
  };
});

// Mock the auth context
vi.mock("@/contexts/AuthContext", async () => {
  const actual = await vi.importActual("@/contexts/AuthContext");
  return {
    ...actual,
    useAuth: () => ({
      authenticated: true,
      authenticatedUser: { id: "123" },
      token: "mock-token"
    })
  };
});

// Mock user service
vi.mock("@/api/userService");

describe("UserProfile", () => {
  const mockUser: IUser = {
    id: "123",
    firstName: "John",
    lastName: "Doe",
    email: "john@example.com",
    userName: "johndoe",
    isAdmin: false,
    isActive: true,
    isDeleted: false,
    profilePicture: "",
    lastLogin: "2025-03-29T12:00:00Z"
  };

  beforeEach(() => {
    vi.clearAllMocks();
    vi.mocked(userService.getUserById).mockResolvedValue(mockUser);
  });

  it("renders loading state initially", () => {
    render(
      <BrowserRouter>
        <AuthProvider>
          <UserProfile />
        </AuthProvider>
      </BrowserRouter>
    );

    // Look for the loading spinner
    expect(screen.getByTestId("wrapper-content").querySelector(".animate-spin")).toBeInTheDocument();
  });

  it("displays user avatar initials when no profile picture", async () => {
    render(
      <BrowserRouter>
        <AuthProvider>
          <UserProfile />
        </AuthProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      expect(screen.getByText("JD")).toBeInTheDocument();
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
          <UserProfile />
        </AuthProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      const profileImage = screen.getByAltText("John Doe");
      expect(profileImage).toBeInTheDocument();
      expect(profileImage).toHaveAttribute("src", "https://example.com/profile.jpg");
    });
  });

  it("displays error message when API call fails", async () => {
    vi.mocked(userService.getUserById).mockRejectedValue(new Error("API Error"));

    render(
      <BrowserRouter>
        <AuthProvider>
          <UserProfile />
        </AuthProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      expect(screen.getByText("Unable to fetch user information.")).toBeInTheDocument();
    });
  });

  it("displays user information correctly", async () => {
    render(
      <BrowserRouter>
        <AuthProvider>
          <UserProfile />
        </AuthProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      expect(screen.getByText("John Doe")).toBeInTheDocument();
      expect(screen.getByText("johndoe")).toBeInTheDocument();
      expect(screen.getByText("john@example.com")).toBeInTheDocument();
    });
  });

  it("shows deleted account warning when user is deleted", async () => {
    const deletedUser = {
      ...mockUser,
      isDeleted: true
    };
    
    vi.mocked(userService.getUserById).mockResolvedValue(deletedUser);

    render(
      <BrowserRouter>
        <AuthProvider>
          <UserProfile />
        </AuthProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      expect(screen.getByText(/Your account has been deleted/)).toBeInTheDocument();
    });
  });
});
