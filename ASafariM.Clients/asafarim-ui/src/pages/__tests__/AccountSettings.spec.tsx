import React from 'react';
import { render, screen, fireEvent, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import AccountSettings from "../Accountpage/AccountSettings";
import { useAuth } from "@/contexts/AuthContext";
import { updatePassword } from "@/api/authService";
import { useNavigate } from "react-router-dom";
import { logger } from "@/utils/logger";
import handleUpdateProfile from "../Accountpage/handleUpdateProfile";

// Mock dependencies
vi.mock("@/contexts/AuthContext", () => ({
  useAuth: vi.fn(),
}));

vi.mock("@/api/authService", () => ({
  updatePassword: vi.fn(),
}));

vi.mock("react-router-dom", () => ({
  useNavigate: vi.fn(),
}));

vi.mock("@/utils/logger", () => ({
  logger: {
    error: vi.fn(),
    log: vi.fn(),
    info: vi.fn(),
  },
}));

vi.mock("../Accountpage/handleUpdateProfile", () => ({
  default: vi.fn(),
}));

// Mock layout components
vi.mock("@/layout/Wrapper/Wrapper", () => ({
  default: ({ children }: { children: React.ReactNode }) => (
    <div data-testid="mock-wrapper">{children}</div>
  ),
}));

vi.mock("@/layout/Header/Header", () => ({
  default: () => <div data-testid="mock-header">Header</div>,
}));

vi.mock("@/layout/Footer/Footer", () => ({
  default: () => <div data-testid="mock-footer">Footer</div>,
}));

// Mock sub-components
vi.mock("../User/DeleteAccount", () => ({
  default: ({ currentUserInfo }: { currentUserInfo: any }) => (
    <div data-testid="mock-delete-account">Delete Account</div>
  ),
}));

vi.mock("../User/ExportData", () => ({
  default: ({ currentUserInfo }: { currentUserInfo: any }) => (
    <div data-testid="mock-export-data">Export Data</div>
  ),
}));

// Mock Notification component
vi.mock("@/components/Notification/Notification", () => ({
  default: ({ type, text }: { type: string; text: string }) => (
    <div data-testid={`notification-${type}`}>{text}</div>
  ),
}));

// Mock TabPane with a simpler implementation
vi.mock("@/components/Containers/Tab/TabPane", () => ({
  default: ({ tabs, onTabChange }: { tabs: any[]; onTabChange: any }) => (
    <div data-testid="mock-tab-pane">
      <div className="tab-headers">
        {tabs.map((tab) => (
          <div key={tab.key} onClick={() => onTabChange?.(tab.key)}>
            {tab.title}
          </div>
        ))}
      </div>
      <div className="tab-content">
        {tabs.map(tab => (
          <div key={tab.key} data-testid={`tab-content-${tab.key}`}>
            {tab.content}
          </div>
        ))}
      </div>
    </div>
  ),
}));

vi.mock("@/components/InputField/InputField", () => ({
  default: ({
    label,
    value,
    onChange,
    type = "text",
  }: {
    label: string;
    value: string;
    onChange: any;
    type?: string;
  }) => (
    <input
      data-testid={`input-field-${label.toLowerCase().replace(/\s+/g, "-")}`}
      type={type}
      value={value}
      onChange={onChange}
      placeholder={`Enter ${label.toLowerCase()}`}
    />
  ),
}));

describe("AccountSettings Component", () => {
  const mockNavigate = vi.fn();
  const mockAuthenticatedUser = {
    id: "user123",
    email: "test@example.com",
    firstName: "Test",
    lastName: "User",
  };

  beforeEach(() => {
    vi.clearAllMocks();
    (useNavigate as any).mockReturnValue(mockNavigate);
    (useAuth as any).mockReturnValue({
      authenticatedUser: mockAuthenticatedUser,
      authenticated: true,
    });

    // Mock localStorage and window.dispatchEvent
    Object.defineProperty(window, 'localStorage', {
      value: {
        getItem: vi.fn(() => '{}'),
        setItem: vi.fn(),
      },
      writable: true
    });
    window.dispatchEvent = vi.fn();
  });

  it("updates password successfully", async () => {
    (updatePassword as any).mockResolvedValue({});
    
    render(<AccountSettings />);
    
    // Navigate to password tab
    const passwordTabButton = screen.getByText("Password Settings");
    fireEvent.click(passwordTabButton);
    
    // Fill in password fields
    const currentPasswordInput = screen.getByTestId("input-field-current-password");
    const newPasswordInput = screen.getByTestId("input-field-new-password");
    
    fireEvent.change(currentPasswordInput, { target: { value: "oldPassword123" } });
    fireEvent.change(newPasswordInput, { target: { value: "newPassword123" } });
    
    // Find the update password button and click it
    const updatePasswordButton = screen.getByTestId("update-password-button");
    fireEvent.click(updatePasswordButton);
    
    // Check if updatePassword was called with correct parameters
    await waitFor(() => {
      expect(updatePassword).toHaveBeenCalledWith({
        Id: mockAuthenticatedUser.id,
        currentPassword: "oldPassword123",
        newPassword: "newPassword123",
      });
    });
    
    // Check for success message
    await waitFor(() => {
      const notification = screen.getByText("Password updated successfully.");
      expect(notification).toBeInTheDocument();
    });
    
    // Verify localStorage and dispatchEvent were called
    expect(localStorage.setItem).toHaveBeenCalled();
    expect(window.dispatchEvent).toHaveBeenCalled();
  });

  it("shows error message when password update fails", async () => {
    (updatePassword as any).mockRejectedValue(new Error("Failed to update password"));
    
    render(<AccountSettings />);
    
    // Navigate to password tab
    const passwordTabButton = screen.getByText("Password Settings");
    fireEvent.click(passwordTabButton);
    
    // Fill in password fields
    const currentPasswordInput = screen.getByTestId("input-field-current-password");
    const newPasswordInput = screen.getByTestId("input-field-new-password");
    
    fireEvent.change(currentPasswordInput, { target: { value: "oldPassword123" } });
    fireEvent.change(newPasswordInput, { target: { value: "newPassword123" } });
    
    // Find the update password button and click it
    const updatePasswordButton = screen.getByTestId("update-password-button");
    fireEvent.click(updatePasswordButton);
    
    // Check if updatePassword was called with correct parameters
    await waitFor(() => {
      expect(updatePassword).toHaveBeenCalledWith({
        Id: mockAuthenticatedUser.id,
        currentPassword: "oldPassword123",
        newPassword: "newPassword123",
      });
    });
    
    // Check for error message
    await waitFor(() => {
      const notification = screen.getByText("Failed to update password.");
      expect(notification).toBeInTheDocument();
    });
    expect(logger.error).toHaveBeenCalled();
  });
});
