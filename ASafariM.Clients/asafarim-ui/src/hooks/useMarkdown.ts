import { useEffect, useState } from 'react';
import {logger} from '@/utils/logger';

function useMarkdown(filePath: string) {
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [markdownContent, setMarkdownContent] = useState('');

  useEffect(() => {
    const fetchMarkdown = async () => {
      try {
        logger.log('Fetching markdown file from:', filePath); // Add this log to check the file path
        const response = await fetch(filePath); // Ensure this fetches the correct markdown file URL
    
        if (!response.ok) {
          throw new Error(`Failed to fetch markdown file: ${response.statusText}`);
        }
    
        const text = await response.text();
        logger.log('Fetched markdown content:', text); // Check if the content is valid markdown
    
        setMarkdownContent(text);
      } catch (err) {
        setError('Failed to load markdown file.');
        logger.error('Error fetching markdown:', err); // Log any fetch errors
      } finally {
        setLoading(false);
      }
    };
    

    if (filePath) {
      fetchMarkdown();
    }
  }, [filePath]);

  return { error, loading, markdownContent };
}

export default useMarkdown;
