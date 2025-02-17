// Currency.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASafariM.Domain.Entities
{
    public class Currency
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(3)]
        public string Code { get; set; } = "EUR"; // ISO 4217 currency code (e.g., EUR, USD)

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = "Euro"; // Full name of the currency

        [Required]
        [StringLength(5)]
        public string Symbol { get; set; } = "€"; // Currency symbol

        public int DecimalPlaces { get; set; } = 2; // Number of decimal places typically used

        public bool IsActive { get; set; } = true;

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}