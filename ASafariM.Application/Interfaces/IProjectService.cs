using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;

namespace ASafariM.Application.Interfaces;

public interface IProjectService : IEntityService<Project>
{
    Task<Project> GetByIdWithMembersAsync(Guid id);
    Task<Project[]> GetAllWithMembersAsync();
    Task<Project[]> GetByIdsAsync(IEnumerable<Guid> ids);
}
