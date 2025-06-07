using System;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Infrastructure.Persistence;
using ASafariM.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASafariM.Test.DomainTests.Persistence
{
    [TestClass]
    public class AppDbContextTests : TestBase
    {
        private Mock<ILogger<UserRepository>> _loggerMock;

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();
            _loggerMock = new Mock<ILogger<UserRepository>>();
        }

        [TestMethod]
        public async Task AddUserAsync_ShouldLogAndSaveChanges()
        {
            // Arrange
            var user = new User
            {
                FirstName = "Test",
                LastName = "User",
                UserName = "testuser",
                PasswordHash = "hashedpassword",
                Email = "test@example.com",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            Context.Users.Add(user);

            // Act
            await Context.SaveChangesAsync();

            // Assert
            Assert.IsTrue(Context.ChangeTracker.Entries().Any());
            var addedUser = Context.Users.FirstOrDefault(u => u.Email == user.Email);
            Assert.IsNotNull(addedUser, "User should not be null after being added.");
            Assert.AreEqual(user.Email, addedUser.Email);
        }

        [TestMethod]
        public async Task GetUserByEmailAsync_ShouldReturnUser_WhenUserExists()
        {
            // Arrange
            var user = new User
            {
                FirstName = "Test",
                LastName = "User",
                UserName = "testuser",
                PasswordHash = "hashedpassword",
                Email = "test@example.com",
            };
            Context.Users.Add(user);
            await Context.SaveChangesAsync();

            // Act
            var result = await Context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(user.Email, result.Email);
        }

        [TestMethod]
        public async Task GetUserByEmailAsync_ShouldReturnNull_WhenUserDoesNotExist()
        {
            // Act
            var result = await Context.Users.FirstOrDefaultAsync(u =>
                u.Email == "nonexistent@example.com"
            );

            // Assert
            Assert.IsNull(result, "User should be null when non-existent.");
        }

        [TestMethod]
        public async Task SaveChangesAsync_CompletesSuccessfully()
        {
            // Arrange
            var user = new User
            {
                FirstName = "Test",
                LastName = "User",
                UserName = "testuser",
                PasswordHash = "hashedpassword",
                Email = "test@example.com",
            };
            Context.Users.Add(user);

            // Act
            var result = await Context.SaveChangesAsync();

            // Assert
            Assert.AreEqual(1, result); // Ensure one record was saved
        }

        [TestMethod]
        public void ContextInitializesWithInMemoryDatabase()
        {
            // Assert
            Assert.IsNotNull(Context);
            Assert.IsInstanceOfType(Context, typeof(AppDbContext));
        }

        [TestMethod]
        public void HandleDuplicateInitializationOfUserRepository()
        {
            // Arrange
            var repo1 = new UserRepository(Context, _loggerMock.Object);
            var repo2 = new UserRepository(CreateMockContext().Object, _loggerMock.Object);

            // Assert
            Assert.IsNotNull(repo1);
            Assert.IsNotNull(repo2);
            Assert.AreNotSame(repo1, repo2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void HandleInvalidDatabaseName_ThrowsException()
        {
            // Act - This should throw
            _ = new AppDbContext(
                new DbContextOptionsBuilder<AppDbContext>()
                    .UseInMemoryDatabase(databaseName: string.Empty)
                    .Options
            );
        }

        [TestMethod]
        public void InitializeMockLoggerForUserRepository()
        {
            // Arrange & Act
            var repo = new UserRepository(Context, _loggerMock.Object);

            // Assert
            Assert.IsNotNull(repo);
            Assert.IsNotNull(_loggerMock.Object);
        }
    }
}
