import { render, screen, fireEvent, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import ForgotPasswordPage from "../Accountpage/ForgotPasswordPage";
import { useNavigate } from "react-router-dom";
import { requestPasswordReset } from "../../api/authapi";
import { logger } from "@/utils/logger";

// Mock dependencies
vi.mock("react-router-dom", () => ({
  useNavigate: vi.fn(),
  Link: ({ to, children }: { to: string; children: React.ReactNode }) => (
    <a href={to} data-testid={`link-to-${to}`}>{children}</a>
  ),
}));

vi.mock("../../api/authapi", () => ({
  requestPasswordReset: vi.fn(),
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

describe("ForgotPasswordPage Component", () => {
  const mockNavigate = vi.fn();
  
  beforeEach(() => {
    vi.clearAllMocks();
    (useNavigate as any).mockReturnValue(mockNavigate);
  });

  it("renders forgot password form", () => {
    render(<ForgotPasswordPage />);
    
    expect(screen.getByTestId("mock-wrapper")).toBeInTheDocument();
    expect(screen.getByText(/Forgot Password/i)).toBeInTheDocument();
    expect(screen.getByPlaceholderText(/Enter your email/i)).toBeInTheDocument();
    expect(screen.getByRole("button", { name: /Reset Password/i })).toBeInTheDocument();
    expect(screen.getByText(/Back to Login/i)).toBeInTheDocument();
  });

  it("shows error when submitting without email", async () => {
    render(<ForgotPasswordPage />);
    
    const submitButton = screen.getByRole("button", { name: /Reset Password/i });
    fireEvent.click(submitButton);
    
    expect(screen.getByText(/Email is required/i)).toBeInTheDocument();
    expect(requestPasswordReset).not.toHaveBeenCalled();
  });

  it("calls requestPasswordReset API with correct email", async () => {
    (requestPasswordReset as any).mockResolvedValue({ success: true });
    
    render(<ForgotPasswordPage />);
    
    const emailInput = screen.getByPlaceholderText(/Enter your email/i);
    fireEvent.change(emailInput, { target: { value: "test@example.com" } });
    
    const submitButton = screen.getByRole("button", { name: /Reset Password/i });
    fireEvent.click(submitButton);
    
    await waitFor(() => {
      expect(requestPasswordReset).toHaveBeenCalledWith("test@example.com");
    });
    
    expect(screen.getByText(/Password reset instructions have been sent/i)).toBeInTheDocument();
  });

  it("shows error message when API call fails", async () => {
    const errorMessage = "Email not found";
    (requestPasswordReset as any).mockRejectedValue({
      response: {
        status: 404,
        data: { message: errorMessage },
      },
    });
    
    render(<ForgotPasswordPage />);
    
    const emailInput = screen.getByPlaceholderText(/Enter your email/i);
    fireEvent.change(emailInput, { target: { value: "nonexistent@example.com" } });
    
    const submitButton = screen.getByRole("button", { name: /Reset Password/i });
    fireEvent.click(submitButton);
    
    await waitFor(() => {
      expect(screen.getByText(errorMessage)).toBeInTheDocument();
    });
    
    expect(logger.error).toHaveBeenCalled();
  });

  it("navigates to login page when clicking back to login", () => {
    render(<ForgotPasswordPage />);
    
    const backToLoginLink = screen.getByText(/Back to Login/i);
    fireEvent.click(backToLoginLink);
    
    expect(mockNavigate).toHaveBeenCalledWith("/login");
  });

  it("clears email field after successful submission", async () => {
    (requestPasswordReset as any).mockResolvedValue({ success: true });
    
    render(<ForgotPasswordPage />);
    
    const emailInput = screen.getByPlaceholderText(/Enter your email/i);
    fireEvent.change(emailInput, { target: { value: "test@example.com" } });
    
    const submitButton = screen.getByRole("button", { name: /Reset Password/i });
    fireEvent.click(submitButton);
    
    await waitFor(() => {
      expect(emailInput).toHaveValue("");
    });
  });
});
