namespace ASafariM.Application.DTOs
{
    public class UserRoleDto
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? Role { get; set; }
    }
}
