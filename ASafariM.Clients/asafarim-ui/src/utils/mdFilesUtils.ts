// E:\asm-fs\apps\frontends\asafarim-client\src\utils\mdFilesUtils.ts
// Import mock data instead of using glob imports
import {
  getAllMdFiles as getMockMdFiles,
  getMdFilesWithoutLogs as getMockMdFilesWithoutLogs,
  getChangelogByRelPath as getMockChangelogByRelPath,
  getMdDocByRelPath as getMockMdDocByRelPath,
  getCreationDate,
  getUpdateDate
} from './mdFilesUtils.mock';

// Export the mock functions
export const getAllMdFiles = getMockMdFiles;
export const getMdFilesWithoutLogs = getMockMdFilesWithoutLogs;
export const getChangelogByRelPath = getMockChangelogByRelPath;
export const getMdDocByRelPath = getMockMdDocByRelPath;

export default {
  getAllMdFiles,
  getMdFilesWithoutLogs,
  getChangelogByRelPath,
  getCreationDate,
  getUpdateDate,
  getMdDocByRelPath,
};
