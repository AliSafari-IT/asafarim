import React from 'react';
import DisplayMd from "../../components/DisplayMd";
import Wrapper from "../../layout/Wrapper/Wrapper";
// Import Markdown file as raw text
import aboutMeMd from './aboutme.md?raw';

const About = () => {
  const headerBlock = (
    <div className="w-full text-center mx-auto m-0 text-gray-200 p-8 bg-gray-700">
      <h1 className="text-3xl font-bold">About Me!</h1>
    </div>
  );

  return (
    <Wrapper header={headerBlock}>
      {/* Pass the markdown content (aboutMeMd) as the filePath prop */}
      <div className="p-8">
      <DisplayMd filePath={aboutMeMd} />
      </div>
    </Wrapper>
  );
};

export default About;
