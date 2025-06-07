import { describe, it, expect, vi } from 'vitest';
import { getGuid } from '../getGuid';

describe('getGuid', () => {
  it('should generate a valid UUID string', () => {
    const uuid = getGuid();
    
    // Check if it's a string
    expect(typeof uuid).toBe('string');
    
    // Check if it has the correct format (8-4-4-4-12)
    const uuidRegex = /^[0-9a-f]{8}-[0-9a-f]{4}-4[0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$/i;
    expect(uuidRegex.test(uuid)).toBe(true);
  });

  it('should generate unique UUIDs', () => {
    const uuids = new Set();
    
    // Generate multiple UUIDs and check for uniqueness
    for (let i = 0; i < 100; i++) {
      uuids.add(getGuid());
    }
    
    // If all UUIDs are unique, the set size should be 100
    expect(uuids.size).toBe(100);
  });

  it('should use Math.random for generation', () => {
    // Mock Math.random to return predictable values
    const randomSpy = vi.spyOn(Math, 'random');
    randomSpy.mockReturnValue(0.5);
    
    const uuid = getGuid();
    
    // With Math.random always returning 0.5, the UUID should be predictable
    // (0.5 * 16) | 0 = 8, so all 'x' characters should be replaced with '8'
    // For 'y' characters, it should be (8 & 0x3) | 0x8 = 8
    expect(uuid).toBe('88888888-8888-4888-8888-888888888888');
    
    // Restore the original Math.random
    randomSpy.mockRestore();
  });
});
