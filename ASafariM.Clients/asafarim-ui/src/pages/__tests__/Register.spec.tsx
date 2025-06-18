import { render, screen, fireEvent, waitFor } from "@testing-library/react";
import { BrowserRouter } from "react-router-dom";
import Register from "../Accountpage/Register";
import { ThemeProvider } from "@/contexts/ThemeContext";
import React from "react";

// Mock ModernNavbar to prevent filepath split errors
vi.mock("@/layout/Navbar/ModernNavbar", () => ({
  default: () => null, // or: () => <div data-testid="mock-navbar" />
}));

const mockNavigate = vi.fn();

// Mock all necessary dependencies
vi.mock("@/api/authapi", () => ({
  register: vi.fn(() => Promise.resolve({ message: "Success" })),
}));

vi.mock("@/contexts/AuthContext", () => ({
  useAuth: () => ({
    authenticated: false,
    authenticatedUser: null,
    token: null,
    login: vi.fn(),
    logout: vi.fn(),
    refreshToken: vi.fn(),
  }),
}));

vi.mock("@/contexts/ThemeContext", () => ({
  ThemeProvider: ({ children }: { children: React.ReactNode }) => children,
  useTheme: () => ({
    theme: "light",
    toggleTheme: vi.fn(),
  }),
}));

vi.mock("react-router-dom", async (importOriginal) => {
  const actual = await importOriginal<typeof import("react-router-dom")>();
  return {
    ...actual,
    useNavigate: () => mockNavigate,
    useLocation: () => ({ search: "" }),
  };
});

describe("Register Component", () => {
  beforeEach(() => {
    vi.clearAllMocks();
    render(
      <BrowserRouter>
        <ThemeProvider>
          <Register />
        </ThemeProvider>
      </BrowserRouter>
    );
  });

  afterEach(() => {
    vi.clearAllMocks();
  });

  // Rest of the test cases remain the same...
  it("renders all form inputs", () => {
    expect(screen.getByLabelText(/First Name/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Last Name/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Username/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Email/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/^Password:/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Confirm Password/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Date of Birth/i)).toBeInTheDocument();
    expect(screen.getByLabelText(/Profile Picture URL/i)).toBeInTheDocument();
  });

  it("shows password mismatch error", async () => {
    fireEvent.change(screen.getByLabelText(/First Name/i), {
      target: { value: "Ali" },
    });
    fireEvent.change(screen.getByLabelText(/Last Name/i), {
      target: { value: "Safari" },
    });
    fireEvent.change(screen.getByLabelText(/Username/i), {
      target: { value: "alisafari" },
    });
    fireEvent.change(screen.getByLabelText(/Email/i), {
      target: { value: "ali@example.com" },
    });
    fireEvent.change(screen.getByLabelText(/^Password:/i), {
      target: { value: "Password1!" },
    });
    fireEvent.change(screen.getByLabelText(/Confirm Password/i), {
      target: { value: "Password2!" },
    });

    fireEvent.click(screen.getByRole("button", { name: /register/i }));

    await waitFor(() => {
      expect(
        screen.getByTestId("error-message")
      ).toHaveTextContent("Passwords do not match");
    });
  });

  it("navigates to login after successful registration", async () => {
    fireEvent.change(screen.getByLabelText(/First Name/i), {
      target: { value: "Ali" },
    });
    fireEvent.change(screen.getByLabelText(/Last Name/i), {
      target: { value: "Safari" },
    });
    fireEvent.change(screen.getByLabelText(/Username/i), {
      target: { value: "alisafari" },
    });
    fireEvent.change(screen.getByLabelText(/Email/i), {
      target: { value: "ali@example.com" },
    });
    fireEvent.change(screen.getByLabelText(/^Password:/i), {
      target: { value: "Password1!" },
    });
    fireEvent.change(screen.getByLabelText(/Confirm Password/i), {
      target: { value: "Password1!" },
    });

    fireEvent.click(screen.getByRole("button", { name: /register/i }));

    await waitFor(() => {
      expect(screen.getByTestId("success-message")).toBeInTheDocument();
    });
  });
});