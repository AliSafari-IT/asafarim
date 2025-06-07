# Chore: Update API Tests and Configurations for Frontend Services

Date: 2025-03-28

## Description of Changes

Improved the testing infrastructure for frontend API services with enhanced mocking strategies, better error handling, and more comprehensive test coverage. This update focuses on ensuring that all API service tests are reliable, maintainable, and provide accurate test results.

### Key Changes:

1. **Enhanced Axios Mocking in API Tests**

Implemented a more robust mocking strategy for Axios in Vitest tests to ensure consistent behavior across all API service tests:

```typescript
// Improved Axios mocking implementation
const mockAxiosInstance = vi.hoisted(() => ({
  post: vi.fn(),
  get: vi.fn(),
  delete: vi.fn(),
  put: vi.fn(),
  defaults: { headers: { common: {} } }
}));

vi.mock('axios', () => ({
  default: {
    create: vi.fn(() => mockAxiosInstance),
    post: vi.fn(),
    get: vi.fn(),
    delete: vi.fn(),
    put: vi.fn()
  }
}));
```

2. **Fixed AuthService Error Handling**

Improved the error handling in the `updatePassword` function to properly log errors and return consistent error messages:

```typescript
// Before: Nested try-catch with incomplete error handling
export const updatePassword = async (model: { Id: string; currentPassword: string; newPassword: string }) => {
  try {
    const url = `${API_URL}/change-password`;
    logger.log("updatePassword → model for url is:" + url, model);

    try{
      const response = await axios.post(url, model);
      return response.data;
    }
    catch(error){
      logger.log("updatePassword → error is:", error);
    }
  } catch (error) {
    // Use the centralized error handler
    const err = error as AxiosError;
    const message = handleError(err); 
    logger.log('Error message when updating password:', message);
    return { message };
  }
};

// After: Simplified with proper error logging
export const updatePassword = async (model: { Id: string; currentPassword: string; newPassword: string }) => {
  try {
    const url = `${API_URL}/change-password`;
    logger.log("updatePassword → model for url is:" + url, model);
    
    const response = await axios.post(url, model);
    return response.data;
  } catch (error) {
    // Use the centralized error handler
    const err = error as AxiosError;
    const message = handleError(err); 
    logger.error('Error message when updating password:', message);
    return { message };
  }
};
```

3. **Removed Redundant Files**

Deleted the unused `entityServices.fixed.ts` file which was an older version of the main implementation, reducing confusion and maintenance overhead.

4. **Added Vitest Workspace Configuration**

Created a new `vitest.workspace.ts` file to enable running tests across multiple projects in the monorepo:

```typescript
import { defineWorkspace } from 'vitest/config'

export default defineWorkspace([
  "./vitest.config.ts",
  "./ASafariM.Clients/asafarim-ui/vite.config.ts",
  "./ASafariM.Clients/asafarim-blog/vitest.config.ts",
  "./ASafariM.Clients/asafarim-bibliography/vitest.config.ts"
])
```

5. **Updated Test Scripts**

Modified the test scripts in package.json to use local Vitest binaries for more consistent test execution:

```json
"test:frontend:blog": "mkdir -p tests/frontend && TIMESTAMP=$(date +%Y%m%d-%H%M) && cd ASafariM.Clients/asafarim-blog && ../../node_modules/.bin/vitest run --config vitest.config.ts --reporter=json --outputFile=../../tests/frontend/blog_detailed_results_$TIMESTAMP.json"
```

## Impact

These changes improve the development and testing workflow by:

1. **Better Test Reliability** - Consistent mocking strategy reduces flaky tests and false negatives
2. **Improved Error Handling** - Enhanced error logging makes it easier to diagnose issues in production
3. **Simplified Codebase** - Removal of redundant files reduces maintenance overhead
4. **Unified Testing Infrastructure** - Workspace configuration enables running tests across all projects
5. **Consistent Test Execution** - Using local binaries ensures all tests run with the same Vitest version

## Files Affected

- `ASafariM.Clients/asafarim-ui/src/api/__tests__/authService.spec.ts` - Updated mocking and test cases
- `ASafariM.Clients/asafarim-ui/src/api/__tests__/authapi.spec.ts` - Improved Axios mocking
- `ASafariM.Clients/asafarim-ui/src/api/__tests__/authorizationService.spec.ts` - Enhanced test coverage
- `ASafariM.Clients/asafarim-ui/src/api/__tests__/dashboardServices.spec.ts` - Added comprehensive test cases
- `ASafariM.Clients/asafarim-ui/src/api/authService.ts` - Fixed error handling in updatePassword
- `ASafariM.Clients/asafarim-ui/src/api/authapi.ts` - Improved token handling
- `ASafariM.Clients/asafarim-ui/src/api/entityServices.ts` - Enhanced error logging
- `vitest.workspace.ts` - New file for workspace configuration
- `ASafariM.Clients/asafarim-ui/package.json` - Updated test scripts
- `ASafariM.Clients/asafarim-blog/package.json` - Updated to use local Vitest binary

## Testing

The changes were tested through the following scenarios:

1. **Successful API Calls** - Verified that all API services correctly handle successful responses
2. **Error Handling** - Confirmed proper error handling and logging for failed API calls
3. **Token Management** - Tested authentication token retrieval and usage
4. **Cross-Project Testing** - Validated that tests can be run across all projects using the workspace configuration

These improvements ensure that the API service tests are more reliable and provide better feedback during development and CI/CD pipelines.

[Snippet identifier=vitest.workspace.ts#L1-7]
import { defineWorkspace } from 'vitest/config'

export default defineWorkspace([
  "./vitest.config.ts",
  "./ASafariM.Clients/asafarim-ui/vite.config.ts",
  "./ASafariM.Clients/asafarim-blog/vitest.config.ts",
  "./ASafariM.Clients/asafarim-bibliography/vitest.config.ts"
])
[/Snippet]

[Snippet identifier=authService.ts#L44-63]
export const updatePassword = async (model: { Id: string; currentPassword: string; newPassword: string }) => {
  try {
    const url = `${API_URL}/change-password`;
    logger.log("updatePassword → model for url is:" + url, model);
    
    const response = await axios.post(url, model);
    return response.data;
  } catch (error) {
    // Use the centralized error handler
    const err = error as AxiosError;
    const message = handleError(err); 
    logger.error('Error message when updating password:', message);
    return { message };
  }
};
[/Snippet]

[Snippet identifier=package.json#L57-65]
  "test:frontend": "mkdir -p tests/frontend && TIMESTAMP=$(date +%Y%m%d-%H%M) && node --max-old-space-size=4096 node_modules/vitest/vitest.mjs run --reporter=verbose --reporter=json --outputFile=tests/frontend/all_test_results_$TIMESTAMP.json --no-coverage",
  "test:script": "node ./scripts/test-scripts/verify-tests.js",
  "test:verify": "node ./scripts/test-scripts/verify-tests.js",
  "deploy:if-tests-pass": "yarn test:backend && yarn test:verify && node ./scripts/publish-with-frontend-tests.js",
  "test:frontend:ui": "mkdir -p tests/frontend && TIMESTAMP=$(date +%Y%m%d-%H%M) && yarn workspace asafarim-ui test --reporter=json --outputFile=tests/frontend/ui_test_results_$TIMESTAMP.json",
  "test:frontend:blog": "mkdir -p tests/frontend && TIMESTAMP=$(date +%Y%m%d-%H%M) && cd ASafariM.Clients/asafarim-blog && ../../node_modules/.bin/vitest run --config vitest.config.ts --reporter=json --outputFile=../../tests/frontend/blog_detailed_results_$TIMESTAMP.json",
  "test:frontend:bibliography": "mkdir -p tests/frontend && TIMESTAMP=$(date +%Y%m%d-%H%M) && cd ASafariM.Clients/asafarim-bibliography && ../../node_modules/.bin/vitest run --config vitest.config.ts --reporter=json --outputFile=../../tests/frontend/bibliography_detailed_results_$TIMESTAMP.json",
  "test:all": "mkdir -p tests/backend tests/frontend && yarn test:backend && yarn test:frontend",
[/Snippet]
