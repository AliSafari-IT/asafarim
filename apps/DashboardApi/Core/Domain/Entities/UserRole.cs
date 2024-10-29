using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardApi.Core.Domain.Entities
{
    public class UserRole
    {
        [Key]
        public Guid Id { get; set; } // Primary Key

        [Required] // Ensure UserId is required for validation
        public Guid UserId { get; set; } // Foreign Key property for User

        [ForeignKey(nameof(UserId))]
        public User? User { get; set; } // Navigation property for User

        [Required] // Ensure RoleId is required for validation
        public Guid RoleId { get; set; } // Foreign Key property for Role

        [ForeignKey(nameof(RoleId))]
        public Role? Role { get; set; } // Navigation property for Role

        // Constructor to initialize Id
        public UserRole()
        {
            Id = Guid.NewGuid(); // Automatically generate a unique Guid for each UserRole instance
        }

        // Constructor to initialize UserId and RoleId
        public UserRole(Guid userId, Guid roleId) : this() // Call the default constructor
        {
            UserId = userId;
            RoleId = roleId;
        }

        // Optional: Constructor to initialize all properties
        public UserRole(Guid id, Guid userId, Guid roleId) : this(userId, roleId)
        {
            Id = id; // Allow setting a specific Id if needed
        }
    }
}
