import React, { useEffect, useState } from "react";
import Layout from "../../layout/Layout";
import Footer from "../../layout/Footer/Footer";
import apiUrls from "@/api/getApiUrls";
import "./HealthCheck.css";

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
        </div>
      </Layout>
    );
  }

  if (error) {
    return (
      <Layout header={<></>} footer={<Footer />}>
        <div className="health-check__container">
          <div className="health-check__error">
            <p>{error}</p>
          </div>
        </div>
      </Layout>
    );
  }

  return (
    <Layout header={<></>} footer={<Footer />}>
      <div className="health-check__container">
        <div className="health-check__content">
          <h1 className="health-check__title">System Health Status</h1>

          {healthData && (
            <div className="health-check__grid">
              {/* System Status */}
              <div className="health-check__status">
                <div
                  className={`health-check__status-indicator ${
                    healthData.status === "healthy" ? "healthy" : "unhealthy"
                  }`}
                ></div>
                <span className="health-check__status-text">
                  System Status: {healthData.status}
                </span>
              </div>

              {/* System Information */}
              <div className="health-check__card">
                <h2>System Info</h2>
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
                  <span>{healthData.buildCommit}</span>
                </p>
                <p>
                  <span>Build Branch</span>
                  <span>{healthData.buildBranch}</span>
                </p>
                <p>
                  <span>Build Author</span>
                  <span>{healthData.buildAuthor}</span>
                </p>
                <p>
                  <span>Last Updated</span>
                  <span>{new Date(healthData.timestamp).toLocaleString()}</span>
                </p>
                {healthData.uptime && (
                  <p>
                    <span>Uptime</span>
                    <span>{healthData.uptime}</span>
                  </p>
                )}
              </div>

              {/* Services Status */}
              {healthData.services && (
                <div className="health-check__card">
                  <h2>Services Status</h2>
                  {Object.entries(healthData.services).map(([key, value]) => (
                    <p key={key}>
                      <span>{key.charAt(0).toUpperCase() + key.slice(1)}</span>
                      <span>{value}</span>
                    </p>
                  ))}
                </div>
              )}

              {/* CPU Usage */}
              {healthData.cpuUsage && (
                <div className="health-check__card">
                  <h2>CPU Usage</h2>
                  <div className="health-check__cpu-usage">
                    <div className="cpu-usage-indicator">
                      <div
                        className="cpu-usage-fill"
                        style={{
                          width: `${Math.min(parseFloat(healthData.cpuUsage), 100)}%`,
                        }}
                      ></div>
                    </div>
                    <p>
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
                    </p>
                  </div>
                </div>
              )}

              {/* Memory Usage */}
              {healthData.memoryUsage && (
                <div className="health-check__card">
                  <h2>Memory Usage</h2>
                  <div className="health-check__memory-grid">
                    {Object.entries(healthData.memoryUsage).map(([key, value]) => (
                      <div key={key}>
                        <p className="label">{key.replace(/([A-Z])/g, " $1")}</p>
                        <p className="value">{formatValue(value)}</p>
                      </div>
                    ))}
                  </div>
                </div>
              )}

              {/* Disk Space */}
              {healthData.diskSpace && (
                <div className="health-check__card">
                  <h2>Disk Space</h2>
                  {Object.entries(healthData.diskSpace).map(([key, value]) => (
                    <p key={key}>
                      <span>{key.replace(/([A-Z])/g, " $1")}</span>
                      <span>{value}</span>
                    </p>
                  ))}
                </div>
              )}

              {/* Environment Details */}
              {healthData.environment && (
                <div className="health-check__card">
                  <h2>Environment</h2>
                  {Object.entries(healthData.environment).map(([key, value]) => {
                    // Skip rendering if value is an object (like environmentVariables)
                    if (typeof value === 'object') return null;
                    return (
                      <p key={key}>
                        <span>{key.replace(/([A-Z])/g, " $1").trim()}</span>
                        <span>{String(value)}</span>
                      </p>
                    );
                  })}
                </div>
              )}

              {/* Active Threads */}
              {healthData.activeThreads && (
                <div className="health-check__card">
                  <h2>Active Threads</h2>
                  <p>
                    <span>Thread Count</span>
                    <span>{healthData.activeThreads.threadCount}</span>
                  </p>
                </div>
              )}
            </div>
          )}
        </div>
      </div>
    </Layout>
  );
};

export default HealthCheck;
