using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DashboardApi.Infrastructure.Data;
using DashboardApi.Core.Domain.Entities;

namespace DashboardApi.WebApi;

[Route("api/[controller]")]
[ApiController]
public class BlogPostsController : Controller
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