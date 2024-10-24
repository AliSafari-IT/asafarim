using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DashboardApi.Core.Domain.Entities
{
    [Index(nameof(Username), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, MaxLength(20, ErrorMessage = "Username cannot be longer than 20 characters"), MinLength(3, ErrorMessage = "Username must be at least 3 characters long")]
        public string Username { get; set; }

        [Required, EmailAddress, MaxLength(50, ErrorMessage = "Email cannot be longer than 50 characters")]
        public string Email { get; set; }

        public string? PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public BlogPost[]? BlogPosts { get; internal set; }
        public UserRole[]? UserRoles { get; internal set; }

        public User() { 
            Id = Guid.NewGuid();                        
        }
    }


}
