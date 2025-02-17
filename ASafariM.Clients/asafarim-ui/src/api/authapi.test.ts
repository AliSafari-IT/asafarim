import { describe, it, expect, vi } from 'vitest';
import axios from 'axios';
import { register, login, requestAccountReactivation } from './authapi';
const {auth} = JSON.parse(localStorage.getItem('auth') || '{}');
vi.mock('axios');

const mockedAxios = vi.mocked(axios, true); // Pass true to enable type-safe mocking

describe('Auth API', () => {
  it('should register a user successfully', async () => {
    const model = {
      email: 'test@example.com',
      password: 'securePassword123',
      firstName: 'John',
      lastName: 'Doe',
      userName: 'johndoe'
    };

    mockedAxios.post.mockResolvedValue({ data: { token: auth.token } });
    const response = await register(model);
    expect(response).toEqual({ token: auth.token });
    expect(mockedAxios.post).toHaveBeenCalledWith('/register', model);
  });

  it('should login a user successfully', async () => {
    const credentials = {
      email: 'test@example.com',
      password: 'securePassword123'
    };
    mockedAxios.post.mockResolvedValue({ data: { token: auth.token } });

    const response = await login(credentials);
    expect(response).toEqual({ token: auth.token });
    expect(mockedAxios.post).toHaveBeenCalledWith('/login', credentials);
  });

  it('should request account reactivation successfully', async () => {
    const email = 'test@example.com';
    mockedAxios.post.mockResolvedValue({ data: { success: true } });

    const response = await requestAccountReactivation(email);
    expect(response).toEqual({ success: true });
    expect(mockedAxios.post).toHaveBeenCalledWith('/requestAccountReactivation', { email });
  });
});
