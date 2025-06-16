using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;

namespace ASafariM.Application.Interfaces
{
    public interface IBibliographyService
    {
        Task<IEnumerable<BibliographyItem>> GetAllBibliographyItemsAsync();
        Task<BibliographyItem> GetBibliographyItemByIdAsync(Guid id);
        Task<BibliographyItem> AddBibliographyItemAsync(BibliographyItem item);
        Task<BibliographyItem> UpdateBibliographyItemAsync(BibliographyItem item);
        Task<bool> DeleteBibliographyItemAsync(Guid id);
        Task<IEnumerable<BibliographyItem>> SearchBibliographyItemsAsync(string searchTerm);
    }
}
