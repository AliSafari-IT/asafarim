using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Common;
using ASafariM.Domain.Entities.PostRelationships;

namespace ASafariM.Domain.Entities
{
    public class Tag : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [StringLength(255)]
        public string? Slug { get; set; }

        // Many-to-Many Relationship with Posts
        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();

        /// <summary>
        /// Generates a slug from the name if not provided.
        /// </summary>
        public void GenerateSlug()
        {
            if (string.IsNullOrWhiteSpace(Slug) && !string.IsNullOrWhiteSpace(Name))
            {
                Slug = Name.ToLower().Replace(" ", "-").Replace("--", "-");
            }
        }
    }
}
