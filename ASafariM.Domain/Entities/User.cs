using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASafariM.Domain.Common;
using ASafariM.Domain.Enums;
using ASafariM.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ASafariM.Domain.Entities
{
    public class User
        : IdentityUser<Guid>,
            IEntity,
            ITrackable,
            IDeletable,
            IHasIsActive,
            IHasDateOfBirth,
            IHasLastLogin,
            IHasFailedLoginAttempts,
            IHasIsLockedOut,
            IHasLockoutEnd,
            IHasSecurityStamp,
            IHasConcurrencyStamp,
            IHasPhoneNumber
    {
        [Key]
        public new Guid Id { get; set; }

        [Required, EmailAddress]
        public override string Email { get; set; } = string.Empty!;

        // ✅ Ensures IdentityUser demands a non-nullable bool
        public override bool PhoneNumberConfirmed { get; set; } = false;

        // ✅ Ensures IdentityUser demands DateTimeOffset? for LockoutEnd
        public override DateTimeOffset? LockoutEnd { get; set; } = null;

        // User Authentication Flags
        public bool IsLoggedIn { get; set; } = false;

        // ✅ User Role Flags
        public bool IsAdmin { get; set; } = false;
        public bool IsSuperAdmin { get; set; } = false;
        public bool IsEditor { get; set; } = false;
        public bool IsModerator { get; set; } = false;
        public bool IsStandardUser { get; set; } = false;
        public bool IsBannedByAdmin { get; set; } = false;
        public bool IsBlocked { get; set; } = false;
        public bool IsVerified { get; set; } = false;
        public bool IsPending { get; set; } = false;
        public bool IsGuest { get; set; } = true;
        public bool IsUser { get; set; } = true;

        // ✅ User Profile Information
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfilePicture { get; set; }
        public string? LinkUrl { get; set; }
        public DateTime? DateOfBirth { get; set; }

        // ✅ User Metadata
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastLogin { get; set; }
        public int FailedLoginAttempts { get; set; } = 0;
        public bool IsDeleted { get; set; } = false;
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
        public Guid? UpdatedBy { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsActive { get; set; }

        // ✅ Author-specific properties
        [MaxLength(50)]
        public string? PenName { get; set; }

        [Url]
        public string? Website { get; set; }

        [MaxLength(1500)]
        public string? Biography { get; set; }

        // ✅ Navigation Properties
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public ICollection<MarkdownFile> AuthoredMarkdownFiles { get; set; } =
            new List<MarkdownFile>();
        public ICollection<MarkdownFile> CollaboratedMarkdownFiles { get; set; } =
            new List<MarkdownFile>();
        public ICollection<Project> OwnedProjects { get; set; } = new List<Project>();
        public ICollection<Project> ManagedProjects { get; set; } = new List<Project>();
        public ICollection<ProjectMember> ProjectMemberships { get; set; } =
            new List<ProjectMember>();
        public ICollection<MarkdownFileUser> MarkdownFileUsers { get; set; } =
            new List<MarkdownFileUser>();

        // ✅ IdentityUser Properties
        public override string? SecurityStamp { get; set; } = Guid.NewGuid().ToString();
        public override string? ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
        public override string PhoneNumber { get; set; } = string.Empty!;
        public override bool EmailConfirmed { get; set; } = false;
        public override bool TwoFactorEnabled { get; set; } = false;

        // ✅ Account Recovery Fields
        public string? ForgotPasswordToken { get; set; }
        public DateTime? ForgotPasswordTokenExpiration { get; set; }
        public DateTime? PasswordResetToken { get; set; }
        public DateTime? ReactivationRequestedAt { get; set; }
        public DateTime? PasswordResetTokenExpiration { get; set; }
        public string? ReactivationReason { get; set; } = null;

        // ✅ Implements IDeletable
        bool? IDeletable.IsDeleted
        {
            get => IsDeleted;
            set => IsDeleted = value ?? false;
        }

        // ✅ Explicit Interface Implementations to Match `IHasPhoneNumber` & `IHasLockoutEnd`
        bool? IHasPhoneNumber.PhoneNumberConfirmed
        {
            get => PhoneNumberConfirmed;
            set => PhoneNumberConfirmed = value ?? false;
        }

        // ✅ Properties for refresh token management
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiration { get; set; }

        public bool IsLockedOut { get; set; } = false;
        DateTime? IHasLockoutEnd.LockoutEnd
        {
            get
            {
                if (!LockoutEnd.HasValue)
                    return null;
                return LockoutEnd.Value.UtcDateTime;
            }
            set
            {
                LockoutEnd = value.HasValue ? new DateTimeOffset(value.Value, TimeSpan.Zero) : null;
            }
        }
    }
}
