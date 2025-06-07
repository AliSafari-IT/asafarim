using ASafariM.Domain.Entities;

namespace ASafariM.Application.DTOs
{
    public class PrivacyPreferenceDto
    {
        public bool IsProfilePublic { get; set; }
        public bool AllowSearchByEmail { get; set; }
        public bool EnableTwoFactorAuthentication { get; set; }
        public bool AllowDataSharing { get; set; }

        public static implicit operator PrivacyPreferenceDto?(PrivacyPreference? v)
        {
            if (v == null)
                return null;
            return new PrivacyPreferenceDto
            {
                IsProfilePublic = v.IsProfilePublic,
                AllowSearchByEmail = v.AllowSearchByEmail,
                EnableTwoFactorAuthentication = v.EnableTwoFactorAuthentication,
                AllowDataSharing = v.AllowDataSharing,
            };
        }
    }
}
