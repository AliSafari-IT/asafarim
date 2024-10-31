using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashboardApi.Core.Domain.Entities
{
    [Index(nameof(Username), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(20, ErrorMessage = "Username cannot be longer than 20 characters"), MinLength(3, ErrorMessage = "Username must be at least 3 characters long")]
        public string Username { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(50, ErrorMessage = "Email cannot be longer than 50 characters")]
        public string Email { get; set; } = string.Empty;

        public string? PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public virtual ICollection<UserBlogPost> UserBlogPosts { get; set; } = new List<UserBlogPost>();

        // Constructor is optional as properties are initialized above
        public User()
        {
            // No need to initialize collections or properties again since they have default values
        }
    }
}
