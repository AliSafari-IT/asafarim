using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASafariM.Domain.Entities
{
    public class Attachment
    {
        [Key]
        public Guid Id { get; set; }
        public string? Url { get; set; }
        public string? FileName { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public string? Size { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        // If you want bidirectional navigation:
        public Post[]? Posts { get; set; } = new Post[] { };
 
    }
}