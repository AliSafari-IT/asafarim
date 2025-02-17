import React, { ReactNode, useState } from 'react';

interface TabPaneProps {
    tabs: {
        key: string;
        title: string;
        icon?: ReactNode;
        content: ReactNode;
    }[];
    defaultActiveKey?: string;
    onTabChange?: (key: string) => void;
    children?: ReactNode; // Added children prop
}

const TabPane: React.FC<TabPaneProps> = ({ tabs, defaultActiveKey, onTabChange, children }) => {
    const [activeKey, setActiveKey] = useState(defaultActiveKey || tabs[0]?.key);

    const handleTabClick = (key: string) => {
        setActiveKey(key);
        if (onTabChange) {
            onTabChange(key);
        }
    };

    return (
        <div className="tab-pane">
            {/* Tab Headers */}
            <div className="tab-headers flex border-b pb-2 space-x-4">
                {tabs.map(({ key, title, icon }) => (
                    <button
                        key={key}
                        className={`px-4 py-2 rounded-t-md transition ${
                            activeKey === key
                                ? 'bg-blue-500 text-white'
                                : 'bg-gray-100 text-gray-800 dark:bg-gray-800 dark:text-gray-300'
                        }`}
                        onClick={() => handleTabClick(key)}
                    >
                        {icon && <span className="mr-2">{icon}</span>}
                        {title}
                    </button>
                ))}
            </div>

            {/* Active Tab Content */}
            <div className="tab-content p-4 bg-white dark:bg-gray-900 rounded-b-lg shadow-md">
                {tabs.map(({ key, content }) =>
                    key === activeKey ? <div key={key}>{content}</div> : null
                )}
                {children}
            </div>
        </div>
    );
};

export default TabPane;
