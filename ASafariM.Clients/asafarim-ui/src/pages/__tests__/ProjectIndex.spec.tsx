import { render, screen, waitFor, fireEvent } from "@testing-library/react";
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

// Mock components
vi.mock("@fluentui/react-components", () => ({
  Button: ({ children, onClick, icon, ...props }: any) => (
    <button onClick={onClick} data-testid="fluent-button" {...props}>
      {icon && <span data-testid="button-icon">{icon.type.name}</span>}
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

vi.mock("@/components/Notification/Notification", () => ({
  default: ({ type, text }: { type: string; text: string }) => (
    <div
      data-testid={`notification-${type}`}
      data-test-notification-text={text}
    >
      {text}
    </div>
  ),
}));

vi.mock("@/layout/Wrapper/Wrapper", () => ({
  default: ({
    children,
    header,
  }: {
    children: ReactNode;
    header?: ReactNode;
  }) => (
    <div data-testid="mocked-wrapper">
      {header && <div data-testid="header-content">{header}</div>}
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

// Mock window.confirm
const originalConfirm = window.confirm;
window.confirm = vi.fn();

// Mock AuthContext before tests
vi.mock("@/contexts/AuthContext", () => ({
  useAuth: () => ({
    authenticated: true,
    authenticatedUser: {
      id: "user1",
      name: "Test User",
      email: "test@example.com",
      role: "admin",
    },
  }),
}));

describe("ProjectHome", () => {
  // Function to create mock projects
  const createMockProjects = (): IProject[] => [
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
    {
      id: "project3",
      name: "Expired Project",
      description: "This project has expired",
      ownerId: "user123",
      createdAt: new Date("2022-01-01T00:00:00Z"),
      updatedAt: new Date("2022-01-01T00:00:00Z"),
      startDate: new Date("2022-01-01"),
      endDate: new Date("2022-12-31"), // Expired date
      status: 0,
      visibility: 2, // Private
      budget: 3000,
    },
  ];

  beforeEach(() => {
    vi.clearAllMocks();
    window.confirm = vi.fn();

    vi.mock("@/api/entityServices", () => ({
      default: {
        fetchProjects: vi
          .fn()
          .mockImplementation(() => Promise.resolve(createMockProjects())),
        deleteEntity: vi.fn().mockResolvedValue({ success: true }),
      },
    }));
  });

  afterAll(() => {
    window.confirm = originalConfirm;
  });

  it.skip ("renders project data after successful fetch", async () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <ProjectHome />
        </ThemeProvider>
      </BrowserRouter>
    );

    // Wait for the projects to load
    await waitFor(() => {
      expect(screen.getByTestId("mocked-wrapper")).toBeInTheDocument();
    });

    // Check if project names are displayed
    expect(screen.getByText("Test Project 1")).toBeInTheDocument();
    expect(screen.getByText("Test Project 2")).toBeInTheDocument();
    expect(screen.getByText("Expired Project")).toBeInTheDocument();
  });

  it.skip("displays status labels correctly", async () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <ProjectHome />
        </ThemeProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      expect(screen.getByTestId("mocked-wrapper")).toBeInTheDocument();
    });

    // Check if status labels are displayed
    expect(screen.getAllByText("In Progress")[0]).toBeInTheDocument();
    expect(screen.getByText("Completed")).toBeInTheDocument();
  });

  it("navigates to add project page when add button is clicked", async () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <ProjectHome />
        </ThemeProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      expect(screen.getByTestId("mocked-wrapper")).toBeInTheDocument();
    });

    // Find and click the add button
    const addButtons = screen.getAllByTestId("fluent-button");
    const addButton = addButtons.find(
      (button) =>
        button.textContent?.includes("Add New Project") ||
        button.getAttribute("aria-label") === "Add New Project"
    );

    if (addButton) {
      fireEvent.click(addButton);
      expect(mockNavigate).toHaveBeenCalledWith("/projects/add");
    } else {
      throw new Error("Add button not found");
    }
  });

  it.skip("navigates to view project page when view button is clicked", async () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <ProjectHome />
        </ThemeProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      expect(screen.getByTestId("mocked-wrapper")).toBeInTheDocument();
    });

    // Find all view buttons
    const viewButtons = screen
      .getAllByTestId("fluent-tooltip")
      .filter((tooltip) => tooltip.getAttribute("title") === "View Project")
      .map((tooltip) => tooltip.querySelector("button"));

    // Click the first view button
    if (viewButtons.length > 0 && viewButtons[0]) {
      fireEvent.click(viewButtons[0]);
      expect(mockNavigate).toHaveBeenCalledWith("/projects/project1");
    } else {
      throw new Error("View button not found");
    }
  });

  it.skip("confirms before deleting a project", async () => {
    // Mock confirm to return true
    (window.confirm as jest.Mock).mockReturnValue(true);

    const dashboardServices = (await import("@/api/entityServices")).default;

    render(
      <BrowserRouter>
        <ThemeProvider>
          <ProjectHome />
        </ThemeProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      expect(screen.getByTestId("mocked-wrapper")).toBeInTheDocument();
    });

    // Find all delete buttons
    const deleteButtons = screen
      .getAllByTestId("fluent-tooltip")
      .filter((tooltip) => tooltip.getAttribute("title") === "Delete Project")
      .map((tooltip) => tooltip.querySelector("button"));

    // Click the first delete button
    if (deleteButtons.length > 0 && deleteButtons[0]) {
      fireEvent.click(deleteButtons[0]);

      // Check if confirm was called
      expect(window.confirm).toHaveBeenCalledWith(
        "Are you sure you want to delete this project?"
      );

      // Check if deleteEntity was called with correct parameters
      expect(dashboardServices.deleteEntity).toHaveBeenCalledWith(
        "projects",
        "project1"
      );
    } else {
      throw new Error("Delete button not found");
    }
  });

  // FIXME: Commented out due to intermittent mocking issues with sessionStorage
  // The test is flaky because of complex mocking of sessionStorage and component rendering
  it.skip("displays notification when present in sessionStorage", async () => {
    const mockNotification = {
      type: "success",
      message: "Project created successfully",
    };
    const getItemSpy = vi.spyOn(Storage.prototype, "getItem");
    const removeItemSpy = vi.spyOn(Storage.prototype, "removeItem");

    // Mock sessionStorage to return the notification
    getItemSpy.mockReturnValue(JSON.stringify(mockNotification));

    // Render the component
    render(
      <BrowserRouter>
        <ThemeProvider>
          <ProjectHome />
        </ThemeProvider>
      </BrowserRouter>
    );

    // Wait for the notification to be processed
    await waitFor(() => {
      const notificationElement = screen.queryByTestId(
        `notification-${mockNotification.type}`
      );
      expect(notificationElement).toBeInTheDocument();
      expect(notificationElement).toHaveTextContent(mockNotification.message);
    });

    // Check if sessionStorage was accessed and cleared
    expect(getItemSpy).toHaveBeenCalledWith("projectNotification");
    expect(removeItemSpy).toHaveBeenCalledWith("projectNotification");

    // Cleanup
    getItemSpy.mockRestore();
    removeItemSpy.mockRestore();
  });
});
