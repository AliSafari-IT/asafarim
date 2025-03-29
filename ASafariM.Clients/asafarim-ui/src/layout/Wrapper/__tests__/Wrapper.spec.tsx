import { render } from "@testing-library/react";
import { describe, it, expect, vi } from "vitest";
import Wrapper from "../Wrapper";
import { BrowserRouter } from "react-router-dom";
import { ThemeProvider } from "@/contexts/ThemeContext";
import { AuthProvider } from "@/contexts/AuthContext";

// Mock the Footer component to avoid navigation elements in tests
vi.mock("../../Footer/Footer", () => ({
  default: () => <div data-testid="mocked-footer">Footer Content</div>
}));

// Mock ModernNavbar to simplify testing
vi.mock("../../Navbar/ModernNavbar", () => ({
  default: () => <div data-testid="modern-navbar">Navbar Content</div>
}));

describe("Wrapper", () => {
  it("renders with default layout", () => {
    const { container } = render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <Wrapper>
              <div>Test Content</div>
            </Wrapper>
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    const wrapper = container.querySelector("#wrapper");
    expect(wrapper).toBeInTheDocument();
    expect(wrapper).toHaveClass("flex");
    expect(wrapper).toHaveClass("min-h-screen");
  });

  it("renders without navbar when removeNavbar is true", () => {
    const { queryByTestId } = render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <Wrapper removeNavbar={true}>
              <div>Test Content</div>
            </Wrapper>
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    expect(queryByTestId("modern-navbar")).not.toBeInTheDocument();
  });

  it("renders custom header", () => {
    const { getByText } = render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <Wrapper header={<div>Custom Header</div>}>
              <div>Test Content</div>
            </Wrapper>
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    expect(getByText("Custom Header")).toBeInTheDocument();
  });

  it("renders error message", () => {
    const { getByText } = render(
      <BrowserRouter>
        <AuthProvider>
          <ThemeProvider>
            <Wrapper error="Test Error">
              <div>Test Content</div>
            </Wrapper>
          </ThemeProvider>
        </AuthProvider>
      </BrowserRouter>
    );

    expect(getByText("Test Error")).toBeInTheDocument();
  });
});
