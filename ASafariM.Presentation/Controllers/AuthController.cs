using System.Security.Cryptography; // System.Security.Cryptography
using ASafariM.Application.CommandModels; // Command models
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
    private readonly IUserRepository? _userRepository;
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
        _userRepository = userRepository;
        _jwtTokenService = jwtTokenService;
        _userService = userService;
        _logger = logger;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] CreateUserCommand command)
    {
        Log.Information("Attempting to register new user with email: {Email}", command.Email);

        if (!ModelState.IsValid)
        {
            Log.Warning("Invalid model state during user registration");
            return BadRequest(ModelState);
        }

        try
        {
            await _userService.CreateUserAsync(command);
            Log.Information("User registered successfully with email: {Email}", command.Email);
            return Ok("User registered successfully");
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error during registration for email: {Email}", command.Email);
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUserCommand command)
    {
        Log.Information("Login attempt for email: {Email}", command.Email);

        var user = await _userRepository.GetUserByEmailAsync(command.Email);
        if (user == null)
        {
            Log.Warning("Login failed - user not found for email: {Email}", command.Email);
            return new ObjectResult(new { message = "Invalid credentials" })
            {
                StatusCode = StatusCodes.Status401Unauthorized,
            };
        }

        // Check if account is deleted
        if (user.IsDeleted == true)
        {
            Log.Warning(
                "Login attempt for deleted account. User ID: {UserId}, Email: {Email}",
                user.Id,
                command.Email
            );
            return new ObjectResult(
                new { message = "This account has been deleted.", isDeleted = true }
            )
            {
                StatusCode = StatusCodes.Status403Forbidden,
            };
        }

        // Check if account is locked
        if (user.IsLockedOut && user.LockoutEnd.HasValue && user.LockoutEnd.Value > DateTime.UtcNow)
        {
            var lockoutTimeRemaining = (user.LockoutEnd.Value - DateTime.UtcNow).Minutes;
            Log.Warning(
                "Login attempt for locked account. User ID: {UserId}, Email: {Email}, Minutes remaining: {Minutes}",
                user.Id,
                command.Email,
                lockoutTimeRemaining
            );

            return new ObjectResult(
                new { message = $"Account is locked. Try again in {lockoutTimeRemaining} minutes." }
            )
            {
                StatusCode = StatusCodes.Status403Forbidden,
            };
        }

        if (!PasswordHasher.VerifyPassword(command.Password, user.PasswordHash))
        {
            Log.Warning(
                "Failed login attempt for user ID: {UserId}, Email: {Email}",
                user.Id,
                command.Email
            );

            // Increment failed login attempts
            user.FailedLoginAttempts++;

            // Lock the account if failed attempts reach 5
            if (user.FailedLoginAttempts >= 5)
            {
                user.IsLockedOut = true;
                user.LockoutEnd = DateTime.UtcNow.AddMinutes(15);
                Log.Warning(
                    "Account locked due to multiple failed attempts. User ID: {UserId}, Email: {Email}",
                    user.Id,
                    command.Email
                );
            }

            await _userRepository.UpdateUserAsync(user);

            return new ObjectResult(new { message = "Invalid credentials" })
            {
                StatusCode = StatusCodes.Status401Unauthorized,
            };
        }

        // Reset failed login attempts and update last login time
        user.FailedLoginAttempts = 0;
        user.IsLockedOut = false;
        user.LockoutEnd = null;
        user.LastLogin = DateTime.UtcNow;

        try
        {
            await _userRepository.UpdateUserAsync(user);
            Log.Information(
                "Successful login for user ID: {UserId}, Email: {Email}",
                user.Id,
                command.Email
            );
        }
        catch (Exception ex)
        {
            Log.Error(
                ex,
                "Failed to update login information for user ID: {UserId}, Email: {Email}",
                user.Id,
                command.Email
            );
        }

        var token = _jwtTokenService.GenerateJwtToken(user);
        return Ok(
            new
            {
                Token = token,
                Authenticated = user.IsDeleted != true,
                AuthenticatedUser = user,
            }
        );
    }

    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;
        Log.Information("User logged out. User ID: {UserId}", userIdClaim ?? "unknown");
        return Ok("Logout successful");
    }

    [HttpPost("reset-password")]
    public async Task<IActionResult> ResetPassword(ResetPasswordCommand command)
    {
        Log.Information("Password reset attempt for token: {Token}", command.NewPassword);
        try
        {
            // Add actual password reset logic here
            Log.Information("Password reset successful for token: {Token}", command.NewPassword);
            return Ok("Password reset successful");
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error during password reset for token: {Token}", command.NewPassword);
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPost("forgot-password")]
    public async Task<IActionResult> ForgotPassword(ForgotPasswordCommand command)
    {
        Log.Information("Password recovery requested for email: {Email}", command.Email);
        try
        {
            // Add actual forgot password logic here
            Log.Information("Password reset link sent to email: {Email}", command.Email);
            return Ok("Password reset link sent successfully");
        }
        catch (Exception ex)
        {
            Log.Error(
                ex,
                "Error processing forgot password request for email: {Email}",
                command.Email
            );
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPost("change-password")]
    public async Task<IActionResult> ChangePassword(ChangePasswordCommand command)
    {
        Log.Information("Password change attempt for user ID: {UserId}", command.Id);
        try
        {
            await _userService.ChangePasswordAsync(command);
            Log.Information("Password successfully changed for user ID: {UserId}", command.Id);
            return Ok("Password changed successfully");
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error changing password for user ID: {UserId}", command.Id);
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPost("update-profile")]
    public async Task<IActionResult> UpdateProfile(UpdateProfileCommand command)
    {
        var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;
        Log.Information("Profile update attempt for user ID: {UserId}", userIdClaim ?? "unknown");

        try
        {
            if (string.IsNullOrEmpty(userIdClaim) || !Guid.TryParse(userIdClaim, out Guid userId))
            {
                Log.Warning("Unauthorized profile update attempt - user not authenticated");
                return Unauthorized("User not authenticated");
            }

            command.UserId = userId;
            await _userService.UpdateProfileAsync(command);

            Log.Information("Profile successfully updated for user ID: {UserId}", userId);
            return Ok("Profile updated successfully");
        }
        catch (InvalidOperationException ex)
        {
            Log.Warning(ex, "Invalid profile update attempt for user ID: {UserId}", userIdClaim);
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error updating profile for user ID: {UserId}", userIdClaim);
            return StatusCode(500, "Internal server error");
        }
    }

    // requestAccountReactivation
    [HttpPost("request-account-reactivation")]
    public async Task<IActionResult> RequestAccountReactivation(
        RequestAccountReactivationCommand command
    )
    {
        Log.Information("Account reactivation request received for email: {Email}", command.Email);

        if (!ModelState.IsValid)
        {
            Log.Warning("Invalid model state for reactivation request");
            return BadRequest(ModelState);
        }

        try
        {
            var user = await _userRepository.GetUserByEmailAsync(command.Email);
            if (user == null)
            {
                Log.Warning(
                    "Reactivation request failed - user not found for email: {Email}",
                    command.Email
                );
                return NotFound(new { message = "User not found" });
            }

            if (user.IsDeleted != true)
            {
                Log.Warning(
                    "Reactivation request failed - account is not deleted. User ID: {UserId}, Email: {Email}",
                    user.Id,
                    command.Email
                );
                return BadRequest(new { message = "Account is not deleted" });
            }

            await _userService.RequestAccountReactivationAsync(command);

            Log.Information(
                "Account reactivation request processed successfully for email: {Email}",
                command.Email
            );

            return Ok(
                new
                {
                    message = "Account reactivation request sent successfully",
                    email = command.Email,
                }
            );
        }
        catch (Exception ex)
        {
            Log.Error(
                ex,
                "Error processing account reactivation request for email: {Email}",
                command.Email
            );
            return StatusCode(
                500,
                new { message = "An error occurred while processing your request" }
            );
        }
    }
}
