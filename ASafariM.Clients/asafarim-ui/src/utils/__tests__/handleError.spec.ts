import { describe, it, expect } from 'vitest';
import { handleError } from '../handleError';
import { AxiosError } from 'axios';

describe('handleError', () => {
  it('should extract error message from Axios error response', () => {
    // Create a mock Axios error with a response
    const mockAxiosError = {
      isAxiosError: true,
      response: {
        data: {
          message: 'Invalid credentials'
        },
        status: 401,
        statusText: 'Unauthorized'
      }
    } as AxiosError;

    const result = handleError(mockAxiosError);
    expect(result).toBe('Invalid credentials');
  });

  it('should return default message when Axios error has no response data', () => {
    // Create a mock Axios error without response data
    const mockAxiosError = {
      isAxiosError: true,
      response: {
        status: 500,
        statusText: 'Internal Server Error'
      }
    } as AxiosError;

    const result = handleError(mockAxiosError);
    expect(result).toBe('An unexpected error occurred!');
  });

  it('should return default message when error is not an Axios error', () => {
    // Create a non-Axios error
    const mockError = {
      isAxiosError: false,
      message: 'Some other error'
    } as AxiosError;

    const result = handleError(mockError);
    expect(result).toBe('An unexpected error occurred!');
  });

  it('should handle Axios error with no response', () => {
    // Create a mock Axios error with no response (e.g., network error)
    const mockAxiosError = {
      isAxiosError: true,
      message: 'Network Error'
    } as AxiosError;

    const result = handleError(mockAxiosError);
    expect(result).toBe('An unexpected error occurred!');
  });
});
