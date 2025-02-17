using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class GeographicalPreference
    {
        [Key]
        public Guid Id { get; set; }

        // Country
        public Guid CountryId { get; set; }
        public Country Country { get; set; } = null!;

        // Currency
        public Guid CurrencyId { get; set; }
        public Currency Currency { get; set; } = null!;

        // TimeZone
        public Guid TimeZoneId { get; set; }
        public TimeZone TimeZone { get; set; } = null!;

        // DateFormat
        public Guid DateFormatId { get; set; }
        public DateFormat DateFormat { get; set; } = null!;

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
