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
    /// Controller for managing portfolios
    /// </summary>
    [ApiController]
    [Route("api/portfolios")]
    public class PortfoliosController : ControllerBase
    {
        private readonly IPortfolioService _portfolioService;
        private readonly ILogger<PortfoliosController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfoliosController"/> class
        /// </summary>
        /// <param name="portfolioService">Portfolio service</param>
        /// <param name="logger">Logger instance</param>
        public PortfoliosController(
            IPortfolioService portfolioService,
            ILogger<PortfoliosController> logger
        )
        {
            _portfolioService = portfolioService;
            _logger = logger;
        }

        /// <summary>
        /// Gets all portfolios
        /// </summary>
        /// <returns>List of portfolios</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Portfolio>>> GetAllPortfolios()
        {
            try
            {
                var portfolios = await _portfolioService.GetAllPortfoliosAsync();
                return Ok(portfolios);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error retrieving portfolios. The Portfolios table may not exist yet."
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The Portfolios table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }

        /// <summary>
        /// Gets a portfolio by ID
        /// </summary>
        /// <param name="id">Portfolio ID</param>
        /// <returns>Portfolio</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Portfolio>> GetPortfolioById(Guid id)
        {
            try
            {
                var portfolio = await _portfolioService.GetPortfolioByIdAsync(id);

                if (portfolio == null)
                {
                    return NotFound($"Portfolio with ID {id} not found");
                }

                return Ok(portfolio);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error retrieving portfolio with ID {Id}. The Portfolios table may not exist yet.",
                    id
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The Portfolios table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }

        /// <summary>
        /// Gets portfolios by owner ID
        /// </summary>
        /// <param name="ownerId">Owner ID</param>
        /// <returns>List of portfolios owned by the specified user</returns>
        [HttpGet("owner/{ownerId}")]
        public async Task<ActionResult<IEnumerable<Portfolio>>> GetPortfoliosByOwnerId(Guid ownerId)
        {
            try
            {
                var portfolios = await _portfolioService.GetPortfoliosByOwnerIdAsync(ownerId);
                return Ok(portfolios);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error retrieving portfolios for owner with ID {OwnerId}. The Portfolios table may not exist yet.",
                    ownerId
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The Portfolios table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }

        /// <summary>
        /// Adds a new portfolio
        /// </summary>
        /// <param name="portfolio">Portfolio to add</param>
        /// <returns>Created portfolio</returns>
        [HttpPost]
        public async Task<ActionResult<Portfolio>> AddPortfolio([FromBody] Portfolio portfolio)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var addedPortfolio = await _portfolioService.AddPortfolioAsync(portfolio);
                return CreatedAtAction(
                    nameof(GetPortfolioById),
                    new { id = addedPortfolio.Id },
                    addedPortfolio
                );
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error adding portfolio. The Portfolios table may not exist yet."
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The Portfolios table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }

        /// <summary>
        /// Updates an existing portfolio
        /// </summary>
        /// <param name="id">Portfolio ID</param>
        /// <param name="portfolio">Updated portfolio</param>
        /// <returns>Updated portfolio</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<Portfolio>> UpdatePortfolio(
            Guid id,
            [FromBody] Portfolio portfolio
        )
        {
            try
            {
                if (id != portfolio.Id)
                {
                    return BadRequest("ID in URL does not match ID in the request body");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var existingPortfolio = await _portfolioService.GetPortfolioByIdAsync(id);
                if (existingPortfolio == null)
                {
                    return NotFound($"Portfolio with ID {id} not found");
                }

                var updatedPortfolio = await _portfolioService.UpdatePortfolioAsync(portfolio);
                return Ok(updatedPortfolio);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error updating portfolio with ID {Id}. The Portfolios table may not exist yet.",
                    id
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The Portfolios table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }

        /// <summary>
        /// Deletes a portfolio
        /// </summary>
        /// <param name="id">Portfolio ID</param>
        /// <returns>No content if successful</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePortfolio(Guid id)
        {
            try
            {
                var portfolio = await _portfolioService.GetPortfolioByIdAsync(id);
                if (portfolio == null)
                {
                    return NotFound($"Portfolio with ID {id} not found");
                }

                var result = await _portfolioService.DeletePortfolioAsync(id);
                if (result)
                {
                    return NoContent();
                }
                else
                {
                    return StatusCode(500, "Failed to delete portfolio");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error deleting portfolio with ID {Id}. The Portfolios table may not exist yet.",
                    id
                );
                return StatusCode(
                    500,
                    new
                    {
                        error = "The Portfolios table may not exist yet. Please run the database migration first.",
                        details = ex.Message,
                        innerException = ex.InnerException?.Message,
                    }
                );
            }
        }
    }
}
