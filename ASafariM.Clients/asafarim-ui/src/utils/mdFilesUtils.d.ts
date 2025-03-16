import { IMenuItem } from '../interfaces/IMenuItem';

export declare function getAllMdFiles(): {
  essentialInsights: IMenuItem;
  legalDocs: IMenuItem;
  changelogs: IMenuItem;
  techDocs: IMenuItem;
  projects: IMenuItem;
};

export declare function getMdFilesWithoutLogs(): {
  essentialInsights: IMenuItem;
  legalDocs: IMenuItem;
  techDocs: IMenuItem;
  projects: IMenuItem;
};

export declare function getChangelogByRelPath(to?: string): IMenuItem | undefined;

export declare function getMdDocByRelPath(to: string): IMenuItem | undefined;
