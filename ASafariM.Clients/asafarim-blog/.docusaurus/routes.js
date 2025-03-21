import React from 'react';
import ComponentCreator from '@docusaurus/ComponentCreator';

export default [
  {
    path: '/asafarim-blog/__docusaurus/debug',
    component: ComponentCreator('/asafarim-blog/__docusaurus/debug', 'bd5'),
    exact: true
  },
  {
    path: '/asafarim-blog/__docusaurus/debug/config',
    component: ComponentCreator('/asafarim-blog/__docusaurus/debug/config', '785'),
    exact: true
  },
  {
    path: '/asafarim-blog/__docusaurus/debug/content',
    component: ComponentCreator('/asafarim-blog/__docusaurus/debug/content', '188'),
    exact: true
  },
  {
    path: '/asafarim-blog/__docusaurus/debug/globalData',
    component: ComponentCreator('/asafarim-blog/__docusaurus/debug/globalData', 'b0b'),
    exact: true
  },
  {
    path: '/asafarim-blog/__docusaurus/debug/metadata',
    component: ComponentCreator('/asafarim-blog/__docusaurus/debug/metadata', 'b66'),
    exact: true
  },
  {
    path: '/asafarim-blog/__docusaurus/debug/registry',
    component: ComponentCreator('/asafarim-blog/__docusaurus/debug/registry', '7fc'),
    exact: true
  },
  {
    path: '/asafarim-blog/__docusaurus/debug/routes',
    component: ComponentCreator('/asafarim-blog/__docusaurus/debug/routes', '2bc'),
    exact: true
  },
  {
    path: '/asafarim-blog/blog',
    component: ComponentCreator('/asafarim-blog/blog', 'e0e'),
    exact: true
  },
  {
    path: '/asafarim-blog/blog/archive',
    component: ComponentCreator('/asafarim-blog/blog/archive', '784'),
    exact: true
  },
  {
    path: '/asafarim-blog/blog/authors',
    component: ComponentCreator('/asafarim-blog/blog/authors', '20e'),
    exact: true
  },
  {
    path: '/asafarim-blog/blog/tags',
    component: ComponentCreator('/asafarim-blog/blog/tags', '45c'),
    exact: true
  },
  {
    path: '/asafarim-blog/blog/tags/asafarim',
    component: ComponentCreator('/asafarim-blog/blog/tags/asafarim', '952'),
    exact: true
  },
  {
    path: '/asafarim-blog/blog/tags/blog',
    component: ComponentCreator('/asafarim-blog/blog/tags/blog', '085'),
    exact: true
  },
  {
    path: '/asafarim-blog/blog/tags/welcome',
    component: ComponentCreator('/asafarim-blog/blog/tags/welcome', 'a40'),
    exact: true
  },
  {
    path: '/asafarim-blog/blog/welcome-to-asafarim-blog',
    component: ComponentCreator('/asafarim-blog/blog/welcome-to-asafarim-blog', '861'),
    exact: true
  },
  {
    path: '/asafarim-blog/markdown-page',
    component: ComponentCreator('/asafarim-blog/markdown-page', '2f1'),
    exact: true
  },
  {
    path: '/asafarim-blog/docs',
    component: ComponentCreator('/asafarim-blog/docs', '8ee'),
    routes: [
      {
        path: '/asafarim-blog/docs',
        component: ComponentCreator('/asafarim-blog/docs', 'd7b'),
        routes: [
          {
            path: '/asafarim-blog/docs',
            component: ComponentCreator('/asafarim-blog/docs', 'ae8'),
            routes: [
              {
                path: '/asafarim-blog/docs/intro',
                component: ComponentCreator('/asafarim-blog/docs/intro', '331'),
                exact: true
              }
            ]
          }
        ]
      }
    ]
  },
  {
    path: '/asafarim-blog/',
    component: ComponentCreator('/asafarim-blog/', '168'),
    exact: true
  },
  {
    path: '*',
    component: ComponentCreator('*'),
  },
];
