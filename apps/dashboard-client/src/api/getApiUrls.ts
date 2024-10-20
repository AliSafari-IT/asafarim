// Determine the correct API URL based on the current hostname
let API_URL = 'https://localhost:44337/api';

if (window.location.hostname === 'preview.asafarim.com') {
    API_URL = 'https://preview.asafarim.com/api';
}

if (window.location.hostname === 'asafarim.com') {
    API_URL = 'https://asafarim.com/api';
}

console.log("apiUrls -> API_URL: " + API_URL);

export default API_URL;