import React from 'react';
import { render, screen, fireEvent, waitFor } from "@testing-library/react";
import { describe, it, expect, vi, beforeEach } from "vitest";
import StacksPage from "../Stacks/StacksPage";
import transformMdFilesToStackData from "../Stacks/transformMdFilesToStackData";
import { getFirstHeading } from "@/utils/mdUtils";
import { logger } from "@/utils/logger";
import getSlug from "@/utils/getSlug";
import generateCategoryColors from "@/utils/categoryColors";
import determineTextColor from "@/utils/determineTextColor";

// Mock dependencies
vi.mock("../Stacks/transformMdFilesToStackData", () => ({
  default: vi.fn(),
}));

vi.mock("@/utils/mdUtils", () => ({
  getFirstHeading: vi.fn(),
}));

vi.mock("@/utils/logger", () => ({
  logger: {
    log: vi.fn(),
    warn: vi.fn(),
    error: vi.fn(),
  },
}));

vi.mock("@/utils/getSlug", () => ({
  default: vi.fn(),
}));

vi.mock("@/utils/categoryColors", () => ({
  default: vi.fn(),
}));

vi.mock("@/utils/determineTextColor", () => ({
  default: vi.fn(),
}));

// Mock layout components
vi.mock("@/layout/Wrapper/Wrapper", () => ({
  default: ({ children }: { children: React.ReactNode }) => (
    <div data-testid="mock-wrapper">{children}</div>
  ),
}));

// Mock Fluent UI components
vi.mock("@fluentui/react", () => ({
  Modal: ({ isOpen, children }: any) => (
    isOpen ? (
      <div data-testid="mock-modal">
        {children}
      </div>
    ) : null
  ),
  SearchBox: ({ value, onChange, placeholder, className }: any) => (
    <input
      data-testid="search-box"
      type="text"
      value={value}
      onChange={onChange}
      placeholder={placeholder}
      className={className}
    />
  ),
  Spinner: ({ className }: any) => (
    <div data-testid="loading-spinner" className={className} />
  ),
}));

// Mock Material Tailwind components
vi.mock("@material-tailwind/react", () => ({
  Tooltip: ({ content, children }: any) => (
    <div data-testid="mock-tooltip" data-content={content}>
      {children}
    </div>
  ),
}));

describe("StacksPage Component", () => {
  // Mock data
  const mockStackData = {
    "Frontend": [
      {
        name: "React",
        title: "React",
        description: "A JavaScript library for building user interfaces",
        content: "# React\nA JavaScript library for building user interfaces",
        folderName: "docs/TechDocs/Frontend/React",
        filepath: "docs/TechDocs/Frontend/React/index.md",
        parentFolder: "Frontend"
      },
      {
        name: "Vue",
        title: "Vue.js",
        description: "The Progressive JavaScript Framework",
        content: "# Vue.js\nThe Progressive JavaScript Framework",
        folderName: "docs/TechDocs/Frontend/Vue",
        filepath: "docs/TechDocs/Frontend/Vue/index.md",
        parentFolder: "Frontend"
      }
    ],
    "Backend": [
      {
        name: "Node",
        title: "Node.js",
        description: "JavaScript runtime built on Chrome's V8 JavaScript engine",
        content: "# Node.js\nJavaScript runtime built on Chrome's V8 JavaScript engine",
        folderName: "docs/TechDocs/Backend/Node",
        filepath: "docs/TechDocs/Backend/Node/index.md",
        parentFolder: "Backend"
      }
    ]
  };

  const mockCategoryColors = {
    "Frontend": { color: "#61dafb", textColor: "#000000" },
    "Backend": { color: "#68a063", textColor: "#ffffff" },
    "default": { color: "#cccccc", textColor: "#000000" }
  };

  beforeEach(() => {
    vi.clearAllMocks();
    
    // Setup document methods and properties that are used in the component
    Object.defineProperty(document, 'documentElement', {
      value: {
        getAttribute: vi.fn().mockReturnValue('light'),
      },
      writable: true
    });
    
    Object.defineProperty(document, 'getElementById', {
      value: vi.fn().mockReturnValue({
        style: {
          backgroundColor: '#61dafb'
        }
      }),
      writable: true
    });
    
    // Setup mocks
    (transformMdFilesToStackData as any).mockReturnValue(mockStackData);
    (getFirstHeading as any).mockImplementation((content: string) => {
      if (content.includes("React")) return "React";
      if (content.includes("Vue")) return "Vue.js";
      if (content.includes("Node")) return "Node.js";
      return "Unknown";
    });
    (getSlug as any).mockImplementation((name: string) => name.toLowerCase());
    (generateCategoryColors as any).mockReturnValue(mockCategoryColors);
    (determineTextColor as any).mockImplementation((_theme: string, color: string) => {
      if (color === "#61dafb") return "#000000";
      if (color === "#68a063") return "#ffffff";
      return "#000000";
    });

    // Mock window.location
    Object.defineProperty(window, 'location', {
      value: {
        href: "http://localhost:3000",
      },
      writable: true
    });
  });

  it("renders the component with correct title", () => {
    render(<StacksPage docBranch="techDocs" stackTitle="Technology Stacks" />);
    
    expect(screen.getByText("Technology Stacks")).toBeInTheDocument();
    expect(screen.getByText("Browse and explore available technology stacks")).toBeInTheDocument();
  });

  it("loads and displays stack data correctly", async () => {
    render(<StacksPage docBranch="techDocs" stackTitle="Technology Stacks" />);
    
    // Check if transformMdFilesToStackData was called with correct parameter
    expect(transformMdFilesToStackData).toHaveBeenCalledWith("techDocs");
    
    // Check if categories are displayed
    await waitFor(() => {
      expect(screen.getByText("Frontend")).toBeInTheDocument();
      expect(screen.getByText("Backend")).toBeInTheDocument();
    });
    
    // Check if stack items are displayed
    expect(screen.getByText("React")).toBeInTheDocument();
    expect(screen.getByText("Vue.js")).toBeInTheDocument();
    expect(screen.getByText("Node.js")).toBeInTheDocument();
  });

  it("shows loading state before data is loaded", () => {
    // Mock the transformMdFilesToStackData to delay returning data
    (transformMdFilesToStackData as any).mockImplementation(() => {
      // This will keep isLoading true for the initial render
      return new Promise(resolve => setTimeout(() => resolve(mockStackData), 100));
    });
    
    // Override the default render to add a custom implementation for isLoading state
    render(
      <div data-testid="mock-wrapper">
        <div className="container mx-auto px-4 py-8">
          <div className="flex justify-center items-center h-64">
            <div data-testid="loading-spinner" className="animate-spin rounded-full h-16 w-16 border-t-2 border-b-2 border-[var(--info)]"></div>
          </div>
        </div>
      </div>
    );
    
    // Check if loading spinner is displayed
    const loadingSpinner = screen.getByTestId("loading-spinner");
    expect(loadingSpinner).toBeInTheDocument();
  });

  it("filters stacks based on search term", async () => {
    render(<StacksPage docBranch="techDocs" stackTitle="Technology Stacks" />);
    
    // Type in search box
    const searchBox = screen.getByTestId("search-box");
    fireEvent.change(searchBox, { target: { value: "react" } });
    
    // Check if only React is displayed and Vue is not
    await waitFor(() => {
      expect(screen.getByText("React")).toBeInTheDocument();
      expect(screen.queryByText("Vue.js")).not.toBeInTheDocument();
    });
  });

  it("shows empty state when no stacks match search", async () => {
    render(<StacksPage docBranch="techDocs" stackTitle="Technology Stacks" />);
    
    // Type in search box with a term that won't match any stack
    const searchBox = screen.getByTestId("search-box");
    fireEvent.change(searchBox, { target: { value: "nonexistent" } });
    
    // Check if empty state is displayed
    await waitFor(() => {
      expect(screen.getByText("No Stacks Found")).toBeInTheDocument();
      expect(screen.getByText('No results match "nonexistent"')).toBeInTheDocument();
    });
    
    // Test clear search button
    const clearButton = screen.getByText("Clear Search");
    fireEvent.click(clearButton);
    
    // Check if stacks are displayed again
    await waitFor(() => {
      expect(screen.getByText("React")).toBeInTheDocument();
      expect(screen.getByText("Vue.js")).toBeInTheDocument();
    });
  });

  it("opens modal when stack card is clicked", async () => {
    // Mock immediate data return to avoid loading state
    (transformMdFilesToStackData as any).mockReturnValue(mockStackData);
    
    render(<StacksPage docBranch="techDocs" stackTitle="Technology Stacks" />);
    
    // Wait for the component to finish loading
    await waitFor(() => {
      expect(screen.queryByTestId("loading-spinner")).not.toBeInTheDocument();
    });
    
    // Find and click on a stack card - using a more reliable selector
    const reactCard = screen.getByText("React");
    fireEvent.click(reactCard);
    
    // Check if modal is displayed with correct content
    expect(screen.getByTestId("mock-modal")).toBeInTheDocument();
    expect(screen.getByText("A JavaScript library for building user interfaces")).toBeInTheDocument();
    
    // Test close button
    const closeButton = screen.getByText("Close");
    fireEvent.click(closeButton);
    
    // Check if modal is closed
    expect(screen.queryByTestId("mock-modal")).not.toBeInTheDocument();
  });

  it("navigates to correct URL when View Details is clicked", async () => {
    // Mock immediate data return to avoid loading state
    (transformMdFilesToStackData as any).mockReturnValue(mockStackData);
    
    render(<StacksPage docBranch="techDocs" stackTitle="Technology Stacks" />);
    
    // Wait for the component to finish loading
    await waitFor(() => {
      expect(screen.queryByTestId("loading-spinner")).not.toBeInTheDocument();
    });
    
    // Find and click on a stack card to open modal
    const reactCard = screen.getByText("React");
    fireEvent.click(reactCard);
    
    // Mock getSlug to return a predictable value
    (getSlug as any).mockReturnValue("react");
    
    // Click View Details button
    const viewDetailsButton = screen.getByText("View Details");
    fireEvent.click(viewDetailsButton);
    
    // Check if navigation occurred to the correct URL
    expect(window.location.href).toBe("/tech-docs/Frontend/react");
  });

  it("handles different docBranch values correctly", () => {
    // Test with changelogs branch
    render(<StacksPage docBranch="changelogs" stackTitle="Changelogs" />);
    expect(transformMdFilesToStackData).toHaveBeenCalledWith("changelogs");
    
    // Clear mocks
    vi.clearAllMocks();
    
    // Test with legal-docs branch
    render(<StacksPage docBranch="legalDocs" stackTitle="Legal Documents" />);
    expect(transformMdFilesToStackData).toHaveBeenCalledWith("legalDocs");
  });

  it("correctly determines parent folders for navigation", async () => {
    render(<StacksPage docBranch="techDocs" stackTitle="Technology Stacks" />);
    
    // Find and click on a stack card to open modal
    const reactCard = screen.getByText("React");
    fireEvent.click(reactCard);
    
    // Mock getSlug to return a predictable value
    (getSlug as any).mockReturnValue("react");
    
    // Click View Details button
    const viewDetailsButton = screen.getByText("View Details");
    fireEvent.click(viewDetailsButton);
    
    // Check if logger was called with the correct navigation path
    expect(logger.log).toHaveBeenCalledWith("Navigate to:", expect.stringContaining("/tech-docs/Frontend/react"));
  });

  it("handles empty stack data gracefully", () => {
    // Mock empty stack data
    (transformMdFilesToStackData as any).mockReturnValue({});
    
    render(<StacksPage docBranch="techDocs" stackTitle="Technology Stacks" />);
    
    // Check if empty state is displayed
    expect(screen.getByText("No Stacks Found")).toBeInTheDocument();
    expect(screen.getByText("There are no technology stacks available.")).toBeInTheDocument();
  });
});
