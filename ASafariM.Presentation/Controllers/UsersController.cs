using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;

namespace ASafariM.Presentation.Controllers
{
    /// <summary>
    /// Controller for managing users
    /// </summary>
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieves all users.
        /// </summary>
        /// <param name="includeSoftDeleted">Whether to include soft deleted users</param>
        /// <returns>Collection of users</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllUsers([FromQuery] bool includeSoftDeleted = false)
        {
            Log.Information(
                "Getting all users. Including soft deleted: {IncludeSoftDeleted}",
                includeSoftDeleted
            );
            try
            {
                var users = await _userService.GetAllUsersAsync(includeSoftDeleted);
                Log.Information("Total users successfully retrieved: {Total}", users.Count());
                return Ok(users);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while getting all users");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="command">Command model containing user details</param>
        /// <returns>Result of the user creation</returns>
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
        {
            Log.Information("Attempting to create user");

            if (!ModelState.IsValid)
            {
                Log.Warning("Invalid model state for user creation");
                return BadRequest(ModelState);
            }

            try
            {
                await _userService.CreateUserAsync(command);
                Log.Information("User successfully created");
                return CreatedAtAction(nameof(GetAllUsers), null);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error creating user");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Creates a new user by admin.
        /// </summary>
        /// <param name="command">Command model containing user details</param>
        /// <returns>Result of the user creation</returns>
        [HttpPost("admin")]
        public async Task<IActionResult> CreateUserByAdmin(
            [FromBody] CreateUserByAdminCommand command
        )
        {
            Log.Information("Attempting to create user by admin: {@Command}", command);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _userService.CreateUserByAdminAsync(command);
                return CreatedAtAction(nameof(GetAllUsers), null);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error creating user by admin");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Updates an existing user.
        /// </summary>
        /// <param name="id">ID of the user to update</param>
        /// <param name="command">Command model containing user details</param>
        /// <returns>Result of the user update</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, [FromBody] UpdateUserCommand command)
        {
            // Implementation that actually saves to database
            // Make sure to validate and persist changes
            var result = await _userService.UpdateUserAsync(command);
            return Ok(result);
        }

        /// <summary>
        /// Updates an existing user by admin.
        /// </summary>
        /// <param name="id">ID of the user to update</param>
        /// <param name="command">Command model containing user details</param>
        /// <returns>Result of the user update</returns>
        [HttpPut("admin/{id}")]
        public async Task<IActionResult> UpdateUserByAdmin(
            [FromRoute] Guid id,
            [FromBody] UpdateUserByAdminCommand command
        )
        {
            Log.Information("Attempting to update user by admin. User ID: {UserId}", id);

            if (id != command.Id)
            {
                Log.Warning(
                    "ID mismatch between route ({RouteId}) and command ({CommandId})",
                    id,
                    command.Id
                );
                return BadRequest("ID mismatch between route and command");
            }

            // Log the received DateOfBirth *before* calling the service
            Log.Information("Received DateOfBirth in command: {DateOfBirth}", command.DateOfBirth);

            try
            {
                var userUpdated = await _userService.UpdateUserByAdminAsync(command);
                if (userUpdated == null)
                {
                    Log.Warning("User not found for admin update. ID: {UserId}", id);
                    return NotFound();
                }

                Log.Information("User successfully updated by admin. ID: {UserId}", id);
                return Ok(userUpdated);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error updating user by admin. ID: {UserId}", id);
                return StatusCode(500, "An error occurred while updating the user");
            }
        }

        /// <summary>
        /// Deletes a user.
        /// </summary>
        /// <param name="id">ID of the user to delete</param>
        /// <param name="command">Command model containing user details</param>
        /// <returns>Result of the user deletion</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(
            [FromRoute] Guid id,
            [FromBody] DeleteUserCommand command
        )
        {
            Log.Information("Attempting to delete user with ID: {UserId}", id);

            if (command == null || string.IsNullOrEmpty(command.Password))
            {
                Log.Warning("Password is required for user deletion. ID: {UserId}", id);
                return BadRequest(new { message = "Password is required" });
            }

            try
            {
                var isDeleted = await _userService.DeleteUserAsync(id, command.Password);
                if (!isDeleted)
                {
                    Log.Warning("User not found for deletion or deletion failed. ID: {UserId}", id);
                    return NotFound(new { message = "User delete failed" });
                }

                Log.Information("User successfully deleted. ID: {UserId}", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error deleting user. ID: {UserId}", id);
                return StatusCode(500, "An error occurred while deleting the user");
            }
        }

        /// <summary>
        /// Deletes a user by admin.
        /// </summary>
        /// <param name="id">ID of the user to delete</param>
        /// <param name="command">Command model containing user details</param>
        /// <returns>Result of the user deletion</returns>
        [HttpDelete("admin/{id}")]
        public async Task<IActionResult> DeleteUserByAdmin(
            [FromRoute] Guid id,
            [FromBody] DeleteUserByAdminCommand command
        )
        {
            Log.Information("Attempting to delete user by admin with ID: {UserId}", id);

            if (command == null || command.IsAdmin == false)
            {
                Log.Warning("Access denied for user deletion by admin. ID: {UserId}", id);
                return Forbid("Access Denied: You do not have permission to delete this user.");
            }

            try
            {
                var isDeleted = await _userService.DeleteUserByAdminAsync(id, command.IsPermanent);
                if (!isDeleted)
                {
                    Log.Warning(
                        "User not found for admin deletion or deletion failed. ID: {UserId}",
                        id
                    );
                    return NotFound(new { message = "User delete failed" });
                }

                Log.Information("User successfully deleted by admin. ID: {UserId}", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error deleting user by admin. ID: {UserId}", id);
                return StatusCode(500, "An error occurred while deleting the user");
            }
        }

        /// <summary>
        /// Retrieves a user by ID.
        /// </summary>
        /// <param name="id">ID of the user to retrieve</param>
        /// <returns>User details</returns>
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<UserDto>> GetUserById(Guid id)
        {
            Log.Information("Attempting to get user by ID: {UserId}", id);

            try
            {
                var user = await _userService.GetUserByIdAsync(id);
                if (user == null)
                {
                    Log.Warning("User not found. ID: {UserId}", id);
                    return NotFound();
                }

                Log.Information("User found. ID: {UserId}", id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error getting user by ID. ID: {UserId}", id);
                return StatusCode(500, "An error occurred while getting the user: " + ex.Message);
            }
        }

        /// <summary>
        /// Retrieves a user by ID.
        /// </summary>
        /// <param name="id">ID of the user to retrieve</param>
        /// <returns>User details</returns>
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<UserDto>>> SearchUsers(
            [FromQuery] string? username = null,
            [FromQuery] string? email = null
        )
        {
            Log.Information(
                "Searching users with username: {Username}, email: {Email}",
                username,
                email
            );

            try
            {
                var users = await _userService.SearchUsersAsync(username, email);
                Log.Information("Found {Count} users matching search criteria", users.Count());
                return Ok(users);
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error searching users with username: {Username}, email: {Email}",
                    username,
                    email
                );
                return StatusCode(500, "An error occurred while searching users");
            }
        }

        /// <summary>
        /// Changes a user's password.
        /// </summary>
        /// <param name="command">Password change command</param>
        /// <returns>Password change result</returns>
        [HttpPut("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordCommand command)
        {
            Log.Information("Attempting to change password for user ID: {UserId}", command.Id);

            try
            {
                var isUpdated = await _userService.ChangePasswordAsync(command);
                if (!isUpdated)
                {
                    Log.Warning("Password update failed for user ID: {UserId}", command.Id);
                    return BadRequest("Password update failed");
                }

                Log.Information("Password successfully updated for user ID: {UserId}", command.Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error changing password for user ID: {UserId}", command.Id);
                return StatusCode(500, "An error occurred while changing the password");
            }
        }

        /// <summary>
        /// Checks the availability of a username and email.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpGet("check-availability/validate")]
        public async Task<ActionResult<object>> CheckAvailability(
            [FromQuery] string? username = null,
            [FromQuery] string? email = null
        )
        {
            Log.Information(
                "Checking availability for username: {Username}, email: {Email}",
                username,
                email
            );

            if (username == null && email == null)
            {
                Log.Warning("Either username or email parameter is required");
                return BadRequest(
                    new { message = "Either username or email parameter is required" }
                );
            }

            try
            {
                var result = new EmailUsernameAvailabilityDto
                {
                    UsernameAvailability =
                        username != null
                            ? await _userService.IsUsernameNotTakenAsync(username)
                            : null,
                    EmailAvailability =
                        email != null ? await _userService.IsEmailNotTakenAsync(email) : null,
                };

                Log.Information(
                    "Availability result - Username: {UsernameAvailability}, Email: {EmailAvailability}",
                    result.UsernameAvailability?.IsTaken,
                    result.EmailAvailability?.IsTaken
                );

                var messages = new List<string>();
                if (result.UsernameAvailability?.IsTaken == true)
                {
                    messages.Add($"Username '{username}' is already taken");
                }
                if (result.EmailAvailability?.IsTaken == true)
                {
                    messages.Add($"Email '{email}' is already registered");
                }

                var isAvailable = !messages.Any();

                Log.Information("Final availability result: {IsAvailable}", isAvailable);
                return Ok(
                    new CheckAvailabilityResponse { IsAvailable = isAvailable, Messages = messages }
                );
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error checking availability for username: {Username}, email: {Email}",
                    username,
                    email
                );
                return StatusCode(500, "An error occurred while checking availability");
            }
        }
    }
}
