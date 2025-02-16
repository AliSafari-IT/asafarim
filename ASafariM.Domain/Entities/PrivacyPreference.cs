using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class PrivacyPreference
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsProfilePublic { get; set; } = false;
        public bool AllowSearchByEmail { get; set; } = false;
        public bool EnableTwoFactorAuthentication { get; set; } = true;
        public bool AllowDataSharing { get; set; } = false;

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
