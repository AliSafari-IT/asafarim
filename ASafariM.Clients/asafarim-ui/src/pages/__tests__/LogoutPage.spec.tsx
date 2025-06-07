import { render, screen, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import LogoutPage from "../Accountpage/LogoutPage";
import { useNavigate } from "react-router-dom";
import { useAuth } from "@/contexts/AuthContext";
import { logger } from "@/utils/logger";

// Mock dependencies
vi.mock("react-router-dom", () => ({
  useNavigate: vi.fn(),
}));

vi.mock("@/contexts/AuthContext", () => ({
  useAuth: vi.fn(),
}));

vi.mock("@/utils/logger", () => ({
  logger: {
    info: vi.fn(),
    error: vi.fn(),
  },
}));

describe("LogoutPage Component", () => {
  const mockNavigate = vi.fn();
  const mockLogout = vi.fn();
  
  beforeEach(() => {
    vi.clearAllMocks();
    (useNavigate as any).mockReturnValue(mockNavigate);
    (useAuth as any).mockReturnValue({ logout: mockLogout });
    
    // Mock localStorage
    Object.defineProperty(window, "localStorage", {
      value: {
        getItem: vi.fn().mockReturnValue("/dashboard"),
        removeItem: vi.fn(),
      },
      writable: true,
    });
  });

  it("renders logout message", () => {
    render(<LogoutPage />);
    
    expect(screen.getByText(/Logging out.../i)).toBeInTheDocument();
    expect(screen.getByText(/Please wait while we log you out./i)).toBeInTheDocument();
  });

  it("calls logout function and redirects to previous location", async () => {
    mockLogout.mockResolvedValue(undefined);
    
    render(<LogoutPage />);
    
    await waitFor(() => {
      expect(mockLogout).toHaveBeenCalled();
      expect(localStorage.removeItem).toHaveBeenCalledWith("returnTo");
      expect(mockNavigate).toHaveBeenCalledWith("/dashboard", { replace: true });
      expect(logger.info).toHaveBeenCalledWith("User logged out successfully");
    });
  });

  it("redirects to home when no previous location is stored", async () => {
    mockLogout.mockResolvedValue(undefined);
    localStorage.getItem = vi.fn().mockReturnValue(null);
    
    render(<LogoutPage />);
    
    await waitFor(() => {
      expect(mockLogout).toHaveBeenCalled();
      expect(mockNavigate).toHaveBeenCalledWith("/", { replace: true });
    });
  });

  it("redirects to login page when logout fails", async () => {
    const error = new Error("Logout failed");
    mockLogout.mockRejectedValue(error);
    
    render(<LogoutPage />);
    
    await waitFor(() => {
      expect(mockLogout).toHaveBeenCalled();
      expect(logger.error).toHaveBeenCalledWith(expect.stringContaining("Error during logout"));
      expect(mockNavigate).toHaveBeenCalledWith("/login", { replace: true });
    });
  });
});
