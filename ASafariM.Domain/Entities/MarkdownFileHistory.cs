using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class MarkdownFileHistory : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public Guid MarkdownFileId { get; set; }
        public MarkdownFile MarkdownFile { get; set; } = null!;

        [Required]
        public string ContentSnapshot { get; set; } = string.Empty; // Snapshot of the content at the time of the change

        [Required]
        // Possibly store which user made the change
        public Guid ChangedByUserId { get; set; }

        [Required]
        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;
    }
}
