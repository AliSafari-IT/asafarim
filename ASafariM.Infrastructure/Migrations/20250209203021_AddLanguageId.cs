using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLanguageId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase().Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "AccessibilityPreferences",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        EnableHighContrastMode = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        EnableScreenReaderSupport = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        TextScalingFactor = table.Column<int>(type: "int", nullable: false),
                        Name = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Value = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_AccessibilityPreferences", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Attachment",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Url = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        FileName = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Description = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Type = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Size = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        CreatedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        UpdatedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        DeletedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Attachment", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Category",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Name = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Description = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Category", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Comment",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Text = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        CreatedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        UpdatedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        DeletedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        DeletedMessage = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Comment", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Countries",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        IsoCode = table
                            .Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsoCode3 = table
                            .Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Name = table
                            .Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Capital = table
                            .Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        NativeName = table
                            .Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        PhoneCode = table
                            .Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Countries", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Currencies",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Code = table
                            .Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Name = table
                            .Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Symbol = table
                            .Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        DecimalPlaces = table.Column<int>(type: "int", nullable: false),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Currencies", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "DateFormats",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Format = table
                            .Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        DisplayName = table
                            .Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Example = table
                            .Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_DateFormats", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "FileFormats",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Extension = table
                            .Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Name = table
                            .Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        MimeType = table
                            .Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Description = table
                            .Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        SupportsEditing = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        SupportsAnnotations = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        MaxSizeInMB = table.Column<int>(type: "int", nullable: false),
                        IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_FileFormats", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "LanguagePreferences",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Language = table.Column<int>(type: "int", nullable: false),
                        Name = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Value = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_LanguagePreferences", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Link",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Url = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Name = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Description = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        CreatedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        UpdatedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        DeletedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Link", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "NotificationPreferences",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        ReceiveEmailNotifications = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        ReceiveSmsNotifications = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        IsSubscribedToNewsletter = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        NotificationFrequencyInHours = table.Column<int>(
                            type: "int",
                            nullable: false
                        ),
                        AllowMarketingEmails = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        Name = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Value = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_NotificationPreferences", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "PaginationSettings",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        ItemsPerPage = table.Column<int>(type: "int", nullable: false),
                        ShowPageNumbers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        ShowFirstLastButtons = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        VisiblePageRange = table.Column<int>(type: "int", nullable: false),
                        EnableInfiniteScroll = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        ShowItemsCount = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        ShowPageSizeSelector = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        PageSizeOptions = table
                            .Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_PaginationSettings", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "PrivacyPreferences",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        IsProfilePublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        AllowSearchByEmail = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        EnableTwoFactorAuthentication = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        AllowDataSharing = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_PrivacyPreferences", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Roles",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Name = table
                            .Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Description = table
                            .Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        CreatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        UpdatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Roles", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "SitemapItems",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PageName = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Description = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Slug = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        AccessByRole = table.Column<int>(type: "int", nullable: false),
                        ParentId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        Order = table.Column<int>(type: "int", nullable: false),
                        Icon = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsExternalLink = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        ExternalLink = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsHidden = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsDisabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        CreatedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        DeletedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        Version = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsPublished = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        PublishedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        PublishedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        UnpublishBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        UnpublishDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        IsUnpublished = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsDraft = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsArchived = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        ArchivedBy = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        ArchivedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        ParentItemId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        Url = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        ChangeFrequency = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Priority = table.Column<double>(type: "double", nullable: false),
                        SitemapItemId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_SitemapItems", x => x.Id);
                        table.ForeignKey(
                            name: "FK_SitemapItems_SitemapItems_ParentItemId",
                            column: x => x.ParentItemId,
                            principalTable: "SitemapItems",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Restrict
                        );
                        table.ForeignKey(
                            name: "FK_SitemapItems_SitemapItems_SitemapItemId",
                            column: x => x.SitemapItemId,
                            principalTable: "SitemapItems",
                            principalColumn: "Id"
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Tags",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Name = table
                            .Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Description = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Slug = table
                            .Column<string>(type: "varchar(255)", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Tags", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "TimeZones",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Name = table
                            .Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        StandardName = table
                            .Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        UtcOffset = table
                            .Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        UsesDaylightSaving = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        DstOffset = table
                            .Column<string>(type: "varchar(6)", maxLength: 6, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_TimeZones", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Topics",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Name = table
                            .Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Description = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Slug = table
                            .Column<string>(type: "varchar(255)", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        ParentTopicId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        CreatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        UpdatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Topics", x => x.Id);
                        table.ForeignKey(
                            name: "FK_Topics_Topics_ParentTopicId",
                            column: x => x.ParentTopicId,
                            principalTable: "Topics",
                            principalColumn: "Id"
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "ThemePreferences",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        IsDarkTheme = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        FontSize = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        LanguageId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        AccentColor = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        BackgroundColor = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        PrimaryColor = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        SecondaryColor = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        TertiaryColor = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        DarkModeTextColor = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        LightModeTextColor = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        DarkModeBackgroundColor = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        LightModeBackgroundColor = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        DarkModePrimaryColor = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        LightModePrimaryColor = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        CreatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        UpdatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        IsDarkModeEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsHighContrastModeEnabled = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        IsReducedMotionEnabled = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_ThemePreferences", x => x.Id);
                        table.ForeignKey(
                            name: "FK_ThemePreferences_LanguagePreferences_LanguageId",
                            column: x => x.LanguageId,
                            principalTable: "LanguagePreferences",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "MiscellaneousPreferences",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        FileFormatId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PaginationSettingsId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        EnableAutoSave = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        EnableRealTimeUpdates = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        DefaultDashboardView = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        ShowActivityTimeline = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: false
                        ),
                        Name = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Value = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_MiscellaneousPreferences", x => x.Id);
                        table.ForeignKey(
                            name: "FK_MiscellaneousPreferences_FileFormats_FileFormatId",
                            column: x => x.FileFormatId,
                            principalTable: "FileFormats",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Restrict
                        );
                        table.ForeignKey(
                            name: "FK_MiscellaneousPreferences_PaginationSettings_PaginationSettin~",
                            column: x => x.PaginationSettingsId,
                            principalTable: "PaginationSettings",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Restrict
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "GeographicalPreferences",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        CountryId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        CurrencyId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        TimeZoneId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        DateFormatId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        Name = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Value = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_GeographicalPreferences", x => x.Id);
                        table.ForeignKey(
                            name: "FK_GeographicalPreferences_Countries_CountryId",
                            column: x => x.CountryId,
                            principalTable: "Countries",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Restrict
                        );
                        table.ForeignKey(
                            name: "FK_GeographicalPreferences_Currencies_CurrencyId",
                            column: x => x.CurrencyId,
                            principalTable: "Currencies",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Restrict
                        );
                        table.ForeignKey(
                            name: "FK_GeographicalPreferences_DateFormats_DateFormatId",
                            column: x => x.DateFormatId,
                            principalTable: "DateFormats",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Restrict
                        );
                        table.ForeignKey(
                            name: "FK_GeographicalPreferences_TimeZones_TimeZoneId",
                            column: x => x.TimeZoneId,
                            principalTable: "TimeZones",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Restrict
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "SitemapItemTopic",
                    columns: table => new
                    {
                        SitemapItemId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        TopicsId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey(
                            "PK_SitemapItemTopic",
                            x => new { x.SitemapItemId, x.TopicsId }
                        );
                        table.ForeignKey(
                            name: "FK_SitemapItemTopic_SitemapItems_SitemapItemId",
                            column: x => x.SitemapItemId,
                            principalTable: "SitemapItems",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_SitemapItemTopic_Topics_TopicsId",
                            column: x => x.TopicsId,
                            principalTable: "Topics",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "AttachmentPost",
                    columns: table => new
                    {
                        AttachmentsId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PostsId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey(
                            "PK_AttachmentPost",
                            x => new { x.AttachmentsId, x.PostsId }
                        );
                        table.ForeignKey(
                            name: "FK_AttachmentPost_Attachment_AttachmentsId",
                            column: x => x.AttachmentsId,
                            principalTable: "Attachment",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "CategoryPost",
                    columns: table => new
                    {
                        CategoriesId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PostsId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_CategoryPost", x => new { x.CategoriesId, x.PostsId });
                        table.ForeignKey(
                            name: "FK_CategoryPost_Category_CategoriesId",
                            column: x => x.CategoriesId,
                            principalTable: "Category",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "CommentPost",
                    columns: table => new
                    {
                        CommentsId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PostsId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_CommentPost", x => new { x.CommentsId, x.PostsId });
                        table.ForeignKey(
                            name: "FK_CommentPost_Comment_CommentsId",
                            column: x => x.CommentsId,
                            principalTable: "Comment",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "LinkPost",
                    columns: table => new
                    {
                        LinksId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PostsId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_LinkPost", x => new { x.LinksId, x.PostsId });
                        table.ForeignKey(
                            name: "FK_LinkPost_Link_LinksId",
                            column: x => x.LinksId,
                            principalTable: "Link",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "MarkdownFileHistories",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        MarkdownFileId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        ContentSnapshot = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        ChangedByUserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        ChangedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_MarkdownFileHistories", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "MarkdownFiles",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Title = table
                            .Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Content = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Visibility = table.Column<string>(type: "nvarchar(50)", nullable: false),
                        AuthorName = table
                            .Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        UpdatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        ProjectId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        ParentMdFileId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        Path = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_MarkdownFiles", x => x.Id);
                        table.ForeignKey(
                            name: "FK_MarkdownFiles_MarkdownFiles_ParentMdFileId",
                            column: x => x.ParentMdFileId,
                            principalTable: "MarkdownFiles",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.SetNull
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "MarkdownFileUsers",
                    columns: table => new
                    {
                        MarkdownFileId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        UserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        DateCollaborated = table.Column<DateTime>(
                            type: "datetime(6)",
                            nullable: false
                        ),
                        CollaborationStopDate = table.Column<DateTime>(
                            type: "datetime(6)",
                            nullable: true
                        ),
                        CollaborationRole = table.Column<int>(type: "int", nullable: false),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey(
                            "PK_MarkdownFileUsers",
                            x => new { x.MarkdownFileId, x.UserId }
                        );
                        table.ForeignKey(
                            name: "FK_MarkdownFileUsers_MarkdownFiles_MarkdownFileId",
                            column: x => x.MarkdownFileId,
                            principalTable: "MarkdownFiles",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "PostAttachment",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PostId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        AttachmentId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_PostAttachment", x => x.Id);
                        table.ForeignKey(
                            name: "FK_PostAttachment_MarkdownFiles_AttachmentId",
                            column: x => x.AttachmentId,
                            principalTable: "MarkdownFiles",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "PostCategory",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PostId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        CategoryId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_PostCategory", x => x.Id);
                        table.ForeignKey(
                            name: "FK_PostCategory_Category_CategoryId",
                            column: x => x.CategoryId,
                            principalTable: "Category",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "PostCollaborator",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PostId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        CollaboratorId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_PostCollaborator", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "PostComment",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PostId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Comment = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CommenterId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        CommentedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_PostComment", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "PostLink",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PostId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        LinkId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_PostLink", x => x.Id);
                        table.ForeignKey(
                            name: "FK_PostLink_MarkdownFiles_LinkId",
                            column: x => x.LinkId,
                            principalTable: "MarkdownFiles",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "PostRelatedPost",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PostId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_PostRelatedPost", x => x.Id);
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Posts",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Title = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Content = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Summary = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Excerpt = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Slug = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        PublishedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        AuthorId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        ViewCount = table.Column<int>(type: "int", nullable: false),
                        CommentCount = table.Column<int>(type: "int", nullable: false),
                        IsPublished = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsDraft = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        CreatedBy = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        UpdatedBy = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        DeletedBy = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Status = table.Column<int>(type: "int", nullable: false),
                        StatusMessage = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        StatusColor = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        StatusIcon = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        StatusTooltip = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsArchived = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        AudioUrls = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        VideoUrls = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        ImageUrls = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        MetaDescription = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Description = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        PostId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Posts", x => x.Id);
                        table.ForeignKey(
                            name: "FK_Posts_Posts_PostId",
                            column: x => x.PostId,
                            principalTable: "Posts",
                            principalColumn: "Id"
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "PostTag",
                    columns: table => new
                    {
                        PostsId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        TagsId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_PostTag", x => new { x.PostsId, x.TagsId });
                        table.ForeignKey(
                            name: "FK_PostTag_Posts_PostsId",
                            column: x => x.PostsId,
                            principalTable: "Posts",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_PostTag_Tags_TagsId",
                            column: x => x.TagsId,
                            principalTable: "Tags",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "PostTags",
                    columns: table => new
                    {
                        PostId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        TagId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_PostTags", x => new { x.PostId, x.TagId });
                        table.ForeignKey(
                            name: "FK_PostTags_Posts_PostId",
                            column: x => x.PostId,
                            principalTable: "Posts",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_PostTags_Tags_TagId",
                            column: x => x.TagId,
                            principalTable: "Tags",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Users",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Email = table
                            .Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        ProfilePicture = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        LastLogin = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        FailedLoginAttempts = table.Column<int>(type: "int", nullable: false),
                        IsLockedOut = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        PenName = table
                            .Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Website = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Biography = table
                            .Column<string>(type: "varchar(1500)", maxLength: 1500, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Name = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        FirstName = table
                            .Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        LastName = table
                            .Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        LinkUrl = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        UpdatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        CreatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: true),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        DeletedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true),
                        LockoutEnd = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        PhoneNumberConfirmed = table.Column<bool>(
                            type: "tinyint(1)",
                            nullable: true
                        ),
                        PostId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        UserName = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        NormalizedUserName = table
                            .Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        NormalizedEmail = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        PasswordHash = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        SecurityStamp = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        ConcurrencyStamp = table
                            .Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        PhoneNumber = table
                            .Column<string>(type: "longtext", nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Users", x => x.Id);
                        table.ForeignKey(
                            name: "FK_Users_Posts_PostId",
                            column: x => x.PostId,
                            principalTable: "Posts",
                            principalColumn: "Id"
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Projects",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        Name = table.Column<string>(
                            type: "nvarchar(120)",
                            maxLength: 120,
                            nullable: false
                        ),
                        Description = table.Column<string>(
                            type: "nvarchar(500)",
                            maxLength: 500,
                            nullable: false
                        ),
                        Visibility = table.Column<string>(type: "nvarchar(50)", nullable: false),
                        OwnerId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        Status = table.Column<int>(type: "int", nullable: false),
                        Budget = table.Column<double>(type: "double", nullable: true),
                        ActualBudget = table.Column<double>(type: "double", nullable: true),
                        RemainingBudget = table.Column<double>(type: "double", nullable: true),
                        IsCancelled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsCancelledby = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        IsCancelledAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        IsCompleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsCompletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        IsCompletedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        IsPaused = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsPausedTo = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        IsExtended = table.Column<bool>(type: "tinyint(1)", nullable: false),
                        IsExtendedTo = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        MarkdownFileId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                        UserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Projects", x => x.Id);
                        table.ForeignKey(
                            name: "FK_Projects_MarkdownFiles_MarkdownFileId",
                            column: x => x.MarkdownFileId,
                            principalTable: "MarkdownFiles",
                            principalColumn: "Id"
                        );
                        table.ForeignKey(
                            name: "FK_Projects_Users_OwnerId",
                            column: x => x.OwnerId,
                            principalTable: "Users",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Restrict
                        );
                        table.ForeignKey(
                            name: "FK_Projects_Users_UserId",
                            column: x => x.UserId,
                            principalTable: "Users",
                            principalColumn: "Id"
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "UserAccessibilityPreferences",
                    columns: table => new
                    {
                        UserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        AccessibilityPreferenceId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey(
                            "PK_UserAccessibilityPreferences",
                            x => new { x.UserId, x.AccessibilityPreferenceId }
                        );
                        table.ForeignKey(
                            name: "FK_UserAccessibilityPreferences_AccessibilityPreferences_Access~",
                            column: x => x.AccessibilityPreferenceId,
                            principalTable: "AccessibilityPreferences",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_UserAccessibilityPreferences_Users_UserId",
                            column: x => x.UserId,
                            principalTable: "Users",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "UserGeographicalPreferences",
                    columns: table => new
                    {
                        UserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        GeographicalPreferenceId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey(
                            "PK_UserGeographicalPreferences",
                            x => new { x.UserId, x.GeographicalPreferenceId }
                        );
                        table.ForeignKey(
                            name: "FK_UserGeographicalPreferences_GeographicalPreferences_Geograph~",
                            column: x => x.GeographicalPreferenceId,
                            principalTable: "GeographicalPreferences",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_UserGeographicalPreferences_Users_UserId",
                            column: x => x.UserId,
                            principalTable: "Users",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "UserLanguagePreferences",
                    columns: table => new
                    {
                        UserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        LanguagePreferenceId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey(
                            "PK_UserLanguagePreferences",
                            x => new { x.UserId, x.LanguagePreferenceId }
                        );
                        table.ForeignKey(
                            name: "FK_UserLanguagePreferences_LanguagePreferences_LanguagePreferen~",
                            column: x => x.LanguagePreferenceId,
                            principalTable: "LanguagePreferences",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_UserLanguagePreferences_Users_UserId",
                            column: x => x.UserId,
                            principalTable: "Users",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "UserMiscellaneousPreferences",
                    columns: table => new
                    {
                        UserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        MiscellaneousPreferenceId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey(
                            "PK_UserMiscellaneousPreferences",
                            x => new { x.UserId, x.MiscellaneousPreferenceId }
                        );
                        table.ForeignKey(
                            name: "FK_UserMiscellaneousPreferences_MiscellaneousPreferences_Miscel~",
                            column: x => x.MiscellaneousPreferenceId,
                            principalTable: "MiscellaneousPreferences",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_UserMiscellaneousPreferences_Users_UserId",
                            column: x => x.UserId,
                            principalTable: "Users",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "UserNotificationPreferences",
                    columns: table => new
                    {
                        UserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        NotificationPreferenceId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey(
                            "PK_UserNotificationPreferences",
                            x => new { x.UserId, x.NotificationPreferenceId }
                        );
                        table.ForeignKey(
                            name: "FK_UserNotificationPreferences_NotificationPreferences_Notifica~",
                            column: x => x.NotificationPreferenceId,
                            principalTable: "NotificationPreferences",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_UserNotificationPreferences_Users_UserId",
                            column: x => x.UserId,
                            principalTable: "Users",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "UserPrivacyPreferences",
                    columns: table => new
                    {
                        UserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        PrivacyPreferenceId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey(
                            "PK_UserPrivacyPreferences",
                            x => new { x.UserId, x.PrivacyPreferenceId }
                        );
                        table.ForeignKey(
                            name: "FK_UserPrivacyPreferences_PrivacyPreferences_PrivacyPreferenceId",
                            column: x => x.PrivacyPreferenceId,
                            principalTable: "PrivacyPreferences",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_UserPrivacyPreferences_Users_UserId",
                            column: x => x.UserId,
                            principalTable: "Users",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "UserRoles",
                    columns: table => new
                    {
                        UserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        RoleId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                        table.ForeignKey(
                            name: "FK_UserRoles_Roles_RoleId",
                            column: x => x.RoleId,
                            principalTable: "Roles",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_UserRoles_Users_UserId",
                            column: x => x.UserId,
                            principalTable: "Users",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "UserThemePreferences",
                    columns: table => new
                    {
                        UserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        ThemePreferenceId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey(
                            "PK_UserThemePreferences",
                            x => new { x.UserId, x.ThemePreferenceId }
                        );
                        table.ForeignKey(
                            name: "FK_UserThemePreferences_ThemePreferences_ThemePreferenceId",
                            column: x => x.ThemePreferenceId,
                            principalTable: "ThemePreferences",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_UserThemePreferences_Users_UserId",
                            column: x => x.UserId,
                            principalTable: "Users",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "ProgressHistories",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        ProjectId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        ProgressPercentage = table.Column<int>(type: "int", nullable: false),
                        Description = table
                            .Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Notes = table
                            .Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        PlannedBudget = table.Column<double>(type: "double", nullable: true),
                        ActualCost = table.Column<double>(type: "double", nullable: true),
                        BudgetVariance = table.Column<double>(type: "double", nullable: true),
                        PlannedStartDate = table.Column<DateTime>(
                            type: "datetime(6)",
                            nullable: true
                        ),
                        ActualStartDate = table.Column<DateTime>(
                            type: "datetime(6)",
                            nullable: true
                        ),
                        PlannedEndDate = table.Column<DateTime>(
                            type: "datetime(6)",
                            nullable: true
                        ),
                        ActualEndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        TimeVarianceInDays = table.Column<int>(type: "int", nullable: true),
                        TotalMilestones = table.Column<int>(type: "int", nullable: false),
                        CompletedMilestones = table.Column<int>(type: "int", nullable: false),
                        CurrentStatus = table.Column<int>(type: "int", nullable: false),
                        StatusReason = table
                            .Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        RiskLevel = table
                            .Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        RiskDescription = table
                            .Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        MitigationPlan = table
                            .Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        CreatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        UpdatedBy = table.Column<Guid>(
                            type: "char(36)",
                            nullable: true,
                            collation: "ascii_general_ci"
                        ),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_ProgressHistories", x => x.Id);
                        table.ForeignKey(
                            name: "FK_ProgressHistories_Projects_ProjectId",
                            column: x => x.ProjectId,
                            principalTable: "Projects",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "ProjectMembers",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        ProjectId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        UserId = table.Column<Guid>(
                            type: "char(36)",
                            nullable: false,
                            collation: "ascii_general_ci"
                        ),
                        ProjectMemberType = table.Column<int>(type: "int", nullable: false),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_ProjectMembers", x => x.Id);
                        table.ForeignKey(
                            name: "FK_ProjectMembers_Projects_ProjectId",
                            column: x => x.ProjectId,
                            principalTable: "Projects",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_ProjectMembers_Users_UserId",
                            column: x => x.UserId,
                            principalTable: "Users",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    }
                )
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[]
                {
                    "Id",
                    "Capital",
                    "CreatedAt",
                    "IsActive",
                    "IsoCode",
                    "IsoCode3",
                    "Name",
                    "NativeName",
                    "PhoneCode",
                    "UpdatedAt",
                },
                values: new object[,]
                {
                    {
                        new Guid("03e61219-a0b5-4a81-a405-8ea9748f2da7"),
                        "Bern",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9180),
                        true,
                        "CH",
                        "CHE",
                        "Switzerland",
                        "Schweiz",
                        "+41",
                        null,
                    },
                    {
                        new Guid("22866fec-7869-4527-894d-b89a1448272c"),
                        "Madrid",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9176),
                        true,
                        "ES",
                        "ESP",
                        "Spain",
                        "España",
                        "+34",
                        null,
                    },
                    {
                        new Guid("3a7dcf9d-7933-4062-aa2f-aa15fbcb92d4"),
                        "Vienna",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9183),
                        true,
                        "AT",
                        "AUT",
                        "Austria",
                        "Österreich",
                        "+43",
                        null,
                    },
                    {
                        new Guid("656f5550-0748-4050-9394-186bd9bd235d"),
                        "Berlin",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9160),
                        true,
                        "DE",
                        "DEU",
                        "Germany",
                        "Deutschland",
                        "+49",
                        null,
                    },
                    {
                        new Guid("897278ff-33d0-43d6-9deb-0d2be5be11f5"),
                        "Rome",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9169),
                        true,
                        "IT",
                        "ITA",
                        "Italy",
                        "Italia",
                        "+39",
                        null,
                    },
                    {
                        new Guid("8c693d95-ed80-4a13-a86d-aa536f6246aa"),
                        "Luxembourg",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9186),
                        true,
                        "LU",
                        "LUX",
                        "Luxembourg",
                        "Luxembourg",
                        "+352",
                        null,
                    },
                    {
                        new Guid("bc1f9fe8-792b-428b-8364-cf20753543f2"),
                        "Amsterdam",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9163),
                        true,
                        "NL",
                        "NLD",
                        "Netherlands",
                        "Nederland",
                        "+31",
                        null,
                    },
                    {
                        new Guid("c6519c22-adfb-47c5-95b0-ffdb6d2e2c5e"),
                        "Paris",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9156),
                        true,
                        "FR",
                        "FRA",
                        "France",
                        "France",
                        "+33",
                        null,
                    },
                    {
                        new Guid("f1cd3c55-4da6-45ef-b205-6ba755c2abbb"),
                        "London",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9166),
                        true,
                        "GB",
                        "GBR",
                        "United Kingdom",
                        "United Kingdom",
                        "+44",
                        null,
                    },
                    {
                        new Guid("f4acc52d-5a96-4e33-bc0a-9b8b2089bd73"),
                        "Brussels",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(8615),
                        true,
                        "BE",
                        "BEL",
                        "Belgium",
                        "België",
                        "+32",
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[]
                {
                    "Id",
                    "Code",
                    "CreatedAt",
                    "DecimalPlaces",
                    "IsActive",
                    "Name",
                    "Symbol",
                    "UpdatedAt",
                },
                values: new object[,]
                {
                    {
                        new Guid("2ccccd04-7bcf-423f-a5de-319f80a7658c"),
                        "GBP",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(3596),
                        2,
                        true,
                        "British Pound",
                        "£",
                        null,
                    },
                    {
                        new Guid("3fff6867-7696-4ea5-864a-d85d0468377d"),
                        "USD",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(3587),
                        2,
                        true,
                        "US Dollar",
                        "$",
                        null,
                    },
                    {
                        new Guid("981c8174-9533-404e-95b3-f2239d35131d"),
                        "CHF",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(3642),
                        2,
                        true,
                        "Swiss Franc",
                        "Fr.",
                        null,
                    },
                    {
                        new Guid("e754874a-cb88-4bdd-9801-d6a3a8d9c2b4"),
                        "EUR",
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(2187),
                        2,
                        true,
                        "Euro",
                        "€",
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[]
                {
                    "Id",
                    "CreatedAt",
                    "DisplayName",
                    "Example",
                    "Format",
                    "IsActive",
                    "IsDefault",
                    "UpdatedAt",
                },
                values: new object[,]
                {
                    {
                        new Guid("0aa33afb-e2c6-4166-b74a-e9bdfa4b4c78"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(1366),
                        "ISO Date Format",
                        "2024-12-31",
                        "yyyy-MM-dd",
                        true,
                        false,
                        null,
                    },
                    {
                        new Guid("4e7eb8a6-6ced-4cfb-b2af-8e37bbb63e6e"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(186),
                        "Belgian/European Date Format",
                        "31/12/2024",
                        "dd/MM/yyyy",
                        true,
                        false,
                        null,
                    },
                    {
                        new Guid("a83e7b6b-2dff-4c31-8d7d-f274cb7228ab"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(1363),
                        "US Date Format",
                        "12/31/2024",
                        "MM/dd/yyyy",
                        true,
                        false,
                        null,
                    },
                    {
                        new Guid("d0e8f8f8-080d-46e4-95a2-6c072fe1ea1a"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(1356),
                        "Belgian Date Format (Dot)",
                        "31.12.2024",
                        "dd.MM.yyyy",
                        true,
                        false,
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[]
                {
                    "Id",
                    "CreatedAt",
                    "Description",
                    "Extension",
                    "IsActive",
                    "IsDefault",
                    "MaxSizeInMB",
                    "MimeType",
                    "Name",
                    "SupportsAnnotations",
                    "SupportsEditing",
                    "UpdatedAt",
                },
                values: new object[,]
                {
                    {
                        new Guid("39639cb1-5498-4662-8734-b773259b5453"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(6669),
                        "JavaScript Object Notation data file",
                        ".json",
                        true,
                        false,
                        10,
                        "application/json",
                        "JSON",
                        true,
                        false,
                        null,
                    },
                    {
                        new Guid("7831d9d1-b66d-47d6-8d30-082129fa8603"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(6672),
                        "Markdown text format",
                        ".md",
                        true,
                        false,
                        10,
                        "text/markdown",
                        "Markdown",
                        true,
                        false,
                        null,
                    },
                    {
                        new Guid("888de1b2-e650-4b1e-ac92-28dd6002d2bc"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(6623),
                        "TypeScript source code file",
                        ".ts",
                        true,
                        false,
                        10,
                        "application/typescript",
                        "TypeScript",
                        true,
                        false,
                        null,
                    },
                    {
                        new Guid("89b60708-d8be-49d1-a9fe-ccd5705f8c67"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(5023),
                        "Simple text document format",
                        ".txt",
                        true,
                        false,
                        10,
                        "text/plain",
                        "Plain Text",
                        true,
                        false,
                        null,
                    },
                    {
                        new Guid("b6d71bd8-bdd9-404b-9468-5f2af946b4f6"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(6631),
                        "TypeScript React component file",
                        ".tsx",
                        true,
                        false,
                        10,
                        "application/typescript+react",
                        "TypeScript React",
                        true,
                        false,
                        null,
                    },
                    {
                        new Guid("cfc24f1b-7b88-4fbf-abd0-3c0497521de0"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(6640),
                        "JavaScript source code file",
                        ".js",
                        true,
                        false,
                        10,
                        "application/javascript",
                        "JavaScript",
                        true,
                        false,
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[]
                {
                    "Id",
                    "CreatedAt",
                    "EnableInfiniteScroll",
                    "IsActive",
                    "IsDefault",
                    "ItemsPerPage",
                    "PageSizeOptions",
                    "ShowFirstLastButtons",
                    "ShowItemsCount",
                    "ShowPageNumbers",
                    "ShowPageSizeSelector",
                    "UpdatedAt",
                    "VisiblePageRange",
                },
                values: new object[]
                {
                    new Guid("1eb148b5-d009-4567-823b-54b0b8aaae30"),
                    new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(7636),
                    false,
                    true,
                    false,
                    10,
                    "[10,20,50,100]",
                    true,
                    true,
                    true,
                    true,
                    null,
                    5,
                }
            );

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[]
                {
                    "Id",
                    "CreatedAt",
                    "CreatedBy",
                    "Description",
                    "Name",
                    "UpdatedAt",
                    "UpdatedBy",
                },
                values: new object[,]
                {
                    {
                        new Guid("0063f531-66e4-4a97-bd03-5b06702cdee6"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(3774),
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        "Has full control over the application and can manage all aspects.",
                        "SuperAdmin",
                        null,
                        null,
                    },
                    {
                        new Guid("148ae103-c5c2-4a25-9d75-96f3f2b36e30"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(3710),
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.",
                        "Moderator",
                        null,
                        null,
                    },
                    {
                        new Guid("2e01fd0c-d264-415d-8882-9e1958fb356a"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(3770),
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        "Guest role is the least privileged role. They can only view public articles.",
                        "Guest",
                        null,
                        null,
                    },
                    {
                        new Guid("4065f3bf-a8cd-4bec-95ad-028930cd7e03"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(3772),
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.",
                        "Editor",
                        null,
                        null,
                    },
                    {
                        new Guid("55a513f4-3f3b-480d-86dd-7839e5763231"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(3767),
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.",
                        "User",
                        null,
                        null,
                    },
                    {
                        new Guid("b906b7a5-7fe9-463f-8d40-2dcb8df630d5"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(2570),
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        "Admin role has full administrative privileges, except for application management.",
                        "Admin",
                        null,
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    {
                        new Guid("132a2a2c-97d0-40e6-995c-4a9ce5576416"),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "Test Tag description 4",
                        "Test Tag name 4",
                        "test-tag-slug-4",
                        null,
                    },
                    {
                        new Guid("17dccfce-e92b-445e-acb1-839286dc4450"),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "Test Tag description 2",
                        "Test Tag name 2",
                        "test-tag-slug-2",
                        null,
                    },
                    {
                        new Guid("9e91b006-7f56-454b-aa23-62c1044cef13"),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "Test Tag description 3",
                        "Test Tag name 3",
                        "test-tag-slug-3",
                        null,
                    },
                    {
                        new Guid("afe838ba-8f0f-4d39-8789-d3f7dd0934f9"),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        "Test Tag description",
                        "Test Tag name",
                        "test-tag-slug",
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[]
                {
                    "Id",
                    "CreatedAt",
                    "DstOffset",
                    "IsActive",
                    "Name",
                    "StandardName",
                    "UpdatedAt",
                    "UsesDaylightSaving",
                    "UtcOffset",
                },
                values: new object[,]
                {
                    {
                        new Guid("515688c1-7bc8-4d21-bf1a-b17c7a94a1cc"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(4493),
                        "+02:00",
                        true,
                        "CET",
                        "Central European Time (Belgium)",
                        null,
                        true,
                        "+01:00",
                    },
                    {
                        new Guid("5970e2a2-2d20-4c2c-8ddc-38624e7452a7"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(5823),
                        "+02:00",
                        true,
                        "UTC",
                        "Coordinated Universal Time",
                        null,
                        true,
                        "+00:00",
                    },
                    {
                        new Guid("7acb42d8-754b-4c41-93d7-b613248f6b76"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(5833),
                        "+03:00",
                        true,
                        "EET",
                        "Eastern European Time",
                        null,
                        true,
                        "+02:00",
                    },
                    {
                        new Guid("9d6a8bab-fbc7-4485-a73d-5de114bfb43a"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(5817),
                        "+02:00",
                        true,
                        "CEST",
                        "Central European Summer Time",
                        null,
                        true,
                        "+02:00",
                    },
                    {
                        new Guid("9f577bd2-cab9-47a9-8b3c-9cb8f785ce45"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(5825),
                        "+01:00",
                        true,
                        "WET",
                        "Western European Time",
                        null,
                        true,
                        "+00:00",
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[]
                {
                    "Id",
                    "CreatedAt",
                    "CreatedBy",
                    "Description",
                    "Name",
                    "ParentTopicId",
                    "Slug",
                    "UpdatedAt",
                    "UpdatedBy",
                },
                values: new object[,]
                {
                    {
                        new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 900, DateTimeKind.Utc).AddTicks(2858),
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        "Test Topic description",
                        "Test Topic name",
                        null,
                        "test-topic-slug",
                        null,
                        null,
                    },
                    {
                        new Guid("7ff22c11-b4a3-41ed-9343-fda3bf013ad0"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 900, DateTimeKind.Utc).AddTicks(4413),
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        "Test Topic description 3",
                        "Test Topic name 3",
                        null,
                        "test-topic-slug-3",
                        null,
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[]
                {
                    "Id",
                    "AccessFailedCount",
                    "Biography",
                    "ConcurrencyStamp",
                    "CreatedAt",
                    "CreatedBy",
                    "DateOfBirth",
                    "DeletedAt",
                    "DeletedBy",
                    "Email",
                    "EmailConfirmed",
                    "FailedLoginAttempts",
                    "FirstName",
                    "IsActive",
                    "IsAdmin",
                    "IsDeleted",
                    "IsLockedOut",
                    "LastLogin",
                    "LastName",
                    "LinkUrl",
                    "LockoutEnabled",
                    "LockoutEnd",
                    "Name",
                    "NormalizedEmail",
                    "NormalizedUserName",
                    "PasswordHash",
                    "PenName",
                    "PhoneNumber",
                    "PhoneNumberConfirmed",
                    "PostId",
                    "ProfilePicture",
                    "SecurityStamp",
                    "TwoFactorEnabled",
                    "UpdatedAt",
                    "UpdatedBy",
                    "UserName",
                    "Website",
                },
                values: new object[,]
                {
                    {
                        new Guid("2e87a96e-c37f-4701-8269-5472fb523af8"),
                        0,
                        null,
                        "ali@asafarim.com",
                        new DateTime(2025, 2, 9, 20, 30, 20, 883, DateTimeKind.Utc).AddTicks(2660),
                        new Guid("2e87a96e-c37f-4701-8269-5472fb523af8"),
                        new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        null,
                        null,
                        "ali@asafarim.com",
                        false,
                        0,
                        "Ali R.",
                        true,
                        true,
                        false,
                        false,
                        new DateTime(2025, 2, 9, 20, 30, 20, 883, DateTimeKind.Utc).AddTicks(201),
                        "Safari",
                        null,
                        false,
                        null,
                        null,
                        "ALI@ASAFARIM.COM",
                        "ALIRZA",
                        "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G",
                        null,
                        "+123456789",
                        true,
                        null,
                        "https://asafarim.com/logoT.svg",
                        "ali@asafarim.com",
                        false,
                        new DateTime(2025, 2, 9, 20, 30, 20, 883, DateTimeKind.Utc).AddTicks(3514),
                        new Guid("2e87a96e-c37f-4701-8269-5472fb523af8"),
                        "alireza",
                        null,
                    },
                    {
                        new Guid("c0ea4656-f3a6-4da6-9e06-14251ec4f20d"),
                        0,
                        null,
                        "user@example.com",
                        new DateTime(2025, 2, 9, 20, 30, 20, 897, DateTimeKind.Utc).AddTicks(4066),
                        new Guid("2e87a96e-c37f-4701-8269-5472fb523af8"),
                        new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        null,
                        null,
                        "user@example.com",
                        false,
                        0,
                        "User",
                        true,
                        true,
                        false,
                        false,
                        new DateTime(2025, 2, 9, 20, 30, 20, 897, DateTimeKind.Utc).AddTicks(4050),
                        "Example",
                        null,
                        false,
                        null,
                        null,
                        "USER@EXAMPLE.COM",
                        "EXAMPLE_USER",
                        "K5xcN3fxatw18eLGtLLoqwTYyN7hhHzyP0MkU4yCJcdPn61r3PVK+3SHlQiMaeKq",
                        null,
                        "+123456789",
                        true,
                        null,
                        "https://asafarim.com/logoT.svg",
                        "user@example.com",
                        false,
                        new DateTime(2025, 2, 9, 20, 30, 20, 897, DateTimeKind.Utc).AddTicks(4067),
                        new Guid("2e87a96e-c37f-4701-8269-5472fb523af8"),
                        "example_user",
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[]
                {
                    "Id",
                    "CreatedAt",
                    "CreatedBy",
                    "Description",
                    "Name",
                    "ParentTopicId",
                    "Slug",
                    "UpdatedAt",
                    "UpdatedBy",
                },
                values: new object[,]
                {
                    {
                        new Guid("1230f7ef-2ad1-4874-918e-eef77d80b722"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 900, DateTimeKind.Utc).AddTicks(4422),
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        "Test Topic description 4",
                        "Test Topic name 4",
                        new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                        "test-topic-slug-4",
                        null,
                        null,
                    },
                    {
                        new Guid("9f628e1b-8dd9-49d1-a222-968206bb91c9"),
                        new DateTime(2025, 2, 9, 20, 30, 20, 900, DateTimeKind.Utc).AddTicks(4076),
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        "Test Topic description 2",
                        "Test Topic name 2",
                        new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                        "test-topic-slug-2",
                        null,
                        null,
                    },
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentPost_PostsId",
                table: "AttachmentPost",
                column: "PostsId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPost_PostsId",
                table: "CategoryPost",
                column: "PostsId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CommentPost_PostsId",
                table: "CommentPost",
                column: "PostsId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Countries_IsoCode",
                table: "Countries",
                column: "IsoCode",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_Countries_IsoCode3",
                table: "Countries",
                column: "IsoCode3",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_Code",
                table: "Currencies",
                column: "Code",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_DateFormats_Format",
                table: "DateFormats",
                column: "Format",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_FileFormats_Extension",
                table: "FileFormats",
                column: "Extension",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_FileFormats_MimeType",
                table: "FileFormats",
                column: "MimeType",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_GeographicalPreferences_CountryId",
                table: "GeographicalPreferences",
                column: "CountryId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_GeographicalPreferences_CurrencyId",
                table: "GeographicalPreferences",
                column: "CurrencyId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_GeographicalPreferences_DateFormatId",
                table: "GeographicalPreferences",
                column: "DateFormatId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_GeographicalPreferences_TimeZoneId",
                table: "GeographicalPreferences",
                column: "TimeZoneId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_LinkPost_PostsId",
                table: "LinkPost",
                column: "PostsId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownFileHistories_MarkdownFileId",
                table: "MarkdownFileHistories",
                column: "MarkdownFileId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownFiles_CreatedBy",
                table: "MarkdownFiles",
                column: "CreatedBy"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownFiles_ParentMdFileId",
                table: "MarkdownFiles",
                column: "ParentMdFileId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownFiles_ProjectId",
                table: "MarkdownFiles",
                column: "ProjectId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownFileUsers_UserId",
                table: "MarkdownFileUsers",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MiscellaneousPreferences_FileFormatId",
                table: "MiscellaneousPreferences",
                column: "FileFormatId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MiscellaneousPreferences_PaginationSettingsId",
                table: "MiscellaneousPreferences",
                column: "PaginationSettingsId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachment_AttachmentId",
                table: "PostAttachment",
                column: "AttachmentId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachment_PostId",
                table: "PostAttachment",
                column: "PostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostCategory_CategoryId",
                table: "PostCategory",
                column: "CategoryId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostCategory_PostId",
                table: "PostCategory",
                column: "PostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostCollaborator_CollaboratorId",
                table: "PostCollaborator",
                column: "CollaboratorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostCollaborator_PostId",
                table: "PostCollaborator",
                column: "PostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_CommenterId",
                table: "PostComment",
                column: "CommenterId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_PostId",
                table: "PostComment",
                column: "PostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostLink_LinkId",
                table: "PostLink",
                column: "LinkId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostLink_PostId",
                table: "PostLink",
                column: "PostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostRelatedPost_PostId",
                table: "PostRelatedPost",
                column: "PostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId"
            );

            migrationBuilder.CreateIndex(name: "IX_Posts_PostId", table: "Posts", column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagsId",
                table: "PostTag",
                column: "TagsId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ProgressHistories_ProjectId",
                table: "ProgressHistories",
                column: "ProjectId",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_ProjectId",
                table: "ProjectMembers",
                column: "ProjectId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_UserId",
                table: "ProjectMembers",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Projects_MarkdownFileId",
                table: "Projects",
                column: "MarkdownFileId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects",
                column: "OwnerId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SitemapItems_ParentItemId",
                table: "SitemapItems",
                column: "ParentItemId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SitemapItems_SitemapItemId",
                table: "SitemapItems",
                column: "SitemapItemId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SitemapItemTopic_TopicsId",
                table: "SitemapItemTopic",
                column: "TopicsId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Tags_Slug",
                table: "Tags",
                column: "Slug",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_ThemePreferences_LanguageId",
                table: "ThemePreferences",
                column: "LanguageId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_TimeZones_StandardName",
                table: "TimeZones",
                column: "StandardName",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ParentTopicId",
                table: "Topics",
                column: "ParentTopicId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Topics_Slug",
                table: "Topics",
                column: "Slug",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessibilityPreferences_AccessibilityPreferenceId",
                table: "UserAccessibilityPreferences",
                column: "AccessibilityPreferenceId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserGeographicalPreferences_GeographicalPreferenceId",
                table: "UserGeographicalPreferences",
                column: "GeographicalPreferenceId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguagePreferences_LanguagePreferenceId",
                table: "UserLanguagePreferences",
                column: "LanguagePreferenceId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserMiscellaneousPreferences_MiscellaneousPreferenceId",
                table: "UserMiscellaneousPreferences",
                column: "MiscellaneousPreferenceId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserNotificationPreferences_NotificationPreferenceId",
                table: "UserNotificationPreferences",
                column: "NotificationPreferenceId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserPrivacyPreferences_PrivacyPreferenceId",
                table: "UserPrivacyPreferences",
                column: "PrivacyPreferenceId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId"
            );

            migrationBuilder.CreateIndex(name: "IX_Users_PostId", table: "Users", column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_UserThemePreferences_ThemePreferenceId",
                table: "UserThemePreferences",
                column: "ThemePreferenceId"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_AttachmentPost_Posts_PostsId",
                table: "AttachmentPost",
                column: "PostsId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPost_Posts_PostsId",
                table: "CategoryPost",
                column: "PostsId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_CommentPost_Posts_PostsId",
                table: "CommentPost",
                column: "PostsId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_LinkPost_Posts_PostsId",
                table: "LinkPost",
                column: "PostsId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownFileHistories_MarkdownFiles_MarkdownFileId",
                table: "MarkdownFileHistories",
                column: "MarkdownFileId",
                principalTable: "MarkdownFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownFiles_Projects_ProjectId",
                table: "MarkdownFiles",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull
            );

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownFiles_Users_CreatedBy",
                table: "MarkdownFiles",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict
            );

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownFileUsers_Users_UserId",
                table: "MarkdownFileUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_PostAttachment_Posts_PostId",
                table: "PostAttachment",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_PostCategory_Posts_PostId",
                table: "PostCategory",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_PostCollaborator_Posts_PostId",
                table: "PostCollaborator",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_PostCollaborator_Users_CollaboratorId",
                table: "PostCollaborator",
                column: "CollaboratorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_Posts_PostId",
                table: "PostComment",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_Users_CommenterId",
                table: "PostComment",
                column: "CommenterId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_PostLink_Posts_PostId",
                table: "PostLink",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_PostRelatedPost_Posts_PostId",
                table: "PostRelatedPost",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_AuthorId",
                table: "Posts",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Users_Posts_PostId", table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_MarkdownFiles_MarkdownFileId",
                table: "Projects"
            );

            migrationBuilder.DropTable(name: "AttachmentPost");

            migrationBuilder.DropTable(name: "CategoryPost");

            migrationBuilder.DropTable(name: "CommentPost");

            migrationBuilder.DropTable(name: "LinkPost");

            migrationBuilder.DropTable(name: "MarkdownFileHistories");

            migrationBuilder.DropTable(name: "MarkdownFileUsers");

            migrationBuilder.DropTable(name: "PostAttachment");

            migrationBuilder.DropTable(name: "PostCategory");

            migrationBuilder.DropTable(name: "PostCollaborator");

            migrationBuilder.DropTable(name: "PostComment");

            migrationBuilder.DropTable(name: "PostLink");

            migrationBuilder.DropTable(name: "PostRelatedPost");

            migrationBuilder.DropTable(name: "PostTag");

            migrationBuilder.DropTable(name: "PostTags");

            migrationBuilder.DropTable(name: "ProgressHistories");

            migrationBuilder.DropTable(name: "ProjectMembers");

            migrationBuilder.DropTable(name: "SitemapItemTopic");

            migrationBuilder.DropTable(name: "UserAccessibilityPreferences");

            migrationBuilder.DropTable(name: "UserGeographicalPreferences");

            migrationBuilder.DropTable(name: "UserLanguagePreferences");

            migrationBuilder.DropTable(name: "UserMiscellaneousPreferences");

            migrationBuilder.DropTable(name: "UserNotificationPreferences");

            migrationBuilder.DropTable(name: "UserPrivacyPreferences");

            migrationBuilder.DropTable(name: "UserRoles");

            migrationBuilder.DropTable(name: "UserThemePreferences");

            migrationBuilder.DropTable(name: "Attachment");

            migrationBuilder.DropTable(name: "Comment");

            migrationBuilder.DropTable(name: "Link");

            migrationBuilder.DropTable(name: "Category");

            migrationBuilder.DropTable(name: "Tags");

            migrationBuilder.DropTable(name: "SitemapItems");

            migrationBuilder.DropTable(name: "Topics");

            migrationBuilder.DropTable(name: "AccessibilityPreferences");

            migrationBuilder.DropTable(name: "GeographicalPreferences");

            migrationBuilder.DropTable(name: "MiscellaneousPreferences");

            migrationBuilder.DropTable(name: "NotificationPreferences");

            migrationBuilder.DropTable(name: "PrivacyPreferences");

            migrationBuilder.DropTable(name: "Roles");

            migrationBuilder.DropTable(name: "ThemePreferences");

            migrationBuilder.DropTable(name: "Countries");

            migrationBuilder.DropTable(name: "Currencies");

            migrationBuilder.DropTable(name: "DateFormats");

            migrationBuilder.DropTable(name: "TimeZones");

            migrationBuilder.DropTable(name: "FileFormats");

            migrationBuilder.DropTable(name: "PaginationSettings");

            migrationBuilder.DropTable(name: "LanguagePreferences");

            migrationBuilder.DropTable(name: "Posts");

            migrationBuilder.DropTable(name: "MarkdownFiles");

            migrationBuilder.DropTable(name: "Projects");

            migrationBuilder.DropTable(name: "Users");
        }
    }
}
