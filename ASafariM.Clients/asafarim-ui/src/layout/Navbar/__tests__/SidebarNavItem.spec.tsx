import { describe, it, expect, vi, beforeEach } from 'vitest';
import { render, screen, fireEvent } from '@testing-library/react';
import { BrowserRouter } from 'react-router-dom';
import SidebarNavItem from '../SidebarNavItem';
import { INavItem } from '@/interfaces/INavItem';

const mockNavigate = vi.fn();

// Mock react-router-dom
vi.mock('react-router-dom', () => ({
  ...vi.importActual('react-router-dom') as any,
  BrowserRouter: ({ children }: { children: React.ReactNode }) => <div>{children}</div>,
  Link: ({ children, to }: { children: React.ReactNode; to: string }) => (
    <a href={to}>{children}</a>
  ),
  useNavigate: () => mockNavigate
}));

describe('SidebarNavItem', () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  const mockNavData: INavItem[] = [
    {
      id: 'parent',
      title: 'Parent Item',
      to: '#',
      icon: <span>🔍</span>,
      name: 'parent',
      subMenu: [
        {
          id: 'child1',
          title: 'Child Item 1',
          to: '/child1',
          icon: <span>📄</span>,
          name: 'child1'
        },
        {
          id: 'child2',
          title: 'Child Item 2',
          to: '/child2',
          icon: <span>📄</span>,
          name: 'child2'
        }
      ]
    },
    {
      id: 'standalone',
      title: 'Standalone Item',
      to: '/standalone',
      icon: <span>🔗</span>,
      className: 'emphasized',
      name: 'standalone'
    }
  ];

  const renderComponent = (props = {}) => {
    return render(
      <BrowserRouter>
        <SidebarNavItem sidebarNavData={mockNavData} {...props} />
      </BrowserRouter>
    );
  };

  it('renders all nav items', () => {
    renderComponent();
    expect(screen.getByText('Parent Item')).toBeInTheDocument();
    expect(screen.getByText('Standalone Item')).toBeInTheDocument();
  });

  it('toggles submenu on click', async () => {
    renderComponent();
    const parentItem = screen.getByText('Parent Item');
    
    // Initially, child items should not be visible
    expect(screen.queryByText('Child Item 1')).not.toBeInTheDocument();
    
    // Click to open submenu
    fireEvent.click(parentItem);
    expect(screen.getByText('Child Item 1')).toBeInTheDocument();
    expect(screen.getByText('Child Item 2')).toBeInTheDocument();
    
    // Click again to close
    fireEvent.click(parentItem);
    expect(screen.queryByText('Child Item 1')).not.toBeInTheDocument();
  });

  it('navigates when clicking a link item', () => {
    renderComponent();
    const standaloneItem = screen.getByText('Standalone Item');
    fireEvent.click(standaloneItem);
    expect(mockNavigate).toHaveBeenCalledWith('/standalone');
  });

  it('applies emphasized styling', () => {
    renderComponent();
    const standaloneItem = screen.getByText('Standalone Item').closest('div');
    expect(standaloneItem?.className).toContain('emphasized');
  });

  it('renders icons correctly', () => {
    renderComponent();
    const icons = screen.getAllByText(/[🔍🔗]/);
    expect(icons).toHaveLength(2);
  });

  it('handles custom onClick events', () => {
    const mockOnClick = vi.fn();
    const customNavData = [{
      id: 'custom',
      title: 'Custom Item',
      to: '#',
      onClick: mockOnClick,
      name: 'custom'
    }];
    
    render(
      <BrowserRouter>
        <SidebarNavItem sidebarNavData={customNavData} />
      </BrowserRouter>
    );
    
    const customItem = screen.getByText('Custom Item');
    fireEvent.click(customItem);
    expect(mockOnClick).toHaveBeenCalled();
  });

  it('closes other dropdowns when opening a new one', () => {
    const multiLevelData: INavItem[] = [
      {
        id: 'parent1',
        title: 'Parent 1',
        to: '#',
        name: 'parent1',
        subMenu: [{
          id: 'child1', title: 'Child 1', to: '/child1',
          name: 'child1'
        }]
      },
      {
        id: 'parent2',
        title: 'Parent 2',
        to: '#',
        name: 'parent2',
        subMenu: [{
          id: 'child2', title: 'Child 2', to: '/child2',
          name: 'child2'
        }]
      }
    ];
    
    render(
      <BrowserRouter>
        <SidebarNavItem sidebarNavData={multiLevelData} />
      </BrowserRouter>
    );
    
    // Open first dropdown
    fireEvent.click(screen.getByText('Parent 1'));
    expect(screen.getByText('Child 1')).toBeInTheDocument();
    
    // Open second dropdown
    fireEvent.click(screen.getByText('Parent 2'));
    expect(screen.getByText('Child 2')).toBeInTheDocument();
    expect(screen.queryByText('Child 1')).not.toBeInTheDocument();
  });

  it('handles nested levels correctly', () => {
    const nestedData: INavItem[] = [{
      id: 'level1',
      title: 'Level 1',
      to: '#',
      name: 'level1',
      subMenu: [{
        id: 'level2',
        title: 'Level 2',
        to: '#',
        name: 'level2',
        subMenu: [{
          id: 'level3',
          title: 'Level 3',
          to: '/level3',
          name: 'level3'
        }]
      }]
    }];
    
    render(
      <BrowserRouter>
        <SidebarNavItem sidebarNavData={nestedData} />
      </BrowserRouter>
    );
    
    // Click through levels
    fireEvent.click(screen.getByText('Level 1'));
    expect(screen.getByText('Level 2')).toBeInTheDocument();
    
    fireEvent.click(screen.getByText('Level 2'));
    expect(screen.getByText('Level 3')).toBeInTheDocument();
  });
});