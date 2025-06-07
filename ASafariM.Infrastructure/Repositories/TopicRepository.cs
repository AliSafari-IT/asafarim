using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ASafariM.Infrastructure.Repositories
{
    public class TopicRepository : ITopicRepository
    {
        private readonly AppDbContext _context;

        public TopicRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Topic>> GetAllAsync()
        {
            return await _context.Topics.ToListAsync();
        }

        public async Task<Topic> GetByIdAsync(Guid id)
        {
            return await _context.Topics.FindAsync(id);
        }

        public async Task<Topic> GetBySlugAsync(string slug)
        {
            return await _context.Topics.FirstOrDefaultAsync(t => t.Slug == slug);
        }

        public async Task<IEnumerable<Topic>> GetChildTopicsAsync(Guid parentId)
        {
            return await _context
                .Topics
                .Where(t => t.ParentTopicId == parentId)
                .ToListAsync();
        }

        public async Task<Topic> AddAsync(Topic topic)
        {
            await _context.Topics.AddAsync(topic);
            await _context.SaveChangesAsync();
            return topic;
        }

        public async Task<Topic> UpdateAsync(Topic topic)
        {
            _context.Topics.Update(topic);
            await _context.SaveChangesAsync();
            return topic;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            if (await ExistsAsync(id) == false)
                return false;
            var topic = await _context.Topics.FindAsync(id);
            if (topic == null)
                return false;

            _context.Topics.Remove(topic);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Topics.AnyAsync(t => t.Id == id);
        }

        public async Task<bool> SlugExistsAsync(string slug)
        {
            return await _context.Topics.AnyAsync(t => t.Slug == slug);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        public async Task<bool> HasChildrenAsync(Guid id)
        {
            try
            {
                var topic = await _context.Topics
                    .Include(t => t.ChildTopics)
                    .FirstOrDefaultAsync(t => t.Id == id);

                return topic?.ChildTopics?.Any() == true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error checking for child topics for id {id}", id);
                throw;
            }
        }
    }
}
