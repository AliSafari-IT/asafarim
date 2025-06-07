import { render, screen, fireEvent } from "@testing-library/react";
import { describe, it, expect, vi } from "vitest";
import About from "../AboutMe/About";
import React from "react";

// Mock all subcomponents
vi.mock("../../layout/Wrapper/Wrapper", () => ({
  default: ({ children }: { children: React.ReactNode }) => (
    <div data-testid="mock-wrapper">{children}</div>
  ),
}));

vi.mock("../../components/MarkdownPage/DisplayMd", () => ({
  default: ({ markdownContent, id }: { markdownContent: string; id: string }) => (
    <div data-testid={`markdown-${id}`}>{markdownContent}</div>
  ),
}));

vi.mock("../AboutMe/TechStackSection", () => ({
  TechStackSection: () => <div data-testid="tech-stack">Tech Stack</div>,
}));

vi.mock("../AboutMe/ExperienceTimeline", () => ({
  ExperienceTimeline: () => <div data-testid="experience-timeline">Experience Timeline</div>,
}));

vi.mock("../AboutMe/AdditionalInfo", () => ({
  default: () => <div data-testid="additional-info">Additional Info Content</div>,
}));

// Mock markdown imports
vi.mock("../AboutMe/aboutme.en.md?raw", () => ({
  default: "Mock English Markdown Content"
}));
vi.mock("../AboutMe/aboutme.nl.md?raw", () => ({
  default: "Mock Dutch Markdown Content"
}));

describe("About Page", () => {
  it("renders wrapper and main sections", () => {
    render(<About />);
    
    expect(screen.getByTestId("mock-wrapper")).toBeInTheDocument();
    expect(screen.getByTestId("tech-stack")).toBeInTheDocument();
    expect(screen.getByTestId("experience-timeline")).toBeInTheDocument();
  });

  it("renders markdown sections for English and Dutch", () => {
    render(<About />);

    expect(screen.getByTestId("markdown-about-me-en")).toHaveTextContent(
      "Mock English Markdown Content"
    );
    expect(screen.getByTestId("markdown-about-me-nl")).toHaveTextContent(
      "Mock Dutch Markdown Content"
    );
  });

  it("toggles AdditionalInfo on button click", () => {
    // Create a custom render to check for the presence of AdditionalInfo
    // based on the expanded state rather than the component itself
    const { container } = render(<About />);

    const toggleButton = screen.getByRole("button", {
      name: /Technical Background & Expertise/i,
    });

    // Initially the content should be hidden (max-height-0 and opacity-0)
    const initialContainer = container.querySelector('.max-h-0.opacity-0');
    expect(initialContainer).not.toBeNull();

    // Expand section
    fireEvent.click(toggleButton);
    
    // After clicking, it should be visible (max-h-[2000px] and opacity-100)
    const expandedContainer = container.querySelector('.max-h-\\[2000px\\].opacity-100');
    expect(expandedContainer).not.toBeNull();

    // Collapse again
    fireEvent.click(toggleButton);
    
    // Should be hidden again
    const collapsedContainer = container.querySelector('.max-h-0.opacity-0');
    expect(collapsedContainer).not.toBeNull();
  });
});
