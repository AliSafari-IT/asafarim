import { renderHook, waitFor } from '@testing-library/react';
import { describe, it, vi, beforeEach, afterEach } from 'vitest';
import { expect } from '@/test-utils/setup-test-env';
import useMarkdown from '@/hooks/useMarkdown';
import { logger } from '@/utils/logger';

// Mock the logger
vi.mock('@/utils/logger', () => ({
  logger: {
    log: vi.fn(),
    error: vi.fn(),
    debug: vi.fn(),
    warn: vi.fn()
  }
}));

describe('useMarkdown', () => {
  beforeEach(() => {
    // Setup fetch mock for each test
    global.fetch = vi.fn();
  });

  afterEach(() => {
    vi.resetAllMocks();
  });

  it('should fetch and return markdown content', async () => {
    // Mock successful fetch response
    (global.fetch as any).mockResolvedValueOnce({
      ok: true,
      text: () => Promise.resolve('# Mock Markdown Content')
    });

    const { result } = renderHook(() => useMarkdown('/mock-path/mock.md'));

    // Initially should be loading
    expect(result.current.loading).toBe(true);
    expect(result.current.error).toBeNull();
    
    // Wait for the async operation to complete
    await waitFor(() => expect(result.current.loading).toBe(false));
    
    // Check final state
    expect(result.current.error).toBeNull();
    expect(result.current.markdownContent).toBe('# Mock Markdown Content');
    expect(global.fetch).toHaveBeenCalledWith('/mock-path/mock.md');
  });

  it('should handle fetch error', async () => {
    // Mock failed fetch response
    (global.fetch as any).mockResolvedValueOnce({
      ok: false,
      statusText: 'Not Found'
    });

    const { result } = renderHook(() => useMarkdown('/invalid-path/mock.md'));

    // Initially should be loading
    expect(result.current.loading).toBe(true);
    
    // Wait for the async operation to complete
    await waitFor(() => expect(result.current.loading).toBe(false));
    
    // Check error state
    expect(result.current.loading).toBe(false);
    expect(result.current.error).toBe('Failed to load markdown file.');
    expect(result.current.markdownContent).toBe('');
    expect(logger.error).toHaveBeenCalled();
  });

  it('should not fetch if no filePath is provided', async () => {
    const { result } = renderHook(() => useMarkdown(''));

    // Wait a bit to ensure any potential fetch would have been called
    await new Promise(resolve => setTimeout(resolve, 10));
    
    // Fetch should not have been called
    expect(global.fetch).not.toHaveBeenCalled();
    
    // Should still be in loading state
    expect(result.current.loading).toBe(true);
    expect(result.current.error).toBeNull();
    expect(result.current.markdownContent).toBe('');
  });
});