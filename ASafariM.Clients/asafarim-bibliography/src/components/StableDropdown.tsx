import React, { useEffect, useState } from 'react';
import { DDMenu, MenuItem } from '@asafarim/dd-menu';

/**
 * StableDropdown - A wrapper component that provides theme-aware DDMenu
 * 
 * This component ensures DDMenu uses the correct theme and provides a consistent API.
 */
interface StableDropdownProps {
  items: MenuItem[];
  className?: string;
  trigger: React.ReactNode;
  placement?: "bottom" | "bottom-start" | "bottom-end" | "top" | "top-start" | "top-end" | "right" | "left";
  onItemClick?: (item: MenuItem) => void;
}

// Inline styles for theme consistency
const dropdownStyles = `
  .stable-dropdown-wrapper .dd-menu__content {
    background-color: var(--dropdown-bg) !important;
    border-color: var(--dropdown-border) !important;
    box-shadow: var(--shadow-large) !important;
  }
  
  .stable-dropdown-wrapper .dd-menu__item {
    color: var(--text-primary) !important;
  }
  
  .stable-dropdown-wrapper .dd-menu__item:hover {
    background-color: var(--dropdown-hover) !important;
    color: var(--text-primary) !important;
  }
  
  .stable-dropdown-wrapper .dd-menu__trigger {
    color: var(--text-primary) !important;
  }
`;

const StableDropdown: React.FC<StableDropdownProps> = ({ 
  items, 
  className, 
  trigger, 
  placement = "bottom-start",
  onItemClick 
}) => {
  const [currentTheme, setCurrentTheme] = useState<'light' | 'dark'>('light');

  // Detect current theme from document
  useEffect(() => {
    const updateTheme = () => {
      const theme = document.documentElement.getAttribute('data-theme') as 'light' | 'dark' | null;
      setCurrentTheme(theme || 'light');
    };

    // Initial theme detection
    updateTheme();

    // Listen for theme changes
    const observer = new MutationObserver(updateTheme);
    observer.observe(document.documentElement, {
      attributes: true,
      attributeFilter: ['data-theme']
    });

    return () => observer.disconnect();
  }, []);
  
  return (
    <>
      <style>{dropdownStyles}</style>
      <div 
        className="stable-dropdown-wrapper"
        style={{
          // Ensure proper theme context
          color: 'var(--text-primary)',
          backgroundColor: 'transparent',
        }}
      >
        <DDMenu 
          items={items} 
          className={`${className || ''} dd-menu--${currentTheme}`}
          theme={currentTheme}
          trigger={trigger}
          placement={placement}
          onItemClick={onItemClick}
          closeOnClick={true}
        />
      </div>
    </>
  );
};

export default StableDropdown;
