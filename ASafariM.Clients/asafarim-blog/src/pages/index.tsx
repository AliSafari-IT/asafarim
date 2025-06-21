import React from 'react';
import clsx from 'clsx';
import Link from '@docusaurus/Link';
import useDocusaurusContext from '@docusaurus/useDocusaurusContext';
import Layout from '@theme/Layout';
import HomepageFeatures from '../components/HomepageFeatures';
import { DDMenu, MenuItem } from "@asafarim/dd-menu";
import "@asafarim/dd-menu/dist/index.css";
import styles from './index.module.css';

// ...define menuItems and use as usual
const menuItems: MenuItem[] = [
  {
    id: "goto",
    label: "Go to",
    link: undefined,
    children: [
      { id: "1", label: "Homepage", link: "https://asafarim.com" },
      {
        id: "2",
        label: "Social Links",
        children: [
          { id: "2-1", label: "LinkedIn", link: "https://linkedin.com/in/ali-safari-m" },
          { id: "2-2", label: "Twitter", link: "https://twitter.com/asafarim" },
          { id: "2-3", label: "GitHub", link: "https://github.com/AliSafari-IT" }, 
        ],
      },
      { id: "3", label: "About", link: "https://asafarim.com/about" },
    ],
  },
];

export function HomepageHeader() {
  const {siteConfig} = useDocusaurusContext();
  return ( 
    <header className={clsx('hero', styles.heroBanner)}>
      <div className="container">
        <div className={styles.heroContent}>
          <div className={styles.heroText}>
            <h1 className={styles.heroTitle}>Welcome to<br /><span className={styles.highlight}>ASafariM Blog</span></h1>
            <p className={styles.heroSubtitle}>{siteConfig.tagline}</p>
            <p className={styles.heroDescription}>
              Exploring software development, technology trends, and the latest in web development. 
              Join me on this journey of continuous learning and innovation.
            </p>
            <div className={styles.buttons}>
              <Link
                className={clsx('button button--primary button--lg', styles.heroButton)}
                to="/blog">
                Read Articles
              </Link>
              <Link
                className={clsx('button button--outline button--lg', styles.heroButton)}
                to="/docs/intro">
                Learn More
              </Link>
               <div className={styles.authorMenu}>
              <DDMenu items={menuItems} theme="dark" className={styles.menu} />
            </div> 
            </div>
          </div>
          <div className={styles.heroImage}>
            <img src="/img/blog-hero-image.svg" alt="ASafariM Blog" />
          </div>
        </div>
      </div>
    </header>
  );
}

export function RecentPosts() {
  return (
    <section className={styles.recentPosts}>
      <div className="container">
        <div className={styles.sectionHeader}>
          <h2 className={styles.sectionTitle}>Recent <span className={styles.highlight}>Articles</span></h2>
          <p className={styles.sectionSubtitle}>
            Stay up-to-date with my latest thoughts and insights
          </p>
        </div>
        <div className={styles.postsGrid}>
          {/* This section will be populated by Docusaurus with actual blog posts */}
          {/* We're just defining the structure and styling */}
        </div>
        <div className={styles.viewAllContainer}>
          <Link
            className={clsx('button button--outline button--lg', styles.viewAllButton)}
            to="/blog">
            View All Posts
          </Link>
        </div>
      </div>
    </section>
  );
}

export default function Home(): JSX.Element {
  const {siteConfig} = useDocusaurusContext();
  return (
    <Layout
      title={`${siteConfig.title}`}
      description="ASafariM Blog - Thoughts, stories and ideas from Ali Safari">
      <HomepageHeader />
      <main>
        <HomepageFeatures />
        <RecentPosts />
      </main>
      <section className={styles.ctaSection}>
        <div className="container">
          <div className={styles.ctaContainer}>
            <h2 className={styles.ctaTitle}>Ready to explore more?</h2>
            <p className={styles.ctaDescription}>
              Dive deeper into software engineering topics and stay connected with the latest updates.
            </p>
            <div className={styles.ctaButtons}>
              <Link
                className={clsx('button button--primary button--lg', styles.ctaButton)}
                to="/blog">
                Start Reading
              </Link>
              <Link
                className={clsx('button button--outline button--lg', styles.ctaButton)}
                to="https://github.com/AliSafari-IT">
                Follow on GitHub
              </Link>
            </div>
          </div>
        </div>
      </section>
    </Layout>
  );
}
