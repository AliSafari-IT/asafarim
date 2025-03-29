import { render, screen, fireEvent } from '@testing-library/react';
import { BrowserRouter } from 'react-router-dom';
import { describe, it, expect, vi } from 'vitest';
import { expect as extendedExpect } from '@/test-utils/setup-test-env';
import MenuItem from '../MenuItem';
import { IMenuItem } from '@/interfaces/IMenuItem';

// Mock FontAwesomeIcon to avoid issues with SVG rendering in tests
vi.mock('@fortawesome/react-fontawesome', () => ({
  FontAwesomeIcon: ({ className }: { className: string }) => (
    <span data-testid="icon" className={className}></span>
  )
}));

// Mock SubMenu component
vi.mock('../SubMenu', () => ({
  default: ({ items, parentId }: { items: IMenuItem[], parentId: string }) => (
    <div data-testid={`submenu-${parentId}`}>
      {items.map(item => (
        <div key={item.id} data-testid={`submenu-item-${item.id}`}>{item.title}</div>
      ))}
    </div>
  )
}));

describe('MenuItem', () => {
  // Test data
  const linkItem: IMenuItem = {
      id: 'link-item',
      title: 'Link Item',
      to: '/link-path',
      isForNavbar: true,
      name: 'Link Item'
  };

  const buttonItem: IMenuItem = {
    id: 'button-item',
    title: 'Button Item',
    isForNavbar: true   ,
    name: 'Button Item'
  };

  const parentItem: IMenuItem = {
    id: 'parent-item',
    title: 'Parent Item',
    isForNavbar: true,
    name: 'Parent Item',
    subMenu: [
      { id: 'child-1', title: 'Child 1', to: '/child-1', isForNavbar: true, name: 'Child 1' },
      { id: 'child-2', title: 'Child 2', to: '/child-2', isForNavbar: true, name: 'Child 2' }
    ]
  };

  // Helper function to render MenuItem with BrowserRouter
  const renderWithRouter = (ui: React.ReactElement) => {
    return render(
      <BrowserRouter>
        {ui}
      </BrowserRouter>
    );
  };

  it('renders a link when item has a "to" property', () => {
    renderWithRouter(
      <MenuItem 
        item={linkItem} 
        isActive={false} 
        onMenuClick={vi.fn()} 
        onClose={vi.fn()} 
      />
    );
    
    const linkElement = screen.getByRole('menuitem');
    extendedExpect(linkElement).toBeInTheDocument();
    extendedExpect(linkElement).toHaveAttribute('href', '/link-path');
    extendedExpect(linkElement).toHaveTextContent('Link Item');
  });

  it('renders a button when item does not have a "to" property', () => {
    renderWithRouter(
      <MenuItem 
        item={buttonItem} 
        isActive={false} 
        onMenuClick={vi.fn()} 
        onClose={vi.fn()} 
      />
    );
    
    const buttonElement = screen.getByRole('button');
    extendedExpect(buttonElement).toBeInTheDocument();
    extendedExpect(buttonElement).toHaveTextContent('Button Item');
  });

  it('calls onClose when link is clicked', () => {
    const onClose = vi.fn();
    renderWithRouter(
      <MenuItem 
        item={linkItem} 
        isActive={false} 
        onMenuClick={vi.fn()} 
        onClose={onClose} 
      />
    );
    
    const linkElement = screen.getByRole('menuitem');
    fireEvent.click(linkElement);
    
    expect(onClose).toHaveBeenCalledTimes(1);
  });

  it('calls onMenuClick with item id when button is clicked', () => {
    const onMenuClick = vi.fn();
    renderWithRouter(
      <MenuItem 
        item={buttonItem} 
        isActive={false} 
        onMenuClick={onMenuClick} 
        onClose={vi.fn()} 
      />
    );
    
    const buttonElement = screen.getByRole('button');
    fireEvent.click(buttonElement);
    
    expect(onMenuClick).toHaveBeenCalledTimes(1);
    expect(onMenuClick).toHaveBeenCalledWith('button-item');
  });

  it('renders chevron right icon for items with children when not active', () => {
    renderWithRouter(
      <MenuItem 
        item={parentItem} 
        isActive={false} 
        onMenuClick={vi.fn()} 
        onClose={vi.fn()} 
      />
    );
    
    const iconElement = screen.getByTestId('icon');
    extendedExpect(iconElement).toBeInTheDocument();
    extendedExpect(iconElement).toHaveClass('ml-2');
    
    // SubMenu should not be rendered when not active
    const submenu = screen.queryByTestId('submenu-parent-item');
    extendedExpect(submenu).not.toBeInTheDocument();
  });

  it('renders chevron down icon and submenu for items with children when active', () => {
    renderWithRouter(
      <MenuItem 
        item={parentItem} 
        isActive={true} 
        onMenuClick={vi.fn()} 
        onClose={vi.fn()} 
      />
    );
    
    const iconElement = screen.getByTestId('icon');
    extendedExpect(iconElement).toBeInTheDocument();
    extendedExpect(iconElement).toHaveClass('ml-2');
    
    // SubMenu should be rendered when active
    const submenu = screen.getByTestId('submenu-parent-item');
    extendedExpect(submenu).toBeInTheDocument();
    
    // SubMenu should contain child items
    const childItem1 = screen.getByTestId('submenu-item-child-1');
    const childItem2 = screen.getByTestId('submenu-item-child-2');
    extendedExpect(childItem1).toBeInTheDocument();
    extendedExpect(childItem2).toBeInTheDocument();
    extendedExpect(childItem1).toHaveTextContent('Child 1');
    extendedExpect(childItem2).toHaveTextContent('Child 2');
  });

  it('does not render submenu for items without children', () => {
    renderWithRouter(
      <MenuItem 
        item={linkItem} 
        isActive={true} 
        onMenuClick={vi.fn()} 
        onClose={vi.fn()} 
      />
    );
    
    // No icon should be rendered for items without children
    const iconElement = screen.queryByTestId('icon');
    extendedExpect(iconElement).not.toBeInTheDocument();
    
    // No submenu should be rendered for items without children
    const submenu = screen.queryByTestId(/submenu-/);
    extendedExpect(submenu).not.toBeInTheDocument();
  });
});