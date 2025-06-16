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
    [Route("api/health")]
    public class HealthCheckController : ControllerBase
    {
        private readonly string _connectionString = string.Empty;

        public HealthCheckController(IConfiguration configuration)
        {
            _connectionString =
                configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
        }

        /// <summary>
        /// Retrieves health status information for the application.
        /// </summary>
        /// <returns>Health status information</returns>
    [HttpGet]
    public IActionResult GetHealthStatus()
    {
        try
        {
            Log.Information("Starting health check");

            // Safely get the git commit hash
            string commitHash;
            try
            {
                commitHash = GetGitCommitHash();
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Failed to get git commit hash");
                commitHash = "N/A";
            }

            var healthStatus = new
            {
                status = "healthy",
                version = "1.0.0",
                buildDate = GetBuildDate(),
                buildCommit = commitHash,
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

        /// <summary>
        /// Retrieves the uptime of the application.
        /// </summary>
        /// <returns>The uptime of the application</returns>
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

        /// <summary>
        /// Retrieves the memory usage of the application.
        /// </summary>
        /// <returns>The memory usage of the application</returns>
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

        /// <summary>
        /// Retrieves the CPU usage of the application.
        /// </summary>
        /// <returns>The CPU usage of the application</returns>
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

        /// <summary>
        /// Retrieves the disk space of the application.
        /// </summary>
        /// <returns>The disk space of the application</returns>
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

        /// <summary>
        /// Retrieves the environment details of the application.
        /// </summary>
        /// <returns>The environment details of the application</returns>
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

        /// <summary>
        /// Retrieves the active thread count of the application.
        /// </summary>
        /// <returns>The active thread count of the application</returns>
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

        /// <summary>
        /// Checks the health of the database.
        /// </summary>
        /// <returns>Health status of the database</returns>
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

        /// <summary>
        /// Checks the health of the cache.
        /// </summary>
        /// <returns>Health status of the cache</returns>
        private string CheckCacheHealth()
        {
            Log.Debug("Cache health check not implemented");
            return "healthy";
        }

        /// <summary>
        /// Checks the health of the session.
        /// </summary>
        /// <returns>Health status of the session</returns>
        private string CheckSessionHealth()
        {
            Log.Debug("Session health check not implemented");
            return "healthy";
        }

        /// <summary>
        /// Retrieves the build date of the application.
        /// </summary>
        /// <returns>The build date of the application</returns>
        private string GetBuildDate()
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Log.Debug("Build date: {BuildDate}", date);
            return date;
        }

        /// <summary>
        /// Retrieves the Git commit hash of the application.
        /// </summary>
        /// <returns>The Git commit hash of the application</returns>
        private string GetGitCommitHash()
        {
            try
            {
                // Try to get it from an environment variable first
                var envCommit = Environment.GetEnvironmentVariable("GIT_COMMIT");
                if (!string.IsNullOrEmpty(envCommit))
                {
                    Log.Debug("Found commit hash from environment: {Hash}", envCommit);
                    return envCommit;
                }

                // Try multiple possible locations for the .git directory
                var possiblePaths = new[]
                {
                    "/var/www/asafarim.be/asafarim", // Main project directory
                    Directory.GetCurrentDirectory(), // Current directory
                    Path.GetDirectoryName(Directory.GetCurrentDirectory()), // Parent of current directory
                    Environment.GetEnvironmentVariable("GIT_DIR"), // From environment variable
                }
                .Where(p => !string.IsNullOrEmpty(p))
                .Select(p => Path.Combine(p, ".git", "HEAD"))
                .Where(p => System.IO.File.Exists(p))
                .ToList();

                Log.Debug("Searching for git info in: {Paths}", string.Join(", ", possiblePaths));

                foreach (var gitHeadPath in possiblePaths)
                {
                    try
                    {
                        Log.Debug("Checking git path: {GitPath}", gitHeadPath);
                        var refPath = System.IO.File.ReadAllText(gitHeadPath).Trim();

                        if (string.IsNullOrEmpty(refPath))
                        {
                            Log.Warning("HEAD file is empty at {GitPath}", gitHeadPath);
                            continue;
                        }

                        if (refPath.StartsWith("ref: "))
                        {
                            var gitDir = Path.GetDirectoryName(gitHeadPath);
                            if (gitDir == null)
                            {
                                Log.Warning("Could not determine git directory from path: {GitPath}", gitHeadPath);
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
                                if (!string.IsNullOrEmpty(hash))
                                {
                                    Log.Debug("Found commit hash in {Path}: {Hash}", commitPath, hash);
                                    return hash;
                                }
                            }

                            // Try in .git/refs directory
                            commitPath = Path.Combine(gitDir, "refs", branchRef);
                            if (System.IO.File.Exists(commitPath))
                            {
                                var hash = System.IO.File.ReadAllText(commitPath).Trim();
                                if (!string.IsNullOrEmpty(hash))
                                {
                                    Log.Debug("Found commit hash in refs: {Hash}", hash);
                                    return hash;
                                }
                            }

                            Log.Warning("Could not find commit file at {Path}", commitPath);
                        }
                        else if (!string.IsNullOrEmpty(refPath))
                        {
                            // It's a direct commit hash
                            Log.Debug("Found direct commit hash: {Hash}", refPath);
                            return refPath;
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Warning(ex, "Failed to process git path: {GitPath}", gitHeadPath);
                        // Continue to next path
                    }
                }

                Log.Warning("Could not find git commit hash in any location");
                return string.Empty;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to retrieve Git commit hash");
                return string.Empty;
            }
        }

        private string GetGitBranchName()
        {
            Log.Debug("Using hardcoded branch name: main");
            return "main"; // Change this dynamically if needed
        }
    }
}
