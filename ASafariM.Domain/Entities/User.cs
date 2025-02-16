using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required, EmailAddress]
        public override string Email { get; set; } = string.Empty;
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
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? ProfilePicture { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public DateTime? LastLogin { get; set; }
        public int FailedLoginAttempts { get; set; } = 0;
        public bool IsLockedOut { get; set; } = false;

        // Author-specific properties
        [MaxLength(50)]
        public string? PenName { get; set; }

        [Url]
        public string? Website { get; set; }

        [MaxLength(1500)]
        public string? Biography { get; set; }

        // Navigation properties
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
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? LinkUrl { get; set; }
        public Guid? UpdatedBy { get; set; }
        public Guid CreatedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LockoutEnd { get; set; } = null;
        public string? SecurityStamp { get; set; } = Guid.NewGuid().ToString();
        public string? ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
        public bool? PhoneNumberConfirmed { get; set; } 
        public string? PhoneNumber { get; set; } = null;
        public bool? EmailConfirmed { get; set; } = false;
        public bool? TwoFactorEnabled { get; set; } = false;
        public string? ForgotPasswordToken { get; set; }
        public DateTime? ForgotPasswordTokenExpiration { get; set; }
        public DateTime? PasswordResetToken { get; set; }
        public DateTime? ReactivationRequestedAt { get; set; }
        public DateTime? PasswordResetTokenExpiration { get; set; }
        public string? ReactivationReason { get; set; } = null;
        bool? IDeletable.IsDeleted 
        { 
            get => IsDeleted;
            set => IsDeleted = value ?? false;
        }
    }
}
