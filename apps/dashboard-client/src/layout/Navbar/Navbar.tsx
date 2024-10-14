import { Link, useLocation } from "react-router-dom";
import { useState } from "react";
import logo from './logoT.svg';
import {  FolderOpen24Filled  as IconOpen, Dismiss24Regular } from '@fluentui/react-icons'; 
// Helper function to check if a route is active
const isActive = (path: string) => {
  return useLocation().pathname === path;
};

function Navbar({ className }: { className?: string }) {
  const user = localStorage.getItem('user');
  const [isMenuOpen, setMenuOpen] = useState(false); // State to toggle mobile menu

  return (
    <nav className={` text-white w-full p-4 flex justify-between items-center  ${className}`}>
      {/* Logo and Left-aligned Links */}
      <div className="flex items-center space-x-4">
        <div className="flex items-center space-x-2">
          <Link to="/" className="flex items-center">
            <img src={logo} alt="Brand Logo" className="w-10 h-10 bg-transparent fill-black" />
            <span className="text-xl font-bold tracking-wide ml-2">ASafariM</span>
          </Link>
        </div>
        {/* Desktop Links */}
        <ul className="list-none  hidden md:flex space-x-6">          
          <li>
            <Link
              to="/about"
              className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/about") ? "text-blue-400" : ""}`}
            >
              About
            </Link>
          </li>
          <li>
            <Link
              to="/contact"
              className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/contact") ? "text-blue-400" : ""}`}
            >
              Contact
            </Link>
          </li>
          {user && (
            <li>
              <Link
                to="/dashboard"
                className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/dashboard") ? "text-blue-400" : ""}`}
              >
                Dashboard
              </Link>
            </li>
          )}
        </ul>
      </div>

      {/* Right-aligned Account Links */}
      <div className="hidden md:flex space-x-6">
        {!user ? (
          <Link
            to="/login"
            className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/login") ? "text-blue-400" : ""}`}
          >
            Login
          </Link>
        ) : (
          <Link
            to="/logout"
            className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/logout") ? "text-blue-400" : ""}`}
          >
            Logout
          </Link>
        )}
      </div>

      {/* Mobile Menu Toggle */}
      <button
        className="md:hidden flex focus:outline-none absolute top-4 right-3 z-50 cursor-pointer w-10 h-7"
        onClick={() => setMenuOpen(!isMenuOpen)}
      >
        {isMenuOpen ? (
          <Dismiss24Regular className="text-gray-400 transition-transform" /> // Close icon
        ) : (
          <IconOpen className="text-gray-400 transition-transform" /> // Hamburger icon
        )}
      </button>

      {/* Mobile Menu */}
      {isMenuOpen && (
        <div className="relative top-3 left-0 w-full p-0 flex flex-col items-center space-y-4 md:hidden hover:text-blue-400,transition-colors duration-300,cursor-pointer">
          <ul className="list-none  space-y-4">
            <li>
              <Link
                to="/about"
                className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/about") ? "text-blue-400" : ""}`}
                onClick={() => setMenuOpen(false)}
              >
                About
              </Link>
            </li>
            <li>
              <Link
                to="/contact"
                className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/contact") ? "text-blue-400" : ""}`}
                onClick={() => setMenuOpen(false)}
              >
                Contact
              </Link>
            </li>
            {user && (
              <li>
                <Link
                  to="/dashboard"
                  className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/dashboard") ? "text-blue-400" : ""}`}
                  onClick={() => setMenuOpen(false)}
                >
                  Dashboard
                </Link>
              </li>
            )}
          </ul>
          <div className="mt-4 ">
            {!user ? (
              <Link
                to="/login"
                className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/login") ? "text-blue-400" : ""}`}
                onClick={() => setMenuOpen(false)}
              >
                Login
              </Link>
            ) : (
              <Link
                to="/logout"
                className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/logout") ? "text-blue-400" : ""}`}
                onClick={() => setMenuOpen(false)}
              >
                Logout
              </Link>
            )}
          </div>
        </div>
      )}
    </nav>
  );
}

export default Navbar;
