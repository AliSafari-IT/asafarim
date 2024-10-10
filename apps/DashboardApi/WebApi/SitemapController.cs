using Core.Application.Sitemaps.Queries;
using Core.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApi.Controllers
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

        // Example: Fetch sitemap for a logged-in user
        [HttpGet]
        public IActionResult GetSitemap(Role userRole)
        {
            IEnumerable<Sitemap> sitemapItems = _getSitemapQuery.Execute(userRole);

            if (sitemapItems == null)
            {
                return NotFound();
            }

            return Ok(sitemapItems);
        }
    }
}
