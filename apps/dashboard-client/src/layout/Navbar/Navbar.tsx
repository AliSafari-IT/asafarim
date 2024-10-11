import { Link } from "react-router-dom";

function Navbar() {
    // is user logged in?
    const user = localStorage.getItem('user');

    return <nav className="w-full p-4 bg-gray-800 text-white">
        <ul className="flex space-x-4">
            <li><Link to="/">Home</Link></li>
            <li><Link to="/about">About</Link></li>
            <li><Link to="/contact">Contact</Link></li>
            {user && <li><Link to="/dashboard">Dashboard</Link></li>}
        </ul>
        {/** Login and Logout links right aligned */}
        <ul className="flex justify-end space-x-4  items-center">

            {!user && <li><Link to="/login">Login</Link></li>}

            {user && <li><Link to="/logout">Logout</Link></li>}


        </ul>
    </nav>
}

export default Navbar;