import React from 'react';
import Layout from '@theme/Layout';
import Link from '@docusaurus/Link';
import useDocusaurusContext from '@docusaurus/useDocusaurusContext';
import { getAllAuthors } from '../../utils/authorsData';
import styles from './authors.module.css';

export default function AuthorsPage(): JSX.Element {
  const {siteConfig} = useDocusaurusContext();
  const authors = getAllAuthors();
  
  return (
    <Layout
      title="Authors"
      description="Blog authors at ASafariM">
      <main className="container margin-vert--lg">
        <h1>Blog Authors</h1>
        <div className={styles.authorsGrid}>
          {authors.map((author) => (
            <div key={author.key} className={styles.authorCard}>
              <Link to={`/authors/${author.key}`} className={styles.authorCardLink}>
                <div className={styles.authorCardContent}>
                  <img 
                    src={author.image_url} 
                    alt={author.name} 
                    className={styles.authorAvatar} 
                  />
                  <h2 className={styles.authorName}>{author.name}</h2>
                  <p className={styles.authorTitle}>{author.title}</p>
                </div>
              </Link>
            </div>
          ))}
        </div>
      </main>
    </Layout>
  );
}
