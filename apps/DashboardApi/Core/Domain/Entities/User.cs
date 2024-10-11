using Core.Domain.Entities;

namespace DashboardApi.Core.Domain.Entities
{
    public class User
    {
        public Guid Id {  get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation property to the join table
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}
