import React, { useState } from 'react';
import { DDMenu, MenuItem } from '@asafarim/dd-menu';

/**
 * StableDropdown - A wrapper component that fixes the issue of dropdowns disappearing after clicking
 * 
 * This component maintains its own open/closed state and prevents event propagation
 * that would otherwise cause the dropdown to close immediately after opening.
 */
interface StableDropdownProps {
  items: MenuItem[];
  className?: string;
  trigger: React.ReactNode;
  placement?: "bottom" | "bottom-start" | "bottom-end" | "top" | "top-start" | "top-end" | "right" | "left";
  onItemClick?: (item: MenuItem) => void;
}

const StableDropdown: React.FC<StableDropdownProps> = ({ 
  items, 
  className, 
  trigger, 
  placement,
  onItemClick 
}) => {
  const [isOpen, setIsOpen] = useState(false);
  
  // Handle item click and close dropdown if needed
  const handleItemClick = (item: MenuItem) => {
    if (onItemClick) {
      onItemClick(item);
    }
    
    // Close dropdown if item doesn't have children
    if (!item.children || item.children.length === 0) {
      setIsOpen(false);
    }
  };
  
  return (
    <div 
      className="stable-dropdown-wrapper" 
      onClick={(e) => e.stopPropagation()}
      style={{ position: 'relative', display: 'inline-block' }}
    >
      <div onClick={() => setIsOpen(!isOpen)}>
        {trigger}
      </div>
      {isOpen && (
        <div className="stable-dropdown-content" style={{ position: 'absolute', zIndex: 1000 }}>
          <DDMenu 
            items={items} 
            className={className}
            trigger={<div style={{ display: 'none' }}></div>}
            placement={placement}
            onItemClick={handleItemClick}
          />
        </div>
      )}
    </div>
  );
};

export default StableDropdown;
