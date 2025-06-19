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
  import('@fluentui/font-icons-mdl2').then(({ initializeIcons }) => {
    initializeIcons();
  }).catch((error) => {
    console.warn('Failed to initialize FluentUI icons:', error);
  });
} catch (error) {
  console.warn('Failed to load FluentUI icons module:', error);
}

const theme = AzureDarkTheme;
ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <FluentProvider theme={theme}>
      <AppWithRouter />
    </FluentProvider>
  </React.StrictMode>
);
