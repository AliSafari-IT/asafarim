using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ASafariM.Presentation.Controllers
{
    /// <summary>
    /// Provides access to tags.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TagsController : ControllerBase
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public TagsController(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieves all tags.
        /// </summary>
        /// <returns>Collection of tags</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TagDto>>> GetTags()
        {
            try
            {
                Log.Information("Fetching all tags");
                var tags = await _tagRepository.GetAllAsync();
                Log.Information("Successfully retrieved {TagCount} tags", tags?.Count() ?? 0);
                return Ok(_mapper.Map<IEnumerable<TagDto>>(tags));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching all tags");
                return StatusCode(500, "Internal server error while fetching tags");
            }
        }

        /// <summary>
        /// Creates a new tag.
        /// </summary>
        /// <param name="command">Command model containing tag details</param>
        /// <returns>Created tag</returns>
        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            try
            {
                Log.Information("Creating new tag with name: {TagName}", command.Name);

                if (string.IsNullOrEmpty(command.Name))
                {
                    Log.Warning("Attempted to create tag with empty name");
                    return BadRequest("Name is required");
                }

                var tag = new Tag()
                {
                    Name = command.Name,
                    Description =
                        command.Description + " (Created by " + User?.Identity?.Name + ")",
                    Slug = command.Slug + "-" + Guid.NewGuid().ToString().Substring(0, 8),
                };

                await _tagRepository.AddAsync(tag);
                await _tagRepository.SaveChangesAsync();

                Log.Information("Successfully created tag with ID: {TagId}", tag.Id);
                return CreatedAtAction(nameof(GetTag), new { id = tag.Id }, tag);
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while creating tag with name: {TagName}",
                    command.Name
                );
                return StatusCode(500, "Internal server error while creating tag");
            }
        }

        /// <summary>
        /// Retrieves a tag by ID.
        /// </summary>
        /// <param name="id">ID of the tag to retrieve</param>
        /// <returns>Tag with the specified ID</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<TagDto>> GetTag(Guid id)
        {
            try
            {
                Log.Information("Fetching tag with ID: {TagId}", id);
                var tag = await _tagRepository.GetByIdAsync(id);

                if (tag == null)
                {
                    Log.Warning("Tag not found with ID: {TagId}", id);
                    return NotFound();
                }

                Log.Information("Successfully retrieved tag with ID: {TagId}", id);
                return Ok(_mapper.Map<TagDto>(tag));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching tag with ID: {TagId}", id);
                return StatusCode(500, "Internal server error while fetching tag");
            }
        }

        /// <summary>
        /// Retrieves a tag by slug.
        /// </summary>
        /// <param name="slug">Slug of the tag to retrieve</param>
        /// <returns>Tag with the specified slug</returns>
        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<TagDto>> GetTagBySlug(string slug)
        {
            try
            {
                Log.Information("Fetching tag with slug: {Slug}", slug);
                var tag = await _tagRepository.GetBySlugAsync(slug);

                if (tag == null)
                {
                    Log.Warning("Tag not found with slug: {Slug}", slug);
                    return NotFound();
                }

                Log.Information("Successfully retrieved tag with slug: {Slug}", slug);
                return Ok(_mapper.Map<TagDto>(tag));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching tag with slug: {Slug}", slug);
                return StatusCode(500, "Internal server error while fetching tag by slug");
            }
        }

        /// <summary>
        /// Retrieves tags by post ID.
        /// </summary>
        /// <param name="postId">ID of the post</param>
        /// <returns>Collection of tags associated with the specified post</returns>
        [HttpGet("post/{postId}")]
        public async Task<ActionResult<IEnumerable<TagDto>>> GetTagsByPost(Guid postId)
        {
            try
            {
                Log.Information("Fetching tags for post ID: {PostId}", postId);
                var tags = await _tagRepository.GetTagsByPostIdAsync(postId);
                Log.Information(
                    "Successfully retrieved {TagCount} tags for post ID: {PostId}",
                    tags?.Count() ?? 0,
                    postId
                );
                return Ok(_mapper.Map<IEnumerable<TagDto>>(tags));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching tags for post ID: {PostId}", postId);
                return StatusCode(500, "Internal server error while fetching tags by post");
            }
        }

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="id">ID of the tag to update</param>
        /// <param name="command">Command model containing tag details</param>
        /// <returns>Updated tag</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<TagDto>> UpdateTag(Guid id, UpdateTagCommand command)
        {
            try
            {
                Log.Information("Updating tag with ID: {TagId}", id);

                var existingTag = await _tagRepository.GetByIdAsync(id);
                if (existingTag == null)
                {
                    Log.Warning("Tag not found for update with ID: {TagId}", id);
                    return NotFound($"Tag with ID {id} not found");
                }

                if (
                    command.Slug != existingTag.Slug
                    && await _tagRepository.SlugExistsAsync(command.Slug)
                )
                {
                    Log.Warning("Attempted to update tag with existing slug: {Slug}", command.Slug);
                    return BadRequest("Slug already exists");
                }

                existingTag.Name = command.Name;
                existingTag.Description =
                    command.Description + " (Updated by " + User?.Identity?.Name + ")";
                existingTag.Slug = command.Slug;

                await _tagRepository.UpdateAsync(existingTag);
                await _tagRepository.SaveChangesAsync();

                Log.Information("Successfully updated tag with ID: {TagId}", id);
                return Ok(existingTag);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while updating tag with ID: {TagId}", id);
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes a tag by ID.
        /// </summary>
        /// <param name="id">ID of the tag to delete</param>
        /// <returns>Result of the deletion</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTag(Guid id)
        {
            try
            {
                Log.Information("Deleting tag with ID: {TagId}", id);

                var tag = await _tagRepository.GetByIdAsync(id);
                if (tag == null)
                {
                    Log.Warning("Tag not found for deletion with ID: {TagId}", id);
                    return NotFound();
                }

                await _tagRepository.DeleteAsync(id);
                await _tagRepository.SaveChangesAsync();

                Log.Information("Successfully deleted tag with ID: {TagId}", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while deleting tag with ID: {TagId}", id);
                return StatusCode(500, "Internal server error while deleting tag");
            }
        }
    }
}
