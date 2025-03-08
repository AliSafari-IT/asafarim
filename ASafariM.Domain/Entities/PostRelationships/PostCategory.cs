using System;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities.PostRelationships
{
    public class PostCategory
    {
        [Key]
        public Guid Id { get; set; }

        public Guid PostId { get; set; }
        public virtual Post Post { get; set; } = null!;

        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;

        public DateTime AssignedAt { get; set; } = DateTime.UtcNow; // ✅ Extra field
        public bool IsPrimary { get; set; } = false; // ✅ Extra field
    }
}
