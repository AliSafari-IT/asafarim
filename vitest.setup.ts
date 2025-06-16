// vitest.setup.ts
import '@testing-library/jest-dom';

// Suppress React 18 warnings during tests
const originalConsoleError = console.error;
console.error = (...args) => {
  if (
    args[0]?.includes?.('Warning: ReactDOM.render is no longer supported') ||
    args[0]?.includes?.('Warning: unmountComponentAtNode is deprecated') ||
    args[0]?.includes?.('Warning: `ReactDOMTestUtils.act` is deprecated')
  ) {
    return; // Suppress React 18 migration warnings
  }
  originalConsoleError(...args);
};

// Set React environment for act()
// @ts-ignore
global.IS_REACT_ACT_ENVIRONMENT = true;
