using System.Security.Claims;
using ASafariM.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Serilog;

namespace ASafariM.Application.Utils
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid? GetCurrentUserId()
        {
            var context = _httpContextAccessor.HttpContext;

            if (context == null)
            {
                Log.Warning("CurrentUserService:: HttpContext is null");
                return null;
            }

            if (context.User == null || context.User.Identity == null)
            {
                Log.Warning("CurrentUserService:: User or User.Identity is null");
                return null;
            }

            if (!context.User.Identity.IsAuthenticated)
            {
                Log.Warning(
                    "CurrentUserService:: User is not authenticated. Headers: {@Headers}",
                    context
                        .Request?.Headers?.Where(h => h.Key.StartsWith("Authorization"))
                        .ToDictionary(h => h.Key, h => h.Value.ToString())
                );
                return null;
            }

            var userIdClaim = context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userIdClaim))
            {
                Log.Warning(
                    "CurrentUserService:: NameIdentifier claim not found. Available claims: {@Claims}",
                    context.User.Claims.Select(c => new { Type = c.Type, Value = c.Value })
                );
                return null;
            }

            Log.Information("CurrentUserService:: User ID from token: {UserId}", userIdClaim);

            if (!Guid.TryParse(userIdClaim, out var userId))
            {
                Log.Warning(
                    "CurrentUserService:: Failed to parse user ID '{UserId}' as GUID",
                    userIdClaim
                );
                return null;
            }

            return userId;
        }
    }
}
