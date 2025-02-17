using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASafariM.Domain.Entities
{
    public class Tag
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string? Description { get; set; }
        public string? Slug { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // If you want bidirectional navigation:
        public Post[]? Posts { get; set; } = new Post[] { };
        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();

    }
}