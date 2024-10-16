import { useEffect, useState } from "react";
import axios from "axios";
import Wrapper from "../../layout/Wrapper/Wrapper";
import { Link } from "react-router-dom";
import { HomeHeaderBlock } from "./HomeHeaderBlock";
import NotAuthenticated from "../../components/NotAuthenticated";
import { ISitemapItem } from "../../interfaces/ISitemapItem";

const Home = () => {
  const [data, setData] = useState<ISitemapItem[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);
  const envVariable = (import.meta as any).env;
  const user = localStorage.getItem('user');
  const API_URL = envVariable.VITE_API_URL;
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

    // Make the API call using the token: "https://localhost:44337/api/sitemap?userRole=Admin"
    axios
      .get(`${API_URL}/sitemap?userRole=Admin`, {
        headers: {
          Authorization: `Bearer ${token}`, // Pass the token in the Authorization header
        },
      })
      .then((response) => {
        // Check if `data` is an array
        if (Array.isArray(data)) {
          setData(response.data); // Set data from API
        } else {
          console.error('Expected an array but got:', data);
          // Handle non-array data here
        }
        setLoading(false);
        setError(null);
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
    const errorMessage = (<div className="w-1/2 mx-auto my-10 px-4 py-3 rounded relative" role="alert">
      <NotAuthenticated />
    </div>);

    return <Wrapper
      pageTitle="Home"
      header={errorMessage}
    >
    </Wrapper>;
  }

  return (
    <Wrapper header={<HomeHeaderBlock />} pageTitle={"Home"} >
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
        <ul className="card m-4">
          {Array.isArray(data) && data.map((item) => (
            <li key={item.id}>
              <a href={item.slug}>{item.pageName}</a> - {item.description}
            </li>
          ))}
          <div className="mt-4 bg-white text-blue-900 rounded-lg shadow-lg p-8 w-full max-w-xl text-center transform hover:scale-105 transition-transform duration-300 ease-in-out">
            <a href="/health" className="text-blue-600 hover:underline">Health checks</a> - <a href="/health-ui" className="text-blue-600 hover:underline">Health checks UI</a>

          </div>
        </ul>
      ) : (
        <p>No data available</p>
      )}
    </Wrapper>
  );
};

export default Home;
