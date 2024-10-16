import React from 'react';
import ReactMarkdown from 'react-markdown';
import './DisplayMd.css';
import useMarkdown from '../hooks/useMarkdown';

interface DisplayMdProps {
  filePath: string;
}

const DisplayMd: React.FC<DisplayMdProps> = ({ filePath }) => {
  // Render markdown content using React Markdown
  const {  error, loading } = useMarkdown(filePath);

  // If error occurs, display error message
  if (error) {
    return <div>Error: {error}</div>;
  }

  // If loading, display loading message
  if (loading) {
    return <div>Loading...</div>;
  }

  return (
    <div className="markdown-container">
        {/* Render the markdown content directly */}
        <ReactMarkdown>{filePath}</ReactMarkdown>
      </div>
  );
};

export default DisplayMd;
