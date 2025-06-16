using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class NotificationPreference
    {
        [Key]
        public Guid Id { get; set; }
        public bool ReceiveEmailNotifications { get; set; }
        public bool ReceiveSmsNotifications { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public int NotificationFrequencyInHours { get; set; } = 24; // Default daily notifications
        public bool AllowMarketingEmails { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
