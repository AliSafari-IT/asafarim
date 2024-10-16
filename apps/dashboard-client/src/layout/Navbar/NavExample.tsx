import React, { useState } from 'react';
import { Link, useLocation } from 'react-router-dom';
import logo from './logoT.svg';
import {
  Library24Color as IconOpen, Dismiss24Regular,
  PersonAccounts24Filled as IconLogin, SignOut24Regular as IconLogout,
  PersonInfo24Regular as IconAbout,
  PhoneVibrate24Regular as IconContact,
  DeveloperBoard24Regular as IconDashboard,
  Home24Regular as IconHome,
  PersonAccounts24Regular as IconUser,
  Search24Regular as IconSearch,
  Teaching24Regular as IconTeaching
} from '@fluentui/react-icons';



function Navbar({ className }: { className?: string }) {
  const [menuOpen, setMenuOpen] = useState(false);
  const user = localStorage.getItem('user');
  function isActive(path: string) {
    const location = useLocation();
    return location.pathname === path;
  }
  return (
    <nav className="bg-gray-900 w-full border-b shadow-md border-gray-200 px-0 py-4 flex items-center justify-between relative">
      {/* Left side */}
      <div className="flex items-center space-x-4 ">
        <a
          href="//asafarim.com"
          className={"flex sm:inline-block text-blue-300 no-underline hover:text-teal-600 hover:underline" + ` ${isActive("/login") ? "text-blue-400 underline" : "no-underline"}`}
        >
          <img src={logo} alt="Brand Logo" className="h-8 w-8 mr-2" />
          <span className="font-semibold text-xl">ASafariM</span>
        </a>
        <a
          href="//techdocs.asafarim.com"
          className={`hidden sm:inline-block text-blue-300 hover:text-teal-600 hover:underline ${isActive("/techdocs") ? "text-green-700 underline" : "no-underline"}`}
        >
          Tech Docs
        </a>
        <a
          href="/about"
          className={`hidden sm:inline-block text-blue-300 hover:text-teal-600 hover:underline ${isActive("/about") ? "text-green-700 underline" : "no-underline"}`}
        >
          About
        </a>
        {user && (
          <a
            href="/dashboard"
            className={`hidden sm:inline-block text-blue-300 hover:text-teal-600 hover:underline ${isActive("/dashboard") ? "text-green-700 underline" : "no-underline"}`}
            >
            Dashboard
          </a>
        )}
      </div>

      {/* Right side */}
      <div className="hidden sm:flex items-center space-x-4 ">
        <a
          href="/contact"
          className={`hidden sm:inline-block text-blue-300 hover:text-teal-600 hover:underline ${isActive("/contact") ? "text-green-700 underline" : "no-underline"}`}
        >
          Contact
        </a>
        {user && (
          <a
            href="/user-account"
            className="hidden sm:inline-block text-blue-300 no-underline hover:text-teal-600 hover:underline items-center"
          >
            <span>User Profile</span>
          </a>
        )}
        {user ? (
          <a
            href="/logout"
            className="hidden sm:inline-block text-blue-300 no-underline hover:text-red-600 hover:underline pr-3"
          >
            <IconLogout />
          </a>
        ) : (
          <a
            href="/login"
            className="hidden sm:inline-block text-blue-300 no-underline hover:text-teal-600 hover:underline pr-3"
          >
            <IconLogin />
          </a>
        )}
      </div>

      {/* Hamburger Icon */}
      <div className="sm:hidden">
        <button
          onClick={() => setMenuOpen(!menuOpen)}
          className="focus:outline-none"
        >
          <svg
            className="w-6 h-6"
            fill="none"
            stroke="currentColor"
            viewBox="0 0 24 24"
          >
            <path
              strokeLinecap="round"
              strokeLinejoin="round"
              strokeWidth={2}
              d={
                menuOpen
                  ? 'M6 18L18 6M6 6l12 12' // X icon when menu is open
                  : 'M4 6h16M4 12h16M4 18h16' // Hamburger icon when menu is closed
              }
            />
          </svg>
        </button>
      </div>

      {/* Mobile Menu */}
      {menuOpen && (
        <div className="absolute top-full left-0 right-0 bg-white shadow-md sm:hidden">
          <a
            href="//techdocs.asafarim.com"
            className="block px-4 py-2 text-gray-600 hover:bg-gray-100 space-x-4"
          >
            <span>Tech Docs</span>
            <IconTeaching />

          </a>

          <a
            href="/about"
            className="block px-4 py-2 text-gray-600 hover:bg-gray-100 space-x-4"
          >
            <span>About</span>
            <IconAbout />
          </a>

          <a
            href="/contact"
            className="block px-4 py-2 text-gray-600 hover:bg-gray-100 space-x-4"
          >
            <span>Contact</span>
            <IconContact />
          </a>

          {user && (
            <a
              href="/dashboard"
              className="block px-4 py-2 text-gray-600 hover:bg-gray-100 space-x-4"
            >
              <span>Dashboard</span>
              <IconDashboard />

            </a>
          )}
          {user && (
            <a
              href="/user-account"
              className="block px-4 py-2 text-gray-600 hover:bg-gray-100 space-x-4"
            >
              <span>User Profile</span>
              <IconUser />
            </a>
          )}
          {user ? (
            <a
              href="/logout"
              className="block px-4 py-2 text-gray-600 hover:bg-gray-100 space-x-4"
            >
              <span>Logout</span>
              <IconLogout />
            </a>
          ) : (
            <a
              href="/login"
              className="block px-4 py-2 text-gray-600 hover:bg-gray-100 space-x-4"
            >
              <span>Login</span>
              <IconLogin />
            </a>
          )}

        </div>
      )}
    </nav>
  );
};

export default Navbar;
