import React, { useEffect } from 'react';
import ReactMarkdown from 'react-markdown';
import rehypeRaw from 'rehype-raw';
import rehypeSanitize from 'rehype-sanitize';
import Toolbar from '../Toolbars/Toolbar';
import FontSizeRadioButtons from '../FontSizeRadioButtons';
import SaveButtons from '../SaveButtons';
import { useTheme } from '@/contexts/ThemeContext';
import remarkRehype from 'remark-rehype';
import remarkGfm from 'remark-gfm';
import remarkStringify from 'remark-stringify';
import remarkParse from 'remark-parse';
import {logger} from '@/utils/logger';

interface DisplayMdProps {
  markdownContent: string;
  id?: string;
}

const DisplayMd: React.FC<DisplayMdProps> = ({ markdownContent, id }) => {
  const [fontSize, setFontSize] = React.useState('14px');
  const [viewBox, setViewBox] = React.useState('0 0 24 24');
  const [copySuccess, setCopySuccess] = React.useState(false);
  const themeContext = useTheme();

  useEffect(() => {
    logger.log('Theme:', themeContext.theme, "filename:", id);
    if (themeContext.theme === 'dark') {
      document.body.setAttribute('data-theme', 'dark');
    } else if (themeContext.theme === 'light') {
      document.body.setAttribute('data-theme', 'light');
    }
  }, [themeContext.theme, themeContext, id]);

  useEffect(() => {
    const element = id
      ? (document.getElementById(id) as HTMLDivElement)
      : (document.getElementsByClassName('markdown-container')[0] as HTMLDivElement);
    if (element) {
      element.style.fontSize = fontSize;
    }
  }, [fontSize, id]);

  useEffect(() => {
    setViewBox("-15 0 20 23");
    if (fontSize === '14px') {
      setViewBox("-15 -1 15 25");
    } else if (fontSize === '16px') {
      setViewBox("-15 0 20 23");
    }
  }, [fontSize]);

  const handleCopy = () => {
    navigator.clipboard.writeText(markdownContent).then(() => {
      setCopySuccess(true);
      setTimeout(() => setCopySuccess(false), 3000);
    });
  };

  const saveToFile = () => {
    const filename = id ? `${id}.md` : 'asafarim-about-me.md';
    logger.log('Saving Markdown file...', filename);

    const blob = new Blob([markdownContent], { type: 'text/markdown' });
    const url = URL.createObjectURL(blob);
    const anchor = document.createElement('a');
    anchor.href = url;
    anchor.download = filename;
    anchor.click();
    // Clean up the URL object
    URL.revokeObjectURL(url);
  };

  const saveHtmlToFile = () => {
    // Get the innerHTML of the element with class "markdown-body"
    const filename = id ? `${id}.html` : 'asafarim-about-me.html';
    logger.log('Saving HTML file...', filename);

    const markdownBodyElement = document.querySelector('.markdown-body');
    if (markdownBodyElement) {
      const markdownContent = markdownBodyElement.innerHTML;
      const blob = new Blob([markdownContent], { type: 'text/html' });
      const url = URL.createObjectURL(blob);
      const anchor = document.createElement('a');
      anchor.href = url;
      anchor.download = filename;
      anchor.click();
      // Clean up the URL object
      URL.revokeObjectURL(url);
    };
  }

  return (
    <div className="markdown-container flex flex-col m-5" id={id}>
      <Toolbar
        aria-label="Markdown Toolbar"
        className="md-toolbar m-4 p-4 flex flex-row justify-between items-center border-b"
      >
        {/* Left: Save Buttons */}
        <div className="flex items-center ">
          <SaveButtons
            onSaveMarkdown={saveToFile}
            onSaveHtml={saveHtmlToFile}
            onCopyMarkdown={handleCopy}
            copySuccess={copySuccess}
            viewBox={viewBox}
          />
        </div>
        {/* Right: Font Size Options */}
        <div className="flex items-center">
          <FontSizeRadioButtons currentFontSize={fontSize} onFontSizeChange={setFontSize} />
        </div>
      </Toolbar>

      <ReactMarkdown
        rehypePlugins={[
          rehypeRaw,
          [rehypeSanitize, {
            tagNames: ['img', 'figure', 'figcaption', 'style','p', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'ul', 'ol', 'li', 'blockquote', 'strong', 'em', 'code', 'br', 'table', 'thead', 'tbody', 'tr', 'th', 'td', 'div', 'span', 'iframe', 'details', 'summary', 'pre', 'code', 'kbd', 'samp', 'var', 'sub', 'sup', 'mark', 'del', 'ins', 'b', 'u', 'i', 'sup', 'sub', 'span', 'hr', 'br', 'a'],
            voidElements: ['br', 'img', 'iframe', 'details', 'summary'],
            attributes: {
              'img': ['src', 'alt', 'width', 'height'],
              'figure': ['src', 'alt', 'width', 'height'],
              'p': ['className', 'id', 'style'],
              'h1': ['className', 'id', 'style'],
              'h2': ['className', 'id', 'style'],
              'h3': ['className', 'id', 'style'],
              'h4': ['className', 'id', 'style'],
              'h5': ['className', 'id', 'style'],
              'h6': ['className', 'id', 'style'],
              'ul': ['className', 'id', 'style'],
              'ol': ['className', 'id', 'style'],
              'li': ['className', 'id', 'style'],
              'blockquote': ['className', 'id', 'style'],
              'strong': ['className', 'id', 'style'],
              'em': ['className', 'id', 'style'],
              'hr': ['className', 'id', 'style'],
              '*': ['className', 'id', 'style'],
              'a': ['href', 'target', 'rel'],
              'code': ['className', 'language'],
              'pre': ['className', 'language'],
              'kbd': ['className', 'id', 'style'],
              'samp': ['className', 'id', 'style'],
            }
          }]
        ]}
        className="markdown-body mt-4 px-4 py-2 md:px-8 md:py-4 lg:px-12 lg:py-6 xl:px-16 xl:py-8 rounded-md shadow-md"
        remarkPlugins={[
          remarkGfm,
          [remarkParse, { encoding: 'utf-8' }],
          [remarkRehype, { allowDangerousHtml: true }],
          remarkStringify
        ]}
        components={{
          code: ({ className, children, ...props }) => {
            const match = /language-(\w+)/.exec(className || '');
            return !match ? (
              <code className={className} {...props}>
                {children}
              </code>
            ) : (
              <pre className={`language-${match[1]} overflow-auto`}>
                <code className={className} {...props}>
                  {children}
                </code>
              </pre>
            );
          }
        }}
      >
        {markdownContent}
      </ReactMarkdown>
    </div>
  );
};

export default DisplayMd;
