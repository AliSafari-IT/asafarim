// E:\asm\apps\dashboard-client\src\components\theme\ToggleTheme.tsx
import React, { useEffect, useRef } from 'react';
import { ToggleThemeProps } from '@/interfaces/ToggleThemeProps';
import { useTheme } from '@/contexts/ThemeContext';
import { 
  Star24Regular, 
  WeatherMoonFilled, 
  WeatherSunnyFilled,
  StarRegular,
  LeafOne24Regular,
  ColorRegular,
  WeatherSunny24Regular,
  WeatherSnowShowerDay24Regular
} from '@fluentui/react-icons';

const ToggleThemeDesktop: React.FC<ToggleThemeProps> = ({
  className = '',
  size = 20,
  title,
  viewWidth = 0
}) => {
  const { theme, toggleTheme } = useTheme();
  const isDark = theme === 'dark';
  const buttonRef = useRef<HTMLButtonElement>(null);
  const particlesRef = useRef<HTMLDivElement>(null);
  const timelineRef = useRef<HTMLDivElement>(null);
  const isCompact = viewWidth < 768;
  
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

  // Handle mouse move for interactive glow effect
  const handleMouseMove = (e: React.MouseEvent<HTMLButtonElement>) => {
    if (!buttonRef.current) return;
    
    const rect = buttonRef.current.getBoundingClientRect();
    const x = e.clientX - rect.left;
    const y = e.clientY - rect.top;
    
    // Update CSS variables for the glow position
    buttonRef.current.style.setProperty('--x', `${x}px`);
    buttonRef.current.style.setProperty('--y', `${y}px`);
  };

  // Create particles on toggle
  const createParticles = () => {
    if (!particlesRef.current) return;
    
    // Clear existing particles
    particlesRef.current.innerHTML = '';
    
    // Create new particles
    const particleCount = 12;
    const colors = isDark 
      ? ['#ffd700', '#f8f9fa', '#90cdf4'] 
      : ['#ff9500', '#ff4500', '#ffd700'];
    
    for (let i = 0; i < particleCount; i++) {
      const particle = document.createElement('div');
      particle.className = 'theme-particle';
      
      // Randomize particle properties
      const size = Math.random() * 8 + 4;
      const color = colors[Math.floor(Math.random() * colors.length)];
      const angle = (Math.random() * 360) * (Math.PI / 180);
      const distance = 30 + Math.random() * 40;
      const delay = Math.random() * 0.2;
      
      // Set particle styles
      particle.style.width = `${size}px`;
      particle.style.height = `${size}px`;
      particle.style.backgroundColor = color;
      particle.style.left = '50%';
      particle.style.top = '50%';
      particle.style.transform = `translate(-50%, -50%)`;
      particle.style.animation = `particle-burst 0.6s ease-out ${delay}s forwards`;
      particle.style.setProperty('--angle', `${angle}rad`);
      particle.style.setProperty('--distance', `${distance}px`);
      
      particlesRef.current.appendChild(particle);
    }
  };

  // Handle theme toggle with animation
  const handleToggle = () => {
    // Create particle burst effect
    createParticles();
    
    // Animate the timeline
    if (timelineRef.current) {
      timelineRef.current.style.animation = 'none';
      // Trigger reflow
      void timelineRef.current.offsetWidth;
      timelineRef.current.style.animation = isDark 
        ? 'timeline-light 1s ease-out forwards' 
        : 'timeline-dark 1s ease-out forwards';
    }
    
    // Toggle the theme
    toggleTheme();
  };

  // Add global animations
  useEffect(() => {
    const style = document.createElement('style');
    style.textContent = `
      @keyframes float {
        0%, 100% { transform: translateY(0px); }
        50% { transform: translateY(-10px); }
      }
      
      @keyframes twinkle {
        0%, 100% { opacity: 1; transform: scale(1); }
        50% { opacity: 0.3; transform: scale(0.8); }
      }
      
      @keyframes cloud-float {
        0% { transform: translateX(0); }
        100% { transform: translateX(20px); }
      }
      
      @keyframes rotate {
        0% { transform: rotate(0deg); }
        100% { transform: rotate(360deg); }
      }
      
      @keyframes particle-burst {
        0% { 
          transform: translate(-50%, -50%); 
          opacity: 1;
        }
        100% { 
          transform: translate(
            calc(-50% + var(--distance) * cos(var(--angle))), 
            calc(-50% + var(--distance) * sin(var(--angle)))
          );
          opacity: 0;
        }
      }
      
      @keyframes timeline-dark {
        0% { transform: translateX(-100%); }
        100% { transform: translateX(0); }
      }
      
      @keyframes timeline-light {
        0% { transform: translateX(0); }
        100% { transform: translateX(100%); }
      }
      
      @keyframes pulse-glow {
        0%, 100% { opacity: 0.7; transform: scale(1); }
        50% { opacity: 1; transform: scale(1.05); }
      }
      
      @keyframes day-night-cycle {
        0% { transform: translateY(0) rotate(0deg); }
        50% { transform: translateY(-30px) rotate(180deg); }
        100% { transform: translateY(0) rotate(360deg); }
      }
      
      @keyframes season-rotate {
        0% { transform: rotate(0deg) translateX(0) scale(1); }
        25% { transform: rotate(90deg) translateX(5px) scale(0.9); }
        50% { transform: rotate(180deg) translateX(0) scale(0.8); }
        75% { transform: rotate(270deg) translateX(-5px) scale(0.9); }
        100% { transform: rotate(360deg) translateX(0) scale(1); }
      }
      
      .star { animation: twinkle var(--duration, 2s) ease-in-out infinite var(--delay, 0s); }
      .float-icon { animation: day-night-cycle 8s ease-in-out infinite; }
      .cloud { animation: cloud-float 3s ease-in-out infinite alternate; }
      .season-icon { animation: season-rotate 10s linear infinite; }
    `;
    document.head.appendChild(style);
    return () => {
      document.head.removeChild(style);
    };
  }, []);

  return (
    <button
      ref={buttonRef}
      type="button"
      onClick={handleToggle}
      onMouseMove={handleMouseMove}
      title={title || `Switch to ${isDark ? 'light' : 'dark'} mode`}
      className={`${className} group relative h-16 w-28 rounded-full p-1.5 transition-all duration-700 z-50 overflow-hidden
        ${isDark 
          ? 'bg-gradient-to-br from-gray-900 via-blue-950 to-indigo-900 shadow-inner shadow-blue-900/30' 
          : 'bg-gradient-to-br from-blue-300 via-sky-200 to-indigo-100 shadow-inner shadow-white/50'
        }`}
      style={{
        '--x': '50%',
        '--y': '50%',
      } as React.CSSProperties}
      aria-label={`Toggle ${isDark ? 'light' : 'dark'} mode`}
    >
      {/* Interactive glow effect */}
      <div 
        className={`absolute pointer-events-none left-[var(--x)] top-[var(--y)] h-32 w-32 -translate-x-1/2 -translate-y-1/2 rounded-full 
          transition-opacity duration-300 blur-xl
          ${isDark ? 'bg-blue-500/20' : 'bg-yellow-400/20'}`}
        style={{ opacity: 0.7 }}
      />
      
      {/* Timeline indicator */}
      <div 
        ref={timelineRef}
        className={`absolute bottom-0 left-0 h-1 w-full transition-colors duration-700
          ${isDark ? 'bg-blue-400' : 'bg-yellow-400'}`}
        style={{ transform: isDark ? 'translateX(0)' : 'translateX(-100%)' }}
      />
      
      {/* Scene Container */}
      <div className="relative h-full w-full overflow-hidden rounded-full">
        {/* Background gradient */}
        <div 
          className={`absolute inset-0 transition-all duration-700
            ${isDark 
              ? 'bg-gradient-to-b from-transparent via-blue-950/50 to-indigo-950/80' 
              : 'bg-gradient-to-b from-transparent via-blue-100/50 to-sky-100/80'
            }`}
        />
        
        {/* Stars (visible in dark mode) */}
        <div className={`absolute inset-0 transition-opacity duration-700 ${isDark ? 'opacity-100' : 'opacity-0'}`}>
          <Star24Regular className="star absolute left-2 top-1 h-2 w-2 text-white" style={{ '--duration': '2s', '--delay': '0s' } as React.CSSProperties} />
          <Star24Regular className="star absolute left-6 top-3 h-1.5 w-1.5 text-white" style={{ '--duration': '2.5s', '--delay': '0.3s' } as React.CSSProperties} />
          <Star24Regular className="star absolute right-3 top-2 h-2 w-2 text-white" style={{ '--duration': '1.8s', '--delay': '0.5s' } as React.CSSProperties} />
          <Star24Regular className="star absolute left-10 top-6 h-1 w-1 text-white" style={{ '--duration': '3s', '--delay': '0.7s' } as React.CSSProperties} />
          <Star24Regular className="star absolute right-8 top-4 h-1.5 w-1.5 text-white" style={{ '--duration': '2.2s', '--delay': '0.2s' } as React.CSSProperties} />
          <StarRegular className="star absolute left-16 top-2 h-2 w-2 text-blue-300" style={{ '--duration': '3.5s', '--delay': '0.1s' } as React.CSSProperties} />
        </div>

        {/* Clouds (visible in light mode) */}
        <div className={`absolute inset-0 transition-opacity duration-700 ${!isDark ? 'opacity-100' : 'opacity-0'}`}>
          <div className="cloud absolute left-1 top-2 h-2 w-6 rounded-full bg-white/90" />
          <div className="cloud absolute right-2 top-4 h-1.5 w-4 rounded-full bg-white/90" />
          <div className="cloud absolute left-10 top-6 h-2 w-5 rounded-full bg-white/80" />
        </div>
        
        {/* Season indicators (four corners) */}
        <div className={`absolute inset-0 transition-opacity duration-700 ${!isDark ? 'opacity-100' : 'opacity-0'}`}>
          <div className="absolute left-2 top-2">
            <ColorRegular className="season-icon h-3 w-3 text-pink-400" />
          </div>
          <div className="absolute right-2 top-2">
            <LeafOne24Regular className="season-icon h-3 w-3 text-green-500" />
          </div>
          <div className="absolute left-2 bottom-2">
            <WeatherSunny24Regular className="season-icon h-3 w-3 text-amber-600" />
          </div>
          <div className="absolute right-2 bottom-2">
            <WeatherSnowShowerDay24Regular className="season-icon h-3 w-3 text-blue-300" />
          </div>
        </div>

        {/* Main Icon */}
        <div 
          className={`float-icon absolute left-1/2 top-1/2 -translate-x-1/2 -translate-y-1/2 transform transition-all duration-700
            ${isDark ? 'text-blue-200' : 'text-yellow-400'}`}
        >
          {isDark ? (
            <WeatherMoonFilled fontSize={pixelSize + 8} className="drop-shadow-lg" />
          ) : (
            <WeatherSunnyFilled fontSize={pixelSize + 8} className="drop-shadow-lg" />
          )}
        </div>

        {/* Particle container for toggle animation */}
        <div ref={particlesRef} className="absolute inset-0 pointer-events-none" />

        {/* Reflection/Glow Effect */}
        <div 
          className={`absolute bottom-1 left-1/2 h-6 w-6 -translate-x-1/2 transform rounded-full blur-md transition-all duration-700
            ${isDark 
              ? 'bg-blue-400/40 animate-pulse' 
              : 'bg-yellow-400/40 animate-pulse'
            }`}
        />
      </div>
    </button>
  );
};

export default React.memo(ToggleThemeDesktop);
