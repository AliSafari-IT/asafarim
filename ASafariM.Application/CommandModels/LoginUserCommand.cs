using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.CommandModels
{
    public class LoginUserCommand
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
