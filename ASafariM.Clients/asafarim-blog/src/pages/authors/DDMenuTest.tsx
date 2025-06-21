import React from 'react';
import { DDMenu, MenuItem } from '@asafarim/dd-menu';
import '@asafarim/dd-menu/dist/index.css';

const TestComponent: React.FC = () => {
  const menuItems: MenuItem[] = [
    { id: "1", label: "Home", link: "/" },
    {
      id: "2",
      label: "Products",
      children: [
        { id: "2-1", label: "Phones", link: "/phones" },
        { id: "2-2", label: "Laptops", link: "/laptops" },
      ],
    },
    { id: "3", label: "About", link: "/about" },
  ];

  return (
    <div>
      <h1>DDMenu Test</h1>
      <DDMenu items={menuItems} theme="light" />
    </div>
  );
};

export default TestComponent;
