import { useState, useEffect } from 'react';

/**
 * Fetches the contents of a markdown file and returns an object with
 * `content`, `error`, and `loading` properties.
 *
 * `content` is the text content of the markdown file, initially an empty string.
 * `error` is an error message if the fetch fails, or `null` otherwise.
 * `loading` is a boolean indicating whether the fetch is in progress.
 *
 * @param {string} filePath URL of the markdown file to fetch.
 * @returns {object} An object with `content`, `error`, and `loading` properties.
 */
const useMarkdown = (filePath: string) => { 
  const [content, setContent] = useState('');
  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
    const fetchMarkdown = async () => {
      try {
        const response = await fetch(filePath);
        if (!response.ok) {
          throw new Error('Failed to load markdown file.');
        }
        const markdown = await response.text();
        
        setContent(markdown);
      } catch (err: any) {
        setError(err.message);
      } finally {
        setLoading(false);
      }
    };

    fetchMarkdown();
  }, [filePath]);

  return { content, error, loading };
};

export default useMarkdown;
