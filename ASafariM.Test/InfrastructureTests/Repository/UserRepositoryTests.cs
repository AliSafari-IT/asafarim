using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Application.Mappings;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using ASafariM.Infrastructure.Repositories;
using ASafariM.Presentation.Controllers;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq; // Required for mocking

namespace ASafariM.Test.InfrastructureTests.Repository
{
    [TestClass]
    public class UserRepositoryTests : TestBase
    {
        private UserRepository _userRepository;
        private Mock<ILogger<UserRepository>> _loggerMock;

        [TestInitialize]
        public override void Setup()
        {
            base.Setup(); // Call base class initialization first
            _loggerMock = new Mock<ILogger<UserRepository>>();
            _userRepository = new UserRepository(Context, _loggerMock.Object);
        }

        [TestCleanup]
        public override void Cleanup()
        {
            _userRepository = null;
            base.Cleanup(); // Call base class cleanup last
        }

        [TestMethod]
        public void initialize_mock_logger_for_user_repository()
        {
            // Arrange & Act - Already done in Setup()

            // Assert
            Assert.IsNotNull(_userRepository);
            Assert.IsNotNull(_loggerMock.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void handle_null_context_options_throws_exception()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<UserRepository>>();
            DbContextOptions<AppDbContext> nullOptions = null;

            // Act - This should throw
            _ = new AppDbContext(nullOptions);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void handle_invalid_database_name_throws_exception()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<UserRepository>>();
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: string.Empty)
                .Options;

            // Act - This should throw
            _ = new AppDbContext(options);
        }

        [TestMethod]
        public async Task GetUserByEmailAsync_ShouldReturnUser_WhenUserExists()
        {
            // Arrange
            var user = new User
            {
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);

            // Act
            var result = await _userRepository.GetUserByEmailAsync("test@example.com");

            // Assert
            Assert.IsNotNull(result, "User should not be null after being added.");
            Assert.AreEqual(user.Email, result.Email);
        }

        [TestMethod]
        public async Task GetUserByEmailAsync_ShouldReturnNull_WhenUserDoesNotExist()
        {
            // Act
            var result = await _userRepository.GetUserByEmailAsync("nonexistent@example.com");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task GetUserByIdAsync_ShouldReturnUser_WhenUserExists()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);

            // Act
            var result = await _userRepository.GetUserByIdAsync(user.Id);

            // Assert
            Assert.IsNotNull(result, "User should not be null after being added.");
            Assert.AreEqual(user.Id, result.Id);
        }
        [TestMethod]
        public async Task GetAllUsersAsync_ShouldReturnAllUsers()
        {
            // Arrange
            var user1 = new User
            {
                Email = "user1@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            var user2 = new User
            {
                Email = "user2@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user1);
            await _userRepository.AddUserAsync(user2);

            // Act
            var result = await _userRepository.GetAllUsersAsync();

            // Assert
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public async Task AddUserAsync_ShouldAddUser()
        {
            // Arrange
            var user = new User
            {
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            // Act
            await _userRepository.AddUserAsync(user);

            // Assert
            var result = await _userRepository.GetUserByEmailAsync(user.Email);
            Assert.IsNotNull(result, "User should not be null after being added.");
        }

        [TestMethod]
        public async Task UpdateUserAsync_ShouldUpdateUser()
        {
            // Arrange
            var user = new User
            {
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);
            user.Email = "updated@example.com";

            // Act
            await _userRepository.UpdateUserAsync(user);

            // Assert
            var result = await _userRepository.GetUserByEmailAsync(user.Email);
            Assert.IsNotNull(result, "User should not be null after being updated.");
            Assert.AreEqual(user.Email, result.Email);
        }

        [TestMethod]
        public async Task GetUserByUserNameAsync_ShouldReturnUser_WhenUserExists()
        {
            // Arrange
            var user = new User
            {
                UserName = "testuser",
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);

            // Act
            var result = await _userRepository.GetUserByUserNameAsync(user.UserName);

            // Assert
            Assert.IsNotNull(result, "User should not be null after being added.");
            Assert.AreEqual(user.UserName, result.UserName);
        }

        [TestMethod]
        public async Task GetUserByPhoneNumberAsync_ShouldReturnUser_WhenUserExists()
        {
            // Arrange
            var user = new User
            {
                PhoneNumber = "1234567890",
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);

            // Act
            var result = await _userRepository.GetUserByPhoneNumberAsync(user.PhoneNumber);

            // Assert
            Assert.IsNotNull(result, "User should not be null after being added.");
            Assert.AreEqual(user.PhoneNumber, result.PhoneNumber);
        }

        [TestMethod]
        public async Task AssignRolesToUserAsync_ShouldAssignRoles_WhenRolesExist()
        {
            // Arrange
            var user = new User
            {
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);

            var role1 = new Role { Name = "Role1", Description = "Test Role 1" };
            var role2 = new Role { Name = "Role2", Description = "Test Role 2" };
            Context.Roles.AddRange(role1, role2);
            await Context.SaveChangesAsync();

            // Act
            await _userRepository.AssignRolesToUserAsync(user.Id, new[] { role1.Id, role2.Id });

            // Assert
            var userRoles = await _userRepository.GetRolesByUserIdAsync(user.Id);
            var roleIds = userRoles.Select(ur => ur.RoleId);
            CollectionAssert.AreEquivalent(new[] { role1.Id, role2.Id }, roleIds.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task AssignRolesToUserAsync_ShouldThrowException_WhenRoleDoesNotExist()
        {
            // Arrange
            var user = new User
            {
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);

            // Act
            await _userRepository.AssignRolesToUserAsync(user.Id, new[] { Guid.NewGuid() });

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public async Task RemoveRolesFromUserAsync_ShouldRemoveRoles_WhenRolesExist()
        {
            // Arrange
            var user = new User
            {
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);

            var role1 = new Role { Name = "Role1", Description = "Test Role 1" };
            var role2 = new Role { Name = "Role2", Description = "Test Role 2" };
            Context.Roles.AddRange(role1, role2);
            await Context.SaveChangesAsync();

            await _userRepository.AssignRolesToUserAsync(user.Id, new[] { role1.Id, role2.Id });

            // Act
            await _userRepository.RemoveRolesFromUserAsync(user.Id, new[] { role1.Id });

            // Assert
            var userRoles = await _userRepository.GetRolesByUserIdAsync(user.Id);
            var roleIds = userRoles.Select(ur => ur.RoleId);
            CollectionAssert.AreEquivalent(new[] { role2.Id }, roleIds.ToArray());
        }

        [TestMethod]
        public async Task GetRolesByUserIdAsync_ShouldReturnRoles_WhenUserHasRoles()
        {
            // Arrange
            var user = new User
            {
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);

            var role1 = new Role { Name = "Role1", Description = "Test Role 1" };
            var role2 = new Role { Name = "Role2", Description = "Test Role 2" };
            Context.Roles.AddRange(role1, role2);
            await Context.SaveChangesAsync();

            await _userRepository.AssignRolesToUserAsync(user.Id, new[] { role1.Id, role2.Id });

            // Act
            var userRoles = await _userRepository.GetRolesByUserIdAsync(user.Id);

            // Assert
            Assert.AreEqual(2, userRoles.Count());
            Assert.IsTrue(userRoles.Any(ur => ur.Role.Name == "Role1"));
            Assert.IsTrue(userRoles.Any(ur => ur.Role.Name == "Role2"));
        }

        [TestMethod]
        public async Task GetRolesByUserIdAsync_ShouldReturnEmptyList_WhenUserHasNoRoles()
        {
            // Arrange
            var user = new User
            {
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);

            // Act
            var userRoles = await _userRepository.GetRolesByUserIdAsync(user.Id);

            // Assert
            Assert.IsFalse(userRoles.Any());
        }
    }
}
