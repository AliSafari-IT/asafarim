using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class Topic : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string? Description { get; set; }
        public string Slug { get; set; }

        // ✅ Self-referencing relationship (Parent-Child Topics)
        public Guid? ParentTopicId { get; set; }

        [ForeignKey("ParentTopicId")]
        public virtual Topic? ParentTopic { get; set; }

        public virtual ICollection<Topic> ChildTopics { get; set; } = new List<Topic>();
        public ICollection<PostTopic> PostTopics { get; set; } = new List<PostTopic>();

        // ✅ Constructor
        public Topic(
            string name,
            string slug,
            string? description = null,
            Guid? parentTopicId = null
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null.");
            Slug = slug ?? throw new ArgumentNullException(nameof(slug), "Slug cannot be null.");
            Description = description;
            ParentTopicId = parentTopicId;
        }

        // ✅ Update Method
        public void UpdateTopic(
            string name,
            string slug,
            string? description = null,
            Guid? parentTopicId = null
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null.");
            Slug = slug ?? throw new ArgumentNullException(nameof(slug), "Slug cannot be null.");
            Description = description;
            ParentTopicId = parentTopicId;
            UpdatedAt = DateTime.UtcNow;
        }

        // ✅ Display Method
        public void DisplayTopicDetails()
        {
            Console.WriteLine($"Topic ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Slug: {Slug}");
            Console.WriteLine($"Description: {Description ?? "N/A"}");
            Console.WriteLine($"Parent Topic ID: {ParentTopicId?.ToString() ?? "None"}");
            Console.WriteLine($"Created At: {CreatedAt}");
            Console.WriteLine($"Updated At: {UpdatedAt?.ToString() ?? "Never"}");
            Console.WriteLine($"Deleted: {(IsDeleted ? "Yes" : "No")}");
            if (IsDeleted)
            {
                Console.WriteLine($"Deleted By: {DeletedBy ?? "Unknown"}");
                Console.WriteLine($"Deleted At: {DeletedAt?.ToString() ?? "Unknown"}");
                Console.WriteLine($"Deleted Message: {DeletedMessage ?? "N/A"}");
            }
        }
    }
}
