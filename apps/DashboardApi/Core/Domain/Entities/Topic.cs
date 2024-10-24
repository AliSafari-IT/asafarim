using System;
namespace Core.Domain.Entities
{
    public class Topic
    {
        // Properties of the Topic class

        /// <summary>
        /// The unique identifier for the topic using Guid.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the topic (e.g., React, Angular, .NET C#, etc.).
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// A short description of the topic.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of blog posts associated with this topic.
        /// </summary>
        public int PostCount { get; set; }

        /// <summary>
        /// The date when the topic was first created or added to the system.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// The most recent date a post was added under this topic.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// A list of associated blog posts related to this topic.
        /// </summary>
        public List<BlogPost>? RelatedPosts { get; set; } // Navigation property

        /// <summary>
        /// The main technology category (e.g., Frontend, Backend, Full-Stack).
        /// </summary>
        public string TechnologyCategory { get; set; }

        /// <summary>
        /// The difficulty level of the content (e.g., Beginner, Intermediate, Advanced).
        /// </summary>
        public string DifficultyLevel { get; set; }

        /// <summary>
        /// A collection of tags to categorize the topic for better searchability.
        /// </summary>
        public List<string>? Tags { get; set; }

        // Constructor for the Topic class
        public Topic()
        {
            Id = Guid.NewGuid(); // Automatically generates a unique Guid for each Topic instance.
            RelatedPosts = [];
            Tags = [];
        }
    }

}