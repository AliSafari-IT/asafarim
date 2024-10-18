using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;
using DashboardApi.Core.Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc; // I have my ApplicationDbContext here

namespace DashboardApi.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;
        private readonly PasswordHasher<User> _passwordHasher;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<User>();
        }


        public async Task CreateNewUserAsync()
        {
            // Create a new user with hashed password
            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = "ali",
                Email = "ali@asm.com",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            // Find all users with the given username
            var duplicateUsers = await _context.Users
                .Where(u => u.Username == user.Username)
                .OrderByDescending(u => u.CreatedAt) // Order by creation date to get the latest
                .ToListAsync();

            // If there's more than one user with the same username, remove the latest one
            if (duplicateUsers.Count > 1)
            {
                var latestUser = duplicateUsers.First(); // Get the latest user (ordered by CreatedAt)

                _context.Users.Remove(latestUser); // Remove the latest duplicate
                await _context.SaveChangesAsync();

                throw new InvalidOperationException($"Latest duplicate user with username '{latestUser.Username}' has been removed.");
            }


            var existingUser = _context.Users.FirstOrDefault(u => u.Username == user.Username);
            if (existingUser != null)
            {
                // Request a new username if the current one already exists
                throw new InvalidOperationException("Username already exists. Please choose a different username.");
            }


            // Hash the password
            user.PasswordHash = _passwordHasher.HashPassword(user, "Ali+123456/");

            // Add the user to the database
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Assign StandardUser role
            var standardUserRole = _context.Roles.FirstOrDefault(r => r.Name == "StandardUser");
            if (standardUserRole != null)
            {
                var userRole = new UserRole
                {
                    UserId = user.Id,
                    RoleId = standardUserRole.Id
                };

                _context.UserRoles.Add(userRole);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("StandardUser role not found.");
            }
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserPasswordAsync(User user, string newPassword)
        {
            var hashedPassword = _passwordHasher.HashPassword(user, newPassword);
            user.PasswordHash = hashedPassword;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserEmailAsync(User user, string newEmail)
        {
            user.Email = newEmail;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserUsernameAsync(User user, string newUsername)
        {
            user.Username = newUsername;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserRolesAsync(User user, string[] roles)
        {
            // Remove all user roles
            _context.UserRoles.RemoveRange(_context.UserRoles.Where(ur => ur.UserId == user.Id));
            await _context.SaveChangesAsync();

            // Add new user roles
            foreach (var role in roles)
            {
                var roleEntity = await _context.Roles.FirstOrDefaultAsync(r => r.Name == role);
                if (roleEntity != null)
                {
                    var userRole = new UserRole
                    {
                        UserId = user.Id,
                        RoleId = roleEntity.Id
                    };
                    _context.UserRoles.Add(userRole);
                }
            }

            await _context.SaveChangesAsync();
        }

        public async Task<List<string>> GetUserRolesAsync(User user)
        {
            var userRoles = await _context.UserRoles
                .Where(ur => ur.UserId == user.Id)
                .Join(_context.Roles, ur => ur.RoleId, r => r.Id, (ur, r) => new { Role = r })
                .Select(ur => ur.Role.Name)
                .ToListAsync();

            return userRoles;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>> GetUsersByRoleAsync(string roleName)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
            if (role == null)
            {
                throw new Exception($"Role '{roleName}' not found.");
            }

            return await _context.Users
                .Join(_context.UserRoles, u => u.Id, ur => ur.UserId, (u, ur) => new { User = u, UserRole = ur })
                .Where(ur => ur.UserRole.RoleId == role.Id)
                .Select(ur => ur.User)
                .ToListAsync();
        }

        public async Task<List<User>> GetUsersByNameAsync(string name)
        {
            return await _context.Users
                .Where(u => u.Username.Contains(name))
                .ToListAsync();
        }

        public async Task<List<User>> GetUsersByEmailAsync(string email)
        {
            return await _context.Users
                .Where(u => u.Email.Contains(email))
                .ToListAsync();
        }

        public async Task<List<User>> GetUsersByRoleAndNameAsync(string roleName, string name)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
            if (role == null)
            {
                throw new Exception($"Role '{roleName}' not found.");
            }

            return await _context.Users
                .Join(_context.UserRoles, u => u.Id, ur => ur.UserId, (u, ur) => new { User = u, UserRole = ur })
                .Where(ur => ur.UserRole.RoleId == role.Id && ur.User.Username.Contains(name))
                .Select(ur => ur.User)
                .ToListAsync();
        }

        // Delete a user by ID
        public async Task DeleteUserAsync(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                throw new Exception($"User with ID '{id}' not found.");
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        internal object? GetUserRoles()
        {
            var userRoles = _context.UserRoles
                .Join(_context.Roles, ur => ur.RoleId, r => r.Id, (ur, r) => new { Role = r })
                .Select(ur => ur.Role.Name)
                .ToList();
            return userRoles;
        }

        internal async Task CreateNewUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            
        }
    }
}
