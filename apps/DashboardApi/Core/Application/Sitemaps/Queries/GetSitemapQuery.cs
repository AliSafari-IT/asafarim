using System.Collections.Generic;
using Core.Application.Interfaces.Repositories;
using Core.Domain.Entities;

namespace Core.Application.Sitemaps.Queries
{
    public class GetSitemapQuery
    {
        private readonly ISitemapRepository _sitemapRepository;

        public GetSitemapQuery(ISitemapRepository sitemapRepository)
        {
            _sitemapRepository = sitemapRepository;
        }

        public IEnumerable<Sitemap> Execute(Role userRole)
        {
            var allSitemaps = _sitemapRepository.GetAllSitemapItems();

            // Filter based on the user role
            return allSitemaps.Where(s => s.AccessByRole <= userRole);
        }
    }
}
