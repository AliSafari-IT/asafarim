import { useEffect, useState } from "react";
import axios from "axios";
import Wrapper from "../../layout/Wrapper/Wrapper";
import { HomeHeaderBlock } from "./HomeHeaderBlock";
import NotAuthenticated from "../../components/NotAuthenticated";
import { ITopic } from "../../interfaces/ITopic";
import Topics from "../Topic/Topics";
import Loading from "../../components/Loading/Loading";

// Determine the correct API URL based on the current hostname
const envVariable = (import.meta as any).env;
let API_URL = envVariable.VITE_API_URL || 'https://asafarim.com/api';
if (window.location.hostname === 'preview.asafarim.com') {
  API_URL = envVariable.VITE_PREVIEW_URL || 'https://preview.asafarim.com/api';
}

const Home = () => {
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);
  const [topics, setTopics] = useState<ITopic[]>([]);
  const user = localStorage.getItem('user');

  // Retrieve topics
  useEffect(() => {
    const fetchTopics = async () => {
      try {
        const response = await axios.get(`${API_URL}/topics`);
        setTopics(response.data);
      } catch (error: any) {
        setError(error.message);
      } finally {
        setLoading(false);
      }
    };

    if (!user) {
      fetchTopics();  
    }
  }, [API_URL, user]);

  if (loading) {
    return (
      <Wrapper pageTitle="Home">
        <Loading size={50} color="skyblue" />
      </Wrapper>
    );
  }

  if (error && topics.length === 0) {
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
      <div id="home">
        {topics.length > 0 ? <Topics topics={topics} /> : <p>No topics found.</p>}
      </div>
    </Wrapper>
  );
};

export default Home;
