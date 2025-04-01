using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASafariM.Application.Services
{
    /// <summary>
    /// Implementation of the portfolio service
    /// </summary>
    public class PortfolioService : IPortfolioService
    {
        private readonly IPortfolioRepository _portfolioRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="portfolioRepository">Portfolio repository</param>
        public PortfolioService(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Portfolio>> GetAllPortfoliosAsync()
        {
            return await _portfolioRepository.GetAllAsync();
        }

        /// <inheritdoc/>
        public async Task<Portfolio> GetPortfolioByIdAsync(Guid id)
        {
            return await _portfolioRepository.GetByIdAsync(id);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Portfolio>> GetPortfoliosByOwnerIdAsync(Guid ownerId)
        {
            return await _portfolioRepository.GetByOwnerIdAsync(ownerId);
        }

        /// <inheritdoc/>
        public async Task<Portfolio> AddPortfolioAsync(Portfolio portfolio)
        {
            return await _portfolioRepository.AddAsync(portfolio);
        }

        /// <inheritdoc/>
        public async Task<Portfolio> UpdatePortfolioAsync(Portfolio portfolio)
        {
            return await _portfolioRepository.UpdateAsync(portfolio);
        }

        /// <inheritdoc/>
        public async Task<bool> DeletePortfolioAsync(Guid id)
        {
            return await _portfolioRepository.DeleteAsync(id);
        }
    }
}
