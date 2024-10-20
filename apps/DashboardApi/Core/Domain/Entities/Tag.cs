using Core.Domain.Entities;

namespace DashboardApi.Core.Domain.Entities
{
    public class Tag
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Title { get; set; }
        public List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
    }
}
