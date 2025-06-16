import { renderHook, act } from '@testing-library/react';
import { describe, it, vi, beforeEach, afterEach } from 'vitest';
import { expect } from '@/test-utils/setup-test-env';
import { useTheme, ThemeProvider } from '@/contexts/ThemeContext';
import React from 'react';

describe('useTheme', () => {
  // Mock localStorage
  const localStorageMock = (() => {
    let store: Record<string, string> = {};
    return {
      getItem: vi.fn((key: string) => store[key] || null),
      setItem: vi.fn((key: string, value: string) => {
        store[key] = value;
      }),
      removeItem: vi.fn((key: string) => {
        delete store[key];
      }),
      clear: vi.fn(() => {
        store = {};
      })
    };
  })();

  // Mock document.documentElement
  const documentElementMock = {
    setAttribute: vi.fn()
  };

  beforeEach(() => {
    // Setup mocks
    Object.defineProperty(window, 'localStorage', { value: localStorageMock });
    Object.defineProperty(document, 'documentElement', { value: documentElementMock });
    
    // Clear localStorage before each test
    localStorageMock.clear();
  });

  afterEach(() => {
    vi.clearAllMocks();
  });

  // Wrapper component for the hook
  const wrapper = ({ children }: { children: React.ReactNode }) => (
    <ThemeProvider>{children}</ThemeProvider>
  );

  it('should use light theme by default when localStorage is empty', () => {
    const { result } = renderHook(() => useTheme(), { wrapper });
    
    expect(result.current.theme).toBe('light');
    expect(localStorageMock.getItem).toHaveBeenCalledWith('theme');
    expect(documentElementMock.setAttribute).toHaveBeenCalledWith('data-theme', 'light');
  });

  it('should use theme from localStorage if available', () => {
    // Set theme in localStorage
    localStorageMock.getItem.mockReturnValueOnce('dark');
    
    const { result } = renderHook(() => useTheme(), { wrapper });
    
    expect(result.current.theme).toBe('dark');
    expect(localStorageMock.getItem).toHaveBeenCalledWith('theme');
  });

  it('should toggle theme from light to dark', () => {
    const { result } = renderHook(() => useTheme(), { wrapper });
    
    // Initial theme should be light
    expect(result.current.theme).toBe('light');
    
    // Toggle theme
    act(() => {
      result.current.toggleTheme();
    });
    
    // Theme should now be dark
    expect(result.current.theme).toBe('dark');
    expect(localStorageMock.setItem).toHaveBeenCalledWith('theme', 'dark');
    expect(documentElementMock.setAttribute).toHaveBeenCalledWith('data-theme', 'dark');
  });

  it('should toggle theme from dark to light', () => {
    // Set initial theme to dark
    localStorageMock.getItem.mockReturnValueOnce('dark');
    
    const { result } = renderHook(() => useTheme(), { wrapper });
    
    // Initial theme should be dark
    expect(result.current.theme).toBe('dark');
    
    // Toggle theme
    act(() => {
      result.current.toggleTheme();
    });
    
    // Theme should now be light
    expect(result.current.theme).toBe('light');
    expect(localStorageMock.setItem).toHaveBeenCalledWith('theme', 'light');
    expect(documentElementMock.setAttribute).toHaveBeenCalledWith('data-theme', 'light');
  });

  it('should throw error when used outside ThemeProvider', () => {
    // Suppress error logging for this test
    const consoleErrorSpy = vi.spyOn(console, 'error').mockImplementation(() => {});
    
    // Try to use hook without provider
    expect(() => {
      renderHook(() => useTheme());
    }).toThrow('useTheme must be used within a ThemeProvider');
    
    // Restore console.error
    consoleErrorSpy.mockRestore();
  });
});