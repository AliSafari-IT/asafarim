import { describe, it, expect, vi, beforeEach } from 'vitest';
import { apiUrls } from '../getApiUrls';
import { logger } from '@/utils/logger'; // Import mocked logger here!

// Mock the logger
vi.mock('@/utils/logger', () => ({
  logger: {
    log: vi.fn(),
    info: vi.fn(),
    warn: vi.fn(),
    error: vi.fn(),
  },
}));

beforeEach(() => {
  vi.resetModules();
  vi.clearAllMocks();
  delete process.env.NODE_ENV;
  delete process.env.REACT_APP_API_PORT;
});

describe('apiUrls', () => {
  it('returns production URL for known host', () => {
    const host = 'blog.asafarim.com';
    const result = apiUrls(host);
    expect(result).toBe('https://blog.asafarim.com/api');
  });

  it('returns fallback localhost URL for unknown host', () => {
    const host = 'unknownhost.local';
    process.env.REACT_APP_API_PORT = '6000';
    const result = apiUrls(host);
    expect(result).toBe('http://localhost:6000/api');
  });

  it('defaults to port 5000 if REACT_APP_API_PORT is not set', () => {
    const host = 'localhost';
    const result = apiUrls(host);
    expect(result).toBe('http://localhost:5000/api');
  });

  it('handles error and returns fallback URL', () => {
    const brokenHost = undefined as unknown as string;
    const result = apiUrls(brokenHost);
    expect(result).toBe('http://localhost:5000/api');
  });

  it('logs all environments and resolutions', () => {
    const host = 'asafarim.com';
    process.env.NODE_ENV = 'production';
    const result = apiUrls(host);

    expect(logger.info).toHaveBeenCalledWith(
      'Environment:', 'production', 'Host:', host, 'isDevelopment:', false
    );
    expect(logger.info).toHaveBeenCalledWith('Resolved API URL:', result);
  });
});
