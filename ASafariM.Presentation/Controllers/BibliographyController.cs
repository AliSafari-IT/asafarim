using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASafariM.Presentation.Controllers
{
    /// <summary>
    /// Controller for managing bibliography items
    /// </summary>
    [ApiController]
    [Route("api/books")]
    public class BibliographyController : ControllerBase
    {
        private readonly IBibliographyService _bibliographyService;
        private readonly ILogger<BibliographyController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="BibliographyController"/> class
        /// </summary>
        /// <param name="bibliographyService">Bibliography service</param>
        /// <param name="logger">Logger instance</param>
        public BibliographyController(
            IBibliographyService bibliographyService,
            ILogger<BibliographyController> logger
        )
        {
            _bibliographyService = bibliographyService;
            _logger = logger;
        }

        /// <summary>
        /// Gets all bibliography items
        /// </summary>
        /// <returns>List of bibliography items</returns>
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

        /// <summary>
        /// Gets a bibliography item by ID
        /// </summary>
        /// <param name="id">Bibliography item ID</param>
        /// <returns>Bibliography item</returns>
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

        /// <summary>
        /// Adds a new bibliography item
        /// </summary>
        /// <param name="item">Bibliography item to add</param>
        /// <returns>Created bibliography item</returns>
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

        /// <summary>
        /// Updates an existing bibliography item
        /// </summary>
        /// <param name="id">Bibliography item ID</param>
        /// <param name="item">Updated bibliography item</param>
        /// <returns>Updated bibliography item</returns>
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

        /// <summary>
        /// Deletes a bibliography item
        /// </summary>
        /// <param name="id">Bibliography item ID</param>
        /// <returns>No content if successful</returns>
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

        /// <summary>
        /// Searches bibliography items
        /// </summary>
        /// <param name="searchTerm">Search term</param>
        /// <returns>List of matching bibliography items</returns>
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
