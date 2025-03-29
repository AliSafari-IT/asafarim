import { render } from "@testing-library/react";
import { describe, it, expect } from "vitest";
import getContent from "../getContent";

describe("getContent", () => {
  it("renders content panel with provided content", () => {
    const testContent = {
      id: 1,
      title: "Test Title",
      content: "<p>Test Content</p>"
    };

    const { container } = render(getContent(testContent));
    const contentPanel = container.querySelector(".content-panel");
    const content = container.querySelector(".content");

    expect(contentPanel).toBeInTheDocument();
    expect(content).toBeInTheDocument();
    expect(content?.innerHTML).toContain("<p>Test Content</p>");
  });

  it("renders empty content panel when no content is provided", () => {
    const { container } = render(getContent(undefined));
    const contentPanel = container.querySelector(".content-panel");
    const content = container.querySelector(".content");

    expect(contentPanel).toBeInTheDocument();
    expect(content).toBeInTheDocument();
    expect(content?.innerHTML).toBe("");
  });
});
