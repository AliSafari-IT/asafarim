import { render, screen, fireEvent, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import LoginPage from "../Accountpage/LoginPage";
import { useNavigate } from "react-router-dom";
import { login } from "../../api/authapi";
import { logger } from "@/utils/logger";

// Mocks
vi.mock("react-router-dom", () => ({
  useNavigate: vi.fn(),
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
  default: ({ email }: { email: string }) => (
    <div data-testid="deleted-account-message">Deleted: {email}</div>
  ),
}));

describe("LoginPage", () => {
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
    window.location.href = "/";
  });

  it("renders login form", () => {
    render(<LoginPage />);
    expect(screen.getByTestId("email-input")).toBeInTheDocument();
    expect(screen.getByTestId("password-input")).toBeInTheDocument();
    expect(screen.getByTestId("login-button")).toBeInTheDocument();
  });

  it("shows error when fields are empty", () => {
    render(<LoginPage />);
    fireEvent.click(screen.getByTestId("login-button"));
    expect(screen.getByTestId("login-error-message")).toHaveTextContent(
      "Email and password are required"
    );
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

  it("handles successful login with remember me", async () => {
    (login as any).mockResolvedValue({
      authenticated: true,
      authenticatedUser: { email: "test@example.com" },
      token: "abc123",
    });

    render(<LoginPage />);
    fireEvent.change(screen.getByTestId("email-input"), {
      target: { value: "test@example.com" },
    });
    fireEvent.change(screen.getByTestId("password-input"), {
      target: { value: "pass123" },
    });
    fireEvent.click(screen.getByTestId("remember-me-checkbox"));
    fireEvent.click(screen.getByTestId("login-button"));

    await waitFor(() => {
      expect(login).toHaveBeenCalled();
      expect(window.localStorage.setItem).toHaveBeenCalledWith(
        "auth",
        expect.any(String)
      );
      expect(window.dispatchEvent).toHaveBeenCalled();
    });
  });

  it("handles successful login without remember me", async () => {
    (login as any).mockResolvedValue({
      authenticated: true,
      authenticatedUser: { email: "test@example.com" },
      token: "abc123",
    });

    render(<LoginPage />);
    fireEvent.change(screen.getByTestId("email-input"), {
      target: { value: "test@example.com" },
    });
    fireEvent.change(screen.getByTestId("password-input"), {
      target: { value: "pass123" },
    });
    fireEvent.click(screen.getByTestId("login-button"));

    await waitFor(() => {
      expect(login).toHaveBeenCalled();
      expect(window.sessionStorage.setItem).toHaveBeenCalled();
      expect(window.dispatchEvent).toHaveBeenCalled();
    });
  });

  it("shows deleted account message", async () => {
    (login as any).mockResolvedValue({
      authenticated: true,
      authenticatedUser: { isDeleted: true, email: "deleted@example.com" },
      token: "deleted-token",
    });

    render(<LoginPage />);
    fireEvent.change(screen.getByTestId("email-input"), {
      target: { value: "deleted@example.com" },
    });
    fireEvent.change(screen.getByTestId("password-input"), {
      target: { value: "password" },
    });
    fireEvent.click(screen.getByTestId("login-button"));

    await waitFor(() => {
      expect(screen.getByTestId("deleted-account-message")).toBeInTheDocument();
    });
  });

  it("displays error from failed login", async () => {
    (login as any).mockRejectedValue({
      response: {
        status: 401,
        data: { message: "Invalid credentials." },
      },
    });

    render(<LoginPage />);
    fireEvent.change(screen.getByTestId("email-input"), {
      target: { value: "wrong@example.com" },
    });
    fireEvent.change(screen.getByTestId("password-input"), {
      target: { value: "wrongpass" },
    });
    fireEvent.click(screen.getByTestId("login-button"));

    await waitFor(() => {
      expect(screen.getByTestId("login-error-message")).toHaveTextContent(
        "Invalid credentials."
      );
    });
  });
});
