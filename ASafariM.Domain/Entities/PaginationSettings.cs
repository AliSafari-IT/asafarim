using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class PaginationSettings
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Range(1, 100)]
        public int ItemsPerPage { get; set; } = 10;

        [Required]
        public bool ShowPageNumbers { get; set; } = true;

        [Required]
        public bool ShowFirstLastButtons { get; set; } = true;

        [Required]
        [Range(1, 10)]
        public int VisiblePageRange { get; set; } = 5; // Number of page numbers visible at once

        [Required]
        public bool EnableInfiniteScroll { get; set; } = false;

        public bool ShowItemsCount { get; set; } = true;

        public bool ShowPageSizeSelector { get; set; } = true;

        [Required]
        public string PageSizeOptions { get; set; } = "10,25,50,100"; // Available page size options

        public bool IsDefault { get; set; } = false;

        public bool IsActive { get; set; } = true;

        // Navigation properties
        public ICollection<MiscellaneousPreference>? MiscellaneousPreferences { get; set; }

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
