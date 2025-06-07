import React from 'react';
import Link from '@docusaurus/Link';
import styles from './styles.module.css';

export interface AuthorInfoProps {
  authorKey: string;
  name: string;
  title: string;
  imageUrl: string;
}

export default function AuthorInfo({
  authorKey,
  name,
  title,
  imageUrl,
}: AuthorInfoProps): JSX.Element {
  return (
    <div className={styles.authorInfoContainer}>
      <Link to={`/authors/${authorKey}`} className={styles.authorLink}>
        <div className={styles.authorCard}>
          <img src={imageUrl} alt={name} className={styles.authorAvatar} />
          <div className={styles.authorDetails}>
            <h3 className={styles.authorName}>{name}</h3>
            <p className={styles.authorTitle}>{title}</p>
            <span className={styles.viewProfile}>View Full Profile</span>
          </div>
        </div>
      </Link>
    </div>
  );
}
