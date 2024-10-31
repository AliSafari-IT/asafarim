using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DashboardApi.Core.Domain.Enum;
using DashboardApi.Core.Helpers;

namespace DashboardApi.Core.Domain.Entities
{
    public class BlogPost
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public string Summary { get; set; } = string.Empty;

        public DateTime PublishedDate { get; set; } = DateTime.UtcNow;

        public string Excerpt { get; set; } = string.Empty;

        public int ViewCount { get; set; } = 0;

        public Guid? TopicId { get; set; }

        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        public bool IsPublished { get; set; } = false;

        public string ImageUrl { get; set; } = string.Empty;

        public string MetaDescription { get; set; } = string.Empty;

        public virtual ICollection<UserBlogPost> RelatedUserBlogPosts { get; set; } = new List<UserBlogPost>();

        public List<Tag> Tags { get; set; } = new List<Tag>();

        public DifficultyLevelEnum DifficultyLevel { get; set; } = DifficultyLevelEnum.Easy;

        public virtual ICollection<User> Authors { get; set; } = new List<User>();

        public TechnologyCategoryEnum TechnologyCategory { get; set; } = TechnologyCategoryEnum.Other;
        public virtual ICollection<UserBlogPost> UserBlogPosts { get; set; } = new List<UserBlogPost>();

        public void AddTag(Tag tag)
        {
            Tags.Add(tag);
        }

        public string Slug => SlugHelper.GenerateSlug(Title);

        public void AddAuthor(User user)
        {
            Authors.Add(user);
        }
    }
}
