using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ASafariM.Presentation.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectService _projectService;
    private readonly ILogger _logger;

    public ProjectsController(IProjectService projectService, ILogger logger)
    {
        _projectService = projectService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
    {
        try
        {
            var projects = await _projectService.GetAllProjectsAsync();
            return Ok(projects);
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while fetching projects");
            return StatusCode(500, "An error occurred while fetching projects");
        }
    }

    [Authorize]
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Project>> GetProjectById(Guid id)
    {
        try
        {
            var project = await _projectService.GetProjectByIdAsync(id);
            if (project == null)
            {
                return NotFound($"Project with ID {id} not found");
            }
            _logger.Information("Fetched project with ID {ProjectId} successfully.", id);
            return Ok(project);
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while fetching project with ID {ProjectId}", id);
            return StatusCode(500, "An error occurred while fetching the project");
        }
    }

    [HttpPost]
    public async Task<ActionResult<Project>> CreateProject([FromBody] CreateProjectDto projectDto)
    {
        try
        {
            var project = new Project
            {
                Name = projectDto.Name,
                Description = projectDto.Description,
                StartDate = projectDto.StartDate,
                EndDate = projectDto.EndDate,
                Budget = projectDto.Budget,
                Visibility = (VisibilityEnum)projectDto.Visibility,
                Status = (StatusEnum)projectDto.Status,
                OwnerId = projectDto.OwnerId,
            };

            var createdProject = await _projectService.CreateProjectAsync(project);
            return CreatedAtAction(
                nameof(GetProjectById),
                new { id = createdProject.Id },
                createdProject
            );
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while creating project");
            return StatusCode(500, "An error occurred while creating the project");
        }
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateProject(Guid id, [FromBody] Project project)
    {
        try
        {
            if (id != project.Id)
            {
                return BadRequest("Project ID mismatch");
            }

            var updated = await _projectService.UpdateProjectAsync(project);
            if (!updated)
            {
                return NotFound($"Project with ID {id} not found");
            }
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while updating project with ID {ProjectId}", id);
            return StatusCode(500, "An error occurred while updating the project");
        }
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteProject(Guid id)
    {
        try
        {
            var deleted = await _projectService.DeleteProjectAsync(id);
            if (!deleted)
            {
                return NotFound($"Project with ID {id} not found");
            }
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while deleting project with ID {ProjectId}", id);
            return StatusCode(500, "An error occurred while deleting the project");
        }
    }
}
