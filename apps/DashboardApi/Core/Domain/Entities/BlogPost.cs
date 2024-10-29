using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DashboardApi.Core.Domain.Enum;
using DashboardApi.Core.Domain.Models;
using DashboardApi.Core.Helpers;
using DashboardApi.Core.Domain.Entities; 

namespace DashboardApi.Core.Domain.Entities
{
    public class BlogPost
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public string Summary { get; set; } = string.Empty;

        public DateTime PublishedDate { get; set; } = DateTime.UtcNow;

        public string Excerpt { get; set; } = string.Empty;

        public int ViewCount { get; set; } = 0;

        [ForeignKey("TopicId")]
        public Guid? TopicId { get; set; }

        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        public bool IsPublished { get; set; } = false;

        public string ImageUrl { get; set; } = string.Empty;

        public string MetaDescription { get; set; } = string.Empty;

        public List<Tag> Tags { get; set; } = new List<Tag>();

        public List<User> Authors { get; set; } = new List<User>();

        public DifficultyLevelEnum DifficultyLevel { get; set; } = DifficultyLevelEnum.Easy;

        // Slug property
        public string Slug => SlugHelper.GenerateSlug(Title); // Ensure SlugHelper is correctly defined
public List<BlogPostTag> BlogPostTags { get; set; } = new List<BlogPostTag>();

        // Constructor
        public BlogPost()
        {
            Id = Guid.NewGuid();
            PublishedDate = DateTime.UtcNow;
            LastUpdated = DateTime.UtcNow;
        }
    }
}
