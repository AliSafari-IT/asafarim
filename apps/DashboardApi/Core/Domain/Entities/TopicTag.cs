using System;
using System.ComponentModel.DataAnnotations;

namespace DashboardApi.Core.Domain.Entities
{
    public class TopicTag
    {
        [Key]
        public Guid TopicId { get; set; }
        public virtual Topic? Topic { get; set; } = null!;

        [Key]
        public Guid TagId { get; set; }
        public virtual Tag? Tag { get; set; } = null!;
    }
}
