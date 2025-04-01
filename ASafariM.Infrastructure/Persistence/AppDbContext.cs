using ASafariM.Application.Utils;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Entities.PostRelationships;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;
using Normalize = ASafariM.Application.Utils;
using TimeZone = ASafariM.Domain.Entities.TimeZone;

namespace ASafariM.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
        : base(options) 
    {
        _configuration = configuration;
    }

    // User-related sets
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    // Preference sets
    public DbSet<AccessibilityPreference> AccessibilityPreferences { get; set; }
    public DbSet<GeographicalPreference> GeographicalPreferences { get; set; }
    public DbSet<NotificationPreference> NotificationPreferences { get; set; }
    public DbSet<PrivacyPreference> PrivacyPreferences { get; set; }
    public DbSet<MiscellaneousPreference> MiscellaneousPreferences { get; set; }
    public DbSet<ThemePreference> ThemePreferences { get; set; }
    public DbSet<LanguagePreference> LanguagePreferences { get; set; }

    // Supporting preference sets
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<TimeZone> TimeZones { get; set; }
    public DbSet<DateFormat> DateFormats { get; set; }
    public DbSet<FileFormat> FileFormats { get; set; }
    public DbSet<PaginationSettings> PaginationSettings { get; set; }

    // Project-related sets
    public DbSet<Project> Projects { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Initiative> Initiatives { get; set; }
    public DbSet<ProjectMember> ProjectMembers { get; set; }
    public DbSet<ProgressHistory> ProgressHistories { get; set; }

    // Markdown-related sets
    public DbSet<MarkdownFile> MarkdownFiles { get; set; }
    public DbSet<MarkdownFileUser> MarkdownFileUsers { get; set; }
    public DbSet<MarkdownFileHistory> MarkdownFileHistories { get; set; }

    // Blog-related sets
    public DbSet<Topic> Topics { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    public DbSet<SitemapItem> SitemapItems { get; set; }

    // preferences
    public DbSet<UserAccessibilityPreference> UserAccessibilityPreferences { get; set; }
    public DbSet<UserGeographicalPreference> UserGeographicalPreferences { get; set; }
    public DbSet<UserLanguagePreference> UserLanguagePreferences { get; set; }
    public DbSet<UserMiscellaneousPreference> UserMiscellaneousPreferences { get; set; }
    public DbSet<UserNotificationPreference> UserNotificationPreferences { get; set; }
    public DbSet<UserPrivacyPreference> UserPrivacyPreferences { get; set; }
    public DbSet<UserThemePreference> UserThemePreferences { get; set; }

    public DbSet<Link> Links { get; set; }

    // Visitor tracking
    public DbSet<VisitorLog> VisitorLogs { get; set; }

    // Bibliography-related sets
    public DbSet<BibliographyItem> BibliographyItems { get; set; }

    // Portfolio-related sets
    public DbSet<Portfolio> Portfolios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            return;

        IConfiguration configuration;
        if (_configuration != null)
        {
            configuration = _configuration;
        }
        else
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        var connectionString = configuration.GetConnectionString("DefaultConnection");
        if (!string.IsNullOrEmpty(connectionString))
        {
            optionsBuilder.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString),
                options => options.EnableStringComparisonTranslations()
            );
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PostTag>().HasKey(pt => new { pt.PostId, pt.TagId });

        modelBuilder.Entity<SitemapItem>(entity =>
        {
            entity.HasKey(s => s.Id);

            // Configure self-referencing relationship
            entity
                .HasOne(s => s.Parent)
                .WithMany(s => s.Children)
                .HasForeignKey(s => s.ParentItemId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure many-to-many relationship with Topics
            entity.HasMany(s => s.Topics).WithMany();
        });

        modelBuilder.Entity<PostTopic>().HasKey(pt => new { pt.PostId, pt.TopicId });

        modelBuilder
            .Entity<PostTopic>()
            .HasOne(pt => pt.Post)
            .WithMany(p => p.PostTopics)
            .HasForeignKey(pt => pt.PostId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder
            .Entity<PostTopic>()
            .HasOne(pt => pt.Topic)
            .WithMany(t => t.PostTopics)
            .HasForeignKey(pt => pt.TopicId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Topic>().HasIndex(t => t.Slug).IsUnique();
        modelBuilder.Entity<Tag>().HasIndex(t => t.Slug).IsUnique();
        // Configure User entity
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.Id);
            entity.Property(u => u.FirstName).HasMaxLength(50).IsRequired();
            entity.Property(u => u.LastName).HasMaxLength(50).IsRequired();
            entity.Property(u => u.Email).HasMaxLength(100).IsRequired();
            entity.Property(u => u.PasswordHash).IsRequired();
            entity.Property(u => u.RefreshToken).HasMaxLength(255).IsRequired(false);
            entity.Property(u => u.RefreshTokenExpiration).IsRequired(false);
            entity.Property(u => u.LastLogin).HasColumnType("datetime(6)").IsRequired(false);
            entity.Property(u => u.IsLoggedIn).HasDefaultValue(false);
            entity.Property(u => u.NormalizedUserName).HasMaxLength(50);
            entity.Property(u => u.SecurityStamp).IsRequired();
            entity.Property(u => u.ConcurrencyStamp).IsRequired();
            entity.Property(u => u.UserName).HasMaxLength(50).IsRequired();

            // Add unique indexes
            entity.HasIndex(u => u.UserName).IsUnique();
            entity.HasIndex(u => u.Email).IsUnique();
            entity.HasIndex(u => u.NormalizedUserName).IsUnique();
            entity.HasIndex(u => u.NormalizedEmail).IsUnique();

            // One-to-Many: User → Project (as Owner)
            entity
                .HasMany(u => u.OwnedProjects)
                .WithOne(p => p.Owner)
                .HasForeignKey(p => p.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            // One-to-Many: User → MarkdownFile (as Author)
            entity
                .HasMany(u => u.AuthoredMarkdownFiles)
                .WithOne()
                .HasForeignKey(mf => mf.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // Many-to-Many: User ↔ MarkdownFile (as Collaborator)
            entity
                .HasMany(u => u.CollaboratedMarkdownFiles)
                .WithMany(mf => mf.Collaborators)
                .UsingEntity<MarkdownFileUser>();
        });

        // Configure Role entity
        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(r => r.Id);
            entity.Property(r => r.Name).HasMaxLength(50).IsRequired();
            entity.Property(r => r.Description).HasMaxLength(200);
        });

        // Configure UserRole entity (Many-to-Many: User ↔ Role)
        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(ur => new { ur.UserId, ur.RoleId });

            entity
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(p => p.Id);

            // Configure the relationship with User (Author)
            entity
                .HasOne(p => p.Author) // Assuming Post has a navigation property Author
                .WithMany(u => u.Posts) // Assuming User has a collection of Posts
                .HasForeignKey(p => p.AuthorId) // Assuming Post has a foreign key property AuthorId
                .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior as needed
        });

        modelBuilder.Entity<PostRelatedPost>().HasKey(prp => new { prp.PostId, prp.RelatedPostId }); // Composite key for the many-to-many relationship

        modelBuilder
            .Entity<PostRelatedPost>()
            .HasOne(prp => prp.Post)
            .WithMany(p => p.PostRelatedPosts)
            .HasForeignKey(prp => prp.PostId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder
            .Entity<PostRelatedPost>()
            .HasOne(prp => prp.RelatedPost)
            .WithMany()
            .HasForeignKey(prp => prp.RelatedPostId)
            .OnDelete(DeleteBehavior.Restrict);

        // Configure User Preference entities
        modelBuilder
            .Entity<UserAccessibilityPreference>()
            .HasKey(ap => new { ap.UserId, ap.AccessibilityPreferenceId });
        modelBuilder
            .Entity<UserGeographicalPreference>()
            .HasKey(ugp => new { ugp.UserId, ugp.GeographicalPreferenceId });
        modelBuilder
            .Entity<UserLanguagePreference>()
            .HasKey(ulp => new { ulp.UserId, ulp.LanguagePreferenceId });
        modelBuilder
            .Entity<UserMiscellaneousPreference>()
            .HasKey(ump => new { ump.UserId, ump.MiscellaneousPreferenceId });
        modelBuilder
            .Entity<UserNotificationPreference>()
            .HasKey(unp => new { unp.UserId, unp.NotificationPreferenceId });
        modelBuilder
            .Entity<UserPrivacyPreference>()
            .HasKey(upp => new { upp.UserId, upp.PrivacyPreferenceId });
        modelBuilder
            .Entity<UserThemePreference>()
            .HasKey(utt => new { utt.UserId, utt.ThemePreferenceId });

        // Configure Project entity
        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Name).HasMaxLength(120).IsRequired();
            entity.Property(p => p.Description).HasMaxLength(500);

            entity
                .HasMany(p => p.ProjectMembers)
                .WithOne(pm => pm.Project)
                .HasForeignKey(pm => pm.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasMany(p => p.MarkdownFiles)
                .WithOne(mf => mf.Project)
                .HasForeignKey(mf => mf.ProjectId)
                .OnDelete(DeleteBehavior.SetNull);

            entity
                .HasOne(p => p.Progress)
                .WithOne(ph => ph.Project)
                .HasForeignKey<ProgressHistory>(ph => ph.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure the relationship with Link entities
            entity
                .HasMany(p => p.Links)
                .WithOne(l => l.Project)
                .HasForeignKey(l => l.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Link>(entity =>
        {
            entity.ToTable("Links");
        });

        modelBuilder.Entity<ProjectMember>(entity =>
        {
            entity.HasKey(pm => new { pm.UserId, pm.ProjectId });

            entity
                .HasOne(pm => pm.User)
                .WithMany(u => u.ProjectMemberships)
                .HasForeignKey(pm => pm.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasOne(pm => pm.Project)
                .WithMany()
                .HasForeignKey(pm => pm.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<MarkdownFile>(entity =>
        {
            entity.HasKey(mf => mf.Id);
            entity.Property(mf => mf.Title).HasMaxLength(255).IsRequired();
            entity.Property(mf => mf.Content).IsRequired();
            entity.Property(mf => mf.AuthorName).HasMaxLength(100);

            // Configure self-referencing relationship for parent-child files
            entity
                .HasOne(mf => mf.ParentMdFile)
                .WithMany()
                .HasForeignKey(mf => mf.ParentMdFileId)
                .OnDelete(DeleteBehavior.SetNull);

            // Configure relationship with MarkdownFileHistory
            entity
                .HasMany(mf => mf.History)
                .WithOne(mfh => mfh.MarkdownFile)
                .HasForeignKey(mfh => mfh.MarkdownFileId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<MarkdownFileHistory>(entity =>
        {
            entity.HasKey(mfh => mfh.Id);
            entity.Property(mfh => mfh.ContentSnapshot).IsRequired();
            entity.Property(mfh => mfh.ChangedAt).HasColumnType("datetime(6)").IsRequired();
        });

        modelBuilder.Entity<MarkdownFileUser>(entity =>
        {
            entity.HasKey(mfu => new { mfu.MarkdownFileId, mfu.UserId });

            entity
                .HasOne(mfu => mfu.User)
                .WithMany(u => u.MarkdownFileUsers)
                .HasForeignKey(mfu => mfu.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasOne(mfu => mfu.MarkdownFile)
                .WithMany(mf => mf.MarkdownFileUsers)
                .HasForeignKey(mfu => mfu.MarkdownFileId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.IsoCode).HasMaxLength(2).IsRequired();
            entity.Property(c => c.IsoCode3).HasMaxLength(3).IsRequired();
            entity.Property(c => c.Name).HasMaxLength(100).IsRequired();
            entity.Property(c => c.NativeName).HasMaxLength(100).IsRequired();
            entity.Property(c => c.PhoneCode).HasMaxLength(10).IsRequired();
            entity.HasIndex(c => c.IsoCode).IsUnique();
            entity.HasIndex(c => c.IsoCode3).IsUnique();
        });

        modelBuilder.Entity<TimeZone>(entity =>
        {
            entity.HasKey(tz => tz.Id);
            entity.Property(tz => tz.Name).HasMaxLength(50).IsRequired();
            entity.Property(tz => tz.StandardName).HasMaxLength(50).IsRequired();
            entity.Property(tz => tz.UtcOffset).HasMaxLength(6).IsRequired();
            entity.Property(tz => tz.DstOffset).HasMaxLength(6);

            entity.HasIndex(tz => tz.StandardName).IsUnique();
        });

        modelBuilder.Entity<DateFormat>(entity =>
        {
            entity.HasKey(df => df.Id);
            entity.Property(df => df.Format).HasMaxLength(20).IsRequired();
            entity.Property(df => df.DisplayName).HasMaxLength(50).IsRequired();
            entity.Property(df => df.Example).HasMaxLength(20).IsRequired();

            entity.HasIndex(df => df.Format).IsUnique();
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Code).HasMaxLength(3).IsRequired();
            entity.Property(c => c.Name).HasMaxLength(100).IsRequired();
            entity.Property(c => c.Symbol).HasMaxLength(5).IsRequired();

            entity.HasIndex(c => c.Code).IsUnique();
        });

        modelBuilder.Entity<FileFormat>(entity =>
        {
            entity.HasKey(ff => ff.Id);
            entity.Property(ff => ff.Extension).HasMaxLength(10).IsRequired();
            entity.Property(ff => ff.Name).HasMaxLength(50).IsRequired();
            entity.Property(ff => ff.MimeType).HasMaxLength(100).IsRequired();
            entity.Property(ff => ff.Description).HasMaxLength(255);

            entity.HasIndex(ff => ff.Extension).IsUnique();
            entity.HasIndex(ff => ff.MimeType).IsUnique();
        });

        modelBuilder.Entity<PaginationSettings>(entity =>
        {
            entity.HasKey(ps => ps.Id);
            entity.Property(ps => ps.ItemsPerPage).IsRequired();
            entity.Property(ps => ps.PageSizeOptions).HasMaxLength(100).IsRequired();
        });

        modelBuilder.Entity<GeographicalPreference>(entity =>
        {
            entity.HasKey(gp => gp.Id);

            entity
                .HasOne(gp => gp.Country)
                .WithMany(c => c.GeographicalPreferences)
                .HasForeignKey(gp => gp.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(gp => gp.Currency)
                .WithMany()
                .HasForeignKey(gp => gp.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(gp => gp.TimeZone)
                .WithMany(tz => tz.GeographicalPreferences)
                .HasForeignKey(gp => gp.TimeZoneId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(gp => gp.DateFormat)
                .WithMany(df => df.GeographicalPreferences)
                .HasForeignKey(gp => gp.DateFormatId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<MiscellaneousPreference>(entity =>
        {
            entity.HasKey(mp => mp.Id);

            entity
                .HasOne(mp => mp.FileFormat)
                .WithMany(ff => ff.MiscellaneousPreferences)
                .HasForeignKey(mp => mp.FileFormatId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(mp => mp.PaginationSettings)
                .WithMany(ps => ps.MiscellaneousPreferences)
                .HasForeignKey(mp => mp.PaginationSettingsId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<AccessibilityPreference>().HasKey(ap => ap.Id);
        modelBuilder.Entity<LanguagePreference>().HasKey(lp => lp.Id);
        modelBuilder.Entity<NotificationPreference>().HasKey(np => np.Id);
        modelBuilder.Entity<PrivacyPreference>().HasKey(pp => pp.Id);
        modelBuilder.Entity<ThemePreference>().HasKey(tp => tp.Id);

        modelBuilder.Entity<ProgressHistory>(entity =>
        {
            entity.HasKey(ph => ph.Id);
            entity.Property(ph => ph.Description).HasMaxLength(500);
            entity.Property(ph => ph.Notes).HasMaxLength(1000);
            entity.Property(ph => ph.StatusReason).HasMaxLength(500);
            entity.Property(ph => ph.RiskLevel).HasMaxLength(50);
            entity.Property(ph => ph.RiskDescription).HasMaxLength(500);
            entity.Property(ph => ph.MitigationPlan).HasMaxLength(1000);
        });

        modelBuilder.Entity<ProgressHistory>().HasIndex(ph => ph.StatusReason).IsUnique();

        modelBuilder.Entity<BibliographyItem>(entity =>
        {
            entity.ToTable("BibliographyItems");

            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Author).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Genre).HasMaxLength(50);

            entity
                .HasOne(b => b.Attachment)
                .WithMany()
                .HasForeignKey(b => b.AttachmentId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
        {
            SeedFactory.SeedDatabase(modelBuilder);
        }

        base.OnModelCreating(modelBuilder);
    }
}
