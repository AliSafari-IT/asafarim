import React, { useEffect, useState, useRef } from 'react';
import Footer from '../Footer/Footer';
import Header from '../Header/Header';
import ModernNavbar from '../Navbar/ModernNavbar';
import { SidebarWrapper } from './SidebarWrapper';
import MainContent from './MainContent';
import { useLocation } from 'react-router-dom';
import { useTheme } from '@/contexts/ThemeContext';

interface LayoutProps {
  pageTitle?: string;
  pageDescription?: string;
  header?: React.ReactNode;
  footer?: React.ReactNode;
  sidebar?: React.ReactNode;
  topbar?: React.ReactNode;
  children?: React.ReactNode;
  className?: string;
  id?: string;
  error?: string;
  removeNavbar?: boolean;
}

const Wrapper: React.FC<LayoutProps> = ({
  pageTitle,
  pageDescription,
  header,
  footer,
  sidebar,
  children,
  className,
  id,
  error,
  removeNavbar
}) => {
  const { theme } = useTheme();
  const [isMobileMenuOpen, setIsMobileMenuOpen] = useState(false);
  const sidebarRef = useRef<HTMLDivElement>(null);
  const buttonRef = useRef<HTMLButtonElement>(null);
  const pt = pageTitle ? `${pageTitle} | ASafariM` : 'ASafariM';
  const location = useLocation();

  if (!footer) {
    footer = <Footer />;
  }
  if (!header) {
    header = <Header />;
  }

  useEffect(() => {
    // Don't save location for auth-related pages
    const skipPaths = ['/login', '/logout', '/register'];
    if (skipPaths.includes(location.pathname)) {
      return;
    }

    // Save the current location for non-auth pages
    localStorage.setItem('returnTo', location.pathname + location.search);
  }, [location]);

  useEffect(() => {
    document.title = pt;
    document
      .querySelector('meta[name="description"]')
      ?.setAttribute('content', `${pageDescription}`);
  }, [pageTitle, pageDescription, pt]);

  useEffect(() => {
    if (theme === 'dark') {
      document.documentElement.classList.add('dark');
    } else {
      document.documentElement.classList.remove('dark');
    }
  }, [theme]);

  useEffect(() => {
    // Update the returnTo value in localStorage
    const handleClickOutside = (event: MouseEvent) => {
      if (
        isMobileMenuOpen &&
        sidebarRef.current &&
        !sidebarRef.current.contains(event.target as Node) &&
        buttonRef.current &&
        !buttonRef.current.contains(event.target as Node)
      ) {
        setIsMobileMenuOpen(false);
      }
    };

    document.addEventListener('mousedown', handleClickOutside);
    return () => {
      document.removeEventListener('mousedown', handleClickOutside);
    };
  }, [isMobileMenuOpen]);
  return (
    <div id={id || 'wrapper'} className={`flex flex-col min-h-screen bg-[var(--bg-primary)] text-[var(--text-primary)] ${className}`}>
      {!removeNavbar && <ModernNavbar />}
      {/* Mobile Sidebar Overlay */}
      {isMobileMenuOpen && (
        <div
          className="fixed inset-0 "
          onClick={() => setIsMobileMenuOpen(false)}
        />
      )}
      <SidebarWrapper
        ref={sidebarRef}
        sidebar={sidebar}
        className={`fixed top-[var(--navbar-height)] left-0 w-64 z-50 transition-transform duration-300 ease-in-out bg-[var(--bg-secondary)] border-r border-[var(--border-secondary)] ${isMobileMenuOpen ? 'translate-x-0' : '-translate-x-full'}`}
      />
      <div className="flex flex-1 pt-[var(--navbar-height)]">
        {/* Main Content */}
        <MainContent className="flex-1 flex flex-col bg-[var(--bg-primary)]" header={header}>
          {error && <div className="text-red-500 w-full md:w-1/2 text-center mx-auto my-10 h-5">{error}</div>}
          {children}
        </MainContent>
      </div>
      {footer}
    </div>
  );
};

export default Wrapper;
