import { render } from "@testing-library/react";
import { describe, it, expect } from "vitest";
import { TopbarWrapper } from "../TopbarWrapper";

describe("TopbarWrapper", () => {
  it("renders with custom topbar content", () => {
    const { getByText } = render(
      <TopbarWrapper topbar={<div>Custom Topbar</div>} />
    );

    expect(getByText("Custom Topbar")).toBeInTheDocument();
  });

  it("renders default navigation items when no topbar is provided", () => {
    const { container } = render(<TopbarWrapper />);
    const header = container.querySelector("header");

    expect(header).toBeInTheDocument();
    expect(header).toHaveClass("bg-[var(--bg-secondary)]");
    expect(header).toHaveClass("h-16");
  });

  it("applies custom className", () => {
    const { container } = render(
      <TopbarWrapper className="custom-class" />
    );

    const header = container.querySelector("header");
    expect(header).toHaveClass("custom-class");
  });

  it("renders children content", () => {
    const { getByText } = render(
      <TopbarWrapper>
        <div>Child Content</div>
      </TopbarWrapper>
    );

    expect(getByText("Child Content")).toBeInTheDocument();
  });
});
