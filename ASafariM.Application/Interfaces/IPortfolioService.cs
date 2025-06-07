using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;

namespace ASafariM.Application.Interfaces
{
    /// <summary>
    /// Interface for portfolio service operations
    /// </summary>
    public interface IPortfolioService
    {
        /// <summary>
        /// Gets all portfolios
        /// </summary>
        /// <returns>List of portfolios</returns>
        Task<IEnumerable<Portfolio>> GetAllPortfoliosAsync();

        /// <summary>
        /// Gets a portfolio by its ID
        /// </summary>
        /// <param name="id">Portfolio ID</param>
        /// <returns>Portfolio if found, null otherwise</returns>
        Task<Portfolio> GetPortfolioByIdAsync(Guid id);

        /// <summary>
        /// Gets portfolios by owner ID
        /// </summary>
        /// <param name="ownerId">Owner ID</param>
        /// <returns>List of portfolios owned by the specified user</returns>
        Task<IEnumerable<Portfolio>> GetPortfoliosByOwnerIdAsync(Guid ownerId);

        /// <summary>
        /// Adds a new portfolio
        /// </summary>
        /// <param name="portfolio">Portfolio to add</param>
        /// <returns>Added portfolio</returns>
        Task<Portfolio> AddPortfolioAsync(Portfolio portfolio);

        /// <summary>
        /// Updates an existing portfolio
        /// </summary>
        /// <param name="portfolio">Portfolio with updated information</param>
        /// <returns>Updated portfolio</returns>
        Task<Portfolio> UpdatePortfolioAsync(Portfolio portfolio);

        /// <summary>
        /// Deletes a portfolio
        /// </summary>
        /// <param name="id">ID of the portfolio to delete</param>
        /// <returns>True if deleted successfully, false otherwise</returns>
        Task<bool> DeletePortfolioAsync(Guid id);
    }
}
