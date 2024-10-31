// UsersController.cs

using Microsoft.AspNetCore.Mvc;
using DashboardApi.Services;  
using Microsoft.EntityFrameworkCore;
using DashboardApi.Core.Domain.Entities;


namespace DashboardApi.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(UserService userService) : ControllerBase
    {
        private readonly UserService _userService = userService;

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userService.GetUsersAsync());
        }

        // Create a new user
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            await _userService.CreateNewUser( user);
            return Ok("User created successfully");
        }


        // Get a user by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // Update a user
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(Guid id, [FromBody] User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }
            await _userService.UpdateUserAsync(user);
            return NoContent();
        }

        // Delete a user
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            await _userService.DeleteUserAsync(user);
            return NoContent();            
        }

        // Update user roles
        [HttpPut("{id}/roles")]
        public async Task<IActionResult> UpdateUserRoles(Guid id, [FromBody] string[] roles)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            await _userService.UpdateUserRolesAsync(user, roles);
            return NoContent();
        }

        // Get user roles
        [HttpGet("{id}/roles")]
        public async Task<IActionResult> GetUserRoles(Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var roles = await _userService.GetUserRolesAsync(user);
            return Ok(roles);
        }


        // Get users by role
        [HttpGet("role/{roleName}")]
        public async Task<IActionResult> GetUsersByRole(string roleName)
        {
            var users = await _userService.GetUsersByRoleAsync(roleName);
            return Ok(users);
        }


        // Get users by role and name
        [HttpGet("role/{roleName}/name/{name}")]
        public async Task<IActionResult> GetUsersByRoleAndName(string roleName, string name)
        {
            var users = await _userService.GetUsersByRoleAndNameAsync(roleName, name);
            return Ok(users);
        }

    }
}