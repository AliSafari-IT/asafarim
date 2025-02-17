using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
            // Specify the log directory path
            string logDirectoryPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "logs"
            );

            // Log the directory path
            _logger.LogInformation("Log directory path: {LogDirectoryPath}", logDirectoryPath);

            // Get the log file matching the pattern
            var logFiles = Directory.GetFiles(logDirectoryPath, "api*.log");

            if (logFiles.Length == 0)
            {
                _logger.LogWarning("No log files found matching the pattern 'api*.log' in directory: {LogDirectoryPath}", logDirectoryPath);
                return NotFound("Log file not found.");
            }

            // Use the first matching log file
            string logFilePath = logFiles.First();

            // Log the file path
            _logger.LogInformation("Log file path: {LogFilePath}", logFilePath);

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