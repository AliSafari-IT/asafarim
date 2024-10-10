using System.Collections.Generic;
using Core.Domain.Entities;

namespace Core.Application.Interfaces.Repositories
{
    public interface ISitemapRepository
    {
        IEnumerable<Sitemap> GetAllSitemapItems();
    }
}
