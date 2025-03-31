import { describe, it, expect, beforeEach, vi } from 'vitest';
import generateCategoryColors from '../categoryColors';
import determineTextColor from '../determineTextColor';
import { getTheme } from '../themeUtils';

// Mock dependencies
vi.mock('../determineTextColor', () => ({
  default: vi.fn().mockReturnValue('#000000')
}));

vi.mock('../themeUtils', () => ({
  getTheme: vi.fn().mockReturnValue('light')
}));

describe('generateCategoryColors', () => {
  beforeEach(() => {
    vi.clearAllMocks();
    
    // Mock document.documentElement and getComputedStyle
    global.document = {
      documentElement: {},
    } as any;
    
    global.getComputedStyle = vi.fn().mockReturnValue({
      getPropertyValue: vi.fn((prop) => {
        if (prop === '--ts-pallette-bgGooglePrimary') {
          return '#e8f0fe, #d2e3fc, #aecbfa, #8ab4f8, #4285f4, #1a73e8, #1967d2, #185abc, #174ea6, #1a4699';
        }
        if (prop === '--ts-pallette-GooglePrimary') {
          return '#000000, #000000, #000000, #000000, #ffffff, #ffffff, #ffffff, #ffffff, #ffffff, #ffffff';
        }
        return '';
      })
    });
  });

  it('should generate colors for categories', () => {
    const categories = ['React', 'Vue', 'Angular'];
    const result = generateCategoryColors(categories);
    
    // Check if all categories have colors assigned
    expect(result.React).toBeDefined();
    expect(result.Vue).toBeDefined();
    expect(result.Angular).toBeDefined();
    
    // Check if each category has the correct structure
    expect(result.React).toHaveProperty('color');
    expect(result.React).toHaveProperty('textColor');
    expect(result.React).toHaveProperty('categories');
    
    // Check if determineTextColor was called
    expect(determineTextColor).toHaveBeenCalled();
    
    // Check if getTheme was called
    expect(getTheme).toHaveBeenCalled();
    
    // Check if default category is created
    expect(result.default).toBeDefined();
  });

  it('should handle empty categories array', () => {
    const result = generateCategoryColors([]);
    
    // Should still create a default category
    expect(result.default).toBeDefined();
    expect(result.default.categories).toEqual(['default']);
  });
});
