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
    path: '/asafarim-blog/markdown-page',
    component: ComponentCreator('/asafarim-blog/markdown-page', '2f1'),
    exact: true
  },
  {
    path: '/asafarim-blog/docs',
    component: ComponentCreator('/asafarim-blog/docs', '4fd'),
    routes: [
      {
        path: '/asafarim-blog/docs',
        component: ComponentCreator('/asafarim-blog/docs', '026'),
        routes: [
          {
            path: '/asafarim-blog/docs',
            component: ComponentCreator('/asafarim-blog/docs', '954'),
            routes: [
              {
                path: '/asafarim-blog/docs/intro',
                component: ComponentCreator('/asafarim-blog/docs/intro', '33c'),
                exact: true,
                sidebar: "tutorialSidebar"
              }
            ]
          }
        ]
      }
    ]
  },
  {
    path: '*',
    component: ComponentCreator('*'),
  },
];
