using ASafariM.Domain.Entities;

namespace ASafariM.Application.DTOs
{
    public class GeographicalPreferenceDto
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public Guid CurrencyId { get; set; }
        public Guid TimeZoneId { get; set; }
        public Guid DateFormatId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
