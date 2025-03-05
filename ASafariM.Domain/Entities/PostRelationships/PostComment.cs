using System;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities.PostRelationships
{
    public class PostComment
    {
        [Key]
        public Guid Id { get; set; }

        // ✅ Foreign Key: Post
        public Guid PostId { get; set; }
        public virtual Post Post { get; set; } = null!;

        // ✅ Foreign Key: Comment
        public Guid CommentId { get; set; }
        public virtual Comment Comment { get; set; } = null!;

        public DateTime CommentedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
    }
}
