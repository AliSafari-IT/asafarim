import React from "react";
import Wrapper from "../../layout/Wrapper/Wrapper";
import { DashboardHeaderBlock } from "./DashboardHeaderBlock";
import { Link } from "@fluentui/react-components";
import QuickNavigation from "../../components/Navigation/QuickNavigation";
import "./Dashboard.css";
import VisitorStats from "./VisitorStats";

const Dashboard: React.FC = () => {
  return (
    <Wrapper header={<DashboardHeaderBlock />}>
      <div className="dashboard-container">
        {/* Main Content Area */}
        <div className="dashboard-content">
          {/* Quick Navigation Component */}
          <QuickNavigation />

          {/* Additional Dashboard Sections */}
          <div className="dashboard-additional-sections">
            <div className="dashboard-section health-status">
              <h2 className="dashboard-section-title">System Health</h2>
              <div className="dashboard-section-content">
                <div className="health-status-indicator">
                  <div className="status-icon healthy"></div>
                  <div className="status-info">
                    <p className="status-text">All systems operational</p>
                    <Link href="/health-check">
                      <button className="view-details-button">
                        View Details
                      </button>
                    </Link>
                  </div>
                </div>
              </div>
            </div>

            <div className="dashboard-section recent-activity">
              <h2 className="dashboard-section-title">Recent Activity</h2>
              <div className="dashboard-section-content">
                <p className="activity-empty-state">
                  No recent activities to display
                </p>
                <Link href="/activity">
                  <button className="view-all-button">View All Activity</button>
                </Link>
              </div>
            </div>
            <VisitorStats />
          </div>
        </div>
      </div>
    </Wrapper>
  );
};

export default Dashboard;
