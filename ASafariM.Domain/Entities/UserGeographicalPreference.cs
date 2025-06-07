namespace ASafariM.Domain.Entities
{
    public class UserGeographicalPreference
    {
        public Guid UserId { get; set; }

        public Guid GeographicalPreferenceId { get; set; }
        public User? User { get; set; }

        public GeographicalPreference? GeographicalPreference { get; set; }
    }
}
