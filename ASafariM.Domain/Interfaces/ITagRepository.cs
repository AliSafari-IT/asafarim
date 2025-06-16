using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;

namespace ASafariM.Domain.Interfaces
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>> GetAllAsync();
        Task<Tag> GetByIdAsync(Guid id);
        Task<Tag> GetBySlugAsync(string slug);
        Task<IEnumerable<Tag>> GetTagsByPostIdAsync(Guid postId);
        Task<Tag> AddAsync(Tag tag);
        Task<Tag> UpdateAsync(Tag tag);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
        Task<bool> SlugExistsAsync(string slug);
        Task SaveChangesAsync();
    }
}
