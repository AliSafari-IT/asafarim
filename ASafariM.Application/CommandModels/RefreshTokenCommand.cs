using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.CommandModels;
public class RefreshTokenCommand
{
    [Required]
    public string RefreshToken { get; set; } = string.Empty;
}

