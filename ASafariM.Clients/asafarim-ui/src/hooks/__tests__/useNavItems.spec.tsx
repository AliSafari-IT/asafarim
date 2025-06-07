import { renderHook } from '@testing-library/react';
import { describe, it, expect, vi, beforeEach } from 'vitest';
import useNavItems from '@/hooks/useNavItems';

// Mock the navItemsList module
vi.mock('@/layout/Navbar/navItemsList', () => {
  const mockNavItems = [
    {
      id: 'dashboard',
      title: 'Dashboard',
      to: '/dashboard',
      icon: {},
      isForNavbar: true
    },
    {
      id: 'about',
      title: 'About',
      to: '/about',
      icon: {},
      isForNavbar: true
    },
    {
      id: 'contact',
      title: 'Contact',
      to: '/contact',
      icon: {},
      isForNavbar: true
    }
  ];
  
  return {
    __esModule: true,
    default: mockNavItems
  };
});

// Mock the logger to prevent console output during tests
vi.mock('@/utils/logger', () => ({
  logger: {
    log: vi.fn(),
    error: vi.fn(),
    debug: vi.fn(),
    warn: vi.fn()
  }
}));

describe('useNavItems', () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  it('should return navigation items', () => {
    const { result } = renderHook(() => useNavItems());
    
    // Check that items are returned
    expect(result.current).toBeDefined();
    expect(Array.isArray(result.current)).toBe(true);
    expect(result.current.length).toBe(3);
  });

  it('should return items with expected structure', () => {
    const { result } = renderHook(() => useNavItems());
    
    // Check structure of returned items
    expect(result.current[0]).toHaveProperty('id', 'dashboard');
    expect(result.current[0]).toHaveProperty('title', 'Dashboard');
    expect(result.current[0]).toHaveProperty('to', '/dashboard');
    expect(result.current[0]).toHaveProperty('icon');
    expect(result.current[0]).toHaveProperty('isForNavbar', true);
  });

  it('should memoize the navigation items', () => {
    // First render
    const { result, rerender } = renderHook(() => useNavItems());
    const firstRenderItems = result.current;
    
    // Re-render the hook
    rerender();
    const secondRenderItems = result.current;
    
    // The items should be the same object reference (memoized)
    expect(secondRenderItems).toBe(firstRenderItems);
  });

  it('should include all required items', () => {
    const { result } = renderHook(() => useNavItems());
    
    // Check that all expected items are present
    const itemIds = result.current.map(item => item.id);
    expect(itemIds).toContain('dashboard');
    expect(itemIds).toContain('about');
    expect(itemIds).toContain('contact');
  });
});