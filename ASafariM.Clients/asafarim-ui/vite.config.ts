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
  esbuild: {
    // Ensure proper module resolution
    keepNames: true,
    target: 'es2020',
    // Fix potential hoisting issues
    tsconfigRaw: {
      compilerOptions: {
        useDefineForClassFields: false,
      },
    },
  },optimizeDeps: {
    include: [
      'react', 
      'react-dom', 
      'react-router-dom',
      'axios',
      'framer-motion',
      'd3', 
      'd3-selection', 
      'd3-scale', 
      'd3-shape', 
      'd3-axis', 
      'd3-time-format'
    ],
    exclude: ['@fluentui/tokens'],
    esbuildOptions: {
      // Needed for D3 to work properly in production
      keepNames: true,
      target: 'es2020',
    },
  },
  plugins: [
    react(),
    vitePluginMd({
      markdownItOptions: {
        html: true,
      },
    }),
  ],  resolve: {
    alias: {
      '@': path.resolve(__dirname, './src'),
      '@assets': path.resolve(__dirname, 'src/assets'),
      '@mdfiles': path.resolve(__dirname, '../../docs'),
    },
    // Ensure proper module resolution
    dedupe: ['react', 'react-dom'],
    // Add extensions to prevent resolution issues
    extensions: ['.mjs', '.js', '.mts', '.ts', '.jsx', '.tsx', '.json'],
  },  define: {
    'process.env': {
      NODE_ENV: JSON.stringify(process.env.NODE_ENV),
    },
    // Help prevent module initialization errors
    global: 'globalThis',
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
  assetsInclude: ['**/*.md'],  build: {
    outDir: 'dist',
    emptyOutDir: true,
    // Enable sourcemap for debugging in production
    sourcemap: true,
    // Use esbuild minifier which is faster and uses less memory
    minify: 'esbuild',
    chunkSizeWarningLimit: 2000,
    // Optimize build for memory usage
    target: 'es2020',    rollupOptions: {
      output: {
        // Simplified chunking strategy to avoid circular dependencies
        manualChunks: {
          // Keep React ecosystem together
          'react-vendor': ['react', 'react-dom'],
          // Separate router to avoid initialization conflicts
          'react-router': ['react-router-dom'],
          // Keep FluentUI together but separate from React
          'fluentui-vendor': ['@fluentui/react', '@fluentui/react-components', '@fluentui/react-icons'],
          // D3 as separate chunk
          'd3-vendor': ['d3'],
          // Other utilities
          'utils-vendor': ['axios', 'lodash', 'framer-motion'],
        },
        // Ensure proper chunk loading order and avoid conflicts
        entryFileNames: '[name]-[hash].js',
        chunkFileNames: '[name]-[hash].js',
        assetFileNames: '[name]-[hash].[ext]',
      },
      // Don't externalize anything to keep dependencies bundled
      external: [],
    },
    commonjsOptions: {
      // Improve compatibility with mixed ES modules
      transformMixedEsModules: true,
      // Ensure proper dependency resolution
      include: /node_modules/,
      extensions: ['.js', '.cjs'],
    },
  },
});
