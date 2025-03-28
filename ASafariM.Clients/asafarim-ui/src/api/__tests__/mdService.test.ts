import { describe, it, expect, vi, beforeEach, afterEach } from 'vitest';
import axios from 'axios';
import * as mdService from '@/api/mdService';
import { logger } from '@/utils/logger';

vi.mock('axios');
vi.mock('@/utils/logger', () => ({
  logger: {
    log: vi.fn(),
    error: vi.fn()
  }
}));

const mockedAxios = axios as unknown as {
  post: ReturnType<typeof vi.fn>,
  get: ReturnType<typeof vi.fn>,
  put: ReturnType<typeof vi.fn>,
  delete: ReturnType<typeof vi.fn>
};

const fakeAuth = {
  token: 'mock-token',
  userId: 'mock-user-id'
};

beforeEach(() => {
  localStorage.setItem('auth', JSON.stringify(fakeAuth));
  vi.clearAllMocks();
});

afterEach(() => {
  localStorage.clear();
});

describe('mdService', () => {
  it('creates a markdown file', async () => {
    mockedAxios.post = vi.fn().mockResolvedValue({ data: { success: true } });

    const result = await mdService.createMarkdownFile('Title', 'Content', 'public');

    expect(mockedAxios.post).toHaveBeenCalledWith(
      '/api/MarkdownFiles',
      {
        title: 'Title',
        content: 'Content',
        visibility: 'public',
        authorId: 'mock-user-id'
      },
      { headers: { Authorization: 'Bearer mock-token' } }
    );
    expect(result).toEqual({ success: true });
  });

  it('gets markdown file by ID', async () => {
    mockedAxios.get = vi.fn().mockResolvedValue({ data: { id: '123', title: 'Title' } });

    const result = await mdService.getMarkdownFileById('123');

    expect(mockedAxios.get).toHaveBeenCalledWith(
      '/api/MarkdownFiles/123',
      { headers: { Authorization: 'Bearer mock-token' } }
    );
    expect(logger.log).toHaveBeenCalledWith('Markdown file retrieved:', { id: '123', title: 'Title' });
    expect(result).toEqual({ id: '123', title: 'Title' });
  });

  it('updates a markdown file', async () => {
    mockedAxios.put = vi.fn().mockResolvedValue({ data: { updated: true } });

    const result = await mdService.updateMarkdownFile('456', 'Updated', 'New Content', 'private');

    expect(mockedAxios.put).toHaveBeenCalledWith(
      '/api/MarkdownFiles/456',
      {
        title: 'Updated',
        content: 'New Content',
        visibility: 'private'
      },
      { headers: { Authorization: 'Bearer mock-token' } }
    );
    expect(logger.log).toHaveBeenCalledWith('Markdown file updated:', { updated: true });
    expect(result).toEqual({ updated: true });
  });

  it('deletes a markdown file by ID', async () => {
    mockedAxios.delete = vi.fn().mockResolvedValue({ data: { deleted: true } });

    await mdService.deleteMarkdownFile('789');

    expect(mockedAxios.delete).toHaveBeenCalledWith(
      '/api/MarkdownFiles/789',
      { headers: { Authorization: 'Bearer mock-token' } }
    );
    expect(logger.log).toHaveBeenCalledWith('Markdown file deleted:', { deleted: true });
  });

  it('deletes multiple markdown files', async () => {
    mockedAxios.delete = vi.fn().mockResolvedValue({ data: { deletedCount: 2 } });

    const result = await mdService.deleteMarkdownFiles(['1', '2']);

    expect(mockedAxios.delete).toHaveBeenCalledWith(
      '/api/MarkdownFiles',
      {
        headers: { Authorization: 'Bearer mock-token' },
        data: { ids: ['1', '2'] }
      }
    );
    expect(logger.log).toHaveBeenCalledWith('Markdown files deleted:', { deletedCount: 2 });
    expect(result).toEqual({ deletedCount: 2 });
  });
});
