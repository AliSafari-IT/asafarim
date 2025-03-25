using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace ASafariM.Test
{
    public abstract class TestBase
    {
        public AppDbContext Context { get; set; }
        protected string DatabaseName { get; }
        protected IConfiguration Configuration { get; }

        public TestBase()
        {
            DatabaseName = $"TestDb_{Guid.NewGuid()}"; // Unique database name for each test
            
            // Create a mock configuration that can be used by the AppDbContext
            var configDictionary = new Dictionary<string, string>
            {
                {"ConnectionStrings:DefaultConnection", "TestConnection"},
                {"Jwt:Key", "TestJwtKeyWithAtLeast32Characters1234567"},
                {"Jwt:Issuer", "TestIssuer"},
                {"Jwt:Audience", "TestAudience"},
                {"Jwt:DurationInMinutes", "60"},
                {"Email:FromAddress", "test@example.com"},
                {"Email:FromName", "Test Sender"},
                {"Email:SmtpServer", "localhost"},
                {"Email:SmtpPort", "25"},
                {"Email:SmtpUsername", "testuser"},
                {"Email:SmtpPassword", "testpassword"}
            };
            
            Configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(configDictionary)
                .Build();
                
            // Configure the DbContext with explicit options to avoid loading from appsettings.json
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: DatabaseName)
                .Options;
                
            Context = new AppDbContext(options, Configuration);
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
            var mockConfig = new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string>
                {
                    {"ConnectionStrings:DefaultConnection", "TestConnection"}
                })
                .Build();
                
            return new Mock<AppDbContext>(
                new DbContextOptionsBuilder<AppDbContext>()
                    .UseInMemoryDatabase($"MockDb_{Guid.NewGuid()}")
                    .Options,
                mockConfig
            );
        }
    }
}