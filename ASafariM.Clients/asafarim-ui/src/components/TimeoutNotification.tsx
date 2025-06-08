import React, { useEffect, useState } from 'react';
import { useApiConfig } from '@/hooks/useApiConfig';

interface TimeoutNotificationProps {
    onDismiss?: () => void;
}

export const TimeoutNotification: React.FC<TimeoutNotificationProps> = ({ onDismiss }) => {
    const { connectionHealth, recommendedConfig, updateConfig } = useApiConfig();
    const [showNotification, setShowNotification] = useState(false);
    const [dismissed, setDismissed] = useState(false);

    useEffect(() => {
        // Show notification if there are repeated connection failures
        if (connectionHealth.consecutiveFailures >= 2 && !dismissed) {
            setShowNotification(true);
        } else {
            setShowNotification(false);
        }
    }, [connectionHealth.consecutiveFailures, dismissed]);

    const handleDismiss = () => {
        setDismissed(true);
        setShowNotification(false);
        onDismiss?.();
    };

    const handleApplyRecommended = () => {
        if (recommendedConfig) {
            updateConfig(recommendedConfig);
            handleDismiss();
        }
    };

    if (!showNotification) {
        return null;
    }

    return (
        <div className="fixed top-4 right-4 z-50 max-w-md">
            <div className="bg-yellow-100 border border-yellow-400 text-yellow-700 px-4 py-3 rounded shadow-lg">
                <div className="flex">
                    <div className="flex-1">
                        <h3 className="font-medium text-sm">
                            Connection Issues Detected
                        </h3>
                        <div className="mt-2 text-sm text-yellow-700">
                            <p>
                                Multiple requests have timed out. This might be due to slow network conditions.
                            </p>
                            {recommendedConfig && (
                                <p className="mt-1">
                                    We recommend increasing the timeout to {recommendedConfig.timeout / 1000} seconds.
                                </p>
                            )}
                        </div>
                        <div className="mt-3 flex space-x-2">
                            {recommendedConfig && (
                                <button
                                    onClick={handleApplyRecommended}
                                    className="text-xs bg-yellow-500 text-white px-2 py-1 rounded hover:bg-yellow-600"
                                >
                                    Apply Fix
                                </button>
                            )}
                            <button
                                onClick={handleDismiss}
                                className="text-xs text-yellow-600 hover:text-yellow-800"
                            >
                                Dismiss
                            </button>
                        </div>
                    </div>
                    <div className="ml-4 flex-shrink-0">
                        <button
                            onClick={handleDismiss}
                            className="text-yellow-400 hover:text-yellow-600"
                        >
                            <svg className="h-5 w-5" viewBox="0 0 20 20" fill="currentColor">
                                <path
                                    fillRule="evenodd"
                                    d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z"
                                    clipRule="evenodd"
                                />
                            </svg>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    );
};
