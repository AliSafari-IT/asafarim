using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ASafariM.Infrastructure.Repositories
{
    public class SitemapItemRepository : ISitemapItemRepository
    {
        private readonly AppDbContext _context;

        public SitemapItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SitemapItem>> GetAllAsync()
        {
            return await _context
                .SitemapItems.Include(s => s.ParentItemId)
                .Include(s => s.ChildItems)
                .Include(s => s.Topics)
                .Where(s => !s.IsDeleted)
                .ToListAsync();
        }

        public async Task<IEnumerable<SitemapItem>> GetRootItemsAsync()
        {
            return await _context
                .SitemapItems.Include(s => s.ChildItems)
                .Include(s => s.Topics)
                .Where(s => !s.IsDeleted && s.ParentItemId == null)
                .ToListAsync();
        }

        public async Task<SitemapItem?> GetByIdAsync(Guid id)
        {
            return await _context
                .SitemapItems.Include(s => s.ParentItemId)
                .Include(s => s.ChildItems)
                .Include(s => s.Topics)
                .FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted);
        }

        public async Task<SitemapItem?> GetBySlugAsync(string slug)
        {
            return await _context
                .SitemapItems.Include(s => s.ParentItemId)
                .Include(s => s.ChildItems)
                .Include(s => s.Topics)
                .FirstOrDefaultAsync(s => s.Slug == slug && !s.IsDeleted);
        }

        public async Task<IEnumerable<SitemapItem>> GetChildrenAsync(Guid parentId)
        {
            return await _context
                .SitemapItems.Include(s => s.Topics)
                .Where(s => s.ParentItemId == parentId && !s.IsDeleted)
                .ToListAsync();
        }

        public async Task<bool> SlugExistsAsync(string slug)
        {
            return await _context.SitemapItems.AnyAsync(s => s.Slug == slug && !s.IsDeleted);
        }

        public async Task<SitemapItem> AddAsync(SitemapItem sitemapItem)
        {
            await _context.SitemapItems.AddAsync(sitemapItem);
            await _context.SaveChangesAsync();
            return sitemapItem;
        }

        public async Task<SitemapItem> UpdateAsync(SitemapItem sitemapItem)
        {
            _context.SitemapItems.Update(sitemapItem);
            await _context.SaveChangesAsync();
            return sitemapItem;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var sitemapItem = await _context.SitemapItems.FindAsync(id);
            if (sitemapItem == null)
                return false;

            sitemapItem.IsDeleted = true;
            sitemapItem.DeletedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.SitemapItems.AnyAsync(s => s.Id == id && !s.IsDeleted);
        }
    }
}
