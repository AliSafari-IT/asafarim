using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Common;
using ASafariM.Domain.Entities.PostRelationships;
using ASafariM.Domain.Enums;

namespace ASafariM.Domain.Entities
{
    public class Post : BaseEntity
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public string? Summary { get; set; }
        public string? Excerpt { get; set; }
        public string? Slug { get; set; }
        public DateTime? PublishedDate { get; set; }

        public Guid AuthorId { get; set; }
        public virtual User? Author { get; set; }

        public int ViewCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;

        public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
        public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
        public virtual ICollection<User> Collaborators { get; set; } = new List<User>();
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
        public virtual ICollection<Link> Links { get; set; } = new List<Link>();

        // ✅ New Many-to-Many Relationship
        public virtual ICollection<PostAttachment> PostAttachments { get; set; } =
            new List<PostAttachment>();
        public ICollection<PostRelatedPost> PostRelatedPosts { get; set; } =
            new List<PostRelatedPost>();
        public virtual ICollection<PostCategory> PostCategories { get; set; } =
            new List<PostCategory>();
        public virtual ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
        public virtual ICollection<PostCollaborator> PostCollaborators { get; set; } =
            new List<PostCollaborator>();
        public virtual ICollection<PostComment> PostComments { get; set; } =
            new List<PostComment>();
        public virtual ICollection<PostLink> PostLinks { get; set; } = new List<PostLink>();
        public ICollection<PostTopic> PostTopics { get; set; } = new List<PostTopic>();

        public bool IsPublished { get; set; } = true;
        public bool IsDraft { get; set; } = false;
        public bool IsArchived { get; set; } = false;

        public StatusEnum Status { get; set; }
        public string? StatusMessage { get; set; }
        public string? StatusColor { get; set; }
        public string? StatusIcon { get; set; }
        public string? StatusTooltip { get; set; }

        public string? MetaDescription { get; set; }
        public string? Description { get; set; }

        public List<string>? AudioUrls { get; set; } = new List<string>();
        public List<string>? VideoUrls { get; set; } = new List<string>();
        public List<string>? ImageUrls { get; set; } = new List<string>();

        public Post(string title, string content, Guid authorId)
        {
            Title =
                title ?? throw new ArgumentNullException(nameof(title), "Title cannot be null.");
            Content =
                content
                ?? throw new ArgumentNullException(nameof(content), "Content cannot be null.");
            AuthorId = authorId;
        }
    }
}
