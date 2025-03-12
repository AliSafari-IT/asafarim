import { defineConfig } from 'vite';
import { configDefaults } from 'vitest/config';
import path from 'path';
import react from '@vitejs/plugin-react';
import vitePluginMd from 'vite-plugin-md';
import md from 'vite-plugin-md';
// https://vite.dev/config/
export default defineConfig({
  mode: process.env.NODE_ENV,
  optimizeDeps: {
    include: ['d3', 'd3-selection', 'd3-scale', 'd3-shape', 'd3-axis', 'd3-time-format', 'react', 'react-dom'],
    exclude: ['@fluentui/tokens'],
    esbuildOptions: {
      // Needed for D3 to work properly in production
      keepNames: true,
    },
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
    postcss: './postcss.config.js',
  },
  assetsInclude: ['**/*.md'],
  build: {
    outDir: 'dist',
    emptyOutDir: true,
    sourcemap: true,
    minify: 'terser',
    terserOptions: {
      // Preserve function and class names for D3
      keep_fnames: true,
      keep_classnames: true,
    },
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
      // Improve compatibility with D3 modules
      transformMixedEsModules: true,
    },
  },
  test: {
    globals: true,
    environment: 'jsdom',
    exclude: [...configDefaults.exclude, 'e2e/*'],
    root: path.resolve(__dirname, './'),
  },
});
