import { render, screen, fireEvent } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import ResetPasswordPage from "../Accountpage/ResetPasswordPage";
import { useNavigate, useLocation } from "react-router-dom";
import { resetPassword } from "../../api/authapi";
import { logger } from "@/utils/logger";

// Mock dependencies
vi.mock("react-router-dom", () => ({
  useNavigate: vi.fn(),
  useLocation: vi.fn(),
}));

vi.mock("../../api/authapi", () => ({
  resetPassword: vi
    .fn()
    .mockImplementation(() => Promise.resolve({ success: true })),
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

describe("ResetPasswordPage", () => {
  const mockNavigate = vi.fn();

  beforeEach(() => {
    vi.clearAllMocks();
    vi.useFakeTimers();

    // Setup mocks
    vi.mocked(useNavigate).mockReturnValue(mockNavigate);
    vi.mocked(useLocation).mockReturnValue({
      search: "?token=test-token&email=test@example.com",
      pathname: "/reset-password",
      state: null,
      hash: "",
      key: "default",
    });
  });

  afterEach(() => {
    vi.useRealTimers();
  });

  it("renders the reset password form with email from URL", () => {
    render(<ResetPasswordPage />);

    expect(screen.getByTestId("reset-password-heading")).toBeInTheDocument();
    expect(screen.getByTestId("email-input")).toHaveValue("test@example.com");
    expect(screen.getByTestId("password-input")).toBeInTheDocument();
    expect(screen.getByTestId("confirm-password-input")).toBeInTheDocument();
    expect(screen.getByTestId("reset-password-button")).toBeInTheDocument();
  });

  it("navigates to login page when clicking back to login link", () => {
    render(<ResetPasswordPage />);

    fireEvent.click(screen.getByTestId("back-to-login-link"));

    expect(mockNavigate).toHaveBeenCalledWith("/login");
  });
});
