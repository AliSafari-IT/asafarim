import axios from "axios";
import { apiConfig } from "@/config/api";

// src/utils/logger.ts
const logToServer = async (message: string, level: string = "info") => {
  console.log("BASE_API_URL:", apiConfig.baseURL);

  const api = axios.create({
    baseURL: apiConfig.baseURL,
  });

  try {
    await api.post("/logs", {
      message,
      level,
    });
  } catch (error) {
    console.error("Failed to log message:", error);
  }
};

export const logger = {
  info: (message: string) => {
    console.log(message);
    logToServer(message, "info");
  },
  warn: (message: string) => {
    console.warn(message);
    logToServer(message, "warn");
  },
  error: (message: string) => {
    console.error(message);
    logToServer(message, "error");
  }
};
