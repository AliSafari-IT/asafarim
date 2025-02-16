import React, { useState, ReactNode } from 'react';

interface TabsProps {
    children: ReactNode;
    defaultActiveKey?: string;
    onTabChange?: (key: string) => void;
}

interface TabPaneProps {
    key: string;
    title: string;
    icon?: ReactNode;
    children: ReactNode;
}

export const TabPane: React.FC<TabPaneProps> = ({ children }) => {
    return <div>{children}</div>;
};

export const Tabs: React.FC<TabsProps> = ({ children, defaultActiveKey, onTabChange }) => {
    const [activeKey, setActiveKey] = useState(defaultActiveKey || '');

    const handleTabClick = (key: string) => {
        setActiveKey(key);
        if (onTabChange) {
            onTabChange(key);
        }
    };

    return (
        <div className="tabs">
            {/* Tab Headers */}
            <div className="tab-headers flex space-x-4 border-b pb-2">
                {React.Children.map(children, (child) => {
                    if (React.isValidElement(child) && child.type === TabPane) {
                        const { key, title, icon } = child.props as TabPaneProps;
                        return (
                            <button
                                key={key}
                                className={`tab-header px-4 py-2 rounded-t-md ${
                                    activeKey === key
                                        ? 'bg-info text-white'
                                        : 'bg-gray-100 text-gray-800 dark:bg-gray-800 dark:text-gray-300'
                                }`}
                                onClick={() => handleTabClick(key!)}
                            >
                                {icon && <span className="mr-2">{icon}</span>}
                                {title}
                            </button>
                        );
                    }
                    return null;
                })}
            </div>

            {/* Tab Content */}
            <div className="tab-content mt-4">
                {React.Children.map(children, (child) => {
                    if (React.isValidElement(child) && child.type === TabPane) {
                        return child.props.key === activeKey ? child : null;
                    }
                    return null;
                })}
            </div>
        </div>
    );
};
