using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ASafariM.Presentation.Controllers
{
    /// <summary>
    /// Controller for managing user roles
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRepository? _userRepository;
        private readonly ILogger<UserRolesController> _logger;
        private readonly IMapper _mapper;

        public UserRolesController(
            IUserRepository userRepository,
            ILogger<UserRolesController> logger,
            IMapper mapper
        )
        {
            _userRepository = userRepository;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Assigns roles to a user.
        /// </summary>
        /// <param name="userId">ID of the user</param>
        /// <param name="roleIds">Collection of role IDs to assign</param>
        /// <returns>Result of the assignment</returns>
        [HttpPost("{userId}/roles")]
        public async Task<IActionResult> AssignRolesToUser(
            string userId,
            [FromBody] IEnumerable<Guid> roleIds
        )
        {
            Log.Information(
                "Attempting to assign roles to user. User ID: {UserId}, Roles: {RoleIds}",
                userId,
                string.Join(", ", roleIds)
            );

            if (!roleIds.Any())
            {
                Log.Warning("No roles provided for assignment to user ID: {UserId}", userId);
                return BadRequest("No roles provided for assignment.");
            }

            try
            {
                var parsedUserId = Guid.Parse(userId);
                if (!await _userRepository.UserExistsAsync(parsedUserId))
                {
                    Log.Warning("User not found for role assignment. User ID: {UserId}", userId);
                    return NotFound($"User with ID {userId} not found.");
                }

                await _userRepository.AssignRolesToUserAsync(parsedUserId, roleIds);
                Log.Information(
                    "Successfully assigned roles to user. User ID: {UserId}, Roles: {RoleIds}",
                    userId,
                    string.Join(", ", roleIds)
                );
                return Ok();
            }
            catch (InvalidOperationException ex)
            {
                Log.Warning(
                    ex,
                    "Invalid operation during role assignment. User ID: {UserId}",
                    userId
                );
                return BadRequest(ex.Message);
            }
            catch (FormatException)
            {
                Log.Warning("Invalid user ID format for role assignment: {UserId}", userId);
                return BadRequest($"Invalid user ID format: {userId}");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error assigning roles to user. User ID: {UserId}", userId);
                return StatusCode(500, "An error occurred while assigning roles");
            }
        }

        /// <summary>
        /// Removes roles from a user.
        /// </summary>
        /// <param name="userId">ID of the user</param>
        /// <param name="roleIds">Collection of role IDs to remove</param>
        /// <returns>Result of the removal</returns>
        [HttpDelete("{userId}/roles")]
        public async Task<IActionResult> RemoveRolesFromUser(
            string userId,
            [FromBody] IEnumerable<Guid> roleIds
        )
        {
            Log.Information(
                "Attempting to remove roles from user. User ID: {UserId}, Roles: {RoleIds}",
                userId,
                string.Join(", ", roleIds)
            );

            if (!roleIds.Any())
            {
                Log.Warning("No roles provided for removal from user ID: {UserId}", userId);
                return BadRequest("No roles provided for removal.");
            }

            try
            {
                var parsedUserId = Guid.Parse(userId);
                if (!await _userRepository.UserExistsAsync(parsedUserId))
                {
                    Log.Warning("User not found for role removal. User ID: {UserId}", userId);
                    return NotFound($"User with ID {userId} not found.");
                }

                var userRoles = await _userRepository.GetRolesByUserIdAsync(parsedUserId);
                var userRoleIds = userRoles.Select(ur => ur.RoleId);
                var nonExistentRoles = roleIds.Except(userRoleIds);

                if (nonExistentRoles.Any())
                {
                    Log.Warning(
                        "Attempt to remove non-existent roles. User ID: {UserId}, Non-existent roles: {NonExistentRoles}",
                        userId,
                        string.Join(", ", nonExistentRoles)
                    );
                    return BadRequest(
                        $"User does not have the following roles: {string.Join(", ", nonExistentRoles)}"
                    );
                }

                await _userRepository.RemoveRolesFromUserAsync(parsedUserId, roleIds);
                Log.Information(
                    "Successfully removed roles from user. User ID: {UserId}, Roles: {RoleIds}",
                    userId,
                    string.Join(", ", roleIds)
                );
                return Ok();
            }
            catch (FormatException)
            {
                Log.Warning("Invalid user ID format for role removal: {UserId}", userId);
                return BadRequest($"Invalid user ID format: {userId}");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error removing roles from user. User ID: {UserId}", userId);
                return StatusCode(500, $"An error occurred while removing roles: {ex.Message}");
            }
        }

        /// <summary>
        /// Checks if a user has a specific role.
        /// </summary>
        /// <param name="userId">ID of the user</param>
        /// <param name="roleId">ID of the role</param>
        /// <returns>Result of the check</returns>
        [HttpGet("{userId}/roles/{roleId}")]
        public async Task<IActionResult> UserHasRole(Guid userId, Guid roleId)
        {
            Log.Information(
                "Checking if user has role. User ID: {UserId}, Role ID: {RoleId}",
                userId,
                roleId
            );

            try
            {
                bool hasRole = await _userRepository.UserHasRoleAsync(userId, roleId);
                Log.Information(
                    "Role check completed. User ID: {UserId}, Role ID: {RoleId}, Has Role: {HasRole}",
                    userId,
                    roleId,
                    hasRole
                );
                return Ok(hasRole);
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error checking user role. User ID: {UserId}, Role ID: {RoleId}",
                    userId,
                    roleId
                );
                return StatusCode(500, "An error occurred while checking user role");
            }
        }

        /// <summary>
        /// Retrieves roles associated with a user.
        /// </summary>
        /// <param name="userId">ID of the user</param>
        /// <returns>Collection of roles associated with the user</returns>
        [HttpGet("{userId}/roles")]
        public async Task<ActionResult<UserRoleDto[]>> GetRolesByUserIdAsync(string userId)
        {
            Log.Information("Retrieving roles for user. User ID: {UserId}", userId);

            try
            {
                var parsedUserId = Guid.Parse(userId);
                if (!await _userRepository.UserExistsAsync(parsedUserId))
                {
                    Log.Warning("User not found while retrieving roles. User ID: {UserId}", userId);
                    return NotFound($"User with ID {userId} not found.");
                }

                var roles = await _userRepository.GetRolesByUserIdAsync(parsedUserId);
                var roleIds = roles.Select(r => r.RoleId);
                Log.Information(
                    "Successfully retrieved roles for user. User ID: {UserId}, Roles: {RoleIds}",
                    userId,
                    string.Join(", ", roleIds)
                );
                return Ok(_mapper.Map<IEnumerable<UserRole>, IEnumerable<UserRoleDto>>(roles));
            }
            catch (FormatException)
            {
                Log.Warning("Invalid user ID format while retrieving roles: {UserId}", userId);
                return BadRequest($"Invalid user ID format: {userId}");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error retrieving roles for user. User ID: {UserId}", userId);
                return StatusCode(500, $"An error occurred while retrieving roles: {ex.Message}");
            }
        }
    }
}
