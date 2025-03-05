using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ASafariM.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(AppDbContext dbContext, ILogger<UserRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            Log.Information("Getting user by email: {Email}", email);
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User?> GetUserByUserNameAsync(string userName)
        {
            Log.Information("Getting user by username: {UserName}", userName);
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.UserName == userName);
        }

        public async Task<User?> GetUserByIdAsync(Guid userId)
        {
            _logger.LogInformation($"Getting user by ID: {userId}");
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task<User?> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            Log.Information("Getting user by phone number: {PhoneNumber}", phoneNumber);
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
        }

        public async Task<List<User>> GetAllUsersAsync(bool includeSoftDeleted = false)
        {
            Log.Information(
                "Retrieving all users. Including soft deleted: {IncludeSoftDeleted}",
                includeSoftDeleted
            );
            var query = _dbContext.Users.AsQueryable();

            if (!includeSoftDeleted)
            {
                query = query.Where(u => !u.IsDeleted);
            }

            return await query
                .Select(u => new User
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    UserName = u.UserName,
                    Email = u.Email,
                    IsAdmin = u.IsAdmin,
                    IsDeleted = u.IsDeleted,
                    DeletedAt = u.DeletedAt,
                    CreatedAt = u.CreatedAt,
                    UpdatedAt = u.UpdatedAt,
                    ProfilePicture = u.ProfilePicture,
                    Biography = u.Biography,
                    IsActive = u.IsActive,
                    DateOfBirth = u.DateOfBirth,
                    LastLogin = u.LastLogin,
                })
                .ToListAsync();
        }

        public async Task AddUserAsync(User user)
        {
            Log.Information("Adding user: {User}", user);
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            Log.Information("Updating user: {User}", user);
            var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == user.Id);

            if (existingUser == null)
                throw new InvalidOperationException($"User with ID {user.Id} not found.");

            // Update all properties
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            existingUser.UserName = user.UserName;
            existingUser.Email = user.Email;
            existingUser.IsAdmin = user.IsAdmin;
            existingUser.IsDeleted = user.IsDeleted;
            existingUser.DeletedAt = user.DeletedAt;
            existingUser.UpdatedAt = DateTime.UtcNow;
            existingUser.ProfilePicture = user.ProfilePicture;
            existingUser.Biography = user.Biography;
            existingUser.IsActive = user.IsActive;
            existingUser.DateOfBirth = user.DateOfBirth;
            existingUser.LastLogin = user.LastLogin;
            existingUser.IsLoggedIn = true;

            _dbContext.Users.Update(existingUser);
            await _dbContext.SaveChangesAsync();
            Log.Information("Successfully updated user: {UserId}", user.Id);
        }

        public async Task UpdateUserByAdminAsync(User user)
        {
            Log.Information("Updating user by admin: {User}", user);
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(Guid id)
        {
            Log.Information("Deleting user with ID: {UserId}", id);
            var user = await _dbContext.Users.FindAsync(id);
            if (user == null)
                throw new InvalidOperationException($"User with ID {id} not found.");

            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
            Log.Information("Successfully deleted user with ID: {UserId}", id);
        }

        public async Task<IEnumerable<User>> GetUsersByUserNameOrEmailAsync(
            string? username,
            string? email
        )
        {
            Log.Information(
                "Getting users by username or email. Username: {UserName}, Email: {Email}",
                username,
                email
            );
            var query = _dbContext.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(username))
                query = query.Where(u => u.UserName.Contains(username));

            if (!string.IsNullOrWhiteSpace(email))
                query = query.Where(u => u.Email.Contains(email));

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<User>> GetUsersByRoleNameAsync(string roleName)
        {
            Log.Information("Getting users by role name: {RoleName}", roleName);
            return await _dbContext
                .UserRoles.Where(ur => ur.Role.Name == roleName)
                .Include(ur => ur.User)
                .Select(ur => ur.User)
                .ToListAsync();
        }

        public async Task<IEnumerable<UserRole>> GetRolesByUserIdAsync(Guid userId)
        {
            Log.Information("Getting roles for user ID: {UserId}", userId);
            return await _dbContext
                .UserRoles.Where(ur => ur.UserId == userId)
                .Include(ur => ur.Role)
                .ToListAsync();
        }

        public async Task AssignRolesToUserAsync(Guid userId, IEnumerable<Guid> roleIds)
        {
            Log.Information(
                "Assigning roles to user {UserId}. Roles: {Roles}",
                userId,
                string.Join(", ", roleIds)
            );

            var user = await _dbContext.Users.FindAsync(userId);
            if (user == null)
            {
                throw new InvalidOperationException($"User with ID {userId} not found.");
            }

            // Fetch all roles first to avoid EF Core query translation issues
            var existingRoles = await _dbContext.Roles.ToListAsync(); // Load into memory

            var validRoleIds = existingRoles.Select(r => r.Id).ToHashSet();
            var invalidRoles = roleIds.Where(roleId => !validRoleIds.Contains(roleId)).ToList();

            if (invalidRoles.Any())
            {
                throw new InvalidOperationException(
                    $"Invalid Role IDs: {string.Join(", ", invalidRoles)}"
                );
            }

            var newRoles = roleIds
                .Where(roleId =>
                    !_dbContext.UserRoles.Any(ur => ur.UserId == userId && ur.RoleId == roleId)
                )
                .Select(roleId => new UserRole { UserId = userId, RoleId = roleId })
                .ToList();

            if (newRoles.Any())
            {
                await _dbContext.UserRoles.AddRangeAsync(newRoles);
                await _dbContext.SaveChangesAsync();
                Log.Information("Successfully assigned roles to user {UserId}", userId);
            }
        }

        public async Task RemoveRolesFromUserAsync(Guid userId, IEnumerable<Guid> roleIds)
        {
            Log.Information(
                "Removing roles from user: {UserId}. Roles: {RoleIds}",
                userId,
                string.Join(", ", roleIds)
            );

            var userRoles = await _dbContext
                .UserRoles.Where(ur => ur.UserId == userId)
                .ToListAsync();

            var rolesToRemove = userRoles.Where(ur => roleIds.Contains(ur.RoleId)).ToList();

            if (!rolesToRemove.Any())
            {
                Log.Warning("No matching roles found for user {UserId}. No roles removed.", userId);
                return; // No roles to remove, exit early
            }

            _dbContext.UserRoles.RemoveRange(rolesToRemove);
            await _dbContext.SaveChangesAsync();
            Log.Information("Successfully removed roles from user {UserId}", userId);
        }

        public async Task<bool> UserExistsAsync(Guid userId)
        {
            Log.Information("Checking if user exists. User ID: {UserId}", userId);
            return await _dbContext.Users.AnyAsync(u => u.Id == userId);
        }

        public async Task<bool> UserExistsByUserNameAsync(string userName)
        {
            Log.Information("Checking if user exists by username: {UserName}", userName);
            return await _dbContext.Users.AnyAsync(u => u.UserName == userName);
        }

        public async Task<bool> UserExistsByEmailAsync(string email)
        {
            Log.Information("Checking if user exists by email: {Email}", email);
            return await _dbContext.Users.AnyAsync(u => u.Email == email);
        }

        public async Task<bool> UserHasRoleAsync(Guid userId, Guid roleId)
        {
            Log.Information(
                "Checking if user has role. User ID: {UserId}, Role ID: {RoleId}",
                userId,
                roleId
            );
            return await _dbContext.UserRoles.AnyAsync(ur =>
                ur.UserId == userId && ur.RoleId == roleId
            );
        }

        public async Task<bool> UserHasRoleByAdminAsync(Guid userId, Guid roleId)
        {
            return await UserHasRoleAsync(userId, roleId);
        }

        public async Task<bool> UserHasRoleByUserAsync(Guid userId, Guid roleId)
        {
            return await UserHasRoleAsync(userId, roleId);
        }

        public async Task<bool> RoleExistsAsync(Guid roleId)
        {
            Log.Information("Checking if role exists. Role ID: {RoleId}", roleId);
            return await _dbContext.Roles.AnyAsync(r => r.Id == roleId);
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            Log.Information("Retrieving all roles.");
            return await _dbContext.Roles.ToListAsync();
        }

        //AddRoleAsync
        public async Task AddRoleAsync(Role role)
        {
            Log.Information("Adding role: {Role}", role);
            await _dbContext.Roles.AddAsync(role);
            await _dbContext.SaveChangesAsync();
        }

        //UpdateRoleAsync
        public async Task UpdateRoleAsync(Role role)
        {
            Log.Information("Updating role: {Role}", role);
            _dbContext.Roles.Update(role);
            await _dbContext.SaveChangesAsync();
        }

        //DeleteRoleAsync
        public async Task DeleteRoleAsync(Guid roleId)
        {
            Log.Information("Deleting role with ID: {RoleId}", roleId);
            var role = await _dbContext.Roles.FindAsync(roleId);
            if (role == null)
            {
                throw new InvalidOperationException($"Role with ID {roleId} not found.");
            }
            _dbContext.Roles.Remove(role);
            await _dbContext.SaveChangesAsync();
        }

        public Task SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
