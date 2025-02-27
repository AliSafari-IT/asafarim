export const plugins = {
  "postcss-import": {},
  "tailwindcss": {},
  "autoprefixer": {},
  "postcss-nesting": {}, // Enables CSS nesting
  "postcss-preset-env": {
    stage: 1,
    features: {
      "nesting-rules": true
    }
  }
};
