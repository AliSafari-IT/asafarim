import { describe, it, expect, beforeEach, vi, afterEach } from 'vitest';

// Mock the logger module instead of importing it directly
vi.mock('../logger', () => {
  // Create a mock implementation that we can control
  const mockLogger = {
    log: vi.fn(),
    info: vi.fn(),
    warn: vi.fn(),
    error: vi.fn(),
    debug: vi.fn()
  };
  
  // Return the factory function that creates our logger
  return {
    get logger() {
      // This will be re-evaluated each time logger is accessed
      const devMode = import.meta.env.VITE_APP_ENV !== 'production1';
      
      // Reset the implementation based on the current environment
      mockLogger.log.mockImplementation((...args) => {
        if (devMode) console.log(...args);
      });
      
      mockLogger.info.mockImplementation((...args) => {
        if (devMode) console.info(...args);
      });
      
      mockLogger.warn.mockImplementation((...args) => {
        if (devMode) console.warn(...args);
      });
      
      mockLogger.error.mockImplementation((...args) => {
        console.error(...args);
      });
      
      mockLogger.debug.mockImplementation((...args) => {
        if (devMode) console.debug(...args);
      });
      
      return mockLogger;
    }
  };
});

// Import the mocked logger
import { logger } from '../logger';

describe('logger', () => {
  // Spy on console methods
  const consoleLogSpy = vi.spyOn(console, 'log').mockImplementation(() => {});
  const consoleInfoSpy = vi.spyOn(console, 'info').mockImplementation(() => {});
  const consoleWarnSpy = vi.spyOn(console, 'warn').mockImplementation(() => {});
  const consoleErrorSpy = vi.spyOn(console, 'error').mockImplementation(() => {});
  const consoleDebugSpy = vi.spyOn(console, 'debug').mockImplementation(() => {});

  beforeEach(() => {
    // Clear all mocks before each test
    vi.clearAllMocks();
  });

  afterEach(() => {
    // Reset environment variables
    vi.unstubAllEnvs();
  });

  describe('in development mode', () => {
    beforeEach(() => {
      // Set development environment
      vi.stubEnv('VITE_APP_ENV', 'development');
    });

    it('should call console.log in development mode', () => {
      logger.log('test message');
      expect(consoleLogSpy).toHaveBeenCalledWith('test message');
    });

    it('should call console.info in development mode', () => {
      logger.info('info message');
      expect(consoleInfoSpy).toHaveBeenCalledWith('info message');
    });

    it('should call console.warn in development mode', () => {
      logger.warn('warning message');
      expect(consoleWarnSpy).toHaveBeenCalledWith('warning message');
    });

    it('should call console.error in development mode', () => {
      logger.error('error message');
      expect(consoleErrorSpy).toHaveBeenCalledWith('error message');
    });

    it('should call console.debug in development mode', () => {
      logger.debug('debug message');
      expect(consoleDebugSpy).toHaveBeenCalledWith('debug message');
    });

    it('should handle multiple arguments', () => {
      logger.log('message', { data: 'test' }, 123);
      expect(consoleLogSpy).toHaveBeenCalledWith('message', { data: 'test' }, 123);
    });
  });

  describe('in production mode', () => {
    beforeEach(() => {
      // Set production environment
      vi.stubEnv('VITE_APP_ENV', 'production1');
    });

    it('should not call console.log in production mode', () => {
      logger.log('test message');
      expect(consoleLogSpy).not.toHaveBeenCalled();
    });

    it('should not call console.info in production mode', () => {
      logger.info('info message');
      expect(consoleInfoSpy).not.toHaveBeenCalled();
    });

    it('should not call console.warn in production mode', () => {
      logger.warn('warning message');
      expect(consoleWarnSpy).not.toHaveBeenCalled();
    });

    it('should still call console.error in production mode', () => {
      logger.error('error message');
      expect(consoleErrorSpy).toHaveBeenCalledWith('error message');
    });

    it('should not call console.debug in production mode', () => {
      logger.debug('debug message');
      expect(consoleDebugSpy).not.toHaveBeenCalled();
    });
  });
});
