import React from 'react';
import { DDMenu, MenuItem } from '@asafarim/dd-menu';
import '@asafarim/dd-menu/dist/index.css';

const TestComponent: React.FC = () => {
  const menuItems: MenuItem[] = [
    { 
      id: "1", 
      label: "Dashboard", 
      link: "/dashboard",
      icon: "🏠"
    },
    {
      id: "2",
      label: "Professional Network",
      icon: "🔗",
      children: [
        { id: "2-1", label: "LinkedIn Profile", link: "/linkedin", icon: "💼" },
        { id: "2-2", label: "Twitter Feed", link: "/twitter", icon: "🐦" },
        { id: "2-3", label: "GitHub Repositories", link: "/github", icon: "👨‍💻" },
        { id: "2-4", label: "Stack Overflow", link: "/stackoverflow", icon: "📚" },
      ],
    },
    { 
      id: "3", 
      label: "About Me", 
      link: "/about",
      icon: "ℹ️"
    },
    { 
      id: "4", 
      label: "Technical Blog", 
      link: "/blog",
      icon: "📝"
    },
    { 
      id: "5", 
      label: "Portfolio", 
      link: "/portfolio",
      icon: "🎨"
    },
    {
      id: "6",
      label: "Contact & Services",
      icon: "📧",
      children: [
        { id: "6-1", label: "Send Message", link: "/contact", icon: "💬" },
        { id: "6-2", label: "Consulting Services", link: "/consulting", icon: "🤝" },
        { id: "6-3", label: "Schedule Meeting", link: "/calendar", icon: "📅" },
      ],
    },
  ];

  return (
    <div style={{ 
      padding: '40px', 
      background: 'linear-gradient(135deg, #f8fafc 0%, #e2e8f0 100%)', 
      minHeight: '100vh',
      fontFamily: '-apple-system, BlinkMacSystemFont, "Segoe UI", system-ui, sans-serif'
    }}>
      <div style={{ 
        maxWidth: '1200px', 
        margin: '0 auto',
        textAlign: 'center',
        marginBottom: '60px'
      }}>
        <h1 style={{ 
          fontSize: '3rem', 
          fontWeight: '700', 
          color: '#0f172a',
          marginBottom: '16px',
          letterSpacing: '-0.02em'
        }}>
          Professional DDMenu Showcase
        </h1>
        <p style={{ 
          fontSize: '1.25rem', 
          color: '#475569',
          maxWidth: '600px',
          margin: '0 auto',
          lineHeight: '1.6'
        }}>
          Experience our premium dropdown menu component with enhanced design, 
          smooth animations, and professional styling for both light and dark themes.
        </p>
      </div>
      
      <div style={{ 
        display: 'grid', 
        gridTemplateColumns: 'repeat(auto-fit, minmax(400px, 1fr))', 
        gap: '60px',
        alignItems: 'start'
      }}>
        <div style={{ 
          background: 'rgba(255, 255, 255, 0.8)', 
          padding: '40px',
          borderRadius: '24px',
          backdropFilter: 'blur(20px)',
          border: '1px solid rgba(255, 255, 255, 0.3)',
          boxShadow: '0 20px 25px -5px rgba(0, 0, 0, 0.1), 0 10px 10px -5px rgba(0, 0, 0, 0.04)'
        }}>
          <h2 style={{ 
            fontSize: '2rem', 
            fontWeight: '600', 
            color: '#0f172a',
            marginBottom: '24px',
            textAlign: 'center'
          }}>
            Light Theme
          </h2>
          <div style={{ display: 'flex', justifyContent: 'center' }}>
            <DDMenu items={menuItems} theme="light" />
          </div>
        </div>
        
        <div style={{ 
          background: 'linear-gradient(135deg, #0f172a 0%, #1e293b 100%)', 
          padding: '40px',
          borderRadius: '24px',
          border: '1px solid #334155',
          boxShadow: '0 20px 25px -5px rgba(0, 0, 0, 0.4), 0 10px 10px -5px rgba(0, 0, 0, 0.2)'
        }}>
          <h2 style={{ 
            fontSize: '2rem', 
            fontWeight: '600', 
            color: '#f8fafc',
            marginBottom: '24px',
            textAlign: 'center'
          }}>
            Dark Theme
          </h2>
          <div style={{ display: 'flex', justifyContent: 'center' }}>
            <DDMenu items={menuItems} theme="dark" />
          </div>
        </div>
      </div>

      <div style={{
        marginTop: '80px',
        textAlign: 'center',
        background: 'rgba(255, 255, 255, 0.6)',
        padding: '40px',
        borderRadius: '20px',
        backdropFilter: 'blur(20px)',
        border: '1px solid rgba(255, 255, 255, 0.3)'
      }}>
        <h3 style={{ 
          fontSize: '1.5rem', 
          fontWeight: '600', 
          color: '#0f172a',
          marginBottom: '16px'
        }}>
          Key Features
        </h3>
        <div style={{ 
          display: 'grid', 
          gridTemplateColumns: 'repeat(auto-fit, minmax(250px, 1fr))', 
          gap: '24px',
          marginTop: '32px'
        }}>
          {[
            '🎨 Modern glassmorphism design',
            '✨ Smooth micro-interactions',
            '🌓 Light & dark theme support',
            '📱 Mobile-responsive layout',
            '♿ Enhanced accessibility',
            '🎯 TypeScript support'
          ].map((feature, index) => (
            <div key={index} style={{
              padding: '20px',
              background: 'rgba(255, 255, 255, 0.5)',
              borderRadius: '12px',
              border: '1px solid rgba(255, 255, 255, 0.3)',
              color: '#475569',
              fontSize: '14px',
              fontWeight: '500'
            }}>
              {feature}
            </div>
          ))}
        </div>
      </div>
    </div>
  );
};

export default TestComponent;
