using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using ASafariM.Domain.Exceptions;
using ASafariM.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ASafariM.Infrastructure.Services
{
    // This implementation of IProjectService provides CRUD operations for Project entities.
    public class ProjectService : IProjectService, IEntityService<Project>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ILogger<ProjectService> _logger;
        private readonly IEntityService<User> _userService;

        public ProjectService(
            IProjectRepository projectRepository,
            IEntityService<User> userService,
            ILogger<ProjectService> logger
        )
        {
            _projectRepository = projectRepository;
            _userService = userService;
            _logger = logger;
        }

        // Retrieves all projects.
        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            try
            {
                var projects = await _projectRepository.GetAllAsync();
                if (projects == null || !projects.Any())
                {
                    _logger.LogWarning("No projects found");
                    return Enumerable.Empty<Project>();
                }
                return projects;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching all projects");
                throw new ProjectServiceException("Error fetching projects", ex);
            }
        }

        // Retrieves a single project by ID. Returns null if not found.
        public async Task<Project?> GetProjectByIdAsync(Guid id)
        {
            try
            {
                var project = await _projectRepository.GetByIdAsync(id);
                if (project == null)
                {
                    _logger.LogWarning($"Project with ID {id} not found");
                    return null;
                }
                return project;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while fetching project with ID {id}");
                throw new ProjectServiceException($"Error fetching project with ID {id}", ex);
            }
        }

        // Creates a new project.
        public async Task<Project> CreateProjectAsync(Project project)
        {
            try
            {
                _logger.LogInformation("Creating new project: {@Project}", project);

                // Set creation date and generate a new ID if needed.
                project.CreatedAt = DateTime.UtcNow;
                if (project.Id == Guid.Empty)
                {
                    project.Id = Guid.NewGuid();
                }

                // Verify that the owner exists.
                _logger.LogInformation("Checking if owner exists: {OwnerId}", project.OwnerId);
                var owner = await _userService.GetByIdAsync(project.OwnerId);
                if (owner == null)
                {
                    _logger.LogError("User with ID {OwnerId} not found", project.OwnerId);
                    throw new InvalidOperationException(
                        $"User with ID {project.OwnerId} not found"
                    );
                }

                // Set default values for Status and Visibility if not provided.
                if (project.Status == 0)
                {
                    project.Status = StatusEnum.InProgress;
                }
                if (project.Visibility == 0)
                {
                    project.Visibility = VisibilityEnum.Private;
                }

                _logger.LogInformation("Adding project to repository: {@Project}", project);
                await _projectRepository.AddAsync(project);
                _logger.LogInformation("Project created successfully: {ProjectId}", project.Id);
                return project;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error occurred while creating project: {ErrorMessage}",
                    ex.Message
                );
                throw new ProjectServiceException("Error creating project", ex);
            }
        }

        // Updates an existing project.
        public async Task<bool> UpdateProjectAsync(Project project)
        {
            try
            {
                var existingProject = await _projectRepository.GetByIdAsync(project.Id);
                if (existingProject == null)
                {
                    throw new NotFoundException($"Project with ID {project.Id} not found");
                }

                project.UpdatedAt = DateTime.UtcNow;
                await _projectRepository.UpdateAsync(project);
                _logger.LogInformation("Project updated successfully: {ProjectId}", project.Id);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while updating project with ID {project.Id}");
                throw new ProjectServiceException(
                    $"Error updating project with ID {project.Id}",
                    ex
                );
            }
        }

        // Deletes a project by its ID.
        public async Task<bool> DeleteProjectAsync(Guid id)
        {
            try
            {
                var project = await _projectRepository.GetByIdAsync(id);
                if (project == null)
                {
                    throw new NotFoundException($"Project with ID {id} not found");
                }

                await _projectRepository.DeleteAsync(id);
                _logger.LogInformation("Project deleted successfully: {ProjectId}", id);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while deleting project with ID {id}");
                throw new ProjectServiceException($"Error deleting project with ID {id}", ex);
            }
        }

        async Task<IEnumerable<Project>> IEntityService<Project>.GetAllAsync()
        {
            return await GetAllProjectsAsync();
        }

        async Task<Project> IEntityService<Project>.GetByIdAsync(Guid id)
        {
            var project = await GetProjectByIdAsync(id);
            if (project == null)
            {
                throw new NotFoundException($"Project with ID {id} not found");
            }
            return project;
        }

        async Task<Project> IEntityService<Project>.CreateAsync(Project entity)
        {
            return await CreateProjectAsync(entity);
        }

        async Task IEntityService<Project>.UpdateAsync(Project entity)
        {
            // Call your existing method and ignore the boolean result.
            await UpdateProjectAsync(entity);
        }

        async Task IEntityService<Project>.DeleteAsync(Guid id)
        {
            // Call your existing method and ignore the boolean result.
            await DeleteProjectAsync(id);
        }
    }
}
