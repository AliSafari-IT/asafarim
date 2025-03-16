import { Component, ErrorInfo, ReactNode } from "react";
import { logger } from "@/utils/logger";

interface Props {
  children: ReactNode;
  fallback?: ReactNode;
}

interface State {
  hasError: boolean;
  error: Error | null;
}

class ChartErrorBoundary extends Component<Props, State> {
  public state: State = {
    hasError: false,
    error: null,
  };

  public static getDerivedStateFromError(error: Error): State {
    return { hasError: true, error };
  }

  public componentDidCatch(error: Error, errorInfo: ErrorInfo) {
    logger.error("Chart Error:", error);
    logger.error("Error Info:", errorInfo);
  }

  public render() {
    if (this.state.hasError) {
      return (
        this.props.fallback || (
          <div className="p-4 bg-red-50 dark:bg-red-900/20 border border-red-200 dark:border-red-800 rounded-lg">
            <h3 className="text-red-800 dark:text-red-200 font-medium">
              Chart Error
            </h3>
            <p className="text-red-600 dark:text-red-300 text-sm mt-1">
              {this.state.error?.message ||
                "An error occurred while rendering the chart."}
            </p>
          </div>
        )
      );
    }

    return this.props.children;
  }
}

export default ChartErrorBoundary;
