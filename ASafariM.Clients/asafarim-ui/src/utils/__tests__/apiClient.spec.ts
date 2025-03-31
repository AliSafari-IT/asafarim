import { describe, it, expect, beforeEach, vi, afterEach } from 'vitest';
import axios from 'axios';
import { logger } from '@/utils/logger';

// Mock dependencies before importing the module to be tested
vi.mock('axios', () => ({
  default: {
    create: vi.fn(() => ({
      interceptors: {
        request: { use: vi.fn() },
        response: { use: vi.fn() }
      }
    }))
  }
}));

vi.mock('@/utils/logger', () => ({
  logger: {
    debug: vi.fn()
  }
}));

describe('apiClient', () => {
  beforeEach(() => {
    vi.clearAllMocks();
    
    // Mock localStorage
    Object.defineProperty(window, 'localStorage', {
      value: {
        getItem: vi.fn(),
        removeItem: vi.fn()
      },
      writable: true
    });
    
    // Mock window.location
    Object.defineProperty(window, 'location', {
      value: { href: '' },
      writable: true
    });
  });
  
  afterEach(() => {
    vi.unstubAllEnvs();
    vi.resetModules();
  });

  it('should create axios instance with correct base URL', async () => {
    // Set environment variables before importing the module
    vi.stubEnv('VITE_API_URL', 'http://test-api.com');
    vi.stubEnv('VITE_ENVIRONMENT', 'development');
    
    // Import the module after setting up the environment
    await import('../apiClient');
    
    // Verify the axios.create was called with correct parameters
    expect(axios.create).toHaveBeenCalledWith(expect.objectContaining({
      baseURL: 'http://test-api.com',
      headers: {
        'Content-Type': 'application/json'
      }
    }));
    
    expect(logger.debug).toHaveBeenCalled();
  });
});
