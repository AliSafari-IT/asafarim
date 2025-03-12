using System;
using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class Link : BaseEntity
    {
        [Required]
        public string Url { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        public Guid? ProjectId { get; set; } // Foreign key to associate links with projects
        public Project? Project { get; set; }

        // ✅ Relationship: Link can belong to multiple posts
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        // ✅ Constructor
        public Link(string url, string name, string? description = null)
        {
            Url = url ?? throw new ArgumentNullException(nameof(url), "URL cannot be null.");
            Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null.");
            Description = description;
        }

        // ✅ Methods
        public void UpdateLink(string url, string name, string? description)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException("URL cannot be empty.", nameof(url));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.", nameof(name));

            Url = url;
            Name = name;
            Description = description;
            UpdatedAt = DateTime.UtcNow;
        }

        public void DisplayLinkDetails()
        {
            Console.WriteLine($"Link ID: {Id}");
            Console.WriteLine($"URL: {Url}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description ?? "N/A"}");
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
