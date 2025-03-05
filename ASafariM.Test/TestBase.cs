using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASafariM.Test
{
    public abstract class TestBase
    {
        public AppDbContext Context { get; set; }
        protected string DatabaseName { get; }

        public TestBase()
        {
            DatabaseName = $"TestDb_{Guid.NewGuid()}"; // Unique database name for each test
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: DatabaseName)
                .Options;
            Context = new AppDbContext(options);
        }

        [TestInitialize]
        public virtual void Setup()
        {
            // Optional: Initialize Context here if needed
        }

        [TestCleanup]
        public virtual void Cleanup()
        {
            Context?.Dispose();
        }

        protected static Mock<AppDbContext> CreateMockContext()
        {
            return new Mock<AppDbContext>(
                new DbContextOptionsBuilder<AppDbContext>()
                    .UseInMemoryDatabase($"MockDb_{Guid.NewGuid()}")
                    .Options
            );
        }
    }
}