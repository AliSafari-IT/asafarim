using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.CommandModels
{
    public class RegisterUserCommand
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string? UserName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public bool IsAdmin { get; set; } = false;

        public string? Biography { get; set; }

        public string? ProfilePicture { get; set; }

        //remark
        public string? Remark { get; set; }

        // Date of birth
        public DateTime? DateOfBirth { get; set; }
    }
}
