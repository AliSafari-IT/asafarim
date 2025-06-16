using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.CommandModels
{
    public class CreatePostCommand
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;
        public string? Summary { get; set; }
        public string? Excerpt { get; set; }
        public string? Slug { get; set; }
        public Guid? TopicId { get; set; } // ✅ Ensure this matches frontend request
        public int DifficultyLevel { get; set; } = 1;
        public bool IsPublished { get; set; } = false;
        public DateTime? PublishedDate { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsDraft { get; set; } = true;
        public string? ImageUrl { get; set; }
        public string? MetaDescription { get; set; }
        public string? Description { get; set; }
        public List<Guid> TagIds { get; set; } = new List<Guid>();
        public List<Guid>? Tags { get; set; }
        public List<Guid>? AttachmentIds { get; set; }
        public List<Guid>? Collaborators { get; set; }
        public List<Guid>? RelatedPosts { get; set; }
        public List<Guid>? Links { get; set; }
        public List<Guid>? Categories { get; set; }
        public List<Guid>? Attachments { get; set; }
        public List<string>? AudioUrls { get; set; }
        public List<string>? VideoUrls { get; set; }
        public List<string>? ImageUrls { get; set; }
    }

    public class UpdatePostCommand : CreatePostCommand
    {
        public Guid Id { get; set; } // Ensures an ID is required for updates
    }
}
