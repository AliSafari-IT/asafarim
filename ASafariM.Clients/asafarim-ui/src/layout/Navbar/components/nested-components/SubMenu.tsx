import React, { useState } from 'react';
import MenuItem from './MenuItem';
import { SubMenuProps } from '../../../../interfaces/dropdown-types';

const SubMenu: React.FC<SubMenuProps> = ({ items, parentId, onMenuClick, onClose }) => {
  const [activeNestedItem, setActiveNestedItem] = useState<string | null>(null);

  const handleNestedMenuClick = (itemId: string) => {
    setActiveNestedItem(activeNestedItem === itemId ? null : itemId);
    onMenuClick(itemId);
  };

  return (
    <div
      className="lg:absolute lg:left-full lg:top-0 w-full lg:w-48 bg-[var(--bg-primary)] shadow-lg rounded-md"
      id={parentId}
      data-testid="submenu-container"
    >
      {items?.map((item) => (
        <MenuItem
          key={item.id}
          item={item}
          isActive={activeNestedItem === item.id}
          onMenuClick={handleNestedMenuClick}
          onClose={onClose}
        />
      ))}
    </div>
  );
};

export default SubMenu;