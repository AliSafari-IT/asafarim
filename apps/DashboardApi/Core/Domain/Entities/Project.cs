using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DashboardApi.Core.Domain.Entities
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsCompleted { get; set; } = false;

        public decimal Budget { get; set; } = 0;

        // Navigation properties for many-to-many relationship
        public virtual ICollection<ProjectClient> ProjectClients { get; set; } = new List<ProjectClient>();

        public virtual User? Owner { get; set; }  // Reference to Owner User

        // Metadata
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateModified { get; set; } = DateTime.UtcNow;

        // Methods
        public void MarkAsCompleted()
        {
            IsCompleted = true;
            DateModified = DateTime.UtcNow;
        }

        public void UpdateProjectDetails(string title, string? description, DateTime? endDate, decimal budget)
        {
            Title = title;
            Description = description;
            EndDate = endDate;
            Budget = budget;
            DateModified = DateTime.UtcNow;
        }
    }
}
