using System;

namespace DashboardApi.Core.Domain.Entities;

    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCompleted { get; set; }
        public decimal Budget { get; set; }
        public Guid ClientId { get; set; }
         public User Client { get; set; } 

        // Navigation properties (optional if Project has related entities)
        public Guid OwnerId { get; set; } // Assuming Project has an owner or creator
        public User Owner { get; set; }  // Reference to User entity, if applicable

        // Metadata
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateModified { get; set; } = DateTime.UtcNow;

        // Methods
        public void MarkAsCompleted()
        {
            IsCompleted = true;
            DateModified = DateTime.UtcNow;
        }

        public void UpdateProjectDetails(string title, string description, Guid clientId, Guid ownerId, DateTime? endDate, decimal budget)
        {
            Title = title;
            Description = description;
            ClientId = clientId;
            OwnerId = ownerId;
            EndDate = endDate;
            Budget = budget;
            DateModified = DateTime.UtcNow;
        }

    }
