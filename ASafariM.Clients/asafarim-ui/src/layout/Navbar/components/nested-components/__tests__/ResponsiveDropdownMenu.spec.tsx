import { render, screen, fireEvent } from '@testing-library/react';
import { BrowserRouter } from 'react-router-dom';
import { describe, it, expect, vi, beforeEach } from 'vitest';
import { expect as extendedExpect } from '@/test-utils/setup-test-env';
import ResponsiveDropdownMenu from '../../ResponsiveDropdownMenu';
import { IMenuItem } from '@/interfaces/IMenuItem';

// Mock child components
vi.mock('../../nested-components/DropdownButton', () => ({
  default: ({ title, isOpen, onClick }: { title: string; isOpen: boolean; onClick: () => void }) => (
    <button 
      data-testid="dropdown-button" 
      data-is-open={isOpen} 
      onClick={onClick}
    >
      {title}
    </button>
  )
}));

vi.mock('../../nested-components/DropdownContainer', () => ({
  default: ({ isOpen, children }: { isOpen: boolean; children: React.ReactNode }) => (
    isOpen ? (
      <div data-testid="dropdown-container">
        {children}
      </div>
    ) : null
  )
}));

vi.mock('../../nested-components/MenuItem', () => ({
  default: ({ 
    item, 
    isActive, 
    onMenuClick, 
    onClose 
  }: { 
    item: IMenuItem; 
    isActive: boolean; 
    onMenuClick: (id: string) => void; 
    onClose: () => void 
  }) => (
    <div 
      data-testid={`menu-item-${item.id}`}
      data-active={isActive}
    >
      <span>{item.title}</span>
      <button 
        data-testid={`menu-click-${item.id}`} 
        onClick={() => onMenuClick(item.id)}
      >
        Toggle
      </button>
      <button 
        data-testid={`menu-close-${item.id}`} 
        onClick={onClose}
      >
        Close
      </button>
    </div>
  )
}));

describe('ResponsiveDropdownMenu', () => {
  // Test data
  const mockNavData: IMenuItem[] = [
    {
        id: 'parent',
        title: 'Parent Menu',
        isForNavbar: true,
        subMenu: [
            {
                id: 'child-1', title: 'Child 1', to: '/child-1', isForNavbar: true,
                name: 'Child 1'
            },
            {
                id: 'child-2', title: 'Child 2', to: '/child-2', isForNavbar: true,
                name: 'Child 2'
            },
            {
                id: 'child-3', title: 'Child 3', to: '/child-3', isForNavbar: true,
                name: 'Child 3'
            }
        ],
        name: 'Parent Menu'
    }
  ];

  // Helper function to render component with BrowserRouter
  const renderWithRouter = (ui: React.ReactElement) => {
    return render(
      <BrowserRouter>
        {ui}
      </BrowserRouter>
    );
  };

  // Mock for document.addEventListener
  let addEventListenerSpy: any;
  let removeEventListenerSpy: any;

  beforeEach(() => {
    // Mock addEventListener and removeEventListener
    addEventListenerSpy = vi.spyOn(document, 'addEventListener');
    removeEventListenerSpy = vi.spyOn(document, 'removeEventListener');
  });

  afterEach(() => {
    vi.restoreAllMocks();
  });

  it('renders with dropdown button showing correct title', () => {
    renderWithRouter(
      <ResponsiveDropdownMenu topbarNavData={mockNavData} />
    );
    
    const button = screen.getByTestId('dropdown-button');
    extendedExpect(button).toBeInTheDocument();
    extendedExpect(button).toHaveTextContent('Parent Menu');
    extendedExpect(button).toHaveAttribute('data-is-open', 'false');
  });

  it('does not render dropdown container when closed', () => {
    renderWithRouter(
      <ResponsiveDropdownMenu topbarNavData={mockNavData} />
    );
    
    const container = screen.queryByTestId('dropdown-container');
    extendedExpect(container).not.toBeInTheDocument();
  });

  it('toggles dropdown when button is clicked', () => {
    renderWithRouter(
      <ResponsiveDropdownMenu topbarNavData={mockNavData} />
    );
    
    // Initially closed
    extendedExpect(screen.queryByTestId('dropdown-container')).not.toBeInTheDocument();
    
    // Click to open
    const button = screen.getByTestId('dropdown-button');
    fireEvent.click(button);
    
    // Should be open now
    extendedExpect(screen.getByTestId('dropdown-container')).toBeInTheDocument();
    
    // Click to close
    fireEvent.click(button);
    
    // Should be closed again
    extendedExpect(screen.queryByTestId('dropdown-container')).not.toBeInTheDocument();
  });

  it('renders menu items when open', () => {
    renderWithRouter(
      <ResponsiveDropdownMenu topbarNavData={mockNavData} />
    );
    
    // Open the dropdown
    const button = screen.getByTestId('dropdown-button');
    fireEvent.click(button);
    
    // Check that all menu items are rendered
    mockNavData[0].subMenu?.forEach(item => {
      const menuItem = screen.getByTestId(`menu-item-${item.id}`);
      extendedExpect(menuItem).toBeInTheDocument();
      item?.title && extendedExpect(menuItem).toHaveTextContent(item.title);
      extendedExpect(menuItem).toHaveAttribute('data-active', 'false');
    });
  });

  it('toggles menu item active state when clicked', () => {
    renderWithRouter(
      <ResponsiveDropdownMenu topbarNavData={mockNavData} />
    );
    
    // Open the dropdown
    const button = screen.getByTestId('dropdown-button');
    fireEvent.click(button);
    
    // Click on the first menu item
    const menuItemButton = screen.getByTestId('menu-click-child-1');
    fireEvent.click(menuItemButton);
    
    // First item should now be active
    extendedExpect(screen.getByTestId('menu-item-child-1')).toHaveAttribute('data-active', 'true');
    
    // Other items should still be inactive
    extendedExpect(screen.getByTestId('menu-item-child-2')).toHaveAttribute('data-active', 'false');
    extendedExpect(screen.getByTestId('menu-item-child-3')).toHaveAttribute('data-active', 'false');
    
    // Click on the first menu item again to deactivate
    fireEvent.click(menuItemButton);
    
    // First item should now be inactive
    extendedExpect(screen.getByTestId('menu-item-child-1')).toHaveAttribute('data-active', 'false');
  });

  it('closes dropdown when menu item close is triggered', () => {
    renderWithRouter(
      <ResponsiveDropdownMenu topbarNavData={mockNavData} />
    );
    
    // Open the dropdown
    const button = screen.getByTestId('dropdown-button');
    fireEvent.click(button);
    
    // Click on a menu item to activate it
    const menuItemButton = screen.getByTestId('menu-click-child-1');
    fireEvent.click(menuItemButton);
    
    // Item should be active
    extendedExpect(screen.getByTestId('menu-item-child-1')).toHaveAttribute('data-active', 'true');
    
    // Click close button
    const closeButton = screen.getByTestId('menu-close-child-1');
    fireEvent.click(closeButton);
    
    // Dropdown should be closed
    extendedExpect(screen.queryByTestId('dropdown-container')).not.toBeInTheDocument();
  });

  it('sets up and cleans up event listeners', () => {
    const { unmount } = renderWithRouter(
      <ResponsiveDropdownMenu topbarNavData={mockNavData} />
    );
    
    // Check that event listener was added
    expect(addEventListenerSpy).toHaveBeenCalledWith('mousedown', expect.any(Function));
    
    // Unmount component
    unmount();
    
    // Check that event listener was removed
    expect(removeEventListenerSpy).toHaveBeenCalledWith('mousedown', expect.any(Function));
  });

  it('handles empty nav data gracefully', () => {
    renderWithRouter(
      <ResponsiveDropdownMenu topbarNavData={[]} />
    );
    
    const button = screen.getByTestId('dropdown-button');
    extendedExpect(button).toBeInTheDocument();
    extendedExpect(button).toHaveTextContent(''); // Empty title
    
    // Open the dropdown
    fireEvent.click(button);
    
    // Container should be rendered but empty
    const container = screen.getByTestId('dropdown-container');
    extendedExpect(container).toBeInTheDocument();
    extendedExpect(container.children.length).toBe(0);
  });

  it('applies custom className', () => {
    renderWithRouter(
      <ResponsiveDropdownMenu 
        topbarNavData={mockNavData} 
        className="custom-class"
      />
    );
    
    // Find the root div (parent of dropdown button)
    const rootDiv = screen.getByTestId('dropdown-button').parentElement;
    extendedExpect(rootDiv).toHaveClass('custom-class');
  });
});