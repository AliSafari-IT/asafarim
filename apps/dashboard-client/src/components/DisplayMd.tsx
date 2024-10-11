import React from 'react';
import ReactMarkdown from 'react-markdown';
import './DisplayMd.css';

interface DisplayMdProps {
  filePath: string;
}

const DisplayMd: React.FC<DisplayMdProps> = ({ filePath }) => {
  return (
    <div className="markdown-container">
      {/* Render the markdown content directly */}
      <ReactMarkdown>{filePath}</ReactMarkdown>
    </div>
  );
};

export default DisplayMd;
