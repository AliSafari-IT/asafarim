using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Domain.Entities;
using Infrastructure.Data;

namespace DashboardApi.WebApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogPostsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BlogPostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> GetPostBySlug(string slug)
        {
            var post = await _context.BlogPosts
                .Include(p => p.Tags)
                .FirstOrDefaultAsync(p => p.Slug == slug);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        // Create 
        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] BlogPost post)
        {
            _context.BlogPosts.Add(post);
            await _context.SaveChangesAsync();
            return Ok(post);
        }

    }
}
