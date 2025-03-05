using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class Role : BaseEntity
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty; // Role name (e.g., Admin, User)
        public string? Description { get; set; } // Optional description for the role

        // Navigation property
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
