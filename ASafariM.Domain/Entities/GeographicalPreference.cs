using System;
using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class GeographicalPreference : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Value { get; set; } = string.Empty;

        // ✅ Country Relationship
        [Required]
        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; } = null!;

        // ✅ Currency Relationship
        [Required]
        public Guid CurrencyId { get; set; }
        public virtual Currency Currency { get; set; } = null!;

        // ✅ TimeZone Relationship
        [Required]
        public Guid TimeZoneId { get; set; }
        public virtual TimeZone TimeZone { get; set; } = null!;

        // ✅ DateFormat Relationship
        [Required]
        public Guid DateFormatId { get; set; }
        public virtual DateFormat DateFormat { get; set; } = null!;

        // ✅ Constructor
        public GeographicalPreference(
            string name,
            string value,
            Guid countryId,
            Guid currencyId,
            Guid timeZoneId,
            Guid dateFormatId
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null.");
            Value =
                value ?? throw new ArgumentNullException(nameof(value), "Value cannot be null.");
            CountryId = countryId;
            CurrencyId = currencyId;
            TimeZoneId = timeZoneId;
            DateFormatId = dateFormatId;
        }

        // ✅ Update Method
        public void UpdatePreference(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Value cannot be empty.", nameof(value));

            Name = name;
            Value = value;
            UpdatedAt = DateTime.UtcNow;
        }

        // ✅ Display Details
        public void DisplayPreferenceDetails()
        {
            Console.WriteLine($"Geographical Preference ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Value: {Value}");
            Console.WriteLine($"Country ID: {CountryId}");
            Console.WriteLine($"Currency ID: {CurrencyId}");
            Console.WriteLine($"TimeZone ID: {TimeZoneId}");
            Console.WriteLine($"DateFormat ID: {DateFormatId}");
            Console.WriteLine($"Created At: {CreatedAt}");
            Console.WriteLine($"Updated At: {UpdatedAt?.ToString() ?? "Never"}");
        }
    }
}
