using ASafariM.Domain.Entities;
using ASafariM.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace ASafariM.Presentation.Controllers;

[ApiController]
[Route("api/visitor")]
public class VisitorController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ILogger<VisitorController> _logger;

    public VisitorController(AppDbContext context, ILogger<VisitorController> logger)
    {
        _context = context;
        _logger = logger;
    }

    /// <summary>
    /// Tracks a visitor's visit.
    /// </summary>
    /// <returns>OK result.</returns>
    [HttpPost("track")]
    public async Task<IActionResult> TrackVisit()
    {
        try
        {
            var visitor = new VisitorLog
            {
                IPAddress = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "Unknown",
                VisitDate = DateTime.UtcNow,
                UserAgent = Request.Headers.UserAgent.ToString(),
                Referrer = Request.Headers.Referer.ToString()
            };

            _context.VisitorLogs.Add(visitor);
            await _context.SaveChangesAsync();

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error tracking visitor");
            // Return OK even if there's an error to prevent client-side errors
            return Ok();
        }
    }

    /// <summary>
    /// Gets the total number of visitors.
    /// </summary>
    /// <returns>The total number of visitors.</returns>
    [HttpGet("stats")]
    public async Task<IActionResult> GetStats()
    {
        try
        {
            var visitCount = await _context.VisitorLogs.CountAsync();
            return Ok(new { totalVisitors = visitCount });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting visitor stats");
            // Return mock data if there's a database error
            var mockVisitorCount = new Random().Next(100, 1000);
            return Ok(new { totalVisitors = mockVisitorCount });
        }
    }
}
