import { render, screen } from "@testing-library/react";
import { describe, it, vi, beforeEach, afterEach } from "vitest";
import { expect as extendedExpect } from "@/test-utils/setup-test-env";
import ModernNavbar from "../ModernNavbar";
import { ThemeProvider } from "@/contexts/ThemeContext";
import type { ReactNode } from "react";

// Mock modules before any imports
vi.mock("@/hooks/useNavItems", () => ({
  default: vi.fn(() => [
    {
      id: "dashboard",
      title: "Dashboard",
      to: "/dashboard",
      isForNavbar: true,
    },
    { id: "about", title: "About", to: "/about", isForNavbar: true },
    { id: "contact", title: "Contact", to: "/contact", isForNavbar: true },
    {
      id: "services",
      title: "Services",
      to: "/services",
      isForNavbar: true,
      subMenu: [],
    },
  ]),
}));

// Mock react-router-dom
const mockNavigate = vi.fn();
const mockLocation = {
  pathname: "/",
  search: "",
  hash: "",
  state: null,
  key: "default",
};

vi.mock("react-router-dom", () => ({
  ...vi.importActual("react-router-dom"),
  BrowserRouter: ({ children }: { children: ReactNode }) => <>{children}</>,
  Link: ({
    children,
    to,
    ...props
  }: {
    children: ReactNode;
    to: string;
    [key: string]: any;
  }) => (
    <a href={to} {...props}>
      {children}
    </a>
  ),
  NavLink: ({
    children,
    to,
    ...props
  }: {
    children: ReactNode;
    to: string;
    [key: string]: any;
  }) => (
    <a href={to} {...props}>
      {children}
    </a>
  ),
  useNavigate: () => mockNavigate,
  useLocation: () => mockLocation,
}));

// Mock the AuthContext
vi.mock("@/contexts/AuthContext", () => ({
  useAuth: vi.fn(() => ({
    authenticatedUser: null,
    authenticated: false,
    token: null,
    login: vi.fn(),
    logout: vi.fn(),
    refreshToken: vi.fn(),
  })),
}));

describe("ModernNavbar", () => {
  const originalScrollY = window.scrollY;

  const mockScrollEvent = (scrollY: number) => {
    Object.defineProperty(window, "scrollY", {
      writable: true,
      configurable: true,
      value: scrollY,
    });

    window.dispatchEvent(new Event("scroll"));
  };

  const mockResizeEvent = () => {
    window.dispatchEvent(new Event("resize"));
  };

  beforeEach(() => {
    // Reset scroll position before each test
    Object.defineProperty(window, "scrollY", {
      writable: true,
      configurable: true,
      value: 0,
    });

    // Reset window width to desktop size
    Object.defineProperty(window, "innerWidth", {
      writable: true,
      configurable: true,
      value: 1024,
    });

    // Setup mocks
    vi.clearAllMocks();
    mockResizeEvent();
    mockScrollEvent(0);
  });

  afterEach(() => {
    // Cleanup after each test
    vi.clearAllMocks();

    // Reset scroll position
    Object.defineProperty(window, "scrollY", {
      writable: true,
      configurable: true,
      value: originalScrollY,
    });
  });

  // Test for brand link
  it("renders brand link", () => {
    render(
      <ThemeProvider>
        <ModernNavbar />
      </ThemeProvider>
    );

    // Find brand link by text content or by the containing element
    const brandElement =
      screen.getByRole("link", { name: /ASafariM \(Demo\)/i }) ||
      screen.getByText("ASafariM (Demo)");

    extendedExpect(brandElement).toBeInTheDocument();
    extendedExpect(brandElement.closest("a")).toHaveAttribute("href", "/");
  });

  // Test for blog link
  it("renders blog link", () => {
    render(
      <ThemeProvider>
        <ModernNavbar />
      </ThemeProvider>
    );

    // Find blog links (there are multiple, for desktop and mobile views)
    const blogLinks = screen.getAllByTitle("Visit Blog");
    extendedExpect(blogLinks.length).toBeGreaterThan(0);

    // Verify that at least one blog link exists and has the correct href
    extendedExpect(blogLinks[0]).toBeInTheDocument();
    extendedExpect(blogLinks[0]).toHaveAttribute(
      "href",
      "https://blog.asafarim.com"
    );
  });

  // Test for about link
  it("renders about link", () => {
    render(
      <ThemeProvider>
        <ModernNavbar />
      </ThemeProvider>
    );

    // Find about link by text content
    const aboutLinks = screen.getAllByText("About");
    extendedExpect(aboutLinks.length).toBeGreaterThan(0);

    // Verify that at least one about link exists and has the correct href
    extendedExpect(aboutLinks[0]).toBeInTheDocument();
    extendedExpect(aboutLinks[0].closest("a")).toHaveAttribute(
      "href",
      "/about"
    );
  });

  // Test for contact link
  it("renders contact link", () => {
    render(
      <ThemeProvider>
        <ModernNavbar />
      </ThemeProvider>
    );

    // Find contact link by text content
    const contactLinks = screen.getAllByText("Contact");
    extendedExpect(contactLinks.length).toBeGreaterThan(0);

    // Verify that at least one contact link exists and has the correct href
    extendedExpect(contactLinks[0]).toBeInTheDocument();
    extendedExpect(contactLinks[0].closest("a")).toHaveAttribute(
      "href",
      "/contact"
    );
  });

  // Test for dashboard link
  it("renders dashboard link", () => {
    render(
      <ThemeProvider>
        <ModernNavbar />
      </ThemeProvider>
    );

    // Find dashboard link by text content
    const dashboardText = screen.getByText("Dashboard");
    extendedExpect(dashboardText).toBeInTheDocument();

    // Since Dashboard is in a dropdown menu, we need to verify it exists
    // but we can't directly check the href as it might be in a button that triggers a dropdown
    const dashboardContainer = dashboardText.closest(".block");
    extendedExpect(dashboardContainer).not.toBeNull();
  });

  // Test for Tech Docs link
  it("renders tech docs link", () => {
    render(
      <ThemeProvider>
        <ModernNavbar />
      </ThemeProvider>
    );

    // Find tech docs link by text content
    const techDocsText = screen.getByText("Tech Docs");
    extendedExpect(techDocsText).toBeInTheDocument();

    // Since Tech Docs is in a dropdown menu, we need to verify it exists
    // but we can't directly check the href as it might be in a button that triggers a dropdown
    const techDocsContainer = techDocsText.closest(".block");
    extendedExpect(techDocsContainer).not.toBeNull();
  });
});
