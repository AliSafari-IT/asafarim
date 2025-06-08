// Simple test script to verify our timeout management system
const { handleApiError, withRetry, retryRequest } = require('./utils/apiErrorHandler');

// Mock axios error for testing
const mockTimeoutError = {
  code: 'ECONNABORTED',
  message: 'timeout of 30000ms exceeded',
  config: { url: '/api/users', method: 'get' }
};

const mockNetworkError = {
  code: 'NETWORK_ERROR',
  message: 'Network Error',
  config: { url: '/api/users', method: 'get' }
};

const mockServerError = {
  response: {
    status: 500,
    statusText: 'Internal Server Error',
    data: { message: 'Server error' }
  },
  config: { url: '/api/users', method: 'get' }
};

console.log('Testing Timeout Management System');
console.log('================================');

// Test 1: Timeout Error Handling
console.log('\n1. Testing timeout error handling:');
try {
  const timeoutResult = handleApiError(mockTimeoutError);
  console.log('✓ Timeout error handled:', timeoutResult.message);
} catch (error) {
  console.log('✗ Timeout error handling failed:', error.message);
}

// Test 2: Network Error Handling
console.log('\n2. Testing network error handling:');
try {
  const networkResult = handleApiError(mockNetworkError);
  console.log('✓ Network error handled:', networkResult.message);
} catch (error) {
  console.log('✗ Network error handling failed:', error.message);
}

// Test 3: Server Error Handling
console.log('\n3. Testing server error handling:');
try {
  const serverResult = handleApiError(mockServerError);
  console.log('✓ Server error handled:', serverResult.message);
} catch (error) {
  console.log('✗ Server error handling failed:', error.message);
}

// Test 4: API Configuration
console.log('\n4. Testing API configuration:');
const apiConfig = require('./config/apiConfig');
if (apiConfig && apiConfig.timeout) {
  console.log('✓ API timeout configuration loaded:', apiConfig.timeout + 'ms');
} else {
  console.log('✗ API timeout configuration missing');
}

console.log('\n================================');
console.log('Timeout Management System Test Complete');
