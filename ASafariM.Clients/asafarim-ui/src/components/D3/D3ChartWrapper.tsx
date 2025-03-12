import React, { useEffect, useState, ReactNode } from 'react';
import ErrorBoundary from '@/components/ErrorBoundary';

interface D3ChartWrapperProps {
  children: ReactNode;
  chartName: string;
  width?: number;
  height?: number;
}

/**
 * A wrapper component for D3 charts that ensures they only render on the client side
 * and provides multiple render attempts to ensure proper rendering in production.
 */
const D3ChartWrapper: React.FC<D3ChartWrapperProps> = ({ 
  children, 
  chartName,
  width = 700,
  height = 400
}) => {
  const [isMounted, setIsMounted] = useState(false);
  const [renderAttempt, setRenderAttempt] = useState(0);
  
  // Only render on client-side
  useEffect(() => {
    setIsMounted(true);
    
    // Schedule multiple render attempts with increasing delays
    const timers = [
      setTimeout(() => {
        console.log(`[${chartName}] First render attempt`);
        setRenderAttempt(1);
      }, 50),
      setTimeout(() => {
        console.log(`[${chartName}] Second render attempt`);
        setRenderAttempt(2);
      }, 300),
      setTimeout(() => {
        console.log(`[${chartName}] Third render attempt`);
        setRenderAttempt(3);
      }, 1000)
    ];
    
    return () => {
      timers.forEach(timer => clearTimeout(timer));
    };
  }, [chartName]);
  
  // Show a loading placeholder during SSR or when not mounted
  if (!isMounted) {
    return (
      <div 
        style={{ 
          width: `${width}px`, 
          height: `${height}px`, 
          position: 'relative',
          borderRadius: '8px',
          boxShadow: '0 4px 6px rgba(0,0,0,0.05)',
          background: 'white',
          padding: '16px',
          display: 'flex',
          alignItems: 'center',
          justifyContent: 'center'
        }}
      >
        <div style={{ display: 'flex', alignItems: 'center' }}>
          <svg width="20" height="20" viewBox="0 0 24 24" style={{ 
            marginRight: '8px', 
            animation: 'spin 1s linear infinite'
          }}>
            <circle cx="12" cy="12" r="10" fill="none" stroke="#ccc" strokeWidth="3" />
            <path fill="none" stroke="#666" strokeWidth="3" d="M12 2a10 10 0 0 1 10 10" />
          </svg>
          Loading {chartName} chart...
        </div>
        <style>
          {`
            @keyframes spin {
              0% { transform: rotate(0deg); }
              100% { transform: rotate(360deg); }
            }
          `}
        </style>
      </div>
    );
  }
  
  // Wrap the chart in an ErrorBoundary to catch any rendering errors
  return (
    <ErrorBoundary fallback={<div>Error loading {chartName} chart</div>}>
      <div data-render-attempt={renderAttempt}>
        {children}
      </div>
    </ErrorBoundary>
  );
};

export default D3ChartWrapper;
