import React, { useEffect, useState } from "react";
import { getVisitorStats } from "../../services/analyticsService";
import "./Dashboard.css";
import { Link } from "@fluentui/react-components";
import { ChartMultipleRegular } from "@fluentui/react-icons";
import { logger } from "@/utils/logger";

const VisitorStats: React.FC = () => {
  const [visitorCount, setVisitorCount] = useState<number>(0);
  const [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
    const fetchStats = async () => {
      try {
        setLoading(true);
        const data = await getVisitorStats();
        setVisitorCount(data?.totalVisitors || 0);
      } catch (error) {
        logger.error("Error fetching visitor stats:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchStats();
  }, []);

  return (
    <div className="dashboard-section visitor-stats">
      <h2 className="dashboard-section-title">Visitor Analytics</h2>
      <div className="dashboard-section-content">
        {loading ? (
          <div className="loading-indicator">Loading visitor data...</div>
        ) : (
          <div className="visitor-status-indicator">
            <div className="visitor-icon">
              <ChartMultipleRegular fontSize={24} />
            </div>
            <div className="visitor-info">
              <p className="visitor-count">
                <span className="visitor-number">{visitorCount.toLocaleString()}</span> 
                <span className="visitor-label">Total Visitors</span>
              </p>
              <p className="visitor-description">
                Total number of unique visitors to your application
              </p>
              <Link href="/analytics">
                <button className="view-details-button">
                  View Analytics
                </button>
              </Link>
            </div>
          </div>
        )}
      </div>
    </div>
  );
};

export default VisitorStats;
