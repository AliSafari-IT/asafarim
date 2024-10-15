// src/layout/Wrapper/Wrapper.tsx

import React from 'react';
import DefaultFooter from '../DefaultFooter/DefaultFooter';
import DefaultHeader from '../DefaultHeader/DefaultHeader';
import Navbar from '../Navbar/Navbar';

interface LayoutProps {
  header?: React.ReactNode;
  footer?: React.ReactNode;
  className?: string;
  sidebar?: React.ReactNode;
  sidebarClassName?: string;
  navbar?: React.ReactNode;
  navbarClassName?: string;
  contentClassName?: string;
  content?: React.ReactNode;
  contentStyle?: React.CSSProperties;
  sidebarStyle?: React.CSSProperties;
  style?: React.CSSProperties;
  pageTitle?: string;
  children?: React.ReactNode;
}

// Layout component with support for custom header, footer, navbar, sidebar, and content
const Wrapper: React.FC<LayoutProps> = ({
  header,
  footer,
  className = '',
  sidebar,
  sidebarClassName = '',
  navbar,
  navbarClassName = '',
  contentClassName = '',
  content,
  contentStyle = {},
  sidebarStyle = {},
  style = {},
  pageTitle,
  children,
}) => {
  // Set the document title if provided
  if (pageTitle) {
    document.title = pageTitle;
  }

  // Default header, footer, and navbar
  const headerBlock = header ?? <DefaultHeader />;
  const footerBlock = footer ?? <DefaultFooter />;
  const navbarBlock = navbar ?? <Navbar className={`p-0 m-0 ${navbarClassName}`} />;

  return (
    <div className={`flex flex-col min-h-screen w-full bg-gray-800 text-black bg-gradient-to-r from-blue-500 to-indigo-600 ${className}`} style={style}>
      {/* Navbar */}
      {navbarBlock}

      <div className="flex flex-grow w-full">
        {/* Sidebar */}
        {sidebar && (
          <aside className={`sidebar ${sidebarClassName}`} style={sidebarStyle}>
            {sidebar}
          </aside>
        )}

        {/* Main Content */}
        <div className={`content flex-grow  ${contentClassName}`} style={contentStyle}>
          {headerBlock}
          <main>{content ?? children}</main>
          {footerBlock}
        </div>
      </div>
    </div>
  );
};

export default Wrapper;
