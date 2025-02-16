using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASafariM.Test
{
    [TestClass]
    public abstract class TestBase
    {
        protected AppDbContext Context { get; private set; }
        protected string DatabaseName { get; }

        protected TestBase()
        {
            DatabaseName = $"TestDb_{Guid.NewGuid()}"; // Unique database name for each test
        }

        [TestInitialize]
        public virtual void Setup()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(DatabaseName)
                .Options;
            Context = new AppDbContext(options);
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
