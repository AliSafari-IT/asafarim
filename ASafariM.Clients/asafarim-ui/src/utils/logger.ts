// src/utils/logger.ts
const logToServer = async (message: string, level: string = "info") => {
  const isDevelopment = import.meta.env.VITE_ENVIRONMENT === "development";
  const BASE_API_URL = isDevelopment
    ? "https://localhost:5001/api"
    : "https://asafarim.com/api";
  console.log("BASE_API_URL:", BASE_API_URL);

  try {
    await fetch(BASE_API_URL + "/logs", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ message, level }),
    });
  } catch (error) {
    console.error("Failed to log message: (" + BASE_API_URL + ")", error);
  }
};

export const logger = {
  info: (message: string) => logToServer(message, "info"),
  warn: (message: string) => logToServer(message, "warn"),
  error: (message: string) => logToServer(message, "error"),
};
