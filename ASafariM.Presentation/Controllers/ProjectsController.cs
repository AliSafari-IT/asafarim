using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using ASafariM.Domain.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ASafariM.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectsController : ControllerBase
{
    private readonly IProjectService _projectService;
    private readonly ILogger<ProjectsController> _logger;

    public ProjectsController(IProjectService projectService, ILogger<ProjectsController> logger)
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
            _logger.LogError(ex, "Error getting projects");
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Project>> GetProjectById(Guid id)
    {
        try
        {
            _logger.LogInformation($"Getting project with id: {id}");
            var project = await _projectService.GetProjectByIdAsync(id);

            if (project == null)
            {
                _logger.LogWarning($"Project with id {id} not found");
                return NotFound($"Project with ID {id} not found");
            }

            _logger.LogInformation($"Retrieved project: {project.Name}");
            return Ok(project);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error getting project with id: {id}");
            return StatusCode(500, "Internal server error");
        }
    }

    /// <summary>
    /// Creates a new project
    /// </summary>
    /// <param name="projectDto">Project creation data</param>
    /// <returns>Newly created project</returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Project>> CreateProject([FromBody] CreateProjectDto projectDto)
    {
        try
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _logger.LogInformation("Creating new project");

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
            _logger.LogInformation($"Created project: {createdProject.Name}");

            return CreatedAtAction(
                nameof(GetProjectById),
                new { id = createdProject.Id },
                createdProject
            );
        }
        catch (ValidationException ex)
        {
            _logger.LogWarning(ex, "Validation error creating project");
            return BadRequest(ex.Message);
        }
        catch (DbUpdateException ex)
        {
            _logger.LogError(ex, "Database error creating project");
            return StatusCode(500, "Database error");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error creating new project");
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateProject(Guid id, [FromBody] Project project)
    {
        try
        {
            _logger.LogInformation($"Updating project with id: {id}");
            if (id != project.Id)
            {
                return BadRequest("Project ID mismatch");
            }

            var updated = await _projectService.UpdateProjectAsync(project);
            if (!updated)
            {
                _logger.LogWarning($"Project with id {id} not found");
                return NotFound($"Project with ID {id} not found");
            }
            _logger.LogInformation($"Updated project: {project.Name}");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error updating project with id: {id}");
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteProject(Guid id)
    {
        try
        {
            _logger.LogInformation($"Deleting project with id: {id}");
            var deleted = await _projectService.DeleteProjectAsync(id);
            if (!deleted)
            {
                _logger.LogWarning($"Project with id {id} not found");
                return NotFound($"Project with ID {id} not found");
            }
            _logger.LogInformation($"Deleted project with id: {id}");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error deleting project with id: {id}");
            return StatusCode(500, "Internal server error");
        }
    }
}
