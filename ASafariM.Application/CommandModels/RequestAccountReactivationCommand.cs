// RequestAccountReactivationCommand

using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.CommandModels
{
    public class RequestAccountReactivationCommand
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Reason is required")]
        [StringLength(
            500,
            MinimumLength = 10,
            ErrorMessage = "Reason must be between 10 and 500 characters"
        )]
        public string ReactivationReason { get; set; }

        [StringLength(100)]
        public string? RequestedBy { get; set; }

        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
    }
}
