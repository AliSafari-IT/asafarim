
using Microsoft.AspNetCore.Mvc;
using DashboardApi.Core.Domain.Entities;
using DashboardApi.Services;

namespace DashboardApi.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly UserService _userService;

        public UserRolesController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.GetUserRoles());
        }

    }
}

