using System;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? UserName { get; set; }

        public bool IsAdmin { get; set; } = false;

        public bool IsUser { get; set; } = true;

        public string? ProfilePicture { get; set; }

        public bool? IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? LastLogin { get; set; }

        public int FailedLoginAttempts { get; set; } = 0;

        public bool IsLockedOut { get; set; } = false;
        public bool IsLoggedIn { get; set; } = false;

        [MaxLength(50)]
        public string? PenName { get; set; }

        [Url]
        public string? Website { get; set; }

        [MaxLength(1000)]
        public string? Biography { get; set; }

        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
    }
}
