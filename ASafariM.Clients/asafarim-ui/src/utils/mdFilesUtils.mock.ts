import { IMenuItem } from '@/interfaces/IMenuItem';
import { ChangeLogSvgIcon } from '../assets/SvgIcons/ChangeLogSvgIcon';

// Create empty mock trees for each document type
const createEmptyTree = (branchInfo: Partial<IMenuItem>): IMenuItem => ({
  folderName: branchInfo.folderName || '',
  id: branchInfo.id || '',
  title: branchInfo.title || '',
  label: branchInfo.label || '',
  name: branchInfo.name || '',
  to: branchInfo.to || '',
  icon: branchInfo.icon || ChangeLogSvgIcon,
  subMenu: [],
  content: '',
  type: 'folder',
});

// Create mock trees for each document type
const techDocsTree = createEmptyTree({
  folderName: 'TechDocs',
  id: 'tech-docs',
  title: 'Tech Docs',
  label: 'Tech Docs',
  name: 'tech-docs',
  to: '/tech-docs',
});

const legalDocsTree = createEmptyTree({
  folderName: 'LegalDocs',
  id: 'legal-docs',
  title: 'Legal Docs',
  label: 'Legal Docs',
  name: 'legal-docs',
  to: '/legal-docs',
});

const essentialInsightsTree = createEmptyTree({
  folderName: 'EssentialInsights',
  id: 'essential-insights',
  title: 'Essential Insights',
  label: 'Essential Insights',
  name: 'essential-insights',
  to: '/essential-insights',
});

const changeLogsTree = createEmptyTree({
  folderName: 'ChangeLogs',
  id: 'changelogs',
  title: 'Change Logs',
  label: 'Change Logs',
  name: 'changelogs',
  to: '/changelogs',
});

const projectsTree = createEmptyTree({
  folderName: 'Projects',
  id: 'projects',
  title: 'Projects',
  label: 'Projects',
  name: 'projects',
  to: '/projects',
});

// Export mock functions
export const getAllMdFiles = (): {
  essentialInsights: IMenuItem;
  legalDocs: IMenuItem;
  changelogs: IMenuItem;
  techDocs: IMenuItem;
  projects: IMenuItem;
} => {
  return {
    legalDocs: legalDocsTree,
    changelogs: changeLogsTree,
    techDocs: techDocsTree,
    essentialInsights: essentialInsightsTree,
    projects: projectsTree
  };
};

export const getMdFilesWithoutLogs = (): {
  essentialInsights: IMenuItem;
  legalDocs: IMenuItem;
  techDocs: IMenuItem;
  projects: IMenuItem;
} => {
  return {
    legalDocs: legalDocsTree,
    techDocs: techDocsTree,
    essentialInsights: essentialInsightsTree,
    projects: projectsTree
  };
};

export const getChangelogByRelPath = (to?: string): IMenuItem | undefined => {
  return undefined;
};

export const getMdDocByRelPath = (to: string): IMenuItem | undefined => {
  return undefined;
};

export const getCreationDate = (content: string): Date => {
  return new Date();
};

export const getUpdateDate = (content: string): Date => {
  return new Date();
};

export default {
  getAllMdFiles,
  getMdFilesWithoutLogs,
  getChangelogByRelPath,
  getCreationDate,
  getUpdateDate,
  getMdDocByRelPath,
};
