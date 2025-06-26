import { defineConfig } from 'vite'
import path from 'path'

// https://vitejs.dev/config/
export default defineConfig({
     resolve: {
    alias: {
      '@asafarim/markdown-utils': path.resolve(__dirname, '../src')
    }
  },
  server: {
    port: 3007
  },
  build: {
    outDir: 'dist'
  }
})
