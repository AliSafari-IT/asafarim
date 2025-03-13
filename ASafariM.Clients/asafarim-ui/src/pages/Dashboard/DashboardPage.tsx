import React from "react";
import Wrapper from "../../layout/Wrapper/Wrapper";
import { DashboardHeaderBlock } from "./DashboardHeaderBlock";
import {
  FluentProvider,
  Link,
  webDarkTheme,
  webLightTheme,
} from "@fluentui/react-components";
import CardContainer from "../../components/Containers/Card/CardContainer";
import { useTheme } from "@/contexts/ThemeContext";
import "./Dashboard.css";

const Dashboard: React.FC = () => {
  const { theme } = useTheme();
  const currentTheme = theme === "dark" ? webDarkTheme : webLightTheme;

  // Navigation card data
  const navigationCards = [
    {
      title: "Projects",
      description: "Browse and manage your active projects",
      icon: "📊",
      link: "/projects",
      color: "primary",
      buttonText: "Discover Projects",
    },
    {
      title: "Users",
      description: "Manage user accounts and permissions",
      icon: "👥",
      link: "/users",
      color: "secondary",
      buttonText: "Manage Users",
    },
    {
      title: "Blog",
      description: "Read the latest articles and updates",
      icon: "📝",
      link: "/blog",
      color: "tertiary",
      buttonText: "Read Our Blog",
    },
    {
      title: "Contact",
      description: "Get in touch with our support team",
      icon: "📞",
      link: "/contact-asafarim",
      color: "accent",
      buttonText: "Get in Touch",
    },
    {
      title: "Changelogs",
      description: "View recent updates and changes",
      icon: "📋",
      link: "/changelogs",
      color: "info",
      buttonText: "View Changelogs",
    },
  ];

  return (
    <Wrapper header={<DashboardHeaderBlock />}>
      <div className="dashboard-container">
        {/* Main Content Area */}
        <div className="dashboard-content">
          {/* Navigation Section */}
          <div className="dashboard-navigation-section">
            <h2 className="dashboard-section-title">Quick Navigation</h2>
            <div className="dashboard-nav-cards">
              {navigationCards.map((card, index) => (
                <div key={index} className={`dashboard-nav-card ${card.color}`}>
                  <div className="nav-card-icon">{card.icon}</div>
                  <div className="nav-card-content">
                    <h3 className="nav-card-title">{card.title}</h3>
                    <p className="nav-card-description">{card.description}</p>
                  </div>
                  <Link href={card.link}>
                    <button className={`nav-card-button ${card.color}`}>
                      {card.buttonText}
                    </button>
                  </Link>
                </div>
              ))}
            </div>
          </div>

          <FluentProvider theme={currentTheme}>
            <div className="dashboard-cards-section">
              <h2 className="dashboard-section-title">System Overview</h2>
              <CardContainer />
            </div>
          </FluentProvider>

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
          </div>
        </div>
      </div>
    </Wrapper>
  );
};

export default Dashboard;
