import { describe, it, expect } from 'vitest';
import getSlug from '../getSlug';

describe('getSlug', () => {
  it('should convert a string to a valid slug', () => {
    const result = getSlug('Hello World');
    expect(result).toBe('hello-world');
  });

  it('should handle special characters', () => {
    const result = getSlug('Hello, World! This is a test.');
    expect(result).toBe('hello-world-this-is-a-test-');
  });

  it('should handle uppercase characters', () => {
    const result = getSlug('HELLO WORLD');
    expect(result).toBe('hello-world');
  });

  it('should handle numbers', () => {
    const result = getSlug('Hello World 123');
    expect(result).toBe('hello-world-123');
  });

  it('should handle multiple spaces and special characters', () => {
    const result = getSlug('Hello   World!!!   Test');
    expect(result).toBe('hello-world-test');
  });

  it('should handle undefined input', () => {
    const result = getSlug(undefined);
    expect(result).toBeUndefined();
  });

  it('should preserve underscores', () => {
    const result = getSlug('hello_world');
    expect(result).toBe('hello_world');
  });
});
