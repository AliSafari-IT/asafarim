import { describe, it, expect, vi, beforeEach } from "vitest";
import handleUpdateProfile from "../Accountpage/handleUpdateProfile";
import { updateUserProfile } from "@/api/authapi";
import { logger } from "@/utils/logger";

// Mock dependencies
vi.mock("@/api/authapi", () => ({
  updateUserProfile: vi.fn(),
}));

vi.mock("@/utils/logger", () => ({
  logger: {
    info: vi.fn(),
    error: vi.fn(),
  },
}));

describe("handleUpdateProfile", () => {
  const mockSetMessage = vi.fn();
  const mockSetLoading = vi.fn();
  const mockAuthenticatedUser = {
    id: "user123",
    email: "old@example.com",
    firstName: "Old",
    lastName: "Name",
  };
  
  beforeEach(() => {
    vi.clearAllMocks();
    
    // Mock localStorage
    Object.defineProperty(window, "localStorage", {
      value: {
        getItem: vi.fn().mockReturnValue(JSON.stringify({ token: "fake-token" })),
        setItem: vi.fn(),
        removeItem: vi.fn(),
      },
      writable: true,
    });
    
    // Mock sessionStorage
    Object.defineProperty(window, "sessionStorage", {
      value: {
        getItem: vi.fn().mockReturnValue(null),
        setItem: vi.fn(),
        removeItem: vi.fn(),
      },
      writable: true,
    });
    
    // Mock window.dispatchEvent
    window.dispatchEvent = vi.fn();
  });

  it("should update user profile successfully", async () => {
    (updateUserProfile as any).mockResolvedValue({ success: true });
    
    await handleUpdateProfile({
      authenticatedUser: mockAuthenticatedUser,
      firstName: "New",
      lastName: "User",
      email: "new@example.com",
      setMessage: mockSetMessage,
      setLoading: mockSetLoading,
    });
    
    // Check if loading state was managed correctly
    expect(mockSetLoading).toHaveBeenCalledWith(true);
    expect(mockSetLoading).toHaveBeenCalledWith(false);
    
    // Check if API was called with correct parameters
    expect(updateUserProfile).toHaveBeenCalledWith({
      id: "user123",
      firstName: "New",
      lastName: "User",
      email: "new@example.com",
    });
    
    // Check if success message was set
    expect(mockSetMessage).toHaveBeenCalledWith({
      type: "success",
      text: expect.stringContaining("Profile updated successfully"),
    });
    
    // Check if localStorage was updated
    expect(window.localStorage.setItem).toHaveBeenCalled();
    expect(window.dispatchEvent).toHaveBeenCalled();
  });

  it("should show error message when user data is invalid", async () => {
    await handleUpdateProfile({
      authenticatedUser: null as any,
      firstName: "New",
      lastName: "User",
      email: "new@example.com",
      setMessage: mockSetMessage,
      setLoading: mockSetLoading,
    });
    
    expect(mockSetMessage).toHaveBeenCalledWith({
      type: "error",
      text: "Invalid user data.",
    });
    expect(updateUserProfile).not.toHaveBeenCalled();
  });

  it("should show error message when auth data is not found", async () => {
    window.localStorage.getItem = vi.fn().mockReturnValue(null);
    window.sessionStorage.getItem = vi.fn().mockReturnValue(null);
    
    await handleUpdateProfile({
      authenticatedUser: mockAuthenticatedUser,
      firstName: "New",
      lastName: "User",
      email: "new@example.com",
      setMessage: mockSetMessage,
      setLoading: mockSetLoading,
    });
    
    expect(mockSetMessage).toHaveBeenCalledWith({
      type: "error",
      text: "Authentication data not found. Please log in again.",
    });
    expect(updateUserProfile).not.toHaveBeenCalled();
  });

  it("should show error message for invalid email format", async () => {
    await handleUpdateProfile({
      authenticatedUser: mockAuthenticatedUser,
      firstName: "New",
      lastName: "User",
      email: "invalid-email",
      setMessage: mockSetMessage,
      setLoading: mockSetLoading,
    });
    
    expect(mockSetMessage).toHaveBeenCalledWith({
      type: "error",
      text: expect.stringContaining("Please enter a valid email address"),
    });
    expect(updateUserProfile).not.toHaveBeenCalled();
  });

  it("should handle API errors", async () => {
    const errorMessage = "Profile update failed";
    (updateUserProfile as any).mockRejectedValue(new Error(errorMessage));
    
    await handleUpdateProfile({
      authenticatedUser: mockAuthenticatedUser,
      firstName: "New",
      lastName: "User",
      email: "new@example.com",
      setMessage: mockSetMessage,
      setLoading: mockSetLoading,
    });
    
    expect(mockSetMessage).toHaveBeenCalledWith({
      type: "error",
      text: expect.stringContaining("Failed to update profile"),
    });
    expect(logger.error).toHaveBeenCalled();
  });
});
