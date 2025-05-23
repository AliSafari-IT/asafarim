import { useState, useEffect } from 'react';
import {logger} from '@/utils/logger';

interface MarkdownItem {
  name: string;
  path: string;
  slug: string;
  isDirectory: boolean;
  children?: MarkdownItem[];
}

const useTechDocs = () => {
  const [techDocs, setTechDocs] = useState<MarkdownItem[]>([]);

  useEffect(() => {
    // Assuming you have an API or a file structure available
    fetch('/api/markdown-files') // Adjust this endpoint
      .then((response) => response.json())
      .then((data) => setTechDocs(data))
      .catch((error) => logger.error('Failed to fetch tech docs:', error));
  }, []);

  return techDocs;
};

export default useTechDocs;
