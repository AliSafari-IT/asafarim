namespace ASafariM.Domain.Entities
{
    public class UserMiscellaneousPreference
    {
        public Guid UserId { get; set; }

        public Guid MiscellaneousPreferenceId { get; set; }
        public User? User { get; set; }

        public MiscellaneousPreference? MiscellaneousPreference { get; set; }
    }
}
