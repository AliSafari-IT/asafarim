import { render, screen, fireEvent, cleanup } from "@testing-library/react";
import { describe, it, vi, beforeEach } from "vitest";
import { expect as extendedExpect } from "@/test-utils/setup-test-env";
import ToggleThemeDesktop from "../ToggleThemeDesktop";
import { ThemeProvider } from "@/contexts/ThemeContext";

// Mock the ThemeContext
const mockToggleTheme = vi.fn();
let mockTheme = 'light';

vi.mock("@/contexts/ThemeContext", () => ({
  useTheme: () => ({
    theme: mockTheme,
    toggleTheme: mockToggleTheme,
  }),
  ThemeProvider: ({ children }: { children: React.ReactNode }) => <>{children}</>,
}));

// Mock Fluent UI icons
vi.mock("@fluentui/react-icons", () => ({
  WeatherMoonRegular: vi.fn(() => <div data-testid="moon-icon">Moon Icon</div>),
  WeatherSunnyRegular: vi.fn(() => <div data-testid="sun-icon">Sun Icon</div>),
}));

describe("ToggleThemeDesktop", () => {
  beforeEach(() => {
    mockToggleTheme.mockClear();
    mockTheme = 'light'; // Reset theme before each test
  });

  it("renders with default props", () => {
    render(
      <ThemeProvider>
        <ToggleThemeDesktop />
      </ThemeProvider>
    );

    const button = screen.getByRole("button");
    extendedExpect(button).toBeInTheDocument();
    extendedExpect(button).toHaveAttribute("aria-label", "Toggle dark mode");
    
    // In light mode, should show sun icon
    const sunIcon = screen.getByTestId("sun-icon");
    extendedExpect(sunIcon).toBeInTheDocument();
    
    // Moon icon should not be present in light mode
    const moonIcon = screen.queryByTestId("moon-icon");
    extendedExpect(moonIcon).not.toBeInTheDocument();
  });

  it("renders with custom props", () => {
    render(
      <ThemeProvider>
        <ToggleThemeDesktop 
          className="custom-class" 
          size="lg" 
          title="Custom Title" 
        />
      </ThemeProvider>
    );

    const button = screen.getByRole("button");
    extendedExpect(button).toBeInTheDocument();
    extendedExpect(button).toHaveClass("custom-class");
    extendedExpect(button).toHaveAttribute("title", "Custom Title");
  });

  it("renders moon icon in dark mode", () => {
    mockTheme = 'dark';
    
    render(
      <ThemeProvider>
        <ToggleThemeDesktop />
      </ThemeProvider>
    );

    // In dark mode, should show moon icon
    const moonIcon = screen.getByTestId("moon-icon");
    extendedExpect(moonIcon).toBeInTheDocument();
    
    // Sun icon should not be present in dark mode
    const sunIcon = screen.queryByTestId("sun-icon");
    extendedExpect(sunIcon).not.toBeInTheDocument();
    
    const button = screen.getByRole("button");
    extendedExpect(button).toHaveAttribute("aria-label", "Toggle light mode");
  });

  it("calls toggleTheme when clicked", () => {
    render(
      <ThemeProvider>
        <ToggleThemeDesktop />
      </ThemeProvider>
    );

    const button = screen.getByRole("button");
    fireEvent.click(button);
    
    extendedExpect(mockToggleTheme).toHaveBeenCalledTimes(1);
  });

  it("handles different size formats", () => {
    // Test with string size format
    render(
      <ThemeProvider>
        <ToggleThemeDesktop size="2x" />
      </ThemeProvider>
    );
    
    let button = screen.getByRole("button");
    extendedExpect(button).toBeInTheDocument();
    
    // Cleanup and test with string size
    cleanup();
    
    render(
      <ThemeProvider>
        <ToggleThemeDesktop size="lg" />
      </ThemeProvider>
    );
    
    button = screen.getByRole("button");
    extendedExpect(button).toBeInTheDocument();
  });
});
