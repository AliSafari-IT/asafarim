namespace ASafariM.Domain.Entities
{
    public class UserThemePreference
    {
        public Guid UserId { get; set; }

        public Guid ThemePreferenceId { get; set; }
        public User User { get; set; }

        public ThemePreference ThemePreference { get; set; }
    }
}   