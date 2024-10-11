import { Link, useLocation } from "react-router-dom";

function Navbar() {
  const location = useLocation(); // Get the current route
  const user = localStorage.getItem('user');

  // Helper function to check if a route is active
  const isActive = (path: string) => location.pathname === path;

  return (
    <nav className="w-full p-4 bg-gray-800 text-white flex justify-between items-center">
      {/* Left-aligned section */}
      <ul className="flex space-x-4 items-center">
        <li>
          <Link
            to="/"
            className={`hover:text-blue-400 ${isActive("/") ? "text-blue-400" : ""}`}
          >
            Home
          </Link>
        </li>
        <li>
          <Link
            to="/about"
            className={`hover:text-blue-400 ${isActive("/about") ? "text-blue-400" : ""}`}
          >
            About
          </Link>
        </li>
        <li>
          <Link
            to="/contact"
            className={`hover:text-blue-400 ${isActive("/contact") ? "text-blue-400" : ""}`}
          >
            Contact
          </Link>
        </li>
        {user && (
          <li>
            <Link
              to="/dashboard"
              className={`hover:text-blue-400 ${isActive("/dashboard") ? "text-blue-400" : ""}`}
            >
              Dashboard
            </Link>
          </li>
        )}
      </ul>

      {/* Right-aligned section */}
      <ul className="flex space-x-4 items-center">
        {!user && (
          <li>
            <Link
              to="/login"
              className={`hover:text-blue-400 ${isActive("/login") ? "text-blue-400" : ""}`}
            >
              Login
            </Link>
          </li>
        )}
        {user && (
          <li>
            <Link
              to="/logout"
              className={`hover:text-blue-400 ${isActive("/logout") ? "text-blue-400" : ""}`}
            >
              Logout
            </Link>
          </li>
        )}
      </ul>
    </nav>
  );
}

export default Navbar;
