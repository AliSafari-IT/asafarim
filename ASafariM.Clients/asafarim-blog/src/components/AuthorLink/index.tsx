import React from 'react';
import Link from '@docusaurus/Link';
import { getAuthor } from '../../utils/authorsData';
import styles from './styles.module.css';

interface AuthorLinkProps {
  authorKey: string;
}

export default function AuthorLink({ authorKey }: AuthorLinkProps): JSX.Element | null {
  const author = getAuthor(authorKey);
  
  if (!author) {
    return null;
  }
  
  return (
    <Link to={`/authors/${authorKey}`} className={styles.authorLink}>
      <div className={styles.authorCard}>
        <img 
          src={author.image_url} 
          alt={author.name} 
          className={styles.authorAvatar}
        />
        <div className={styles.authorInfo}>
          <div className={styles.authorName}>{author.name}</div>
          <div className={styles.authorTitle}>{author.title}</div>
        </div>
      </div>
    </Link>
  );
}
