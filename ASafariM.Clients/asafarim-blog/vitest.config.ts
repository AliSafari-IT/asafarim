// vitest.config.ts
import { defineConfig } from 'vitest/config';
import react from '@vitejs/plugin-react';
import path from 'path';

export default defineConfig({
  plugins: [react()],
  resolve: {
    alias: {
      '@site': path.resolve(__dirname, './'),
      '@docusaurus': path.resolve(__dirname, './node_modules/@docusaurus'),
      '@theme': path.resolve(__dirname, './node_modules/@docusaurus/theme-classic'),
    },
  },
  test: {
    globals: true,
    environment: 'jsdom',
    include: ['src/**/*.{spec,test}.{ts,tsx}'],
    exclude: ['node_modules/**', 'dist/**'],
  }
});
