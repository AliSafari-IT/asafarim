using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ASafariM.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /// <summary>
    /// This controller handles operations related to roles in the application.
    /// </summary>
    /// <remarks>
    /// This controller provides endpoints for managing roles in the application.
    /// </remarks>
    public class RolesController : Controller
    {
        private readonly IRoleService _roleService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RolesController"/> class.
        /// </summary>
        /// <param name="roleService">The service used to manage roles.</param>
        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        // Get roles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            try
            {
                Log.Information("Fetching all roles");
                var roles = await _roleService.GetAllAsync();
                Log.Information("Successfully retrieved {RoleCount} roles", roles?.Count() ?? 0);
                return Ok(roles);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching all roles");
                return StatusCode(500, "An error occurred while retrieving roles");
            }
        }

        // GET ROLE NAMES
        /// <summary>
        /// Gets the name of the role by its unique identifier.
        /// </summary>
        /// <param name="roleId">The unique identifier of the role.</param>
        /// <returns>The name of the role.</returns>
        [HttpGet("{roleId}")]
        public async Task<ActionResult<string>> GetRoleName(Guid roleId)
        {
            try
            {
                Log.Information("Fetching role name for ID: {RoleId}", roleId);

                if (roleId == Guid.Empty)
                {
                    Log.Warning("Attempted to fetch role with empty ID");
                    return BadRequest("Role ID cannot be empty.");
                }

                var role = await _roleService.GetByIdAsync(roleId);
                if (role == null)
                {
                    Log.Warning("Role not found with ID: {RoleId}", roleId);
                    return NotFound();
                }

                Log.Information("Successfully retrieved role name for ID: {RoleId}", roleId);
                return Ok(role.Name);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching role name for ID: {RoleId}", roleId);
                return StatusCode(500, "An error occurred while retrieving the role");
            }
        }
    }
}
