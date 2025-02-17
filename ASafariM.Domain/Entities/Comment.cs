using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASafariM.Domain.Entities
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }
        public string? Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public string? DeletedMessage { get; set; }

        // If you want bidirectional navigation:
        public Post[]? Posts { get; set; } = new Post[] { };

        // Navigation properties for preferences
        
    }
}