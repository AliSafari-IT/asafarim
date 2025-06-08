# Timeout Issue Resolution Guide

## Overview
The timeout improvements include several new features to better handle slow network conditions and provide users with control over API timeout settings.

## What's Been Added

### 1. Enhanced Error Handling
- Better timeout detection with specific error messages
- Reduced default timeout from 30s to 15s for better user experience
- Consistent error handling across all API functions
- Detailed error logging for debugging

### 2. Configurable API Settings
- **File**: `/src/config/apiConfig.ts`
- Predefined configurations for different network speeds
- User-customizable settings stored in localStorage
- Environment variable support for default configuration

### 3. Retry Logic
- Automatic retry for failed requests (configurable)
- Exponential backoff between retries
- Smart retry logic that doesn't retry client errors (4xx)
- Configurable number of retry attempts

### 4. Connection Monitoring
- **Hook**: `/src/hooks/useApiConfig.ts`
- Real-time connection health monitoring
- Latency measurement
- Automatic configuration recommendations based on connection speed

### 5. User Interface Components
- **ConnectionStatus Component**: Shows connection health and allows configuration
- **TimeoutNotification Component**: Alerts users to connection issues with suggested fixes

## Usage Examples

### Basic Integration in Your App

```tsx
// In your main App component or layout
import { TimeoutNotification } from '@/components/TimeoutNotification';
import { ConnectionStatus } from '@/components/ConnectionStatus';

function App() {
  return (
    <div>
      {/* Your existing app content */}
      
      {/* Add timeout notification for automatic issue detection */}
      <TimeoutNotification />
      
      {/* Optional: Add connection status in header/footer */}
      <ConnectionStatus showDetails={false} className="ml-auto" />
    </div>
  );
}
```

### Manual Configuration

```tsx
// For admin panels or settings pages
import { ConnectionStatus } from '@/components/ConnectionStatus';

function SettingsPage() {
  return (
    <div>
      <h1>Network Settings</h1>
      <ConnectionStatus showDetails={true} className="max-w-md" />
    </div>
  );
}
```

### Programmatic Configuration

```tsx
import { updateApiConfig } from '@/config/apiConfig';

// For slow networks
updateApiConfig({
  timeout: 30000,    // 30 seconds
  maxRetries: 3,     // 3 retry attempts
  retryDelay: 2000   // 2 second delay between retries
});

// For fast networks
updateApiConfig({
  timeout: 8000,     // 8 seconds
  maxRetries: 1,     // 1 retry attempt
  retryDelay: 500    // 0.5 second delay
});
```

### Environment Configuration

Add to your `.env` file:

```env
# For development with slow local network
VITE_NETWORK_SPEED=slow

# For production with fast CDN
VITE_NETWORK_SPEED=fast

# To disable retries for debugging
VITE_NETWORK_SPEED=no-retry
```

## Configuration Options

### Timeout Settings
- **timeout**: Request timeout in milliseconds (1000-60000)
- **maxRetries**: Number of retry attempts (0-5)
- **retryDelay**: Base delay between retries in milliseconds
- **enableRetry**: Whether to enable retry logic

### Predefined Configurations
- **Default**: 15s timeout, 2 retries, 1s delay
- **Fast Network**: 8s timeout, 1 retry, 0.5s delay
- **Slow Network**: 30s timeout, 3 retries, 2s delay
- **No Retry**: 15s timeout, 0 retries (for debugging)

## Troubleshooting

### If you're still getting timeouts:

1. **Check your network speed**: Use the ConnectionStatus component to measure latency
2. **Apply recommended settings**: The system will suggest optimal settings based on your connection
3. **Manual configuration**: Use custom settings for your specific environment
4. **Server-side issues**: If latency is consistently high, check your backend server performance

### Common Solutions:

- **Slow network**: Increase timeout to 30s, enable 3 retries
- **Unstable connection**: Enable retry logic with longer delays
- **Fast but busy network**: Keep timeout moderate but reduce retries
- **Development environment**: Use no-retry configuration for easier debugging

## Monitoring

The system automatically tracks:
- Connection success/failure rates
- Response latency
- Consecutive failures
- Recommended configuration changes

Users will be automatically notified when connection issues are detected and provided with suggested solutions.
