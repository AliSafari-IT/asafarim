using System;
using System.Collections.Generic;
using ASafariM.Domain.Enums;

namespace ASafariM.Application.DTOs
{
    public class MarkdownFileResponseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public VisibilityEnum Visibility { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<ContributorDto> Contributors { get; set; } = new List<ContributorDto>();
    }
}
