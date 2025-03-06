import { defineConfig } from 'vite';
import { configDefaults } from 'vitest/config';
import path from 'path';
import react from '@vitejs/plugin-react';
import vitePluginMd from 'vite-plugin-md';
import md from 'vite-plugin-md';
import react from '@vitejs/plugin-react';
import { PluginOption } from 'vite';

export default defineConfig({
  mode: process.env.NODE_ENV,
  optimizeDeps: {
    include: ['d3', 'react', 'react-dom'],
    exclude: ['@fluentui/tokens'],
  },
  plugins: [
    react(),
    vitePluginMd({
      markdownItOptions: {
        html: true,
      },      
    }),
    md()
  ],
  resolve: {
    alias: {
      '@': path.resolve(__dirname, './src'),
      '@assets': path.resolve(__dirname, 'src/assets'),
      '@mdfiles': path.resolve(__dirname, '../../docs'),
    },
  },
  define: {
    'process.env': {
      NODE_ENV: JSON.stringify(process.env.NODE_ENV),
      VITE_API_URL: JSON.stringify('http://localhost:5000'),
    },
  },
  server: {
    port: 3000,
    open: true,
    proxy: {
      '/api': {
        target: 'http://localhost:5000',
        changeOrigin: true,
        rewrite: (path) => path.replace(/^\/api/, '/api')
      }
    }
  },
  css: {
    preprocessorOptions: {
      scss: { quietDeps: true }
    },
    postcss: './postcss.config.js',
  },
  assetsInclude: ['**/*.md'],
  build: {
    outDir: 'dist',
    emptyOutDir: true,
    sourcemap: true,
    rollupOptions: {
      output: {
        manualChunks: {
          'd3': ['d3'],
          'vendor': [
            'react',
            'react-dom',
            '@fluentui/react-components',
            '@fluentui/react'
          ]
        },
      },
    },
    commonjsOptions: {
      include: [/node_modules/],
      transformMixedEsModules: true
    },
    chunkSizeWarningLimit: 2000,
  },
  test: {
    environment: 'jsdom',
    globals: true,
    setupFiles: './tests/setupTests.js',
    exclude: [...configDefaults.exclude],
    coverage: {
      reporter: ['text', 'json', 'html'],
    },
  }
});
