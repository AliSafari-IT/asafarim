using System;
using ASafariM.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class Comment : BaseEntity
    {
        [Required]
        public string Text { get; set; }

        // ✅ Self-referencing relationship (Parent-Child Comments)
        public Guid? ParentCommentId { get; set; }
        public virtual Comment? ParentComment { get; set; }
        public virtual ICollection<Comment> Replies { get; set; } = new List<Comment>();

        // ✅ Relationship: Comment belongs to ONE user
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        // ✅ Relationship: Comment can belong to multiple posts
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        // ✅ Relationship: Comment can have multiple tags
        public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();

        // ✅ Metadata fields (inherited from BaseEntity)
        public string? DeletedMessage { get; set; }

        // ✅ Constructor
        public Comment(string text, Guid userId)
        {
            Text =
                text
                ?? throw new ArgumentNullException(nameof(text), "Comment text cannot be null.");
            UserId = userId;
        }

        // ✅ Methods
        public void UpdateText(string newText)
        {
            if (string.IsNullOrWhiteSpace(newText))
                throw new ArgumentException("Comment text cannot be empty.", nameof(newText));

            Text = newText;
            UpdatedAt = DateTime.UtcNow;
        }

        public void MarkAsDeleted(string deletedBy, string? message = null)
        {
            if (string.IsNullOrWhiteSpace(deletedBy))
                throw new ArgumentException(
                    "DeletedBy cannot be null or empty.",
                    nameof(deletedBy)
                );

            IsDeleted = true;
            DeletedAt = DateTime.UtcNow;
            DeletedBy = deletedBy;
            DeletedMessage = message;
        }

        public void Restore()
        {
            IsDeleted = false;
            DeletedAt = null;
            DeletedBy = null;
            DeletedMessage = null;
        }

        public void DisplayCommentDetails()
        {
            Console.WriteLine($"Comment ID: {Id}");
            Console.WriteLine($"Text: {Text}");
            Console.WriteLine($"Created By User ID: {UserId}");
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
