using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DashboardApi.Core.Domain.Entities
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; internal set; }

        public List<User> Users { get; set; } = new List<User>();

        public List<Permission> Permissions { get; set; } = new List<Permission>();

        public Role() { }
    }
}
