import React, { useState } from 'react';
import { Link, useLocation } from 'react-router-dom';
import logo from './logoT.svg';
import {
  Library24Color as IconOpen, Dismiss24Regular,
  PersonAccounts24Filled as IconLogin, SignOut24Regular as IconLogout,
  PersonInfo24Regular as IconAbout,
  PhoneVibrate24Regular as IconContact,
  DeveloperBoardSearch24Regular as IconDashboard
} from '@fluentui/react-icons';
import AlertContainer from "../../components/AlertContainer";

// Helper function to check if a route is active
const isActive = (path: string) => {
  return useLocation().pathname === path;
};

function Navbar({ className }: { className?: string }) {
  const user = localStorage.getItem('user');
  const [isMenuOpen, setMenuOpen] = useState(false); // State to toggle mobile menu

  return (
    <nav className={`text-white w-full flex sm&:justify-center md:justify-around flex-wrap  px-0 py-10 shadow-md ${isMenuOpen ? "bg-gray-800" : "bg-gray-900"} ${className}`}>
      {/* Logo and Left-aligned Links */}
      <div className="flex items-center space-x-3">
        <Link to="/" className={`flex items-center ${isActive("/") ? "text-blue-400 underline" : "no-underline"}`}>
          <img src={logo} alt="Brand Logo" className="w-14 h-9 bg-transparent py-5 " />
          <span className="text-2xl font-bold tracking-wide ml-2">ASafariM</span>
        </Link>
      </div>

      {/* Desktop Links */}
      <ul className="list-none hidden md:flex space-x-6">
        <li>
          <Link
            to="//techdocs.asafarim.com"
            className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/techdocs") ? "text-blue-400 underline" : "no-underline"}`}
          >
            Tech Docs
          </Link>
        </li>
        <li>
          <Link
            to="/about"
            className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/about") ? "text-blue-400 underline" : "no-underline"}`}
          >
            About
          </Link>
        </li>
        <li>
          <Link
            to="/contact"
            className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/contact") ? "text-blue-400 underline" : "no-underline"}`}
          >
            Contact
          </Link>
        </li>
        {user && (
          <li>
            <Link
              to="/dashboard"
              className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/dashboard") ? "text-blue-400 underline" : "no-underline"}`}
            >
              Dashboard
            </Link>
          </li>
        )}
      </ul>

      {/* Right-aligned Account Links (Desktop) */}
      <div className="hidden md:flex space-x-6">
        {!user ? (
          <Link to="/login" className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/login") ? "text-blue-400 underline" : "no-underline"}`}>
            <IconLogin className="text-green-300 w-8 h-8" aria-label="Login" title="Login" />
          </Link>
        ) : (
          <Link to="/logout" className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/logout") ? "text-blue-400 underline" : "no-underline"}`}>
            <IconLogout className="text-red-700 w-8 h-8" aria-label="Logout" title="Logout" />
          </Link>
        )}
      </div>

      {/* Mobile Menu Toggle */}
      <button
        className="md:hidden flex items-center focus:outline-none absolute top-4 right-3 z-50"
        onClick={() => setMenuOpen(!isMenuOpen)}
      >
        {isMenuOpen ? (
          <Dismiss24Regular className="text-gray-400 transition-transform" /> // Close icon
        ) : (
          <IconOpen className="text-[#aefcf2] transition-transform rotate-90" /> // Hamburger icon
        )}
      </button>

      {/* Mobile Menu */}
      {isMenuOpen && (
        <AlertContainer close={() => setMenuOpen(false)} className="absolute top-8 right-0 w-full bg-gray-800 z-50">
          <div className="w-1/2 flex flex-col items-start justify-baseline px-40 space-y-1 py-0">
              <Link
                to="//techdocs.asafarim.com"
                className={`text-lg hover:text-blue-400 transition-colors duration-300 ${isActive("/techdocs") ? "text-blue-400 underline" : "no-underline"}`}
                onClick={() => setMenuOpen(false)}
              >
                Tech Docs
              </Link>
            
              <Link
                to="/about"
                className={`text-lg hover:text-blue-400 transition-colors duration-300 ${isActive("/about") ? "text-blue-400 underline" : "no-underline"}`}
                onClick={() => setMenuOpen(false)}
              >
                About
              </Link>
            
              <Link
                to="/contact"
                className={`text-lg hover:text-blue-400 transition-colors duration-300 ${isActive("/contact") ? "text-blue-400 underline" : "no-underline"}`}
                onClick={() => setMenuOpen(false)}
              >
                Contact
              </Link>
            {user && (
                <Link
                  to="/dashboard"
                  className={`text-lg hover:text-blue-400 transition-colors duration-300 ${isActive("/dashboard") ? "text-blue-400 underline" : "no-underline"}`}
                  onClick={() => setMenuOpen(false)}
                >
                  Dashboard
                </Link>
            )}
          </div>
          <div className="flex flex-col items-center">
            {!user ? (
              <Link
                to="/login"
                className={`text-lg hover:text-blue-400 transition-colors duration-300 ${isActive("/login") ? "text-blue-400 underline" : "no-underline"}`}
                onClick={() => setMenuOpen(false)}
              >
                Login
              </Link>
            ) : (
              <Link
                to="/logout"
                className={`text-lg hover:text-blue-400 transition-colors duration-300 ${isActive("/logout") ? "text-blue-400 underline" : "no-underline"}`}
                onClick={() => setMenuOpen(false)}
              >
                Logout
              </Link>
            )}
          </div>
        </AlertContainer>
      )}
    </nav>
  );
}

export default Navbar;
