using System;
using System.Linq;
using System.Threading.Tasks;
using DashboardApi.Core.Domain.Entities;
using DashboardApi.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DashboardApi.Services
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectServices _projectServices;

        public ProjectsController(ProjectServices projectServices)
        {
            _projectServices = projectServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var projects = await _projectServices.GetProjectsAsync();
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(Guid id)
        {
            var project = await _projectServices.GetProjectAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult> AddProject([FromBody] Project project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var addedProject = await _projectServices.AddProjectAsync(project);
            return CreatedAtAction(nameof(GetProject), new { id = addedProject.Id }, addedProject);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(Guid id, [FromBody] Project project)
        {
            if (id != project.Id || id == Guid.Empty)
            {
                return BadRequest("Project ID mismatch");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _projectServices.UpdateProjectAsync(project);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _projectServices.ProjectExistsAsync(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(Guid id)
        {
            var project = await _projectServices.GetProjectAsync(id);
            if (project == null)
            {
                return NotFound();
            }

            await _projectServices.DeleteProjectAsync(project);
            return NoContent();
        }
    }
}
