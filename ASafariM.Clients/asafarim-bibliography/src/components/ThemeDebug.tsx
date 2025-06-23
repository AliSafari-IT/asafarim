import { useTheme } from '@asafarim/react-themes';

export default function ThemeDebug() {
  const { mode, currentTheme } = useTheme();
    return (
    <div style={{
      position: 'fixed',
      top: '10px',
      left: '10px',
      background: 'var(--theme-color-background-secondary)',
      color: 'var(--theme-color-text)',
      padding: '8px',
      borderRadius: '4px',
      fontSize: '12px',
      zIndex: 9999,
      border: '1px solid var(--theme-color-border)',
    }}>
      <div>Mode: {mode}</div>
      <div>Theme: {currentTheme.name}</div>
      <div>BG: {getComputedStyle(document.documentElement).getPropertyValue('--theme-color-background')}</div>
    </div>
  );
}
