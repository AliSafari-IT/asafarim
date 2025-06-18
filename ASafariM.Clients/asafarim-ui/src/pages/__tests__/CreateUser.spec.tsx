import { render, screen, fireEvent, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import CreateUser from "../User/CreateUser";
import { BrowserRouter } from "react-router-dom";
import { AuthProvider } from "@/contexts/AuthContext";
import { ThemeProvider } from "@/contexts/ThemeContext";
import { ReactNode } from "react";
import { IField } from "@/interfaces";

// Import the module to mock
import * as userManagerApi from "@/api/userManagerApi";
import React from "react";

// Mock axios before any imports that use it
vi.mock("axios", () => {
  // Create a mock axios instance with interceptors
  const mockAxiosInstance = {
    interceptors: {
      request: { use: vi.fn(), eject: vi.fn() },
      response: { use: vi.fn(), eject: vi.fn() },
    },
    get: vi.fn().mockResolvedValue({ data: { isAvailable: true } }),
    post: vi.fn().mockResolvedValue({ data: { success: true } }),
    put: vi.fn().mockResolvedValue({ data: {} }),
    delete: vi.fn().mockResolvedValue({ data: {} }),
    defaults: { headers: { common: {} } },
  };

  return {
    default: {
      create: vi.fn(() => mockAxiosInstance),
      isAxiosError: vi.fn(),
      get: vi.fn().mockResolvedValue({ data: { isAvailable: true } }),
      post: vi.fn().mockResolvedValue({ data: { success: true } }),
    },
  };
});

// Mock modules before tests
vi.mock("@/api/userManagerApi");
vi.mock("@/api/authapi", () => ({
  getAuthenticatedUser: vi.fn().mockResolvedValue({
    id: "123",
    firstName: "John",
    lastName: "Doe",
    isAdmin: false,
    isDeleted: false,
  }),
}));

vi.mock("@/layout/Wrapper/Wrapper", () => ({
  default: ({ children, error }: { children: ReactNode; error?: string }) => (
    <div data-testid="mocked-wrapper">
      {error && <div data-testid="error-message">{error}</div>}
      {children}
    </div>
  ),
}));

vi.mock("@/layout/Footer/Footer", () => ({
  default: () => <div data-testid="mocked-footer">Footer Content</div>,
}));

vi.mock("@/layout/Header/Header", () => ({
  default: () => <div data-testid="mocked-header">Header Content</div>,
}));

vi.mock("@/layout/Navbar/ModernNavbar", () => ({
  default: () => <div data-testid="mocked-navbar">Navbar Content</div>,
}));

// Create a variable to control form submission behavior
let submitEmptyForm = false;

vi.mock("@/components/crud/AddForm", () => ({
  default: ({
    fields,
    submitHandler,
    onCancel,
  }: {
    fields: IField[];
    submitHandler: (formData: FormData) => void;
    onCancel: () => void;
  }) => (
    <form
      data-testid="mocked-add-form"
      role="form"
      onSubmit={(e) => {
        e.preventDefault();
        const formData = new FormData();

        if (!submitEmptyForm) {
          // Add values for all required fields
          formData.append("firstName", "John");
          formData.append("lastName", "Doe");
          formData.append("userName", "johndoe");
          formData.append("email", "john@example.com");
          formData.append("dateOfBirth", "1990-01-01");
          formData.append("password", "P@ssw0rd");
          formData.append("isAdmin", "false");
          formData.append("isActive", "true");
        }

        // Call the submit handler with the form data
        submitHandler(formData);
      }}
    >
      {fields.map((field) => (
        <div key={field.name}>
          <label htmlFor={field.name}>{field.label}</label>
          <input
            id={field.name}
            name={field.name}
            type={field.type}
            required={field.required}
            onChange={field.onChange}
          />
        </div>
      ))}
      <button type="submit">Submit</button>
      <button type="button" onClick={onCancel}>
        Cancel
      </button>
    </form>
  ),
}));

// Mock the react-router-dom's useNavigate
const mockNavigate = vi.fn();
vi.mock("react-router-dom", async () => {
  const actual = await vi.importActual<typeof import("react-router-dom")>(
    "react-router-dom"
  );
  return {
    ...actual,
    useNavigate: () => mockNavigate,
  };
});

describe("CreateUser", () => {
  beforeEach(() => {
    // Reset all mocks and variables before each test
    vi.resetAllMocks();
    submitEmptyForm = false;

    // Set up default mock implementations
    vi.mocked(userManagerApi.addUserByAdmin).mockResolvedValue({
      success: true,
      data: { id: "123" },
    });
  });

  it("renders the form with all required fields", () => {
    render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <CreateUser />
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    expect(screen.getByLabelText(/First Name/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Last Name/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/User Name/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Email/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Date of Birth/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Password/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Bio/i)).toBeInTheDocument();
  });

  // navigate to '/users' on success
  it("navigates to '/users' on success", async () => {
    render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <CreateUser />
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    const form = screen.getByTestId("mocked-add-form");
    fireEvent.submit(form);

    await waitFor(
      () => {
        expect(mockNavigate).toHaveBeenCalledWith("/users");
      },
      { timeout: 3000 }
    );
  });

  // handleCancel
  it("navigates to '/users' on cancel", () => {
    render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <CreateUser />
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    const cancelButton = screen.getByRole("button", { name: /cancel/i });
    fireEvent.click(cancelButton);

    expect(mockNavigate).toHaveBeenCalledWith("/users");
  });
});
