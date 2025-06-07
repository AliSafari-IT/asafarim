import React, { useEffect, useState } from "react";
import { getVisitorStats } from "../../services/analyticsService";
import Layout from "../../layout/Layout";
import Header from "../../layout/Header/Header";
import Footer from "../../layout/Footer/Footer";
import "./AnalyticsPage.css";
import { ChartMultipleRegular, PeopleCommunityRegular, HistoryRegular } from "@fluentui/react-icons";
import { logger } from "@/utils/logger";

interface VisitorData {
  totalVisitors: number;
}

const AnalyticsPage: React.FC = () => {
  const [visitorData, setVisitorData] = useState<VisitorData>({ totalVisitors: 0 });
  const [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
    const fetchAnalyticsData = async () => {
      try {
        setLoading(true);
        const data = await getVisitorStats();
        setVisitorData({ totalVisitors: data?.totalVisitors || 0 });
      } catch (error) {
        logger.error("Error fetching analytics data:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchAnalyticsData();
  }, []);

  return (
    <Layout header={<Header />} footer={<Footer />}>
      <div className="analytics-container">
        <h1 className="analytics-title">Visitor Analytics</h1>
        
        {loading ? (
          <div className="analytics-loading">
            <div className="loading-spinner"></div>
            <p>Loading analytics data...</p>
          </div>
        ) : (
          <div className="analytics-content">
            <div className="analytics-overview">
              <p className="overview-description">
                Welcome to the Analytics Dashboard. Here you can monitor visitor traffic and engagement metrics for your application.
              </p>
            </div>

            <div className="analytics-cards">
              <div className="analytics-card">
                <div className="card-icon">
                  <PeopleCommunityRegular fontSize={32} />
                </div>
                <div className="card-content">
                  <h3>Total Visitors</h3>
                  <p className="card-value">{visitorData.totalVisitors.toLocaleString()}</p>
                  <p className="card-description">Unique visitors to your application</p>
                </div>
              </div>

              <div className="analytics-card">
                <div className="card-icon">
                  <ChartMultipleRegular fontSize={32} />
                </div>
                <div className="card-content">
                  <h3>Page Views</h3>
                  <p className="card-value">{(visitorData.totalVisitors * 3.5).toFixed(0).toLocaleString()}</p>
                  <p className="card-description">Total page views across all visitors</p>
                </div>
              </div>

              <div className="analytics-card">
                <div className="card-icon">
                  <HistoryRegular fontSize={32} />
                </div>
                <div className="card-content">
                  <h3>Avg. Session Duration</h3>
                  <p className="card-value">2m 45s</p>
                  <p className="card-description">Average time spent on your application</p>
                </div>
              </div>
            </div>

            <div className="analytics-chart-container">
              <h2>Visitor Trends</h2>
              <div className="analytics-chart-placeholder">
                <p>Detailed analytics charts will be available in a future update.</p>
                <p>Currently displaying mock data for demonstration purposes.</p>
              </div>
            </div>
          </div>
        )}
      </div>
    </Layout>
  );
};

export default AnalyticsPage;
