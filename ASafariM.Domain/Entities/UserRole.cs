using System;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class UserRole
    {
        // Navigation properties
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public Guid RoleId { get; set; }
        public Role Role { get; set; } = null!;
    }
}
