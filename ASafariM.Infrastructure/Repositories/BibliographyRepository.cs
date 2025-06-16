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
    public class BibliographyRepository : IBibliographyRepository
    {
        private readonly AppDbContext _context;

        public BibliographyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BibliographyItem>> GetAllAsync()
        {
            return await _context
                .BibliographyItems.Include(b => b.Attachment)
                .Where(b => !b.IsDeleted)
                .OrderByDescending(b => b.CreatedAt)
                .ToListAsync();
        }

        public async Task<BibliographyItem> GetByIdAsync(Guid id)
        {
            return await _context
                .BibliographyItems.Include(b => b.Attachment)
                .FirstOrDefaultAsync(b => b.Id == id && !b.IsDeleted);
        }

        public async Task<BibliographyItem> AddAsync(BibliographyItem item)
        {
            if (item.Id == Guid.Empty)
            {
                item.Id = Guid.NewGuid();
            }

            // BaseEntity properties are already set by default
            await _context.BibliographyItems.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<BibliographyItem> UpdateAsync(BibliographyItem item)
        {
            var existingItem = await _context.BibliographyItems.FirstOrDefaultAsync(b =>
                b.Id == item.Id && !b.IsDeleted
            );

            if (existingItem == null)
            {
                return null;
            }

            // Update properties
            existingItem.Title = item.Title;
            existingItem.Author = item.Author;
            existingItem.Year = item.Year;
            existingItem.Genre = item.Genre;
            existingItem.IsRead = item.IsRead;
            existingItem.AttachmentId = item.AttachmentId;

            // Update BaseEntity properties
            existingItem.UpdatedAt = DateTime.UtcNow;
            existingItem.UpdatedBy = item.UpdatedBy ?? "System";

            await _context.SaveChangesAsync();
            return existingItem;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var item = await _context.BibliographyItems.FirstOrDefaultAsync(b =>
                b.Id == id && !b.IsDeleted
            );

            if (item == null)
            {
                return false;
            }

            // Soft delete
            item.IsDeleted = true;
            item.DeletedAt = DateTime.UtcNow;
            item.DeletedBy = "System";

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
