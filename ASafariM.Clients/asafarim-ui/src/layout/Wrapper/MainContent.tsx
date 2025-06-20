import * as React from 'react';

interface MainContentProps {
    children: React.ReactNode;
    className?: string;
    style?: React.CSSProperties;
    header?: React.ReactNode;
}

const MainContent: React.FC<MainContentProps> = ({ children, className, header }) => {
    return (
        <div className={`${className} flex flex-col flex-1 overflow-hidden focus:outline-none`}>
            {header}
            {children}
        </div>
    );
};

export default MainContent;