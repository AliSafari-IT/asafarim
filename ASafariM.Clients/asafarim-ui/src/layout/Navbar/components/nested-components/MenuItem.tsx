import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faChevronDown, faChevronRight } from '@fortawesome/free-solid-svg-icons';
import { MenuItemProps } from '../../../../interfaces/dropdown-types';

// Recursive MenuItem component that can handle multiple levels of nesting
const MenuItem: React.FC<MenuItemProps> = ({ item, isActive, onMenuClick, onClose }) => {
  const hasChildren = item.subMenu && item.subMenu.length > 0;
  const [activeNestedItems, setActiveNestedItems] = useState<Record<string, boolean>>({});

  const handleNestedMenuClick = (itemId: string) => {
    setActiveNestedItems(prev => ({
      ...prev,
      [itemId]: !prev[itemId]
    }));
  };

  return (
    <div key={item.id} className={`relative ${hasChildren ? 'menu-item-with-children' : ''}`}>
      {item.to && !item.to.startsWith('#') ? (
        <Link
          to={item.to}
          className="block px-4 py-2 text-sm hover:bg-[var(--bg-secondary)] text-[var(--text-primary)]"
          onClick={onClose}
          role="menuitem"
          tabIndex={-1}
          target={item.target}
        >
          {item.title}
        </Link>
      ) : (
        <button
          className={`w-full text-left px-4 py-2 text-sm hover:bg-[var(--bg-secondary)] text-[var(--text-primary)] flex items-center justify-between ${hasChildren ? 'has-children' : ''}`}
          onClick={() => {
            onMenuClick(item.id);
            if (hasChildren) {
              handleNestedMenuClick(item.id);
            }
          }}
        >
          {item.title}
          {hasChildren && (
            <FontAwesomeIcon
              icon={isActive ? faChevronDown : faChevronRight}
              className="ml-2"
            />
          )}
        </button>
      )}

      {hasChildren && (
        <div
          className={`nested-submenu w-48 bg-[var(--bg-primary)] shadow-lg rounded-md ${isActive ? 'active' : ''}`}
          id={item.id}
          data-testid="submenu-container"
        >
          {item.subMenu?.map((subItem) => (
            <MenuItem
              key={subItem.id}
              item={subItem}
              isActive={activeNestedItems[subItem.id] || false}
              onMenuClick={handleNestedMenuClick}
              onClose={onClose}
            />
          ))}
        </div>
      )}
    </div>
  );
};

export default MenuItem;
