using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASafariM.Domain.Enums;

namespace ASafariM.Domain.Entities
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(120)")]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public VisibilityEnum Visibility { get; set; } = VisibilityEnum.Private;

        // The user who created (owns) this project
        public Guid OwnerId { get; set; }
        public User Owner { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = null;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public StatusEnum Status { get; set; } = StatusEnum.InProgress;

        public double? Budget { get; set; }

        public double? ActualBudget { get; set; }

        public double? RemainingBudget { get; set; }

        public ProgressHistory? Progress { get; set; }

        // project cancelled
        public bool IsCancelled { get; set; } = false;
        public Guid? IsCancelledby { get; set; }
        public DateTime? IsCancelledAt { get; set; }

        // project completed
        public bool IsCompleted { get; set; } = false;
        public DateTime? IsCompletedAt { get; set; }
        public Guid? IsCompletedBy { get; set; }

        public bool IsPaused { get; set; } = false;
        public DateTime? IsPausedTo { get; set; }
        public bool IsExtended { get; set; } = false;
        public DateTime? IsExtendedTo { get; set; }

        // Project members (with possible roles = "Manager", "Member", etc.)
        public ICollection<ProjectMember> ProjectMembers { get; set; } = new List<ProjectMember>();

        // The project's associated MarkdownFiles (many-to-many)
        public ICollection<MarkdownFile> MarkdownFiles { get; set; } = new List<MarkdownFile>();
    }
}
