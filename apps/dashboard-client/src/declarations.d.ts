declare module 'rehype-sanitize' {
  const rehypeSanitize: any;
  export default rehypeSanitize;
}


declare module '*.md' {
    const content: string;
    export default content;
  }

  declare module '*.md?raw' {
    const content: string;
    export default content;
  }

  declare module '*.mdx' {
    const content: string;
    export default content;
  } 
  
  declare module '*.svg' {
    const content: string;
    export default content;
  }
  