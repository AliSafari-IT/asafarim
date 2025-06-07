import { describe, it, expect, vi, beforeEach } from "vitest";
import { render, screen, waitFor } from "@testing-library/react";
import AnalyticsPage from "../Analytics/AnalyticsPage";
import * as analyticsService from "@/services/analyticsService";
import * as logger from "@/utils/logger";

// Mock logger
vi.mock("@/utils/logger", () => ({
  logger: {
    error: vi.fn(),
  },
}));

// Mock Layout, Header, Footer
vi.mock("@/layout/Layout", () => ({
  default: ({ header, footer, children }: any) => (
    <div data-testid="mock-layout">
      {header}
      <main>{children}</main>
      {footer}
    </div>
  ),
}));
vi.mock("@/layout/Header/Header", () => ({
  default: () => <div data-testid="mock-header">Header</div>,
}));
vi.mock("@/layout/Footer/Footer", () => ({
  default: () => <div data-testid="mock-footer">Footer</div>,
}));

describe("AnalyticsPage", () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  it("renders loading state initially", async () => {
    vi.spyOn(analyticsService, "getVisitorStats").mockResolvedValueOnce({
      totalVisitors: 0,
    });

    render(<AnalyticsPage />);
    expect(screen.getByText(/loading analytics data/i)).toBeInTheDocument();

    await waitFor(() => {
      expect(screen.getByText(/visitor analytics/i)).toBeInTheDocument();
    });
  });

  it("renders analytics data correctly", async () => {
    vi.spyOn(analyticsService, "getVisitorStats").mockResolvedValueOnce({
      totalVisitors: 1234,
    });

    render(<AnalyticsPage />);

    await waitFor(() => {
      expect(screen.getByText("1.234")).toBeInTheDocument();
      expect(screen.getByText("4319")).toBeInTheDocument(); // 1234 * 3.5
      expect(screen.getByText("2m 45s")).toBeInTheDocument();
    });
  });

  it("logs an error if data fetching fails", async () => {
    const loggerError = vi.spyOn(logger.logger, "error");
    vi.spyOn(analyticsService, "getVisitorStats").mockRejectedValueOnce(
      new Error("Fetch failed")
    );

    render(<AnalyticsPage />);

    await waitFor(() => {
      expect(loggerError).toHaveBeenCalledWith(
        "Error fetching analytics data:",
        expect.any(Error)
      );
    });
  });
});
