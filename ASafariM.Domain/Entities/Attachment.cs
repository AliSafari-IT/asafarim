using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class Attachment : BaseEntity
    {
        [Required]
        public string Url { get; set; }

        [Required]
        public string FileName { get; set; }

        public string? Description { get; set; }
        public string? Type { get; set; }
        public string? Size { get; set; }

        // Constructor (Enforces Required Fields)
        public Attachment(
            string url,
            string fileName,
            string? description = null,
            string? type = null,
            string? size = null
        )
        {
            Url = url ?? throw new ArgumentNullException(nameof(url), "URL cannot be null.");
            FileName =
                fileName
                ?? throw new ArgumentNullException(nameof(fileName), "File name cannot be null.");
            Description = description;
            Type = type;
            Size = size;
        }

        // Methods
        public void MarkAsDeleted(string deletedBy)
        {
            if (string.IsNullOrWhiteSpace(deletedBy))
                throw new ArgumentException(
                    "DeletedBy cannot be null or empty.",
                    nameof(deletedBy)
                );

            IsDeleted = true;
            DeletedAt = DateTime.UtcNow;
            DeletedBy = deletedBy;
        }

        public void Restore()
        {
            IsDeleted = false;
            DeletedAt = null;
            DeletedBy = null;
        }

        public void UpdateMetadata(string? description, string? type, string? size)
        {
            Description = description;
            Type = type;
            Size = size;
            UpdatedAt = DateTime.UtcNow;
        }

        public void DisplayAttachmentDetails()
        {
            Console.WriteLine($"Attachment ID: {Id}");
            Console.WriteLine($"File Name: {FileName}");
            Console.WriteLine($"URL: {Url}");
            Console.WriteLine($"Type: {Type ?? "N/A"}");
            Console.WriteLine($"Size: {Size ?? "N/A"}");
            Console.WriteLine($"Description: {Description ?? "N/A"}");
            Console.WriteLine($"Created By: {CreatedBy}");
            Console.WriteLine($"Updated By: {UpdatedBy ?? "N/A"}");
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
