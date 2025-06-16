using System;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class UserAccessibilityPreference
    {
        public Guid UserId { get; set; }
        public Guid AccessibilityPreferenceId { get; set; }
        public User? User { get; set; }
        public AccessibilityPreference? AccessibilityPreference { get; set; }
    }
}
