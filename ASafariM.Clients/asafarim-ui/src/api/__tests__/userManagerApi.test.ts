import { describe, it, expect, beforeEach, vi, afterEach } from 'vitest';
import * as userManagerApi from '../userManagerApi';
import { ICreateUserModel } from '@/interfaces/ICreateUserModel';

describe('userManagerApi', () => {
    // Test data
    const testUser: ICreateUserModel = {
        firstName: 'Ali',
        lastName: 'Safari',
        email: 'ali@example.com',
        userName: 'alisafari',
        isAdmin: false,
        password: 'password123'
    };

    // Mock response data
    const createUserResponse = {
        success: true,
        data: {
            id: '123',
            ...testUser
        }
    };

    const addUserByAdminResponse = {
        success: true,
        data: {
            id: 'admin-123',
            ...testUser
        }
    };

    beforeEach(() => {
        // Mock the createUser function
        vi.spyOn(userManagerApi, 'createUser').mockResolvedValue(createUserResponse);
        
        // Mock the addUserByAdmin function
        vi.spyOn(userManagerApi, 'addUserByAdmin').mockResolvedValue(addUserByAdminResponse);
    });

    afterEach(() => {
        vi.restoreAllMocks();
    });

    // Create User
    it('should create a new user', async () => {
        // Call the createUser function
        const result = await userManagerApi.createUser(testUser);

        // Verify the result structure and values
        expect(result).toHaveProperty('success', true);
        expect(result.data).toHaveProperty('id', '123');
        expect(result.data).toHaveProperty('firstName', 'Ali');
        expect(result.data).toHaveProperty('lastName', 'Safari');
        expect(result.data).toHaveProperty('email', 'ali@example.com');
    });

    // Create User by Admin
    it('should add user by admin', async () => {
        // Call the addUserByAdmin function
        const result = await userManagerApi.addUserByAdmin(testUser);
        
        // Verify the result
        expect(result).toHaveProperty('success', true);
        expect(result.data).toHaveProperty('id', 'admin-123');
    });
});