import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import AppWithRouter from './AppWithRouter';
import { AzureDarkTheme } from '@fluentui-contrib/azure-theme';
import { FluentProvider } from '@fluentui/react-components';
import { initializeGA } from './services/analyticsService';

// Initialize Google Analytics
initializeGA();

// Initialize FluentUI icons - with error handling
try {
  const { initializeIcons } = require('@fluentui/font-icons-mdl2');
  initializeIcons();
} catch (error) {
  console.warn('Failed to initialize FluentUI icons:', error);
}

const theme = AzureDarkTheme;
ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <FluentProvider theme={theme}>
      <AppWithRouter />
    </FluentProvider>
  </React.StrictMode>
);
