import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import AppWithRouter from './AppWithRouter';
import { initializeGA } from './services/analyticsService';
import ThemeProvider from '@asafarim/react-themes';

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

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <ThemeProvider defaultMode="light" persistMode={true}>
      <AppWithRouter />
    </ThemeProvider>
  </React.StrictMode>
);
