import React, { useEffect, useState } from 'react';
import axios from 'axios';

const Home = () => {
  const [data, setData] = useState<any[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const token = "0+a0ZklJy6DVL6osEj73W6P9inMk3+Ocn8KkQoUDR78=";  // Replace with the actual token you received after login

    axios.get('http://localhost:5146/api/sitemap?userRole=Admin', {
      headers: {
        Authorization: `Bearer ${token}`  // Pass the token in the Authorization header
      }
    })
    .then((response) => {
      setData(response.data);  // Set data from API
      setLoading(false);        // Set loading to false once data is fetched
    })
    .catch((err) => {
      setError('Failed to load data');  // Handle error
      setLoading(false);                // Stop loading if there's an error
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
