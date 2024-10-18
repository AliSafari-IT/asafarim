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
  const API_URL = envVariable.VITE_API_URL;

  // Retrieve topics
  useEffect(() => {
    const userData = localStorage.getItem('user');
    const token = userData ? JSON.parse(userData).token : null;
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
  }, [ API_URL ]);

  useEffect(() => {
    if (!user) {
      setError('No authentication token found. Please log in.');
      setLoading(false);
      return;
    }
  }, [topics]);

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
      <Topics topics={topics} />
    </Wrapper>;
  }

  return (
    <Wrapper header={<HomeHeaderBlock />} pageTitle={"Home"} >
      {error && <p>{error}</p>}
      <Topics topics={topics} />
    </Wrapper>
  );
};

export default Home;
