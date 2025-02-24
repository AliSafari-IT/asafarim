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
            string logDirectoryPath =
                Environment.GetEnvironmentVariable("ASAFARIM_ENV") == "production"
                    ? "/var/www/asafarim/logs"
                    : "D:/repos/ASafariM/Logs";

            // Log the directory path
            _logger.LogInformation("Log directory path: {LogDirectoryPath}", logDirectoryPath);

            // Get the log file matching the pattern
            var logFiles = Directory
                .GetFiles(logDirectoryPath, "api*.log")
                .OrderByDescending(f => f)
                .ToArray(); // Most recent files first

            if (logFiles.Length == 0)
            {
                _logger.LogWarning(
                    "No log files found matching the pattern 'api*.log' in directory: {LogDirectoryPath}",
                    logDirectoryPath
                );
                return NotFound("Log file not found.");
            }

            // Combine all log files
            var combinedLogs = new StringBuilder();
            foreach (var logFile in logFiles)
            {
                // Log the file path
                _logger.LogInformation("Reading log file: {LogFilePath}", logFile);

                // Read and append the log file content
                string content = System.IO.File.ReadAllText(logFile, Encoding.UTF8);
                combinedLogs.AppendLine($"=== Log File: {Path.GetFileName(logFile)} ===");
                combinedLogs.AppendLine(content);
                combinedLogs.AppendLine();
            }

            // Return the combined log content as plain text
            return Content(combinedLogs.ToString(), "text/plain", Encoding.UTF8);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving logs");
            return StatusCode(500, "Internal server error.");
        }
    }

    [HttpPost]
    public IActionResult PostLog([FromBody] LogMessage message)
    {
        if (message == null || string.IsNullOrEmpty(message.Message))
        {
            return BadRequest("Log message cannot be empty");
        }

        try
        {
            _logger.LogInformation(
                "Received log message: {Message} with level {Level}",
                message.Message,
                message.Level ?? "INFO"
            );

            return Ok(new { message = "Log received successfully" });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing log message");
            return StatusCode(500, new { error = "Failed to process log message" });
        }
    }
}

public class LogMessage
{
    public string Message { get; set; }
    public string Level { get; set; }
}
