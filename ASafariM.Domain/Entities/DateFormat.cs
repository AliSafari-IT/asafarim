using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class DateFormat
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Format { get; set; } = "dd-MM-yyyy"; // The actual format string

        [Required]
        [StringLength(50)]
        public string DisplayName { get; set; } = "European (31-12-2025)"; // User-friendly name

        [Required]
        [StringLength(20)]
        public string Example { get; set; } = "31-12-2025"; // Example date in this format

        public bool IsDefault { get; set; }

        public bool IsActive { get; set; } = true;

        // Navigation properties
        public ICollection<GeographicalPreference> GeographicalPreferences { get; set; } = new List<GeographicalPreference>();

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
