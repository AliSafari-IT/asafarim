// Import the original mapper
import MDXComponents from '@theme-original/MDXComponents';
import Box from '@site/src/components/Box';
import Figure from '@site/src/components/Figure';
import AuthorLink from '@site/src/components/AuthorLink';

export default {
  // Re-use the default mapping
  ...MDXComponents,
  // Map the "Box" tag to our Box component
  Box: Box,
  // Map the "Figure" tag to our Figure component
  Figure: Figure,
  // Map the "AuthorLink" tag to our AuthorLink component
  AuthorLink: AuthorLink,
};