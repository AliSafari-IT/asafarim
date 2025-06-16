namespace ASafariM.Domain.Entities
{
    public class UserLanguagePreference
    {
        public Guid UserId { get; set; }

        public Guid LanguagePreferenceId { get; set; }
        public User? User { get; set; }

        public LanguagePreference? LanguagePreference { get; set; }
    }
}
