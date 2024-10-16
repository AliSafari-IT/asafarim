import { Link, useLocation } from "react-router-dom";
import { useState } from "react";
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
    <nav className={` text-white w-full flex justify-between items-center  ${className}`}>
      {/* Logo and Left-aligned Links */}
      <div className="flex items-center space-x-4">
        <div className="flex items-center space-x-2">
          <Link to="/" className={`flex items-center ${isActive("/") ? "text-blue-400 underline" : "no-underline"}`}>
            <img src={logo} alt="Brand Logo" className="w-10 h-10 bg-transparent fill-black py-2" />
            <span className="text-xl font-bold tracking-wide ml-2">ASafariM</span>
          </Link>
        </div>
        {/* Desktop Links */}
        <ul className="list-none  hidden md:flex space-x-6">
          <li>
            <Link
              to="//techdocs.asafarim.com"
              className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/techdocs") ? "text-blue-400 underline" : "no-underline"}`}
              onClick={() => setMenuOpen(false)}
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
      </div>

      {/* Right-aligned Account Links */}
      <div className="hidden md:flex space-x-6">
        {!user ? (
          <Link
            to="/login"
            className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/login") ? "text-blue-400 underline" : "no-underline"}`}
          >
            <IconLogin className="text-green-300 w-14 h-9 " aria-label="Login" title="Login" />
          </Link>
        ) : (
          <Link
            to="/logout"
            className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/logout") ? "text-blue-400 underline" : "no-underline"}`}
          >
            <IconLogout className="text-red-600 p-4" aria-label="Logout" title="Logout" />
          </Link>
        )}
      </div>

      {/* Mobile Menu Toggle */}
      <button
        className="md:hidden flex focus:outline-none absolute top-4 right-3 z-50 cursor-pointer bg-transparent border-0"
        onClick={() => setMenuOpen(!isMenuOpen)}
      >
        {isMenuOpen ? (
          <Dismiss24Regular className="text-gray-400 transition-transform" /> // Close icon
        ) : (
          <IconOpen className="text-[#aefcf2] bg-transparent transition-transform rotate-90" /> // Hamburger icon
        )}
      </button>

      {/* Mobile Menu */}
      {isMenuOpen && (
        <AlertContainer close={() => setMenuOpen(false)} className="relative w-3/4 top-3 left-0 w-full flex flex-col items-around justify-center space-y-4 md:hidden hover:text-blue-400,transition-colors duration-300,cursor-pointer">
          <ul className="list-none  space-y-4">
            {/** Add link to /techdocs */}
            <li>
              <Link
                to="//techdocs.asafarim.com"
                className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/techdocs") ? "text-blue-400 underline" : "no-underline"}`}
                onClick={() => setMenuOpen(false)}
              >
                Tech Docs
              </Link>
            </li>
            <li>
              <Link
                to="/about"
                className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/about") ? "text-blue-400 underline" : "no-underline"}`}
                onClick={() => setMenuOpen(false)}
              >
                About  <IconAbout className="text-gray-700  hover:text-indigo-700 cursor-pointer " aria-label="Logout" title="Logout" />
              </Link>
            </li>
            <li>
              <Link
                to="/contact"
                className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/contact") ? "text-blue-400 underline" : "no-underline"}`}
                onClick={() => setMenuOpen(false)}
              >
                Contact  <IconContact className="text-gray-700  hover:text-indigo-700 cursor-pointer " aria-label="Logout" title="Logout" />
              </Link>
            </li>
            {user && (
              <li>
                <Link
                  to="/dashboard"
                  className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/dashboard") ? "text-blue-400 underline" : "no-underline"}`}
                  onClick={() => setMenuOpen(false)}
                >
                  Dashboard  <IconDashboard className="text-gray-700  hover:text-indigo-700 cursor-pointer " aria-label="Logout" title="Logout" />
                </Link>
              </li>
            )}
          </ul>
          <div className="flex flex-col">
            {!user ? (
              <Link
                to="/login"
                className={`hover:text-blue-400 transition-colors duration-300 ${isActive("/login") ? "text-blue-400 underline" : "no-underline"}`}
                onClick={() => setMenuOpen(false)}
              >
                Login
              </Link>
            ) : (
              <Link
                to="/logout"
                className={`flex justify-end items-center py-4 px-6 hover:text-blue-400 transition-colors duration-300 ${isActive("/logout") ? "text-blue-400 underline" : "no-underline"}`}
                onClick={() => setMenuOpen(false)}
              >
                Logout <IconLogout className="text-gray-700  hover:text-red-700 cursor-pointer " aria-label="Logout" title="Logout" />
              </Link>

            )}
          </div>
        </AlertContainer>
      )}
    </nav>
  );
}

export default Navbar;
