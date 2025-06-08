import React, { useState } from 'react';
import { useApiConfig } from '@/hooks/useApiConfig';

interface ConnectionStatusProps {
    showDetails?: boolean;
    className?: string;
}

export const ConnectionStatus: React.FC<ConnectionStatusProps> = ({ 
    showDetails = false, 
    className = '' 
}) => {
    const { connectionHealth, testConnection, config } = useApiConfig();
    const [isExpanded, setIsExpanded] = useState(false);
    const [isTesting, setIsTesting] = useState(false);

    const getStatusColor = () => {
        if (connectionHealth.consecutiveFailures >= 3) return 'bg-red-500';
        if (connectionHealth.consecutiveFailures >= 1) return 'bg-yellow-500';
        if (connectionHealth.isConnected) return 'bg-green-500';
        return 'bg-gray-500';
    };

    const getStatusText = () => {
        if (connectionHealth.consecutiveFailures >= 3) return 'Connection Issues';
        if (connectionHealth.consecutiveFailures >= 1) return 'Unstable';
        if (connectionHealth.isConnected) return 'Connected';
        return 'Unknown';
    };

    const handleTestConnection = async () => {
        setIsTesting(true);
        try {
            await testConnection();
        } finally {
            setIsTesting(false);
        }
    };

    const formatResponseTime = (time: number) => {
        if (time < 1000) return `${time}ms`;
        return `${(time / 1000).toFixed(1)}s`;
    };

    const formatDate = (date: Date | null) => {
        if (!date) return 'Never';
        return date.toLocaleTimeString();
    };

    if (!showDetails) {
        // Simple indicator version
        return (
            <div 
                className={`flex items-center space-x-2 cursor-pointer ${className}`}
                onClick={() => setIsExpanded(!isExpanded)}
                title={`Connection Status: ${getStatusText()}`}
            >
                <div className={`w-3 h-3 rounded-full ${getStatusColor()}`} />
                <span className="text-sm text-gray-600 dark:text-gray-300">
                    {getStatusText()}
                </span>
                
                {isExpanded && (
                    <div className="absolute bottom-full right-0 mb-2 p-3 bg-white dark:bg-gray-800 border border-gray-200 dark:border-gray-700 rounded-lg shadow-lg z-50 min-w-64">
                        <div className="space-y-2">
                            <div className="flex justify-between">
                                <span className="text-sm font-medium">Status:</span>
                                <span className={`text-sm font-bold ${
                                    connectionHealth.isConnected ? 'text-green-600' : 'text-red-600'
                                }`}>
                                    {getStatusText()}
                                </span>
                            </div>
                            
                            <div className="flex justify-between">
                                <span className="text-sm">Failures:</span>
                                <span className="text-sm">{connectionHealth.consecutiveFailures}</span>
                            </div>
                            
                            <div className="flex justify-between">
                                <span className="text-sm">Avg Response:</span>
                                <span className="text-sm">
                                    {formatResponseTime(connectionHealth.averageResponseTime)}
                                </span>
                            </div>
                            
                            <div className="flex justify-between">
                                <span className="text-sm">Last Success:</span>
                                <span className="text-sm">
                                    {formatDate(connectionHealth.lastSuccessfulRequest)}
                                </span>
                            </div>
                            
                            <button
                                onClick={handleTestConnection}
                                disabled={isTesting}
                                className="w-full mt-2 px-3 py-1 bg-blue-500 text-white text-sm rounded hover:bg-blue-600 disabled:opacity-50"
                            >
                                {isTesting ? 'Testing...' : 'Test Connection'}
                            </button>
                        </div>
                    </div>
                )}
            </div>
        );
    }

    // Detailed version for settings pages
    return (
        <div className={`p-4 bg-white dark:bg-gray-800 border border-gray-200 dark:border-gray-700 rounded-lg ${className}`}>
            <div className="flex items-center justify-between mb-4">
                <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
                    Connection Status
                </h3>
                <div className="flex items-center space-x-2">
                    <div className={`w-4 h-4 rounded-full ${getStatusColor()}`} />
                    <span className={`font-medium ${
                        connectionHealth.isConnected ? 'text-green-600' : 'text-red-600'
                    }`}>
                        {getStatusText()}
                    </span>
                </div>
            </div>

            <div className="grid grid-cols-2 gap-4 mb-4">
                <div className="space-y-2">
                    <div className="flex justify-between">
                        <span className="text-sm text-gray-600 dark:text-gray-400">
                            Consecutive Failures:
                        </span>
                        <span className={`text-sm font-medium ${
                            connectionHealth.consecutiveFailures > 0 ? 'text-red-600' : 'text-green-600'
                        }`}>
                            {connectionHealth.consecutiveFailures}
                        </span>
                    </div>
                    
                    <div className="flex justify-between">
                        <span className="text-sm text-gray-600 dark:text-gray-400">
                            Average Response Time:
                        </span>
                        <span className="text-sm font-medium">
                            {formatResponseTime(connectionHealth.averageResponseTime)}
                        </span>
                    </div>
                </div>

                <div className="space-y-2">
                    <div className="flex justify-between">
                        <span className="text-sm text-gray-600 dark:text-gray-400">
                            Last Successful Request:
                        </span>
                        <span className="text-sm font-medium">
                            {formatDate(connectionHealth.lastSuccessfulRequest)}
                        </span>
                    </div>
                    
                    <div className="flex justify-between">
                        <span className="text-sm text-gray-600 dark:text-gray-400">
                            Current Timeout:
                        </span>
                        <span className="text-sm font-medium">
                            {formatResponseTime(config.timeout)}
                        </span>
                    </div>
                </div>
            </div>

            {connectionHealth.recentResponses.length > 0 && (
                <div className="mb-4">
                    <h4 className="text-sm font-medium text-gray-900 dark:text-white mb-2">
                        Recent Response Times
                    </h4>
                    <div className="flex space-x-1 h-8">
                        {connectionHealth.recentResponses.map((time, index) => {
                            const height = Math.min((time / Math.max(...connectionHealth.recentResponses)) * 100, 100);
                            const color = time > config.timeout * 0.8 ? 'bg-red-400' : 
                                         time > config.timeout * 0.5 ? 'bg-yellow-400' : 'bg-green-400';
                            
                            return (
                                <div
                                    key={index}
                                    className={`flex-1 ${color} rounded-sm`}
                                    style={{ height: `${height}%`, alignSelf: 'flex-end' }}
                                    title={`${formatResponseTime(time)}`}
                                />
                            );
                        })}
                    </div>
                    <div className="flex justify-between text-xs text-gray-500 mt-1">
                        <span>Oldest</span>
                        <span>Latest</span>
                    </div>
                </div>
            )}

            <button
                onClick={handleTestConnection}
                disabled={isTesting}
                className="w-full px-4 py-2 bg-blue-500 text-white rounded-lg hover:bg-blue-600 disabled:opacity-50 disabled:cursor-not-allowed transition-colors"
            >
                {isTesting ? (
                    <div className="flex items-center justify-center space-x-2">
                        <div className="w-4 h-4 border-2 border-white border-t-transparent rounded-full animate-spin" />
                        <span>Testing Connection...</span>
                    </div>
                ) : (
                    'Test Connection'
                )}
            </button>
        </div>
    );
};
