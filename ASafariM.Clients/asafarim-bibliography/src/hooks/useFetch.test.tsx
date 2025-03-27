import { renderHook, act } from '@testing-library/react';
import useFetch from '../hooks/useFetch';
import { vi } from 'vitest';

describe('useFetch', () => {
  const mockJson = { message: 'Success' };

  beforeEach(() => {
    vi.clearAllMocks();
    global.fetch = vi.fn();
  });

  it('should fetch data on mount by default', async () => {
    (fetch as any).mockResolvedValueOnce({
      ok: true,
      json: async () => mockJson,
      headers: { get: () => 'application/json' },
    });

    const { result } = renderHook(() =>
      useFetch('https://api.example.com/data')
    );

    expect(result.current.loading).toBe(true);

    await act(async () => {
      // wait for fetch to resolve
    });

    expect(result.current.data).toEqual(mockJson);
    expect(result.current.loading).toBe(false);
    expect(result.current.error).toBe(null);
  });

  it('should not fetch on mount if immediate is false', () => {
    const { result } = renderHook(() =>
      useFetch('https://api.example.com/data', { immediate: false })
    );

    expect(result.current.data).toBe(null);
    expect(result.current.loading).toBe(false);
  });

  it('should refetch data manually', async () => {
    (fetch as any).mockResolvedValueOnce({
      ok: true,
      json: async () => mockJson,
      headers: { get: () => 'application/json' },
    });

    const { result } = renderHook(() =>
      useFetch('https://api.example.com/data')
    );

    expect(result.current.data).toBe(null);
    expect(result.current.loading).toBe(true);

    await act(async () => {
      result.current.refetch();
    });

    expect(result.current.data).toEqual(mockJson);
    expect(result.current.loading).toBe(false);
    expect(result.current.error).toBe(null);
  });
});
