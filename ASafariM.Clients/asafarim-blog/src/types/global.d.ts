// Type declarations for various module formats

declare module '@site/blog/authors.yml' {
  interface Author {
    name: string;
    title: string;
    urls: string[];
    image_url: string;
    email: string;
    company: string;
    location: string;
    bio: string;
    contact: string;
  }

  const authors: Record<string, Author>;
  export default authors;
}

// Add more module declarations as needed
