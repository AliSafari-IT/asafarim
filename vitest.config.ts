// vitest.config.ts
import { defineConfig } from 'vitest/config';  
import react from '@vitejs/plugin-react';
import path from 'path';

export default defineConfig({
  plugins: [react()],
  resolve: {
    alias: {
      '@': path.resolve(__dirname, './'),
      '~ui': path.resolve(__dirname, './ASafariM.Clients/asafarim-ui'),
      '~blog': path.resolve(__dirname, './ASafariM.Clients/asafarim-blog'),
      '~bibliography': path.resolve(__dirname, './ASafariM.Clients/asafarim-bibliography'),
      '~ui/assets': path.resolve(__dirname, './ASafariM.Clients/asafarim-ui/src/assets'),
      '~blog/assets': path.resolve(__dirname, './ASafariM.Clients/asafarim-blog/src/assets'),
      '~bibliography/assets': path.resolve(__dirname, './ASafariM.Clients/asafarim-bibliography/src/assets'),
      '~blog/static': path.resolve(__dirname, './ASafariM.Clients/asafarim-blog/static'),
      '~bibliography/static': path.resolve(__dirname, './ASafariM.Clients/asafarim-bibliography/static'),
      '~ui/mdfiles': path.resolve(__dirname, './ASafariM.Clients/asafarim-ui/docs')
    },
  },
  test: {
    globals: true,
    environment: 'jsdom',
    setupFiles: ['./vitest.setup.ts'],
    reporters: ['default'],
    include: [
      'ASafariM.Clients/asafarim-ui/src/**/*.{test,spec,unit.test}.{js,mjs,cjs,ts,mts,cts,jsx,tsx}',
      'ASafariM.Clients/asafarim-blog/src/**/*.{test,spec,unit.test}.{js,mjs,cjs,ts,mts,cts,jsx,tsx}',
      'ASafariM.Clients/asafarim-bibliography/src/**/*.{test,spec,unit.test}.{js,mjs,cjs,ts,mts,cts,jsx,tsx}'
    ],
    exclude: [
      'node_modules/**',
      '**/node_modules/**',
      'dist/**',
      '.idea/**',
      '.git/**',
      '.cache/**'
    ],
    // Disable coverage by default, enable it only when explicitly requested
    coverage: {
      enabled: false,
      provider: 'v8',
      reporter: ['text', 'json'],
      reportsDirectory: './test-results/coverage'
    },
    pool: 'forks',
    poolOptions: {
      forks: {
        singleFork: true
      }
    },
    testTimeout: 60000,
    hookTimeout: 60000,
    silent: false,
    maxConcurrency: 1
  }
});