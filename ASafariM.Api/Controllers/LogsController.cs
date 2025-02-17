using System.IO;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Serilog;

[ApiController]
[Route("api/[controller]")]
public class LogsController : ControllerBase
{
    private readonly ILogger<LogsController> _logger;

    public LogsController(ILogger<LogsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetLogs()
    {
        try
        {
            // Specify the log file path
            string logFilePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "logs",
                "api.log"
            );

            if (!System.IO.File.Exists(logFilePath))
            {
                return NotFound("Log file not found.");
            }

            // Read the log file content
            string logContent = System.IO.File.ReadAllText(logFilePath, Encoding.UTF8);

            // Return the log content as plain text
            return Content(logContent, "text/plain", Encoding.UTF8);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving logs");
            return StatusCode(500, "Internal server error.");
        }
    }
}
