/**
 * Content Parsing Utilities for Markdown
 */

/**
 * Extracts the first heading (H1) from markdown content
 * @param markdownContent - The markdown content to parse
 * @returns The text of the first H1 heading, or empty string if none found
 */
export function getFirstHeading(markdownContent: string): string {
  const headingRegex = /^# (.*)$/m;
  const match: RegExpMatchArray | null = markdownContent.match(headingRegex);
  return match ? match[1].trim() : '';
}

/**
 * Extracts all headings from markdown content
 * @param markdownContent - The markdown content to parse
 * @param maxLevel - Maximum heading level to extract (1-6)
 * @returns Array of heading objects with level, text, and anchor
 */
export function getAllHeadings(
  markdownContent: string, 
  maxLevel: number = 6
): Array<{ level: number; text: string; anchor: string }> {
  const headingRegex = /^(#{1,6})\s+(.*)$/gm;
  const headings: Array<{ level: number; text: string; anchor: string }> = [];
  let match;
  
  while ((match = headingRegex.exec(markdownContent)) !== null) {
    const level = match[1].length;
    if (level <= maxLevel) {
      const text = match[2].trim();
      const anchor = text
        .toLowerCase()
        .replace(/[^\w\s-]/g, '')
        .replace(/\s+/g, '-');
      
      headings.push({ level, text, anchor });
    }
  }
  
  return headings;
}

/**
 * Extracts the first paragraph from markdown content
 * @param markdownContent - The markdown content to parse
 * @returns The first paragraph text, or empty string if none found
 */
export function getFirstParagraph(markdownContent: string): string {
  // Remove headings, code blocks, and other markdown syntax
  const cleaned = markdownContent
    .replace(/^#{1,6}\s+.*$/gm, '') // Remove headings
    .replace(/```[\s\S]*?```/g, '') // Remove code blocks
    .replace(/`[^`]*`/g, '') // Remove inline code
    .replace(/\*\*([^*]*)\*\*/g, '$1') // Remove bold
    .replace(/\*([^*]*)\*/g, '$1') // Remove italic
    .replace(/\[([^\]]*)\]\([^)]*\)/g, '$1') // Remove links
    .trim();
  
  const paragraphs = cleaned.split(/\n\s*\n/);
  return paragraphs.find(p => p.trim().length > 0) || '';
}

/**
 * Extracts all links from markdown content
 * @param markdownContent - The markdown content to parse
 * @returns Array of link objects with text and url
 */
export function extractLinks(markdownContent: string): Array<{ text: string; url: string }> {
  const linkRegex = /\[([^\]]*)\]\(([^)]*)\)/g;
  const links: Array<{ text: string; url: string }> = [];
  let match;
  
  while ((match = linkRegex.exec(markdownContent)) !== null) {
    links.push({
      text: match[1],
      url: match[2]
    });
  }
  
  return links;
}

/**
 * Extracts all images from markdown content
 * @param markdownContent - The markdown content to parse
 * @returns Array of image objects with alt text and src
 */
export function extractImages(markdownContent: string): Array<{ alt: string; src: string; title?: string }> {
  const imageRegex = /!\[([^\]]*)\]\(([^)]*?)(?:\s+"([^"]*)")?\)/g;
  const images: Array<{ alt: string; src: string; title?: string }> = [];
  let match;
  
  while ((match = imageRegex.exec(markdownContent)) !== null) {
    images.push({
      alt: match[1],
      src: match[2],
      title: match[3] || undefined
    });
  }
  
  return images;
}

/**
 * Extracts code blocks from markdown content
 * @param markdownContent - The markdown content to parse
 * @returns Array of code block objects with language and content
 */
export function extractCodeBlocks(markdownContent: string): Array<{ language: string; content: string }> {
  const codeBlockRegex = /```(\w*)\n([\s\S]*?)```/g;
  const codeBlocks: Array<{ language: string; content: string }> = [];
  let match;
  
  while ((match = codeBlockRegex.exec(markdownContent)) !== null) {
    codeBlocks.push({
      language: match[1] || 'text',
      content: match[2].trim()
    });
  }
  
  return codeBlocks;
}

/**
 * Removes markdown syntax and returns plain text
 * @param markdownContent - The markdown content to parse
 * @returns Plain text without markdown syntax
 */
export function stripMarkdown(markdownContent: string): string {
  return markdownContent
    .replace(/^#{1,6}\s+/gm, '') // Remove heading markers
    .replace(/\*\*([^*]*)\*\*/g, '$1') // Remove bold
    .replace(/\*([^*]*)\*/g, '$1') // Remove italic
    .replace(/~~([^~]*)~~/g, '$1') // Remove strikethrough
    .replace(/`([^`]*)`/g, '$1') // Remove inline code
    .replace(/```[\s\S]*?```/g, '') // Remove code blocks
    .replace(/\[([^\]]*)\]\([^)]*\)/g, '$1') // Remove links, keep text
    .replace(/!\[([^\]]*)\]\([^)]*\)/g, '$1') // Remove images, keep alt text
    .replace(/^\s*[-*+]\s+/gm, '') // Remove list markers
    .replace(/^\s*\d+\.\s+/gm, '') // Remove numbered list markers
    .replace(/^\s*>\s+/gm, '') // Remove blockquote markers
    .replace(/\n\s*\n/g, '\n') // Remove extra line breaks
    .trim();
}

/**
 * Counts words in markdown content (plain text)
 * @param markdownContent - The markdown content to analyze
 * @returns Number of words
 */
export function getWordCount(markdownContent: string): number {
  const plainText = stripMarkdown(markdownContent);
  // Remove extra whitespace and normalize
  const normalizedText = plainText.replace(/\s+/g, ' ').trim();
  if (normalizedText.length === 0) {
    return 0;
  }
  return normalizedText.split(' ').filter(word => word.length > 0).length;
}

/**
 * Estimates reading time for markdown content
 * @param markdownContent - The markdown content to analyze
 * @param wordsPerMinute - Average reading speed (default: 200)
 * @returns Estimated reading time in minutes
 */
export function getReadingTime(markdownContent: string, wordsPerMinute: number = 200): number {
  const wordCount = getWordCount(markdownContent);
  const readingTime = wordCount / wordsPerMinute;
  return Math.max(1, Math.ceil(readingTime)); // Minimum 1 minute
}
