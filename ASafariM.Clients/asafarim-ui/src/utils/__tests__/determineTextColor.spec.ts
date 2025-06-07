import { describe, it, expect, beforeEach, vi } from 'vitest';
// import { logger } from '@/utils/logger';

// Mock tinycolor2 before importing the module to be tested
vi.mock('tinycolor2', () => {
  return {
    default: function() {
      return {
        isValid: vi.fn().mockReturnValue(true),
        toHexString: vi.fn().mockReturnValue('#FFFFFF')
      };
    }
  };
});

// Add these properties to the tinycolor2 mock
const tinycolorMock = await import('tinycolor2');
tinycolorMock.default.readability = vi.fn().mockReturnValue(5.0);
tinycolorMock.default.mostReadable = vi.fn().mockReturnValue({
  toHexString: vi.fn().mockReturnValue('#FFFFFF')
});

vi.mock('@/utils/logger', () => ({
  logger: {
    warn: vi.fn(),
    debug: vi.fn()
  }
}));

// Import the module after setting up mocks
import determineTextColor from '../determineTextColor';

describe('determineTextColor', () => {
  beforeEach(() => {
    vi.clearAllMocks();
    
    // Mock document.documentElement and getComputedStyle
    global.document = {
      documentElement: {},
    } as any;
    
    global.getComputedStyle = vi.fn().mockReturnValue({
      getPropertyValue: vi.fn().mockReturnValue('#FFFFFF')
    });
  });

  it('should return dark text color for light theme with good contrast', () => {
    // Setup mocks for this test
    (tinycolorMock.default.readability as any).mockReturnValueOnce(5.0);
    
    const result = determineTextColor('light', '#FFFFFF');
    expect(result).toBe('darkblue');
  });

  it('should return light text color for dark theme with good contrast', () => {
    // Setup mocks for this test
    (tinycolorMock.default.readability as any).mockReturnValueOnce(5.0);
    
    const result = determineTextColor('dark', '#000000');
    expect(result).toBe('lightblue');
  });

  it('should use mostReadable when contrast is insufficient', () => {
    // Setup mocks for this test
    (tinycolorMock.default.readability as any).mockReturnValueOnce(3.0); // Below minimum contrast
    
    const result = determineTextColor('light', '#AAAAAA');
    expect(result).toBe('#FFFFFF');
  });

  it('should handle CSS variables', () => {
    const result = determineTextColor('light', 'var(--my-color)');
    expect(global.getComputedStyle).toHaveBeenCalled();
    expect(result).toBeDefined();
  });

  // it('should handle invalid colors', () => {
  //   // Setup mock for invalid color
  //   const isValidMock = vi.fn().mockReturnValueOnce(false);
  //   vi.spyOn(tinycolorMock.default.prototype, 'isValid').mockImplementationOnce(isValidMock);
    
  //   const textColor = determineTextColor('light', 'not-a-color');
  //   expect(logger.warn).toHaveBeenCalled();
  //   expect(textColor).toBeDefined();
  // });
});
