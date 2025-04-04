using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Application.Services;
using ASafariM.Application.Utils;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using ASafariM.Infrastructure.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASafariM.Test.InfrastructureTests.Services
{
    [TestClass]
    public class UserServiceTests : TestBase
    {
        private readonly Mock<IUserRepository> _userRepositoryMock = new Mock<IUserRepository>();
        private readonly Mock<ILogger<UserService>> _loggerMock = new Mock<ILogger<UserService>>();
        private readonly Mock<IMapper> _mapperMock = new Mock<IMapper>();
        private readonly Mock<IAuthorizationService> _authorizationServiceMock =
            new Mock<IAuthorizationService>();
        private readonly Mock<IEmailService> _emailServiceMock = new Mock<IEmailService>();
        private readonly JwtTokenService _jwtTokenService;
        private readonly UserService _userService;

        public UserServiceTests()
        {
            // Create a real JwtTokenService instance instead of a mock
            _jwtTokenService = new JwtTokenService(Configuration);
            
            _userService = new UserService(
                _userRepositoryMock.Object,
                _mapperMock.Object,
                Context,
                _authorizationServiceMock.Object,
                Configuration,
                _emailServiceMock.Object,
                _jwtTokenService
            );
        }

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();

            // Setup mapper mock for UserDto mapping
            _mapperMock
                .Setup(m => m.Map<UserDto>(It.IsAny<User>()))
                .Returns((User user) => new UserDto { Id = user.Id, Email = user.Email });
            _mapperMock
                .Setup(m => m.Map<UserInfoDto>(It.IsAny<User>()))
                .Returns((User user) => new UserInfoDto { Id = user.Id, Email = user.Email });
            _mapperMock
                .Setup(m => m.Map<UserDto>(It.IsAny<UserInfoDto>()))
                .Returns((UserInfoDto dto) => new UserDto { Id = dto.Id, Email = dto.Email });
        }

        [TestCleanup]
        public override void Cleanup()
        {
            base.Cleanup();
        }

        [TestMethod]
        public async Task DeleteUserAsync_ShouldCallRepository_WhenUserExists()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var password = "testPassword123";
            var user = new User
            {
                Id = userId,
                FirstName = "Test",
                LastName = "User",
                UserName = "testuser",
                Email = "test@example.com",
                PasswordHash = PasswordHasher.HashPassword(password),
            };

            _userRepositoryMock.Setup(repo => repo.GetUserByIdAsync(userId)).ReturnsAsync(user);

            // Act
            await _userService.DeleteUserAsync(userId, password);

            // Assert
            _userRepositoryMock.Verify(repo => repo.DeleteUserAsync(userId), Times.Once);
        }
    }
}
