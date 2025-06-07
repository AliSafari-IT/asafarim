import { render, screen, waitFor, fireEvent } from '@testing-library/react';
import { describe, it, beforeEach, vi, expect } from 'vitest';
import ViewProject from '../Project/ViewProject';
import { BrowserRouter } from 'react-router-dom';
import { ThemeProvider } from '@/contexts/ThemeContext';
import { ReactNode } from 'react';

const mockNavigate = vi.fn();
vi.mock('react-router-dom', async () => {
  const actual = await vi.importActual<typeof import('react-router-dom')>('react-router-dom');
  return {
    ...actual,
    useNavigate: () => mockNavigate,
    useParams: () => ({ id: 'project1' })
  };
});

vi.mock('@/contexts/AuthContext', () => ({
  useAuth: () => ({
    authenticated: true,
    authenticatedUser: {
      id: 'user123',
      firstName: 'Test',
      lastName: 'User',
      isAdmin: true
    }
  })
}));

vi.mock('@/utils/logger', () => ({
  logger: {
    debug: vi.fn(),
    error: vi.fn()
  }
}));

vi.mock('@/api/entityServices', () => ({
  default: {
    fetchEntityById: vi.fn().mockResolvedValue({
      id: 'project1',
      name: 'Test Project',
      description: 'A great test project',
      startDate: '2023-01-01',
      endDate: '2023-12-31',
      budget: 1000,
      ownerId: 'user123',
      visibility: 0,
      status: 1
    }),
    fetchEntityRepoLinks: vi.fn().mockResolvedValue([
      'https://github.com/test/test-repo'
    ])
  }
}));

vi.mock('@/components/Loading/Loading', () => ({
  default: ({ message }: { message: string }) => <div>{message}</div>
}));

vi.mock('@/components/Notification/Notification', () => ({
  default: ({ text }: { text: string }) => <div>{text}</div>
}));

vi.mock('@/components/Toolbars/Toolbar', () => ({
  default: ({ children }: { children: ReactNode }) => <div>{children}</div>
}));

vi.mock('@/layout/Wrapper/Wrapper', () => ({
  default: ({ children }: { children: ReactNode }) => (
    <div data-testid="mocked-wrapper">{children}</div>
  )
}));

describe('ViewProject', () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  it('renders loading state initially', () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <ViewProject />
        </ThemeProvider>
      </BrowserRouter>
    );
    expect(screen.getByText('Loading project details...')).toBeInTheDocument();
  });

  it('displays project details after loading', async () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <ViewProject />
        </ThemeProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      expect(screen.getByText('Test Project')).toBeInTheDocument();
      expect(screen.getByText('A great test project')).toBeInTheDocument();
      expect(screen.getByText('1/1/2023')).toBeInTheDocument(); // localized start date
      expect(screen.getByText('31/12/2023')).toBeInTheDocument(); // Fix: use the actual date format shown in the UI
    });
  });

  it('shows repository link if available', async () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <ViewProject />
        </ThemeProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      expect(screen.getByText('https://github.com/test/test-repo')).toBeInTheDocument();
    });
  });

  it('navigates back when back button is clicked', async () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <ViewProject />
        </ThemeProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      const backButton = screen.getByRole('button', { name: /back/i });
      fireEvent.click(backButton);
      expect(mockNavigate).toHaveBeenCalledWith(-1);
    });
  });

  it('navigates to edit page if edit button is clicked', async () => {
    render(
      <BrowserRouter>
        <ThemeProvider>
          <ViewProject />
        </ThemeProvider>
      </BrowserRouter>
    );

    await waitFor(() => {
      const editButton = screen.getByRole('button', { name: /edit project/i });
      fireEvent.click(editButton);
      expect(mockNavigate).toHaveBeenCalledWith('/projects/edit/project1');
    });
  });
});
