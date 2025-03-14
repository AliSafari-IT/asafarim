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

        /// <summary>
        /// Retrieves all projects
        /// </summary>
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
        /// Retrieves repository links for a project by its ID
        /// </summary>
        [HttpGet("{id:guid}/links")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<string>>> GetProjectRepoLinks(Guid id)
        {
            try
            {
                _logger.LogInformation(
                    "Retrieving repository links for project with ID: {ProjectId}",
                    id
                );

                // Check if project exists first
                var projectExists = await _projectService.ExistsAsync(id);
                if (!projectExists)
                {
                    _logger.LogWarning("Project with ID {ProjectId} not found.", id);
                    return NotFound($"Project with ID {id} not found");
                }

                // Get project to check visibility
                var projectBasic = await _projectService.GetByIdAsync(id);
                
                // If project is not public, check if user is authenticated
                if (projectBasic.Visibility != VisibilityEnum.Public)
                {
                    // Check if user is authenticated
                    if (!User.Identity.IsAuthenticated)
                    {
                        _logger.LogWarning("Unauthorized access attempt to non-public project links: {ProjectId}", id);
                        return Unauthorized("Authentication required to access links for non-public projects");
                    }
                    
                    // For members-only or private projects, additional authorization checks could be added here
                    // TODO: Check if authenticated user is owner, admin, or member for members-only projects
                }

                try
                {
                    // Get project with links
                    var project = await _projectService.GetByIdWithLinksAsync(id);
                    if (project == null)
                    {
                        _logger.LogWarning(
                            "Project with ID {ProjectId} not found after confirming existence.",
                            id
                        );
                        return NotFound($"Project with ID {id} not found");
                    }

                    // Check if Links collection is null to avoid NullReferenceException
                    if (project.Links == null)
                    {
                        _logger.LogWarning("Links collection is null for project {ProjectId}", id);
                        project.Links = new List<Link>();
                    }

                    // Extract links
                    var links = project.Links.ToList();
                    _logger.LogInformation(
                        "Found {LinkCount} links for project {ProjectId}",
                        links.Count,
                        id
                    );

                    // Extract URLs
                    var repoLinks = links.Select(l => l.Url).ToList();

                    _logger.LogInformation(
                        "Successfully retrieved {LinkCount} repository links for project: {ProjectName}",
                        repoLinks.Count,
                        project.Name
                    );

                    return Ok(repoLinks);
                }
                catch (Exception innerEx)
                    when (innerEx.Message.Contains("ProjectId")
                        || (
                            innerEx.InnerException != null
                            && innerEx.InnerException.Message.Contains("ProjectId")
                        )
                    )
                {
                    // Special handling for the "Unknown column 'l.ProjectId'" error
                    _logger.LogError(
                        innerEx,
                        "Database schema error: missing ProjectId column in Links table. Error: {ErrorMessage}",
                        innerEx.Message
                    );

                    // Return empty links rather than crashing with a 500 error
                    _logger.LogInformation(
                        "Returning empty links list due to database schema issue"
                    );
                    return Ok(new List<string>());
                }
                catch (Exception innerEx)
                {
                    _logger.LogError(
                        innerEx,
                        "Error fetching links for project {ProjectId}: {ErrorMessage}",
                        id,
                        innerEx.Message
                    );
                    if (innerEx.InnerException != null)
                    {
                        _logger.LogError(
                            "Inner exception: {InnerError}",
                            innerEx.InnerException.Message
                        );
                    }
                    throw; // Rethrow to be caught by outer handler
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error retrieving repository links for project with ID {ProjectId}: {ErrorMessage}",
                    id,
                    ex.Message
                );
                return StatusCode(
                    500,
                    "An internal error occurred while retrieving repository links. Please check server logs for details."
                );
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

                Project createdProject;

                // Check if repository links are provided
                if (projectDto.RepoLinks != null && projectDto.RepoLinks.Any())
                {
                    _logger.LogInformation(
                        $"Creating project with {projectDto.RepoLinks.Count} repository links"
                    );

                    // Filter out invalid links
                    var validLinks = projectDto
                        .RepoLinks.Where(link => !string.IsNullOrWhiteSpace(link))
                        .ToList();

                    if (validLinks.Count != projectDto.RepoLinks.Count)
                    {
                        _logger.LogWarning(
                            $"Filtered out {projectDto.RepoLinks.Count - validLinks.Count} invalid links"
                        );
                    }

                    // Use the CreateAsync method that accepts repository links
                    createdProject = await _projectService.CreateAsync(project, validLinks);
                    _logger.LogInformation(
                        $"Successfully created project with repository links: {createdProject.Name}"
                    );
                }
                else
                {
                    // Use the standard CreateAsync method without links
                    createdProject = await _projectService.CreateAsync(project);
                    _logger.LogInformation(
                        $"Successfully created project without repository links: {createdProject.Name}"
                    );
                }

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

                // Map DTO to Entity
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

                // First update the basic project properties
                await _projectService.UpdateAsync(existingProject);
                _logger.LogInformation(
                    $"Successfully updated basic project properties for ID: {id}"
                );

                // Log received repository links
                if (projectDto.RepoLinks != null)
                {
                    _logger.LogInformation(
                        $"Received {projectDto.RepoLinks.Count} repo links with update request"
                    );

                    // Log individual links for debugging
                    foreach (var link in projectDto.RepoLinks)
                    {
                        _logger.LogInformation($"Received repo link: '{link}'");
                    }

                    // Then handle repository links separately if provided
                    if (projectDto.RepoLinks.Any())
                    {
                        _logger.LogInformation(
                            $"Updating repository links for project {id}. Links count: {projectDto.RepoLinks.Count}"
                        );

                        try
                        {
                            // Create a filtered list of valid links
                            var validLinks = projectDto
                                .RepoLinks.Where(link => !string.IsNullOrWhiteSpace(link))
                                .ToList();

                            if (validLinks.Count != projectDto.RepoLinks.Count)
                            {
                                _logger.LogWarning(
                                    $"Filtered out {projectDto.RepoLinks.Count - validLinks.Count} invalid links"
                                );
                            }

                            // Separate call to update repository links
                            await _projectService.UpdateAsync(existingProject, validLinks);
                            _logger.LogInformation(
                                $"Successfully updated repository links for project ID: {id}"
                            );
                        }
                        catch (Exception linkEx)
                        {
                            _logger.LogError(
                                linkEx,
                                $"Error updating repository links for project ID {id}: {linkEx.Message}"
                            );

                            if (linkEx.InnerException != null)
                            {
                                _logger.LogError(
                                    $"Inner exception: {linkEx.InnerException.Message}"
                                );
                            }

                            // Return a partial success response
                            return StatusCode(
                                207, // 207 Multi-Status
                                new
                                {
                                    message = "Project was updated but repository links could not be updated",
                                    error = linkEx.Message,
                                }
                            );
                        }
                    }
                }

                return NoContent(); // 204 No Content indicates success
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Unhandled exception in UpdateProject: {ex.Message}");
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
                return NoContent(); // Returns NoContent instead of assigning void to a variable
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error deleting project with ID {id}");
                return StatusCode(500, "An internal error occurred.");
            }
        }
    }
}
