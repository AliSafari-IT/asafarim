namespace DashboardApi.Core.Domain.Entities;
public class UserRole
{
    public Guid UserId { get; set; }
    public User? User { get; set; }  // Make User nullable to avoid initialization issues in seeding
    public Guid RoleId { get; set; }
    public Role? Role { get; set; }  // Make Role nullable to avoid initialization issues in seeding
}

