using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DashboardApi.Core.Domain.Enum;

namespace DashboardApi.Core.Domain.Entities
{
    public class Topic
    {
        [Key]
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public string Description { get; set; } = string.Empty;

        public int PostCount { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        public List<BlogPost>? RelatedPosts { get; set; } = new List<BlogPost>();

        public TechnologyCategoryEnum? TechnologyCategory { get; set; }

        public DifficultyLevelEnum? DifficultyLevel { get; set; } 

        public List<Tag>? Tags { get; set; } = new List<Tag>();

        public Topic()
        {
            Id = Guid.NewGuid();
            RelatedPosts = new List<BlogPost>();
            Tags = new List<Tag>();
            CreatedDate = DateTime.UtcNow;
            LastUpdated = CreatedDate;
            PostCount = 0;
            DifficultyLevel = DifficultyLevelEnum.Easy;
            TechnologyCategory = TechnologyCategoryEnum.Other;
        }
    }
}

