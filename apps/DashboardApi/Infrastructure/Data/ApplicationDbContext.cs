using Microsoft.EntityFrameworkCore;
using Core.Domain.Entities;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sitemap> Sitemaps { get; set; }
    }
}
