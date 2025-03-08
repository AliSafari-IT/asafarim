using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Exceptions;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ASafariM.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _context;

        public PostRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get all Posts
        public async Task<IEnumerable<Post>> GetAllAsync()
        {
            return await _context.Posts.Where(p => !p.IsDeleted).ToListAsync();
        }

        public async Task<IEnumerable<Post>> GetPublishedAsync()
        {
            return await _context
                .Posts.Where(p => p.IsPublished && !p.IsDeleted)
                .OrderByDescending(p => p.PublishedDate)
                .ToListAsync();
        }

        public async Task<Post> GetByIdAsync(Guid id)
        {
            var post = await _context.Posts.FindAsync(id);
            return post ?? throw new NotFoundException($"Post with ID {id} not found");
        }

        public async Task<Post> GetBySlugAsync(string slug)
        {
            var post = await _context
                .Posts.Where(p => p.Slug == slug && !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Slug == slug && !p.IsDeleted);
            return post ?? throw new NotFoundException($"Post with slug {slug} not found");
        }

        public async Task<IEnumerable<Post>> GetByTopicIdAsync(Guid topicId)
        {
            return await _context
                .Posts.Where(p => !p.IsDeleted)
                .OrderByDescending(p => p.PublishedDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<Post>> GetByTagIdAsync(Guid tagId)
        {
            return await _context
                .Posts.Where(p => !p.IsDeleted)
                .OrderByDescending(p => p.PublishedDate)
                .ToListAsync();
        }

        public async Task<Post> AddAsync(Post post)
        {
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<Post> UpdateAsync(Post post)
        {
            _context.Posts.Update(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
                return false;

            post.IsDeleted = true;
            post.DeletedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Posts.AnyAsync(p => p.Id == id && !p.IsDeleted);
        }

        public async Task<bool> SlugExistsAsync(string slug)
        {
            return await _context.Posts.AnyAsync(p => p.Slug == slug && !p.IsDeleted);
        }

        public async Task<int> IncrementViewCountAsync(Guid id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
                return 0;

            post.ViewCount++;
            await _context.SaveChangesAsync();
            return post.ViewCount;
        }
    }
}
