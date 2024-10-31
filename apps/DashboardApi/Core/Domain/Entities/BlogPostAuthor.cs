using System;
using System.ComponentModel.DataAnnotations;

namespace DashboardApi.Core.Domain.Entities
{
    public class BlogPostAuthor
    {
        [Key]
        public Guid BlogPostId { get; set; }
        public virtual BlogPost? BlogPost { get; set; } = null;

        [Key]
        public Guid UserId { get; set; }
        public virtual User? Author { get; set; } = null;
    }
}
