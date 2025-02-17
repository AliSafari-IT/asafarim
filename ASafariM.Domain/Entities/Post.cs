using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASafariM.Domain.Entities
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public string? Summary { get; set; }
        public string? Excerpt { get; set; }
        public string? Slug { get; set; }

        public DateTime? PublishedDate { get; set; }

        // Author Relationship (One-to-Many)
        public Guid AuthorId { get; set; }
        public User? Author { get; set; }

        public int ViewCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;

        // Many-to-Many Relationship (Tags, Categories)
        public ICollection<Tag>? Tags { get; set; }
        public ICollection<Category>? Categories { get; set; }

        // Many-to-Many Relationship (Collaborators)
        public ICollection<User>? Collaborators { get; set; }

        // One-to-Many Relationship (Comments)
        public ICollection<Comment>? Comments { get; set; }

        // One-to-Many Relationship (Attachments & Links)
        public ICollection<Attachment>? Attachments { get; set; }
        public ICollection<Link>? Links { get; set; }

        // Self-referencing Many-to-Many (Related Posts)
        public ICollection<Post>? RelatedPosts { get; set; }

        // Status & Metadata
        public bool IsPublished { get; set; } = true;
        public bool IsDraft { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? DeletedBy { get; set; }

        public StatusEnum Status { get; set; }
        public string? StatusMessage { get; set; }
        public string? StatusColor { get; set; }
        public string? StatusIcon { get; set; }
        public string? StatusTooltip { get; set; }

        // **[NotMapped] Attributes to Exclude Certain Properties from EF Core Migrations**
        [NotMapped]
        public Guid[]? TagIds { get; set; }

        [NotMapped]
        public Guid[]? CategoryIds { get; set; }

        [NotMapped]
        public Guid[]? CollaboratorIds { get; set; }

        [NotMapped]
        public Guid[]? CommentIds { get; set; }

        [NotMapped]
        public Guid[]? LinkIds { get; set; }

        [NotMapped]
        public Guid[]? RelatedPostIds { get; set; }
        public bool IsArchived { get; set; }

        public List<string>? AudioUrls { get; set; } = new List<string>();
        public List<string>? VideoUrls { get; set; } = new List<string>();
        public List<string>? ImageUrls { get; set; } = new List<string>();

        // NotMapped
        public string? MetaDescription { get; set; }
        public string? Description { get; set; }

        // Navigation Properties
        public ICollection<PostComment> PostComments { get; set; } = new List<PostComment>();
        public ICollection<PostAttachment> PostAttachments { get; set; } =
            new List<PostAttachment>();
        public ICollection<PostLink> PostLinks { get; set; } = new List<PostLink>();
        public ICollection<PostRelatedPost> PostRelatedPosts { get; set; } =
            new List<PostRelatedPost>();
        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
        public ICollection<PostCategory> PostCategories { get; set; } = new List<PostCategory>();
        public ICollection<PostCollaborator> PostCollaborators { get; set; } =
            new List<PostCollaborator>();
    }

    public class PostCollaborator
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public User Collaborator { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class PostCategory
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public Category Category { get; set; }
    }

    public class PostRelatedPost
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public Post RelatedPost { get; set; }
    }

    public class PostLink
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public MarkdownFile Link { get; set; }
    }

    public class PostAttachment
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public MarkdownFile Attachment { get; set; }
    }

    public class PostComment
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public string Comment { get; set; }
        public User Commenter { get; set; }
        public DateTime CommentedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
