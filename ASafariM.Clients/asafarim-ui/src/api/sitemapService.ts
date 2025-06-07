import { ISitemapItem } from "@/interfaces/ISitemapItem";
import { IRoleEnum } from "../interfaces/IRole";
import API_URL from "./getApiUrls";
import { logger } from "@/utils/logger";

const getSitemap = async (userRole: IRoleEnum) => {
  logger.info(`Fetching sitemap for userRole: ${userRole}`);
  const localAuth = localStorage.getItem('auth');

  const {token} =localAuth ? JSON.parse(localAuth).token : {token: null};
  
  logger.info(`Token from localStorage: ${token}`);

  if (!token) {
    throw new Error('JWT token is missing. Please login first.');
  }

  try {
    const response = await fetch(`${API_URL}/sitemap?roleIndex=${userRole}`, {
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
    logger.info(`Sitemap response: ${JSON.stringify(data)}`);

    return data;
  } catch (error) {
    logger.error('Failed to fetch sitemap', error);
    throw error;
  }
};

const createSitemap = async (newItem: Omit<ISitemapItem, 'id'>) => {
  const {token} = JSON.parse(localStorage.getItem('auth') || '{}');
  
  if (!token) {
    throw new Error('JWT token is missing. Please login first.');
  }

  const response = await fetch(`${API_URL}/api/sitemap`, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${token}`
    },
    body: JSON.stringify(newItem)
  });

  if (!response.ok) {
    throw new Error('Failed to create sitemap item');
  }

  return response.json();
};

const sitemapService = { getSitemap, createSitemap };
export default sitemapService;
