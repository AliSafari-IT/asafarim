using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using DashboardApi.Core.Domain.Entities;
using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;  // Fully qualify the Role from this namespace

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // Build configuration
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();

            // Get connection string
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Set up DbContext options
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<DashboardApi.Core.Domain.Entities.Role> Roles { get; set; } // Fully qualified
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<SitemapEntity> Sitemaps { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure many-to-many relationship between User and BlogPost
            modelBuilder.Entity<User>()
                .HasMany(u => u.BlogPosts)
                .WithMany(bp => bp.Authors)
                .UsingEntity<Dictionary<string, object>>(
                    "UserBlogPost",
                    j => j
                        .HasOne<BlogPost>()
                        .WithMany()
                        .HasForeignKey("BlogPostsId")
                        .HasConstraintName("FK_UserBlogPost_BlogPosts_BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade),
                    j => j
                        .HasOne<User>()
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .HasConstraintName("FK_UserBlogPost_Users_UserId")
                        .OnDelete(DeleteBehavior.Cascade));


            var hashedPassword = "AQAAAAIAAYagAAAAEOKlPRS/QM3Cwap8gPgQxmoe3YnRicXFekLb+BVDYrQvr349cjI0d3LD9G/rPWOhEQ=="; // Password: Ali+123456/

            // User and Role IDs
            var userId = new Guid("c032f3c0-877a-11ef-b2d0-bc2411fc845a");
            var roleId = new Guid("55555555-5555-5555-5555-555555555555");

            // BlogPost and Topic IDs
            var post1Id = new Guid("22222222-2222-2222-2222-222222222222");
            var topic1Id = new Guid("11111111-1111-1111-1111-111111111111");

            // Tag IDs
            var tag1Id = new Guid("33333333-3333-3333-3333-333333333333");
            var tag2Id = new Guid("44444444-4444-4444-4444-444444444444");

            // Sitemap IDs
            var sitemap1Id = new Guid("55555555-5555-5555-5555-555555555555");

            // Seed User
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = userId,
                Name = "Ali",
                Username = "ali",
                Email = "ali@asm.com",
                PasswordHash = hashedPassword,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = roleId,
                Name = "Admin",
                Description = "Administrator role"
            });

            // Seed UserRoles
            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                UserId = userId,
                RoleId = roleId
            });

            // Seed Topic
            modelBuilder.Entity<Topic>().HasData(new Topic
            {
                Id = topic1Id,
                Name = "React",
                Description = "Frontend library for building user interfaces.",
                CreatedDate = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow,
                TechnologyCategory = "Frontend",
                DifficultyLevel = "Intermediate",
                PostCount = 1,
                Tags = new List<string> { "JavaScript", "Frontend" }
            });

            // Seed BlogPost
            modelBuilder.Entity<BlogPost>().HasData(new BlogPost
            {
                Id = post1Id,
                Title = "Introduction to React",
                Content = "Full content here...",
                Summary = "Learn the basics of React.",
                Excerpt = "An introductory post about React.",
                PublishedDate = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow,
                Slug = "introduction-to-react",
                ViewCount = 0,
                IsPublished = true,
                ImageUrl = "https://example.com/image.jpg",
                MetaDescription = "Introduction to React for beginners.",
                TopicId = topic1Id
            });

            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    Id = tag1Id,
                    Name = "CSharp",
                    Title = "C#"
                },
                new Tag
                {
                    Id = tag2Id,
                    Name = "DotNet",
                    Title = ".NET"
                }
            );


            // Seed the join table for User and BlogPost
            modelBuilder.Entity("UserBlogPost").HasData(
                new { UsersId = userId, BlogPostsId = post1Id }
            );

            // Seed the join table for BlogPost and Tag
            modelBuilder.Entity("BlogPostTag").HasData(
                new { BlogPostsId = post1Id, TagsId = tag1Id },
                new { BlogPostsId = post1Id, TagsId = tag2Id }
            );

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
            modelBuilder.Entity<SitemapEntity>().HasData(
                new SitemapEntity
                {
                    Id = Guid.NewGuid(),
                    PageName = "Contact",
                    Description = "Contact Page",
                    Slug = "/contact",
                    AccessByRole = Core.Domain.Enum.EnumUserRole.StandardUser
                },
                new SitemapEntity
                {
                    Id = Guid.NewGuid(),
                    PageName = "About",
                    Description = "About Page",
                    Slug = "/about",
                    AccessByRole = Core.Domain.Enum.EnumUserRole.StandardUser
                }
            );

            // Configure one-to-many relationship between Topic and BlogPost
            modelBuilder.Entity<Topic>()
                .HasMany(t => t.RelatedPosts)
                .WithOne(p => p.Topic)
                .HasForeignKey(p => p.TopicId);

            // Value Comparer for Tags
            var stringListValueComparer = new ValueComparer<List<string>>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList());

            modelBuilder.Entity<Topic>()
                .Property(t => t.Tags)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList())
                .Metadata
                .SetValueComparer(stringListValueComparer);

            // Configure many-to-many relationship between BlogPost and Tag
            modelBuilder.Entity<BlogPost>()
                .HasMany(bp => bp.Tags)
                .WithMany(t => t.BlogPosts);

            // In OnModelCreating
            var tag1 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "CSharp",
                Title = "C#"
            };

            var tag2 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "DotNet",
                Title = ".NET"
            };

            modelBuilder.Entity<Tag>().HasData(tag1, tag2);

            // Other seeding logic (Roles, Users, etc.)
        }

    }
}
