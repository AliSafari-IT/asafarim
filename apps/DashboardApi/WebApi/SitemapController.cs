using Core.Application.Sitemaps.Queries;
using DashboardApi.Core.Domain.Entities;
using DashboardApi.Core.Domain.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace DashboardApi.WebApi
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]  // Ensure this endpoint is only accessible with JWT authentication
    public class SitemapController : ControllerBase
    {
        private readonly GetSitemapQuery _getSitemapQuery;

        public SitemapController(GetSitemapQuery getSitemapQuery)
        {
            _getSitemapQuery = getSitemapQuery;
        }

        // Example: Fetch sitemap for a logged-in user (with a given role)
        [HttpGet]
        public IActionResult GetSitemap(EnumUserRole roleIndex)
        {
            IEnumerable<SitemapEntity> sitemapItems = _getSitemapQuery.Execute(roleIndex);

            if (sitemapItems == null)
            {
                return NotFound();
            }

            return Ok(sitemapItems);
        }
    }
}
