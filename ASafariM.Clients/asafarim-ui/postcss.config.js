export const plugins = {
  "postcss-import": {},
  "tailwindcss": {},
  "autoprefixer": {},
  "postcss-nesting": {}, // Enables CSS nesting
  "postcss-preset-env": {
    stage: 3,
    features: {
      "nesting-rules": true,
      "custom-properties": true,
      "media-query-ranges": true
    }
  }
};
