using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.CommandModels;

public class ForgotPasswordCommand
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
