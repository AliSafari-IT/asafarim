namespace ASafariM.Domain.Entities
{
    public class UserPrivacyPreference
    {
        public Guid UserId { get; set; }

        public Guid PrivacyPreferenceId { get; set; }
        public User? User { get; set; }

        public PrivacyPreference? PrivacyPreference { get; set; }
    }
}
