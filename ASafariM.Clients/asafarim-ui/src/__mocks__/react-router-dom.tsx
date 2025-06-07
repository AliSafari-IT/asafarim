import React from 'react';
import { vi } from 'vitest';

export const BrowserRouter: React.FC<{ children: React.ReactNode }> = ({ children }) => (
  <div>{children}</div>
);

export const Link: React.FC<{ to: string; children: React.ReactNode }> = ({ to, children }) => (
  <a href={to} onClick={(e) => e.preventDefault()}>{children}</a>
);

export const useLocation = vi.fn(() => ({
  pathname: '/',
  search: '',
  hash: '',
  state: null,
  key: 'default',
}));

export const useNavigate = vi.fn(() => vi.fn());
export const useParams = vi.fn(() => ({}));
export const Routes = ({ children }: { children: React.ReactNode }) => <div>{children}</div>;
export const Route = ({ element }: { element: React.ReactNode }) => <>{element}</>;
//export const Outlet = () => <div>Outlet</div>;