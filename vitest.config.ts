// vitest.config.ts
import { defineConfig } from 'vitest/config';  
import react from '@vitejs/plugin-react';
import { fileURLToPath } from 'url';

export default defineConfig({
  plugins: [react()],
  resolve: {
    alias: {
      '@': fileURLToPath(new URL('./src', import.meta.url)),
      '~ui': fileURLToPath(new URL('./ASafariM.Clients/asafarim-ui', import.meta.url)),
      '~blog': fileURLToPath(new URL('./ASafariM.Clients/asafarim-blog', import.meta.url)),
      '~bibliography': fileURLToPath(new URL('./ASafariM.Clients/asafarim-bibliography', import.meta.url)),
      '~ui/assets': fileURLToPath(new URL('./ASafariM.Clients/asafarim-ui/src/assets', import.meta.url)),
      '~blog/assets': fileURLToPath(new URL('./ASafariM.Clients/asafarim-blog/src/assets', import.meta.url)),
      '~bibliography/assets': fileURLToPath(new URL('./ASafariM.Clients/asafarim-bibliography/src/assets', import.meta.url)),
      '~blog/static': fileURLToPath(new URL('./ASafariM.Clients/asafarim-blog/static', import.meta.url)),
      '~bibliography/static': fileURLToPath(new URL('./ASafariM.Clients/asafarim-bibliography/static', import.meta.url)),
      '~ui/mdfiles': fileURLToPath(new URL('./ASafariM.Clients/asafarim-ui/docs', import.meta.url))
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
