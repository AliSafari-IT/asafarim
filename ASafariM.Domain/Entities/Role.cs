namespace ASafariM.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty; // Role name (e.g., Admin, User)
        public string? Description { get; set; } // Optional description for the role

        // Navigation property
        public ICollection<UserRole> UserRoles { get; set; } = [];
        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
