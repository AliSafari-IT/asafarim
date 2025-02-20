import DisplayMd from "../../components/MarkdownPage/DisplayMd";
import Wrapper from "../../layout/Wrapper/Wrapper";
import aboutMeMd from "./aboutme.en.md?raw";
import aboutMeNlMd from "./aboutme.nl.md?raw";
import AdditionalInfo from "./AdditionalInfo";
import { useState } from "react";

export default function About(): JSX.Element {
  const [isExpanded, setIsExpanded] = useState(false);

  return (
    <Wrapper footer={null}>
      <div className="flex flex-col gap-6">
        {/* First row: English and Dutch summaries */}
        <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
          <div className="bg-white dark:bg-gray-800 p-6 rounded-lg shadow-md">
            <h2 className="text-2xl font-bold mb-4 text-teal-600 dark:text-teal-400">
              About Me
            </h2>
            <DisplayMd markdownContent={aboutMeMd} id="about-me-en" />
          </div>
          <div className="bg-white dark:bg-gray-800 p-6 rounded-lg shadow-md">
            <h2 className="text-2xl font-bold mb-4 text-teal-600 dark:text-teal-400">
              Over Mij
            </h2>
            <DisplayMd markdownContent={aboutMeNlMd} id="about-me-nl" />
          </div>
        </div>

        {/* Second row: Collapsible Additional Information */}
        <div className="bg-gradient-to-r from-teal-50 to-blue-50 dark:from-gray-800 dark:to-gray-750 rounded-lg shadow-md overflow-hidden hover:shadow-lg transition-shadow duration-200 border border-teal-100 dark:border-teal-900">
          <button
            onClick={() => setIsExpanded(!isExpanded)}
            className="w-full p-6 text-left focus:outline-none focus:ring-2 focus:ring-teal-500 focus:ring-opacity-50 hover:from-teal-100 hover:to-blue-100 dark:hover:from-gray-750 dark:hover:to-gray-700 transition-all duration-200"
          >
            <div className="flex items-center justify-between">
              <div className="flex items-center space-x-2">
                <h2 className="text-2xl font-bold text-teal-700 dark:text-teal-300">
                  Technical Background & Expertise
                </h2>
                <span className="text-sm text-teal-600/70 dark:text-teal-400/70 font-medium">
                  {isExpanded ? '(click to collapse)' : '(click to expand)'}
                </span>
              </div>
              <div className="flex items-center space-x-2">
                <span className="text-sm text-teal-600 dark:text-teal-400 font-medium">
                  {isExpanded ? 'Show Less' : 'Show More'}
                </span>
                <svg
                  className={`w-6 h-6 transform transition-transform duration-200 text-teal-600 dark:text-teal-400 ${
                    isExpanded ? "rotate-180" : ""
                  }`}
                  fill="none"
                  stroke="currentColor"
                  viewBox="0 0 24 24"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth={2}
                    d="M19 9l-7 7-7-7"
                  />
                </svg>
              </div>
            </div>
          </button>
          
          <div
            className={`transition-all duration-300 ease-in-out ${
              isExpanded ? "max-h-[2000px] opacity-100" : "max-h-0 opacity-0"
            } overflow-hidden bg-white dark:bg-gray-800`}
          >
            <div className="p-6 border-t border-teal-100 dark:border-teal-900">
              <AdditionalInfo />
            </div>
          </div>
        </div>
      </div>
    </Wrapper>
  );
}
