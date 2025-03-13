// E:\asm\apps\dashboard-client\src\components\theme\ToggleTheme.tsx
import React, { useRef } from 'react';
import { ToggleThemeProps } from '@/interfaces/ToggleThemeProps';
import { useTheme } from '@/contexts/ThemeContext';
import { 
  WeatherMoonRegular, 
  WeatherSunnyRegular
} from '@fluentui/react-icons';

const ToggleThemeDesktop: React.FC<ToggleThemeProps> = ({
  className = '',
  size = 20,
  title
}) => {
  const { theme, toggleTheme } = useTheme();
  const isDark = theme === 'dark';
  const buttonRef = useRef<HTMLButtonElement>(null);
  
  // Convert FontAwesome size to pixel number
  const getPixelSize = (size: string | number): number => {
    if (typeof size === 'number') return size;
    const sizeMap: { [key: string]: number } = {
      'xs': 12,
      'sm': 14,
      '1x': 16,
      'lg': 18,
      '2x': 24,
      '3x': 32,
      '4x': 48,
      '5x': 64,
      '6x': 80,
      '7x': 96,
      '8x': 112,
      '9x': 128,
      '10x': 144,
    };
    return sizeMap[size] || 20;
  };

  const pixelSize = getPixelSize(size);

  return (
    <button
      ref={buttonRef}
      type="button"
      onClick={toggleTheme}
      title={title || `Switch to ${isDark ? 'light' : 'dark'} mode`}
      className={`${className} relative flex items-center justify-center h-10 w-10 rounded-full transition-all duration-300
        ${isDark 
          ? 'bg-gray-800 text-blue-300 hover:bg-gray-700' 
          : 'bg-blue-100 text-yellow-500 hover:bg-blue-50'
        }`}
      aria-label={`Toggle ${isDark ? 'light' : 'dark'} mode`}
    >
      <div className="relative">
        {/* Icon with subtle animation */}
        <div 
          className="transition-transform duration-300 hover:scale-110"
          style={{ 
            transform: isDark ? 'rotate(0deg)' : 'rotate(0deg)',
            opacity: 1
          }}
        >
          {isDark ? (
            <WeatherMoonRegular fontSize={pixelSize} />
          ) : (
            <WeatherSunnyRegular fontSize={pixelSize} />
          )}
        </div>
        
        {/* Subtle glow effect */}
        <div 
          className={`absolute inset-0 rounded-full blur-sm transition-opacity duration-300 -z-10
            ${isDark ? 'bg-blue-500/20' : 'bg-yellow-400/20'}`}
          style={{ 
            opacity: 0.7,
            transform: 'scale(1.2)'
          }}
        />
      </div>
    </button>
  );
};

export default React.memo(ToggleThemeDesktop);
