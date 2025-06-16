using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;

namespace ASafariM.Application.Interfaces;

public interface IProjectService : IEntityService<Project>
{
    Task<Project> GetByIdWithMembersAsync(Guid id);
    Task<Project[]> GetAllWithMembersAsync();
    Task<Project[]> GetByIdsAsync(IEnumerable<Guid> ids);
    Task<Project> GetByIdWithLinksAsync(Guid id); // Fetch project with repo links only
    Task<Project> CreateAsync(Project project, List<string> repoUrls);
    Task UpdateAsync(Project project, List<string> repoUrls);
    Task<bool> ExistsAsync(Guid id); // Check if a project exists by ID
 //   Task<Project?> GetByIdWithLinksAsync(Guid id); // Fetch project with repo links only
}
