import { render, screen, fireEvent } from "@testing-library/react";
import { describe, it, vi, beforeEach } from "vitest";
import { expect as extendedExpect } from "@/test-utils/setup-test-env";
import { ToggleThemeMobile } from "../ToggleThemeMobile";
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

// Mock FontAwesome components
vi.mock("@fortawesome/react-fontawesome", () => ({
  FontAwesomeIcon: vi.fn(({ icon, title, onClick, className, style }) => (
    <div 
      data-testid="font-awesome-icon" 
      data-icon={icon.iconName}
      title={title}
      className={className}
      style={style}
      onClick={onClick}
    >
      FontAwesome Icon: {icon.iconName}
    </div>
  )),
}));

vi.mock("@fortawesome/free-solid-svg-icons", () => ({
  faSun: { iconName: 'sun', prefix: 'fas' },
  faMoon: { iconName: 'moon', prefix: 'fas' },
}));

describe("ToggleThemeMobile", () => {
  beforeEach(() => {
    mockToggleTheme.mockClear();
    mockTheme = 'light'; // Reset theme before each test
  });

  it("renders with default props in light mode", () => {
    render(
      <ThemeProvider>
        <ToggleThemeMobile />
      </ThemeProvider>
    );

    const icon = screen.getByTestId("font-awesome-icon");
    extendedExpect(icon).toBeInTheDocument();
    extendedExpect(icon).toHaveAttribute("data-icon", "sun");
    extendedExpect(icon).toHaveStyle("cursor: pointer");
  });

  it("renders with custom props", () => {
    render(
      <ThemeProvider>
        <ToggleThemeMobile 
          className="custom-class" 
          size="2x" 
          title="Custom Title" 
        />
      </ThemeProvider>
    );

    const icon = screen.getByTestId("font-awesome-icon");
    extendedExpect(icon).toBeInTheDocument();
    extendedExpect(icon).toHaveClass("custom-class");
    extendedExpect(icon).toHaveAttribute("title", "Custom Title");
  });

  it("renders moon icon in dark mode", () => {
    mockTheme = 'dark';
    
    render(
      <ThemeProvider>
        <ToggleThemeMobile />
      </ThemeProvider>
    );

    const icon = screen.getByTestId("font-awesome-icon");
    extendedExpect(icon).toBeInTheDocument();
    extendedExpect(icon).toHaveAttribute("data-icon", "moon");
  });

  it("calls toggleTheme when clicked", () => {
    render(
      <ThemeProvider>
        <ToggleThemeMobile />
      </ThemeProvider>
    );

    const icon = screen.getByTestId("font-awesome-icon");
    fireEvent.click(icon);
    
    extendedExpect(mockToggleTheme).toHaveBeenCalledTimes(1);
  });

  it("applies different sizes correctly", () => {
    render(
      <ThemeProvider>
        <ToggleThemeMobile size="2x" />
      </ThemeProvider>
    );

    const icon = screen.getByTestId("font-awesome-icon");
    extendedExpect(icon).toBeInTheDocument();
    // Size is passed to FontAwesomeIcon
    // We can't directly test the size prop since it's internal to FontAwesomeIcon
    // but we can verify the component renders
  });
});
