import React, { useState, useRef, useEffect } from 'react';
import { DropdownProps } from '../../../interfaces/dropdown-types';
import DropdownButton from './nested-components/DropdownButton';
import DropdownContainer from './nested-components/DropdownContainer';
import MenuItem from './nested-components/MenuItem';

const ResponsiveDropdownMenu: React.FC<DropdownProps> = ({
  topbarNavData,
  className = '',
}) => {
  const [isOpen, setIsOpen] = useState(false);
  const [activeMenus, setActiveMenus] = useState<Record<string, boolean>>({});
  const dropdownRef = useRef<HTMLDivElement>(null);

  useEffect(() => {
    const handleClickOutside = (event: MouseEvent) => {
      if (dropdownRef.current && !dropdownRef.current.contains(event.target as Node)) {
        setIsOpen(false);
        setActiveMenus({});
      }
    };

    document.addEventListener('mousedown', handleClickOutside);
    return () => document.removeEventListener('mousedown', handleClickOutside);
  }, []);

  const handleMenuClick = (menuId: string) => {
    setActiveMenus(prev => ({
      ...prev,
      [menuId]: !prev[menuId]
    }));
  };

  const handleClose = () => {
    setIsOpen(false);
    setActiveMenus({});
  };

  return (
    <div ref={dropdownRef} className={`relative ${className}`}>
      <DropdownButton
        title={topbarNavData[0]?.title || ''}
        isOpen={isOpen}
        onClick={() => setIsOpen(!isOpen)}
      />

      <DropdownContainer isOpen={isOpen}>
        {topbarNavData[0]?.subMenu?.map((item) => (
          <MenuItem
            key={item.id}
            item={item}
            isActive={!!activeMenus[item.id]}
            onMenuClick={handleMenuClick}
            onClose={handleClose}
          />
        ))}
      </DropdownContainer>
    </div>
  );
};

export default ResponsiveDropdownMenu;
