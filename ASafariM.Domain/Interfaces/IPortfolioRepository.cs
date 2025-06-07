using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;

namespace ASafariM.Domain.Interfaces
{
    /// <summary>
    /// Interface for Portfolio repository operations
    /// </summary>
    public interface IPortfolioRepository
    {
        /// <summary>
        /// Gets all portfolios
        /// </summary>
        /// <returns>List of portfolios</returns>
        Task<IEnumerable<Portfolio>> GetAllAsync();

        /// <summary>
        /// Gets a portfolio by its ID
        /// </summary>
        /// <param name="id">Portfolio ID</param>
        /// <returns>Portfolio if found, null otherwise</returns>
        Task<Portfolio> GetByIdAsync(Guid id);

        /// <summary>
        /// Gets portfolios by owner ID
        /// </summary>
        /// <param name="ownerId">Owner ID</param>
        /// <returns>List of portfolios owned by the specified user</returns>
        Task<IEnumerable<Portfolio>> GetByOwnerIdAsync(Guid ownerId);

        /// <summary>
        /// Adds a new portfolio
        /// </summary>
        /// <param name="portfolio">Portfolio to add</param>
        /// <returns>Added portfolio</returns>
        Task<Portfolio> AddAsync(Portfolio portfolio);

        /// <summary>
        /// Updates an existing portfolio
        /// </summary>
        /// <param name="portfolio">Portfolio with updated information</param>
        /// <returns>Updated portfolio</returns>
        Task<Portfolio> UpdateAsync(Portfolio portfolio);

        /// <summary>
        /// Deletes a portfolio
        /// </summary>
        /// <param name="id">ID of the portfolio to delete</param>
        /// <returns>True if deleted successfully, false otherwise</returns>
        Task<bool> DeleteAsync(Guid id);
    }
}
