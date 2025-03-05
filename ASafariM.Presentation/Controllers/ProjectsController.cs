using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASafariM.Presentation.Controllers
{
    /// <summary>
    /// Controller for managing projects
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly ILogger<ProjectsController> _logger;

        public ProjectsController(
            IProjectService projectService,
            ILogger<ProjectsController> logger
        )
        {
            _projectService = projectService;
            _logger = logger;
            _logger.LogInformation("ProjectsController initialized.");
        }

        // To fetch all projects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {
            try
            {
                _logger.LogInformation("Fetching projects via API.");
                var projects = await _projectService.GetAllAsync();
                _logger.LogInformation($"Returning {projects.Count()} projects.");
                return Ok(projects);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to fetch projects.");
                return StatusCode(500, "Failed to load projects. Please try again later.");
            }
        }

        /// <summary>
        /// Retrieves a project by its ID
        /// </summary>
        [HttpGet("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Project>> GetProjectById(Guid id)
        {
            try
            {
                _logger.LogInformation($"Retrieving project with ID: {id}");
                var project = await _projectService.GetByIdAsync(id);

                if (project == null)
                {
                    _logger.LogWarning($"Project with ID {id} not found.");
                    return NotFound($"Project with ID {id} does not exist.");
                }

                _logger.LogInformation($"Retrieved project: {project.Name}");
                return Ok(project);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error retrieving project with ID {id}");
                return StatusCode(500, "An internal error occurred.");
            }
        }

        /// <summary>
        /// Creates a new project
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Project>> CreateProject(
            [FromBody] ProjectCreateDto projectDto
        )
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid project creation request.");
                return BadRequest(ModelState);
            }

            try
            {
                _logger.LogInformation("Creating a new project: {@ProjectDto}", projectDto);

                if (!Enum.IsDefined(typeof(VisibilityEnum), projectDto.Visibility))
                    return BadRequest("Invalid visibility value.");

                if (!Enum.IsDefined(typeof(StatusEnum), projectDto.Status))
                    return BadRequest("Invalid status value.");

                var project = new Project(name: projectDto.Name, ownerId: projectDto.OwnerId)
                {
                    Description = projectDto.Description,
                    StartDate = projectDto.StartDate,
                    EndDate = projectDto.EndDate,
                    Budget = (double?)projectDto.Budget,
                    Visibility = (VisibilityEnum)projectDto.Visibility,
                    Status = (StatusEnum)projectDto.Status,
                };

                var createdProject = await _projectService.CreateAsync(project);

                _logger.LogInformation($"Successfully created project: {createdProject.Name}");

                return CreatedAtAction(
                    nameof(GetProjectById),
                    new { id = createdProject.Id },
                    createdProject
                );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating project.");
                return StatusCode(500, "An internal error occurred.");
            }
        }

        /// <summary>
        /// Updates an existing project
        /// </summary>
        [HttpPut("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateProject(
            Guid id,
            [FromBody] ProjectUpdateDto projectDto
        )
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid project update request.");
                return BadRequest(ModelState);
            }

            try
            {
                _logger.LogInformation($"Updating project with ID: {id}");

                if (projectDto == null)
                {
                    _logger.LogWarning("Received null project update request.");
                    return BadRequest("Project update data cannot be null.");
                }

                var existingProject = await _projectService.GetByIdAsync(id);
                if (existingProject == null)
                {
                    _logger.LogWarning($"Project with ID {id} not found.");
                    return NotFound($"Project with ID {id} does not exist.");
                }

                // ✅ Map DTO to Entity
                existingProject.Name = projectDto.Name;
                existingProject.Description = projectDto.Description;
                existingProject.StartDate = projectDto.StartDate;
                existingProject.EndDate = projectDto.EndDate;
                existingProject.Budget = projectDto.Budget;
                existingProject.Status = projectDto.Status.HasValue
                    ? (StatusEnum)projectDto.Status.Value
                    : existingProject.Status;
                existingProject.Visibility = projectDto.Visibility.HasValue
                    ? (VisibilityEnum)projectDto.Visibility.Value
                    : existingProject.Visibility;
                existingProject.UpdatedAt = DateTime.UtcNow;

                // ✅ Call UpdateAsync with the correct entity
                await _projectService.UpdateAsync(existingProject);

                _logger.LogInformation($"Successfully updated project with ID: {id}");
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error updating project with ID {id}");
                return StatusCode(500, "An internal error occurred.");
            }
        }

        /// <summary>
        /// Deletes a project by ID
        /// </summary>
        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProject(Guid id)
        {
            try
            {
                _logger.LogInformation($"Deleting project with ID: {id}");

                var project = await _projectService.GetByIdAsync(id);
                if (project == null)
                {
                    _logger.LogWarning($"Project with ID {id} not found.");
                    return NotFound($"Project with ID {id} does not exist.");
                }

                await _projectService.DeleteAsync(id);

                _logger.LogInformation($"Successfully deleted project with ID: {id}");
                return NoContent(); // ✅ Returns NoContent instead of assigning void to a variable
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error deleting project with ID {id}");
                return StatusCode(500, "An internal error occurred.");
            }
        }
    }
}
