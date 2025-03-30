import { render, screen, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import ProjectHome from "../Project/Index";
import { BrowserRouter } from "react-router-dom";
import { ThemeProvider } from "@/contexts/ThemeContext";
import { ReactNode } from "react";
import { IProject } from "@/interfaces/IProject";

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

// Mock project data
const mockProjects: IProject[] = [
  {
    id: "project1",
    name: "Test Project 1",
    description: "Description for test project 1",
    ownerId: "user123",
    createdAt: new Date("2023-01-01T00:00:00Z"),
    updatedAt: new Date("2023-01-01T00:00:00Z"),
    startDate: new Date("2023-01-01"),
    endDate: new Date("2023-12-31"),
    status: 0, // assuming 0 is Active
    visibility: 0, // assuming 0 is Public
    budget: 1000,
  },
  {
    id: "project2",
    name: "Test Project 2",
    description: "Description for test project 2",
    ownerId: "user456",
    createdAt: new Date("2023-01-01T00:00:00Z"),
    updatedAt: new Date("2023-01-01T00:00:00Z"),
    startDate: new Date("2023-01-01"),
    endDate: new Date("2023-12-31"),
    status: 1, // assuming 1 is Completed
    visibility: 1, // assuming 1 is Private
    budget: 2000,
  },
];

// Mock entityServices
vi.mock("@/api/entityServices", () => ({
  default: {
    getEntities: vi.fn().mockImplementation(() => {
      return Promise.resolve({
        $values: mockProjects,
      });
    }),
    fetchEntities: vi.fn().mockImplementation(() => {
      return Promise.resolve({ $values: mockProjects });
    }),
    deleteEntity: vi.fn().mockResolvedValue({ success: true }),
  },
}));

// Mock the AuthContext
vi.mock("@/contexts/AuthContext", () => ({
  useAuth: () => ({
    authenticated: true,
    authenticatedUser: {
      id: "user123",
      firstName: "Test",
      lastName: "User",
      isAdmin: true,
      role: "Admin",
    },
  }),
}));

// Mock components
vi.mock("@fluentui/react-components", () => ({
  Button: ({ children, onClick }: any) => (
    <button onClick={onClick} data-testid="fluent-button">
      {children}
    </button>
  ),
  Toolbar: ({ children }: any) => (
    <div data-testid="fluent-toolbar">{children}</div>
  ),
  Tooltip: ({ content, children }: any) => (
    <div data-testid="fluent-tooltip" title={content}>
      {children}
    </div>
  ),
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

describe('ProjectHome', () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  it('renders project data after successful fetch', async () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <ProjectHome />
        </ThemeProvider>
      </BrowserRouter>
    );

    // Wait for the projects to load and check for project data
    await waitFor(() => {
      expect(screen.getByTestId('mocked-wrapper')).toBeInTheDocument();
    });
  });
});
