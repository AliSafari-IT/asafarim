import { renderHook, waitFor } from '@testing-library/react';
import { describe, it, expect, vi, beforeEach, afterEach } from 'vitest';
import useTechDocs from '@/hooks/useTechDocs';
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

describe('useTechDocs', () => {
  beforeEach(() => {
    // Setup fetch mock for each test
    global.fetch = vi.fn();
  });

  afterEach(() => {
    vi.resetAllMocks();
  });

  it('should fetch and return tech docs', async () => {
    // Mock tech docs data
    const mockTechDocs = [
      {
        name: 'React',
        path: '/docs/react',
        slug: 'react',
        isDirectory: true,
        children: [
          {
            name: 'Getting Started',
            path: '/docs/react/getting-started',
            slug: 'getting-started',
            isDirectory: false
          },
          {
            name: 'Hooks',
            path: '/docs/react/hooks',
            slug: 'hooks',
            isDirectory: false
          }
        ]
      },
      {
        name: 'TypeScript',
        path: '/docs/typescript',
        slug: 'typescript',
        isDirectory: true,
        children: [
          {
            name: 'Introduction',
            path: '/docs/typescript/introduction',
            slug: 'introduction',
            isDirectory: false
          }
        ]
      }
    ];

    // Mock successful fetch response
    (global.fetch as any).mockResolvedValueOnce({
      ok: true,
      json: () => Promise.resolve(mockTechDocs)
    });

    const { result } = renderHook(() => useTechDocs());

    // Initially should be empty array
    expect(result.current).toEqual([]);
    
    // Wait for the async operation to complete
    await waitFor(() => expect(result.current.length).toBeGreaterThan(0));
    
    // Check final state
    expect(result.current).toEqual(mockTechDocs);
    expect(global.fetch).toHaveBeenCalledWith('/api/markdown-files');
  });

  it('should handle fetch error', async () => {
    // Mock fetch error
    const mockError = new Error('Network error');
    (global.fetch as any).mockRejectedValueOnce(mockError);

    const { result } = renderHook(() => useTechDocs());

    // Initially should be empty array
    expect(result.current).toEqual([]);
    
    // Wait a bit to ensure the fetch promise is rejected
    await new Promise(resolve => setTimeout(resolve, 10));
    
    // State should still be empty array
    expect(result.current).toEqual([]);
    
    // Logger should have been called with error
    expect(logger.error).toHaveBeenCalledWith('Failed to fetch tech docs:', mockError);
  });

  it('should handle empty response', async () => {
    // Mock empty response
    (global.fetch as any).mockResolvedValueOnce({
      ok: true,
      json: () => Promise.resolve([])
    });

    const { result } = renderHook(() => useTechDocs());

    // Initially should be empty array
    expect(result.current).toEqual([]);
    
    // Wait for the async operation to complete
    await waitFor(() => expect(global.fetch).toHaveBeenCalled());
    
    // State should still be empty array
    expect(result.current).toEqual([]);
  });
});