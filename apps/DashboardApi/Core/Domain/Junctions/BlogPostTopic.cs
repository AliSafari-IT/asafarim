// create a junction table for blog posts and topics
// this table will allow us to do a many to many relationship between blog posts and topics

namespace DashboardApi.Core.Domain.Junctions;

public class BlogPostTopic
{
         public Guid Id { get; set; } = Guid.NewGuid();
   public Guid BlogPostId { get; set; }
    public Guid TopicId { get; set; }
}