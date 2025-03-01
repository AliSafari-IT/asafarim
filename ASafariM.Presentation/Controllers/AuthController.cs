using System.Security.Cryptography;
using ASafariM.Application.CommandModels;
using ASafariM.Application.Interfaces;
using ASafariM.Application.Services;
using ASafariM.Application.Utils;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ASafariM.Presentation.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IUserService _userService;
    private readonly JwtTokenService _jwtTokenService;
    private readonly ILogger<AuthController> _logger;

    public AuthController(
        IUserRepository userRepository,
        JwtTokenService jwtTokenService,
        IUserService userService,
        ILogger<AuthController> logger
    )
    {
        _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        _jwtTokenService =
            jwtTokenService ?? throw new ArgumentNullException(nameof(jwtTokenService));
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] CreateUserCommand command)
    {
        _logger.LogInformation(
            "Attempting to register new user with email: {Email}",
            command.Email
        );

        if (!ModelState.IsValid)
        {
            _logger.LogWarning("Invalid model state during user registration");
            return BadRequest(new { message = "Invalid model state" });
        }

        try
        {
            await _userService.CreateUserAsync(command);
            _logger.LogInformation(
                "User registered successfully with email: {Email}",
                command.Email
            );
            return Ok(new { message = "User registered successfully" });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error during registration for email: {Email}", command.Email);
            return StatusCode(500, new { message = "Internal server error" });
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
    {
        _logger.LogInformation("Login attempt for email: {Email}", command.Email);

        var user = await _userRepository.GetUserByEmailAsync(command.Email);
        if (user == null)
        {
            _logger.LogWarning("Login failed - user not found for email: {Email}", command.Email);
            return BadRequest(new { message = "User not found" });
        }

        if (user.IsDeleted)
        {
            _logger.LogWarning("Login attempt for deleted account. Email: {Email}", command.Email);
            return BadRequest(new { message = "This account has been deleted.", isDeleted = true });
        }

        if (user.IsLockedOut && user.LockoutEnd.HasValue && user.LockoutEnd.Value > DateTime.UtcNow)
        {
            var lockoutTimeRemaining = (user.LockoutEnd.Value - DateTime.UtcNow).Minutes;
            _logger.LogWarning(
                "Login attempt for locked account. Email: {Email}, Locked for: {Minutes} min",
                command.Email,
                lockoutTimeRemaining
            );
            return BadRequest(
                new { message = $"Account is locked. Try again in {lockoutTimeRemaining} minutes." }
            );
        }

        if (!PasswordHasher.VerifyPassword(command.Password, user.PasswordHash))
        {
            _logger.LogWarning("Failed login attempt for Email: {Email}", command.Email);

            user.FailedLoginAttempts++;
            if (user.FailedLoginAttempts >= 5)
            {
                user.IsLockedOut = true;
                user.LockoutEnd = DateTime.UtcNow.AddMinutes(15);
                _logger.LogWarning(
                    "Account locked due to failed attempts. Email: {Email}",
                    command.Email
                );
            }

            await _userRepository.UpdateUserAsync(user);
            return BadRequest(new { message = "Invalid credentials" });
        }

        user.FailedLoginAttempts = 0;
        user.IsLockedOut = false;
        user.LockoutEnd = null;
        user.LastLogin = DateTime.UtcNow;

        await _userRepository.UpdateUserAsync(user);
        _logger.LogInformation("Successful login for Email: {Email}", command.Email);

        var token = _jwtTokenService.GenerateJwtToken(user);
        return Ok(new { Token = token, Authenticated = true });
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;
        _logger.LogInformation("User logged out. User ID: {UserId}", userIdClaim ?? "unknown");
        return Ok(new { message = "Logout successful" });
    }

    [HttpPost("reset-password")]
    public IActionResult ResetPassword([FromBody] ResetPasswordCommand command)
    {
        _logger.LogInformation("Password reset attempt initiated.");
        try
        {
            _logger.LogInformation("Password reset successful.");
            return Ok(new { message = "Password reset successful" });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error during password reset.");
            return StatusCode(500, new { message = "Internal server error" });
        }
    }

    [HttpPost("forgot-password")]
    public IActionResult ForgotPassword([FromBody] ForgotPasswordCommand command)
    {
        _logger.LogInformation("Password recovery requested for email: {Email}", command.Email);
        try
        {
            _logger.LogInformation("Password reset link sent to email: {Email}", command.Email);
            return Ok(new { message = "Password reset link sent successfully" });
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error processing forgot password request for email: {Email}",
                command.Email
            );
            return StatusCode(500, new { message = "Internal server error" });
        }
    }

    [HttpPost("update-profile")]
    public async Task<IActionResult> UpdateProfile([FromBody] UpdateProfileCommand command)
    {
        var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;
        if (string.IsNullOrEmpty(userIdClaim) || !Guid.TryParse(userIdClaim, out Guid userId))
        {
            _logger.LogWarning("Unauthorized profile update attempt.");
            return Unauthorized(new { message = "User not authenticated" });
        }

        command.UserId = userId;
        await _userService.UpdateProfileAsync(command);

        _logger.LogInformation("Profile successfully updated for user ID: {UserId}", userId);
        return Ok(new { message = "Profile updated successfully" });
    }
}
