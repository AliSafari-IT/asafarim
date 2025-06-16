using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        // If you want bidirectional navigation:
        public ICollection<Post> Posts { get; set; } = new List<Post>();

        // Constructor
        public Category(string name, string? description = null)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null.");
            Description = description;
        }

        // Methods
        public void UpdateCategory(string name, string? description)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.", nameof(name));

            Name = name;
            Description = description;
            UpdatedAt = DateTime.UtcNow;
        }

        public void DisplayCategoryDetails()
        {
            Console.WriteLine($"Category ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description ?? "N/A"}");
            Console.WriteLine($"Created At: {CreatedAt}");
            Console.WriteLine($"Updated At: {UpdatedAt?.ToString() ?? "Never"}");
            Console.WriteLine($"Deleted: {(IsDeleted ? "Yes" : "No")}");
            if (IsDeleted)
            {
                Console.WriteLine($"Deleted By: {DeletedBy ?? "Unknown"}");
                Console.WriteLine($"Deleted At: {DeletedAt?.ToString() ?? "Unknown"}");
            }
        }
    }
}
