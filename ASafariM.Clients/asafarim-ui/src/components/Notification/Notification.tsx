import React from 'react';

interface NotificationProps {
    type: 'success' | 'warning' | 'error' | 'info' | string;
    text: string;
    role?: string;
    onDismiss?: () => void;
}

const Notification: React.FC<NotificationProps> = ({ type, text, role, onDismiss: onClose }) => {
    const bgColor =
        type === 'success' ? 'bg-green-100 dark:bg-green-800' :
        type === 'warning' ? 'bg-yellow-100 dark:bg-yellow-800' :
        type === 'error' ? 'bg-red-100 dark:bg-red-800' :
        'bg-blue-100 dark:bg-blue-800';

    const textColor =
        type === 'success' ? 'text-green-800 dark:text-green-100' :
        type === 'warning' ? 'text-yellow-800 dark:text-yellow-100' :
        type === 'error' ? 'text-red-800 dark:text-red-100' :
        'text-blue-800 dark:text-blue-100';

    return (
        <div
            className={`flex items-center justify-between p-4 mb-4 rounded-lg shadow-md ${bgColor} ${textColor}`}
            role={role}
        >
            <p className="text-sm font-medium">{text}</p>
            {onClose && (
                <button
                onClick={onClose}
                className="ml-4 px-3 py-1 rounded-md text-sm font-semibold bg-transparent hover:bg-opacity-20"
            >
                <span className={`text-darkred font-bold transition-transform duration-300 ${type === 'success' ? 'hover:text-success' : type === 'warning' ? 'hover:text-warning' : type === 'error' ? 'hover:text-error' : 'hover:text-info'} transform hover:-scale-y-150`}>✕</span>
            </button>
            )}
        </div>
    );
};

export default Notification;
