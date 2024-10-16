// src/layout/Wrapper/Wrapper.tsx

import React, { useEffect } from 'react';
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
  pageDescription?: string;
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
  pageDescription = 'ASafariM React .Net Core TypeScript Client',
}) => {

  // Default header, footer, and navbar
  const sidebarBlock = sidebar ?? <div className="w-64 h-full bg-gray-800 text-white">Sidebar</div>;
  const headerBlock = header ?? <DefaultHeader />;
  const footerBlock = footer ?? <DefaultFooter />;
  const navbarBlock = navbar ?? <Navbar className={`p-0 m-0 ${navbarClassName}`} />;

  // Page title
  const title = `${pageTitle ? `${pageTitle} | ` : ''}ASafariM`;
  const description = pageDescription;
  useEffect(() => {
    document.title = title;
    document.querySelector('meta[name="description"]')?.setAttribute('content', description);
  }, [pageTitle]);

  return (
    <>      
      <div className={`flex flex-col min-h-screen w-full bg-gray-800 text-black bg-gradient-to-r from-blue-500 to-indigo-600 ${className} layout-container`} style={style}>
        {/* Navbar */}
        {navbarBlock}

        <div className="flex flex-grow w-full">
          {/* Sidebar */}
          {sidebar && (
            <aside className={`sidebar ${sidebarClassName}`} style={sidebarStyle}>
              {sidebarBlock}
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
    </>
  );
};

export default Wrapper;
