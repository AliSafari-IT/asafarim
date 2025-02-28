export const plugins = [
  require('postcss-import'),
  require('tailwindcss'),
  require('autoprefixer'),
  require('postcss-nested'), // Ensures proper nesting support
  require('postcss-preset-env')({
    stage: 1,
    features: {
      'nesting-rules': true, // Enables modern CSS nesting
    },
  }),
];
