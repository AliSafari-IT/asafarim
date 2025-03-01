import { defineConfig } from 'vite';
import vitePluginMd from 'vite-plugin-md';
import { visualizer } from 'rollup-plugin-visualizer';
import path from 'path';
import md from 'vite-plugin-md';
// https://vite.dev/config/
export default defineConfig({
  optimizeDeps: {
    include: ['d3', 'react', 'react-dom'],
    exclude: ['@fluentui/tokens', '@fluentui/react-icons'],
  },
  plugins: [
    visualizer({ open: true }) as PluginOption,
    react(),
    vitePluginMd({ markdownItOptions: { html: true } }),
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
    'import.meta.env.VITE_API_URL': JSON.stringify(process.env.VITE_API_URL || 'http://localhost:5000'),
  },
  server: {
    port: 3000,
    open: true,
    proxy: {
      '/api': {
        target: process.env.VITE_API_URL || 'http://localhost:5000',
        changeOrigin: true,
        secure: false,
        rewrite: (path) => path.replace(/^\/api/, '/api'),
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
    rollupOptions: {
      external: ['@emailjs/browser', '@fluentui/tokens', '@fluentui/react-icons'],
      output: {
        manualChunks: {
          'd3': ['d3'],
          'vendor': ['react', 'react-dom', '@fluentui/react-components', '@fluentui/react']
        },
      },
    },
    commonjsOptions: {
      include: [/node_modules/],
      transformMixedEsModules: true
    },
    chunkSizeWarningLimit: 2000,
  },
});
