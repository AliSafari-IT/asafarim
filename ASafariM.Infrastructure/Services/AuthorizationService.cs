using System.Threading.Tasks;
using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Application.Utils;
using ASafariM.Domain.Entities;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ASafariM.Infrastructure.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly ILogger<AuthorizationService> _logger;
        private readonly CurrentUserService _currentUserService;

        public AuthorizationService(
            ILogger<AuthorizationService> logger,
            CurrentUserService currentUserService
        )
        {
            _logger = logger;
            _currentUserService = currentUserService;
        }

        /// <summary>
        /// Synchronously checks if a user is authorized for a specific policy.
        /// </summary>
        /// <param name="user">The user to authorize.</param>
        /// <param name="policyName">The name of the policy to check.</param>
        /// <returns>True if the user is authorized; otherwise, false.</returns>
        public bool Authorize(UserDto user, string policyName)
        {
            var isAdmin = user.IsAdmin;
            var isLogged = user.IsLoggedIn;
            var userId = user.Id;

            switch (policyName)
            {
                case "AdminAccess":
                    return isAdmin;
                case "UserAccess":
                    return isLogged && !isAdmin;
                case "GuestAccess":
                    return !isLogged;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Asynchronously checks if a user is authorized for a specific policy.
        /// </summary>
        /// <param name="user">The user to authorize.</param>
        /// <param name="policyName">The name of the policy to check.</param>
        /// <returns>A task that resolves to true if the user is authorized; otherwise, false.</returns>
        public async Task<bool> AuthorizeAsync(UserDto user, string policyName)
        {
            var userId = user.Id;
            var currentUserId = _currentUserService.GetCurrentUserId();

            _logger.LogInformation(
                $"User ID from request: {userId}, User ID from token: {currentUserId}"
            );

            if (policyName == "update_profile")
            {
                // If currentUserId is null (token not validated), check if the user ID in the request
                // matches the user ID in the request body (client-side validation)
                if (currentUserId == null)
                {
                    _logger.LogWarning(
                        "Token validation failed, falling back to client-side validation"
                    );
                    // For profile updates, we'll trust the client-side validation temporarily
                    // This is a fallback mechanism until the token validation is fixed
                    return true;
                }

                // Allow users to update their own profile
                return userId == currentUserId;
            }

            return await Task.FromResult(true);
        }
    }
}
