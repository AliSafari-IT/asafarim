using DashboardApi.Core.Domain.Entities;

namespace Core.Domain.Entities;

/// <summary>
/// Represents a blog post.
/// </summary>

public class BlogPost
{
    // Properties
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Summary { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Slug { get; set; }
    public string Excerpt { get; set; }
    public int ViewCount { get; set; }
    public Guid TopicId { get; set; }
    public Topic Topic { get; set; }
    public DateTime LastUpdated { get; set; }
    public bool IsPublished { get; set; }
    public string ImageUrl { get; set; }
    public string MetaDescription { get; set; }
    public List<Tag> Tags { get; set; } = new List<Tag>();
    public List<User> Authors { get; set; } = new List<User>();
    // Constructor to initialize collections
    public BlogPost()
    {
        Id = Guid.NewGuid(); // Automatically generates a unique Guid for each BlogPost instance.
        PublishedDate = DateTime.UtcNow;
        LastUpdated = DateTime.UtcNow;
        ViewCount = 0;
        IsPublished = false;
        Tags = [];
        Authors = [];

    }
}
