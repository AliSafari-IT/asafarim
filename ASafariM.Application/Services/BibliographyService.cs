using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace ASafariM.Application.Services
{
    public class BibliographyService : IBibliographyService
    {
        private readonly IBibliographyRepository _bibliographyRepository;
        private readonly ILogger<BibliographyService> _logger;

        public BibliographyService(IBibliographyRepository bibliographyRepository, ILogger<BibliographyService> logger)
        {
            _bibliographyRepository = bibliographyRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<BibliographyItem>> GetAllBibliographyItemsAsync()
        {
            try
            {
                return await _bibliographyRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving all bibliography items. The table may not exist yet.");
                return new List<BibliographyItem>();
            }
        }

        public async Task<BibliographyItem> GetBibliographyItemByIdAsync(Guid id)
        {
            try
            {
                return await _bibliographyRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving bibliography item with ID {Id}. The table may not exist yet.", id);
                return null;
            }
        }

        public async Task<BibliographyItem> AddBibliographyItemAsync(BibliographyItem item)
        {
            try
            {
                return await _bibliographyRepository.AddAsync(item);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding bibliography item. The table may not exist yet.");
                throw;
            }
        }

        public async Task<BibliographyItem> UpdateBibliographyItemAsync(BibliographyItem item)
        {
            try
            {
                return await _bibliographyRepository.UpdateAsync(item);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating bibliography item with ID {Id}. The table may not exist yet.", item.Id);
                throw;
            }
        }

        public async Task<bool> DeleteBibliographyItemAsync(Guid id)
        {
            try
            {
                return await _bibliographyRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting bibliography item with ID {Id}. The table may not exist yet.", id);
                return false;
            }
        }

        public async Task<IEnumerable<BibliographyItem>> SearchBibliographyItemsAsync(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    return await GetAllBibliographyItemsAsync();
                }

                var allItems = await GetAllBibliographyItemsAsync();

                return allItems.Where(item =>
                    item.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    item.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    item.Genre.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    item.Year.ToString().Contains(searchTerm)
                );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching bibliography items with term {Term}. The table may not exist yet.", searchTerm);
                return new List<BibliographyItem>();
            }
        }
    }
}
