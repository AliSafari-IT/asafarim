using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Application.DTOs;
using ASafariM.Application.Mappings;
using ASafariM.Domain.Entities;
using ASafariM.Infrastructure.Repositories;
using ASafariM.Presentation.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASafariM.Test.PresentationTests.Controllers
{
    [TestClass]
    public class UserRolesControllerIntegrationTests : TestBase
    {
        private UserRepository _userRepository;
        private UserRolesController _controller;
        private IMapper _mapper;
        private Mock<ILogger<UserRepository>> _loggerMock;
        private Mock<ILogger<UserRolesController>> _controllerLoggerMock;

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();

            // Setup logger mocks
            _loggerMock = new Mock<ILogger<UserRepository>>();
            _controllerLoggerMock = new Mock<ILogger<UserRolesController>>();

            // Setup mapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserMappingProfile());
            });
            _mapper = mapperConfig.CreateMapper();

            // Setup repository and controller
            _userRepository = new UserRepository(Context, _loggerMock.Object);
            _controller = new UserRolesController(_userRepository, _controllerLoggerMock.Object, _mapper);
        }

        [TestCleanup]
        public override void Cleanup()
        {
            _controller = null;
            _userRepository = null;
            base.Cleanup();
        }

        [TestMethod]
        public async Task CompleteRoleManagementFlow_ShouldSucceed()
        {
            // Arrange
            var user = new User
            {
                Email = "test@example.com",
                UserName = "testuser",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);

            var roles = new[]
            {
                new Role { Name = "Admin", Description = "Administrator" },
                new Role { Name = "User", Description = "Standard User" },
            };

            Context.Roles.AddRange(roles);
            await Context.SaveChangesAsync();

            // Act & Assert - Step 1: Assign roles
            var assignResult = await _controller.AssignRolesToUser(
                user.Id.ToString(),
                new[] { roles[0].Id, roles[1].Id }
            );
            Assert.IsInstanceOfType(assignResult, typeof(OkResult));

            // Act & Assert - Step 2: Verify assigned roles
            var getRolesResult = await _controller.GetRolesByUserIdAsync(user.Id.ToString());
            var okResult = getRolesResult.Result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var userRoles = okResult.Value as IEnumerable<UserRoleDto>;
            Assert.IsNotNull(userRoles);
            Assert.AreEqual(2, userRoles.Count());

            // Update the role retrieval test to check against RoleDto
            var roleDtoList = userRoles
                .Select(ur => new RoleDto { Id = ur.RoleId, Name = ur?.RoleName ?? null })
                .ToList();

            // Assert that the role DTOs match expected values
            Assert.AreEqual(2, roleDtoList.Count);
            Assert.IsTrue(roleDtoList.Any(r => r.Name == "Admin"));
            Assert.IsTrue(roleDtoList.Any(r => r.Name == "User"));

            // Act & Assert - Step 3: Remove one role
            var removeResult = await _controller.RemoveRolesFromUser(
                user.Id.ToString(),
                new[] { roles[0].Id }
            );
            Assert.IsInstanceOfType(removeResult, typeof(OkResult));

            // Act & Assert - Step 4: Verify remaining roles
            getRolesResult = await _controller.GetRolesByUserIdAsync(user.Id.ToString());
            okResult = getRolesResult.Result as OkObjectResult;
            userRoles = okResult.Value as IEnumerable<UserRoleDto>;
            Assert.AreEqual(1, userRoles.Count());
            Assert.AreEqual(roles[1].Id, userRoles.First().RoleId);
        }

        [TestMethod]
        public async Task CascadeDelete_ShouldRemoveUserRoles_WhenUserIsDeleted()
        {
            // Arrange
            var user = new User
            {
                Email = "test@example.com",
                UserName = "testuser",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            await _userRepository.AddUserAsync(user);

            var role = new Role { Name = "Admin", Description = "Administrator" };
            Context.Roles.Add(role);
            await Context.SaveChangesAsync();

            // Assign role to user
            await _controller.AssignRolesToUser(user.Id.ToString(), new[] { role.Id });

            // Act - Delete user
            await _userRepository.DeleteUserAsync(user.Id);
            await Context.SaveChangesAsync();

            // Assert - Check that user roles are deleted
            var userRoles = await _userRepository.GetRolesByUserIdAsync(user.Id);
            Assert.AreEqual(0, userRoles.Count());
        }
    }
}
