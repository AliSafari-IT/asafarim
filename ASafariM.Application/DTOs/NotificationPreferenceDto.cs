using ASafariM.Domain.Entities;

namespace ASafariM.Application.DTOs
{
    public class NotificationPreferenceDto
    {
        public bool ReceiveEmailNotifications { get; set; }
        public bool ReceiveSmsNotifications { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public int NotificationFrequencyInHours { get; set; }
        public bool AllowMarketingEmails { get; set; }

        public static implicit operator NotificationPreferenceDto?(NotificationPreference? v)
        {
            if (v == null)
                return null;
            return new NotificationPreferenceDto
            {
                ReceiveEmailNotifications = v.ReceiveEmailNotifications,
                ReceiveSmsNotifications = v.ReceiveSmsNotifications,
                IsSubscribedToNewsletter = v.IsSubscribedToNewsletter,
                NotificationFrequencyInHours = v.NotificationFrequencyInHours,
                AllowMarketingEmails = v.AllowMarketingEmails,
            };
        }
    }
}
