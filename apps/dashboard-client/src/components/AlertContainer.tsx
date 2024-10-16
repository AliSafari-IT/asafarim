import React from 'react';

interface AlertContainerProps {
    className?: string;
    style?: React.CSSProperties;
    title?: string;
    close?: () => void;
  theme?: 'info' | 'success' | 'warning' | 'danger' | 'none'; // Define the possible themes
  children: React.ReactNode; // Allow children to be passed in
}

const themeStyles: { [key: string]: string } = {
  info: 'bg-blue-100 border-blue-400 text-blue-800',
  success: 'bg-green-100 border-green-400 text-green-800',
  warning: 'bg-yellow-100 border-yellow-400 text-yellow-800',
  danger: 'bg-red-100 border-red-400 text-red-800',
  none: 'bg-gray-100 border-gray-400 text-gray-800',
};

const AlertContainer: React.FC<AlertContainerProps> = ({ theme = 'none', children }) => {

  return (
    <div className={`p-4 border rounded-lg shadow-md ${themeStyles[theme]}`}>
      {children}
    </div>
  );
};

export default AlertContainer;
