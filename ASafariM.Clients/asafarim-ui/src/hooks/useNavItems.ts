import { useMemo } from 'react';
import navItemsList from '@/layout/Navbar/navItemsList';

/**
 * Custom hook to get navigation items
 * This hook provides a memoized version of the navigation items list
 * to avoid unnecessary re-renders
 */
const useNavItems = () => {
  const items = useMemo(() => {
    return navItemsList;
  }, []);

  return items;
};

export default useNavItems;
