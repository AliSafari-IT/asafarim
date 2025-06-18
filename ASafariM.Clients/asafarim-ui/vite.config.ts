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
    // Disable sourcemap generation to reduce memory usage
    sourcemap: false,
    // Use esbuild minifier which is faster and uses less memory
    minify: 'esbuild',
    chunkSizeWarningLimit: 2000,
    // Optimize build for memory usage
    target: 'es2018',
    rollupOptions: {
      output: {
        // Increase chunking to reduce individual file sizes
        manualChunks: (id) => {
          // Core libraries
          if (id.includes('node_modules/react') || id.includes('node_modules/react-dom')) {
            return 'vendor-react';
          }
          if (id.includes('node_modules/@fluentui')) {
            return 'vendor-fluentui';
          }
          if (id.includes('node_modules/d3')) {
            return 'vendor-d3';
          }
          // Group other node_modules
          if (id.includes('node_modules')) {
            return 'vendor-others';
          }
        },
      },
    },
    commonjsOptions: {
      // Improve compatibility with D3 modules
      transformMixedEsModules: true,
    },
  },
});
