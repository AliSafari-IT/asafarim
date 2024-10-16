namespace Core.Domain.Entities;

/// <summary>
/// Represents a blog post.
/// </summary>

public class BlogPost
{
    /// <summary>
    /// Unique identifier for the blog post.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Title of the blog post.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// The main content of the blog post.
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// The date when the blog post was published.
    /// </summary>
    public DateTime PublishedDate { get; set; }

    /// <summary>
    /// The author who wrote the blog post.
    /// </summary>
    public string Author { get; set; }

    /// <summary>
    /// The URL slug for the blog post, typically used for SEO-friendly URLs.
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// A short summary or excerpt of the blog post.
    /// </summary>
    public string Excerpt { get; set; }

    /// <summary>
    /// The number of views or times the blog post has been read.
    /// </summary>
    public int ViewCount { get; set; }

    /// <summary>
    /// A collection of tags related to the blog post for categorization and search.
    /// </summary>
    public List<string> Tags { get; set; }

    /// <summary>
    /// The date when the blog post was last updated.
    /// </summary>
    public DateTime LastUpdated { get; set; }

    /// <summary>
    /// Indicates whether the blog post is published or still in draft status.
    /// </summary>
    public bool IsPublished { get; set; }

    /// <summary>
    /// The URL of the main image associated with the blog post.
    /// </summary>
    public string ImageUrl { get; set; }

    /// <summary>
    /// Meta description for SEO purposes, to summarize the content for search engines.
    /// </summary>
    public string MetaDescription { get; set; }

    // Constructor to initialize collections
    public BlogPost()
    {
        Id = Guid.NewGuid(); // Automatically generates a unique Guid for each BlogPost instance.
        Tags = new List<string>();
    }
}
