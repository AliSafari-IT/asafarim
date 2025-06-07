// src/components/ErrorBoundary.tsx
import { Component, ErrorInfo, ReactNode } from "react";
import {logger} from '@/utils/logger';

interface Props {
  children: ReactNode;
  fallback?: ReactNode;
}

interface State {
  hasError: boolean;
  error: Error | null;
}

class ErrorBoundary extends Component<Props, State> {
  constructor(props: Props) {
    super(props);
    this.state = { hasError: false, error: null };
  }

  static getDerivedStateFromError(error: Error): State {
    return { hasError: true, error };
  }

  componentDidCatch(error: Error, errorInfo: ErrorInfo): void {
    logger.error("Chart error caught:", error, errorInfo);
  }

  render(): ReactNode {
    if (this.state.hasError) {
      return this.props.fallback || (
        <div className="error-boundary p-4 bg-red-50 text-red-800 rounded-lg">
          <h3 className="font-bold">Something went wrong loading this chart</h3>
          <p className="text-sm mt-2">{this.state.error?.message}</p>
          <button 
            className="mt-2 px-4 py-2 bg-red-200 rounded-md"
            onClick={() => this.setState({ hasError: false, error: null })}
          >
            Try again
          </button>
        </div>
      );
    }

    return this.props.children;
  }
}

export default ErrorBoundary;