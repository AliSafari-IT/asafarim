using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Domain.Entities;
using Infrastructure.Data;
using System;
using System.Threading.Tasks;

namespace DashboardApi.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TagsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all tags
        [HttpGet]
        public async Task<IActionResult> GetTags()
        {
            var tags = await _context.Tags.ToListAsync();
            return Ok(tags);
        }

        // Get a specific tag by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTag(Guid id)
        {
            var tag = await _context.Tags.FindAsync(id);
            if (tag == null)
            {
                return NotFound();
            }
            return Ok(tag);
        }

        // Create a new tag
        [HttpPost]
        public async Task<IActionResult> CreateTag([FromBody] Tag tag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tags.Add(tag);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTag), new { id = tag.Id }, tag); // Return the created tag's location
        }

        // Update an existing tag
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTag(Guid id, [FromBody] Tag tag)
        {
            if (id != tag.Id && id != Guid.Empty)
            {
                return BadRequest("Tag ID mismatch: " + id + " vs. " + tag.Id);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Exclude blogPosts if it is not needed for the update
            tag.BlogPosts = null;

            _context.Entry(tag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Tags.Any(t => t.Id == id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // Delete a tag
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTag(Guid id)
        {
            var tag = await _context.Tags.FindAsync(id);
            if (tag == null)
            {
                return NotFound();
            }

            _context.Tags.Remove(tag);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
