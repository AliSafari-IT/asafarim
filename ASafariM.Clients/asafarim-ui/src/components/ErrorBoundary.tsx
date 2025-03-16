import { Component, ErrorInfo, ReactNode } from 'react';
import {logger} from '@/utils/logger';

interface Props {
  children: ReactNode;
  fallback?: ReactNode;
}

interface State {
  hasError: boolean;
  error: Error | null;
}

/**
 * ErrorBoundary component that catches JavaScript errors in its child component tree.
 * It logs the errors and displays a fallback UI instead of crashing the whole app.
 */
class ErrorBoundary extends Component<Props, State> {
  constructor(props: Props) {
    super(props);
    this.state = { 
      hasError: false,
      error: null
    };
  }

  static getDerivedStateFromError(error: Error): State {
    // Update state so the next render will show the fallback UI
    return { 
      hasError: true,
      error 
    };
  }

  componentDidCatch(error: Error, errorInfo: ErrorInfo): void {
    // Log the error to an error reporting service
    logger.error('ErrorBoundary caught an error:', error, errorInfo);
  }

  render(): ReactNode {
    if (this.state.hasError) {
      // You can render any custom fallback UI
      return this.props.fallback || (
        <div style={{
          padding: '20px',
          margin: '10px',
          borderRadius: '8px',
          backgroundColor: '#f8f9fa',
          border: '1px solid #e9ecef',
          color: '#495057'
        }}>
          <h3 style={{ color: '#dc3545', marginTop: 0 }}>Something went wrong</h3>
          <p>The component could not be rendered. Please try refreshing the page.</p>
          <details style={{ 
            whiteSpace: 'pre-wrap',
            backgroundColor: '#f1f3f5', 
            padding: '10px', 
            borderRadius: '4px',
            marginTop: '10px',
            fontSize: '12px'
          }}>
            <summary>Error details</summary>
            {this.state.error?.toString()}
          </details>
        </div>
      );
    }

    return this.props.children;
  }
}

export default ErrorBoundary;
