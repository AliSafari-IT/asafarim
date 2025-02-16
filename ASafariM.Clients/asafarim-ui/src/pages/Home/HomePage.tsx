import Layout from "../../layout/Layout";
import NotAuthenticated from "../../components/NotAuthenticated";
import HomePanels from "./HomePanels";
import useAuth from "../../hooks/useAuth";
import StacksPage from "../../components/Stacks/StacksPage";
import DisplayMd from "@/components/MarkdownPage/DisplayMd";
import { useLocation } from "react-router-dom";
import readme from './README.md?raw';
import React, { useEffect } from "react";
import UnderConstruction from '../UnderConstruction';

export const Home = () => {
  const user = useAuth(); 
  const location = useLocation();

  const [mdFile, setMdFile] = React.useState<string>('');
  useEffect(() => {
    const loadMarkdownContent = async () => {
      setMdFile(readme);
    };

    loadMarkdownContent();
  }, [location.pathname]);

  if (!user) {
    return ( 
      <Layout header={<></>} pageTitle="NotAuthenticated Page">
        <div className="w-full mt-3 alert alert-danger alert-dismissible fade show" role="alert">
          <NotAuthenticated />
        </div>
      </Layout>
    );
  }

  return (
    <Layout  header={<></>} pageTitle="Home">
      <UnderConstruction />
      <DisplayMd markdownContent={mdFile}   id="readMe"  />
      <StacksPage docBranch="techDocs" stackTitle="Tech Stacks"/>
      <HomePanels />
    </Layout>
  );

};

export default Home;
