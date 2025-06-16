using System.ComponentModel.DataAnnotations;
using ASafariM.Application.DTOs;

namespace ASafariM.Application.CommandModels
{
    public class UpdateUserCommand
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
        public IEnumerable<UserRoleDto>? Roles { get; set; }
    }
}
