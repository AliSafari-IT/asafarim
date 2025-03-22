import React from 'react';
import ComponentCreator from '@docusaurus/ComponentCreator';

export default [
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
    path: '/blog/tags/tags/asafarim-tag',
    component: ComponentCreator('/blog/tags/tags/asafarim-tag', '4ef'),
    exact: true
  },
  {
    path: '/blog/tags/tags/automation-tag',
    component: ComponentCreator('/blog/tags/tags/automation-tag', '84d'),
    exact: true
  },
  {
    path: '/blog/tags/tags/blog-tag',
    component: ComponentCreator('/blog/tags/tags/blog-tag', '691'),
    exact: true
  },
  {
    path: '/blog/tags/tags/data-management-capitalized-tag',
    component: ComponentCreator('/blog/tags/tags/data-management-capitalized-tag', 'c60'),
    exact: true
  },
  {
    path: '/blog/tags/tags/programming-tag',
    component: ComponentCreator('/blog/tags/tags/programming-tag', 'c81'),
    exact: true
  },
  {
    path: '/blog/tags/tags/technology-tag',
    component: ComponentCreator('/blog/tags/tags/technology-tag', '65f'),
    exact: true
  },
  {
    path: '/blog/tags/tags/welcome-tag',
    component: ComponentCreator('/blog/tags/tags/welcome-tag', '3cf'),
    exact: true
  },
  {
    path: '/blog/tags/tags/xitechnix-tag',
    component: ComponentCreator('/blog/tags/tags/xitechnix-tag', 'b5f'),
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
    component: ComponentCreator('/docs', 'a3c'),
    routes: [
      {
        path: '/docs',
        component: ComponentCreator('/docs', '95a'),
        routes: [
          {
            path: '/docs',
            component: ComponentCreator('/docs', '94f'),
            routes: [
              {
                path: '/docs/azuredevops/azure-devops-services',
                component: ComponentCreator('/docs/azuredevops/azure-devops-services', 'c68'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/azuredevops/azure-pipelines',
                component: ComponentCreator('/docs/azuredevops/azure-pipelines', '710'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/azuredevops/intro',
                component: ComponentCreator('/docs/azuredevops/intro', '5bf'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/azuredevops/test-pipeline',
                component: ComponentCreator('/docs/azuredevops/test-pipeline', '113'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/azuredevops/test-plans/create-testcases',
                component: ComponentCreator('/docs/azuredevops/test-plans/create-testcases', 'fc2'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/azuredevops/test-plans/test-env',
                component: ComponentCreator('/docs/azuredevops/test-plans/test-env', '623'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/azuredevops/test-plans/test-plans',
                component: ComponentCreator('/docs/azuredevops/test-plans/test-plans', '710'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/azuredevops/yamlscripts/agent',
                component: ComponentCreator('/docs/azuredevops/yamlscripts/agent', 'f57'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/azuredevops/yamlscripts/print-dir-contents',
                component: ComponentCreator('/docs/azuredevops/yamlscripts/print-dir-contents', 'b50'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/azuredevops/yamlscripts/reuse-template',
                component: ComponentCreator('/docs/azuredevops/yamlscripts/reuse-template', '75a'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/azuredevops/yamlscripts/triggers',
                component: ComponentCreator('/docs/azuredevops/yamlscripts/triggers', 'b52'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
              {
                path: '/docs/azuredevops/yamlscripts/Yaml-templates',
                component: ComponentCreator('/docs/azuredevops/yamlscripts/Yaml-templates', '08a'),
                exact: true,
                sidebar: "tutorialSidebar"
              },
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
