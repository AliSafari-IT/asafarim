using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DashboardApi.Core.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; internal set; }

        // Navigation property to the join table
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();

        // Constructor
        public Role(string name, string? description = null)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }

        public Role() {}
    }
}
