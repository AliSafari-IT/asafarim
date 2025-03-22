import React from 'react';
import ComponentCreator from '@docusaurus/ComponentCreator';

export default [
  {
    path: '/__docusaurus/debug',
    component: ComponentCreator('/__docusaurus/debug', '5ff'),
    exact: true
  },
  {
    path: '/__docusaurus/debug/config',
    component: ComponentCreator('/__docusaurus/debug/config', '5ba'),
    exact: true
  },
  {
    path: '/__docusaurus/debug/content',
    component: ComponentCreator('/__docusaurus/debug/content', 'a2b'),
    exact: true
  },
  {
    path: '/__docusaurus/debug/globalData',
    component: ComponentCreator('/__docusaurus/debug/globalData', 'c3c'),
    exact: true
  },
  {
    path: '/__docusaurus/debug/metadata',
    component: ComponentCreator('/__docusaurus/debug/metadata', '156'),
    exact: true
  },
  {
    path: '/__docusaurus/debug/registry',
    component: ComponentCreator('/__docusaurus/debug/registry', '88c'),
    exact: true
  },
  {
    path: '/__docusaurus/debug/routes',
    component: ComponentCreator('/__docusaurus/debug/routes', '000'),
    exact: true
  },
  {
    path: '/blog',
    component: ComponentCreator('/blog', '23a'),
    exact: true
  },
  {
    path: '/blog/archive',
    component: ComponentCreator('/blog/archive', '182'),
    exact: true
  },
  {
    path: '/blog/authors',
    component: ComponentCreator('/blog/authors', '0b7'),
    exact: true
  },
  {
    path: '/blog/lab-automation-benefits',
    component: ComponentCreator('/blog/lab-automation-benefits', '531'),
    exact: true
  },
  {
    path: '/blog/opening-post',
    component: ComponentCreator('/blog/opening-post', 'fec'),
    exact: true
  },
  {
    path: '/blog/tags',
    component: ComponentCreator('/blog/tags', '287'),
    exact: true
  },
  {
    path: '/blog/tags/asafarim',
    component: ComponentCreator('/blog/tags/asafarim', '9a9'),
    exact: true
  },
  {
    path: '/blog/tags/automation',
    component: ComponentCreator('/blog/tags/automation', '346'),
    exact: true
  },
  {
    path: '/blog/tags/blog',
    component: ComponentCreator('/blog/tags/blog', '85d'),
    exact: true
  },
  {
    path: '/blog/tags/data-management',
    component: ComponentCreator('/blog/tags/data-management', '309'),
    exact: true
  },
  {
    path: '/blog/tags/programming',
    component: ComponentCreator('/blog/tags/programming', 'f25'),
    exact: true
  },
  {
    path: '/blog/tags/technology',
    component: ComponentCreator('/blog/tags/technology', 'd7b'),
    exact: true
  },
  {
    path: '/blog/tags/welcome',
    component: ComponentCreator('/blog/tags/welcome', 'edd'),
    exact: true
  },
  {
    path: '/blog/tags/xitechnix',
    component: ComponentCreator('/blog/tags/xitechnix', '7f0'),
    exact: true
  },
  {
    path: '/blog/welcome-to-asafarim-blog',
    component: ComponentCreator('/blog/welcome-to-asafarim-blog', '014'),
    exact: true
  },
  {
    path: '/markdown-page',
    component: ComponentCreator('/markdown-page', '3d7'),
    exact: true
  },
  {
    path: '/docs',
    component: ComponentCreator('/docs', 'e44'),
    routes: [
      {
        path: '/docs',
        component: ComponentCreator('/docs', '633'),
        routes: [
          {
            path: '/docs',
            component: ComponentCreator('/docs', '096'),
            routes: [
              {
                path: '/docs/content-type-mime',
                component: ComponentCreator('/docs/content-type-mime', '244'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/deserialization',
                component: ComponentCreator('/docs/deserialization', 'c6c'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/design-patterns/façade-pattern',
                component: ComponentCreator('/docs/design-patterns/façade-pattern', '379'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/design-patterns/overview',
                component: ComponentCreator('/docs/design-patterns/overview', 'd93'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/design-patterns/singleton-pattern',
                component: ComponentCreator('/docs/design-patterns/singleton-pattern', '50f'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/engineering',
                component: ComponentCreator('/docs/engineering', 'c9c'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/frameworks-libraries/nx-workspace/nx-Basics',
                component: ComponentCreator('/docs/frameworks-libraries/nx-workspace/nx-Basics', '8ac'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/frameworks-libraries/site-generators/docusaurus',
                component: ComponentCreator('/docs/frameworks-libraries/site-generators/docusaurus', 'eab'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/frameworks-libraries/syncfusion/syncfusion-Basics',
                component: ComponentCreator('/docs/frameworks-libraries/syncfusion/syncfusion-Basics', '6b6'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/git',
                component: ComponentCreator('/docs/git', '9f0'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/git/deserialization',
                component: ComponentCreator('/docs/git/deserialization', 'ffa'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/git/fetchpull',
                component: ComponentCreator('/docs/git/fetchpull', '216'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/git/overwriting-local-repo',
                component: ComponentCreator('/docs/git/overwriting-local-repo', '1a3'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/git/rollback-commit',
                component: ComponentCreator('/docs/git/rollback-commit', '459'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/intro',
                component: ComponentCreator('/docs/intro', '61d'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/json/json-overview/intro',
                component: ComponentCreator('/docs/json/json-overview/intro', 'e45'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/json/json-overview/sch',
                component: ComponentCreator('/docs/json/json-overview/sch', '115'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/json/json-overview/sch-dev',
                component: ComponentCreator('/docs/json/json-overview/sch-dev', '293'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/React/Axios/',
                component: ComponentCreator('/docs/React/Axios/', 'a1e'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/React/Basics/handle-data-from-api',
                component: ComponentCreator('/docs/React/Basics/handle-data-from-api', 'd03'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/React/Hooks/useFetch',
                component: ComponentCreator('/docs/React/Hooks/useFetch', '14e'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/React/Redux/Redux-Basic-Example',
                component: ComponentCreator('/docs/React/Redux/Redux-Basic-Example', '234'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/science-applications',
                component: ComponentCreator('/docs/science-applications', 'a01'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/serialization',
                component: ComponentCreator('/docs/serialization', 'd2b'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/technology',
                component: ComponentCreator('/docs/technology', '168'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/uml/userStory-userCase',
                component: ComponentCreator('/docs/uml/userStory-userCase', '344'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/uml/wireframing',
                component: ComponentCreator('/docs/uml/wireframing', 'fda'),
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
    path: '/',
    component: ComponentCreator('/', 'e5f'),
    exact: true
  },
  {
    path: '*',
    component: ComponentCreator('*'),
  },
];
