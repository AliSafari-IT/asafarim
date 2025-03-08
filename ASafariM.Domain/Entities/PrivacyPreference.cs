using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class PrivacyPreference : BaseEntity
    {
        public bool IsProfilePublic { get; set; } = false;
        public bool AllowSearchByEmail { get; set; } = false;
        public bool EnableTwoFactorAuthentication { get; set; } = true;
        public bool AllowDataSharing { get; set; } = false;
    }
}
