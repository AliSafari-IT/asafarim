import React from 'react';
import Link from '@docusaurus/Link';
import styles from './styles.module.css';
import { getAuthor } from '../../utils/authorsData';

interface Props {
  className?: string;
  authors: string[];
}

function BlogPostAuthor({ author }) {
  const { name, title, image_url, key } = author;
  
  return (
    <div className={styles.authorContainer}>
      <Link to={`/authors/${key}`} className={styles.authorLink}>
        <div className={styles.authorCard}>
          <img src={image_url} alt={name} className={styles.authorAvatar} />
          <div className={styles.authorInfo}>
            <div className={styles.authorName}>{name}</div>
            <div className={styles.authorTitle}>{title}</div>
          </div>
        </div>
      </Link>
    </div>
  );
}

export default function BlogPostAuthors({ className, authors }: Props): JSX.Element {
  // If no authors are listed, don't render anything
  if (!authors || authors.length === 0) {
    return <></>;
  }

  return (
    <div className={`${styles.authorsContainer} ${className || ''}`}>
      {authors.map((authorKey) => {
        // Get author data from our utility
        const authorData = getAuthor(authorKey);
        if (!authorData) return null;
        
        // Add the key to the author data
        const author = { ...authorData, key: authorKey };
        
        return <BlogPostAuthor key={authorKey} author={author} />;
      })}
    </div>
  );
}
