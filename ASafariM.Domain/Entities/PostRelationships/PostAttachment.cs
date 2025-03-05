using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASafariM.Domain.Entities.PostRelationships
{
    public class PostAttachment
    {
        [Key]
        public Guid Id { get; set; }

        // ✅ Foreign Key: Post
        public Guid PostId { get; set; }
        public virtual Post Post { get; set; } = null!;

        // ✅ Foreign Key: Attachment
        public Guid AttachmentId { get; set; }
        public virtual Attachment Attachment { get; set; } = null!;

        // ✅ Extra Metadata (Optional)
        public DateTime AttachedAt { get; set; } = DateTime.UtcNow;
        public bool IsPrimary { get; set; } = false;
    }
}
