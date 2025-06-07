using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;

namespace ASafariM.Domain.Interfaces
{
    public interface ISitemapItemRepository
    {
        Task<IEnumerable<SitemapItem>> GetAllAsync();
        Task<SitemapItem> GetByIdAsync(Guid id);
        Task<SitemapItem> GetBySlugAsync(string slug);
        Task<IEnumerable<SitemapItem>> GetChildrenAsync(Guid parentId);
        Task<IEnumerable<SitemapItem>> GetRootItemsAsync();
        Task<SitemapItem> AddAsync(SitemapItem sitemapItem);
        Task<SitemapItem> UpdateAsync(SitemapItem sitemapItem);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
        Task<bool> SlugExistsAsync(string slug);
    }
}
