// src/utils/logger.ts
export const logger = {
  log: (...args: any[]) => {
    if (import.meta.env.MODE !== 'production') {
      console.log(...args);
    }
  },
  info: (...args: any[]) => {
    if (import.meta.env.MODE !== 'production') {
      console.info(...args);
    }
  },
  warn: (...args: any[]) => {
    if (import.meta.env.MODE !== 'production') {
      console.warn(...args);
    }
  },
  error: (...args: any[]) => {
    console.error(...args);
  },
  debug: (...args: any[]) => {
    if (import.meta.env.MODE !== 'production') {
      console.debug(...args);
    }
  }
};
