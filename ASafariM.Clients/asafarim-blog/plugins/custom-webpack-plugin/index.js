// plugins\custom-webpack-plugin\index.js
module.exports = function (context, options) {
    return {
      name: 'custom-webpack-plugin',
      configureWebpack(config, isServer, utils) {
        return {
          devServer: {
            proxy: {
              '/api': {
                target: process.env.BLOG_PROXY_TARGET_URL,
                changeOrigin: true,
              },
            },
          },
        };
      },
    };
  };