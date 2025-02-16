using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.CommandModels;

public class ChangePasswordCommand
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string CurrentPassword { get; set; }

    [Required]
    public string NewPassword { get; set; }
}
