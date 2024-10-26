// create a junction table for blog posts and tags
// this table will allow us to do a many to many relationship between blog posts and tags

namespace DashboardApi.Core.Domain.Junctions;

public class BlogPostTag
{
        public Guid Id { get; set; } = Guid.NewGuid();
    public Guid BlogPostId { get; set; }
    public Guid TagId { get; set; }
}