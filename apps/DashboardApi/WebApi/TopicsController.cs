using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Domain.Entities;
using Infrastructure.Data;

namespace DashboardApi.WebApi
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

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTopic(Guid id, [FromBody] Topic topic)
        {
            if (id != topic.Id)
                return BadRequest("Topic ID mismatch: " + id + " vs. " + topic.Id);

            _context.Entry(topic).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Create a new topic
        [HttpPost]
        public async Task<IActionResult> CreateTopic([FromBody] Topic topic)
        {
            _context.Topics.Add(topic);
            await _context.SaveChangesAsync();
            return Ok(topic);
        }

        // Delete a topic
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTopic(Guid id)
        {
            var topic = await _context.Topics.FindAsync(id);
            if (topic == null)
            {
                return NotFound();
            }
            _context.Topics.Remove(topic);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        
    }
}
