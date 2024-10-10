using System.Collections.Generic;
using Core.Application.Interfaces.Repositories;
using Core.Domain.Entities;

namespace Infrastructure.Data.Repositories
{
    public class SitemapRepository : ISitemapRepository
    {
        // Simulating data; in real use, this could be fetched from a database.
        public IEnumerable<Sitemap> GetAllSitemapItems()
        {
            return new List<Sitemap>
            {
                new Sitemap { Id = Guid.NewGuid(), PageName = "Home", Description = "Home Page", Slug = "/", AccessByRole = Role.Guest },
                new Sitemap { Id = Guid.NewGuid(), PageName = "About", Description = "About Us", Slug = "/about", AccessByRole = Role.Guest },
                new Sitemap { Id = Guid.NewGuid(), PageName = "Contact", Description = "Contact Us", Slug = "/contact", AccessByRole = Role.StandardUser },
                new Sitemap { Id = Guid.NewGuid(), PageName = "Dashboard", Description = "Admin Dashboard", Slug = "/dashboard", AccessByRole = Role.Admin }
            };
        }
    }
}
