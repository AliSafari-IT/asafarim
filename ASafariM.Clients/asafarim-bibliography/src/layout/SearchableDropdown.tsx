import React, { useState } from 'react';
import { DDMenu, MenuItem } from '@asafarim/dd-menu';
import '@asafarim/dd-menu/dist/index.css';
import '../styles/professional-dropdown.css';

const SearchableDropdown: React.FC = () => {
  // Sample data for demonstration
  const allItems: MenuItem[] = [
    { id: "dashboard", label: "Dashboard", link: "/dashboard", icon: "🏠" },
    { id: "projects", label: "Projects", link: "/projects", icon: "📁" },
    { id: "tasks", label: "Tasks", link: "/tasks", icon: "✅" },
    { id: "calendar", label: "Calendar", link: "/calendar", icon: "📅" },
    { id: "messages", label: "Messages", link: "/messages", icon: "💬" },
    { id: "notifications", label: "Notifications", link: "/notifications", icon: "🔔" },
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
  const [searchTerm, setSearchTerm] = useState('');
  const [filteredItems, setFilteredItems] = useState<MenuItem[]>(allItems);
  const [focusedIndex, setFocusedIndex] = useState(-1);
  
  // Reset focused index when filtered items change
  React.useEffect(() => {
    setFocusedIndex(-1);
  }, [filteredItems]);

  // Handle search input change
  const handleSearchChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const term = e.target.value.toLowerCase();
    setSearchTerm(term);
    
    if (term.trim() === '') {
      setFilteredItems(allItems);
    } else {
      const filtered = allItems.filter(item => 
        item.label.toLowerCase().includes(term)
      );
      setFilteredItems(filtered);
    }
  };

  // Handle keyboard events for accessibility
  const handleKeyDown = (e: React.KeyboardEvent) => {
    if (e.key === 'Escape') {
      setIsOpen(false);
    } else if (e.key === 'Enter' || e.key === ' ') {
      setIsOpen(!isOpen);
      e.preventDefault();
    }
  };

  // Custom dropdown trigger with search functionality
  const customTrigger = (
    <div 
      className="pro-dropdown__trigger pro-dropdown__trigger--button"
      style={{
        background: 'linear-gradient(to right, #3b82f6, #6366f1)',
        display: 'flex',
        alignItems: 'center',
        gap: '8px'
      }}
      role="button"
      aria-haspopup="true"
      aria-expanded={isOpen}
      tabIndex={0}
      onClick={() => setIsOpen(!isOpen)}
      onKeyDown={handleKeyDown}
    >
      <span>🔍</span> Search Menu Items
    </div>
  );

  // Custom dropdown content with search input
  const customContent = (
    <div className="pro-dropdown__content" style={{ padding: '12px', minWidth: '280px' }}>
      <div style={{ marginBottom: '12px' }}>
        <input
          type="text"
          placeholder="Search menu items..."
          value={searchTerm}
          onChange={handleSearchChange}
          style={{
            width: '100%',
            padding: '8px 12px',
            borderRadius: '6px',
            border: '1px solid #e2e8f0',
            fontSize: '14px',
            outline: 'none',
            transition: 'border-color 0.2s ease',
          }}
          autoFocus
          onFocus={(e) => e.target.select()}
          onKeyDown={(e) => {
            if (e.key === 'Escape') {
              setIsOpen(false);
              e.preventDefault();
              e.stopPropagation();
            } else if (e.key === 'ArrowDown') {
              e.preventDefault();
              setFocusedIndex(prev => (prev < filteredItems.length - 1 ? prev + 1 : 0));
            } else if (e.key === 'ArrowUp') {
              e.preventDefault();
              setFocusedIndex(prev => (prev > 0 ? prev - 1 : filteredItems.length - 1));
            } else if (e.key === 'Enter' && focusedIndex >= 0) {
              e.preventDefault();
              const item = filteredItems[focusedIndex];
              if (item) {
                if (item.onClick) item.onClick();
                if (item.link) window.location.href = item.link;
                setIsOpen(false);
              }
            }
          }}
        />
      </div>
      
      {filteredItems.length > 0 ? (
        <div className="pro-dropdown__items">
          {filteredItems.map((item, index) => (
            <div 
              key={item.id} 
              className={`pro-dropdown__item ${focusedIndex === index ? 'pro-dropdown__item--active' : ''}`}
              onClick={() => {
                if (item.onClick) item.onClick();
                if (item.link) window.location.href = item.link;
                setIsOpen(false);
              }}
              onKeyDown={(e) => {
                if (e.key === 'Enter' || e.key === ' ') {
                  if (item.onClick) item.onClick();
                  if (item.link) window.location.href = item.link;
                  setIsOpen(false);
                  e.preventDefault();
                } else if (e.key === 'ArrowDown') {
                  e.preventDefault();
                  setFocusedIndex(prev => (prev < filteredItems.length - 1 ? prev + 1 : 0));
                } else if (e.key === 'ArrowUp') {
                  e.preventDefault();
                  setFocusedIndex(prev => (prev > 0 ? prev - 1 : filteredItems.length - 1));
                }
              }}
              role="menuitem"
              tabIndex={focusedIndex === index ? 0 : -1}
              ref={el => {
                if (el && focusedIndex === index) {
                  el.focus();
                }
              }}
              style={{
                transition: 'all 0.15s ease',
                backgroundColor: focusedIndex === index ? 'rgba(59, 130, 246, 0.08)' : undefined,
              }}
            >
              {item.icon && (
                <span className="pro-dropdown__item-icon">{item.icon}</span>
              )}
              <span className="pro-dropdown__item-label">{item.label}</span>
            </div>
          ))}
        </div>
      ) : (
        <div style={{ 
          padding: '12px', 
          textAlign: 'center', 
          color: '#64748b',
          fontSize: '14px' 
        }}>
          No items found
        </div>
      )}
      
      <div style={{ 
        borderTop: '1px solid #e5e7eb', 
        marginTop: '8px', 
        paddingTop: '8px',
        fontSize: '13px',
        color: '#64748b',
        textAlign: 'center'
      }}>
        Press <kbd style={{ 
          background: '#f1f5f9', 
          padding: '2px 5px', 
          borderRadius: '3px',
          border: '1px solid #e2e8f0',
          fontSize: '11px'
        }}>Esc</kbd> to close
      </div>
    </div>
  );

  return (
    <div style={{ padding: '40px', background: 'white', borderRadius: '12px' }}>
      <h3 style={{ 
        fontSize: '18px', 
        fontWeight: '600', 
        color: '#334155',
        marginBottom: '20px' 
      }}>
        Searchable Dropdown Menu
      </h3>
      
      <p style={{ 
        fontSize: '15px', 
        color: '#64748b',
        marginBottom: '20px',
        maxWidth: '600px'
      }}>
        This enhanced dropdown features a search input to quickly filter through menu items.
        Perfect for menus with many options or for improving user experience.
      </p>
      
      <div style={{ display: 'flex', gap: '20px', flexWrap: 'wrap' }}>
        {/* Custom searchable dropdown */}
        <div>
          <DDMenu
            items={allItems}
            className="pro-dropdown pro-dropdown--default pro-dropdown--md"
            trigger={customTrigger}
            onItemClick={(item: MenuItem) => {
              if (item.onClick) item.onClick();
            }}
          />
        </div>
      </div>
    </div>
  );
};

export default SearchableDropdown;
