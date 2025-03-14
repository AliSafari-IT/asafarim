import React, { useState, useEffect, useRef } from 'react';
import { Link, useLocation } from 'react-router-dom';
import { useTheme } from '@/contexts/ThemeContext';
import useAuth from '@/hooks/useAuth';
import useNavItems from '@/hooks/useNavItems';
import { ChevronDownIcon } from '@heroicons/react/20/solid';
import { Bars3Icon, XMarkIcon, MoonIcon, SunIcon, HomeIcon } from '@heroicons/react/24/outline';
import { Transition } from '@headlessui/react';
import ChangeLogsDropdown from './ChangeLogsDropdown';
import UserDropdown from '@/components/user/UserDropdown';
import './ModernNavbar.css';
import Brand from './components/Brand';
import ASMButton from './components/ASMButton';
import ResponsiveDropdownMenu from './components/ResponsiveDropdownMenu';
import { IMenuItem } from '@/interfaces/IMenuItem';
import { getAllMdFiles } from '@/utils/mdFilesUtils';

const ModernNavbar: React.FC = () => {
  const { authenticatedUser, authenticated, token } = useAuth();
  const { theme, toggleTheme } = useTheme();
  const location = useLocation();
  const navItems = useNavItems();
  const mdFiles = getAllMdFiles();
  
  // Find specific nav items
  const dashboardItem = navItems.find(item => item.id === 'dashboard');
  const aboutItem = navItems.find(item => item.id === 'about');
  const contactItem = navItems.find(item => item.id === 'contact');
  
  const [isMenuOpen, setIsMenuOpen] = useState(false);
  const [scrolled, setScrolled] = useState(false);
  const [viewWidth, setViewWidth] = useState(window.innerWidth);
  const [activeDropdown, setActiveDropdown] = useState<string | null>(null);
  const menuRef = useRef<HTMLDivElement>(null);

  // Check if current path matches the given path
  const isActive = (path: string | undefined): boolean => {
    if (!path || path === '#') return false;
    return location.pathname === path || location.pathname.startsWith(path + '/');
  };

  // Handle scroll events to change navbar appearance
  useEffect(() => {
    const handleScroll = () => {
      const offset = window.scrollY;
      setScrolled(offset > 10);
    };

    window.addEventListener('scroll', handleScroll);
    return () => window.removeEventListener('scroll', handleScroll);
  }, []);

  // Handle resize events to update viewWidth
  useEffect(() => {
    const handleResize = () => {
      setViewWidth(window.innerWidth);
      if (window.innerWidth >= 1024) {
        setIsMenuOpen(false);
        setActiveDropdown(null);
      }
    };

    window.addEventListener('resize', handleResize);
    return () => window.removeEventListener('resize', handleResize);
  }, []);

  // Close mobile menu when clicking outside
  useEffect(() => {
    const handleClickOutside = (event: MouseEvent) => {
      if (menuRef.current && !menuRef.current.contains(event.target as Node)) {
        if (isMenuOpen) {
          setIsMenuOpen(false);
        }
        setActiveDropdown(null);
      }
    };

    document.addEventListener('mousedown', handleClickOutside);
    return () => document.removeEventListener('mousedown', handleClickOutside);
  }, [isMenuOpen]);

  // Handle dropdown toggle
  const toggleDropdown = (id: string) => {
    setActiveDropdown(activeDropdown === id ? null : id);
  };

  // Render nested menu items
  const renderNestedMenu = (items: IMenuItem[], level: number = 0) => {
    return items.map((item, index) => (
      <div key={item.id || index} className={`${level > 0 ? 'ml-4' : ''}`}>
        {item.subMenu && item.subMenu.length > 0 ? (
          <div className="relative">
            <button
              onClick={() => toggleDropdown(item.id)}
              className={`w-full text-left flex items-center justify-between px-4 py-2 text-sm ${
                isActive(item.to)
                  ? 'bg-gray-100 dark:bg-gray-800 text-gray-900 dark:text-white'
                  : 'text-gray-700 dark:text-gray-300 hover:bg-gray-50 dark:hover:bg-gray-800'
              }`}
            >
              <span className="flex items-center">
                {item.icon && <span className="mr-2">{item.icon}</span>}
                {item.title}
              </span>
              <ChevronDownIcon
                className={`w-4 h-4 transition-transform ${
                  activeDropdown === item.id ? 'transform rotate-180' : ''
                }`}
              />
            </button>
            <Transition
              show={activeDropdown === item.id}
              enter="transition ease-out duration-100"
              enterFrom="transform opacity-0 scale-95"
              enterTo="transform opacity-100 scale-100"
              leave="transition ease-in duration-75"
              leaveFrom="transform opacity-100 scale-100"
              leaveTo="transform opacity-0 scale-95"
            >
              <div className="relative">
                {renderNestedMenu(item.subMenu, level + 1)}
              </div>
            </Transition>
          </div>
        ) : (
          item.to ? (
            <Link
              to={item.to || '#'}
              className={`block px-4 py-2 text-sm ${
                isActive(item.to)
                  ? 'bg-gray-100 dark:bg-gray-800 text-gray-900 dark:text-white'
                  : 'text-gray-700 dark:text-gray-300 hover:bg-gray-50 dark:hover:bg-gray-800'
              }`}
              onClick={() => setIsMenuOpen(false)}
            >
              <span className="flex items-center">
                {item.icon && <span className="mr-2">{item.icon}</span>}
                {item.title}
              </span>
            </Link>
          ) : (
            <div className={`block px-4 py-2 text-sm`}>
              <span className="flex items-center">
                {item.icon && <span className="mr-2">{item.icon}</span>}
                {item.title}
              </span>
            </div>
          )
        )}
      </div>
    ));
  };

  return (
    <div className="relative">
      <nav 
        className={`fixed w-full z-50 transition-all duration-300 ${
          scrolled ? 'bg-white dark:bg-gray-900 shadow-md py-2' : 'bg-white/80 dark:bg-gray-900/80 backdrop-blur-sm py-4'
        }`}
        ref={menuRef}
      >
        <div className="max-w-full mx-auto px-4 sm:px-6 lg:px-8">
          <div className="flex justify-between h-16">
            <div className="flex items-center">
              <Brand
                to="/"
                className="brand-asafarim"
                brandName="ASafariM (Demo)"
              />
            </div>

            {/* Desktop menu */}
            <div className="hidden lg:flex items-center space-x-4">
              {/* Main Navigation Items - filter out items we're handling separately */}
              {navItems
                .filter(item => item?.isForNavbar && 
                  !['dashboard', 'about', 'contact'].includes(item.id || ''))
                .map((item, index) => (
                  <ResponsiveDropdownMenu
                    key={index}
                    topbarNavData={[item]}
                    className="block"
                  />
                ))}
              
              {/* TechDocs Dropdown */}
              <ResponsiveDropdownMenu
                topbarNavData={[mdFiles.techDocs]}
                className="block"
              />
              
              {/* Dashboard Dropdown */}
              {dashboardItem && (
                <ResponsiveDropdownMenu
                  topbarNavData={[dashboardItem]}
                  className="block"
                />
              )}
              
              {/* About Page Link */}
              {aboutItem && (
                <Link
                  to={aboutItem.to || '#'}
                  className="text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 px-3 py-2 rounded-md text-sm font-medium"
                >
                  {aboutItem.title}
                </Link>
              )}
              
              {/* Contact Page Link */}
              {contactItem && (
                <Link
                  to={contactItem.to || '#'}
                  className="text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 px-3 py-2 rounded-md text-sm font-medium"
                >
                  {contactItem.title}
                </Link>
              )}
              
              {viewWidth > 400 && <ASMButton />}
              
              {/* Theme Toggle */}
              <button
                onClick={toggleTheme}
                className="text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white p-2 rounded-full focus:outline-none"
                aria-label="Toggle theme"
              >
                {theme === 'dark' ? (
                  <SunIcon className="h-6 w-6" aria-hidden="true" />
                ) : (
                  <MoonIcon className="h-6 w-6" aria-hidden="true" />
                )}
              </button>
              
              {/* Changelogs */}
              <ChangeLogsDropdown mobileView={false} />
              
              {/* Auth */}
              {authenticated && token && authenticatedUser ? (
                <UserDropdown mobileView={false} themeToggler={null} />
              ) : (
                <div className="flex items-center space-x-2">
                  <Link
                    to="/login"
                    className="text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 px-3 py-2 rounded-md text-sm font-medium"
                  >
                    Login
                  </Link>
                  <Link
                    to="/register"
                    className="bg-primary text-white px-3 py-2 rounded-md text-sm font-medium hover:bg-primary-dark"
                  >
                    Register
                  </Link>
                </div>
              )}
            </div>

            {/* Mobile menu button */}
            <div className="lg:hidden flex items-center">
              {/* Theme Toggle for Mobile */}
              <button
                onClick={toggleTheme}
                className="text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white p-2 rounded-full focus:outline-none mr-2"
                aria-label="Toggle theme"
              >
                {theme === 'dark' ? (
                  <SunIcon className="h-6 w-6" aria-hidden="true" />
                ) : (
                  <MoonIcon className="h-6 w-6" aria-hidden="true" />
                )}
              </button>

              <button
                onClick={() => setIsMenuOpen(!isMenuOpen)}
                className="p-2 rounded-md text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 focus:outline-none"
                aria-expanded={isMenuOpen}
                aria-controls="mobile-menu"
              >
                <span className="sr-only">Open main menu</span>
                {isMenuOpen ? (
                  <XMarkIcon className="h-6 w-6" aria-hidden="true" />
                ) : (
                  <Bars3Icon className="h-6 w-6" aria-hidden="true" />
                )}
              </button>
            </div>
          </div>
        </div>

        {/* Mobile menu */}
        <Transition
          show={isMenuOpen}
          enter="transition ease-out duration-100 transform"
          enterFrom="opacity-0 scale-95"
          enterTo="opacity-100 scale-100"
          leave="transition ease-in duration-75 transform"
          leaveFrom="opacity-100 scale-100"
          leaveTo="opacity-0 scale-95"
        >
          <div className="lg:hidden" id="mobile-menu">
            <div className="px-2 pt-2 pb-3 space-y-1 sm:px-3 bg-white dark:bg-gray-900 shadow-lg">
              {/* Main Navigation Items - filter out items we're handling separately */}
              <div className="py-1">
                {navItems
                  .filter(item => item?.isForNavbar && 
                    !['dashboard', 'about', 'contact'].includes(item.id || ''))
                  .map((item, index) => (
                    <div key={index} className="py-1">
                      {renderNestedMenu([item])}
                    </div>
                  ))}
              </div>
              
              {/* TechDocs Dropdown for Mobile */}
              <div className="py-1">
                {renderNestedMenu([mdFiles.techDocs])}
              </div>
              
              {/* Dashboard Dropdown for Mobile */}
              {dashboardItem && (
                <div className="py-1">
                  {renderNestedMenu([dashboardItem])}
                </div>
              )}
              
              {/* About Page Link for Mobile */}
              {aboutItem && (
                <div className="px-4 py-2">
                  <Link
                    to={aboutItem.to || '#'}
                    className="block text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 px-3 py-2 rounded-md text-sm font-medium"
                    onClick={() => setIsMenuOpen(false)}
                  >
                    {aboutItem.title}
                  </Link>
                </div>
              )}
              
              {/* Contact Page Link for Mobile */}
              {contactItem && (
                <div className="px-4 py-2">
                  <Link
                    to={contactItem.to || '#'}
                    className="block text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 px-3 py-2 rounded-md text-sm font-medium"
                    onClick={() => setIsMenuOpen(false)}
                  >
                    {contactItem.title}
                  </Link>
                </div>
              )}
              
              {viewWidth <= 400 && (
                <div className="py-1">
                  <ASMButton />
                </div>
              )}
              
              {/* Changelogs for Mobile */}
              <ChangeLogsDropdown mobileView={true} />
              
              {/* Auth for Mobile */}
              {authenticated && token && authenticatedUser ? (
                <UserDropdown mobileView={true} themeToggler={null} />
              ) : (
                <div className="px-4 py-2 space-y-1">
                  <Link
                    to="/login"
                    className="block text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 px-3 py-2 rounded-md text-sm font-medium"
                    onClick={() => setIsMenuOpen(false)}
                  >
                    Login
                  </Link>
                  <Link
                    to="/register"
                    className="block bg-primary text-white px-3 py-2 rounded-md text-sm font-medium hover:bg-primary-dark"
                    onClick={() => setIsMenuOpen(false)}
                  >
                    Register
                  </Link>
                </div>
              )}
            </div>
          </div>
        </Transition>
      </nav>

      {/* Breadcrumbs - shown below the navbar but still fixed */}
      {location.pathname !== '/' && (
        <div className="fixed w-full bg-gray-50 dark:bg-gray-800 border-t border-gray-200 dark:border-gray-700 z-40" style={{ top: 'calc(var(--navbar-height) + 30px)' }}> 
          <div className="max-w-full mx-auto px-4 sm:px-6 lg:px-8">
            <div className="flex items-center py-2 text-sm breadcrumbs">
              <Link to="/" className="text-gray-500 hover:text-gray-700 dark:text-gray-400 dark:hover:text-gray-300">
                <HomeIcon className="h-4 w-4 inline-block mr-1" />
                Home
              </Link>
              {location.pathname.split('/').filter(Boolean).map((path, index, array) => {
                const url = `/${array.slice(0, index + 1).join('/')}`;
                const isLast = index === array.length - 1;
                return (
                  <React.Fragment key={path}>
                    <span className="mx-2 text-gray-400 separator">/</span>
                    {isLast ? (
                      <span className="text-primary font-medium current">{path.charAt(0).toUpperCase() + path.slice(1)}</span>
                    ) : (
                      <Link to={url} className="text-gray-500 hover:text-gray-700 dark:text-gray-400 dark:hover:text-gray-300">
                        {path.charAt(0).toUpperCase() + path.slice(1)}
                      </Link>
                    )}
                  </React.Fragment>
                );
              })}
            </div>
          </div>
        </div>
      )}

      {/* Main content spacer to prevent content from being hidden under the navbar and breadcrumbs */}
      <div className={`${location.pathname !== '/' ? 'pt-28' : 'pt-16'}`}></div>
    </div>
  );
};

export default ModernNavbar;
