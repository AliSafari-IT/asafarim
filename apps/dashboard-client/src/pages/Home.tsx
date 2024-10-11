import { useEffect, useState } from "react";
import axios from "axios";
import Wrapper from "../layout/Wrapper/Wrapper";
import { Link } from "react-router-dom";

const HeaderComponent = () => {
  return (
    <div className="w-full text-center mx-auto m-0 text-gray-200 p-4 bg-gray-700">
      <h1 className="text-5xl font-extrabold mb-4 animate-pulse">
        Welcome to the ASafariM Dashboard
      </h1>
      <p className="text-lg font-light max-w-lg mx-auto">
        Explore your personalized dashboard, manage your panels, and stay up to
        date with the latest updates in a clean, intuitive interface.
      </p>
    </div>
  );
};

const Home = () => {
  const [data, setData] = useState<any[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const user = localStorage.getItem('user');

  // Fetch data from API
  useEffect(() => {
    // Retrieve the token from localStorage
    const userData = localStorage.getItem('user');
    const token = userData ? JSON.parse(userData).token : null;

    if (!token) {
      setError('No authentication token found. Please log in.');
      setLoading(false);
      return;
    }

    // Make the API call using the token
    axios
      .get("https://localhost:44337/api/sitemap?userRole=Admin", {
        headers: {
          Authorization: `Bearer ${token}`, // Pass the token in the Authorization header
        },
      })
      .then((response) => {
        setData(response.data); // Set data from API
        setLoading(false); // Set loading to false once data is fetched
      })
      .catch((_err) => {
        setError("Failed to load data"); // Handle error
        setLoading(false); // Stop loading if there's an error
      });
  }, []);

  if (loading) {
    return <p>Loading...</p>;
  }

  if (error) {
    return <Wrapper header={<div className="  bg-warning  alert alert-danger">No authentication token found. Please log in.</div>}>
      <Link to={"/login"} title="Login" className="bg-red link button ">
        Login
      </Link>
    </Wrapper>;
  }

  return (
    <Wrapper header={<HeaderComponent />} >
      <h1 className="text-3xl font-bold">Home Page</h1>
      {error && <p>{error}</p>}
      {user && <div className="bg-white text-blue-900 rounded-lg shadow-lg p-8 w-full max-w-xl text-center transform hover:scale-105 transition-transform duration-300 ease-in-out">
        <h2 className="text-3xl font-semibold mb-4">Manage Your Dashboard</h2>
        <p className="mb-6 text-lg font-light">
          Dive into the detailed overview of all your panels, add new ones, or
          make changes with a single click.
        </p>
        <Link
          to="/dashboard"
          className="bg-blue-600 hover:bg-blue-700 text-white py-2 px-4 rounded-lg shadow-md text-lg transition-colors duration-300 ease-in-out"
        >
          View Dashboard
        </Link>
      </div>}

      {data.length > 0 ? (
        <ul>
          {data.map((item) => (
            <li key={item.id}>
              <a href={item.slug}>{item.pageName}</a> - {item.description}
            </li>
          ))}
        </ul>
      ) : (
        <p>No data available</p>
      )}
    </Wrapper>
  );
};

export default Home;
