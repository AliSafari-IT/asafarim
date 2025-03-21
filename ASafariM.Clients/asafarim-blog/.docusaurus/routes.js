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
    component: ComponentCreator('/asafarim-blog/docs', 'be0'),
    routes: [
      {
        path: '/asafarim-blog/docs',
        component: ComponentCreator('/asafarim-blog/docs', '138'),
        routes: [
          {
            path: '/asafarim-blog/docs',
            component: ComponentCreator('/asafarim-blog/docs', '97d'),
            routes: [
              {
                path: '/asafarim-blog/docs/category/tutorial---basics',
                component: ComponentCreator('/asafarim-blog/docs/category/tutorial---basics', '189'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/asafarim-blog/docs/category/tutorial---extras',
                component: ComponentCreator('/asafarim-blog/docs/category/tutorial---extras', '049'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/asafarim-blog/docs/intro',
                component: ComponentCreator('/asafarim-blog/docs/intro', '33c'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/asafarim-blog/docs/tutorial-basics/congratulations',
                component: ComponentCreator('/asafarim-blog/docs/tutorial-basics/congratulations', '5a4'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/asafarim-blog/docs/tutorial-basics/create-a-blog-post',
                component: ComponentCreator('/asafarim-blog/docs/tutorial-basics/create-a-blog-post', '9a0'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/asafarim-blog/docs/tutorial-basics/create-a-document',
                component: ComponentCreator('/asafarim-blog/docs/tutorial-basics/create-a-document', 'ea7'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/asafarim-blog/docs/tutorial-basics/create-a-page',
                component: ComponentCreator('/asafarim-blog/docs/tutorial-basics/create-a-page', '005'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/asafarim-blog/docs/tutorial-basics/deploy-your-site',
                component: ComponentCreator('/asafarim-blog/docs/tutorial-basics/deploy-your-site', '971'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/asafarim-blog/docs/tutorial-basics/markdown-features',
                component: ComponentCreator('/asafarim-blog/docs/tutorial-basics/markdown-features', '1d3'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/asafarim-blog/docs/tutorial-extras/manage-docs-versions',
                component: ComponentCreator('/asafarim-blog/docs/tutorial-extras/manage-docs-versions', '4be'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/asafarim-blog/docs/tutorial-extras/translate-your-site',
                component: ComponentCreator('/asafarim-blog/docs/tutorial-extras/translate-your-site', 'c0c'),
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
    path: '/asafarim-blog/',
    component: ComponentCreator('/asafarim-blog/', '168'),
    exact: true
  },
  {
    path: '*',
    component: ComponentCreator('*'),
  },
];
