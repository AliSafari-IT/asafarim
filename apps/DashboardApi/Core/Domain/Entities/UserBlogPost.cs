using System;
using System.ComponentModel.DataAnnotations;

namespace DashboardApi.Core.Domain.Entities
{
    public class UserBlogPost
    {
        [Key]
        public Guid UserId { get; set; } // Foreign key for User

        public virtual User User { get; set; } // Navigation property for User

        [Key]
        public Guid BlogPostId { get; set; } // Foreign key for BlogPost

        public virtual BlogPost BlogPost { get; set; } // Navigation property for BlogPost
    }
}
