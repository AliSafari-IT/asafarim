using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Serilog;

namespace ASafariM.Presentation.Controllers
{
    /// <summary>
    /// Provides health status information for the application.
    /// </summary>
    /// <remarks>
    /// This controller returns various health metrics including service status,
    /// uptime, memory and CPU usage, disk space, environment details, and active threads.
    /// </remarks>
    [ApiController]
    [Route("api/system-health")]
    public class HealthCheckController : ControllerBase
    {
        private readonly string _connectionString = string.Empty;

        public HealthCheckController(IConfiguration configuration)
        {
            _connectionString =
                configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
        }

        [HttpGet]
        public IActionResult GetHealthStatus()
        {
            try
            {
                Log.Information("Starting health check");
                var healthStatus = new
                {
                    status = "healthy",
                    version = "1.0.0",
                    buildDate = GetBuildDate(),
                    buildCommit = GetGitCommitHash()?.Substring(0, 8),
                    buildBranch = GetGitBranchName(),
                    buildAuthor = "A. Safari M.",
                    timestamp = DateTime.UtcNow,
                    services = new
                    {
                        database = CheckDatabaseHealth(),
                        cache = CheckCacheHealth(),
                        session = CheckSessionHealth(),
                        api = "healthy",
                    },
                    uptime = GetUptime(),
                    memoryUsage = GetMemoryUsage(),
                    cpuUsage = GetCpuUsage(),
                    diskSpace = GetDiskSpace(),
                    environment = GetEnvironmentDetails(),
                    activeThreads = GetActiveThreads(),
                };

                Log.Information("Health check completed successfully");
                return Ok(healthStatus);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Health check failed");
                return StatusCode(500, new { status = "unhealthy", error = ex.Message });
            }
        }

        private string GetUptime()
        {
            try
            {
                var uptime =
                    DateTime.UtcNow - Process.GetCurrentProcess().StartTime.ToUniversalTime();
                var uptimeStr = uptime.ToString(@"dd\.hh\:mm\:ss");
                Log.Debug("System uptime: {Uptime}", uptimeStr);
                return uptimeStr;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to retrieve uptime");
                return "Unknown";
            }
        }

        private object GetMemoryUsage()
        {
            try
            {
                var process = Process.GetCurrentProcess();
                var memoryInfo = new
                {
                    totalAllocated = $"{GC.GetTotalMemory(false) / 1024 / 1024} MB",
                    used = $"{process.PrivateMemorySize64 / 1024 / 1024} MB",
                    workingSet = $"{process.WorkingSet64 / 1024 / 1024} MB",
                    peakPagedMemory = $"{process.PeakPagedMemorySize64 / 1024 / 1024} MB",
                };

                Log.Debug("Memory usage: {@MemoryInfo}", memoryInfo);
                return memoryInfo;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to retrieve memory usage");
                return new { error = "Memory usage could not be retrieved" };
            }
        }

        private object GetCpuUsage()
        {
            try
            {
                var process = Process.GetCurrentProcess();
                var startCpuUsage = process.TotalProcessorTime;
                var startTime = DateTime.UtcNow;

                Thread.Sleep(500); // Allow time for CPU calculation

                var endCpuUsage = process.TotalProcessorTime;
                var endTime = DateTime.UtcNow;
                var cpuUsedMs = (endCpuUsage - startCpuUsage).TotalMilliseconds;
                var elapsedMs = (endTime - startTime).TotalMilliseconds;
                var cpuUsage = Math.Round((cpuUsedMs / elapsedMs) * 100, 2);

                Log.Debug("CPU usage: {CpuUsage}%", cpuUsage);
                return $"{cpuUsage} %";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to retrieve CPU usage");
                return "Unknown";
            }
        }

        private object GetDiskSpace()
        {
            try
            {
                var rootDrive = DriveInfo
                    .GetDrives()
                    .FirstOrDefault(d =>
                        d.IsReady && d.Name == Path.GetPathRoot(Environment.CurrentDirectory)
                    );
                if (rootDrive == null)
                    return "Drive not available";

                var diskInfo = new
                {
                    rootDrive.Name,
                    totalSpace = $"{rootDrive.TotalSize / 1024 / 1024 / 1024} GB",
                    freeSpace = $"{rootDrive.TotalFreeSpace / 1024 / 1024 / 1024} GB",
                };
                Log.Debug("Disk space info: {@DiskInfo}", diskInfo);
                return diskInfo;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to retrieve disk space");
                return "Unknown";
            }
        }

        private object GetEnvironmentDetails()
        {
            try
            {
                var envDetails = new
                {
                    machineName = Environment.MachineName,
                    osVersion = Environment.OSVersion.ToString(),
                    frameworkVersion = System
                        .Runtime
                        .InteropServices
                        .RuntimeInformation
                        .FrameworkDescription,
                    processArchitecture = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString(),
                    environmentVariables = Environment
                        .GetEnvironmentVariables()
                        .Keys.Cast<string>()
                        .Take(5)
                        .ToDictionary(k => k, k => Environment.GetEnvironmentVariable(k)),
                };

                Log.Debug("Environment details: {@EnvDetails}", envDetails);
                return envDetails;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to retrieve environment details");
                return "Unknown";
            }
        }

        private object GetActiveThreads()
        {
            try
            {
                var threadCount = Process.GetCurrentProcess().Threads.Count;
                Log.Debug("Active threads: {ThreadCount}", threadCount);
                return new { threadCount };
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to retrieve thread count");
                return "Unknown";
            }
        }

        private string CheckDatabaseHealth()
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                Log.Error("Database health check failed: Connection string is not configured");
                return "unhealthy (no connection string)";
            }

            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    // First try to connect
                    try
                    {
                        Log.Debug("Attempting to open database connection");
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex, "Database connection failed");
                        return $"unhealthy (connection failed)";
                    }

                    // Then try to execute a simple query
                    try
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "SELECT 1";
                            command.CommandTimeout = 5; // 5 seconds timeout
                            command.ExecuteScalar();
                        }
                        Log.Information("Database health check successful");
                        return "healthy";
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex, "Database query failed");
                        return $"unhealthy (query failed)";
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Database health check failed with general error");
                return $"unhealthy (general error)";
            }
        }

        private string CheckCacheHealth()
        {
            Log.Debug("Cache health check not implemented");
            return "healthy";
        }

        private string CheckSessionHealth()
        {
            Log.Debug("Session health check not implemented");
            return "healthy";
        }

        private string GetBuildDate()
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Log.Debug("Build date: {BuildDate}", date);
            return date;
        }

        private string GetGitCommitHash()
        {
            try
            {
                // Try multiple possible locations for the .git directory
                var possiblePaths = new[]
                {
                    "/var/www/asafarim", // Main project directory
                    Directory.GetCurrentDirectory(), // Current directory
                    Path.GetDirectoryName(Directory.GetCurrentDirectory()), // Parent of current directory
                    Environment.GetEnvironmentVariable("GIT_DIR"), // From environment variable
                }
                    .Where(p => !string.IsNullOrEmpty(p))
                    .Select(p => Path.Combine(p, ".git", "HEAD"))
                    .Where(p => System.IO.File.Exists(p));

                Log.Debug("Searching for git info in: {Paths}", string.Join(", ", possiblePaths));

                foreach (var gitHeadPath in possiblePaths)
                {
                    Log.Debug("Checking git path: {GitPath}", gitHeadPath);
                    var refPath = System.IO.File.ReadAllText(gitHeadPath).Trim();

                    if (refPath.StartsWith("ref: "))
                    {
                        // It's a reference, follow it
                        var gitDir = Path.GetDirectoryName(gitHeadPath); // Path to .git directory
                        if (gitDir == null)
                        {
                            Log.Warning(
                                "Could not determine git directory from path: {GitPath}",
                                gitHeadPath
                            );
                            continue;
                        }

                        var branchRef = refPath.Substring(5).Trim(); // Remove "ref: "
                        if (string.IsNullOrEmpty(branchRef))
                        {
                            Log.Warning("Branch reference is empty");
                            continue;
                        }

                        // Try in .git directory
                        var commitPath = Path.Combine(gitDir, branchRef);
                        if (System.IO.File.Exists(commitPath))
                        {
                            var hash = System.IO.File.ReadAllText(commitPath).Trim();
                            Log.Debug("Found commit hash in {Path}: {Hash}", commitPath, hash);
                            return hash;
                        }

                        // Try in .git/refs directory
                        commitPath = Path.Combine(gitDir, "refs", branchRef);
                        if (System.IO.File.Exists(commitPath))
                        {
                            var hash = System.IO.File.ReadAllText(commitPath).Trim();
                            Log.Debug("Found commit hash in refs: {Hash}", hash);
                            return hash;
                        }

                        Log.Warning("Could not find commit file at {Path}", commitPath);
                    }
                    else
                    {
                        // It's a direct commit hash
                        Log.Debug("Found direct commit hash: {Hash}", refPath);
                        return refPath;
                    }
                }

                // If we get here, try to get it from an environment variable
                var envCommit = Environment.GetEnvironmentVariable("GIT_COMMIT");
                if (!string.IsNullOrEmpty(envCommit))
                {
                    Log.Debug("Found commit hash from environment: {Hash}", envCommit);
                    return envCommit;
                }

                Log.Warning("Could not find git commit hash in any location");
                return "Unknown";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to retrieve Git commit hash");
                return "Unknown";
            }
        }

        private string GetGitBranchName()
        {
            Log.Debug("Using hardcoded branch name: main");
            return "main"; // Change this dynamically if needed
        }
    }
}
