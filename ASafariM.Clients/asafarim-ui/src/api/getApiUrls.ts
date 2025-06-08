import { logger } from "@/utils/logger";

const apiUrls = (host: string): string => {
    try {
        const isDevelopment = import.meta.env.MODE === 'development' || import.meta.env.VITE_ENVIRONMENT === 'development';
        logger.info('Environment:', import.meta.env.MODE, 'Host:', host, 'isDevelopment:', isDevelopment);

        // Define API URLs for production environments
        const productionUrls: { [key: string]: string } = {
            'bibliography.asafarim.com': 'https://bibliography.asafarim.com/api',
            'www.bibliography.asafarim.com': 'https://bibliography.asafarim.com/api',
            'bibliography.asafarim.be': 'https://bibliography.asafarim.be/api',
            'www.bibliography.asafarim.be': 'https://bibliography.asafarim.be/api',
            'blog.asafarim.com': 'https://blog.asafarim.com/api',
            'www.blog.asafarim.com': 'https://blog.asafarim.com/api',
            'blog.asafarim.be': 'https://blog.asafarim.be/api',
            'www.blog.asafarim.be': 'https://blog.asafarim.be/api',
            'asafarim.com': 'https://asafarim.com/api',
            'www.asafarim.com': 'https://asafarim.com/api',
            'asafarim.be': 'https://asafarim.be/api',
            'www.asafarim.be': 'https://asafarim.be/api',
        };

        // Return the production URL if the host matches, otherwise use the local development URL
        const apiUrl = productionUrls[host] || `http://localhost:${import.meta.env.VITE_API_PORT || 5000}/api`;
        logger.info('Resolved API URL:', apiUrl);
        return apiUrl;
    } catch (error) {
        logger.error('Error resolving API URL:', error);
        return 'http://localhost:5000/api'; // Fallback URL
    }
};

logger.log('Resolved API URL:', apiUrls(window.location.hostname), 'for host:', window.location.hostname);
export { apiUrls };
export default apiUrls;
