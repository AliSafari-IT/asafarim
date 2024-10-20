import React from 'react';
import ReactMarkdown from 'react-markdown';
import rehypeRaw from 'rehype-raw'; 
import rehypeSanitize from 'rehype-sanitize'; 
import './DisplayMd.css';
import useMarkdown from '../hooks/useMarkdown';

interface DisplayMdProps {
  filePath: string;
}

const DisplayMd: React.FC<DisplayMdProps> = ({ filePath }) => {
  const {  error, loading } = useMarkdown(filePath);

  if (error) {
    return <div>Error: {error}</div>;
  }

  if (loading) {
    return <div>Loading...</div>;
  }

  return (
    <div className="markdown-container">
      <ReactMarkdown rehypePlugins={[rehypeRaw, rehypeSanitize]}>{filePath}</ReactMarkdown>
    </div>
  );
};

export default DisplayMd;
