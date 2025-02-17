const apiUrls = (host: string) => {
    const isDevelopment = import.meta.env.VITE_ENVIRONMENT === 'development';
    console.debug('isDevelopment:', isDevelopment, 'host:', host);

    switch (host) {
        case 'preview.asafarim.com':
        case 'www.preview.asafarim.com':
            return 'https://preview.asafarim.com/api';
        case 'asafarim.com':
        case 'www.asafarim.com':
            return 'https://asafarim.com/api';
        default:
            return `https://localhost:${import.meta.env.VITE_API_HTTPS_PORT}/api`;
    }
};

console.debug(apiUrls(window.location.hostname));
export { apiUrls };
export default apiUrls;
