using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("api/logs")]
public class LogsController : ControllerBase
{
    private readonly ILogger<LogsController> _logger;
    private const int DefaultPageSize = 1000; // Number of lines per page
    private const int MaxPageSize = 5000;

    public string Message { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;

    public LogsController(ILogger<LogsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetLogs(
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = DefaultPageSize
    )
    {
        try
        {
            pageSize = Math.Min(pageSize, MaxPageSize);
            string logDirectoryPath =
                Environment.GetEnvironmentVariable("ASAFARIM_ENV") == "production"
                    ? "/var/www/asafarim/logs"
                    : "D:/repos/ASafariM/Logs";

            var logFiles = Directory
                .GetFiles(logDirectoryPath, "*.log")
                .OrderByDescending(f => f)
                .ToArray();

            if (!logFiles.Any())
            {
                _logger.LogWarning(
                    "No log files found in directory: {LogDirectoryPath}",
                    logDirectoryPath
                );
                return NotFound("No log files found.");
            }

            Response.ContentType = "text/plain";
            Response.Headers["X-Total-Files"] = logFiles.Length.ToString();

            // Stream the response
            return new FileCallbackResult(
                "text/plain",
                async (stream, _) =>
                {
                    var writer = new StreamWriter(stream, Encoding.UTF8);
                    foreach (var logFile in logFiles)
                    {
                        await writer.WriteLineAsync(
                            $"=== Log File: {Path.GetFileName(logFile)} ==="
                        );

                        using var fileStream = new FileStream(
                            logFile,
                            FileMode.Open,
                            FileAccess.Read,
                            FileShare.ReadWrite
                        );
                        using var reader = new StreamReader(fileStream, Encoding.UTF8);

                        string line;
                        var currentLine = 0;
                        var startLine = (page - 1) * pageSize;
                        var endLine = page * pageSize;

                        while ((line = await reader.ReadLineAsync()) != null)
                        {
                            if (currentLine >= startLine && currentLine < endLine)
                            {
                                await writer.WriteLineAsync(line);
                            }
                            else if (currentLine >= endLine)
                            {
                                break;
                            }
                            currentLine++;
                        }

                        await writer.WriteLineAsync();
                        await writer.FlushAsync();
                    }
                }
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving logs");
            return StatusCode(500, "Internal server error.");
        }
    }

    [HttpPost]
    public async Task<IActionResult> PostLog([FromBody] LogMessage message)
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

// Custom FileCallbackResult for streaming response
public class FileCallbackResult : FileResult
{
    private readonly Func<Stream, ActionContext, Task> _callback;

    public FileCallbackResult(string contentType, Func<Stream, ActionContext, Task> callback)
        : base(contentType)
    {
        _callback = callback;
    }

    public override async Task ExecuteResultAsync(ActionContext context)
    {
        var response = context.HttpContext.Response;
        response.ContentType = ContentType;

        await _callback(response.Body, context);
    }
}
