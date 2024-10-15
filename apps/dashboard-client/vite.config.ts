import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import vitePluginMd from 'vite-plugin-md';

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [react(), vitePluginMd(),],
  css: {
    postcss: './postcss.config.cjs',
  },
  assetsInclude: ['**/*.md'],
})
