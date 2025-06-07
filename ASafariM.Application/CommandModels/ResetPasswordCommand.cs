using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.CommandModels;

public class ResetPasswordCommand
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string NewPassword { get; set; }

    [Required]
    public string Token { get; set; }
}
