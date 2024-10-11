import axios from 'axios';

const API_URL = 'https://localhost:44337/api/sitemap';

const getSitemap = async () => {
  const response = await axios.get(`${API_URL}?userRole=Admin`);
  return response.data;
};

const sitemapService = { getSitemap };
export default sitemapService;
