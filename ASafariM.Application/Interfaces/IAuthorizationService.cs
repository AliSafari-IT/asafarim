using System.Threading.Tasks;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;

namespace ASafariM.Application.Interfaces
{
    public interface IAuthorizationService
    {
        /// <summary>
        /// Synchronously checks if a user is authorized for a specific policy.
        /// </summary>
        /// <param name="user">The user to authorize.</param>
        /// <param name="policyName">The name of the policy to check.</param>
        /// <returns>True if the user is authorized; otherwise, false.</returns>
        bool Authorize(UserDto user, string policyName);

        /// <summary>
        /// Asynchronously checks if a user is authorized for a specific policy.
        /// </summary>
        /// <param name="user">The user to authorize.</param>
        /// <param name="policyName">The name of the policy to check.</param>
        /// <returns>A task that resolves to true if the user is authorized; otherwise, false.</returns>
        Task<bool> AuthorizeAsync(UserDto user, string policyName);
    }
}
