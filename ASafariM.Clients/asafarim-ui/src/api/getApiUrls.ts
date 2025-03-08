const apiUrls = (host: string) => {
    const isDevelopment = import.meta.env.VITE_ENVIRONMENT === 'development';
    console.debug('isDevelopment:', isDevelopment, 'host:', host);

    // Define API URLs for production environments
const productionUrls: { [key: string]: string } = {
    'preview.asafarim.com': 'https://preview.asafarim.com/api',
    'www.preview.asafarim.com': 'https://preview.asafarim.com/api',
    'asafarim.com': 'https://asafarim.com/api',
    'www.asafarim.com': 'https://asafarim.com/api',
};

    // Return the production URL if the host matches, otherwise use the local development URL
    return productionUrls[host] || `http://localhost:${import.meta.env.VITE_API_PORT}/api`;
};

console.log('Resolved API URL:', apiUrls(window.location.hostname), 'for host:', window.location.hostname);
export { apiUrls };
export default apiUrls;
