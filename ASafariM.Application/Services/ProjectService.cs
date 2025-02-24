using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ASafariM.Application.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;
    private readonly IEntityService<User> _userService;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public ProjectService(
        IProjectRepository projectRepository,
        IEntityService<User> userService,
        IMapper mapper,
        ILogger logger
    )
    {
        _projectRepository = projectRepository;
        _userService = userService;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<IEnumerable<Project>> GetAllProjectsAsync()
    {
        try
        {
            return await _projectRepository.GetAllAsync();
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while fetching all projects");
            throw;
        }
    }

    public async Task<Project?> GetProjectByIdAsync(Guid id)
    {
        try
        {
            return await _projectRepository.GetByIdAsync(id);
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while fetching project with ID {ProjectId}", id);
            throw;
        }
    }

    public async Task<Project> CreateProjectAsync(Project project)
    {
        try
        {
            _logger.Information("Creating new project: {@Project}", project);

            // Set creation date and generate ID if not provided
            project.CreatedAt = DateTime.UtcNow;
            if (project.Id == Guid.Empty)
            {
                project.Id = Guid.NewGuid();
            }

            // Ensure Owner exists
            _logger.Information("Checking if owner exists: {OwnerId}", project.OwnerId);
            var owner = await _userService.GetByIdAsync(project.OwnerId);
            if (owner == null)
            {
                _logger.Error("User with ID {OwnerId} not found", project.OwnerId);
                throw new InvalidOperationException($"User with ID {project.OwnerId} not found");
            }
            _logger.Information("Owner found: {Owner}", owner);

            // Don't set the navigation property to avoid circular references
            // Just verify the owner exists
            project.Owner = owner; // Set the owner since it's required by EF Core

            // Set default values if not provided
            if (project.Status == 0)
            {
                project.Status = StatusEnum.InProgress;
            }
            if (project.Visibility == 0)
            {
                project.Visibility = VisibilityEnum.Private;
            }

            _logger.Information("Adding project to repository: {@Project}", project);
            await _projectRepository.AddAsync(project);
            _logger.Information("Project created successfully: {ProjectId}", project.Id);
            return project;
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while creating project: {ErrorMessage}", ex.Message);
            throw;
        }
    }

    public async Task<bool> UpdateProjectAsync(Project project)
    {
        try
        {
            var existingProject = await _projectRepository.GetByIdAsync(project.Id);
            if (existingProject == null)
            {
                return false;
            }

            project.UpdatedAt = DateTime.UtcNow;
            await _projectRepository.UpdateAsync(project);
            return true;
        }
        catch (Exception ex)
        {
            _logger.Error(
                ex,
                "Error occurred while updating project with ID {ProjectId}",
                project.Id
            );
            throw;
        }
    }

    public async Task<bool> DeleteProjectAsync(Guid id)
    {
        try
        {
            var project = await _projectRepository.GetByIdAsync(id);
            if (project == null)
            {
                return false;
            }

            await _projectRepository.DeleteAsync(id);
            return true;
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while deleting project with ID {ProjectId}", id);
            throw;
        }
    }
}
