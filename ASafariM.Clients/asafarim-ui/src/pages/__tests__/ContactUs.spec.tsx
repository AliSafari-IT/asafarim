import { describe, it, expect, vi, beforeEach } from "vitest";
import { render, screen } from "@testing-library/react";
import ContactUs from "../Contact";
import React from "react";

// Mocks for subcomponents
vi.mock("@/layout/Layout", () => ({
  default: ({ children }: { children: React.ReactNode }) => (
    <div data-testid="mock-layout">{children}</div>
  ),
}));

vi.mock("../Contact/components/ContactInfo", () => ({
  default: () => <div data-testid="mock-contact-info">Contact Info</div>,
}));

vi.mock("../Contact/components/ContactForm", () => ({
  default: () => <div data-testid="mock-contact-form">Contact Form</div>,
}));

vi.mock("../Contact/components/AvailabilitySection", () => ({
  default: () => <div data-testid="mock-availability">Availability</div>,
}));

vi.mock("../Contact/components/FutureSkillsSection", () => ({
  default: () => <div data-testid="mock-future-skills">Future Skills</div>,
}));

describe("ContactUs Page", () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  it("renders page layout and hero header", () => {
    render(<ContactUs />);

    expect(screen.getByTestId("mock-layout")).toBeInTheDocument();
    expect(
      screen.getByRole("heading", { name: /get in touch/i })
    ).toBeInTheDocument();
    expect(
      screen.getByText(/I'm always interested in new opportunities/i)
    ).toBeInTheDocument();
  });

  it("renders all main sections", () => {
    render(<ContactUs />);

    expect(screen.getByTestId("mock-contact-info")).toBeInTheDocument();
    expect(screen.getByTestId("mock-contact-form")).toBeInTheDocument();
    expect(screen.getByTestId("mock-availability")).toBeInTheDocument();
    expect(screen.getByTestId("mock-future-skills")).toBeInTheDocument();
  });

  it("renders Dutch message at the bottom", () => {
    render(<ContactUs />);

    expect(
      screen.getByText(
        /ik ben altijd geïnteresseerd in nieuwe kansen en samenwerkingen/i
      )
    ).toBeInTheDocument();
  });
});
