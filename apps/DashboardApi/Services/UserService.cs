using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;
using DashboardApi.Core.Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore; // I have my ApplicationDbContext here

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
    }
}
