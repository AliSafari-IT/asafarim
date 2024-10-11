using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using Core.Domain.Entities;
using DashboardApi.Core.Domain.Entities;  // Fully qualify the Role from this namespace

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<DashboardApi.Core.Domain.Entities.Role> Roles { get; set; }  // Fully qualified
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Sitemap> Sitemaps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var hasher = new PasswordHasher<User>();

            // Update the existing admin user with a new password
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = new Guid("32b57e5c-d6dd-4eee-91e0-21b7d96aad2e"), // Replace with actual admin user Id
                Username = "admin",
                Email = "admin@asafarim.com",
                PasswordHash = hasher.HashPassword(null, "admin+123456"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            });


            // Configure the composite primary key for UserRole
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            // Define relationships
            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);

            // Seed Sitemap data
            modelBuilder.Entity<Sitemap>().HasData(
                new Sitemap
                {
                    Id = Guid.NewGuid(),
                    PageName = "Contact",
                    Description = "Contact Page",
                    Slug = "/contact",
                    AccessByRole = Core.Domain.Entities.Role.StandardUser
                },
                new Sitemap
                {
                    Id = Guid.NewGuid(),
                    PageName = "About",
                    Description = "About Page",
                    Slug = "/about",
                    AccessByRole = Core.Domain.Entities.Role.StandardUser
                }
            );

            // Other seeding logic (Roles, Users, etc.)
        }


    }
}
