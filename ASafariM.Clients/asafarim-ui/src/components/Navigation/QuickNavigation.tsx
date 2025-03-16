import React from "react";
import { FluentProvider, Link, webDarkTheme, webLightTheme } from "@fluentui/react-components";
import CardContainer from "../Containers/Card/CardContainer";
import { useTheme } from "@/contexts/ThemeContext";
import "./QuickNavigation.css";

interface NavigationCard {
  title: string;
  description: string;
  icon: string;
  link: string;
  color: string;
  buttonText: string;
}

const QuickNavigation: React.FC = () => {
  const { theme } = useTheme();
  const currentTheme = theme === "dark" ? webDarkTheme : webLightTheme;

  // Navigation card data
  const navigationCards: NavigationCard[] = [
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
      link: "/contact",
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
    <div className="quick-navigation-container">
      {/* Navigation Section */}
      <div className="navigation-section">
        <h2 className="section-title">Quick Navigation</h2>
        <div className="nav-cards">
          {navigationCards.map((card, index) => (
            <div key={index} className={`nav-card ${card.color}`}>
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

      {/* System Overview Section */}
      <FluentProvider theme={currentTheme}>
        <div className="system-overview-section">
          <h2 className="section-title">System Overview</h2>
          <CardContainer />
        </div>
      </FluentProvider>
    </div>
  );
};

export default QuickNavigation;
