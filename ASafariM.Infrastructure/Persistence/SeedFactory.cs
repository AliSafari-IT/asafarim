using ASafariM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ASafariM.Infrastructure.Persistence;

public static class SeedFactory
{
    public static void SeedDatabase(ModelBuilder modelBuilder)
    {
        SeedUsers(modelBuilder);
        SeedRoles(modelBuilder);
        SeedFileFormats(modelBuilder);
        SeedPaginationSettings(modelBuilder);
        SeedDateFormats(modelBuilder);
        SeedCurrencies(modelBuilder);
        SeedTimeZones(modelBuilder);
        SeedCountries(modelBuilder);
        SeedTags(modelBuilder);
        SeedTopics(modelBuilder);
        SeedBibliographyItems(modelBuilder);
    }

    private static void SeedUsers(ModelBuilder modelBuilder)
    {
        var userId = Guid.Parse("8048da39-cdaf-47a9-9fb1-960d81dd704a");
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = userId,
                FirstName = "Demo Admin",
                LastName = "Account",
                Email = "demo_admin@example.com",
                NormalizedEmail = "DEMO_ADMIN@EXAMPLE.COM",
                PasswordHash = PasswordHasher.HashPassword("Demo+123456/"),
                LastLogin = new DateTime(2025, 2, 17, 10, 0, 0),
                PhoneNumber = "+123456789",
                PhoneNumberConfirmed = true,
                UserName = "demo_admin",
                NormalizedUserName = "DEMO_ADMIN",
                SecurityStamp = "demo_admin@example.com",
                ConcurrencyStamp = "demo_admin@example.com",
                IsActive = true,
                ProfilePicture = "https://asafarim.com/logoT.svg",
                CreatedBy = userId,
                CreatedAt = new DateTime(2025, 2, 17, 10, 0, 0),
                UpdatedBy = userId,
                UpdatedAt = new DateTime(2025, 2, 17, 10, 0, 0),
                IsAdmin = true,
                IsSuperAdmin = true,
                IsPending = false,
                IsBannedByAdmin = false,
                IsBlocked = false,
                IsModerator = false,
                IsStandardUser = true,
                IsGuest = false,
                IsEditor = false,
                IsLockedOut = false,
                IsVerified = true,
                DateOfBirth = new DateTime(1975, 7, 15),
                IsDeleted = false,
                DeletedAt = null,
                DeletedBy = null,
            }
        );

        // Add other user seeds similarly...
    }

    private static void SeedRoles(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(
            new Role
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                Description = "Admin role has full administrative privileges, except for application management.",
            },
            // Add other roles similarly...
        );
    }

    private static void SeedFileFormats(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FileFormat>().HasData(
            new FileFormat
            {
                Id = Guid.NewGuid(),
                Name = "Plain Text",
                Extension = ".txt",
                MimeType = "text/plain",
                Description = "Simple text document format",
            },
            // Add other file formats similarly...
        );
    }

    // Add other seeding methods similarly...
}
