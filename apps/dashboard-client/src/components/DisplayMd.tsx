import React from 'react';
import ReactMarkdown from 'react-markdown';
import rehypeRaw from 'rehype-raw';
import rehypeSanitize from 'rehype-sanitize';
import './DisplayMd.css';

interface DisplayMdProps {
  markdownContent: string;
}

const DisplayMd: React.FC<DisplayMdProps> = ({ markdownContent }) => {
  return (
    <div className="markdown-container">
      <ReactMarkdown rehypePlugins={[rehypeRaw, rehypeSanitize]}>
        {markdownContent}
      </ReactMarkdown>
    </div>
  );
};

export default DisplayMd;
