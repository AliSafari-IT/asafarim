using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASafariM.Domain.Enums;

namespace ASafariM.Domain.Entities
{
    public class MarkdownFile
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(255)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        // Visibility can be Public or MembersOnly
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public VisibilityEnum Visibility { get; set; } = VisibilityEnum.Public;

        // Foreign keys
        [MaxLength(100)]
        public string? AuthorName { get; set; } // Computed from User's FirstName + LastName
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }

        public Guid? ProjectId { get; set; }

        // Navigation properties
        public Project? Project { get; set; }

        public Guid? ParentMdFileId { get; set; }
        public MarkdownFile? ParentMdFile { get; set; }
        public ICollection<MarkdownFileUser>? MarkdownFileUsers { get; set; } = [];

        [NotMapped]
        public ICollection<User>? Collaborators { get; set; } = [];

        public ICollection<MarkdownFileHistory>? History { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public string Path { get; set; } = string.Empty;

        // Associated Projects (many-to-many)
        public ICollection<Project>? Projects { get; set; } = [];
    }
}
