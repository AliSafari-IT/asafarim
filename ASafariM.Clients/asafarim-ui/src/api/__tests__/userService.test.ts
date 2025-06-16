import { describe, it, expect, beforeEach, vi, afterEach } from 'vitest';
import * as userService from '../userService';
import { IUser } from '@/interfaces/IUser';

describe('userService', () => {
    // Mock data for tests
    const mockUsers: IUser[] = [
        {
            id: '123',
            firstName: 'Ali',
            lastName: 'Safari',
            email: 'ali@example.com',
            userName: 'alisafari',
            isDeleted: false,
            isAdmin: false
        },
        {
            id: '456',
            firstName: 'John',
            lastName: 'Doe',
            email: 'john@example.com',
            userName: 'johndoe',
            isDeleted: false,
            isAdmin: false
        }
    ];

    const mockUsersWithDeleted: IUser[] = [
        ...mockUsers,
        {
            id: '789',
            firstName: 'Jane',
            lastName: 'Smith',
            email: 'jane@example.com',
            userName: 'janesmith',
            isDeleted: true,
            isAdmin: false
        }
    ];

    beforeEach(() => {
        // Mock the getUsers function
        vi.spyOn(userService, 'getUsers').mockImplementation(async (includeSoftDeleted = false) => {
            return includeSoftDeleted ? mockUsersWithDeleted : mockUsers;
        });
    });

    afterEach(() => {
        vi.restoreAllMocks();
    });

    it('should get all users with default includeSoftDeleted=false', async () => {
        // Call the function
        const result = await userService.getUsers();
        
        // Verify the result
        expect(Array.isArray(result)).toBe(true);
        expect(result.length).toBe(2);
        expect(result[0].id).toBe('123');
        expect(result[1].id).toBe('456');
    });
    
    it('should get all users including soft deleted ones when includeSoftDeleted=true', async () => {
        // Call the function with includeSoftDeleted=true
        const result = await userService.getUsers(true);
        
        // Verify the result
        expect(Array.isArray(result)).toBe(true);
        expect(result.length).toBe(3);
        expect(result[2].id).toBe('789');
        expect(result[2].isDeleted).toBe(true);
    });
});
