using ASafariM.Domain.Entities;
using ASafariM.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASafariM.Presentation.Controllers;

[ApiController]
[Route("api/visitor")]
public class VisitorController : ControllerBase
{
    private readonly AppDbContext _context;

    public VisitorController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("track")]
    public async Task<IActionResult> TrackVisit()
    {
        var visitor = new VisitorLog
        {
            IPAddress = HttpContext.Connection.RemoteIpAddress.ToString(),
            VisitDate = DateTime.UtcNow,
        };

        _context.VisitorLogs.Add(visitor);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpGet("stats")]
    public async Task<IActionResult> GetStats()
    {
        var visitCount = await _context.VisitorLogs.CountAsync();
        return Ok(new { totalVisitors = visitCount });
    }
}
