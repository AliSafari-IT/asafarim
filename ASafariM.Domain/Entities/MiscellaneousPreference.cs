using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class MiscellaneousPreference
    {
        [Key]
        public Guid Id { get; set; }

        // File Format
        public Guid FileFormatId { get; set; }
        public FileFormat FileFormat { get; set; } = null!;

        // Pagination Settings
        public Guid PaginationSettingsId { get; set; }
        public PaginationSettings PaginationSettings { get; set; } = null!;

        public bool EnableAutoSave { get; set; } = true;
        public bool EnableRealTimeUpdates { get; set; } = true;
        public string DefaultDashboardView { get; set; } = "Summary"; // e.g., "Summary", "Detailed"
        public bool ShowActivityTimeline { get; set; } = true;

        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
