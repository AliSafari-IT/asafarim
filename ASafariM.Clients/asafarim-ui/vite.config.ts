import { defineConfig } from 'vite';
import path from 'path';
import react from '@vitejs/plugin-react';
import vitePluginMd from 'vite-plugin-md';
import dotenv from 'dotenv';

// Load .env file
dotenv.config();

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
    },
  },
  server: {
    port: parseInt(process.env.VITE_UI_PORT || '3000', 10),
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
    chunkSizeWarningLimit: 1000, // Increased from default 500kb to 1000kb
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
            'react-dom'
          ],
          'fluentui': [
            '@fluentui/react-components',
            '@fluentui/react',
            '@fluentui/react-icons'
          ],
          'charts': [
            'd3-selection',
            'd3-scale',
            'd3-shape',
            'd3-axis',
            'd3-time-format'
          ]
        },
      },
    },
    commonjsOptions: {
      // Improve compatibility with D3 modules
      transformMixedEsModules: true,
    },
  },
});
