using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DashboardApi.Core.Domain.Entities
{
    public class Topic
    {
        // Properties of the Topic class

        /// <summary>
        /// The unique identifier for the topic using Guid.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the topic (e.g., React, Angular, .NET C#, etc.).
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// A short description of the topic.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The number of blog posts associated with this topic.
        /// </summary>
        public int PostCount { get; set; }

        /// <summary>
        /// The date when the topic was first created or added to the system.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The most recent date a post was added under this topic.
        /// </summary>
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// A list of associated blog posts related to this topic.
        /// </summary>
        public List<BlogPost>? RelatedPosts { get; set; } = new List<BlogPost>(); // Navigation property

        /// <summary>
        /// The main technology category (e.g., Frontend, Backend, Full-Stack).
        /// </summary>
        public string TechnologyCategory { get; set; } = string.Empty;

        /// <summary>
        /// The difficulty level of the content (e.g., Beginner, Intermediate, Advanced).
        /// </summary>
        public string DifficultyLevel { get; set; } = string.Empty;

        /// <summary>
        /// A collection of tags to categorize the topic for better searchability.
        /// </summary>
        public List<string>? Tags { get; set; } = new List<string>();

        // Constructor for the Topic class
        public Topic()
        {
            Id = Guid.NewGuid(); // Automatically generates a unique Guid for each Topic instance.
            RelatedPosts = new List<BlogPost>();
            Tags = new List<string>();
        }
    }
}
