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

            var adminRoleId = new Guid("166ecfcb-e06d-41ea-bce7-a307d87645c7");

            // Seed the ali user
            var aliUserId = Guid.NewGuid();
            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = aliUserId,
                Username = "ali",
                Email = "ali@asafarim.com",
                CreatedAt = DateTime.UtcNow,
                PasswordHash = hasher.HashPassword(null, "Ali+123456/"),
                UpdatedAt = DateTime.UtcNow,
            });

            // Configure the Role enum to be stored as a string
            modelBuilder.Entity<Sitemap>()
                .Property(s => s.AccessByRole)
                .HasConversion<string>();

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

            // Configure many-to-many relationship between User and Role
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);

            // Seed Guest and StandardUser roles using the fully qualified name
            var guestRoleId = Guid.NewGuid();
            var standardUserRoleId = Guid.NewGuid();

            modelBuilder.Entity<DashboardApi.Core.Domain.Entities.Role>().HasData(
                new DashboardApi.Core.Domain.Entities.Role { Id = guestRoleId, Name = "Guest" },
                new DashboardApi.Core.Domain.Entities.Role { Id = standardUserRoleId, Name = "StandardUser" }
            );

            // Optional: Link the ali user to the StandardUser role
            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                UserId = aliUserId,
                RoleId = standardUserRoleId
            });
        }
    }
}
