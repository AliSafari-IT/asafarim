// Import the original mapper
import MDXComponents from '@theme-original/MDXComponents';
import Figure from '@site/src/components/Figure';

export default {
  // Re-use the default mapping
  ...MDXComponents,
  // Map the "Figure" tag to our Figure component
  Figure: Figure
};
