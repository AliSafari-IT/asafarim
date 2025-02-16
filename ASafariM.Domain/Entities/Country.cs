using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ASafariM.Domain.Entities
{
    public class Country
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(2)]
        public string IsoCode { get; set; } = "BE"; // ISO 3166-1 alpha-2 code

        [Required]
        [StringLength(3)]
        public string IsoCode3 { get; set; } = "BEL"; // ISO 3166-1 alpha-3 code

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = "Belgium";

        [StringLength(100)]
        public string? Capital { get; set; } = "Brussels";

        [StringLength(100)]
        public string? NativeName { get; set; } = "België";

        [Required]
        [StringLength(5)]
        [RegularExpression(
            @"^\+\d{1,3}$",
            ErrorMessage = "Phone code must start with '+' followed by 1-3 digits"
        )]
        public string PhoneCode { get; set; } = "+32";

        public bool IsActive { get; set; } = true;

        // Navigation properties
        public ICollection<GeographicalPreference>? GeographicalPreferences { get; set; }

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
