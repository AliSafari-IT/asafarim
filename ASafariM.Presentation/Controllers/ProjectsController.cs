using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASafariM.Presentation.Controllers
{
    [ApiController]
    [Route("api/projects")]
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

        /// <summary>
        /// Retrieves all projects
        /// </summary>
        /// <returns>List of projects</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {
            try
            {
                _logger.LogInformation("Fetching all projects...");
                var projects = await _projectService.GetAllProjectsAsync();

                if (!projects.Any())
                {
                    _logger.LogWarning("No projects found.");
                    return NotFound("No projects available.");
                }

                _logger.LogInformation($"Successfully retrieved {projects.Count()} projects.");
                return Ok(projects);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving projects.");
                return StatusCode(500, "An internal error occurred.");
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
                var project = await _projectService.GetProjectByIdAsync(id);

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

                var project = new Project
                {
                    Name = projectDto.Name,
                    Description = projectDto.Description,
                    StartDate = projectDto.StartDate,
                    EndDate = projectDto.EndDate,
                    Budget = (double?)projectDto.Budget,
                    Visibility = (VisibilityEnum)projectDto.Visibility,
                    Status = (StatusEnum)projectDto.Status,
                    OwnerId = projectDto.OwnerId,
                };

                var createdProject = await _projectService.CreateProjectAsync(project);

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

                if (!Enum.IsDefined(typeof(VisibilityEnum), projectDto.Visibility))
                    return BadRequest("Invalid visibility value.");

                if (!Enum.IsDefined(typeof(StatusEnum), projectDto.Status))
                    return BadRequest("Invalid status value.");

                var updated = await _projectService.UpdateProjectAsync(id, projectDto);

                if (!updated)
                {
                    _logger.LogWarning($"Project with ID {id} not found.");
                    return NotFound($"Project with ID {id} does not exist.");
                }

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
                var deleted = await _projectService.DeleteProjectAsync(id);

                if (!deleted)
                {
                    _logger.LogWarning($"Project with ID {id} not found.");
                    return NotFound($"Project with ID {id} does not exist.");
                }

                _logger.LogInformation($"Successfully deleted project with ID: {id}");
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error deleting project with ID {id}");
                return StatusCode(500, "An internal error occurred.");
            }
        }
    }
}
