import { render, screen } from "@testing-library/react";
import { describe, it, vi } from "vitest";
import { expect as extendedExpect } from "@/test-utils/setup-test-env";
import ThemeToggler from "../ToggleTheme";
import { ThemeProvider } from "@/contexts/ThemeContext";
import type { SizeProp } from "@fortawesome/fontawesome-svg-core";

// Mock the theme components
vi.mock("../ToggleThemeDesktop", () => ({
  default: vi.fn(({ title }) => <div data-testid="desktop-theme-toggle">{title}</div>),
}));

vi.mock("../ToggleThemeMobile", () => ({
  default: vi.fn(({ title }) => <div data-testid="mobile-theme-toggle">{title}</div>),
}));

describe("ThemeToggler", () => {
  it("renders desktop theme toggle by default", () => {
    render(
      <ThemeProvider>
        <ThemeToggler title="Toggle Theme" />
      </ThemeProvider>
    );

    const desktopToggle = screen.getByTestId("desktop-theme-toggle");
    extendedExpect(desktopToggle).toBeInTheDocument();
    extendedExpect(desktopToggle).toHaveTextContent("Toggle Theme");
    
    // Mobile toggle should not be present
    const mobileToggle = screen.queryByTestId("mobile-theme-toggle");
    extendedExpect(mobileToggle).not.toBeInTheDocument();
  });

  it("renders mobile theme toggle when mobileView is true", () => {
    render(
      <ThemeProvider>
        <ThemeToggler title="Toggle Theme" mobileView={true} />
      </ThemeProvider>
    );

    const mobileToggle = screen.getByTestId("mobile-theme-toggle");
    extendedExpect(mobileToggle).toBeInTheDocument();
    extendedExpect(mobileToggle).toHaveTextContent("Toggle Theme");
    
    // Desktop toggle should not be present
    const desktopToggle = screen.queryByTestId("desktop-theme-toggle");
    extendedExpect(desktopToggle).not.toBeInTheDocument();
  });

  it("passes correct props to desktop toggle", () => {
    const props = {
      className: "custom-class",
      size: "lg" as SizeProp,
      title: "Custom Title",
      viewWidth: 1024
    };

    render(
      <ThemeProvider>
        <ThemeToggler  {...props} />
      </ThemeProvider>
    );

    const desktopToggle = screen.getByTestId("desktop-theme-toggle");
    extendedExpect(desktopToggle).toBeInTheDocument();
    extendedExpect(desktopToggle).toHaveTextContent("Custom Title");
  });

  it("passes correct props to mobile toggle", () => {
    const props = {
      className: "custom-class",
      size: "lg" as SizeProp,
      title: "Custom Title",
      viewWidth: 768,
      mobileView: true
    };

    render(
      <ThemeProvider>
        <ThemeToggler {...props} />
      </ThemeProvider>
    );

    const mobileToggle = screen.getByTestId("mobile-theme-toggle");
    extendedExpect(mobileToggle).toBeInTheDocument();
    extendedExpect(mobileToggle).toHaveTextContent("Custom Title");
  });
});
