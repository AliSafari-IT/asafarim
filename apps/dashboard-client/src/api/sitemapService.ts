// src/api/sitemapService.ts

// Set the API URL for your sitemap service
const API_URL =  (import.meta as any).env.VITE_API_URL;
console.log("sitemapService -> API_URL: " + API_URL);

const getSitemap = async (userRole: string) => {
  console.log(`Fetching sitemap for userRole: ${userRole}`);

  const token = localStorage.getItem('token');
  if (!token) {
    throw new Error('JWT token is missing. Please login first.');
  }

  try {
    const response = await fetch(`${API_URL}/api/sitemap?userRole=${userRole}`, {
      method: 'GET',
      headers: {
        'Accept': 'application/json',
        'Authorization': `Bearer ${token}`,
      },
    });

    if (!response.ok) {
      throw new Error(`Failed to fetch sitemap with status: ${response.status}`);
    }

    const data = await response.json();
    console.log(`Sitemap response: ${JSON.stringify(data)}`);

    return data;
  } catch (error) {
    console.error('Failed to fetch sitemap', error);
    throw error;
  }
};


const sitemapService = { getSitemap };
export default sitemapService;
