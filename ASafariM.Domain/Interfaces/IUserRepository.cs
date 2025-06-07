using ASafariM.Domain.Entities;

namespace ASafariM.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByEmailAsync(string email);
        Task<User?> GetUserByUserNameAsync(string userName);
        Task<User?> GetUserByIdAsync(Guid userId);
        Task<List<User>> GetAllUsersAsync(bool includeSoftDeleted = false);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task UpdateUserByAdminAsync(User user);
        Task DeleteUserAsync(Guid id);
        Task<IEnumerable<User>> GetUsersByUserNameOrEmailAsync(string? username, string? email);
        Task<IEnumerable<User>> GetUsersByRoleNameAsync(string roleName);
        Task AssignRolesToUserAsync(Guid userId, IEnumerable<Guid> roleIds);
        Task<IEnumerable<UserRole>> GetRolesByUserIdAsync(Guid userId);
        Task<User?> GetUserByPhoneNumberAsync(string phoneNumber);

        Task RemoveRolesFromUserAsync(Guid userId, IEnumerable<Guid> roleIds);
        Task<bool> UserExistsAsync(Guid userId);
        Task<bool> UserExistsByUserNameAsync(string userName);
        Task<bool> UserExistsByEmailAsync(string email);
        Task<bool> UserHasRoleAsync(Guid userId, Guid roleId);
        Task<bool> UserHasRoleByAdminAsync(Guid userId, Guid roleId);
        Task<bool> UserHasRoleByUserAsync(Guid userId, Guid roleId);
        Task<bool> RoleExistsAsync(Guid roleId);
        Task<IEnumerable<Role>> GetAllRolesAsync();
        Task AddRoleAsync(Role role);
        Task SaveChangesAsync();
    }
}
