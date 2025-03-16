import React, { useEffect, useState } from "react";
import Layout from "../../layout/Layout";
import Footer from "../../layout/Footer/Footer";
import apiUrls from "@/api/getApiUrls";
import "./HealthCheck.css";
import { logger } from "@/utils/logger";

interface HealthStatus {
  status: string;
  version: string;
  buildDate: string;
  buildCommit: string;
  buildBranch: string;
  buildAuthor: string;
  timestamp: string;
  services?: {
    database: string;
    cache: string;
    session: string;
    api: string;
  };
  uptime?: string;
  memoryUsage?: {
    totalAllocated: string;
    used: string;
    workingSet: string;
    peakPagedMemory: string;
  };
  cpuUsage?: string;
  diskSpace?: {
    name: string;
    totalSpace: string;
    freeSpace: string;
  };
  environment?: {
    machineName: string;
    osVersion: string;
    frameworkVersion: string;
    processArchitecture: string;
    environmentVariables?: Record<string, string>;
  };
  activeThreads?: {
    threadCount: number;
  };
}

const formatValue = (value: string | number) => {
  if (typeof value === "number") {
    return value.toFixed(2);
  }
  return value;
};

const HealthCheck: React.FC = () => {
  const [healthData, setHealthData] = useState<HealthStatus | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [lastUpdated, setLastUpdated] = useState<string>("");

  useEffect(() => {
    const fetchHealthStatus = async () => {
      const baseUrl = apiUrls(window.location.hostname);
      try {
        const response = await fetch(`${baseUrl}/health`);
        if (!response.ok) {
          throw new Error("Health check failed");
        }
        const data = await response.json();
        setHealthData(data);
        setLastUpdated(new Date().toLocaleTimeString());
      } catch (err) {
        setError(
          err instanceof Error ? err.message : "Failed to fetch health status"
        );
      } finally {
        setLoading(false);
      }
    };

    fetchHealthStatus();
    const interval = setInterval(fetchHealthStatus, 30000);
    return () => clearInterval(interval);
  }, []);

  if (loading) {
    return (
      <Layout header={<></>} footer={<Footer />}>
        <div className="health-check__loading">
          <div className="health-check__spinner"></div>
          <p>Loading system health data...</p>
        </div>
      </Layout>
    );
  }

  if (error) {
    return (
      <Layout header={<></>} footer={<Footer />}>
        <div className="health-check__container">
          <div className="health-check__error">
            <h2>Error Loading Health Data</h2>
            <p>{error}</p>
            <button 
              className="health-check__retry-button"
              onClick={() => window.location.reload()}
            >
              Retry
            </button>
          </div>
        </div>
      </Layout>
    );
  }

  return (
    <Layout header={<></>} footer={<Footer />}>
      <div className="health-check__container">
        <div className="health-check__content">
          <div className="health-check__header">
            <h1 className="health-check__title">System Health Dashboard</h1>
            <div className="health-check__refresh-info">
              <span>Last updated: {lastUpdated}</span>
              <button 
                className="health-check__refresh-button"
                onClick={() => window.location.reload()}
                title="Refresh data"
              >
                ↻
              </button>
            </div>
          </div>

          {healthData && (
            <>
              {/* System Status Banner */}
              <div className="health-check__status-banner">
                <div
                  className={`health-check__status-indicator ${
                    healthData.status === "healthy" ? "healthy" : "unhealthy"
                  }`}
                ></div>
                <div className="health-check__status-details">
                  <h2 className="health-check__status-text">
                    System Status: {healthData.status.toUpperCase()}
                  </h2>
                  <p className="health-check__status-timestamp">
                    As of {new Date(healthData.timestamp).toLocaleString()}
                    {healthData.uptime && ` • Uptime: ${healthData.uptime}`}
                  </p>
                </div>
              </div>

              {/* Main Dashboard Grid */}
              <div className="health-check__dashboard">
                {/* Left Column - System & Services */}
                <div className="health-check__column">
                  {/* System Information */}
                  <div className="health-check__card system-info">
                    <h2>System Information</h2>
                    <div className="health-check__card-content">
                      <p>
                        <span>Version</span>
                        <span>{healthData.version}</span>
                      </p>
                      <p>
                        <span>Build Date</span>
                        <span>{healthData.buildDate}</span>
                      </p>
                      <p>
                        <span>Build Commit</span>
                        <span className="truncate-text" title={healthData.buildCommit}>
                          {healthData.buildCommit}
                        </span>
                      </p>
                      <p>
                        <span>Build Branch</span>
                        <span>{healthData.buildBranch}</span>
                      </p>
                      <p>
                        <span>Build Author</span>
                        <span>{healthData.buildAuthor}</span>
                      </p>
                    </div>
                  </div>

                  {/* Services Status */}
                  {healthData.services && (
                    <div className="health-check__card services">
                      <h2>Services Status</h2>
                      <div className="health-check__card-content">
                        {Object.entries(healthData.services).map(([key, value]) => (
                          <p key={key}>
                            <span>{key.charAt(0).toUpperCase() + key.slice(1)}</span>
                            <span className={`service-status ${value.toLowerCase()}`}>
                              {value}
                            </span>
                          </p>
                        ))}
                      </div>
                    </div>
                  )}

                  {/* Active Threads */}
                  {healthData.activeThreads && (
                    <div className="health-check__card threads">
                      <h2>Active Threads</h2>
                      <div className="health-check__card-content">
                        <div className="thread-count-display">
                          <div className="thread-count-value">
                            {healthData.activeThreads.threadCount}
                          </div>
                          <div className="thread-count-label">
                            Active Threads
                          </div>
                        </div>
                      </div>
                    </div>
                  )}
                </div>

                {/* Right Column - Resources */}
                <div className="health-check__column">
                  {/* CPU Usage */}
                  {healthData.cpuUsage && (
                    <div className="health-check__card resources">
                      <h2>CPU Usage</h2>
                      <div className="health-check__card-content">
                        <div className="health-check__cpu-usage">
                          <div className="resource-usage-label">
                            <span>Current Usage</span>
                            <span
                              className={`cpu-value ${
                                parseFloat(healthData.cpuUsage) > 80
                                  ? "high"
                                  : parseFloat(healthData.cpuUsage) > 50
                                  ? "medium"
                                  : "low"
                              }`}
                            >
                              {formatValue(healthData.cpuUsage)}%
                            </span>
                          </div>
                          <div className="cpu-usage-indicator">
                            <div
                              className={`cpu-usage-fill ${
                                parseFloat(healthData.cpuUsage) > 80
                                  ? "high"
                                  : parseFloat(healthData.cpuUsage) > 50
                                  ? "medium"
                                  : "low"
                              }`}
                              style={{
                                width: `${Math.min(parseFloat(healthData.cpuUsage), 100)}%`,
                              }}
                            ></div>
                          </div>
                        </div>
                      </div>
                    </div>
                  )}

                  {/* Memory Usage */}
                  {healthData.memoryUsage && (
                    <div className="health-check__card resources">
                      <h2>Memory Usage</h2>
                      <div className="health-check__card-content">
                        <div className="health-check__memory-grid">
                          {Object.entries(healthData.memoryUsage).map(([key, value]) => (
                            <div key={key} className="memory-item">
                              <div className="memory-icon">
                                <span className="memory-icon-symbol">
                                  {key.includes("total") ? "∑" : 
                                   key.includes("used") ? "↑" : 
                                   key.includes("working") ? "⚙" : "⚡"}
                                </span>
                              </div>
                              <div className="memory-details">
                                <p className="memory-label">
                                  {key.replace(/([A-Z])/g, " $1").trim()}
                                </p>
                                <p className="memory-value">{formatValue(value)}</p>
                              </div>
                            </div>
                          ))}
                        </div>
                      </div>
                    </div>
                  )}

                  {/* Disk Space */}
                  {healthData.diskSpace && (
                    <div className="health-check__card resources">
                      <h2>Disk Space</h2>
                      <div className="health-check__card-content">
                        <div className="disk-name">
                          <strong>Drive:</strong> {healthData.diskSpace.name}
                        </div>
                        <div className="disk-space-details">
                          <div className="disk-space-item">
                            <span>Total Space</span>
                            <span>{healthData.diskSpace.totalSpace}</span>
                          </div>
                          <div className="disk-space-item">
                            <span>Free Space</span>
                            <span>{healthData.diskSpace.freeSpace}</span>
                          </div>
                          {healthData.diskSpace.totalSpace && healthData.diskSpace.freeSpace && (
                            <div className="disk-usage-bar">
                              <div className="disk-usage-label">
                                <span>Used Space</span>
                                <span>
                                  {calculateDiskUsage(
                                    healthData.diskSpace.totalSpace,
                                    healthData.diskSpace.freeSpace
                                  )}%
                                </span>
                              </div>
                              <div className="disk-usage-indicator">
                                <div
                                  className="disk-usage-fill"
                                  style={{
                                    width: `${calculateDiskUsage(
                                      healthData.diskSpace.totalSpace,
                                      healthData.diskSpace.freeSpace
                                    )}%`,
                                  }}
                                ></div>
                              </div>
                            </div>
                          )}
                        </div>
                      </div>
                    </div>
                  )}
                </div>

                {/* Environment Details - Full Width */}
                {healthData.environment && (
                  <div className="health-check__card environment full-width">
                    <h2>Environment Details</h2>
                    <div className="health-check__card-content">
                      <div className="environment-grid">
                        {Object.entries(healthData.environment).map(([key, value]) => {
                          // Skip rendering if value is an object (like environmentVariables)
                          if (typeof value === 'object') return null;
                          return (
                            <div key={key} className="environment-item">
                              <span className="environment-label">
                                {key.replace(/([A-Z])/g, " $1").trim()}
                              </span>
                              <span className="environment-value">{String(value)}</span>
                            </div>
                          );
                        })}
                      </div>
                    </div>
                  </div>
                )}
              </div>
            </>
          )}
        </div>
      </div>
    </Layout>
  );
};

// Helper function to calculate disk usage percentage
const calculateDiskUsage = (totalSpace: string, freeSpace: string): number => {
  try {
    // Extract numeric values and convert to bytes
    const extractSize = (sizeStr: string): number => {
      const match = sizeStr.match(/(\d+(\.\d+)?)\s*(KB|MB|GB|TB)/i);
      if (!match) return 0;
      
      const value = parseFloat(match[1]);
      const unit = match[3].toUpperCase();
      
      const multipliers: Record<string, number> = {
        'KB': 1024,
        'MB': 1024 * 1024,
        'GB': 1024 * 1024 * 1024,
        'TB': 1024 * 1024 * 1024 * 1024
      };
      
      return value * (multipliers[unit] || 1);
    };
    
    const totalBytes = extractSize(totalSpace);
    const freeBytes = extractSize(freeSpace);
    
    if (totalBytes === 0) return 0;
    
    const usedPercentage = ((totalBytes - freeBytes) / totalBytes) * 100;
    return Math.round(usedPercentage);
  } catch (error) {
    logger.error("Error calculating disk usage:", error);
    return 0;
  }
};

export default HealthCheck;
