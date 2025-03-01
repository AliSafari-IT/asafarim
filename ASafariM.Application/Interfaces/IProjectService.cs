using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;

namespace ASafariM.Application.Interfaces;

public interface IProjectService
{
    Task<IEnumerable<Project>> GetAllProjectsAsync();
    Task<Project?> GetProjectByIdAsync(Guid id);
    Task<Project> CreateProjectAsync(Project project);
    Task<bool> UpdateProjectAsync(Guid id, ProjectUpdateDto projectDto);
    Task<bool> DeleteProjectAsync(Guid id);
}
