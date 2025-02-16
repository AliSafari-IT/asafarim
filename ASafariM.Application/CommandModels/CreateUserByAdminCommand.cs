using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.CommandModels
{
    public class CreateUserByAdminCommand
    {
        [Required, MinLength(2)]
        public required string FirstName { get; set; }

        [Required, MinLength(1)]
        public required string LastName { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [MinLength(6)]
        public required string Password { get; set; }

        [Required]
        [MinLength(3)]
        public required string UserName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? ProfilePicture { get; set; }

        public bool IsAdmin { get; set; } = false;
        public bool IsUser { get; set; } = true;
    }
}
