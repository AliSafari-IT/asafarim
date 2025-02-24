const getApiConfig = () => {
    const isDevelopment = import.meta.env.VITE_ENVIRONMENT === "development";
    
    return {
        baseURL: isDevelopment ? '/api' : 'https://asafarim.com/api',
        isDevelopment
    };
};

export const apiConfig = getApiConfig();
