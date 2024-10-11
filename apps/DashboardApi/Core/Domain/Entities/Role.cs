using System;

namespace DashboardApi.Core.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        // Navigation property to the join table
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
