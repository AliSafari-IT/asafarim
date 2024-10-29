using System;
using DashboardApi.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DashboardApi.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<BlogPostTag> BlogPostTags { get; set; }
        public DbSet<ProjectClient> ProjectClients { get; set; } // Add DbSet for ProjectClient

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var userId1 = new Guid("c032f3c0-877a-11ef-b2d0-bc2411fc845a"); // Unique user ID
            var userId2 = new Guid("00000000-0000-0000-0000-000000000002"); // Another unique user ID
            var existingUserId = new Guid("00000000-0000-0000-0000-000000000005"); // Make sure this is unique or remove it
            var hashedPassword =
                "AQAAAAIAAYagAAAAEOKlPRS/QM3Cwap8gPgQxmoe3YnRicXFekLb+BVDYrQvr349cjI0d3LD9G/rPWOhEQ=="; // Password: Ali+123456/

            // Seed users with unique IDs only
            modelBuilder
                .Entity<User>()
                .HasData(
                    new User
                    {
                        Id = userId1,
                        Name = "tara",
                        Username = "tara",
                        Email = "tara@examplea.com",
                        PasswordHash = hashedPassword,
                    },
                    new User
                    {
                        Id = userId2,
                        Name = "kian",
                        Username = "kian",
                        Email = "kian@exampleb.com",
                        PasswordHash = hashedPassword,
                    },
                    new User
                    {
                        Id = existingUserId, // Only if this ID is unique and intentional
                        Name = "DuplicateUser" // Ensure this user is supposed to be seeded
                    }
                );

            // Continue seeding other entities such as Projects here...
            var projectId1 = new Guid("00000000-0000-0000-0000-000000000003");
            var projectId2 = new Guid("00000000-0000-0000-0000-000000000004");

            // Seed projects
            modelBuilder
                .Entity<Project>()
                .HasData(
                    new Project
                    {
                        Id = projectId1,
                        Title = "Project 1",
                    },
                    new Project
                    {
                        Id = projectId2,
                        Title = "Project 2",
                    }
                );

            // Define the BlogPostTag entity with a composite key
            modelBuilder.Entity<BlogPostTag>().HasKey(bpt => new { bpt.BlogPostId, bpt.TagId });

            // Configure the many-to-many relationship for BlogPostTag
            modelBuilder
                .Entity<BlogPostTag>()
                .HasOne(bpt => bpt.BlogPost)
                .WithMany(bp => bp.BlogPostTags)
                .HasForeignKey(bpt => bpt.BlogPostId);

            modelBuilder
                .Entity<BlogPostTag>()
                .HasOne(bpt => bpt.Tag)
                .WithMany(t => t.BlogPostTags)
                .HasForeignKey(bpt => bpt.TagId);

            // Define the composite key for the ProjectClient entity
            modelBuilder.Entity<ProjectClient>().HasKey(pc => new { pc.ProjectId, pc.ClientId });

            modelBuilder
                .Entity<ProjectClient>()
                .HasOne(pc => pc.Project)
                .WithMany(p => p.ProjectClients)
                .HasForeignKey(pc => pc.ProjectId);

            modelBuilder
                .Entity<ProjectClient>()
                .HasOne(pc => pc.Client)
                .WithMany() // If you don't need to reference all clients from User, keep it empty
                .HasForeignKey(pc => pc.ClientId);
        }
    }
}
