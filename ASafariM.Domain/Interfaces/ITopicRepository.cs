using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;

namespace ASafariM.Domain.Interfaces
{
    public interface ITopicRepository
    {
        Task<IEnumerable<Topic>> GetAllAsync();
        Task<Topic> GetByIdAsync(Guid id);
        Task<Topic> GetBySlugAsync(string slug);
        Task<IEnumerable<Topic>> GetChildTopicsAsync(Guid parentId);
        Task<Topic> AddAsync(Topic topic);
        Task<Topic> UpdateAsync(Topic topic);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
        Task<bool> SlugExistsAsync(string slug);
        Task SaveChangesAsync();
        Task<bool> HasChildrenAsync(Guid id);
    }
}
