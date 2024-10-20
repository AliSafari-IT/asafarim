using System.Collections.Generic;
using Core.Application.Interfaces.Repositories;
using Core.Domain.Entities;
using Core.Domain.Enum;
using DashboardApi.Core.Domain.Entities;

namespace Core.Application.Sitemaps.Queries
{
    public class GetSitemapQuery
    {
        private readonly ISitemapRepository _sitemapRepository;

        public GetSitemapQuery(ISitemapRepository sitemapRepository)
        {
            _sitemapRepository = sitemapRepository;
        }

        public IEnumerable<SitemapEntity> Execute(EnumUserRole roleIndex)
        {
            var allSitemaps = _sitemapRepository.GetAllSitemapItems();
            Console.WriteLine(allSitemaps);
            // Filter based on the user role
            return allSitemaps.Where(s => s.AccessByRole <= roleIndex);
        }
    }
}
