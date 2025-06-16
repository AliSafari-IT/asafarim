import { useState, useEffect, useCallback } from 'react';
import { ApiConfig, getApiConfig, updateApiConfig } from '@/config/apiConfig';

export interface ConnectionHealth {
    isConnected: boolean;
    lastSuccessfulRequest: Date | null;
    consecutiveFailures: number;
    averageResponseTime: number;
    recentResponses: number[];
}

export interface RecommendedConfig {
    timeout: number;
    maxRetries: number;
    retryDelay: number;
    reason: string;
}

export interface UseApiConfigReturn {
    config: ApiConfig;
    connectionHealth: ConnectionHealth;
    recommendedConfig: RecommendedConfig | null;
    updateConfig: (newConfig: Partial<ApiConfig>) => void;
    resetToDefaults: () => void;
    testConnection: () => Promise<boolean>;
}

export const useApiConfig = (): UseApiConfigReturn => {
    const [config, setConfig] = useState<ApiConfig>(getApiConfig());
    const [connectionHealth, setConnectionHealth] = useState<ConnectionHealth>({
        isConnected: true,
        lastSuccessfulRequest: null,
        consecutiveFailures: 0,
        averageResponseTime: 0,
        recentResponses: []
    });
    const [recommendedConfig, setRecommendedConfig] = useState<RecommendedConfig | null>(null);

    // Listen for config changes
    useEffect(() => {
        const handleConfigChange = (event: CustomEvent) => {
            setConfig(event.detail);
        };

        window.addEventListener('api-config-changed', handleConfigChange as EventListener);
        return () => {
            window.removeEventListener('api-config-changed', handleConfigChange as EventListener);
        };
    }, []);

    // Monitor network performance and update connection health
    useEffect(() => {
        const monitorPerformance = () => {
            // Listen for fetch events to monitor API performance
            const originalFetch = window.fetch;
            
            window.fetch = async (...args) => {
                const startTime = Date.now();
                
                try {
                    const response = await originalFetch(...args);
                    const responseTime = Date.now() - startTime;
                    
                    // Update connection health on successful request
                    setConnectionHealth(prev => {
                        const newResponses = [...prev.recentResponses, responseTime].slice(-10); // Keep last 10 responses
                        const avgResponseTime = newResponses.reduce((sum, time) => sum + time, 0) / newResponses.length;
                        
                        return {
                            isConnected: true,
                            lastSuccessfulRequest: new Date(),
                            consecutiveFailures: 0,
                            averageResponseTime: avgResponseTime,
                            recentResponses: newResponses
                        };
                    });
                    
                    return response;
                } catch (error) {
                    // Update connection health on failed request
                    setConnectionHealth(prev => ({
                        ...prev,
                        isConnected: false,
                        consecutiveFailures: prev.consecutiveFailures + 1
                    }));
                    
                    throw error;
                }
            };
            
            return () => {
                window.fetch = originalFetch;
            };
        };

        const cleanup = monitorPerformance();
        return cleanup;
    }, []);

    // Generate recommendations based on connection health
    useEffect(() => {
        const { consecutiveFailures, averageResponseTime, isConnected } = connectionHealth;
        
        if (consecutiveFailures >= 3) {
            setRecommendedConfig({
                timeout: 30000,
                maxRetries: 3,
                retryDelay: 2000,
                reason: 'Frequent connection failures detected. Increasing timeout and retries.'
            });
        } else if (averageResponseTime > 5000) {
            setRecommendedConfig({
                timeout: 25000,
                maxRetries: 2,
                retryDelay: 1500,
                reason: 'Slow response times detected. Increasing timeout values.'
            });
        } else if (averageResponseTime < 1000 && isConnected) {
            setRecommendedConfig({
                timeout: 8000,
                maxRetries: 1,
                retryDelay: 500,
                reason: 'Fast and stable connection detected. Optimizing for speed.'
            });
        } else {
            setRecommendedConfig(null);
        }
    }, [connectionHealth]);

    const updateConfigHandler = useCallback((newConfig: Partial<ApiConfig>) => {
        updateApiConfig(newConfig);
        setConfig(getApiConfig());
    }, []);

    const resetToDefaults = useCallback(() => {
        localStorage.removeItem('api-config');
        setConfig(getApiConfig());
        window.dispatchEvent(new CustomEvent('api-config-changed', { 
            detail: getApiConfig() 
        }));
    }, []);

    const testConnection = useCallback(async (): Promise<boolean> => {
        try {
            const startTime = Date.now();
            const isDevelopment = import.meta.env.VITE_ENVIRONMENT === 'development';
            const baseUrl = isDevelopment ? 'http://localhost:5000' : 'https://asafarim.com';
            
            const response = await fetch(`${baseUrl}/health`, {
                method: 'GET',
                signal: AbortSignal.timeout(config.timeout)
            });
            
            const responseTime = Date.now() - startTime;
            
            if (response.ok) {
                setConnectionHealth(prev => ({
                    ...prev,
                    isConnected: true,
                    lastSuccessfulRequest: new Date(),
                    consecutiveFailures: 0,
                    recentResponses: [...prev.recentResponses, responseTime].slice(-10)
                }));
                return true;
            } else {
                setConnectionHealth(prev => ({
                    ...prev,
                    isConnected: false,
                    consecutiveFailures: prev.consecutiveFailures + 1
                }));
                return false;
            }
        } catch (error) {
            setConnectionHealth(prev => ({
                ...prev,
                isConnected: false,
                consecutiveFailures: prev.consecutiveFailures + 1
            }));
            return false;
        }
    }, [config.timeout]);

    return {
        config,
        connectionHealth,
        recommendedConfig,
        updateConfig: updateConfigHandler,
        resetToDefaults,
        testConnection
    };
};
