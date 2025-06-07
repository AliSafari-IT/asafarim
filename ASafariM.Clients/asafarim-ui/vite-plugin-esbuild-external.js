// vite-plugin-esbuild-external.js
import externalPlugin from './esbuild-plugin-external.js';

/**
 * Custom Vite plugin to integrate our ESBuild external plugin
 */
export default function vitePluginEsbuildExternal() {
  return {
    name: 'vite-plugin-esbuild-external',
    config(config) {
      // Configure ESBuild options
      config.optimizeDeps = config.optimizeDeps || {};
      config.optimizeDeps.esbuildOptions = config.optimizeDeps.esbuildOptions || {};
      
      // Add our custom ESBuild plugin
      config.optimizeDeps.esbuildOptions.plugins = [
        ...(config.optimizeDeps.esbuildOptions.plugins || []),
        externalPlugin()
      ];
      
      return config;
    }
  };
}
