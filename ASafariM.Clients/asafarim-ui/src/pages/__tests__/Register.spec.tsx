import { render, screen, fireEvent, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import Register from "../Accountpage/Register";
import { useNavigate } from "react-router-dom";
import { register as registerApi } from "../../api/authapi";
import { logger } from "@/utils/logger";

// Mock dependencies
vi.mock("react-router-dom", () => ({
  useNavigate: vi.fn(),
  Link: ({ to, children }: { to: string; children: React.ReactNode }) => (
    <a href={to} data-testid={`link-to-${to}`}>{children}</a>
  ),
}));

vi.mock("../../api/authapi", () => ({
  register: vi.fn(),
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

describe("Register Component", () => {
  const mockNavigate = vi.fn();
  
  beforeEach(() => {
    vi.clearAllMocks();
    (useNavigate as any).mockReturnValue(mockNavigate);
  });

  it("renders registration form", () => {
    render(<Register />);
    
    expect(screen.getByTestId("mock-wrapper")).toBeInTheDocument();
    expect(screen.getByText(/Create an Account/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/First Name/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Last Name/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Username/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Email/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Password/i)).toBeInTheDocument();
    expect(screen.getByRole("button", { name: /Register/i })).toBeInTheDocument();
    expect(screen.getByText(/Already have an account/i)).toBeInTheDocument();
  });

  it("shows error when submitting with missing required fields", async () => {
    render(<Register />);
    
    const submitButton = screen.getByRole("button", { name: /Register/i });
    fireEvent.click(submitButton);
    
    expect(screen.getByText(/All fields are required/i)).toBeInTheDocument();
    expect(registerApi).not.toHaveBeenCalled();
  });

  it("shows error for invalid email format", async () => {
    render(<Register />);
    
    // Fill in all fields except email with invalid format
    fireEvent.change(screen.getByLabelText(/First Name/i), { target: { value: "John" } });
    fireEvent.change(screen.getByLabelText(/Last Name/i), { target: { value: "Doe" } });
    fireEvent.change(screen.getByLabelText(/Username/i), { target: { value: "johndoe" } });
    fireEvent.change(screen.getByLabelText(/Email/i), { target: { value: "invalid-email" } });
    fireEvent.change(screen.getByLabelText(/Password/i), { target: { value: "password123" } });
    
    const submitButton = screen.getByRole("button", { name: /Register/i });
    fireEvent.click(submitButton);
    
    expect(screen.getByText(/Please enter a valid email address/i)).toBeInTheDocument();
    expect(registerApi).not.toHaveBeenCalled();
  });

  it("shows error for password too short", async () => {
    render(<Register />);
    
    // Fill in all fields with short password
    fireEvent.change(screen.getByLabelText(/First Name/i), { target: { value: "John" } });
    fireEvent.change(screen.getByLabelText(/Last Name/i), { target: { value: "Doe" } });
    fireEvent.change(screen.getByLabelText(/Username/i), { target: { value: "johndoe" } });
    fireEvent.change(screen.getByLabelText(/Email/i), { target: { value: "john@example.com" } });
    fireEvent.change(screen.getByLabelText(/Password/i), { target: { value: "short" } });
    
    const submitButton = screen.getByRole("button", { name: /Register/i });
    fireEvent.click(submitButton);
    
    expect(screen.getByText(/Password must be at least 6 characters long/i)).toBeInTheDocument();
    expect(registerApi).not.toHaveBeenCalled();
  });

  it("shows error for username too short", async () => {
    render(<Register />);
    
    // Fill in all fields with short username
    fireEvent.change(screen.getByLabelText(/First Name/i), { target: { value: "John" } });
    fireEvent.change(screen.getByLabelText(/Last Name/i), { target: { value: "Doe" } });
    fireEvent.change(screen.getByLabelText(/Username/i), { target: { value: "jo" } });
    fireEvent.change(screen.getByLabelText(/Email/i), { target: { value: "john@example.com" } });
    fireEvent.change(screen.getByLabelText(/Password/i), { target: { value: "password123" } });
    
    const submitButton = screen.getByRole("button", { name: /Register/i });
    fireEvent.click(submitButton);
    
    expect(screen.getByText(/Username must be at least 3 characters long/i)).toBeInTheDocument();
    expect(registerApi).not.toHaveBeenCalled();
  });

  it("calls register API with correct data and shows success message", async () => {
    (registerApi as any).mockResolvedValue({ success: true });
    
    render(<Register />);
    
    // Fill in all fields correctly
    fireEvent.change(screen.getByLabelText(/First Name/i), { target: { value: "John" } });
    fireEvent.change(screen.getByLabelText(/Last Name/i), { target: { value: "Doe" } });
    fireEvent.change(screen.getByLabelText(/Username/i), { target: { value: "johndoe" } });
    fireEvent.change(screen.getByLabelText(/Email/i), { target: { value: "john@example.com" } });
    fireEvent.change(screen.getByLabelText(/Password/i), { target: { value: "password123" } });
    
    const submitButton = screen.getByRole("button", { name: /Register/i });
    fireEvent.click(submitButton);
    
    await waitFor(() => {
      expect(registerApi).toHaveBeenCalledWith({
        email: "john@example.com",
        password: "password123",
        firstName: "John",
        lastName: "Doe",
        userName: "johndoe",
        isAdmin: false,
        dateOfBirth: undefined,
        profilePicture: undefined
      });
    });
    
    expect(screen.getByText(/Registration successful/i)).toBeInTheDocument();
  });

  it("shows error message when API call fails", async () => {
    const errorMessage = "Email already in use";
    (registerApi as any).mockRejectedValue({
      response: {
        status: 400,
        data: { message: errorMessage },
      },
    });
    
    render(<Register />);
    
    // Fill in all fields correctly
    fireEvent.change(screen.getByLabelText(/First Name/i), { target: { value: "John" } });
    fireEvent.change(screen.getByLabelText(/Last Name/i), { target: { value: "Doe" } });
    fireEvent.change(screen.getByLabelText(/Username/i), { target: { value: "johndoe" } });
    fireEvent.change(screen.getByLabelText(/Email/i), { target: { value: "john@example.com" } });
    fireEvent.change(screen.getByLabelText(/Password/i), { target: { value: "password123" } });
    
    const submitButton = screen.getByRole("button", { name: /Register/i });
    fireEvent.click(submitButton);
    
    await waitFor(() => {
      expect(screen.getByText(errorMessage)).toBeInTheDocument();
    });
    
    expect(logger.error).toHaveBeenCalled();
  });

  it("navigates to login page when clicking login link", () => {
    render(<Register />);
    
    const loginLink = screen.getByText(/Sign in/i);
    fireEvent.click(loginLink);
    
    expect(mockNavigate).toHaveBeenCalledWith("/login");
  });
});
