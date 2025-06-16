/// <reference types="vitest" />
import { describe, it, expect, vi, beforeEach } from 'vitest';
import { v4 as uuidv4 } from 'uuid';

// Create mock functions with vi.hoisted() to properly handle hoisting
const mockPost = vi.hoisted(() => vi.fn());
const mockGet = vi.hoisted(() => vi.fn());
const mockUse = vi.hoisted(() => vi.fn());
const mockIsAxiosError = vi.hoisted(() => vi.fn().mockReturnValue(true));

// Mock axios before importing authApi
vi.mock('axios', () => {
    return {
        default: {
            create: () => ({
                interceptors: {
                    request: { use: mockUse },
                    response: { use: mockUse }
                },
                post: mockPost,
                get: mockGet,
                defaults: {}
            }),
            isAxiosError: mockIsAxiosError
        },
        isAxiosError: mockIsAxiosError
    };
});

// Import modules after mocking
import * as authApi from '../authapi';
import { ILoginModel } from '@/interfaces/ILoginModel';
import { IRegisterModel } from '@/interfaces/IRegisterModel';

// Test constants
const testPassword = 'secret+123/';
const testEmail = 'test@example.com';
const testUserName = 'testuser';
const testFirstName = 'John';
const testLastName = 'Doe';
const testUserId = uuidv4();

// Setup storage mocks for all tests
const mockSessionStorage = {
    getItem: vi.fn(),
    setItem: vi.fn(),
    clear: vi.fn(),
    removeItem: vi.fn(),
    length: 0,
    key: vi.fn()
};

const mockLocalStorage = {
    getItem: vi.fn(),
    setItem: vi.fn(),
    clear: vi.fn(),
    removeItem: vi.fn(),
    length: 0,
    key: vi.fn()
};

describe('authapi test suite', () => {
    beforeEach(() => {
        vi.resetAllMocks();
        
        // Setup storage mocks before each test
        Object.defineProperty(window, 'localStorage', { value: mockLocalStorage });
        Object.defineProperty(window, 'sessionStorage', { value: mockSessionStorage });
        
        // Clear mocks
        mockLocalStorage.clear.mockClear();
        mockLocalStorage.getItem.mockClear();
        mockSessionStorage.clear.mockClear();
        mockSessionStorage.getItem.mockClear();
    });

    describe('login', () => {
        it('should return normalized response on success', async () => {
            const credentials: ILoginModel = { email: testEmail, password: testPassword };
            const mockResponse = {
                data: {
                    token: 'mock-token',
                    authenticatedUser: { id: 'user123', email: testEmail },
                    authenticated: true
                }
            };
            mockPost.mockResolvedValue(mockResponse);

            const result = await authApi.login(credentials);

            expect(result.token).toBe('mock-token');
            expect(result.authenticatedUser.email).toBe(testEmail);
            expect(result.authenticated).toBe(true);
        });

        it('should throw error if token is missing', async () => {
            const credentials: ILoginModel = { email: testEmail, password: testPassword };
            mockPost.mockResolvedValue({ data: { authenticatedUser: {} } });

            await expect(authApi.login(credentials)).rejects.toThrow('Invalid response from server: missing authentication token');
        });
    });

    describe('register', () => {
        it('should return data on successful registration', async () => {
            const model: IRegisterModel = { email: testEmail, password: testPassword, userName: 'newuser', firstName: 'John', lastName: 'Doe' };
            const mockData = { message: 'Registered successfully' };
            mockPost.mockResolvedValue({ data: mockData });

            const result = await authApi.register(model);
            expect(result).toEqual(mockData);
        });
    });

    describe('logout', () => {
        it('should handle successful logout and clear storage', async () => {
            // Setup mock response
            mockPost.mockResolvedValue({ data: { message: 'Logged out' } });
            
            // Call logout
            const result = await authApi.logout();
            
            // Verify API was called
            expect(mockPost).toHaveBeenCalledWith('auth/logout');
            
            // Verify result
            expect(result.message).toBe('Logged out');
            
            // Verify storage was cleared
            expect(localStorage.clear).toHaveBeenCalled();
            expect(sessionStorage.clear).toHaveBeenCalled();
        });

        it('should return local message if logout fails', async () => {
            // Setup mock error
            mockPost.mockRejectedValue(new Error('Server down'));
            
            // Call logout
            const result = await authApi.logout();
            
            // Verify result
            expect(result.message).toBe('Logged out locally');
            
            // Storage should still be cleared even on error
            expect(localStorage.clear).toHaveBeenCalled();
            expect(sessionStorage.clear).toHaveBeenCalled();
        });
    });

    describe('getAuthenticatedUser', () => {
        it('should return authenticated user from sessionStorage', () => {
            // Setup mock user in sessionStorage
            const mockUser = { id: testUserId, email: testEmail };
            const mockAuthData = JSON.stringify({ authenticatedUser: mockUser });
            
            // Setup sessionStorage mock to return our auth data
            mockSessionStorage.getItem.mockReturnValue(mockAuthData);
            
            // Call the function
            const result = authApi.getAuthenticatedUser();
            
            // Verify sessionStorage was checked
            expect(sessionStorage.getItem).toHaveBeenCalledWith('auth');
            
            // Verify the result matches our mock user
            expect(result).toEqual(mockUser);
        });
        
        it('should return null when no auth data exists', () => {
            // Setup sessionStorage to return null
            mockSessionStorage.getItem.mockReturnValue(null);
            
            // Call the function
            const result = authApi.getAuthenticatedUser();
            
            // Verify sessionStorage was checked
            expect(sessionStorage.getItem).toHaveBeenCalledWith('auth');
            
            // Verify result is null
            expect(result).toBeNull();
        });
    });
});
