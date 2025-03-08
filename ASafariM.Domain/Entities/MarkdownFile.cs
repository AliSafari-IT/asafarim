using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASafariM.Domain.Common;
using ASafariM.Domain.Enums;

namespace ASafariM.Domain.Entities
{
    public class MarkdownFile : BaseEntity
    {
        [Required, MaxLength(255)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        // ✅ Visibility can be Public or MembersOnly
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public VisibilityEnum Visibility { get; set; } = VisibilityEnum.Public;

        // ✅ Foreign keys
        [MaxLength(100)]
        public string? AuthorName { get; set; } // Computed from User's FirstName + LastName

        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }

        public Guid? ProjectId { get; set; }

        // ✅ Navigation properties
        public virtual Project? Project { get; set; }

        public Guid? ParentMdFileId { get; set; }
        public virtual MarkdownFile? ParentMdFile { get; set; }
        public virtual ICollection<MarkdownFileUser> MarkdownFileUsers { get; set; } =
            new List<MarkdownFileUser>();

        [NotMapped]
        public ICollection<User>? Collaborators { get; set; } = new List<User>();

        public virtual ICollection<MarkdownFileHistory>? History { get; set; } =
            new List<MarkdownFileHistory>();

        // ✅ File Path
        [Required]
        public string Path { get; set; } = string.Empty;

        // ✅ Many-to-Many Relationship: MarkdownFile ↔ Projects
        public virtual ICollection<Project>? Projects { get; set; } = new List<Project>();

        // ✅ Constructor
        public MarkdownFile(string title, string content, string path, Guid createdBy)
        {
            Title =
                title ?? throw new ArgumentNullException(nameof(title), "Title cannot be null.");
            Content =
                content
                ?? throw new ArgumentNullException(nameof(content), "Content cannot be null.");
            Path = path ?? throw new ArgumentNullException(nameof(path), "Path cannot be null.");
            CreatedBy = createdBy;
        }

        // ✅ Update Method
        public void UpdateMarkdownFile(string title, string content, string path, Guid updatedBy)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty.", nameof(title));

            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Content cannot be empty.", nameof(content));

            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Path cannot be empty.", nameof(path));

            Title = title;
            Content = content;
            Path = path;
            UpdatedBy = updatedBy;
            UpdatedAt = DateTime.UtcNow;
        }

        // ✅ Display Method
        public void DisplayMarkdownFileDetails()
        {
            Console.WriteLine($"Markdown File ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Visibility: {Visibility}");
            Console.WriteLine($"Author Name: {AuthorName ?? "Unknown"}");
            Console.WriteLine($"Path: {Path}");
            Console.WriteLine($"Created At: {CreatedAt}");
            Console.WriteLine($"Updated At: {UpdatedAt?.ToString() ?? "Never"}");
            Console.WriteLine($"Deleted: {(IsDeleted ? "Yes" : "No")}");
            if (IsDeleted)
            {
                Console.WriteLine($"Deleted By: {DeletedBy ?? "Unknown"}");
                Console.WriteLine($"Deleted At: {DeletedAt?.ToString() ?? "Unknown"}");
                Console.WriteLine($"Deleted Message: {DeletedMessage ?? "N/A"}");
            }
        }
    }
}
