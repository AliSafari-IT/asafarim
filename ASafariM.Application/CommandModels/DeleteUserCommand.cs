using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.CommandModels
{
    public class DeleteUserCommand
    {
        [Required]
        public required string Password { get; set; }
    }

    public class DeleteUserByAdminCommand
    {
        [Required]
        public required bool IsAdmin { get; set; }

        [Required]
        public required bool IsPermanent { get; set; }
    }
}
