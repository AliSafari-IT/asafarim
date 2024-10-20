import { useEffect, useState } from "react";
import axios from "axios";
import Wrapper from "../../layout/Wrapper/Wrapper";
import { HomeHeaderBlock } from "./HomeHeaderBlock";
import NotAuthenticated from "../../components/NotAuthenticated";
import { ITopic } from "../../interfaces/ITopic";
import Topics from "../Topic/Topics";

const Home = () => {
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);
  const [topics, setTopics] = useState<ITopic[]>([]);
  const envVariable = (import.meta as any).env;
  const user = localStorage.getItem('user');

  // Determine the correct API URL based on the current hostname
  let API_URL = envVariable.VITE_API_URL || 'https://asafarim.com/api';
  if (window.location.hostname === 'preview.asafarim.com') {
    API_URL = envVariable.VITE_PREVIEW_URL + "/api";
  }

  console.log('Environment Variables:', envVariable);
  console.log('API_URL in Home: ', API_URL);

  // Retrieve topics
  useEffect(() => {
    const userData = localStorage.getItem('user');
    const token = userData ? JSON.parse(userData).token : null;

    if (!token) {
      setError('No authentication token found. Please log in.');
      setLoading(false);
      return;
    }

    setLoading(true);
    axios
      .get(`${API_URL}/topics`, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      })
      .then((response) => {
        setTopics(response.data);
        setLoading(false);
      })
      .catch((err) => {
        console.error(err);
        setError("Failed to load topics");
        setLoading(false);
      });
  }, [API_URL, user]);

  if (loading) {
    return (
      <Wrapper pageTitle="Home">
        <p>Loading...</p>
      </Wrapper>
    );
  }

  if (error) {
    return (
      <Wrapper pageTitle="Home">
        <div className="w-1/2 mx-auto my-10 px-4 py-3 rounded relative" role="alert">
          <NotAuthenticated />
        </div>
        <p>{error}</p>
      </Wrapper>
    );
  }

  return (
    <Wrapper header={<HomeHeaderBlock />} pageTitle={"Home"}>
      {topics.length > 0 ? <Topics topics={topics} /> : <p>No topics found.</p>}
    </Wrapper>
  );
};

export default Home;
