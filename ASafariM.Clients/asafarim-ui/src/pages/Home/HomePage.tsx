import Layout from "../../layout/Layout";
import NotAuthenticated from "../../components/NotAuthenticated";
import HomePanels from "./HomePanels";
import useAuth from "../../hooks/useAuth";
import StacksPage from "../../components/Stacks/StacksPage";
import DisplayMd from "@/components/MarkdownPage/DisplayMd";
import { useLocation } from "react-router-dom";
import readme from "./README.md?raw";
import React, { useEffect } from "react";
import UnderConstruction from "../UnderConstruction";
import HeroSection from "./HeroSection";
import TechSkillsSection from "./TechSkillsSection";

export const Home = () => {
  const user = useAuth();
  const location = useLocation();
  var isUnderConstruction = false;

  const [mdFile, setMdFile] = React.useState<string>("");
  useEffect(() => {
    const loadMarkdownContent = async () => {
      setMdFile(readme);
    };

    loadMarkdownContent();
  }, [location.pathname]);

  if (!user) {
    return (
      <Layout header={<></>} pageTitle="NotAuthenticated Page">
        <div
          className="w-full mt-3 alert alert-danger alert-dismissible fade show"
          role="alert"
        >
          <NotAuthenticated />
        </div>
      </Layout>
    );
  }

  return (
    <Layout header={<></>} pageTitle="Home">
      {isUnderConstruction && <UnderConstruction />}
      <HeroSection />
      <TechSkillsSection />
      <DisplayMd markdownContent={mdFile} id="readMe" />
      <StacksPage docBranch="techDocs" stackTitle="Tech Stacks" />
      <HomePanels />
    </Layout>
  );
};

export default Home;
