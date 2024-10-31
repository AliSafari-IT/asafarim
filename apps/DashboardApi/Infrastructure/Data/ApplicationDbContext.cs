// apps/DashboardApi/Infrastructure/Data/ApplicationDbContext.cs

using System;
using System.ComponentModel.DataAnnotations;
using DashboardApi.Core.Domain.Entities;
using DashboardApi.Core.Domain.Enum;
using Microsoft.EntityFrameworkCore;

namespace DashboardApi.Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectClient> ProjectClients { get; set; }
        public DbSet<Panel> Panels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Users
            var adminUser = new User
            {
                Id = Guid.NewGuid(),
                Username = "admin",
                Email = "admin@asm.com",
                PasswordHash = "AQAAAAIAAYagAAAAEOKlPRS/QM3Cwap8gPgQxmoe3YnRicXFekLb+BVDYrQvr349cjI0d3LD9G/rPWOhEQ==",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            var regularUser = new User
            {
                Id = Guid.NewGuid(),
                Username = "ali",
                Email = "ali@asm.com",
                PasswordHash = "AQAAAAIAAYagAAAAEOKlPRS/QM3Cwap8gPgQxmoe3YnRicXFekLb+BVDYrQvr349cjI0d3LD9G/rPWOhEQ==",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            modelBuilder.Entity<User>().HasData(adminUser, regularUser);

            // Seed Roles
            var adminRole = new Role
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                Description = "Admin Role",
            };

            var userRole = new Role
            {
                Id = Guid.NewGuid(),
                Name = "User",
                Description = "User Role",
            };

            modelBuilder.Entity<Role>().HasData(adminRole, userRole);

            // Seed Permissions
            var adminPermission = new Permission
            {
                Id = Guid.NewGuid(),
                Name = "Admin rights",
                Description = "All permission rights including create, read, update, delete, view",
            };

            var userPermission = new Permission
            {
                Id = Guid.NewGuid(),
                Name = "User rights",
                Description = "Included permission rights: create, read, update, soft delete, view",
            };

            modelBuilder.Entity<Permission>().HasData(adminPermission, userPermission);

            // Seed Topics
            var topic1 = new Topic
            {
                Id = Guid.NewGuid(),
                Name = "Database Schema",
                Description = "Creating a database schema for a new product",
                DifficultyLevel = DifficultyLevelEnum.Easy,
                TechnologyCategory = TechnologyCategoryEnum.Database,
                CreatedDate = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow,
                PostCount = 0
            };

            var topic2 = new Topic
            {
                Id = Guid.NewGuid(),
                Name = "React Typescript Blog",
                Description = "Creating a blog with React and Typescript",
                DifficultyLevel = DifficultyLevelEnum.Medium,
                TechnologyCategory = TechnologyCategoryEnum.Frontend,
                CreatedDate = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow,
                PostCount = 0
            };

            modelBuilder.Entity<Topic>().HasData(topic1, topic2);

            // Seed BlogPosts
            var blogPost1 = new BlogPost
            {
                Id = Guid.NewGuid(),
                Title = "Creating a Database Schema",
                Content = "Detailed explanation of creating a database schema.",
                PublishedDate = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow,
                DifficultyLevel = DifficultyLevelEnum.Easy,
                TopicId = topic1.Id,
                IsPublished = true
            };

            var blogPost2 = new BlogPost
            {
                Id = Guid.NewGuid(),
                Title = "React and Typescript",
                Content = "Creating a blog using React and Typescript.",
                PublishedDate = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow,
                DifficultyLevel = DifficultyLevelEnum.Medium,
                TopicId = topic2.Id,
                IsPublished = true
            };

            modelBuilder.Entity<BlogPost>().HasData(blogPost1, blogPost2);

            // Seed Projects
            var project1 = new Project
            {
                Id = Guid.NewGuid(),
                Title = "Database Schema Project",
                Description = "Create a database schema for a new product",
                StartDate = DateTime.UtcNow,
                Budget = 1000,
                IsCompleted = false,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow
            };

            modelBuilder.Entity<Project>().HasData(project1);

            // Seed UserRoles
            var userRoleEntry = new UserRole
            {
                Id = Guid.NewGuid(),
                UserId = adminUser.Id,
                RoleId = adminRole.Id
            };

            modelBuilder.Entity<UserRole>().HasData(userRoleEntry);

            // UserBlogPost   
            modelBuilder.Entity<UserBlogPost>()
        .HasKey(ub => new { ub.UserId, ub.BlogPostId });

            modelBuilder.Entity<UserBlogPost>()
                .HasOne(ub => ub.User)
                .WithMany(u => u.UserBlogPosts)
                .HasForeignKey(ub => ub.UserId);

            modelBuilder.Entity<UserBlogPost>()
                .HasOne(ub => ub.BlogPost)
                .WithMany(b => b.UserBlogPosts)
                .HasForeignKey(ub => ub.BlogPostId);
        }
    }
}
