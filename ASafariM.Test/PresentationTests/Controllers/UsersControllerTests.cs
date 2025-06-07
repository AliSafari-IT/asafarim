using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Application.Services;
using ASafariM.Presentation.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASafariM.Test.PresentationTests.Controllers
{
    [TestClass]
    public class UsersControllerTests : TestBase
    {
        private Mock<IUserService> _userServiceMock;
        private Mock<ILogger<UsersController>> _loggerMock;
        private Mock<IMapper> _mapperMock;
        private UsersController _controller;

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();
            _userServiceMock = new Mock<IUserService>();
            _loggerMock = new Mock<ILogger<UsersController>>();
            _mapperMock = new Mock<IMapper>();
            _controller = new UsersController(_userServiceMock.Object, _mapperMock.Object);
        }

        [TestCleanup]
        public override void Cleanup()
        {
            _controller = null;
            base.Cleanup();
        }

        [TestMethod]
        public async Task GetAllUsers_ReturnsOkWithUsers()
        {
            // Arrange
            var users = new List<UserDto>
            {
                new UserDto { Id = Guid.NewGuid(), Email = "user1@example.com" },
                new UserDto { Id = Guid.NewGuid(), Email = "user2@example.com" },
            };
            _userServiceMock.Setup(s => s.GetAllUsersAsync(false)).ReturnsAsync(users); // Explicitly specify the argument

            // Act
            var result = await _controller.GetAllUsers();

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(users, okResult.Value);
        }

        [TestMethod]
        public async Task CheckAvailability_UsernameTaken_ReturnsMessages()
        {
            // Arrange
            var username = "existingUser";
            _userServiceMock
                .Setup(s => s.IsUsernameNotTakenAsync(username))
                .ReturnsAsync(new IsTakenDto { IsTaken = true });

            // Act
            var actionResult = await _controller.CheckAvailability(username: username);
            var result = actionResult.Result as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);

            var response = result.Value as CheckAvailabilityResponse;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.IsAvailable);
            Assert.AreEqual(1, response.Messages.Count);
            Assert.AreEqual("Username 'existingUser' is already taken", response.Messages[0]);
        }

        [TestMethod]
        public async Task CheckAvailability_UsernameAvailable_ReturnsNoMessages()
        {
            // Arrange
            var username = "availableUser";
            _userServiceMock
                .Setup(s => s.IsUsernameNotTakenAsync(username))
                .ReturnsAsync(new IsTakenDto { IsTaken = false });

            // Act
            var actionResult = await _controller.CheckAvailability(username: username);
            var result = actionResult.Result as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);

            var response = result.Value as CheckAvailabilityResponse;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsAvailable);
            Assert.AreEqual(0, response.Messages.Count);
        }
    }
}
