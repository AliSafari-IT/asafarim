using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;

namespace ASafariM.Domain.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllAsync();
        Task<IEnumerable<Post>> GetPublishedAsync();
        Task<Post> GetByIdAsync(Guid id);
        Task<Post> GetBySlugAsync(string slug);
        Task<IEnumerable<Post>> GetByTopicIdAsync(Guid topicId);
        Task<IEnumerable<Post>> GetByTagIdAsync(Guid tagId);
        Task<Post> AddAsync(Post post);
        Task<Post> UpdateAsync(Post post);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
        Task<bool> SlugExistsAsync(string slug);
        Task<int> IncrementViewCountAsync(Guid id);
    }
}
