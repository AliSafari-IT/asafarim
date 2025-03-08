using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;

namespace ASafariM.Application.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponseDto> LoginAsync(LoginUserCommand command);
        Task<AuthResponseDto> RefreshTokenAsync(RefreshTokenCommand command);
    }
}
