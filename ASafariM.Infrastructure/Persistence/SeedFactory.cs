using ASafariM.Application.Utils;
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
        modelBuilder
            .Entity<User>()
            .HasData(
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
    }

    private static void SeedRoles(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Role>()
            .HasData(
                new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin",
                    Description =
                        "Admin role has full administrative privileges, except for application management.",
                }
            );
    }

    private static void SeedFileFormats(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<FileFormat>()
            .HasData(
                new FileFormat
                {
                    Id = Guid.NewGuid(),
                    Name = "Plain Text",
                    Extension = ".txt",
                    MimeType = "text/plain",
                    Description = "Simple text document format",
                }
            );
    }

    private static void SeedPaginationSettings(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<PaginationSettings>()
            .HasData(
                new PaginationSettings
                {
                    Id = Guid.NewGuid(),
                    ItemsPerPage = 10,
                    ShowPageNumbers = true,
                    ShowFirstLastButtons = true,
                    VisiblePageRange = 5,
                    EnableInfiniteScroll = false,
                    ShowItemsCount = true,
                    ShowPageSizeSelector = true,
                    PageSizeOptions = "10,25,50,100",
                    IsDefault = true,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                }
            );
    }

    private static void SeedDateFormats(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<DateFormat>()
            .HasData(
                new DateFormat
                {
                    Id = Guid.NewGuid(),
                    Format = "yyyy-MM-dd",
                    DisplayName = "ISO 8601",
                    Example = "2025-12-31",
                    IsDefault = true,
                }
            );
    }

    private static void SeedCurrencies(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Currency>()
            .HasData(
                new Currency
                {
                    Id = Guid.NewGuid(),
                    Name = "US Dollar",
                    Code = "USD",
                    Symbol = "$",
                    DecimalPlaces = 2,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                }
            );
    }

    private static void SeedTimeZones(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<ASafariM.Domain.Entities.TimeZone>()
            .HasData(
                new ASafariM.Domain.Entities.TimeZone
                {
                    Id = Guid.NewGuid(),
                    Name = "UTC",
                    StandardName = "UTC",
                    UtcOffset = "+00:00",
                    UsesDaylightSaving = false,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                }
            );
    }

    private static void SeedCountries(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Country>()
            .HasData(
                new Country
                {
                    Id = Guid.NewGuid(),
                    Name = "United States",
                    IsoCode = "US",
                    IsoCode3 = "USA",
                    PhoneCode = "+1",
                    Capital = "Washington, D.C.",
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                }
            );
    }

    private static void SeedTags(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Tag>()
            .HasData(
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "Development",
                    Slug = "development",
                    Description = "Software development related content",
                }
            );
    }

    private static void SeedTopics(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Topic>()
            .HasData(
                new Topic(
                    name: "Programming",
                    slug: "programming",
                    description: "Programming related content"
                )
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                }
            );
    }

    private static void SeedBibliographyItems(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<BibliographyItem>()
            .HasData(
                new BibliographyItem
                {
                    Id = Guid.NewGuid(),
                    Title = "Clean Code",
                    Author = "Robert C. Martin",
                    Year = 2008,
                    Genre = "Software Development",
                    IsRead = true,
                    CreatedAt = DateTime.UtcNow,
                }
            );
    }
}
