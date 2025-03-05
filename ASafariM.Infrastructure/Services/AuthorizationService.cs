using System.Threading.Tasks;
using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Application.Utils;
using ASafariM.Domain.Entities;

namespace ASafariM.Infrastructure.Services
{
    public class AuthorizationService : IAuthorizationService
    {
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
            if (policyName == "delete_user")
            {
                if (user.IsAdmin || (user.IsLoggedIn))
                {
                    return true;
                }
            }

            if (policyName == "delete_profile")
            {
                if (user.IsLoggedIn)
                {
                    return true;
                }
            }

            if (policyName == "edit_user")
            {
                if (user.IsAdmin)
                {
                    return true;
                }
            }

            if (policyName == "view_user")
            {
                // Allow view_user policy for guest users or logged-in users
                return true;
            }

            if (policyName == "edit_profile")
            {
                if (user.IsLoggedIn)
                {
                    return true;
                }
            }

            return await Task.FromResult(true);
        }
    }
}
