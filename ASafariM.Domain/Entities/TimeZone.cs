using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class TimeZone
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = "Central European Time"; // Display name

        [Required]
        [StringLength(50)]
        public string StandardName { get; set; } = "CET"; // Standard abbreviation

        [Required]
        [StringLength(6)]
        public string UtcOffset { get; set; } = "+01:00"; // UTC offset in format +/-HH:mm

        public bool UsesDaylightSaving { get; set; } = true;

        [StringLength(6)]
        public string? DstOffset { get; set; } = "+02:00"; // Daylight Saving Time offset

        public bool IsActive { get; set; } = true;

        // Navigation properties
        public ICollection<GeographicalPreference>? GeographicalPreferences { get; set; }

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
