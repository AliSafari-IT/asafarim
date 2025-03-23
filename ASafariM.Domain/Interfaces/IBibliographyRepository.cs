using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;

namespace ASafariM.Domain.Interfaces
{
    public interface IBibliographyRepository
    {
        Task<IEnumerable<BibliographyItem>> GetAllAsync();
        Task<BibliographyItem> GetByIdAsync(Guid id);
        Task<BibliographyItem> AddAsync(BibliographyItem item);
        Task<BibliographyItem> UpdateAsync(BibliographyItem item);
        Task<bool> DeleteAsync(Guid id);
    }
}
