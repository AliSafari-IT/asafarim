using Xunit;
using Moq;
using System.Collections.Generic;
using Core.Application.Interfaces.Repositories;
using Core.Application.Sitemaps.Queries;
using Core.Domain.Enum;
using Sitemap = DashboardApi.Core.Domain.Entities.SitemapEntity;
using DashboardApi.Core.Domain.Entities;

namespace DashboardApi.Tests.Sitemap
{
    public class GetSitemapQueryTests
    {
        private readonly Mock<ISitemapRepository> _sitemapRepositoryMock;

        public GetSitemapQueryTests()
        {
            _sitemapRepositoryMock = new Mock<ISitemapRepository>();
        }

        [Fact]
        public void Execute_ShouldReturnAllSitemaps_WhenUserHasHighestRole()
        {
            // Arrange
            var sitemaps = new List<SitemapEntity>
            {
                new() { Id = Guid.NewGuid(), Slug = "/", Description = "Home Page", PageName = "Home", AccessByRole = EnumUserRole.Admin },
                new() { Id = Guid.NewGuid(), AccessByRole = EnumUserRole.StandardUser, Description = "About Us", PageName = "About", Slug = "/about" },
                new() { Id = Guid.NewGuid(), AccessByRole = EnumUserRole.Guest, Description = "Contact Us", PageName = "Contact", Slug = "/contact" }                
            };
            _sitemapRepositoryMock.Setup(static repo => repo.GetAllSitemapItems()).Returns(sitemaps);

            var query = new GetSitemapQuery(_sitemapRepositoryMock.Object);

            // Act
            var result = query.Execute(EnumUserRole.Admin);

            // Assert
            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void Execute_ShouldReturnOnlyGuestSitemaps_WhenUserHasLowestRole()
        {
            // Arrange
           var sitemaps = new List<SitemapEntity>
            {
                new() { Id = Guid.NewGuid(), Slug = "/", Description = "Home Page", PageName = "Home", AccessByRole = EnumUserRole.Admin },
                new() { Id = Guid.NewGuid(), AccessByRole = EnumUserRole.StandardUser, Description = "About Us", PageName = "About", Slug = "/about" },
                new() { Id = Guid.NewGuid(), AccessByRole = EnumUserRole.Guest, Description = "Contact Us", PageName = "Contact", Slug = "/contact" }                
            };
            _sitemapRepositoryMock.Setup(repo => repo.GetAllSitemapItems()).Returns(sitemaps);

            var query = new GetSitemapQuery(_sitemapRepositoryMock.Object);

            // Act
            var result = query.Execute(EnumUserRole.Guest);

            // Assert
            Assert.Single(result); // Guest should only access Guest sitemaps
            Assert.Contains(result, r => r.AccessByRole == EnumUserRole.Guest);
            Assert.DoesNotContain(result, r => r.AccessByRole == EnumUserRole.StandardUser);
        }
    }
}
