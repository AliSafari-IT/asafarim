using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace ASafariM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogsController : ControllerBase
    {
        private static readonly object _lock = new object();

        [HttpPost]
        public IActionResult Log(LogMessage logMessage)
        {
            var logDirectory =
                (Environment.GetEnvironmentVariable("ASAFARIM_ENV") == "production")
                    ? "/var/www/asafarim/logs"
                    : "E:/ASafariM/Logs";

            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            var logFilePath = Path.Combine(logDirectory, $"log-ui_{DateTime.Now:yyyyMMdd}.log");

            // Format the log message with a timestamp and level
            var formattedMessage =
                $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} [{logMessage.Level}] {logMessage.Message}{Environment.NewLine}";

            lock (_lock)
            {
                System.IO.File.AppendAllText(logFilePath, formattedMessage);
            }

            return Ok();
        }
    }

    public class LogMessage
    {
        public string? Message { get; set; }
        public string? Level { get; set; }
    }
}
