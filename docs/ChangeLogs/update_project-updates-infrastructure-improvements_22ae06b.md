# Project Updates and Infrastructure Improvements

Date: May 13, 2025
Author: Ali Safari

## Changes in the last 5 commits can be summarized as follows

### Package Management

- Migrated from npm/yarn to pnpm for improved performance and disk space efficiency
- Updated all package.json files to use pnpm workspace protocol

### Configuration

- Enhanced terminal server configuration with:
  - Improved error handling
  - Better session management
  - Optimized resource allocation

### Project Files

- Standardized file naming conventions
- Updated outdated configuration files
- Removed deprecated dependencies

## Commit 1: 22ae06b - chore(package): update package manager to pnpm and remove yarn files

**Date:** May 12, 2025  
**Author:** Ali Safari  
**Changes:**

- Migrated from Yarn to pnpm as package manager
- Removed all Yarn-related files (yarn.lock, etc.)
- Updated root package.json to specify pnpm as package manager
- Added pnpm workspace configuration

**Affected Files:**

- `package.json`
- `pnpm-lock.yaml` (new)
- `pnpm-workspace.yaml` (new)
- Removed yarn.lock

**Code Snippet (package.json changes):**

```json
{
  "packageManager": "pnpm@10.10.0",
  "pnpm": {
    "overrides": {
      "node-pty": "1.1.0-beta34"
    }
  }
}
```

---

## Commit 2: ccdd9d9 - chore(package): update dependencies in package.json files  

**Date:** May 12, 2025  
**Author:** Ali Safari  
**Changes:**

- Updated multiple dependencies across the project
- Added new devDependencies
- Modified pnpm overrides for specific packages

**Affected Files:**

- `package.json`
- `ASafariM.Clients/node-terminal/package.json`
- `pnpm-lock.yaml`

**Code Snippet (dependency updates):**

```json
{
  "dependencies": {
    "node-pty": "^1.1.0-beta34"
  },
  "devDependencies": {
    "dotenv": "^16.5.0",
    "@types/react-test-renderer": "^18"
  }
}
```

---

## Commit 3: ac5194a - chore(asafarim): Update project files and dependencies  

**Date:** May 12, 2025  
**Author:** Ali Safari  
**Changes:**

- Updated project configurations
- Modified terminal-related scripts in package.json
- Added new npm scripts for terminal management

**Affected Files:**

- `package.json`
- `ASafariM.Clients/node-terminal/package.json`
- `ASafariM.Clients/node-terminal/server.js`

**Code Snippet (new scripts):**

```json
{
  "scripts": {
    "nt:install": "pnpm --filter asafarim-terminal install",
    "nt:rebuild": "pnpm --filter asafarim-terminal rebuild node-pty --loglevel verbose",
    "nt:server": "cd /var/www/asafarim/ASafariM.Clients/node-terminal && node server.js"
  }
}
```

---

## Commit 4: 10e6b3e - chore(package): update package files and configurations  

**Date:** May 12, 2025  
**Author:** Ali Safari  
**Changes:**

- Added .npmrc configuration files
- Updated node-terminal package structure
- Modified server.js to use dotenv
- Enhanced terminal startup script

**Affected Files:**

- `.npmrc` (new)
- `ASafariM.Clients/node-terminal/.npmrc` (new)
- `ASafariM.Clients/node-terminal/package.json`
- `ASafariM.Clients/node-terminal/server.js`

**Code Snippet (server.js changes):**

```javascript
require('dotenv').config();
// ...
server.listen(PORT, () => {
  console.log(`Server running on port ${PORT} → http://localhost:${PORT}/`);
});
```

---

## Commit 5: 1438a6f - refactor(utils): remove mdFilesUtils.mock.ts file and update mdFilesUtils.ts file  

**Date:** May 13, 2025  
**Author:** Ali Safari  
**Changes:**

- Removed mock implementation of markdown file utilities
- Implemented real markdown file loading using Vite glob imports
- Added tree structure generation for documentation navigation
- Improved file path handling and sorting

**Affected Files:**

- `ASafariM.Clients/asafarim-ui/src/utils/mdFilesUtils.ts` (updated)
- `ASafariM.Clients/asafarim-ui/src/utils/mdFilesUtils.mock.ts` (deleted)

**Code Snippet (tree generation):**

```typescript
function getTree(
  mdFiles: Record<string, string>,
  branchInfo: IMenuItem
): IMenuItem {
  const tree: IMenuItem = {
    ...branchInfo,
    subMenu: [],
    content: '',
  };

  // ... (implementation details)
  
  return tree;
}
```

**File Patterns Affected:**

- `**/*.md` - Markdown file handling
- `src/utils/*.ts` - Utility file updates
- `package*.json` - Package configuration changes
- `.npmrc` - NPM configuration files

---

## Future Work

- Refactor the `exT` script in the root `package.json` to support cross-platform local development, particularly for Windows environments.
- Enhance the Markdown content rendering in `asafarim-ui` with features like dynamic table of contents generation or improved code block styling.
- Investigate and stabilize `node-pty` integration for the `asafarim-terminal` to ensure consistent behavior across different setups.
- Implement comprehensive unit and integration tests for the refactored `mdFilesUtils.ts` to cover various Markdown structures and edge cases.
- Standardize and document the local development setup for all `asafarim-*` client applications, including the `asafarim-terminal`.
