import { describe, it, expect } from 'vitest';
import cx from '../concatenateClasses';

describe('concatenateClasses', () => {
  it('should concatenate multiple class names', () => {
    const result = cx('class1', 'class2', 'class3');
    expect(result).toBe('class1 class2 class3');
  });

  it('should filter out falsy values', () => {
    const result = cx('class1', false, 'class2', undefined, null as any, 'class3');
    expect(result).toBe('class1 class2 class3');
  });

  it('should handle empty arguments', () => {
    const result = cx();
    expect(result).toBe('');
  });

  it('should handle conditional classes', () => {
    const isActive = true;
    const isDisabled = false;
    
    const result = cx(
      'base-class',
      isActive && 'active',
      isDisabled && 'disabled'
    );
    
    expect(result).toBe('base-class active');
  });
});
