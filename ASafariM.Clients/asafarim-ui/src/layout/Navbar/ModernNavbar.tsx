import React, { useState, useEffect, useRef } from 'react';
import { Link, useLocation } from 'react-router-dom';
import { useTheme } from '@/contexts/ThemeContext';
import useAuth from '@/hooks/useAuth';
import useNavItems from '@/hooks/useNavItems';
import { ChevronDownIcon } from '@heroicons/react/20/solid';
import { Bars3Icon, XMarkIcon, MoonIcon, SunIcon, HomeIcon } from '@heroicons/react/24/outline';
import { Transition, Menu } from '@headlessui/react';
import ChangeLogsDropdown from './ChangeLogsDropdown';
import UserDropdown from '@/components/user/UserDropdown';
import './ModernNavbar.css';
import Brand from './components/Brand';
import ASMButton from './components/ASMButton';

// Define types for navigation items
interface NavSubItem {
  id: string;
  title?: string;
  className?: string;
  description?: string;
  label?: string;
  style?: React.CSSProperties;
  name?: string;
  to?: string;
  icon?: React.ReactNode;
  isForNavbar?: boolean;
  subMenu?: NavSubItem[];
}

interface NavItem {
  id: string;
  title?: string;
  className?: string;
  description?: string;
  label?: string;
  style?: React.CSSProperties;
  name?: string;
  to?: string;
  icon?: React.ReactNode;
  isForNavbar?: boolean;
  subMenu?: NavItem[];
}

interface NestedDropdownProps {
  item: NavItem;
  isActive: (path: string) => boolean;
  isMobile?: boolean;
}

interface NestedSubMenuProps {
  item: NavSubItem;
  isActive: (path: string) => boolean;
}

interface MobileMenuItemProps {
  item: NavItem;
  isActive: (path: string) => boolean;
}

interface MobileSubMenuItemProps {
  item: NavSubItem;
  isActive: (path: string) => boolean;
}

// Recursive component for nested dropdown menus
const NestedDropdown: React.FC<NestedDropdownProps> = ({ item, isActive, isMobile = false }) => {
  const [isOpen, setIsOpen] = useState(false);
  const dropdownRef = useRef<HTMLDivElement>(null);

  // Close dropdown when clicking outside
  useEffect(() => {
    if (!isMobile) {
      const handleClickOutside = (event: MouseEvent) => {
        if (dropdownRef.current && !dropdownRef.current.contains(event.target as Node)) {
          setIsOpen(false);
        }
      };
      
      document.addEventListener('mousedown', handleClickOutside);
      return () => document.removeEventListener('mousedown', handleClickOutside);
    }
  }, [isMobile]);

  if (!item.subMenu || item.subMenu.length === 0) {
    return (
      <Link
        to={item.to || '#'}
        className={`${
          isActive(item.to || '') 
            ? 'text-primary' 
            : 'text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white'
        } px-3 py-2 rounded-md text-sm font-medium transition-colors duration-200`}
      >
        {item.icon && <span className="mr-2">{item.icon}</span>}
        {item.title}
      </Link>
    );
  }

  return (
    <div ref={dropdownRef} className="relative">
      <button
        onClick={() => setIsOpen(!isOpen)}
        className={`${
          isActive(item.to || '') 
            ? 'text-primary' 
            : 'text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white'
        } flex items-center px-3 py-2 rounded-md text-sm font-medium transition-colors duration-200`}
        aria-expanded={isOpen}
      >
        {item.icon && <span className="mr-2">{item.icon}</span>}
        {item.title}
        <ChevronDownIcon 
          className={`ml-1 h-5 w-5 transition-transform duration-200 ${isOpen ? 'rotate-180' : ''}`} 
          aria-hidden="true" 
        />
      </button>

      {isOpen && (
        <div className="absolute left-0 mt-2 w-56 origin-top-right rounded-md bg-white dark:bg-gray-800 shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none z-50">
          <div className="py-1">
            {item.subMenu && item.subMenu.map((subItem: NavItem, subIndex: number) => (
              <div key={subIndex}>
                {subItem.subMenu && subItem.subMenu.length > 0 ? (
                  <NestedSubMenu item={subItem} isActive={isActive} />
                ) : (
                  <Link
                    to={subItem.to || '#'}
                    className={`${
                      isActive(subItem.to || '') 
                        ? 'bg-gray-100 dark:bg-gray-700 text-primary' 
                        : 'text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-700'
                    } block px-4 py-2 text-sm transition-colors duration-200`}
                  >
                    {subItem.icon && <span className="mr-2">{subItem.icon}</span>}
                    {subItem.title}
                  </Link>
                )}
              </div>
            ))}
          </div>
        </div>
      )}
    </div>
  );
};

// Component for nested submenus within dropdowns
const NestedSubMenu: React.FC<NestedSubMenuProps> = ({ item, isActive }) => {
  const [isOpen, setIsOpen] = useState(false);
  const subMenuRef = useRef<HTMLDivElement>(null);

  // Close dropdown when clicking outside
  useEffect(() => {
    const handleClickOutside = (event: MouseEvent) => {
      if (subMenuRef.current && !subMenuRef.current.contains(event.target as Node)) {
        setIsOpen(false);
      }
    };
    
    document.addEventListener('mousedown', handleClickOutside);
    return () => document.removeEventListener('mousedown', handleClickOutside);
  }, []);

  return (
    <div ref={subMenuRef} className="relative group">
      <button
        onClick={() => setIsOpen(!isOpen)}
        className="flex items-center justify-between w-full px-4 py-2 text-sm text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-700 transition-colors duration-200"
        aria-expanded={isOpen}
      >
        <div className="flex items-center">
          {item.icon && <span className="mr-2">{item.icon}</span>}
          {item.title}
        </div>
        <ChevronDownIcon 
          className={`ml-1 h-5 w-5 transition-transform duration-200 ${isOpen ? 'rotate-180' : ''}`} 
          aria-hidden="true" 
        />
      </button>

      {isOpen && (
        <div className="absolute left-full top-0 w-56 -ml-1 rounded-md bg-white dark:bg-gray-800 shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none z-50">
          <div className="py-1">
            {item.subMenu && item.subMenu.map((subSubItem, subSubIndex) => (
              <Link
                key={subSubIndex}
                to={subSubItem.to || '#'}
                className={`${
                  isActive(subSubItem.to || '') 
                    ? 'bg-gray-100 dark:bg-gray-700 text-primary' 
                    : 'text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-700'
                } block px-4 py-2 text-sm transition-colors duration-200`}
              >
                {subSubItem.icon && <span className="mr-2">{subSubItem.icon}</span>}
                {subSubItem.title}
              </Link>
            ))}
          </div>
        </div>
      )}
    </div>
  );
};

const ModernNavbar: React.FC = () => {
  const { authenticatedUser, authenticated, token } = useAuth();
  const { theme, toggleTheme } = useTheme();
  const location = useLocation();
  const navItems = useNavItems() as NavItem[];
  
  const [isMenuOpen, setIsMenuOpen] = useState(false);
  const [scrolled, setScrolled] = useState(false);
  const [viewWidth, setViewWidth] = useState(window.innerWidth);
  const menuRef = useRef<HTMLDivElement>(null);

  // Check if current path matches the given path
  const isActive = (path: string): boolean => {
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
      }
    };

    window.addEventListener('resize', handleResize);
    return () => window.removeEventListener('resize', handleResize);
  }, []);

  // Close mobile menu when clicking outside
  useEffect(() => {
    const handleClickOutside = (event: MouseEvent) => {
      if (menuRef.current && !menuRef.current.contains(event.target as Node) && isMenuOpen) {
        setIsMenuOpen(false);
      }
    };

    document.addEventListener('mousedown', handleClickOutside);
    return () => document.removeEventListener('mousedown', handleClickOutside);
  }, [isMenuOpen]);

  return (
    <>
      <nav 
        className={`fixed w-full z-50 transition-all duration-300 ${
          scrolled ? 'bg-white dark:bg-gray-900 shadow-md py-2' : 'bg-white/80 dark:bg-gray-900/80 backdrop-blur-sm py-4'
        }`}
        ref={menuRef}
      >
        <div className="max-w-full mx-auto px-4 sm:px-6 lg:px-8">
          <div className="flex justify-between h-16">
            <div className="flex items-center">
              {/* Logo/Brand */}
              <Brand
                to="/"
                className="brand-asafarim"
                brandName="ASafariM (Demo)"
              />
            </div>

            {/* Desktop menu */}
            <div className="hidden lg:flex items-center space-x-4">
              {/* Main Navigation Items with Nested Dropdowns */}
              {navItems
                .filter(item => item?.isForNavbar)
                .map((item: NavItem, index: number) => (
                  <NestedDropdown key={index} item={item} isActive={isActive} />
                ))}
              
              {/* Dashboard Dropdown */}
              <Menu as="div" className="relative">
                <Menu.Button 
                  className={`flex items-center ${
                    isActive('/dashboard') || isActive('/projects') || isActive('/users') || isActive('/system-health')
                      ? 'text-primary' 
                      : 'text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white'
                  } px-3 py-2 rounded-md text-sm font-medium transition-colors duration-200`}
                >
                  Dashboard
                  <ChevronDownIcon className="ml-1 h-5 w-5" aria-hidden="true" />
                </Menu.Button>
                <Transition
                  enter="transition ease-out duration-100"
                  enterFrom="transform opacity-0 scale-95"
                  enterTo="transform opacity-100 scale-100"
                  leave="transition ease-in duration-75"
                  leaveFrom="transform opacity-100 scale-100"
                  leaveTo="transform opacity-0 scale-95"
                >
                  <Menu.Items className="absolute left-0 mt-2 w-56 origin-top-left rounded-md bg-white dark:bg-gray-800 shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none z-50">
                    <div className="py-1">
                      <Menu.Item>
                        {({ active }) => (
                          <Link
                            to="/dashboard"
                            className={`${
                              active ? 'bg-gray-100 dark:bg-gray-700' : ''
                            } ${isActive('/dashboard') ? 'text-primary font-medium' : ''} block px-4 py-2 text-sm text-gray-700 dark:text-gray-300`}
                          >
                            Dashboard Home
                          </Link>
                        )}
                      </Menu.Item>
                      <Menu.Item>
                        {({ active }) => (
                          <Link
                            to="/system-health"
                            className={`${
                              active ? 'bg-gray-100 dark:bg-gray-700' : ''
                            } ${isActive('/system-health') ? 'text-primary font-medium' : ''} block px-4 py-2 text-sm text-gray-700 dark:text-gray-300`}
                          >
                            System Health Stats
                          </Link>
                        )}
                      </Menu.Item>
                      <Menu.Item>
                        {({ active }) => (
                          <Link
                            to="/projects"
                            className={`${
                              active ? 'bg-gray-100 dark:bg-gray-700' : ''
                            } ${isActive('/projects') ? 'text-primary font-medium' : ''} block px-4 py-2 text-sm text-gray-700 dark:text-gray-300`}
                          >
                            Projects
                          </Link>
                        )}
                      </Menu.Item>
                      <Menu.Item>
                        {({ active }) => (
                          <Link
                            to="/users"
                            className={`${
                              active ? 'bg-gray-100 dark:bg-gray-700' : ''
                            } ${isActive('/users') ? 'text-primary font-medium' : ''} block px-4 py-2 text-sm text-gray-700 dark:text-gray-300`}
                          >
                            Users
                          </Link>
                        )}
                      </Menu.Item>
                    </div>
                  </Menu.Items>
                </Transition>
              </Menu>

              {/* Tech Stack Dropdown */}
              <Menu as="div" className="relative">
                <Menu.Button className="flex items-center text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white px-3 py-2 rounded-md text-sm font-medium transition-colors duration-200">
                  Tech Stack
                  <ChevronDownIcon className="ml-1 h-5 w-5" aria-hidden="true" />
                </Menu.Button>
                <Transition
                  enter="transition ease-out duration-100"
                  enterFrom="transform opacity-0 scale-95"
                  enterTo="transform opacity-100 scale-100"
                  leave="transition ease-in duration-75"
                  leaveFrom="transform opacity-100 scale-100"
                  leaveTo="transform opacity-0 scale-95"
                >
                  <Menu.Items className="absolute right-0 mt-2 w-56 origin-top-right rounded-md bg-white dark:bg-gray-800 shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none z-50">
                    <div className="py-1">
                      <Menu.Item>
                        {({ active }) => (
                          <Link
                            to="/projects/frontend"
                            className={`${
                              active ? 'bg-gray-100 dark:bg-gray-700' : ''
                            } block px-4 py-2 text-sm text-gray-700 dark:text-gray-300`}
                          >
                            Frontend Development
                          </Link>
                        )}
                      </Menu.Item>
                      <Menu.Item>
                        {({ active }) => (
                          <Link
                            to="/projects/backend"
                            className={`${
                              active ? 'bg-gray-100 dark:bg-gray-700' : ''
                            } block px-4 py-2 text-sm text-gray-700 dark:text-gray-300`}
                          >
                            Backend Development
                          </Link>
                        )}
                      </Menu.Item>
                      <Menu.Item>
                        {({ active }) => (
                          <Link
                            to="/projects/data-analysis"
                            className={`${
                              active ? 'bg-gray-100 dark:bg-gray-700' : ''
                            } block px-4 py-2 text-sm text-gray-700 dark:text-gray-300`}
                          >
                            Data Analysis
                          </Link>
                        )}
                      </Menu.Item>
                      <Menu.Item>
                        {({ active }) => (
                          <Link
                            to="/projects/ai-ml"
                            className={`${
                              active ? 'bg-gray-100 dark:bg-gray-700' : ''
                            } block px-4 py-2 text-sm text-gray-700 dark:text-gray-300`}
                          >
                            AI & Machine Learning
                          </Link>
                        )}
                      </Menu.Item>
                    </div>
                  </Menu.Items>
                </Transition>
              </Menu>

              {/* About Link */}
              <Link
                to="/about"
                className={`${
                  isActive('/about') 
                    ? 'text-primary' 
                    : 'text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white'
                } px-3 py-2 rounded-md text-sm font-medium transition-colors duration-200`}
              >
                About
              </Link>

              {/* Contact Link */}
              <Link
                to="/contact"
                className={`${
                  isActive('/contact') 
                    ? 'text-primary' 
                    : 'text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white'
                } px-3 py-2 rounded-md text-sm font-medium transition-colors duration-200`}
              >
                Contact
              </Link>
              
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
              
              {/* Resume Button */}
              {viewWidth > 400 && <ASMButton />}
              
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
          <div className="lg:hidden mobile-menu" id="mobile-menu">
            <div className="px-2 pt-2 pb-3 space-y-1 sm:px-3 bg-white dark:bg-gray-900 shadow-lg">
              {/* Main Navigation Items with Mobile-Optimized Nested Menus */}
              {navItems
                .filter(item => item?.isForNavbar)
                .map((item: NavItem, index: number) => (
                  <MobileMenuItem key={index} item={item} isActive={isActive} />
                ))}
              
              {/* Tech Stack Links */}
              <div className="py-1">
                <div className="text-gray-700 dark:text-gray-300 px-3 py-2 rounded-md text-base font-medium">
                  Tech Stack
                </div>
                <div className="pl-4 space-y-1 mt-1">
                  <Link
                    to="/projects/frontend"
                    className="text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm"
                  >
                    Frontend Development
                  </Link>
                  <Link
                    to="/projects/backend"
                    className="text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm"
                  >
                    Backend Development
                  </Link>
                  <Link
                    to="/projects/data-analysis"
                    className="text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm"
                  >
                    Data Analysis
                  </Link>
                  <Link
                    to="/projects/ai-ml"
                    className="text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm"
                  >
                    AI & Machine Learning
                  </Link>
                </div>
              </div>

              {/* Dashboard Dropdown for Mobile */}
              <div className="py-1">
                <div className="text-gray-700 dark:text-gray-300 px-3 py-2 rounded-md text-base font-medium">
                  Dashboard
                </div>
                <div className="pl-4 space-y-1 mt-1">
                  <Link
                    to="/dashboard"
                    className={`text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm ${isActive('/dashboard') ? 'text-primary font-medium' : ''}`}
                  >
                    Dashboard Home
                  </Link>
                  <Link
                    to="/system-health"
                    className={`text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm ${isActive('/system-health') ? 'text-primary font-medium' : ''}`}
                  >
                    System Health Stats
                  </Link>
                  <Link
                    to="/projects"
                    className={`text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm ${isActive('/projects') ? 'text-primary font-medium' : ''}`}
                  >
                    Projects
                  </Link>
                  <Link
                    to="/users"
                    className={`text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm ${isActive('/users') ? 'text-primary font-medium' : ''}`}
                  >
                    Users
                  </Link>
                </div>
              </div>

              {/* About Link for Mobile */}
              <Link
                to="/about"
                className="text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm font-medium"
              >
                About
              </Link>

              {/* Contact Link for Mobile */}
              <Link
                to="/contact"
                className="text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm font-medium"
              >
                Contact
              </Link>

              {/* Resume Button for Mobile */}
              {viewWidth <= 400 && (
                <div className="py-1">
                  <a
                    href="https://sites.google.com/view/asafarim-it"
                    target="_blank"
                    rel="noopener noreferrer"
                    className="flex items-center text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white px-3 py-2 rounded-md text-sm"
                  >
                    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" fill="currentColor" className="w-5 h-5 mr-2">
                      <path d="M5.625 1.5c-1.036 0-1.875.84-1.875 1.875v17.25c0 1.035.84 1.875 1.875 1.875h12.75c1.035 0 1.875-.84 1.875-1.875V12.75A3.75 3.75 0 0016.5 9h-1.875a1.875 1.875 0 01-1.875-1.875V5.25A3.75 3.75 0 009 1.5H5.625z" />
                      <path d="M12.971 1.816A5.23 5.23 0 0114.25 5.25v1.875c0 .207.168.375.375.375H16.5a5.23 5.23 0 013.434 1.279 9.768 9.768 0 00-6.963-6.963z" />
                    </svg>
                    Resume
                  </a>
                </div>
              )}
              
              {/* Changelogs for Mobile */}
              <ChangeLogsDropdown mobileView={true} />
              
              {/* Auth for Mobile */}
              {authenticated && token && authenticatedUser ? (
                <UserDropdown mobileView={true} themeToggler={null} />
              ) : (
                <div className="py-1 space-y-1">
                  <Link
                    to="/login"
                    className="text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm"
                  >
                    Login
                  </Link>
                  <Link
                    to="/register"
                    className="text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white block px-3 py-2 rounded-md text-sm font-medium"
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
        <div className="fixed w-full bg-gray-50 dark:bg-gray-800 border-t border-gray-200 dark:border-gray-700 z-40" style={{ top: 'var(--navbar-height)' }}>
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
    </>
  );
};

// Component for mobile menu items with collapsible submenus
const MobileMenuItem: React.FC<MobileMenuItemProps> = ({ item, isActive }) => {
  const { title = '', icon, subMenu, to = '' } = item;
  const active = isActive(to);
  const [isOpen, setIsOpen] = useState(false);
  
  if (!item.subMenu || item.subMenu.length === 0) {
    return (
      <Link
        to={item.to || '#'}
        className={`${
          active 
            ? 'text-primary bg-primary/10' 
            : 'text-gray-700 dark:text-gray-300'
        } block px-3 py-2 rounded-md text-base font-medium`}
      >
        {icon && <span className="mr-2">{icon}</span>}
        {title}
      </Link>
    );
  }
  
  return (
    <div>
      <button
        onClick={() => setIsOpen(!isOpen)}
        className={`${
          active 
            ? 'text-primary bg-primary/10' 
            : 'text-gray-700 dark:text-gray-300'
        } flex items-center justify-between w-full px-3 py-2 rounded-md text-base font-medium`}
        aria-expanded={isOpen}
      >
        <div className="flex items-center">
          {icon && <span className="mr-2">{icon}</span>}
          {title}
        </div>
        <ChevronDownIcon 
          className={`ml-1 h-5 w-5 transition-transform duration-200 ${isOpen ? 'rotate-180' : ''}`} 
          aria-hidden="true" 
        />
      </button>
      
      {isOpen && (
        <div className="pl-4 space-y-1 mt-1">
          {item.subMenu && item.subMenu.map((subItem: NavItem, subIndex: number) => (
            <MobileSubMenuItem key={subIndex} item={subItem} isActive={isActive} />
          ))}
        </div>
      )}
    </div>
  );
};

// Component for mobile submenu items with further nesting support
const MobileSubMenuItem: React.FC<MobileSubMenuItemProps> = ({ item, isActive }) => {
  const [isOpen, setIsOpen] = useState(false);
  
  if (!item.subMenu || item.subMenu.length === 0) {
    return (
      <Link
        to={item.to || '#'}
        className={`${
          isActive(item.to || '') 
            ? 'text-primary' 
            : 'text-gray-600 dark:text-gray-400'
        } block px-3 py-2 rounded-md text-sm`}
      >
        {item.icon && <span className="mr-2">{item.icon}</span>}
        {item.title}
      </Link>
    );
  }
  
  return (
    <div>
      <button
        onClick={() => setIsOpen(!isOpen)}
        className={`${
          isActive(item.to || '') 
            ? 'text-primary' 
            : 'text-gray-600 dark:text-gray-400'
        } flex items-center justify-between w-full px-3 py-2 rounded-md text-sm`}
        aria-expanded={isOpen}
      >
        <div className="flex items-center">
          {item.icon && <span className="mr-2">{item.icon}</span>}
          {item.title}
        </div>
        <ChevronDownIcon 
          className={`ml-1 h-4 w-4 transition-transform duration-200 ${isOpen ? 'rotate-180' : ''}`} 
          aria-hidden="true" 
        />
      </button>
      
      {isOpen && (
        <div className="pl-4 space-y-1 mt-1">
          {item.subMenu && item.subMenu.map((subSubItem, subSubIndex) => (
            <Link
              key={subSubIndex}
              to={subSubItem.to || '#'}
              className={`${
                isActive(subSubItem.to || '') 
                  ? 'text-primary' 
                  : 'text-gray-500 dark:text-gray-500'
              } block px-3 py-2 rounded-md text-sm`}
            >
              {subSubItem.icon && <span className="mr-2">{subSubItem.icon}</span>}
              {subSubItem.title}
            </Link>
          ))}
        </div>
      )}
    </div>
  );
};

export default ModernNavbar;
