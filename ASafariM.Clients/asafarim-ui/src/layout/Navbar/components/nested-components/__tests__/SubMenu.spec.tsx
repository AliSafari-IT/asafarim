import { render, screen, fireEvent } from '@testing-library/react';
import { BrowserRouter } from 'react-router-dom';
import { describe, it, expect, vi } from 'vitest';
import { expect as extendedExpect } from '@/test-utils/setup-test-env';
import SubMenu from '../SubMenu';
import { IMenuItem } from '@/interfaces/IMenuItem';

// Mock MenuItem component
vi.mock('../MenuItem', () => ({
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
      onClick={() => onMenuClick(item.id)}
    >
      {item.title}
      <button data-testid={`close-button-${item.id}`} onClick={onClose}>
        Close
      </button>
    </div>
  )
}));

describe('SubMenu', () => {
  // Test data
  const items: IMenuItem[] = [
    {
        id: 'item-1', title: 'Item 1', to: '/item-1', isForNavbar: true,
        name: 'Item 1'
    },
    { id: 'item-2', title: 'Item 2', to: '/item-2', isForNavbar: true, name: 'Item 2' },
    { id: 'item-3', title: 'Item 3', to: '/item-3', isForNavbar: true, name: 'Item 3' }
  ];

  const parentId = 'parent-menu';

  // Helper function to render SubMenu with BrowserRouter
  const renderWithRouter = (ui: React.ReactElement) => {
    return render(
      <BrowserRouter>
        {ui}
      </BrowserRouter>
    );
  };

  it('renders all menu items', () => {
    renderWithRouter(
      <SubMenu
        items={items}
        parentId={parentId}
        onMenuClick={vi.fn()}
        onClose={vi.fn()}
      />
    );
    
    // Check that all items are rendered
    items.forEach(item => {
      const menuItem = screen.getByTestId(`menu-item-${item.id}`);
      extendedExpect(menuItem).toBeInTheDocument();
      extendedExpect(menuItem).toHaveTextContent(`${item?.title}`);
    });
  });

  it('has the correct CSS classes and parent ID', () => {
    renderWithRouter(
      <SubMenu
        items={items}
        parentId={parentId}
        onMenuClick={vi.fn()}
        onClose={vi.fn()}
      />
    );
    
    // Check that the container has the correct ID and classes
    const container = screen.getByText('Item 1').parentElement;
    extendedExpect(container).toHaveAttribute('id', 'parent-menu');
    extendedExpect(container).toHaveClass('lg:absolute');
    extendedExpect(container).toHaveClass('lg:left-full');
    extendedExpect(container).toHaveClass('lg:top-0');
    extendedExpect(container).toHaveClass('w-full');
    extendedExpect(container).toHaveClass('lg:w-48');
    extendedExpect(container).toHaveClass('bg-[var(--bg-primary)]');
    extendedExpect(container).toHaveClass('shadow-lg');
    extendedExpect(container).toHaveClass('rounded-md');
  });

  it('sets active state on menu item when clicked', () => {
    const onMenuClick = vi.fn();
    renderWithRouter(
      <SubMenu
        items={items}
        parentId={parentId}
        onMenuClick={onMenuClick}
        onClose={vi.fn()}
      />
    );
    
    // Initially, no items should be active
    items.forEach(item => {
      const menuItem = screen.getByTestId(`menu-item-${item.id}`);
      extendedExpect(menuItem).toHaveAttribute('data-active', 'false');
    });
    
    // Click on the first item
    const firstItem = screen.getByTestId('menu-item-item-1');
    fireEvent.click(firstItem);
    
    // First item should now be active, others should not
    extendedExpect(screen.getByTestId('menu-item-item-1')).toHaveAttribute('data-active', 'true');
    extendedExpect(screen.getByTestId('menu-item-item-2')).toHaveAttribute('data-active', 'false');
    extendedExpect(screen.getByTestId('menu-item-item-3')).toHaveAttribute('data-active', 'false');
    
    // onMenuClick should have been called with the item ID
    expect(onMenuClick).toHaveBeenCalledTimes(1);
    expect(onMenuClick).toHaveBeenCalledWith('item-1');
  });

  it('toggles active state when the same item is clicked twice', () => {
    renderWithRouter(
      <SubMenu
        items={items}
        parentId={parentId}
        onMenuClick={vi.fn()}
        onClose={vi.fn()}
      />
    );
    
    // Click on the first item to activate it
    const firstItem = screen.getByTestId('menu-item-item-1');
    fireEvent.click(firstItem);
    
    // First item should now be active
    extendedExpect(firstItem).toHaveAttribute('data-active', 'true');
    
    // Click on the first item again to deactivate it
    fireEvent.click(firstItem);
    
    // First item should no longer be active
    extendedExpect(firstItem).toHaveAttribute('data-active', 'false');
  });

  it('changes active item when a different item is clicked', () => {
    renderWithRouter(
      <SubMenu
        items={items}
        parentId={parentId}
        onMenuClick={vi.fn()}
        onClose={vi.fn()}
      />
    );
    
    // Click on the first item to activate it
    const firstItem = screen.getByTestId('menu-item-item-1');
    fireEvent.click(firstItem);
    
    // First item should now be active
    extendedExpect(firstItem).toHaveAttribute('data-active', 'true');
    
    // Click on the second item
    const secondItem = screen.getByTestId('menu-item-item-2');
    fireEvent.click(secondItem);
    
    // Second item should now be active, first item should not
    extendedExpect(firstItem).toHaveAttribute('data-active', 'false');
    extendedExpect(secondItem).toHaveAttribute('data-active', 'true');
  });

  it('calls onClose when close button is clicked', () => {
    const onClose = vi.fn();
    renderWithRouter(
      <SubMenu
        items={items}
        parentId={parentId}
        onMenuClick={vi.fn()}
        onClose={onClose}
      />
    );
    
    // Click the close button on the first item
    const closeButton = screen.getByTestId('close-button-item-1');
    fireEvent.click(closeButton);
    
    // onClose should have been called
    expect(onClose).toHaveBeenCalledTimes(1);
  });

  it('handles empty items array gracefully', () => {
    renderWithRouter(
      <SubMenu
        items={[]}
        parentId={parentId}
        onMenuClick={vi.fn()}
        onClose={vi.fn()}
      />
    );
    
    // Container should still be rendered
    const container = screen.getByTestId('submenu-container');
    extendedExpect(container).toBeInTheDocument();
    extendedExpect(container).toHaveAttribute('id', 'parent-menu');
    
    // No menu items should be rendered
    const menuItems = screen.queryAllByTestId(/menu-item-/);
    expect(menuItems.length).toBe(0);
  });
});