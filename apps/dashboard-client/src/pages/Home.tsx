import { useEffect, useState } from "react";
import axios from "axios";

const Home = () => {
  const [data, setData] = useState<any[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const bearer = {
      token:
        "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiYWxpIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZW1haWxhZGRyZXNzIjoiYWxpQGFzbS5jb20iLCJleHAiOjE3Mjg2MTM3OTksImlzcyI6ImFzYWZhcmltIiwiYXVkIjoiaHR0cHM6Ly9hc2FmYXJpbS5jb20ifQ.MPn5386ktH8gkoJenjORAy6EoDKDkHj9TCx8xlVUYEo",
    }; // Replace with the actual token you received after login
    

    axios
      .get("https://localhost:44337/api/Sitemap?userRole=Admin", {
        headers: {
          Authorization: `Bearer ${bearer.token}`, // Pass the token in the Authorization header
        },
      })
      .then((response) => {
        console.log(response.data);
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
    return <p>{error}</p>;
  }

  return (
    <div>
      <h1 className="text-3xl font-bold">Home Page</h1>
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
    </div>
  );
};

export default Home;
