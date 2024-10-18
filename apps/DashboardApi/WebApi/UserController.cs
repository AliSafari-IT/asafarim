using Microsoft.AspNetCore.Mvc;
using DashboardApi.Services;  // Add the correct namespace

namespace DashboardApi.WebApi;
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpPost("create-user")]
    public async Task<IActionResult> CreateUser()
    {
        await _userService.CreateNewUserAsync();
        return Ok("User created successfully!");
    }

}
