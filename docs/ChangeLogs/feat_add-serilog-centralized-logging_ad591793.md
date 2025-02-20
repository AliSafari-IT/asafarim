# Feature: Add Serilog for Centralized Logging with File Sink

Date 2025-02-05

## Description of Changes

Implemented comprehensive logging across the application using Serilog with structured log messages and file sink configuration. Key changes include:

### 1. Serilog Configuration in Program.cs
```csharp
var logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File(
        Path.Combine(logDirectory, "log_.txt"),
        rollingInterval: RollingInterval.Day,
        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] {Message}{NewLine}{Exception}"
    )
    .CreateLogger();
Log.Information("Logger configured successfully. → Path: {LogDirectory}", logDirectory);
```

### 2. Enhanced Controller Logging
Example from HealthCheckController:
```csharp
[HttpGet]
public IActionResult GetHealthStatus()
{
    try
    {
        Log.Information("Starting health check");
        var healthStatus = new { /* ... */ };
        Log.Information("Health check completed successfully");
        return Ok(healthStatus);
    }
    catch (Exception ex)
    {
        Log.Error(ex, "Health check failed");
        return StatusCode(500, new { status = "unhealthy", error = ex.Message });
    }
}
```

### 3. Structured Logging for Authentication
Example from AuthController:
```csharp
Log.Warning(
    "Login attempt for locked account. User ID: {UserId}, Email: {Email}, Minutes remaining: {Minutes}",
    user.Id,
    command.Email,
    lockoutTimeRemaining
);
```

### 4. Diagnostic Information Logging
Example from HealthCheckController:
```csharp
Log.Debug("Memory usage: {@MemoryInfo}", memoryInfo);
Log.Debug("CPU usage: {CpuUsage}%", cpuUsage);
Log.Debug("Disk space info: {@DiskInfo}", diskInfo);
```

## Impact

- Improved application monitoring and debugging capabilities
- Centralized logging with daily rolling file output
- Structured log messages for better log analysis
- Enhanced security logging for authentication events
- Comprehensive health check logging
- Consistent logging patterns across controllers

## Files Affected

1. `ASafariM.Api/Program.cs`
2. `ASafariM.Presentation/Controllers/HealthCheckController.cs`
3. `ASafariM.Presentation/Controllers/AuthController.cs`
4. `ASafariM.Presentation/Controllers/MarkdownFilesController.cs`
5. `ASafariM.Presentation/Controllers/PostsController.cs`

## Testing

1. **Log File Generation**
   - Verify log files are created in the configured directory
   - Confirm daily rolling file creation

2. **Log Content Verification**
   - Check structured log messages format
   - Verify timestamp and log level display
   - Confirm exception details are properly logged

3. **Security Logging**
   - Test failed login attempts logging
   - Verify account lockout logging
   - Check successful login logging

4. **Health Check Logging**
   - Verify system metrics logging
   - Test database connection logging
   - Check git information logging
