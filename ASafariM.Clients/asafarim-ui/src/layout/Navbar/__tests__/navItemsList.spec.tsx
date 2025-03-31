import { describe, it, expect } from 'vitest';
import navItems from '../navItemsList';
import { IMenuItem } from '@/interfaces/IMenuItem';

describe('navItemsList', () => {
  it('should contain all main navigation categories', () => {
    const expectedIds = [
      'blog',
      'tech-docs',
      'books',
      'essential-insights',
      'legal-docs',
      'changelogs',
      'dashboard',
      'about',
      'contact'
    ];
    
    expect(navItems.map(item => item.id)).toEqual(expect.arrayContaining(expectedIds));
  });

  it('should have properly configured dashboard menu', () => {
    const dashboardItem = navItems.find(item => item.id === 'dashboard') as IMenuItem;
    
    expect(dashboardItem.subMenu).toHaveLength(4);
    expect(dashboardItem.subMenu?.map(sub => sub.id)).toEqual([
      'system-health',
      'dashboard-main',
      'projects',
      'users'
    ]);
    
    expect(dashboardItem.subMenu?.[0]).toMatchObject({
      title: 'System Health Status',
      to: '/system-health',
      isForNavbar: true
    });
  });

  it('should have valid MD chapter structure', () => {
    const techDocsItem = navItems.find(item => item.id === 'tech-docs') as IMenuItem;
    const firstChapter = techDocsItem.subMenu?.[0]?.subMenu?.[0];
    
    expect(firstChapter).toMatchObject({
      id: 'tech-docs-backend-intro',
      title: 'backend intro'
    });
    
    expect(firstChapter?.to).toBe('/tech-docs/Backend/backend-intro');
  });

  it('should have properly configured external links', () => {
    const blogItem = navItems.find(item => item.id === 'blog') as IMenuItem;
    const booksItem = navItems.find(item => item.id === 'books') as IMenuItem;
    
    expect(blogItem.to).toBe('//https://techdocs.asafarim.com/blog');
    expect(booksItem.to).toBe('//books.asafarim.com');
  });

  it('should have valid essential insights structure', () => {
    const insightsItem = navItems.find(item => item.id === 'essential-insights') as IMenuItem;
    
    // Check that the Essential Insights item exists and has the correct properties
    expect(insightsItem).toBeDefined();
    expect(insightsItem.title).toBe('Essential Insights');
    expect(insightsItem.isForNavbar).toBe(true);
    
    // Verify that it has a subMenu array (which is now dynamically generated)
    expect(insightsItem.subMenu).toBeDefined();
    expect(Array.isArray(insightsItem.subMenu)).toBe(true);
  });

  it('should have proper navbar flags', () => {
    // Top-level navigation items that should be in navbar
    const navbarItems = ['about', 'contact', 'dashboard'];
    navbarItems.forEach(id => {
      const item = navItems.find(item => item.id === id);
      expect(item?.isForNavbar).toBe(true);
    });

    // Dashboard submenu items should be in navbar
    const dashboardItem = navItems.find(item => item.id === 'dashboard') as IMenuItem;
    dashboardItem.subMenu?.forEach(item => {
      expect(item.isForNavbar).toBe(true);
    });
  });
});