import { render } from "@testing-library/react";
import { describe, it, expect } from "vitest";
import MainContent from "../MainContent";

describe("MainContent", () => {
  it("renders children content", () => {
    const { getByText } = render(
      <MainContent>
        <div>Test Content</div>
      </MainContent>
    );

    expect(getByText("Test Content")).toBeInTheDocument();
  });

  it("applies custom className", () => {
    const { container } = render(
      <MainContent className="custom-class">
        <div>Test Content</div>
      </MainContent>
    );

    const mainContent = container.firstChild;
    expect(mainContent).toHaveClass("custom-class");
    expect(mainContent).toHaveClass("flex");
  });

  it("renders header content", () => {
    const { getByText } = render(
      <MainContent header={<div>Header Content</div>}>
        <div>Test Content</div>
      </MainContent>
    );

    expect(getByText("Header Content")).toBeInTheDocument();
    expect(getByText("Test Content")).toBeInTheDocument();
  });
});
