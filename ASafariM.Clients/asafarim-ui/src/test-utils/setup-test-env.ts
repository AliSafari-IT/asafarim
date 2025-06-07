import * as matchers from '@testing-library/jest-dom/matchers';
import { expect } from 'vitest';

// Extend Vitest's expect with Jest DOM matchers
expect.extend(matchers);

// Export the extended expect for use in tests
export { expect };
