namespace ASafariM.Domain.Entities
{
    public class UserNotificationPreference
    {
        public Guid UserId { get; set; }

        public Guid NotificationPreferenceId { get; set; }
        public User? User { get; set; }

        public NotificationPreference? NotificationPreference { get; set; }
    }
}
