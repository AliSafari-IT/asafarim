import { render, screen, fireEvent, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import ResetPasswordPage from "../Accountpage/ResetPasswordPage";
import { useNavigate, useLocation } from "react-router-dom";
import { resetPassword } from "../../api/authapi";
import { logger } from "@/utils/logger";

// Mock dependencies
vi.mock("react-router-dom", () => ({
  useNavigate: vi.fn(),
  useLocation: vi.fn(),
  Link: ({ to, children }: { to: string; children: React.ReactNode }) => (
    <a href={to} data-testid={`link-to-${to}`}>{children}</a>
  ),
}));

vi.mock("../../api/authapi", () => ({
  resetPassword: vi.fn(),
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

describe("ResetPasswordPage Component", () => {
  const mockNavigate = vi.fn();
  
  beforeEach(() => {
    vi.clearAllMocks();
    (useNavigate as any).mockReturnValue(mockNavigate);
    (useLocation as any).mockReturnValue({
      search: "?token=test-token&email=test@example.com",
    });
  });

  it("renders reset password form with token and email from URL", () => {
    render(<ResetPasswordPage />);
    
    expect(screen.getByTestId("mock-wrapper")).toBeInTheDocument();
    expect(screen.getByText(/Reset Password/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/New Password/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Confirm Password/i)).toBeInTheDocument();
    expect(screen.getByRole("button", { name: /Reset Password/i })).toBeInTheDocument();
    expect(screen.getByText(/Back to Login/i)).toBeInTheDocument();
  });

  it("shows error when token or email is missing", () => {
    (useLocation as any).mockReturnValue({
      search: "",
    });
    
    render(<ResetPasswordPage />);
    
    const submitButton = screen.getByRole("button", { name: /Reset Password/i });
    fireEvent.click(submitButton);
    
    expect(screen.getByText(/Invalid reset link/i)).toBeInTheDocument();
    expect(resetPassword).not.toHaveBeenCalled();
  });

  it("shows error when passwords don't match", () => {
    render(<ResetPasswordPage />);
    
    fireEvent.change(screen.getByLabelText(/New Password/i), { target: { value: "NewPass123!" } });
    fireEvent.change(screen.getByLabelText(/Confirm Password/i), { target: { value: "DifferentPass123!" } });
    
    const submitButton = screen.getByRole("button", { name: /Reset Password/i });
    fireEvent.click(submitButton);
    
    expect(screen.getByText(/Passwords do not match/i)).toBeInTheDocument();
    expect(resetPassword).not.toHaveBeenCalled();
  });

  it("shows error when password doesn't meet complexity requirements", () => {
    render(<ResetPasswordPage />);
    
    fireEvent.change(screen.getByLabelText(/New Password/i), { target: { value: "simple" } });
    fireEvent.change(screen.getByLabelText(/Confirm Password/i), { target: { value: "simple" } });
    
    const submitButton = screen.getByRole("button", { name: /Reset Password/i });
    fireEvent.click(submitButton);
    
    expect(screen.getByText(/Password must be at least 8 characters/i)).toBeInTheDocument();
    expect(resetPassword).not.toHaveBeenCalled();
  });

  it("calls resetPassword API with correct data and redirects to login on success", async () => {
    (resetPassword as any).mockResolvedValue({ success: true });
    
    render(<ResetPasswordPage />);
    
    fireEvent.change(screen.getByLabelText(/New Password/i), { target: { value: "NewPass123!" } });
    fireEvent.change(screen.getByLabelText(/Confirm Password/i), { target: { value: "NewPass123!" } });
    
    const submitButton = screen.getByRole("button", { name: /Reset Password/i });
    fireEvent.click(submitButton);
    
    await waitFor(() => {
      expect(resetPassword).toHaveBeenCalledWith({
        email: "test@example.com",
        token: "test-token",
        newPassword: "NewPass123!",
      });
    });
    
    expect(screen.getByText(/Password has been reset successfully/i)).toBeInTheDocument();
    expect(mockNavigate).toHaveBeenCalledWith("/login");
  });

  it("shows error message when API call fails", async () => {
    const errorMessage = "Invalid or expired token";
    (resetPassword as any).mockRejectedValue({
      response: {
        status: 400,
        data: { message: errorMessage },
      },
    });
    
    render(<ResetPasswordPage />);
    
    fireEvent.change(screen.getByLabelText(/New Password/i), { target: { value: "NewPass123!" } });
    fireEvent.change(screen.getByLabelText(/Confirm Password/i), { target: { value: "NewPass123!" } });
    
    const submitButton = screen.getByRole("button", { name: /Reset Password/i });
    fireEvent.click(submitButton);
    
    await waitFor(() => {
      expect(screen.getByText(errorMessage)).toBeInTheDocument();
    });
    
    expect(logger.error).toHaveBeenCalled();
  });

  it("navigates to login page when clicking back to login", () => {
    render(<ResetPasswordPage />);
    
    const backToLoginLink = screen.getByText(/Back to Login/i);
    fireEvent.click(backToLoginLink);
    
    expect(mockNavigate).toHaveBeenCalledWith("/login");
  });
});
