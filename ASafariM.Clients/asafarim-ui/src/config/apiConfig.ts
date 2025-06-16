// API Configuration for timeout and network settings
// Adjust these values based on your network conditions and server response times

export interface ApiConfig {
    timeout: number;           // Request timeout in milliseconds
    maxRetries: number;        // Maximum number of retry attempts
    retryDelay: number;        // Base delay between retries in milliseconds
    enableRetry: boolean;      // Whether to enable retry logic
}

// Default configuration - optimized for most network conditions
export const defaultApiConfig: ApiConfig = {
    timeout: 15000,     // 15 seconds - good balance between responsiveness and allowing slow responses
    maxRetries: 2,      // 2 retry attempts for failed requests
    retryDelay: 1000,   // 1 second base delay between retries
    enableRetry: true   // Enable retry logic by default
};

// Fast network configuration - for users with reliable, fast connections
export const fastNetworkConfig: ApiConfig = {
    timeout: 8000,      // 8 seconds - faster timeout for quick networks
    maxRetries: 1,      // Only 1 retry attempt
    retryDelay: 500,    // 0.5 second delay
    enableRetry: true
};

// Slow network configuration - for users with slower or unreliable connections
export const slowNetworkConfig: ApiConfig = {
    timeout: 30000,     // 30 seconds - longer timeout for slow networks
    maxRetries: 3,      // More retry attempts
    retryDelay: 2000,   // 2 second delay between retries
    enableRetry: true
};

// No retry configuration - for debugging or when retries are not desired
export const noRetryConfig: ApiConfig = {
    timeout: 15000,     // Standard timeout
    maxRetries: 0,      // No retries
    retryDelay: 0,      // No delay needed
    enableRetry: false  // Disable retry logic
};

// Get configuration based on environment or user preference
export const getApiConfig = (): ApiConfig => {
    // Check if there's a user preference stored in localStorage
    const userConfigString = localStorage.getItem('api-config');
    if (userConfigString) {
        try {
            const userConfig = JSON.parse(userConfigString);
            return { ...defaultApiConfig, ...userConfig };
        } catch (error) {
            console.warn('Invalid API config in localStorage, using default config');
        }
    }

    // Check environment variable for network speed hint
    const networkHint = import.meta.env.VITE_NETWORK_SPEED;
    switch (networkHint) {
        case 'fast':
            return fastNetworkConfig;
        case 'slow':
            return slowNetworkConfig;
        case 'no-retry':
            return noRetryConfig;
        default:
            return defaultApiConfig;
    }
};

// Function to update API configuration at runtime
export const updateApiConfig = (newConfig: Partial<ApiConfig>): void => {
    const currentConfig = getApiConfig();
    const updatedConfig = { ...currentConfig, ...newConfig };
    localStorage.setItem('api-config', JSON.stringify(updatedConfig));
    
    // Dispatch event to notify components about config change
    window.dispatchEvent(new CustomEvent('api-config-changed', { 
        detail: updatedConfig 
    }));
};
