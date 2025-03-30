import { render, screen, fireEvent, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import LoginPage from "../Accountpage/LoginPage";
import { useNavigate } from "react-router-dom";
import { login } from "../../api/authapi";
import { logger } from "@/utils/logger";

// Mock dependencies
vi.mock("react-router-dom", () => ({
  useNavigate: vi.fn(),
  Link: ({ to, children }: { to: string; children: React.ReactNode }) => (
    <a href={to} data-testid={`link-to-${to}`}>{children}</a>
  ),
}));

vi.mock("../../api/authapi", () => ({
  login: vi.fn(),
}));

vi.mock("@/utils/logger", () => ({
  logger: {
    info: vi.fn(),
    error: vi.fn(),
  },
}));

vi.mock("../../layout/Wrapper/Wrapper", () => ({
  default: ({ children }: { children: React.ReactNode }) => (
    <div data-testid="mock-wrapper">{children}</div>
  ),
}));

vi.mock("../../components/DeletedAccountMessage", () => ({
  default: () => <div data-testid="deleted-account-message">Account deleted message</div>,
}));

describe("LoginPage Component", () => {
  const mockNavigate = vi.fn();

  beforeEach(() => {
    vi.clearAllMocks();
    (useNavigate as any).mockReturnValue(mockNavigate);

    Object.defineProperty(window, "localStorage", {
      value: {
        getItem: vi.fn(),
        setItem: vi.fn(),
        removeItem: vi.fn(),
      },
      writable: true,
    });

    Object.defineProperty(window, "sessionStorage", {
      value: {
        getItem: vi.fn(),
        setItem: vi.fn(),
        removeItem: vi.fn(),
      },
      writable: true,
    });

    window.dispatchEvent = vi.fn();
  });

  it("renders login form", () => {
    render(<LoginPage />);
    expect(screen.getByTestId("mock-wrapper")).toBeInTheDocument();
    expect(screen.getByTestId("login-heading")).toBeInTheDocument();
    expect(screen.getByTestId("email-input")).toBeInTheDocument();
    expect(screen.getByTestId("password-input")).toBeInTheDocument();
    expect(screen.getByTestId("login-button")).toBeInTheDocument();
    expect(screen.getByTestId("forgot-password-link")).toBeInTheDocument();
    expect(screen.getByTestId("register-link")).toBeInTheDocument();
  });

  it("shows error when fields are empty", async () => {
    render(<LoginPage />);
    
    // Submit the form with empty fields
    const form = screen.getByRole('form');
    fireEvent.submit(form);

    await waitFor(() => {
      expect(screen.getByTestId("login-error-message")).toHaveTextContent(
        "Email and password are required"
      );
    });
  });

  it("handles successful login with remember me", async () => {
    const mockAuthResponse = {
      token: "fake-token",
      authenticatedUser: {
        id: "user123",
        email: "test@example.com",
        firstName: "Test",
        lastName: "User",
      },
      authenticated: true,
    };

    (login as any).mockResolvedValue(mockAuthResponse);

    render(<LoginPage />);
    fireEvent.change(screen.getByTestId("email-input"), { target: { value: "test@example.com" } });
    fireEvent.change(screen.getByTestId("password-input"), { target: { value: "password123" } });
    fireEvent.click(screen.getByTestId("remember-me-checkbox"));
    fireEvent.click(screen.getByTestId("login-button"));

    await waitFor(() => {
      expect(login).toHaveBeenCalledWith({
        email: "test@example.com",
        password: "password123",
      });
      expect(window.localStorage.setItem).toHaveBeenCalled();
      expect(window.dispatchEvent).toHaveBeenCalled();
    });
  });

  it("handles successful login without remember me", async () => {
    const mockAuthResponse = {
      token: "fake-token",
      authenticatedUser: {
        id: "user123",
        email: "test@example.com",
        firstName: "Test",
        lastName: "User",
      },
      authenticated: true,
    };

    (login as any).mockResolvedValue(mockAuthResponse);

    render(<LoginPage />);
    fireEvent.change(screen.getByTestId("email-input"), { target: { value: "test@example.com" } });
    fireEvent.change(screen.getByTestId("password-input"), { target: { value: "password123" } });
    fireEvent.click(screen.getByTestId("login-button"));

    await waitFor(() => {
      expect(login).toHaveBeenCalled();
      expect(window.sessionStorage.setItem).toHaveBeenCalled();
    });
  });

  it("displays error from failed login", async () => {
    const errorMessage = "Invalid credentials.";
    (login as any).mockRejectedValue({
      isAxiosError: true,
      response: {
        status: 401,
        data: { message: errorMessage },
      }
    });

    render(<LoginPage />);
    fireEvent.change(screen.getByTestId("email-input"), { target: { value: "wrong@example.com" } });
    fireEvent.change(screen.getByTestId("password-input"), { target: { value: "wrongpass" } });
    fireEvent.click(screen.getByTestId("login-button"));

    await waitFor(() => {
      expect(screen.getByTestId("login-error-message")).toHaveTextContent(
        errorMessage
      );
      expect(logger.error).toHaveBeenCalled();
    });
  });

  it("navigates to register page", () => {
    render(<LoginPage />);
    fireEvent.click(screen.getByTestId("register-link"));
    expect(mockNavigate).toHaveBeenCalledWith("/register");
  });

  it("navigates to forgot password page", () => {
    render(<LoginPage />);
    fireEvent.click(screen.getByTestId("forgot-password-link"));
    expect(mockNavigate).toHaveBeenCalledWith("/forgot-password");
  });

  it("handles demo login button click", async () => {
    const mockAuthResponse = {
      token: "demo-token",
      authenticatedUser: {
        id: "demo-id",
        email: "demo_admin@example.com",
        firstName: "Demo",
        lastName: "Admin",
      },
      authenticated: true,
    };

    (login as any).mockResolvedValue(mockAuthResponse);

    render(<LoginPage />);
    fireEvent.click(screen.getByTestId("demo-login-demo-admin"));

    await waitFor(() => {
      expect(login).toHaveBeenCalledWith({
        email: "demo_admin@example.com",
        password: "Demo+123456/",
      });
      expect(window.localStorage.setItem).toHaveBeenCalled();
    });
  });

  it("shows deleted account message", async () => {
    const mockDeletedResponse = {
      token: "deleted-token",
      authenticatedUser: {
        id: "deleted-id",
        email: "deleted@example.com",
        firstName: "Deleted",
        lastName: "User",
        isDeleted: true,
      },
      authenticated: true,
    };

    (login as any).mockResolvedValue(mockDeletedResponse);

    render(<LoginPage />);
    fireEvent.change(screen.getByTestId("email-input"), { target: { value: "deleted@example.com" } });
    fireEvent.change(screen.getByTestId("password-input"), { target: { value: "deletedpass" } });
    fireEvent.click(screen.getByTestId("login-button"));

    await waitFor(() => {
      expect(screen.getByTestId("deleted-account-message")).toBeInTheDocument();
    });
  });
});
