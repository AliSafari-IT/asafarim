import Layout from "../../layout/Layout";
import HomePanels from "./HomePanels";
import StacksPage from "../../components/Stacks/StacksPage";
import DisplayMd from "@/components/MarkdownPage/DisplayMd";
import { useLocation } from "react-router-dom";
import readme from "./README.md?raw";
import React, { useEffect, useState } from "react";
import UnderConstruction from "../UnderConstruction";
import HeroSection from "./HeroSection";
import TechSkillsSection from "./TechSkillsSection";

export const Home = () => {
  const location = useLocation();
  const isUnderConstruction = false;
  const [mdFile, setMdFile] = React.useState<string>("");
  const [isVisible, setIsVisible] = useState(false);

  useEffect(() => {
    const loadMarkdownContent = async () => {
      setMdFile(readme);
    };

    loadMarkdownContent();
    // Add entrance animation
    const timer = setTimeout(() => setIsVisible(true), 100);
    return () => clearTimeout(timer);
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
      
      {/* Modern Layout with Creative Sections */}
      <div className={`transition-all duration-1000 ${isVisible ? 'opacity-100 translate-y-0' : 'opacity-0 translate-y-8'}`}>        {/* Hero Section - Full width with parallax effect */}
        <section className="relative">
          <div className="absolute inset-0 bg-gradient-to-br from-blue-600/10 via-teal-500/10 to-purple-600/10 animate-pulse"></div>
          <HeroSection />
        </section>

        {/* Content Grid Layout */}
        <div className="container mx-auto px-4 relative z-10">
          
          {/* Tech Skills in a floating card */}
          <div className="transform hover:scale-105 transition-transform duration-300 mb-16">
            <TechSkillsSection />
          </div>

          {/* Two-column layout for better content organization */}
          <div className="grid lg:grid-cols-3 gap-8 mb-16">
            
            {/* Left column - Documentation */}
            <div className="lg:col-span-2 space-y-8">
              <div className="bg-gradient-to-r from-gray-50 to-white dark:from-gray-800 dark:to-gray-900 rounded-2xl shadow-xl p-8 border border-gray-200 dark:border-gray-700">
                <div className="flex items-center mb-6">
                  <div className="w-3 h-3 bg-red-400 rounded-full mr-2"></div>
                  <div className="w-3 h-3 bg-yellow-400 rounded-full mr-2"></div>
                  <div className="w-3 h-3 bg-green-400 rounded-full mr-4"></div>
                  <h2 className="text-2xl font-bold text-gray-800 dark:text-gray-200">Project Documentation</h2>
                </div>
                <div className="prose prose-lg dark:prose-invert max-w-none">
                  <DisplayMd markdownContent={mdFile} id="readMe" />
                </div>
              </div>
            </div>

            {/* Right column - Tech Stacks as sidebar */}
            <div className="lg:col-span-1">
              <div className="sticky top-8">
                <div className="bg-white dark:bg-gray-800 rounded-2xl shadow-xl border border-gray-200 dark:border-gray-700 overflow-hidden">
                  <div className="bg-gradient-to-r from-teal-500 to-blue-600 p-4">
                    <h3 className="text-xl font-bold text-white">Technology Stack</h3>
                  </div>
                  <div className="p-6">
                    <StacksPage docBranch="techDocs" stackTitle="" />
                  </div>
                </div>
              </div>
            </div>
          </div>          {/* Interactive Data Panels Section */}
          <section className="mb-16">
            <div className="text-center mb-12">
              <h2 className="text-4xl font-bold text-teal-600 dark:text-teal-400 mb-4">
                Interactive Data Visualizations
              </h2>
              <p className="text-xl text-gray-600 dark:text-gray-400 max-w-3xl mx-auto">
                Explore dynamic charts and data analytics showcasing real-world applications of modern web technologies
              </p>
              <div className="w-24 h-1 bg-gradient-to-r from-teal-500 to-blue-500 rounded-full mx-auto mt-4"></div>
            </div>
            
            {/* Animated container for HomePanels */}
            <div className="relative">
              <div className="absolute inset-0 bg-gradient-to-r from-blue-400/5 via-teal-400/5 to-purple-400/5 rounded-3xl"></div>
              <div className="relative bg-white/80 dark:bg-gray-800/80 backdrop-blur-sm rounded-3xl shadow-2xl border border-gray-200/50 dark:border-gray-700/50 p-8">
                <HomePanels />
              </div>
            </div>
          </section>

          {/* Bottom decorative element */}
          <div className="flex justify-center mb-16">
            <div className="flex space-x-2">
              <div className="w-2 h-2 bg-teal-400 rounded-full animate-bounce"></div>
              <div className="w-2 h-2 bg-blue-400 rounded-full animate-bounce" style={{ animationDelay: '0.1s' }}></div>
              <div className="w-2 h-2 bg-purple-400 rounded-full animate-bounce" style={{ animationDelay: '0.2s' }}></div>
            </div>
          </div>
        </div>
      </div>
    </Layout>
  );
};

export default Home;
