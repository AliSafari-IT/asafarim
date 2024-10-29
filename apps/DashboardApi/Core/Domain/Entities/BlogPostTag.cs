using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashboardApi.Core.Domain.Entities;

namespace DashboardApi.Core.Domain.Entities
{
    public class BlogPostTag
    {
        public Guid BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }

        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
