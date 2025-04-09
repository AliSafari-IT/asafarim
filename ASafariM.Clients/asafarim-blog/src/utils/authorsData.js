// This file provides a way to access author data from authors.yml in components
// In a real implementation, this would be handled by Docusaurus's data loading

const authorsData = {
  alisafari: {
    name: 'Ali Safari',
    title: 'Full-Stack Software Engineer | Clean Architecture | AI & Data Enthusiast',
    urls: [
      'https://github.com/AliSafari-IT',
      'https://linkedin.com/in/ali-safari-m',
      'https://asafarim.com'
    ],
    image_url: 'https://avatars.githubusercontent.com/u/58768873?s=300&v=4',
    email: 'contact@asafarim.com',
    company: 'ASafariM',
    location: 'Hasselt, Belgium',
    bio: "I'm a software engineer with a passion for clean architecture and AI. I'm always learning and sharing my knowledge with the community.",
    contact: 'https://www.asafarim.com/contact'
  },
  // Add more authors as needed
};

export function getAuthor(authorKey) {
  return authorsData[authorKey] || null;
}

export function getAllAuthors() {
  return Object.entries(authorsData).map(([key, data]) => ({
    key,
    ...data,
  }));
}

export default authorsData;
