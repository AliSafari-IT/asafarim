using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASafariM.Presentation.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BibliographyController : ControllerBase
    {
        private readonly IBibliographyService _bibliographyService;
        private readonly ILogger<BibliographyController> _logger;

        public BibliographyController(
            IBibliographyService bibliographyService,
            ILogger<BibliographyController> logger
        )
        {
            _bibliographyService = bibliographyService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BibliographyItem>>> GetAllBibliographyItems()
        {
            try
            {
                var items = await _bibliographyService.GetAllBibliographyItemsAsync();
                return Ok(items);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error retrieving bibliography items. The BibliographyItems table may not exist yet."
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The BibliographyItems table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BibliographyItem>> GetBibliographyItemById(Guid id)
        {
            try
            {
                var item = await _bibliographyService.GetBibliographyItemByIdAsync(id);

                if (item == null)
                {
                    return NotFound($"Bibliography item with ID {id} not found");
                }

                return Ok(item);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error retrieving bibliography item with ID {Id}. The BibliographyItems table may not exist yet.",
                    id
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The BibliographyItems table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }

        [HttpPost]
        public async Task<ActionResult<BibliographyItem>> AddBibliographyItem(
            [FromBody] BibliographyItem item
        )
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var addedItem = await _bibliographyService.AddBibliographyItemAsync(item);
                return CreatedAtAction(
                    nameof(GetBibliographyItemById),
                    new { id = addedItem.Id },
                    addedItem
                );
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error adding bibliography item. The BibliographyItems table may not exist yet."
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The BibliographyItems table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<BibliographyItem>> UpdateBibliographyItem(
            Guid id,
            [FromBody] BibliographyItem item
        )
        {
            try
            {
                if (id != item.Id)
                {
                    return BadRequest("ID in URL does not match ID in the request body");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var existingItem = await _bibliographyService.GetBibliographyItemByIdAsync(id);
                if (existingItem == null)
                {
                    return NotFound($"Bibliography item with ID {id} not found");
                }

                var updatedItem = await _bibliographyService.UpdateBibliographyItemAsync(item);
                return Ok(updatedItem);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error updating bibliography item with ID {Id}. The BibliographyItems table may not exist yet.",
                    id
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The BibliographyItems table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBibliographyItem(Guid id)
        {
            try
            {
                var existingItem = await _bibliographyService.GetBibliographyItemByIdAsync(id);
                if (existingItem == null)
                {
                    return NotFound($"Bibliography item with ID {id} not found");
                }

                await _bibliographyService.DeleteBibliographyItemAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error deleting bibliography item with ID {Id}. The BibliographyItems table may not exist yet.",
                    id
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The BibliographyItems table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<BibliographyItem>>> SearchBibliographyItems(
            [FromQuery] string searchTerm
        )
        {
            try
            {
                var items = await _bibliographyService.SearchBibliographyItemsAsync(searchTerm);
                return Ok(items);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error searching bibliography items. The BibliographyItems table may not exist yet."
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The BibliographyItems table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }
    }
}
