using System;
using System.ComponentModel.DataAnnotations.Schema;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class PostTopic : BaseEntity
    {
        public Guid PostId { get; set; }
        public Post Post { get; set; } = null!;

        public Guid TopicId { get; set; }
        public Topic Topic { get; set; } = null!;
    }
}
