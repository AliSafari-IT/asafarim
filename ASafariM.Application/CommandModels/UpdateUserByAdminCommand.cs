using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;

namespace ASafariM.Application.CommandModels
{
    public class UpdateUserByAdminCommand
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public string? UserName { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public bool? IsAdmin { get; set; }

        public string? Biography { get; set; }

        public string? Remark { get; set; }

        public string? ProfilePicture { get; set; }

        public string? Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public ThemePreference? ThemePreference { get; set; }
        public GeographicalPreference? GeographicalPreference { get; set; }
        public NotificationPreference? NotificationPreference { get; set; }
        public LanguagePreference? LanguagePreference { get; set; }
        public PrivacyPreference? PrivacyPreference { get; set; }
        public AccessibilityPreference? AccessibilityPreference { get; set; }
        public MiscellaneousPreference? MiscellaneousPreference { get; set; }
        public IEnumerable<UserRoleDto>? Roles { get; set; }
        public bool? IsSuperAdmin { get; set; }
        public bool? IsEditor { get; set; }
        public bool? IsModerator { get; set; }
        public bool? IsStandardUser { get; set; }
        public bool? IsBannedByAdmin { get; set; }
        public bool? IsBlocked { get; set; }
        public bool? IsVerified { get; set; }
        public bool? IsPending { get; set; }
        public bool? IsGuest { get; set; }
        public bool? IsUser { get; set; }
        public bool? IsLockedOut { get; set; }
        public bool? IsUserActive { get; set; }
        public bool? IsUserInactive { get; set; }
        public bool? IsUserPending { get; set; }
        public bool? IsUserDeleted { get; set; }
        public bool? IsUserLockedOut { get; set; }
        public bool? IsUserLockedOutByAdmin { get; set; }
        
    }
}
