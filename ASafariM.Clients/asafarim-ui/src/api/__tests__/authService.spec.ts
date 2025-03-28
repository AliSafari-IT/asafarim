/// <reference types="vitest" />
import { describe, it, expect, vi, beforeEach } from 'vitest';
import axios from 'axios';
import * as authService from '../authService';
import { AxiosError } from 'axios';
import { handleError } from '@/utils/handleError';
import { logger } from '@/utils/logger';

vi.mock('axios');
vi.mock('@/utils/handleError', () => ({
    handleError: vi.fn().mockReturnValue('Mocked error message')
}));
vi.mock('@/utils/logger', () => ({
    logger: {
        log: vi.fn(),
        error: vi.fn(),
        warn: vi.fn(),
        info: vi.fn()
    }
}));

vi.mock('@/utils/logger', () => ({
    logger: {
      log: vi.fn(),
      info: vi.fn(),
      warn: vi.fn(),
      error: vi.fn()
    }
  }));
  

const mockedAxios = axios as unknown as {
    post: ReturnType<typeof vi.fn>;
};

describe('authService', () => {
    beforeEach(() => {
        vi.clearAllMocks();
    });

    describe('updateEmail', () => {
        it('should return response data on success', async () => {
            const model = { userId: 'u1', newEmail: 'new@example.com' };
            mockedAxios.post = vi.fn().mockResolvedValue({ data: { success: true } });

            const result = await authService.updateEmail(model);
            expect(mockedAxios.post).toHaveBeenCalledWith(expect.stringMatching(/update-email/), model);
            expect(result).toEqual({ success: true });
        });

        it('should handle and return error message on failure', async () => {
            const model = { userId: 'u1' };
            mockedAxios.post = vi.fn().mockRejectedValue({ response: { data: 'fail' } });

            const result = await authService.updateEmail(model);
            expect(handleError).toHaveBeenCalled();
            expect(result).toEqual({ message: 'Mocked error message' });
        });
    });

    describe('updateUsername', () => {
        it('should return response data on success', async () => {
            const model = { userId: 'u1', newUsername: 'ali', email: 'ali@example.com' };
            mockedAxios.post = vi.fn().mockResolvedValue({ data: { status: 'ok' } });

            const result = await authService.updateUsername(model);
            expect(mockedAxios.post).toHaveBeenCalledWith(expect.stringMatching(/update-username/), model);
            expect(result).toEqual({ status: 'ok' });
        });

        it('should handle and return error message on failure', async () => {
            mockedAxios.post = vi.fn().mockRejectedValue({});

            const result = await authService.updateUsername({
                userId: 'u1',
                newUsername: 'ali',
                email: 'ali@example.com'
            });
            expect(handleError).toHaveBeenCalled();
            expect(result).toEqual({ error: 'Mocked error message' });
        });
    });

    describe('updatePassword', () => {
        const model = { Id: 'u1', currentPassword: 'oldpass', newPassword: 'newpass' };

        it('should return response data on success', async () => {
            mockedAxios.post = vi.fn().mockResolvedValue({ data: { changed: true } });

            const result = await authService.updatePassword(model);
            expect(mockedAxios.post).toHaveBeenCalledWith(expect.stringMatching(/change-password/), model);
            expect(result).toEqual({ changed: true });
        });

        it('should log and return error message on failure', async () => {
            mockedAxios.post = vi.fn().mockRejectedValue({ response: { status: 400 } });

            const result = await authService.updatePassword(model);
            expect(handleError).toHaveBeenCalled();
            expect(result).toEqual({ message: 'Mocked error message' });
        });
    });
});
