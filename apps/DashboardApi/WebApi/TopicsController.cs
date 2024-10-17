using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Domain.Entities;
using Infrastructure.Data;

namespace DashboardApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TopicsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TopicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetTopics()
        {
            var topics = await _context.Topics
                .Include(t => t.RelatedPosts)
                .ToListAsync();

            return Ok(topics);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTopicById(Guid id)
        {
            var topic = await _context.Topics
                .Include(t => t.RelatedPosts)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (topic == null)
                return NotFound();

            return Ok(topic);
        }
    }
}
