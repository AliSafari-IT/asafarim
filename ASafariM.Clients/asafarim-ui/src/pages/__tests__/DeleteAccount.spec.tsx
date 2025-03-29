import { render, screen, fireEvent } from "@testing-library/react";
import { BrowserRouter } from "react-router-dom";
import DeleteAccount from "../User/DeleteAccount";
import { describe, it, vi, beforeEach, expect } from "vitest";
import { IUserInfo } from "@/interfaces";

// Mock userService
vi.mock("@/api/userService", () => ({
  deleteUser: vi.fn(),
}));

vi.mock("@/utils/logger", () => ({
  logger: {
    debug: vi.fn(),
    error: vi.fn(),
  },
}));

const mockNavigate = vi.fn();
vi.mock("react-router-dom", async () => {
  const actual = await vi.importActual("react-router-dom");
  return {
    ...actual,
    useNavigate: () => mockNavigate,
  };
});

const renderComponent = (user: IUserInfo | null) =>
  render(
    <BrowserRouter>
      <DeleteAccount currentUserInfo={user} />
    </BrowserRouter>
  );

describe("DeleteAccount", () => {
  const validUser = {
    id: "123",
    userName: "test",
    email: "test@example.com",
    isAdmin: false,
  };

  beforeEach(() => {
    vi.clearAllMocks();
    localStorage.clear();
    sessionStorage.clear();
  });

  it("shows initial warning screen", () => {
    renderComponent(validUser);
    expect(screen.getByText(/Delete Account/i)).toBeInTheDocument();
    expect(
      screen.getByText(/This action cannot be undone/i)
    ).toBeInTheDocument();
  });

  it("transitions to confirmation step when button is clicked", () => {
    renderComponent(validUser);
    fireEvent.click(screen.getByText(/I understand, delete my account/i));
    expect(screen.getByText(/Confirm Account Deletion/i)).toBeInTheDocument();
  });
});
