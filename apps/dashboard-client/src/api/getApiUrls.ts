/// <reference types="vite/client" />

const apiUrls = (host: string) => {
    switch (host) {
        case 'preview.asafarim.com':
            return 'https://preview.asafarim.com/api';
        case 'asafarim.com':
            return 'https://asafarim.com/api';
        default:
            return `https://localhost:${import.meta.env.VITE_SERVER_PORT}/api`;
    }
};

export default apiUrls(window.location.hostname);
