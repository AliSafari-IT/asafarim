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
    [ApiController]
    [Route("api/[controller]")]
    public class SitemapItemsController : ControllerBase
    {
        private readonly ISitemapItemRepository _sitemapItemRepository;
        private readonly IMapper _mapper;

        public SitemapItemsController(ISitemapItemRepository sitemapItemRepository, IMapper mapper)
        {
            _sitemapItemRepository = sitemapItemRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SitemapItemDto>>> GetSitemapItems()
        {
            try
            {
                Log.Information("Fetching all sitemap items");
                var items = await _sitemapItemRepository.GetAllAsync();
                Log.Information(
                    "Successfully retrieved {ItemCount} sitemap items",
                    items?.Count() ?? 0
                );
                return Ok(_mapper.Map<IEnumerable<SitemapItemDto>>(items));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching all sitemap items");
                return StatusCode(500, "Internal server error while fetching sitemap items");
            }
        }

        [HttpGet("root")]
        public async Task<ActionResult<IEnumerable<SitemapItemDto>>> GetRootItems()
        {
            try
            {
                Log.Information("Fetching root sitemap items");
                var items = await _sitemapItemRepository.GetRootItemsAsync();
                Log.Information(
                    "Successfully retrieved {ItemCount} root sitemap items",
                    items?.Count() ?? 0
                );
                return Ok(_mapper.Map<IEnumerable<SitemapItemDto>>(items));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching root sitemap items");
                return StatusCode(500, "Internal server error while fetching root sitemap items");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SitemapItemDto>> GetSitemapItem(Guid id)
        {
            try
            {
                Log.Information("Fetching sitemap item with ID: {ItemId}", id);
                var item = await _sitemapItemRepository.GetByIdAsync(id);
                if (item == null)
                {
                    Log.Warning("Sitemap item not found with ID: {ItemId}", id);
                    return NotFound();
                }

                Log.Information("Successfully retrieved sitemap item with ID: {ItemId}", id);
                return Ok(_mapper.Map<SitemapItemDto>(item));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching sitemap item with ID: {ItemId}", id);
                return StatusCode(500, "Internal server error while fetching sitemap item");
            }
        }

        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<SitemapItemDto>> GetSitemapItemBySlug(string slug)
        {
            try
            {
                Log.Information("Fetching sitemap item with slug: {Slug}", slug);
                var item = await _sitemapItemRepository.GetBySlugAsync(slug);
                if (item == null)
                {
                    Log.Warning("Sitemap item not found with slug: {Slug}", slug);
                    return NotFound();
                }

                Log.Information("Successfully retrieved sitemap item with slug: {Slug}", slug);
                return Ok(_mapper.Map<SitemapItemDto>(item));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching sitemap item with slug: {Slug}", slug);
                return StatusCode(500, "Internal server error while fetching sitemap item by slug");
            }
        }

        [HttpGet("{id}/children")]
        public async Task<ActionResult<IEnumerable<SitemapItemDto>>> GetChildItems(Guid id)
        {
            try
            {
                Log.Information("Fetching child items for sitemap item ID: {ParentId}", id);
                var items = await _sitemapItemRepository.GetChildrenAsync(id);
                Log.Information(
                    "Successfully retrieved {ItemCount} child items for sitemap item ID: {ParentId}",
                    items?.Count() ?? 0,
                    id
                );
                return Ok(_mapper.Map<IEnumerable<SitemapItemDto>>(items));
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while fetching child items for sitemap item ID: {ParentId}",
                    id
                );
                return StatusCode(500, "Internal server error while fetching child items");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<SitemapItemDto>> CreateSitemapItem(
            CreateSitemapItemCommand command
        )
        {
            try
            {
                Log.Information("Creating new sitemap item with slug: {Slug}", command.Slug);

                if (await _sitemapItemRepository.SlugExistsAsync(command.Slug))
                {
                    Log.Warning(
                        "Attempted to create sitemap item with existing slug: {Slug}",
                        command.Slug
                    );
                    return BadRequest("Slug already exists");
                }

                var item = _mapper.Map<SitemapItem>(command);
                item.CreatedBy = User.Identity.Name;
                item.UpdatedBy = User.Identity.Name;
                item.CreatedAt = DateTime.UtcNow;
                item.UpdatedAt = DateTime.UtcNow;
                item.IsActive = true;

                if (command.IsPublished)
                {
                    Log.Information(
                        "Publishing sitemap item during creation with slug: {Slug}",
                        command.Slug
                    );
                    item.PublishedDate = DateTime.UtcNow;
                    item.PublishedBy = User.Identity.Name;
                }

                await _sitemapItemRepository.AddAsync(item);
                Log.Information("Successfully created sitemap item with ID: {ItemId}", item.Id);
                return CreatedAtAction(
                    nameof(GetSitemapItem),
                    new { id = item.Id },
                    _mapper.Map<SitemapItemDto>(item)
                );
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while creating sitemap item with slug: {Slug}",
                    command.Slug
                );
                return StatusCode(500, "Internal server error while creating sitemap item");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<ActionResult<SitemapItemDto>> UpdateSitemapItem(
            Guid id,
            UpdateSitemapItemCommand command
        )
        {
            try
            {
                Log.Information("Updating sitemap item with ID: {ItemId}", id);

                if (id != command.Id)
                {
                    Log.Warning(
                        "ID mismatch during update. Path ID: {PathId}, Command ID: {CommandId}",
                        id,
                        command.Id
                    );
                    return BadRequest();
                }

                var existingItem = await _sitemapItemRepository.GetByIdAsync(id);
                if (existingItem == null)
                {
                    Log.Warning("Sitemap item not found for update with ID: {ItemId}", id);
                    return NotFound();
                }

                if (
                    command.Slug != existingItem.Slug
                    && await _sitemapItemRepository.SlugExistsAsync(command.Slug)
                )
                {
                    Log.Warning(
                        "Attempted to update sitemap item with existing slug: {Slug}",
                        command.Slug
                    );
                    return BadRequest("Slug already exists");
                }

                _mapper.Map(command, existingItem);
                existingItem.UpdatedBy = User.Identity.Name;
                existingItem.UpdatedAt = DateTime.UtcNow;

                if (command.IsPublished && !existingItem.IsPublished)
                {
                    Log.Information("Publishing sitemap item during update with ID: {ItemId}", id);
                    existingItem.PublishedDate = DateTime.UtcNow;
                    existingItem.PublishedBy = User.Identity.Name;
                }

                await _sitemapItemRepository.UpdateAsync(existingItem);
                Log.Information("Successfully updated sitemap item with ID: {ItemId}", id);
                return Ok(_mapper.Map<SitemapItemDto>(existingItem));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while updating sitemap item with ID: {ItemId}", id);
                return StatusCode(500, "Internal server error while updating sitemap item");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSitemapItem(Guid id)
        {
            try
            {
                Log.Information("Deleting sitemap item with ID: {ItemId}", id);

                var item = await _sitemapItemRepository.GetByIdAsync(id);
                if (item == null)
                {
                    Log.Warning("Sitemap item not found for deletion with ID: {ItemId}", id);
                    return NotFound();
                }

                item.DeletedBy = User.Identity.Name;
                await _sitemapItemRepository.DeleteAsync(id);
                Log.Information("Successfully deleted sitemap item with ID: {ItemId}", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while deleting sitemap item with ID: {ItemId}", id);
                return StatusCode(500, "Internal server error while deleting sitemap item");
            }
        }
    }
}
