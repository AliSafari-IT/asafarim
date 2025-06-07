import { describe, it, expect, beforeEach, vi } from 'vitest';
import { sitemapService } from '../sitemapService';
import { apiClient } from '../../utils/apiClient';

// Mock the apiClient
vi.mock('../../utils/apiClient', () => ({
  apiClient: {
    post: vi.fn(),
    get: vi.fn(),
    put: vi.fn(),
    delete: vi.fn()
  }
}));

const mockSitemap = {
  id: 1,
  pageName: 'Test Page',
  description: 'Test Description',
  slug: 'test-page',
  accessByRole: 'admin'
};

describe('sitemapService', () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  describe('createSitemap', () => {
    it('should create a new sitemap item', async () => {
      const mockResponse = { data: mockSitemap };
      vi.mocked(apiClient.post).mockResolvedValue(mockResponse);

      const result = await sitemapService.createSitemap(mockSitemap);
      expect(apiClient.post).toHaveBeenCalledWith('/api/sitemaps', mockSitemap);
      expect(result).toEqual(mockSitemap);
    });
  });

  describe('getAllSitemaps', () => {
    it('should fetch all sitemap items', async () => {
      const mockResponse = { data: [mockSitemap] };
      vi.mocked(apiClient.get).mockResolvedValue(mockResponse);

      const result = await sitemapService.getAllSitemaps();
      expect(apiClient.get).toHaveBeenCalledWith('/api/sitemaps');
      expect(result).toEqual([mockSitemap]);
    });
  });

  describe('getSitemapById', () => {
    it('should fetch a sitemap item by id', async () => {
      const mockResponse = { data: mockSitemap };
      vi.mocked(apiClient.get).mockResolvedValue(mockResponse);

      const result = await sitemapService.getSitemapById(1);
      expect(apiClient.get).toHaveBeenCalledWith('/api/sitemaps/1');
      expect(result).toEqual(mockSitemap);
    });
  });

  describe('updateSitemap', () => {
    it('should update a sitemap item', async () => {
      const mockResponse = { data: mockSitemap };
      vi.mocked(apiClient.put).mockResolvedValue(mockResponse);

      const result = await sitemapService.updateSitemap(1, mockSitemap);
      expect(apiClient.put).toHaveBeenCalledWith('/api/sitemaps/1', mockSitemap);
      expect(result).toEqual(mockSitemap);
    });
  });

  describe('deleteSitemap', () => {
    it('should delete a sitemap item', async () => {
      const mockResponse = { data: {} };
      vi.mocked(apiClient.delete).mockResolvedValue(mockResponse);

      const result = await sitemapService.deleteSitemap(1);
      expect(apiClient.delete).toHaveBeenCalledWith('/api/sitemaps/1');
      expect(result).toEqual({});
    });
  });
});
