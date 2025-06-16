import { useAuth } from "@/contexts/AuthContext";
import React, { useState, useRef, useEffect } from "react";
import { Link } from "react-router-dom";

interface IUserDropdownProps {
  themeToggler?: React.ReactNode;
  mobileView: boolean;
}

const UserDropdown: React.FC<IUserDropdownProps> = ({
  themeToggler,
  mobileView,
}) => {
  const { authenticatedUser, authenticated, token } = useAuth();

  const [isOpen, setIsOpen] = useState(false);
  const dropdownRef = useRef<HTMLDivElement>(null);

  useEffect(() => {
    const handleClickOutside = (event: MouseEvent) => {
      // Make sure event.target is valid before using it
      if (!event || !event.target) return;
      
      // Safe check if the dropdown ref exists and doesn't contain the clicked element
      if (dropdownRef.current && !dropdownRef.current.contains(event.target as Node)) {
        setIsOpen(false);
      }
    };

    // Add the event listener
    document.addEventListener("mousedown", handleClickOutside);
    
    // Clean up the event listener when component unmounts
    return () => {
      document.removeEventListener("mousedown", handleClickOutside);
    };
  }, []);

  if (!authenticated || !token) return null;

  return (
    authenticatedUser && (
      <div className="relative" ref={dropdownRef}>
        <button
          onClick={() => setIsOpen(!isOpen)}
          className="flex items-center space-x-2 text-[var(--text-info)] hover:text-[var(--info)] focus:outline-none transition-colors duration-200"
        >
          <div className="w-8 h-8 rounded-full bg-[var(--info)] text-[var(--text-primary)] flex items-center justify-center">
            {`${authenticatedUser.firstName?.charAt(0).toUpperCase()}`}
          </div>
          <span className="text-sm font-medium text-[var(--text-warning)]">
            {authenticatedUser.firstName} {authenticatedUser.lastName}
          </span>
          <svg
            className={`w-4 h-4 transition-transform duration-200 ${
              isOpen ? "transform rotate-180" : ""
            }`}
            fill="none"
            stroke="currentColor"
            viewBox="0 0 24 24"
          >
            <path
              strokeLinecap="round"
              strokeLinejoin="round"
              strokeWidth="2"
              d="M19 9l-7 7-7-7"
            />
          </svg>
        </button>

        {isOpen && (
          <div
            className={`${
              mobileView ? "fixed left-4 z-50" : "absolute right-0 z-50"
            } w-64 bg-[var(--bg-secondary)] text-[var(--text-primary)] rounded-lg shadow-xl border border-gray-200 dark:border-gray-700 z-10 ${
              isOpen ? "block" : "hidden"
            }`}
            style={{
              maxHeight: '400px',
              overflowY: 'auto',
              top: mobileView ? 'auto' : 'calc(100% + 0.5rem)',
              bottom: mobileView ? '5rem' : 'auto'
            }}
          >
            {themeToggler && (
              <div className="px-4 py-3 flex justify-between items-center border-b border-gray-200 dark:border-gray-700">
                {themeToggler}
              </div>
            )}
            <div className="py-2">
              <Link
                to="/user-profile"
                className="flex items-center px-4 py-2.5 text-sm font-medium hover:bg-[var(--info-light)] dark:hover:bg-gray-700 transition-colors duration-200"
                title="User Profile"
              >
                <svg className="w-4 h-4 mr-2" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M16 7a4 4 0 11-8 0 4 4 0 018 0zM12 14a7 7 0 00-7 7h14a7 7 0 00-7-7z" />
                </svg>
                User Profile
              </Link>
              <Link
                to="/user-account-settings"
                className="flex items-center px-4 py-2.5 text-sm font-medium hover:bg-[var(--info-light)] dark:hover:bg-gray-700 transition-colors duration-200"
                title="Account Settings"
              >
                <svg className="w-4 h-4 mr-2" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M10.325 4.317c.426-1.756 2.924-1.756 3.35 0a1.724 1.724 0 002.573 1.066c1.543-.94 3.31.826 2.37 2.37a1.724 1.724 0 001.065 2.572c1.756.426 1.756 2.924 0 3.35a1.724 1.724 0 00-1.066 2.573c.94 1.543-.826 3.31-2.37 2.37a1.724 1.724 0 00-2.572 1.065c-.426 1.756-2.924 1.756-3.35 0a1.724 1.724 0 00-2.573-1.066c-1.543.94-3.31-.826-2.37-2.37a1.724 1.724 0 00-1.065-2.572c-1.756-.426-1.756-2.924 0-3.35a1.724 1.724 0 001.066-2.573c-.94-1.543.826-3.31 2.37-2.37.996.608 2.296.07 2.572-1.065z" />
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M15 12a3 3 0 11-6 0 3 3 0 016 0z" />
                </svg>
                Account Settings
              </Link>
            </div>
            <hr className="border-gray-200 dark:border-gray-700" />
            <div className="py-2">
              <Link
                to="/logout"
                className="flex items-center px-4 py-2.5 text-sm font-medium text-[var(--danger-dark)] hover:bg-[var(--danger-light)] hover:text-[var(--danger-dark)] transition-colors duration-200"
                title="Logout"
              >
                <svg className="w-4 h-4 mr-2" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M17 16l4-4m0 0l-4-4m4 4H7m6 4v1a3 3 0 01-3 3H6a3 3 0 01-3-3V7a3 3 0 013-3h4a3 3 0 013 3v1" />
                </svg>
                Logout
              </Link>
            </div>
            <hr className="border-gray-200 dark:border-gray-700" />
            <div className="py-2">
              <a
                href="https://asafarim.com/cli"
                target="_blank"
                rel="noopener noreferrer"
                className="flex items-center px-4 py-2.5 text-sm font-medium hover:bg-[var(--info-light)] dark:hover:bg-gray-700 transition-colors duration-200"
                title="CLI Access"
              >
                <svg className="w-4 h-4 mr-2" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M8 9l3 3-3 3m5 0h3M5 20h14a2 2 0 002-2V6a2 2 0 00-2-2H5a2 2 0 00-2 2v12a2 2 0 002 2z" />
                </svg>
                CLI Access
                <svg className="w-3 h-3 ml-1" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M10 6H6a2 2 0 00-2 2v10a2 2 0 002 2h10a2 2 0 002-2v-4M14 4h6m0 0v6m0-6L10 14" />
                </svg>
              </a>
            </div>
          </div>
        )}
      </div>
    )
  );
};

export default UserDropdown;
