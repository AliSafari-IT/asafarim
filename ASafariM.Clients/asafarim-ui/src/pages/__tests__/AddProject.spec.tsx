import { render, screen, fireEvent } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import AddProject from "../Project/AddProject";
import { BrowserRouter } from "react-router-dom";
import { ThemeProvider } from "@/contexts/ThemeContext";
import { ReactNode } from "react";
import React from "react";

// Mock the logger
vi.mock("@/utils/logger", () => ({
  logger: {
    log: vi.fn(),
    info: vi.fn(),
    debug: vi.fn(),
    error: vi.fn(),
    warn: vi.fn(),
  },
}));

// Mock the axios module
vi.mock("axios", () => {
  return {
    default: {
      get: vi.fn().mockImplementation((url) => {
        if (url.includes("repos")) {
          return Promise.resolve({
            data: [
              {
                name: "test-repo",
                html_url: "https://github.com/test/test-repo",
                description: "Test repo",
              },
            ],
          });
        } else if (url.includes("gists")) {
          return Promise.resolve({
            data: [
              {
                description: "Test gist",
                html_url: "https://gist.github.com/test/123",
                files: { "test.js": {} },
              },
            ],
          });
        }
        return Promise.resolve({ data: {} });
      }),
      post: vi.fn().mockResolvedValue({ data: { success: true } }),
      create: vi.fn().mockReturnValue({
        interceptors: {
          request: { use: vi.fn(), eject: vi.fn() },
          response: { use: vi.fn(), eject: vi.fn() },
        },
        get: vi.fn().mockResolvedValue({ data: {} }),
        post: vi.fn().mockResolvedValue({ data: { success: true } }),
      }),
    },
  };
});

// Mock entityServices
vi.mock("@/api/entityServices", () => ({
  default: {
    createEntity: vi.fn().mockResolvedValue({ id: "test-project-id" }),
    addEntityRepoLink: vi.fn().mockResolvedValue(true),
  },
}));

// Mock the AuthContext
vi.mock("@/contexts/AuthContext", () => ({
  AuthProvider: ({ children }: { children: ReactNode }) => (
    <div data-testid="auth-provider">{children}</div>
  ),
  useAuth: () => ({
    authenticated: true,
    authenticatedUser: {
      id: "user123",
      firstName: "Test",
      lastName: "User",
      isAdmin: true,
    },
  }),
}));

// Mock Fluent UI components to avoid rendering issues
vi.mock("@fluentui/react/lib/TextField", () => ({
  TextField: ({ label, onChange, value, name }: any) => (
    <div data-testid={`field-${name}`}>
      <label htmlFor={name}>{label}</label>
      <input
        id={name}
        name={name}
        value={value || ""}
        onChange={(e) => onChange && onChange(e, e.target.value)}
        data-testid={`input-${name}`}
      />
    </div>
  ),
}));

vi.mock("@fluentui/react/lib/Button", () => ({
  PrimaryButton: ({ text, onClick, disabled }: any) => (
    <button onClick={onClick} disabled={disabled} data-testid="primary-button">
      {text || "Save"}
    </button>
  ),
  DefaultButton: ({ text, onClick }: any) => (
    <button onClick={onClick} data-testid="default-button">
      {text || "Cancel"}
    </button>
  ),
  ActionButton: ({ onClick, children, text }: any) => (
    <button onClick={onClick} data-testid="action-button" aria-label={text}>
      {children || text || "Back"}
    </button>
  ),
  IconButton: ({ onClick, iconProps }: any) => (
    <button
      onClick={onClick}
      data-testid={`icon-button-${iconProps?.iconName || "default"}`}
    >
      Icon
    </button>
  ),
}));

vi.mock("@fluentui/react/lib/Dropdown", () => ({
  Dropdown: ({ label, options, onChange, selectedKey, id }: any) => (
    <div data-testid={`dropdown-${id}`}>
      <label>{label}</label>
      <select
        value={selectedKey || ""}
        onChange={(e) =>
          onChange &&
          onChange(
            e,
            options.find((o: any) => o.key === e.target.value)
          )
        }
        data-testid={`select-${id}`}
      >
        {options?.map((option: any) => (
          <option key={option.key} value={option.key}>
            {option.text}
          </option>
        ))}
      </select>
    </div>
  ),
}));

vi.mock("@/components/Toolbars/Toolbar", () => ({
  default: () => <div data-testid="toolbar">Toolbar</div>,
}));

vi.mock("@/layout/Wrapper/Wrapper", () => ({
  default: ({ children, error }: { children: ReactNode; error?: string }) => (
    <div data-testid="mocked-wrapper">
      {error && <div data-testid="error-message">{error}</div>}
      {children}
    </div>
  ),
}));

// Mock navigate
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

describe("AddProject", () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  it("displays form fields correctly", () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <AddProject />
        </ThemeProvider>
      </BrowserRouter>
    );

    // Check that all form fields are rendered
    expect(screen.getByTestId("input-name")).toBeInTheDocument();
    expect(screen.getByTestId("input-description")).toBeInTheDocument();
    expect(screen.getByTestId("input-startDate")).toBeInTheDocument();
    expect(screen.getByTestId("input-endDate")).toBeInTheDocument();
    expect(screen.getByTestId("input-budget")).toBeInTheDocument();
  });

  it("shows validation errors when form is submitted with empty fields", () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <AddProject />
        </ThemeProvider>
      </BrowserRouter>
    );

    const saveButton = screen.getAllByTestId("primary-button")[0];
    fireEvent.click(saveButton);

    // Check for the general error message
    expect(screen.getByText("Please correct the highlighted fields before submitting")).toBeInTheDocument();
    
    // Check for the specific project name error
    expect(screen.getByText("Project name is required")).toBeInTheDocument();
  });

  it("handles project name input", () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <AddProject />
        </ThemeProvider>
      </BrowserRouter>
    );

    const nameInput = screen.getByTestId("input-name");
    fireEvent.change(nameInput, { target: { value: "Test Project" } });

    expect(nameInput).toHaveValue("Test Project");
  });

  it("adds a valid manual repository link", () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <AddProject />
        </ThemeProvider>
      </BrowserRouter>
    );

    const input = screen.getByTestId("input-undefined");
    const addBtn = screen.getAllByRole("button", { name: /save/i })[0];

    fireEvent.change(input, {
      target: { value: "https://github.com/test/test-repo" },
    });
    fireEvent.click(addBtn);

    expect(
      screen.getByText("https://github.com/test/test-repo")
    ).toBeInTheDocument();
  });
});
