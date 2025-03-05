using System.Security.Claims;
using ASafariM.Application.Interfaces;
using Microsoft.AspNetCore.Http;

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
            if (context == null || !context.User.Identity?.IsAuthenticated == true)
                return null;

            var userIdClaim = context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Guid.TryParse(userIdClaim, out var userId) ? userId : (Guid?)null;
        }
    }
}
