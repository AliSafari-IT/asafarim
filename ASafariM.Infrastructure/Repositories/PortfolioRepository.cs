using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ASafariM.Infrastructure.Repositories
{
    /// <summary>
    /// Implementation of the Portfolio repository
    /// </summary>
    public class PortfolioRepository : IPortfolioRepository
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Database context</param>
        public PortfolioRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Portfolio>> GetAllAsync()
        {
            return await _context
                .Portfolios.Where(p => !p.IsDeleted)
                .Include(p => p.Owner)
                .ToListAsync();
        }

        /// <inheritdoc/>
        public async Task<Portfolio> GetByIdAsync(Guid id)
        {
            return await _context
                .Portfolios.Where(p => p.Id == id && !p.IsDeleted)
                .Include(p => p.Owner)
                .FirstOrDefaultAsync();
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Portfolio>> GetByOwnerIdAsync(Guid ownerId)
        {
            return await _context
                .Portfolios.Where(p => p.OwnerId == ownerId && !p.IsDeleted)
                .Include(p => p.Owner)
                .ToListAsync();
        }

        /// <inheritdoc/>
        public async Task<Portfolio> AddAsync(Portfolio portfolio)
        {
            portfolio.CreatedAt = DateTime.UtcNow;
            portfolio.IsActive = true;
            portfolio.IsDeleted = false;

            await _context.Portfolios.AddAsync(portfolio);
            await _context.SaveChangesAsync();

            return portfolio;
        }

        /// <inheritdoc/>
        public async Task<Portfolio> UpdateAsync(Portfolio portfolio)
        {
            var existingPortfolio = await _context.Portfolios.FirstOrDefaultAsync(p =>
                p.Id == portfolio.Id && !p.IsDeleted
            );

            if (existingPortfolio == null)
            {
                return null;
            }

            existingPortfolio.Title = portfolio.Title;
            existingPortfolio.Summary = portfolio.Summary;
            existingPortfolio.AboutMarkdown = portfolio.AboutMarkdown;
            existingPortfolio.ExperienceMarkdown = portfolio.ExperienceMarkdown;
            existingPortfolio.PublicationsMarkdown = portfolio.PublicationsMarkdown;
            existingPortfolio.FundingMarkdown = portfolio.FundingMarkdown;
            existingPortfolio.Visibility = portfolio.Visibility;
            existingPortfolio.UpdatedAt = DateTime.UtcNow;
            existingPortfolio.UpdatedBy = portfolio.UpdatedBy;

            _context.Portfolios.Update(existingPortfolio);
            await _context.SaveChangesAsync();

            return existingPortfolio;
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteAsync(Guid id)
        {
            var portfolio = await _context.Portfolios.FirstOrDefaultAsync(p =>
                p.Id == id && !p.IsDeleted
            );

            if (portfolio == null)
            {
                return false;
            }

            portfolio.IsDeleted = true;
            portfolio.DeletedAt = DateTime.UtcNow;

            _context.Portfolios.Update(portfolio);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
