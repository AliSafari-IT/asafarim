/// <reference types="vitest" />
import { describe, it, expect, vi, beforeEach } from 'vitest';
import AuthorizationService from '../authorizationService';
import { IUserInfo } from '@/interfaces/IUserInfo';
import axios from 'axios';

// Mock axios POST
vi.mock('axios');
const mockedAxios = axios as unknown as {
  post: ReturnType<typeof vi.fn>;
};

// Mock storage
const mockSessionStorage = {
  getItem: vi.fn(),
  setItem: vi.fn(),
  clear: vi.fn(),
};
const mockLocalStorage = {
  getItem: vi.fn(),
  setItem: vi.fn(),
  clear: vi.fn(),
};

const mockUser: IUserInfo = {
  id: 'user123',
  email: 'test@example.com',
  userName: 'tester',
  isAdmin: false,
};

const adminUser: IUserInfo = { ...mockUser, isAdmin: true };

describe('AuthorizationService', () => {
  beforeEach(() => {
    vi.resetAllMocks();

    // Patch storage
    Object.defineProperty(window, 'localStorage', { value: mockLocalStorage });
    Object.defineProperty(window, 'sessionStorage', { value: mockSessionStorage });
  });

  describe('authorize', () => {
    it('should return false if user or policy is missing', () => {
      expect(AuthorizationService.authorize(null as any, 'admin_only')).toBe(false);
      expect(AuthorizationService.authorize(mockUser, '')).toBe(false);
    });

    it('should return true for update_profile policy', () => {
      expect(AuthorizationService.authorize(mockUser, 'update_profile')).toBe(true);
    });

    it('should return true for admin_only policy if user is admin', () => {
      expect(AuthorizationService.authorize(adminUser, 'admin_only')).toBe(true);
    });

    it('should return false for admin_only if user is not admin', () => {
      expect(AuthorizationService.authorize(mockUser, 'admin_only')).toBe(false);
    });

    it('should return true for delete_user if admin', () => {
      expect(AuthorizationService.authorize(adminUser, 'delete_user')).toBe(true);
    });

    it('should return false for delete_user if not admin', () => {
      expect(AuthorizationService.authorize(mockUser, 'delete_user')).toBe(false);
    });
  });

  describe('authorizeAsync', () => {
    it('should return false if no auth data in storage', async () => {
      mockLocalStorage.getItem.mockReturnValue(null);
      mockSessionStorage.getItem.mockReturnValue(null);

      const result = await AuthorizationService.authorizeAsync(mockUser, 'some_policy');
      expect(result).toBe(false);
    });

    it('should return false if token is missing from auth data', async () => {
      const badAuth = JSON.stringify({ authenticatedUser: mockUser });
      mockLocalStorage.getItem.mockReturnValue(badAuth);

      const result = await AuthorizationService.authorizeAsync(mockUser, 'some_policy');
      expect(result).toBe(false);
    });

    it('should return true for update_profile if authenticated', async () => {
      const validAuth = JSON.stringify({ authenticated: true, token: 'abc123' });
      mockLocalStorage.getItem.mockReturnValue(validAuth);

      const result = await AuthorizationService.authorizeAsync(mockUser, 'update_profile');
      expect(result).toBe(true);
    });

    it('should return true if API says authorized', async () => {
      const validAuth = JSON.stringify({ token: 'abc123' });
      mockLocalStorage.getItem.mockReturnValue(validAuth);

      mockedAxios.post = vi.fn().mockResolvedValue({ data: { isAuthorized: true } });

      const result = await AuthorizationService.authorizeAsync(mockUser, 'admin_only');
      expect(result).toBe(true);
    });

    it('should return false if API throws error', async () => {
      const validAuth = JSON.stringify({ token: 'abc123' });
      mockLocalStorage.getItem.mockReturnValue(validAuth);

      mockedAxios.post = vi.fn().mockRejectedValue(new Error('API down'));

      const result = await AuthorizationService.authorizeAsync(mockUser, 'admin_only');
      expect(result).toBe(false);
    });
  });
});
