import { render } from "@testing-library/react";
import { describe, it, expect } from "vitest";
import { SidebarWrapper } from "../SidebarWrapper";
import { BrowserRouter } from "react-router-dom";
import { ThemeProvider } from "@/contexts/ThemeContext";

describe("SidebarWrapper", () => {
  it("renders with custom sidebar content", () => {
    const { getByText } = render(
      <BrowserRouter>
        <ThemeProvider>
          <SidebarWrapper sidebar={<div>Custom Sidebar</div>} />
        </ThemeProvider>
      </BrowserRouter>
    );

    expect(getByText("Custom Sidebar")).toBeInTheDocument();
  });

  it("renders default navigation items when no sidebar is provided", () => {
    const { container } = render(
      <BrowserRouter>
        <ThemeProvider>
          <SidebarWrapper />
        </ThemeProvider>
      </BrowserRouter>
    );

    const sidebar = container.querySelector("aside");
    expect(sidebar).toBeInTheDocument();
    expect(sidebar).toHaveClass("bg-[var(--bg-secondary)]");
    expect(sidebar).toHaveClass("w-64");
  });

  it("applies custom className", () => {
    const { container } = render(
      <BrowserRouter>
        <ThemeProvider>
          <SidebarWrapper className="custom-class" />
        </ThemeProvider>
      </BrowserRouter>
    );

    const sidebar = container.querySelector("aside");
    expect(sidebar).toHaveClass("custom-class");
  });

  it("renders children content", () => {
    const { getByText } = render(
      <BrowserRouter>
        <ThemeProvider>
          <SidebarWrapper>
            <div>Child Content</div>
          </SidebarWrapper>
        </ThemeProvider>
      </BrowserRouter>
    );

    expect(getByText("Child Content")).toBeInTheDocument();
  });
});
