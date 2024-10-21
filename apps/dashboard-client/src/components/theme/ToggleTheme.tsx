// E:\asm\apps\dashboard-client\src\components\theme\ToggleTheme.tsx
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faMoon, faSun } from '@fortawesome/free-solid-svg-icons';
import { useTheme } from '../../hooks/useTheme';

export const ToggleThemeIcon = ({ theme }: { theme: string }) => {
  return <FontAwesomeIcon icon={theme === 'dark' ? faMoon : faSun} />;
};

interface ToggleThemeProps {
  className?: string;
}
const ToggleTheme = ({ className }: ToggleThemeProps): JSX.Element => {
  const { theme, toggleTheme } = useTheme();

  return (
    <div 
      title="Toggle Theme" 
      onClick={toggleTheme} 
      className={`cursor-pointer text-xl text-blue-300 hover:text-teal-600 transition duration-300 ${className}`}
    >
      <ToggleThemeIcon theme={theme}/>
    </div>
  );
};

export default ToggleTheme;
