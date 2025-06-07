// vite-external-plugin.js
import esbuildConfig from './esbuild.config.js';

export default function externalPlugin() {
  return {
    name: 'vite-plugin-external',
    config(config) {
      // Add external packages to rollup options
      config.build = config.build || {};
      config.build.rollupOptions = config.build.rollupOptions || {};
      config.build.rollupOptions.external = [
        ...(config.build.rollupOptions.external || []),
        ...esbuildConfig.external
      ];
      
      return config;
    }
  };
}
