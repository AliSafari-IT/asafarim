using System;
using System.Collections.Generic;

namespace ASafariM.Application.DTOs
{
    public class TopicDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Slug { get; set; }
        public Guid? ParentTopicId { get; set; }
        public string? ParentTopicName { get; set; }
        public ICollection<TopicDto>? ChildTopics { get; set; }
        public ICollection<TagDto>? Tags { get; set; }
    }
}
