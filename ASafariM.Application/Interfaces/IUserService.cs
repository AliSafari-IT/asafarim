using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;

namespace ASafariM.Application.Interfaces
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(RegisterUserCommand command);
        Task<bool> LoginUserAsync(LoginUserCommand command);
        Task<UserDto?> GetUserByIdAsync(Guid userId);
        Task<IEnumerable<UserDto>> GetAllUsersAsync(bool includeSoftDeleted = false);
        Task<User> CreateUserAsync(CreateUserCommand command);
        Task<UserDto?> UpdateUserAsync(UpdateUserCommand command);
        Task<bool> DeleteUserAsync(Guid id, string password);
        Task<bool> ChangePasswordAsync(ChangePasswordCommand command);
        Task<bool> IsUserAdminAsync(Guid userId);
        Task<bool> IsUserSuperAdminAsync(Guid userId);
        Task<bool> IsUserEditorAsync(Guid userId);
        Task<bool> IsUserModeratorAsync(Guid userId);
        Task<bool> IsUserStandardUserAsync(Guid userId);
        Task<bool> IsUserBannedByAdminAsync(Guid userId);
        Task<bool> IsUserBlockedAsync(Guid userId);
        Task<bool> IsUserVerifiedAsync(Guid userId);
        Task<bool> IsPendingAsync(Guid userId);
        Task<bool> IsGuestAsync(Guid userId);
        Task<bool> IsUserActiveAsync(Guid userId);
        Task<bool> IsUserLockedOutAsync(Guid userId);
        Task<bool> ForgotPasswordAsync(ForgotPasswordCommand command);
        Task<bool> ResetPasswordAsync(ResetPasswordCommand command);
        Task UpdateProfileAsync(UpdateProfileCommand command);
        Task<bool> DeleteUserByAdminAsync(Guid id, bool isAdmin);
        Task<UserDto?> UpdateUserByAdminAsync(UpdateUserByAdminCommand command);
        Task<IsTakenDto?> IsUsernameNotTakenAsync(string username);
        Task<IsTakenDto?> IsEmailNotTakenAsync(string email);
        Task<UserDto?> CreateUserByAdminAsync(CreateUserByAdminCommand command);
        Task<IEnumerable<UserDto>> SearchUsersAsync(string? username, string? email);
        Task<IEnumerable<UserRoleDto>> GetRolesByUserId(string userId);
        Task<bool> RequestAccountReactivationAsync(RequestAccountReactivationCommand command);
        // GetByIdAsync
        Task<UserDto?> GetByIdAsync(Guid userId);
        Task RevokeUserTokenAsync(Guid userId);
    }
}
