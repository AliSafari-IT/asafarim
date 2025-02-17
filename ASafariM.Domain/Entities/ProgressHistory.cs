using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class ProgressHistory
    {
        [Key]
        public Guid Id { get; set; }

        // Project reference
        public Guid ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        // Progress tracking
        public int ProgressPercentage { get; set; }
        public string? Description { get; set; }
        public string? Notes { get; set; }

        // Budget tracking
        public double? PlannedBudget { get; set; }
        public double? ActualCost { get; set; }
        public double? BudgetVariance { get; set; }

        // Time tracking
        public DateTime? PlannedStartDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int? TimeVarianceInDays { get; set; }

        // Milestones
        public int TotalMilestones { get; set; }
        public int CompletedMilestones { get; set; }

        // Status tracking
        public StatusEnum CurrentStatus { get; set; }
        public string? StatusReason { get; set; }

        // Risk tracking
        public string? RiskLevel { get; set; }
        public string? RiskDescription { get; set; }
        public string? MitigationPlan { get; set; }

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
