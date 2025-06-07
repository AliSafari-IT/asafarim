import React from 'react';
import { DropdownContainerProps } from '../../../../interfaces/dropdown-types';

const DropdownContainer: React.FC<DropdownContainerProps> = ({ isOpen, children }) => {
  if (!isOpen) return null;

  return (
    <div className="absolute left-0 mt-2 w-48 bg-[var(--bg-primary)] shadow-lg rounded-md z-10">
      {children}
    </div>
  );
};

export default DropdownContainer;