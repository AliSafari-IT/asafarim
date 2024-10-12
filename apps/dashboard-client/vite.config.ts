import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import vitePluginMd from 'vite-plugin-md';

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [react(), vitePluginMd(),],
  server: {
    proxy: {
      '/health-ui': {
        target: 'https://localhost:44337', // Your ASP.NET Core backend URL
        changeOrigin: true,
        secure: false, // Disable SSL verification in development
      },
    },
  },
  assetsInclude: ['**/*.md'],
})
