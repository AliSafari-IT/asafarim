using System;
using System.ComponentModel.DataAnnotations;

namespace DashboardApi.Core.Domain.Entities
{
    public class BlogPostTag
    {
        [Key]
        public Guid BlogPostId { get; set; }
        public virtual BlogPost BlogPost { get; set; }

        [Key]
        public Guid TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
