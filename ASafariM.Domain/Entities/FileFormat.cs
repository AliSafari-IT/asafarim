using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class FileFormat
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Extension { get; set; } = ".pdf"; // File extension (e.g., .pdf, .docx)

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = "PDF Document"; // Display name

        [Required]
        [StringLength(100)]
        public string MimeType { get; set; } = "application/pdf"; // MIME type for the format

        [StringLength(255)]
        public string? Description { get; set; } = "Portable Document Format"; // Optional description

        public bool SupportsEditing { get; set; } = false; // Whether the format supports editing

        public bool SupportsAnnotations { get; set; } = true; // Whether the format supports annotations

        public int MaxSizeInMB { get; set; } = 10; // Maximum allowed file size in MB

        public bool IsDefault { get; set; } = false;

        public bool IsActive { get; set; } = true;

        // Navigation properties
        public ICollection<MiscellaneousPreference>? MiscellaneousPreferences { get; set; }

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
