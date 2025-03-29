import React from 'react';
import { render, screen } from '@testing-library/react';
import { BrowserRouter } from 'react-router-dom';
import { describe, it, expect, vi, beforeEach } from 'vitest';
import * as matchers from '@testing-library/jest-dom/matchers';
import Footer from './Footer';
import { getAllMdFiles } from '@/utils/mdFilesUtils';

// Extend Vitest's expect with Jest DOM matchers
expect.extend(matchers);

// Mock the getAllMdFiles utility
vi.mock('@/utils/mdFilesUtils', () => ({
  getAllMdFiles: vi.fn()
}));

describe('Footer', () => {
  beforeEach(() => {
    // Mock the return value of getAllMdFiles
    (getAllMdFiles as ReturnType<typeof vi.fn>).mockReturnValue({
      legalDocs: {
        subMenu: [
          {
            id: 'terms',
            title: 'Terms of Service',
            to: '/legal/terms',
          },
          {
            id: 'privacy',
            title: 'Privacy Policy',
            to: '/legal/privacy',
          },
          {
            id: 'cookies',
            title: 'Cookie Policy',
            to: '/legal/cookies',
          }
        ]
      }
    });
  });

  it('renders the footer component', () => {
    render(
      <BrowserRouter>
        <Footer />
      </BrowserRouter>
    );
    
    // Check that the footer element exists
    const footerElement = screen.getByRole('contentinfo');
    expect(footerElement).toBeInTheDocument();
  });

  it('displays the current year in the copyright notice', () => {
    render(
      <BrowserRouter>
        <Footer />
      </BrowserRouter>
    );
    
    const currentYear = new Date().getFullYear();
    const copyrightText = screen.getByText(new RegExp(`${currentYear} ASafariM`));
    expect(copyrightText).toBeInTheDocument();
  });

  it('renders all legal document links', () => {
    render(
      <BrowserRouter>
        <Footer />
      </BrowserRouter>
    );
    
    // Check for each legal document link
    const termsLink = screen.getByText('Terms of Service');
    expect(termsLink).toBeInTheDocument();
    expect(termsLink).toHaveAttribute('href', '/legal/terms');
    
    const privacyLink = screen.getByText('Privacy Policy');
    expect(privacyLink).toBeInTheDocument();
    expect(privacyLink).toHaveAttribute('href', '/legal/privacy');
    
    const cookiesLink = screen.getByText('Cookie Policy');
    expect(cookiesLink).toBeInTheDocument();
    expect(cookiesLink).toHaveAttribute('href', '/legal/cookies');
  });

  it('renders the contact link', () => {
    render(
      <BrowserRouter>
        <Footer />
      </BrowserRouter>
    );
    
    const contactLink = screen.getByText('Contact');
    expect(contactLink).toBeInTheDocument();
    expect(contactLink).toHaveAttribute('href', '/contact');
  });

  it('renders dividers between links', () => {
    render(
      <BrowserRouter>
        <Footer />
      </BrowserRouter>
    );
    
    // Count the number of dividers (|)
    const dividers = screen.getAllByText('|');
    
    // There should be 3 dividers: 2 between the 3 legal links and 1 before Contact
    expect(dividers).toHaveLength(3);
  });

  it('handles empty legal docs gracefully', () => {
    // Mock empty legal docs
    (getAllMdFiles as ReturnType<typeof vi.fn>).mockReturnValue({
      legalDocs: {
        subMenu: []
      }
    });
    
    render(
      <BrowserRouter>
        <Footer />
      </BrowserRouter>
    );
    
    // Should still render the footer and contact link
    expect(screen.getByRole('contentinfo')).toBeInTheDocument();
    expect(screen.getByText('Contact')).toBeInTheDocument();
  });
});