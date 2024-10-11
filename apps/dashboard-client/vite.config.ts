import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import vitePluginMd from 'vite-plugin-md';

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [react(), vitePluginMd(),],
  server: {
    proxy: {
      '/api': 'http://localhost:44337', // Proxy API requests to .NET Core server
    },
  },
  assetsInclude: ['**/*.md'],
})
