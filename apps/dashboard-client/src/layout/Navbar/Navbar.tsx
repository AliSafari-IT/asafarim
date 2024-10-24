// Navbar.tsx
import { useState } from 'react';
import { useLocation } from 'react-router-dom';
import logo from './logoT.svg';
import {
  
  PersonAccounts24Filled as IconLogin, SignOut24Regular as IconLogout,
  PersonInfo24Regular as IconAbout,
  PhoneVibrate24Regular as IconContact,
  DeveloperBoard24Regular as IconDashboard,
  PersonAccounts24Regular as IconUser,
  Teaching24Regular as IconTeaching
} from '@fluentui/react-icons';

interface NavbarProps {
  className?: string;
  children?: React.ReactNode; // Add this line
}

function Navbar({ className }: NavbarProps) {
  const [menuOpen, setMenuOpen] = useState(false);
  const location = useLocation();
  const user = localStorage.getItem('user');

  const isActive = (path: string) => location.pathname === path;

  const navLinkClass = (path: string) =>
    `hidden sm:inline-block px-3 py-2 rounded-md ${
      isActive(path)
        ? 'text-white bg-blue-500 font-bold'
        : 'text-blue-300 hover:text-teal-600 hover:underline'
    }`;

  const mobileNavLinkClass = (path: string) =>
    `block px-4 py-2 ${
      isActive(path)
        ? 'text-white bg-blue-500 font-bold'
        : 'text-gray-600 hover:bg-gray-100'
    }`;

  return (
    <nav className={"bg-gray-900 w-full border-b shadow-md border-gray-200 px-4 py-4 flex items-center justify-between relative " + className}>
      {/* Left side */}
      <div className="flex items-center space-x-4">
        <a
          href="//asafarim.com"
          className="flex items-center text-blue-300 no-underline hover:text-teal-600 hover:underline"
        >
          <img src={logo} alt="Brand Logo" className="h-8 w-8 mr-2" />
          <span className="font-semibold text-xl">ASafariM</span>
        </a>
        <a href="//techdocs.asafarim.com" className={navLinkClass('/techdocs')}>
          Tech Docs
        </a>
        <a href="/about" className={navLinkClass('/about')}>
          About
        </a>
        {user && (
          <a href="/dashboard" className={navLinkClass('/dashboard')}>
            Dashboard
          </a>
        )}
      </div>

      {/* Right side */}
      <div className="hidden sm:flex items-center space-x-4">
        <a href="/contact" className={navLinkClass('/contact')}>
          Contact
        </a>
        {user && (
          <a href="/user-account" className={navLinkClass('/user-account')}>
            User Profile
          </a>
        )}
        {user ? (
          <a
            href="/logout"
            className="hidden sm:inline-block px-3 py-2 rounded-md text-blue-300 no-underline hover:text-red-600 hover:underline"
          >
            <IconLogout />
          </a>
        ) : (
          <a href="/login" className={navLinkClass('/login') + ' pr-8'}>
            <IconLogin />
          </a>
        )}
      </div>

      {/* Hamburger Icon */}
      <div className="sm:hidden pr-5">
        <button
          onClick={() => setMenuOpen(!menuOpen)}
          className="focus:outline-none"
        >
          <svg
            className="w-6 h-6 text-blue-300"
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
          <a href="//techdocs.asafarim.com" className={mobileNavLinkClass('/techdocs')}>
            <span>Tech Docs</span>
            <IconTeaching className="inline-block ml-2" />
          </a>
          <a href="/about" className={mobileNavLinkClass('/about')}>
            <span>About</span>
            <IconAbout className="inline-block ml-2" />
          </a>
          <a href="/contact" className={mobileNavLinkClass('/contact')}>
            <span>Contact</span>
            <IconContact className="inline-block ml-2" />
          </a>
          {user && (
            <a href="/dashboard" className={mobileNavLinkClass('/dashboard')}>
              <span>Dashboard</span>
              <IconDashboard className="inline-block ml-2" />
            </a>
          )}
          {user && (
            <a href="/user-account" className={mobileNavLinkClass('/user-account')}>
              <span>User Profile</span>
              <IconUser className="inline-block ml-2" />
            </a>
          )}
          {user ? (
            <a
              href="/logout"
              className="block px-4 py-2 text-gray-600 hover:bg-gray-100"
            >
              <span>Logout</span>
              <IconLogout className="inline-block ml-2" />
            </a>
          ) : (
            <a href="/login" className={mobileNavLinkClass('/login')}>
              <span>Login</span>
              <IconLogin className="inline-block ml-2" />
            </a>
          )}
        </div>
      )}
    </nav>
  );
}

export default Navbar;
