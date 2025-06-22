import React from "react";
// import ElegantDropdownShowcase from "./ElegantDropdownShowcase";
// import MinimalDDMenuShowcase from "./MinimalDDMenuShowcase";
// import ProfessionalDropdownShowcase from "./ProfessionalDropdownShowcase";
// import SearchableDropdown from "./SearchableDropdown";
// import "../styles/enhanced-dropdown.css";
// import '../styles/professional-dropdown.css';
import DDMenu, { MenuItem } from "../../../packages/dd-menu";
import "@asafarim/dd-menu/dist/index.css";

const TestComponent: React.FC = () => {
  const navMenuItems: MenuItem[] = [
    { 
      id: "dashboard", 
      label: "Dashboard", 
      link: "/dashboard",
      icon: "🏠"
    },
    {
      id: "projects",
      label: "Projects",
      icon: "📁",
      children: [
        { id: "active-projects", label: "Active Projects", link: "/projects/active", icon: "⚡" },
        { id: "completed", label: "Completed", link: "/projects/completed", icon: "✅" },
        { id: "archive", label: "Archive", link: "/projects/archive", icon: "📦" },
      ],
    },
    { 
      id: "team", 
      label: "Team", 
      link: "/team",
      icon: "👥"
    },
    { 
      id: "analytics", 
      label: "Analytics", 
      link: "/analytics",
      icon: "📊"
    },
  ];

  // User profile menu
  const profileMenuItems: MenuItem[] = [
    { id: "profile", label: "View Profile", link: "/profile", icon: "👤" },
    { id: "settings", label: "Settings", link: "/settings", icon: "⚙️" },
    { id: "billing", label: "Billing", link: "/billing", icon: "💳" },
    { id: "divider1", label: "—", disabled: true },
    { id: "help", label: "Help & Support", link: "/help", icon: "❓" },
    { id: "logout", label: "Sign Out", onClick: () => alert('Signing out...'), icon: "🚪" },
  ];

  // Sidebar menu items
  const sidebarMenuItems: MenuItem[] = [
    { id: "home", label: "Home", link: "/", icon: "🏠" },
    { 
      id: "workspace", 
      label: "Workspace", 
      icon: "💼",
      children: [
        { id: "my-workspace", label: "My Workspace", link: "/workspace/mine" },
        { id: "shared", label: "Shared with me", link: "/workspace/shared" },
        { id: "recent", label: "Recent", link: "/workspace/recent" },
      ]
    },
    { id: "favorites", label: "Favorites", link: "/favorites", icon: "⭐" },
    { id: "trash", label: "Trash", link: "/trash", icon: "🗑️" },
  ];

  
  return (
    <div style={{ padding: '20px', maxWidth: '1200px', margin: '0 auto' }}>
      <h1 style={{ 
        marginBottom: '30px', 
        textAlign: 'center',
        fontSize: '32px',
        fontWeight: 'bold',
        color: '#1e293b'
      }}>Dropdown Menu Showcase</h1>

      <DDMenu 
        items={navMenuItems} 
        className="dd-menu--navbar"
        trigger={
          <div 
            className="dd-menu__trigger dd-menu__trigger--text"
            role="button"
            aria-haspopup="true"
            tabIndex={0}
          >
            Navigation
          </div>
        }
      />
      
      {/* <div style={{ marginBottom: '60px' }}>
        <h2 style={{ 
          marginBottom: '20px', 
          fontSize: '24px',
          fontWeight: '600',
          color: '#334155',
          borderBottom: '2px solid #e2e8f0',
          paddingBottom: '10px'
        }}>Professional Dropdown</h2>
        <ProfessionalDropdownShowcase />
      </div>
      
      <div style={{ marginBottom: '60px' }}>
        <h2 style={{ 
          marginBottom: '20px', 
          fontSize: '24px',
          fontWeight: '600',
          color: '#334155',
          borderBottom: '2px solid #e2e8f0',
          paddingBottom: '10px'
        }}>Searchable Dropdown</h2>
        <SearchableDropdown />
      </div>
      
      <div style={{ marginBottom: '60px' }}>
        <h2 style={{ 
          marginBottom: '20px', 
          fontSize: '24px',
          fontWeight: '600',
          color: '#334155',
          borderBottom: '2px solid #e2e8f0',
          paddingBottom: '10px'
        }}>Elegant Dropdown</h2>
        <ElegantDropdownShowcase />
      </div>
      
      <div>
        <h2 style={{ 
          marginBottom: '20px', 
          fontSize: '24px',
          fontWeight: '600',
          color: '#334155',
          borderBottom: '2px solid #e2e8f0',
          paddingBottom: '10px'
        }}>Minimal Dropdown</h2>
        <MinimalDDMenuShowcase />
      </div> */}
    </div>
  );
};

export default TestComponent;
