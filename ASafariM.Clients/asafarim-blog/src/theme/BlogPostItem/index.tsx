import React from 'react';
import Link from '@docusaurus/Link';
import OriginalBlogPostItem from '@theme-original/BlogPostItem';
import authorsData from '../../utils/authorsData';
import styles from './styles.module.css';

// Define type for author data
interface AuthorData {
  name: string;
  title: string;
  image_url: string;
  [key: string]: any; // For other possible properties
}

// We need to extend the original component with a proper wrapper
export default function BlogPostItem(props: any): JSX.Element {
  // Use useLayoutEffect to modify DOM after render but before paint
  React.useLayoutEffect(() => {
    // Wait for a small delay to ensure DOM is fully rendered
    setTimeout(() => {
      // Find all author containers/links in the document
      // First, look for the parent element that might contain the avatar
      const authorContainers = document.querySelectorAll('.avatar');
      
      authorContainers.forEach((container) => {
        // Check if this is a blog post author avatar
        if (container.closest('.blog-post-header')) {
          // Find the name element
          const nameElement = container.querySelector('.avatar__name');
          if (!nameElement) return;
          
          // Get the author name
          const authorName = nameElement.textContent?.trim();
          if (!authorName) return;
          
          // Find any existing links that might be mailto links
          const existingLinks = nameElement.querySelectorAll('a');
          if (existingLinks.length > 0) {
            // Remove any mailto links completely
            existingLinks.forEach(link => {
              if (link.href.startsWith('mailto:')) {
                // Store the text content before removing
                const linkText = link.textContent;
                // Replace the link with just the text
                link.replaceWith(document.createTextNode(linkText || ''));
              }
            });
          }
          
          // Find the author key that matches this name
          const typedAuthorsData = authorsData as Record<string, AuthorData>;
          const authorEntry = Object.entries(typedAuthorsData).find(
            ([_, data]) => data.name === authorName
          );
          
          if (authorEntry) {
            const [authorKey, _] = authorEntry;
            
            // Create our own link to the dynamic author page
            const authorPageLink = document.createElement('a');
            authorPageLink.href = `/authors/${authorKey}`;
            authorPageLink.textContent = authorName;
            authorPageLink.className = styles.authorLink;
            authorPageLink.title = `View posts by ${authorName}`;
            
            // Replace the name text with our link
            nameElement.textContent = '';
            nameElement.appendChild(authorPageLink);
            
            // Prevent default click behavior on the avatar which might have a mailto link
            const avatarPhoto = container.querySelector('.avatar__photo');
            if (avatarPhoto) {
              // If the photo is in a link, override that link too
              const photoLink = avatarPhoto.closest('a');
              if (photoLink) {
                photoLink.href = `/authors/${authorKey}`;
                photoLink.title = `View posts by ${authorName}`;
                
                // Remove any onclick handlers and let the link work naturally
                photoLink.removeAttribute('onclick');
                
                // Make sure it doesn't have a mailto link
                if (photoLink.href.startsWith('mailto:')) {
                  photoLink.href = `/authors/${authorKey}`;
                }
              } else {
                // If the photo isn't in a link, wrap it in one
                const wrapper = document.createElement('a');
                wrapper.href = `/authors/${authorKey}`;
                wrapper.title = `View posts by ${authorName}`;
                wrapper.className = styles.authorPhotoLink;
                
                // Replace the photo with a linked version
                const parent = avatarPhoto.parentElement;
                if (parent) {
                  const photoClone = avatarPhoto.cloneNode(true);
                  wrapper.appendChild(photoClone);
                  parent.replaceChild(wrapper, avatarPhoto);
                }
              }
            }
          }
        }
      });
    }, 100); // Small delay to ensure everything is rendered
  }, []); // Empty dependency array - run once after mount
  
  // Simply render the original component
  return <OriginalBlogPostItem {...props} />;
}
