import axios from "axios";
import ReactGA from "react-ga4";

// GA4 Measurement ID from environment variables
const GA_MEASUREMENT_ID = import.meta.env.VITE_GA_MEASUREMENT_ID;

/**
 * Initialize Google Analytics
 */
export function initializeGA() {
  if (GA_MEASUREMENT_ID) {
    ReactGA.initialize(GA_MEASUREMENT_ID);
    console.log("Google Analytics initialized");
  } else {
    console.warn("Google Analytics Measurement ID not found");
  }
}

/**
 * Track page views
 * @param path - The current page path
 * @param title - The page title
 */
export function trackPageView(path: string, title?: string) {
  ReactGA.send({ 
    hitType: "pageview", 
    page: path,
    title: title 
  });
}

/**
 * Track custom events
 * @param category - Event category
 * @param action - Event action
 * @param label - Event label (optional)
 * @param value - Event value (optional)
 */
export function trackEvent(category: string, action: string, label?: string, value?: number) {
  ReactGA.event({
    category,
    action,
    label,
    value
  });
}

// Mock data for visitor stats
const mockVisitorData = {
  totalVisitors: Math.floor(Math.random() * 1000) + 100
};

/**
 * Get visitor stats from backend API or mock data if API is unavailable
 */
export async function getVisitorStats() {
  try {
    // First try to get data from the backend API
    const response = await axios.get('/api/visitor/stats', { timeout: 3000 });
    return response.data;
  } catch (error) {
    console.warn("Error fetching visitor stats from API, using mock data:", error);
    
    // If API call fails, return mock data
    return mockVisitorData;
  }
}
