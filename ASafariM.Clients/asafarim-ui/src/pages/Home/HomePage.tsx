import Layout from "../../layout/Layout";
import HomePanels from "./HomePanels";
import StacksPage from "../../components/Stacks/StacksPage";
import DisplayMd from "@/components/MarkdownPage/DisplayMd";
import { useLocation } from "react-router-dom";
import readme from "./README.md?raw";
import React, { useEffect } from "react";
import UnderConstruction from "../UnderConstruction";
import HeroSection from "./HeroSection";
import TechSkillsSection from "./TechSkillsSection";

export const Home = () => {
  const location = useLocation();
  const isUnderConstruction = false;

  const [mdFile, setMdFile] = React.useState<string>("");
  useEffect(() => {
    const loadMarkdownContent = async () => {
      setMdFile(readme);
    };

    loadMarkdownContent();
  }, [location.pathname]);

  // Removed authentication check to allow all users to see the home page
  return (
    <Layout header={<></>} pageTitle="Home">
      {isUnderConstruction && (
        <UnderConstruction 
          title="Under Construction"
          description="This page is currently under construction."
          constructionTips={["Check back soon for updates", "We're working hard to improve this page"]}
          bodyText="Thank you for your patience while we improve this page."
        />
      )}
      <HeroSection />
      <TechSkillsSection />
      <DisplayMd markdownContent={mdFile} id="readMe" />
      <StacksPage docBranch="techDocs" stackTitle="Tech Stacks" />
      <HomePanels />
    </Layout>
  );
};

export default Home;
