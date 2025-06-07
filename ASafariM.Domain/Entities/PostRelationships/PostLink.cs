using System;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities.PostRelationships
{
    public class PostLink
    {
        [Key]
        public Guid Id { get; set; }

        // ✅ Foreign Key: Post
        public Guid PostId { get; set; }
        public virtual Post Post { get; set; } = null!;

        // ✅ Foreign Key: Link (MarkdownFile)
        public Guid LinkId { get; set; }
        public virtual MarkdownFile Link { get; set; } = null!;

        public DateTime LinkedAt { get; set; } = DateTime.UtcNow;
    }
}
