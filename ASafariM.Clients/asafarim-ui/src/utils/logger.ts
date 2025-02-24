import axios from "axios";
import { apiConfig } from "@/config/api";

// src/utils/logger.ts
const logToServer = async (message: string, level: string = "info") => {
    // Skip server logging in development mode
    if (apiConfig.isDevelopment) {
        console.log(`[${level.toUpperCase()}] ${message}`);
        return;
    }

    try {
        await axios.post(`${apiConfig.baseURL}/logs`, {
            message,
            level,
            timestamp: new Date().toISOString()
        });
    } catch (error) {
        // Only log server errors to console in production
        console.error("Failed to send log to server:", error);
    }
};

export const logger = {
    info: (message: string) => {
        if (apiConfig.isDevelopment) {
            console.log(`[INFO] ${message}`);
        } else {
            logToServer(message, "info");
        }
    },
    warn: (message: string) => {
        if (apiConfig.isDevelopment) {
            console.warn(`[WARN] ${message}`);
        } else {
            logToServer(message, "warn");
        }
    },
    error: (message: string) => {
        if (apiConfig.isDevelopment) {
            console.error(`[ERROR] ${message}`);
        } else {
            logToServer(message, "error");
        }
    }
};
