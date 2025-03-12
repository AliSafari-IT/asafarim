using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASafariM.Domain.Common;
using ASafariM.Domain.Enums;

namespace ASafariM.Domain.Entities
{
    public class Project : BaseEntity
    {
        [Required]
        [Column(TypeName = "nvarchar(120)")]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public VisibilityEnum Visibility { get; set; } = VisibilityEnum.Private;

        // ✅ The user who owns this project
        public Guid OwnerId { get; set; }
        public virtual User Owner { get; set; } = null!;

        // ✅ Project Metadata
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public StatusEnum Status { get; set; } = StatusEnum.InProgress;

        public double? Budget { get; set; }
        public double? ActualBudget { get; set; }
        public double? RemainingBudget { get; set; }

        public virtual ProgressHistory? Progress { get; set; }

        // ✅ Project State Flags
        public bool IsCancelled { get; set; } = false;
        public Guid? CancelledBy { get; set; }
        public DateTime? CancelledAt { get; set; }

        public bool IsCompleted { get; set; } = false;
        public Guid? CompletedBy { get; set; }
        public DateTime? CompletedAt { get; set; }

        public bool IsPaused { get; set; } = false;
        public DateTime? PausedUntil { get; set; }
        public bool IsExtended { get; set; } = false;
        public DateTime? ExtendedUntil { get; set; }

        // Foreign Key Relationship
        public List<Link> Links { get; set; } = new List<Link>(); // Repository links

        // ✅ Project members with roles ("Manager", "Member", etc.)
        public virtual ICollection<ProjectMember> ProjectMembers { get; set; } =
            new List<ProjectMember>();

        // ✅ Many-to-Many: Associated Markdown Files
        public virtual ICollection<MarkdownFile> MarkdownFiles { get; set; } =
            new List<MarkdownFile>();

        // ✅ Constructor
        public Project(string name, Guid ownerId)
        {
            Name =
                name
                ?? throw new ArgumentNullException(nameof(name), "Project name cannot be null.");
            OwnerId = ownerId;
        }

        // ✅ Update Method
        public void UpdateProject(string name, string description, StatusEnum status)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Project name cannot be empty.", nameof(name));

            Name = name;
            Description = description;
            Status = status;
            UpdatedAt = DateTime.UtcNow;
        }

        // ✅ Display Method
        public void DisplayProjectDetails()
        {
            Console.WriteLine($"Project ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Visibility: {Visibility}");
            Console.WriteLine($"Owner ID: {OwnerId}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine(
                $"Budget: {Budget ?? 0} | Actual: {ActualBudget ?? 0} | Remaining: {RemainingBudget ?? 0}"
            );
            Console.WriteLine($"Start Date: {StartDate?.ToShortDateString() ?? "N/A"}");
            Console.WriteLine($"End Date: {EndDate?.ToShortDateString() ?? "N/A"}");
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
