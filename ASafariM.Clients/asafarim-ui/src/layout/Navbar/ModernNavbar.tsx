import React, { useState, useEffect, useRef } from "react";
import { Link, useLocation } from "react-router-dom";
//import { useTheme } from "@/contexts/ThemeContext";
import { ThemeToggle, useTheme } from "@asafarim/react-themes";
import { useAuth } from "@/contexts/AuthContext";
import useNavItems from "@/hooks/useNavItems";
import { ChevronDownIcon } from "@heroicons/react/20/solid";
import {
  Bars3Icon,
  XMarkIcon,
  // MoonIcon,
  // SunIcon,
  HomeIcon,
} from "@heroicons/react/24/outline";
import ChangeLogsDropdown from "./ChangeLogsDropdown";
import UserDropdown from "@/components/user/UserDropdown";
import "./ModernNavbar.css";
import Brand from "./components/Brand";
import ASMButton from "./components/ASMButton";
import ResponsiveDropdownMenu from "./components/ResponsiveDropdownMenu";
import { IMenuItem } from "@/interfaces/IMenuItem";
import mdFilesUtils from "@/utils/mdFilesUtils";
import { logger } from "@/utils/logger";
import { Transition } from "@headlessui/react";

const ModernNavbar: React.FC = () => {
  const { authenticatedUser, authenticated } = useAuth();
  const location = useLocation();
  const navItems = useNavItems();
  const mdFiles = mdFilesUtils.getAllMdFiles();

  // Find specific nav items
  const dashboardItem = navItems.find((item) => item.id === "dashboard");
  const aboutItem = navItems.find((item) => item.id === "about");
  const contactItem = navItems.find((item) => item.id === "contact");
  // Get current projects directly from mdFiles instead of navItems
  const currentProjects = mdFiles.currentProjects;

  const [isMenuOpen, setIsMenuOpen] = useState(false);
  const [scrolled, setScrolled] = useState(false);
  const [viewWidth, setViewWidth] = useState(window.innerWidth);
  const [activeDropdowns, setActiveDropdowns] = useState<string[]>([]);
  const menuRef = useRef<HTMLDivElement>(null);

  // Check if current path matches the given path
  const isActive = (path: string | undefined): boolean => {
    if (!path || path === "#") return false;
    return (
      location.pathname === path || location.pathname.startsWith(path + "/")
    );
  };

  const { currentTheme } = useTheme();

  // Handle scroll events to change navbar appearance
  useEffect(() => {
    const handleScroll = () => {
      const offset = window.scrollY;
      setScrolled(offset > 10);
    };

    logger.log("Adding scroll event listener");
    window.addEventListener("scroll", handleScroll);
    return () => {
      logger.log("Removing scroll event listener");
      window.removeEventListener("scroll", handleScroll);
    };
  }, []);

  // Handle resize events to update viewWidth
  useEffect(() => {
    const handleResize = () => {
      setViewWidth(window.innerWidth);
      if (window.innerWidth >= 1024) {
        setIsMenuOpen(false);
        setActiveDropdowns([]);
      }
    };

    window.addEventListener("resize", handleResize);
    return () => window.removeEventListener("resize", handleResize);
  }, []);

  // Close mobile menu when clicking outside
  useEffect(() => {
    const handleClickOutside = (event: MouseEvent) => {
      if (menuRef.current && !menuRef.current.contains(event.target as Node)) {
        if (isMenuOpen) {
          setIsMenuOpen(false);
        }
        setActiveDropdowns([]);
      }
    };

    document.addEventListener("mousedown", handleClickOutside);
    return () => document.removeEventListener("mousedown", handleClickOutside);
  }, [isMenuOpen]);

  // Handle dropdown toggle
  const toggleDropdown = (id: string) => {
    setActiveDropdowns((prev) =>
      prev.includes(id) ? prev.filter((item) => item !== id) : [...prev, id]
    );
  };

  // Render nested menu items for mobile view
  const renderNestedMenu = (
    items: IMenuItem[],
    parentPath: string = "",
    depth: number = 0
  ) => {
    return items.map((item, idx) => {
      const itemId = item.id || `${parentPath}-${idx}`;
      const isOpen = activeDropdowns.includes(itemId);

      return (
        <div
          key={itemId}
          className="w-full"
          style={{
            backgroundColor: currentTheme.colors.background,
            color: currentTheme.colors.text,
          }}
        >
          {item.subMenu && item.subMenu.length > 0 ? (
            <div className="w-full">
              <div
                className={`flex justify-between items-center w-full px-4 py-2 text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 rounded-md text-sm font-medium cursor-pointer ${
                  isOpen ? "bg-gray-100 dark:bg-gray-800" : ""
                }`}
                style={{ paddingLeft: `${depth * 0.5 + 1}rem` }}
                onClick={() => toggleDropdown(itemId)}
              >
                <span className="flex items-center">
                  {item.icon && <span className="mr-2">{item.icon}</span>}
                  {item.title}
                </span>
                <ChevronDownIcon
                  className={`h-5 w-5 transition-transform ${
                    isOpen ? "transform rotate-180" : ""
                  }`}
                />
              </div>
              {isOpen && (
                <div className="mt-1 space-y-1">
                  {item.subMenu.map((subItem, subIdx) => {
                    const subItemId = subItem.id || `${itemId}-${subIdx}`;

                    return (
                      <div
                        key={subItemId}
                        className="w-full"
                        style={{
                          backgroundColor: currentTheme.colors.background,
                          color: currentTheme.colors.text,
                        }}
                      >
                        {subItem.to && !subItem.to.startsWith("#") ? (
                          <Link
                            to={subItem.to}
                            className={`block px-4 py-2 text-sm text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 rounded-md ${
                              isActive(subItem.to)
                                ? "bg-gray-100 dark:bg-gray-800 font-semibold"
                                : ""
                            }`}
                            style={{
                              paddingLeft: `${(depth + 1) * 0.5 + 1}rem`,
                            }}
                            onClick={() => {
                              setIsMenuOpen(false);
                              setActiveDropdowns([]);
                            }}
                          >
                            <span className="flex items-center">
                              {subItem.icon && (
                                <span className="mr-2">{subItem.icon}</span>
                              )}
                              {subItem.title}
                            </span>
                          </Link>
                        ) : subItem.subMenu && subItem.subMenu.length > 0 ? (
                          <div className="w-full">
                            {renderNestedMenu([subItem], subItemId, depth + 1)}
                          </div>
                        ) : (
                          <div
                            className="px-4 py-2 text-sm text-gray-700 dark:text-gray-300"
                            style={{
                              paddingLeft: `${(depth + 1) * 0.5 + 1}rem`,
                            }}
                          >
                            <span className="flex items-center">
                              {subItem.icon && (
                                <span className="mr-2">{subItem.icon}</span>
                              )}
                              {subItem.title}
                            </span>
                          </div>
                        )}
                      </div>
                    );
                  })}
                </div>
              )}
            </div>
          ) : (
            <Link
              to={item.to || "#"}
              className={`block px-4 py-2 text-sm text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 rounded-md ${
                isActive(item.to)
                  ? "bg-gray-100 dark:bg-gray-800 font-semibold"
                  : ""
              }`}
              style={{ paddingLeft: `${depth * 0.5 + 1}rem` }}
              onClick={() => setIsMenuOpen(false)}
            >
              <span className="flex items-center">
                {item.icon && <span className="mr-2">{item.icon}</span>}
                {item.title}
              </span>
            </Link>
          )}
        </div>
      );
    });
  };

  return (
    <div
      className="relative"
      style={{
        backgroundColor: currentTheme.colors.background,
        color: currentTheme.colors.text,
      }}
    >
      <nav
        className={`fixed w-full z-50 transition-all duration-300 ${
          scrolled
            ? "bg-white dark:bg-gray-900 shadow-md py-2"
            : "bg-white/80 dark:bg-gray-900/80 backdrop-blur-sm py-4"
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
              {/* Current Projects Dropdown - Using data directly from mdFiles */}
              <ResponsiveDropdownMenu
                topbarNavData={[currentProjects]}
                className="block"
              />

              {/* Main Navigation Items - filter out items we're handling separately */}
              {navItems
                .filter(
                  (item) =>
                    item?.isForNavbar &&
                    !["dashboard", "about", "contact", "current-projects"].includes(item.id || "")
                )
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
                  to={aboutItem.to || "#"}
                  className="text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 px-3 py-2 rounded-md text-sm font-medium"
                >
                  {aboutItem.title}
                </Link>
              )}

              {/* Contact Page Link */}
              {contactItem && (
                <Link
                  to={contactItem.to || "#"}
                  className="text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 px-3 py-2 rounded-md text-sm font-medium"
                >
                  {contactItem.title}
                </Link>
              )}

              {/* ASM Button for Desktop */}
              <ASMButton
                onlyIcon={viewWidth < 768}
                onClick={() =>
                  window.open("https://pbk.asafarim.com/resume", "_blank")
                }
                width="24"
                height="24"
              />

              {/* Theme Toggle */}
              <ThemeToggle size="sm" showLabels={false} />

              {/* Blog Link */}
              <a
                href="https://blog.asafarim.com"
                target="_blank"
                rel="noopener noreferrer"
                className="text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 px-3 py-2 rounded-md text-sm font-medium flex items-center group"
                title="Visit Blog"
              >
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  viewBox="0 0 24 24"
                  fill="none"
                  stroke="currentColor"
                  strokeWidth="1.5"
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  className="h-5 w-5 mr-1 group-hover:animate-pulse"
                >
                  <path d="M4 19.5v-15A2.5 2.5 0 0 1 6.5 2H20v20H6.5a2.5 2.5 0 0 1-2.5-2.5z" />
                  <path d="M8 7h8" />
                  <path d="M8 11h8" />
                  <path d="M8 15h5" />
                  <circle
                    cx="16"
                    cy="16"
                    r="2"
                    className="fill-current group-hover:fill-[var(--primary)]"
                  />
                </svg>
                <span className="group-hover:text-[var(--primary)] transition-colors duration-200">
                  Blog
                </span>
              </a>

              {/* Changelogs */}
              <ChangeLogsDropdown mobileView={false} />

              {/* Auth */}
              {authenticated && authenticatedUser ? (
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
                    className="block bg-[var(--primary)] text-[var(--text-inverted)] dark:text-[var(--text-secondary)] px-3 py-2 rounded-md text-sm font-medium hover:bg-[var(--primary)]"
                    onClick={() => setIsMenuOpen(false)}
                  >
                    Register
                  </Link>
                </div>
              )}
            </div>

            {/* Mobile menu button */}
            <div className="lg:hidden flex items-center">
              {/* ASM Button for Mobile Header */}
              <div className="mr-2">
                <ASMButton
                  onlyIcon={viewWidth < 480}
                  onClick={() =>
                    window.open("https://pbk.asafarim.com/resume", "_blank")
                  }
                  width="24"
                  height="24"
                />
              </div>

              {/* Theme Toggle for Mobile */}
              <ThemeToggle size="sm" showLabels={false} />

              {/* Blog Link for Mobile */}
              <a
                href="https://blog.asafarim.com"
                target="_blank"
                rel="noopener noreferrer"
                className="text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white p-2 rounded-full focus:outline-none mr-2 group"
                title="Visit Blog"
              >
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  viewBox="0 0 24 24"
                  fill="none"
                  stroke="currentColor"
                  strokeWidth="1.5"
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  className="h-6 w-6 group-hover:animate-pulse"
                >
                  <path d="M4 19.5v-15A2.5 2.5 0 0 1 6.5 2H20v20H6.5a2.5 2.5 0 0 1-2.5-2.5z" />
                  <path d="M8 7h8" />
                  <path d="M8 11h8" />
                  <path d="M8 15h5" />
                  <circle
                    cx="16"
                    cy="16"
                    r="2"
                    className="fill-current group-hover:fill-[var(--primary)]"
                  />
                </svg>
              </a>

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
                  .filter(
                    (item) =>
                      item?.isForNavbar &&
                      !["dashboard", "about", "contact"].includes(item.id || "")
                  )
                  .map((item, index) => (
                    <div key={index} className="py-1">
                      {renderNestedMenu([item])}
                    </div>
                  ))}
              </div>

              {/* TechDocs Dropdown for Mobile */}
              <div className="py-1">{renderNestedMenu([mdFiles.techDocs])}</div>

              {/* Dashboard Dropdown for Mobile */}
              {dashboardItem && (
                <div className="py-1">{renderNestedMenu([dashboardItem])}</div>
              )}

              {/* About Page Link for Mobile */}
              {aboutItem && (
                <div className="px-4 py-2">
                  <Link
                    to={aboutItem.to || "#"}
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
                    to={contactItem.to || "#"}
                    className="block text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 px-3 py-2 rounded-md text-sm font-medium"
                    onClick={() => setIsMenuOpen(false)}
                  >
                    {contactItem.title}
                  </Link>
                </div>
              )}

              {/* Blog Link for Mobile Menu */}
              <div className="px-4 py-2">
                <a
                  href="https://blog.asafarim.com"
                  target="_blank"
                  rel="noopener noreferrer"
                  className="block text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-800 px-3 py-2 rounded-md text-sm font-medium flex items-center group"
                  onClick={() => setIsMenuOpen(false)}
                >
                  <svg
                    xmlns="http://www.w3.org/2000/svg"
                    viewBox="0 0 24 24"
                    fill="none"
                    stroke="currentColor"
                    strokeWidth="1.5"
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    className="h-5 w-5 mr-2 group-hover:animate-pulse"
                  >
                    <path d="M4 19.5v-15A2.5 2.5 0 0 1 6.5 2H20v20H6.5a2.5 2.5 0 0 1-2.5-2.5z" />
                    <path d="M8 7h8" />
                    <path d="M8 11h8" />
                    <path d="M8 15h5" />
                    <circle
                      cx="16"
                      cy="16"
                      r="2"
                      className="fill-current group-hover:fill-[var(--primary)]"
                    />
                  </svg>
                  <span className="group-hover:text-[var(--primary)] transition-colors duration-200">
                    Blog
                  </span>
                </a>
              </div>

              {/* Changelogs for Mobile */}
              <ChangeLogsDropdown mobileView={true} />

              {/* Auth for Mobile */}
              {authenticated && authenticatedUser ? (
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
      {location.pathname !== "/" && (
        <div
          className="fixed w-full bg-gray-50 dark:bg-gray-800 border-t border-gray-200 dark:border-gray-700 z-40"
          style={{ top: "calc(var(--navbar-height) + 30px)" }}
        >
          <div className="max-w-full mx-auto px-4 sm:px-6 lg:px-8">
            <div className="flex items-center py-2 text-sm breadcrumbs">
              <Link
                to="/"
                className="text-gray-500 hover:text-gray-700 dark:text-gray-400 dark:hover:text-gray-300"
              >
                <HomeIcon className="h-4 w-4 inline-block mr-1" />
                Home
              </Link>
              {location.pathname
                .split("/")
                .filter(Boolean)
                .map((path, index, array) => {
                  const url = `/${array.slice(0, index + 1).join("/")}`;
                  const isLast = index === array.length - 1;
                  return (
                    <React.Fragment key={path}>
                      <span className="mx-2 text-gray-400 separator">/</span>
                      {isLast ? (
                        <span className="text-primary font-medium current">
                          {path.charAt(0).toUpperCase() + path.slice(1)}
                        </span>
                      ) : (
                        <Link
                          to={url}
                          className="text-gray-500 hover:text-gray-700 dark:text-gray-400 dark:hover:text-gray-300"
                        >
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
      <div className={`${location.pathname !== "/" ? "pt-28" : "pt-16"}`}></div>
    </div>
  );
};

export default ModernNavbar;

