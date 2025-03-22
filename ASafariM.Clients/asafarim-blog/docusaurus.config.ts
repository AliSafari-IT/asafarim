import {themes as prismThemes} from 'prism-react-renderer';
import type {Config} from '@docusaurus/types';
import type * as Preset from '@docusaurus/preset-classic';
// This runs in Node.js - Don't use client-side code here (browser APIs, JSX...)
const config: Config = { 
  title: 'Blog | ASafariM',
  tagline: 'Thoughts, stories and ideas from Ali Safari',
  favicon: 'img/favicon.ico',

  // Set the production url of your site here
  url: 'https://blog.asafarim.com',
  // Set the /<baseUrl>/ pathname under which your site is served
  // For GitHub pages deployment, it is often '/<projectName>/'
  baseUrl: '/',

  // GitHub pages deployment config.
  // If you aren't using GitHub pages, you don't need these.
  organizationName: 'AliSafari-IT', // Usually your GitHub org/user name.
  projectName: 'asafarim', // Usually your repo name.

  onBrokenLinks: 'ignore', 
  onBrokenMarkdownLinks: 'ignore',

  // Even if you don't use internationalization, you can use this field to set
  // useful metadata like html lang. For example, if your site is Chinese, you
  // may want to replace "en" with "zh-Hans".
  i18n: {
    defaultLocale: 'en',
    locales: ['en'],
  },

  presets: [
    [
      'classic',
      {
        docs: {
          sidebarPath: './sidebars.ts',
          editUrl:
            'https://github.com/AliSafari-IT/asafarim/tree/main/ASafariM.Clients/asafarim-blog/',
        },
        blog: {
          showReadingTime: true,
          feedOptions: {
            type: ['rss', 'atom'],
            xslt: true,
          },
          editUrl:
            'https://github.com/AliSafari-IT/asafarim/tree/main/ASafariM.Clients/asafarim-blog/',
          onInlineTags: 'warn',
          onInlineAuthors: 'warn',
          onUntruncatedBlogPosts: 'warn',
        },
        theme: {
          customCss: './src/css/custom.css',
        },
      } satisfies Preset.Options,
    ],
  ],

  themeConfig: {
    image: 'img/logoT.svg',
    navbar: {
      title: 'Blog | ASafariM',
      hideOnScroll: false,
      style: 'dark',
      logo: {
        alt: 'ASafariM Logo',
        src: 'img/logoT.svg',
        srcDark: 'img/logoT.svg',
        href: 'https://asafarim.com',
      },
      items: [
        {
          type: 'docSidebar',
          sidebarId: 'tutorialSidebar',
          position: 'left',
          label: 'Articles',
        },
        {to: '/blog', label: 'Blog', position: 'left'},
        {
          href: 'https://github.com/AliSafari-IT/asafarim',
          label: 'GitHub',
          position: 'right',
        },
      ],
    },
    footer: {
      style: 'light',
      links: [
        {
          title: 'Docs',
          items: [
            {
              label: 'Introduction',
              to: '/docs/intro',
            },
          ],
        },
        {
          title: 'Connect',
          items: [
            {
              label: 'GitHub',
              href: 'https://github.com/AliSafari-IT',
            },
            {
              label: 'LinkedIn',
              href: 'https://www.linkedin.com/in/ali-safari-m/',
            },
          ],
        },
        {
          title: 'More',
          items: [
            {
              label: 'Blog',
              to: '/blog',
            },
            {
              label: 'ASafariM Website',
              href: 'https://asafarim.com',
            },
          ],
        },
      ],
      copyright: `Copyright ${new Date().getFullYear()} ASafariM. Built with Docusaurus.`,
    },
    prism: {
      theme: prismThemes.github,
      darkTheme: prismThemes.dracula,
    },
  } satisfies Preset.ThemeConfig,
};

export default config;
