import React, { useState } from "react";
// import ElegantDropdownShowcase from "./ElegantDropdownShowcase";
// import MinimalDDMenuShowcase from "./MinimalDDMenuShowcase";
// import ProfessionalDropdownShowcase from "./ProfessionalDropdownShowcase";
// import SearchableDropdown from "./SearchableDropdown";
// import "../styles/enhanced-dropdown.css";
// import '../styles/professional-dropdown.css';
// import DDMenu, { MenuItem } from "../../../packages/dd-menu";
import DDMenu, { MenuItem } from "@asafarim/dd-menu";
import "@asafarim/dd-menu/dist/index.css";

const TestComponent: React.FC = () => {
  const theme = localStorage.getItem("theme") as "auto" | "light" | "dark";
  const allItems: MenuItem[] = [
    { id: "dashboard", label: "Dashboard", link: "/dashboard", icon: "🏠" },
    { id: "projects", label: "Projects", link: "/projects", icon: "📁" },
    { id: "tasks", label: "Tasks", link: "/tasks", icon: "✅" },
    { id: "calendar", label: "Calendar", link: "/calendar", icon: "📅" },
    { id: "messages", label: "Messages", link: "/messages", icon: "💬" },
    {
      id: "notifications",
      label: "Notifications",
      link: "/notifications",
      icon: "🔔",
    },
    { id: "settings", label: "Settings", link: "/settings", icon: "⚙️" },
    { id: "help", label: "Help & Support", link: "/help", icon: "❓" },
    { id: "profile", label: "My Profile", link: "/profile", icon: "👤" },
    { id: "team", label: "Team Members", link: "/team", icon: "👥" },
    { id: "analytics", label: "Analytics", link: "/analytics", icon: "📊" },
    { id: "reports", label: "Reports", link: "/reports", icon: "📈" },
    { id: "documents", label: "Documents", link: "/documents", icon: "📄" },
    { id: "files", label: "Files", link: "/files", icon: "📁" },
  ];

  const [isOpen, setIsOpen] = useState(false);
  const [searchTerm, setSearchTerm] = useState("");
  const [filteredItems, setFilteredItems] = useState<MenuItem[]>(allItems);
  const [focusedIndex, setFocusedIndex] = useState(-1);

  // Reset focused index when filtered items change
  React.useEffect(() => {
    setFocusedIndex(-1);
  }, [filteredItems]);

  // Handle search input change
  const handleSearchChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const term = e.target.value;
    setSearchTerm(term);

    if (term.trim() === "") {
      setFilteredItems(allItems);
    } else {
      // Case-insensitive search that matches anywhere in the label
      const filtered = allItems.filter((item) =>
        item.label.toLowerCase().includes(term.toLowerCase())
      );
      setFilteredItems(filtered);
    }
  };

  // Handle keyboard events for accessibility
  const handleKeyDown = (e: React.KeyboardEvent) => {
    if (e.key === "Escape") {
      setIsOpen(false);
    } else if (e.key === "Enter" || e.key === " ") {
      setIsOpen(!isOpen);
      e.preventDefault();
    }
  };

  // Custom dropdown with search functionality
  const SearchableDropdownMenu = () => {
    return (
      <div className="searchable-dropdown">
        <div
          className="searchable-dropdown__trigger"
          style={{
            background: "linear-gradient(to right, #3b82f6, #6366f1)",
            display: "flex",
            alignItems: "center",
            gap: "8px",
            padding: "8px 16px",
            borderRadius: "6px",
            color: "white",
            cursor: "pointer",
            fontWeight: "500",
            fontSize: "14px",
          }}
          onClick={() => setIsOpen(!isOpen)}
          onKeyDown={handleKeyDown}
          role="button"
          aria-haspopup="true"
          aria-expanded={isOpen}
          tabIndex={0}
        >
          <span>🔍</span> Search Menu Items
        </div>
        
        {isOpen && (
          <div 
            className="searchable-dropdown__menu"
            style={{
              position: "absolute",
              zIndex: 100,
              marginTop: "4px",
              background: "white",
              borderRadius: "6px",
              boxShadow: "0 4px 12px rgba(0, 0, 0, 0.15)",
              border: "1px solid #e5e7eb",
              width: "280px",
              maxHeight: "400px",
              overflow: "hidden",
              display: "flex",
              flexDirection: "column",
            }}
          >
            <div 
              className="searchable-dropdown__search"
              style={{
                padding: "12px",
                borderBottom: "1px solid #e5e7eb",
              }}
            >
              <input
                type="text"
                placeholder="Search items..."
                value={searchTerm}
                onChange={handleSearchChange}
                style={{
                  width: "100%",
                  padding: "8px 12px",
                  border: "1px solid #d1d5db",
                  borderRadius: "4px",
                  fontSize: "14px",
                  outline: "none",
                }}
                autoFocus
                onKeyDown={(e) => {
                  if (e.key === "Escape") {
                    setIsOpen(false);
                  } else if (e.key === "ArrowDown") {
                    e.preventDefault();
                    setFocusedIndex(prev => 
                      prev < filteredItems.length - 1 ? prev + 1 : prev
                    );
                  } else if (e.key === "ArrowUp") {
                    e.preventDefault();
                    setFocusedIndex(prev => prev > 0 ? prev - 1 : prev);
                  } else if (e.key === "Enter" && focusedIndex >= 0) {
                    const selectedItem = filteredItems[focusedIndex];
                    if (selectedItem && !selectedItem.disabled) {
                      if (selectedItem.onClick) selectedItem.onClick();
                      if (selectedItem.link) window.location.href = selectedItem.link;
                      setIsOpen(false);
                    }
                  }
                }}
              />
            </div>
            
            <div 
              className="searchable-dropdown__items"
              style={{
                overflowY: "auto",
                maxHeight: "320px",
              }}
            >
              {filteredItems.length > 0 ? (
                filteredItems.map((item, index) => (
                  <div
                    key={item.id}
                    className={`searchable-dropdown__item ${focusedIndex === index ? 'focused' : ''}`}
                    style={{
                      padding: "8px 16px",
                      cursor: "pointer",
                      display: "flex",
                      alignItems: "center",
                      gap: "8px",
                      backgroundColor: focusedIndex === index ? "#f3f4f6" : "transparent",
                      color: item.disabled ? "#9ca3af" : "#374151",
                    }}
                    onClick={() => {
                      if (!item.disabled) {
                        if (item.onClick) item.onClick();
                        if (item.link) window.location.href = item.link;
                        setIsOpen(false);
                      }
                    }}
                    onMouseEnter={() => setFocusedIndex(index)}
                  >
                    {item.icon && <span>{item.icon}</span>}
                    <span>{item.label}</span>
                  </div>
                ))
              ) : (
                <div 
                  style={{
                    padding: "16px",
                    textAlign: "center",
                    color: "#6b7280",
                    fontSize: "14px",
                  }}
                >
                  No items found
                </div>
              )}
            </div>
          </div>
        )}
      </div>
    );
  };

  const navMenuItems: MenuItem[] = [
    {
      id: "dashboard",
      label: "Dashboard",
      link: "/dashboard",
      icon: "🏠",
    },
    {
      id: "projects",
      label: "Projects",
      icon: "📁",
      children: [
        {
          id: "active-projects",
          label: "Active Projects",
          link: "/projects/active",
          icon: "⚡",
        },
        {
          id: "completed",
          label: "Completed",
          link: "/projects/completed",
          icon: "✅",
        },
        {
          id: "archive",
          label: "Archive",
          link: "/projects/archive",
          icon: "📦",
        },
      ],
    },
    {
      id: "team",
      label: "Team",
      link: "/team",
      icon: "👥",
    },
    {
      id: "analytics",
      label: "Analytics",
      link: "/analytics",
      icon: "📊",
    },
  ];

  // User profile menu
  const profileMenuItems: MenuItem[] = [
    { id: "profile", label: "View Profile", link: "/profile", icon: "👤" },
    { id: "settings", label: "Settings", link: "/settings", icon: "⚙️" },
    { id: "billing", label: "Billing", link: "/billing", icon: "💳" },
    { id: "divider1", label: "—", disabled: true },
    { id: "help", label: "Help & Support", link: "/help", icon: "❓" },
    {
      id: "logout",
      label: "Sign Out",
      onClick: () => alert("Signing out..."),
      icon: "🚪",
    },
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
      ],
    },
    { id: "favorites", label: "Favorites", link: "/favorites", icon: "⭐" },
    { id: "trash", label: "Trash", link: "/trash", icon: "🗑️" },
  ];

  return (
    <div style={{ padding: "20px", maxWidth: "1200px", margin: "0 auto" }}>
      <h1
        style={{
          marginBottom: "30px",
          textAlign: "center",
          fontSize: "32px",
          fontWeight: "bold",
          color: "#1e293b",
        }}
      >
        Dropdown Menu Showcase
      </h1>
      <div
        style={{
          display: "flex",
          gap: "30px",
          alignItems: "center",
        }}
      >
        <DDMenu
          items={navMenuItems}
          className="dd-menu--navbar"
          placement="bottom"
          closeOnClick={true}
          size="lg"
          theme={theme || "auto"}
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

        {/* Navigation Menu */}
        <DDMenu
          items={navMenuItems}
          className="dd-menu--navbar"
          trigger={
            <div className="elegant-navbar__item">
              <span>DD-Down</span>
              <svg
                width="16"
                height="16"
                viewBox="0 0 16 16"
                fill="currentColor"
              >
                <path
                  d="M4 6l4 4 4-4"
                  stroke="currentColor"
                  strokeWidth="1.5"
                  fill="none"
                  strokeLinecap="round"
                  strokeLinejoin="round"
                />
              </svg>
            </div>
          }
        />

        {/* Profile Menu */}
        <DDMenu
          items={profileMenuItems}
          className="dd-menu--navbar"
          trigger={
            <div
              style={{
                display: "flex",
                alignItems: "center",
                gap: "8px",
                padding: "8px 12px",
                cursor: "pointer",
                borderRadius: "8px",
                transition: "all 0.12s ease",
              }}
            >
              <div
                style={{
                  width: "32px",
                  height: "32px",
                  background:
                    "linear-gradient(135deg, #06b6d4 0%, #3b82f6 100%)",
                  borderRadius: "50%",
                  display: "flex",
                  alignItems: "center",
                  justifyContent: "center",
                  color: "white",
                  fontSize: "14px",
                  fontWeight: "600",
                }}
              >
                JD
              </div>
              <span
                style={{
                  color: "#374151",
                  fontWeight: "500",
                  fontSize: "14px",
                }}
              >
                John Doe
              </span>
            </div>
          }
          placement="bottom-end"
        />
      </div>
      {/* Minimal Style */}
      <div
        style={{
          background: "#ffffff",
          padding: "24px",
          borderRadius: "12px",
          border: "1px solid #e5e7eb",
          boxShadow: "0 1px 3px 0 rgba(0, 0, 0, 0.1)",
          textAlign: "center",
        }}
      >
        <h3
          style={{
            fontSize: "1.125rem",
            fontWeight: "600",
            color: "#1f2937",
            marginBottom: "16px",
          }}
        >
          Ultra Minimal
        </h3>
        <DDMenu
          items={navMenuItems}
          className="dd-menu--minimal dd-menu--md"
          trigger={
            <span
              style={{
                color: "#374151",
                fontWeight: "500",
                cursor: "pointer",
              }}
            >
              Click me ↓
            </span>
          }
        />
        <p
          style={{
            color: "#6b7280",
            fontSize: "13px",
            marginTop: "12px",
            fontStyle: "italic",
          }}
        >
          No borders, just hover effects
        </p>
      </div>

      {/*  */}
      {/* Custom Trigger Examples */}
      <div
        style={{
          background: "#ffffff",
          padding: "24px",
          borderRadius: "8px",
          border: "1px solid #e5e7eb",
        }}
      >
        <h2
          style={{
            color: "#1f2937",
            marginBottom: "24px",
            textAlign: "center",
            fontSize: "20px",
            fontWeight: "600",
          }}
        >
          Custom Triggers
        </h2>
        <div
          style={{
            display: "flex",
            gap: "24px",
            justifyContent: "center",
            flexWrap: "wrap",
            alignItems: "center",
          }}
        >
          {/* Button Trigger */}
          <DDMenu
            items={navMenuItems}
            className="dd-menu--minimal"
            trigger={
              <button
                style={{
                  background: "#3b82f6",
                  color: "white",
                  border: "none",
                  padding: "8px 16px",
                  borderRadius: "6px",
                  cursor: "pointer",
                  fontWeight: "500",
                  fontSize: "14px",
                }}
              >
                Action Menu
              </button>
            }
          />

          {/* Icon Trigger */}
          <DDMenu
            items={profileMenuItems}
            className="dd-menu--minimal"
            trigger={
              <div
                style={{
                  width: "40px",
                  height: "40px",
                  borderRadius: "50%",
                  background: "#f3f4f6",
                  display: "flex",
                  alignItems: "center",
                  justifyContent: "center",
                  cursor: "pointer",
                  fontSize: "20px",
                  border: "1px solid #e5e7eb",
                }}
              >
                ⚙️
              </div>
            }
            placement="bottom-end"
          />

          {/* Text Trigger */}
          <DDMenu
            items={navMenuItems}
            className="dd-menu--navbar"
            trigger={
              <span
                style={{
                  color: "#3b82f6",
                  fontWeight: "500",
                  cursor: "pointer",
                  fontSize: "14px",
                  padding: "4px 8px",
                  borderRadius: "4px",
                }}
              >
                More Options
              </span>
            }
          />
        </div>
      </div>

      <div
        style={{ padding: "40px", background: "white", borderRadius: "12px" }}
      >
        <h3
          style={{
            fontSize: "18px",
            fontWeight: "600",
            color: "#334155",
            marginBottom: "20px",
          }}
        >
          Searchable Dropdown Menu
        </h3>

        <p
          style={{
            fontSize: "15px",
            color: "#64748b",
            marginBottom: "20px",
            maxWidth: "600px",
          }}
        >
          This enhanced dropdown features a search input to quickly filter
          through menu items. Perfect for menus with many options or for
          improving user experience.
        </p>

        <div style={{ display: "flex", gap: "20px", flexWrap: "wrap" }}>
          {/* Custom searchable dropdown */}
          <div style={{ position: "relative" }}>
            <SearchableDropdownMenu />
          </div>
        </div>
      </div>

      {/* Features */}
      <div
        style={{
          marginTop: "40px",
          textAlign: "center",
          background: "#ffffff",
          padding: "32px",
          borderRadius: "8px",
          border: "1px solid #e5e7eb",
        }}
      >
        <h3
          style={{
            fontSize: "18px",
            fontWeight: "600",
            color: "#1f2937",
            marginBottom: "24px",
          }}
        >
          Key Features
        </h3>
        <div
          style={{
            display: "grid",
            gridTemplateColumns: "repeat(auto-fit, minmax(200px, 1fr))",
            gap: "16px",
          }}
        >
          {[
            "🎨 Minimal & clean design",
            "⚡ Multiple variants",
            "🎯 TypeScript support",
            "📱 Mobile responsive",
            "♿ Accessible",
            "🎨 Custom triggers",
          ].map((feature, index) => (
            <div
              key={index}
              style={{
                padding: "12px",
                background: "#f9fafb",
                borderRadius: "6px",
                border: "1px solid #e5e7eb",
                color: "#6b7280",
                fontSize: "13px",
                fontWeight: "500",
              }}
            >
              {feature}
            </div>
          ))}
        </div>
      </div>
    </div>
  );
};
export default TestComponent;
