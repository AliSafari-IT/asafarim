using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

using DashboardApi.Core.Domain.Entities;
using Core.Domain.Entities;  // Fully qualify the Role from this namespace

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
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = new Guid("c032f3c0-877a-11ef-b2d0-bc2411fc845a"),
                Username = "ali",
                Email = "ali@asm.com",
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Ali+123456/"), // Direct instantiation
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
                    AccessByRole = Core.Domain.Enum.EnumUserRole.StandardUser
                },
                new Sitemap
                {
                    Id = Guid.NewGuid(),
                    PageName = "About",
                    Description = "About Page",
                    Slug = "/about",
                    AccessByRole = Core.Domain.Enum.EnumUserRole.StandardUser
                }
            );

            // Other seeding logic (Roles, Users, etc.)
        }


    }
}
