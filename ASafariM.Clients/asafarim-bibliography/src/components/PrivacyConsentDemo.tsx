import { useState, useEffect } from 'react';
import { 
  ConsentProvider, 
  ConsentBanner, 
  ConsentModal,
  useConsent,
  PrivacyConsentConfig,
  ConsentRecord,
  applyConsentTheme,
  getDarkTheme,
  type ConsentCategory
} from '@asafarim/react-privacy-consent';
import '@asafarim/react-privacy-consent/styles.css';

// IMPORTANT: Define configuration outside the component to ensure it's stable across renders
// This prevents recreation of the config object on each render which can cause consent to reset
const demoConsentConfig: PrivacyConsentConfig = {
  settings: {
    categories: [
      {
        id: 'necessary',
        name: 'Necessary Cookies',
        description: 'Essential cookies required for basic website functionality. These cannot be disabled.',
        type: 'necessary',
        required: true,
        defaultValue: true
      },
      {
        id: 'analytics',
        name: 'Analytics & Performance',
        description: 'Help us understand how visitors interact with our website by collecting anonymous usage data.',
        type: 'analytics',
        required: false,
        defaultValue: false
      },
      {
        id: 'marketing',
        name: 'Marketing & Advertising',
        description: 'Used to deliver personalized advertisements and measure campaign effectiveness.',
        type: 'marketing',
        required: false,
        defaultValue: false
      },
      {
        id: 'preferences',
        name: 'Preferences',
        description: 'Remember your settings and preferences to provide a customized experience.',
        type: 'preferences',
        required: false,
        defaultValue: false
      }
    ],
    version: '1.0.0',
    expirationDays: 365,
    storageKey: 'privacy-consent-demo',
    showDeclineAll: true,
    showAcceptAll: true,
    showManagePreferences: true,
    autoShowDelay: 1000,
    respectDoNotTrack: true
  },
  
  banner: {
    position: 'bottom',
    layout: 'banner',
    showCloseButton: true,
    showCompanyLogo: false,
    blocking: false,
    animation: true,
    backdrop: false
  },

  texts: {
    title: 'We value your privacy',
    description: 'We use cookies to enhance your browsing experience, serve personalized ads or content, and analyze our traffic. By clicking "Accept All", you consent to our use of cookies.',
    acceptAllText: 'Accept All',
    rejectAllText: 'Reject All',
    managePreferencesText: 'Customize Settings',
    savePreferencesText: 'Save Preferences',
    closeText: 'Close',
    learnMoreText: 'Learn More',
    poweredByText: 'Powered by @asafarim/react-privacy-consent'
  },

  onConsentChange: (consent: ConsentRecord) => {
    console.log('Consent changed:', consent);
  },
  onBannerShow: () => {
    console.log('Banner shown');
  },
  onBannerHide: () => {
    console.log('Banner hidden');
  }
};

// Main demo content component
function DemoContent() {  const { 
    hasConsent, 
    showPreferences, 
    hidePreferences,
    isPreferencesVisible,
    resetConsent, 
    updateConsent,
    acceptAll,
    rejectAll,
    getConsent,
    getAllConsent,
    config
  } = useConsent();

  const [showConsentDebug, setShowConsentDebug] = useState(false);
  const [isModalOpen, setIsModalOpen] = useState(false);

  // Close our custom modal when the preferences modal is closed
  useEffect(() => {
    if (!isPreferencesVisible && isModalOpen) {
      setIsModalOpen(false);
    }
  }, [isPreferencesVisible, isModalOpen]);

  const handleOpenModal = () => {
    setIsModalOpen(true);
    showPreferences(); // This ensures the consent system knows the preferences modal is open
  };

  const handleCategoryToggle = (categoryId: string) => {
    const currentStatus = getConsent(categoryId);
    const isCurrentlyAccepted = currentStatus === 'accepted';
    updateConsent(categoryId, !isCurrentlyAccepted);
  };

  const getConsentStatusDisplay = (categoryId: string): string => {
    const status = getConsent(categoryId);
    switch (status) {
      case 'accepted': return '✅ Accepted';
      case 'rejected': return '❌ Rejected';
      case 'pending': return '⏳ Pending';
      default: return '❓ Unknown';
    }
  };

  return (
    <div className="privacy-consent-demo">
      {/* Demo Header */}
      <header className="demo-header">
        <h1>@asafarim/react-privacy-consent Demo</h1>
        <p>A comprehensive GDPR/CCPA compliant privacy consent management system for React applications</p>
        <div className="demo-badges">
          <span className="badge">⚛️ React 18+</span>
          <span className="badge">📘 TypeScript</span>
          <span className="badge">🛡️ GDPR Ready</span>
          <span className="badge">🎨 Customizable</span>
          <span className="badge">♿ Accessible</span>
        </div>
      </header>

      {/* Demo Navigation */}
      <nav className="demo-nav">
        <div className="demo-controls">          <button onClick={() => showPreferences()} className="btn btn-secondary">
            🛠️ Manage Preferences
          </button>
          <button onClick={resetConsent} className="btn btn-danger">
            🔄 Reset Consent
          </button>
          <button 
            onClick={() => setShowConsentDebug(!showConsentDebug)} 
            className="btn btn-info"
          >
            🐛 {showConsentDebug ? 'Hide' : 'Show'} Debug Info
          </button>
          <button onClick={handleOpenModal} className="btn btn-primary">
            📋 Open Modal
          </button>
        </div>
      </nav>

      {/* Consent Status Display */}
      <section className="demo-section">
        <h2>Current Consent Status</h2>
        <div className="consent-status-grid">
          {config.settings.categories.map((category: ConsentCategory) => (
            <div key={category.id} className="consent-status-card">
              <div className="status-header">
                <h3>{category.name}</h3>
                <span className={`status-badge status-${getConsent(category.id)}`}>
                  {getConsentStatusDisplay(category.id)}
                </span>
              </div>
              <p className="status-description">{category.description}</p>
              <div className="status-controls">
                <button
                  onClick={() => handleCategoryToggle(category.id)}
                  disabled={category.required}
                  className={`btn ${hasConsent(category.id) ? 'btn-success' : 'btn-outline'}`}
                >
                  {hasConsent(category.id) ? 'Enabled' : 'Disabled'}
                  {category.required && ' (Required)'}
                </button>
              </div>
            </div>
          ))}
        </div>
      </section>

      {/* Interactive Actions */}
      <section className="demo-section">
        <h2>Interactive Actions</h2>
        <div className="action-grid">
          <div className="action-card">
            <h3>Quick Actions</h3>
            <div className="action-buttons">
              <button onClick={acceptAll} className="btn btn-success">
                ✅ Accept All Cookies
              </button>
              <button onClick={rejectAll} className="btn btn-danger">
                ❌ Reject All Non-Essential
              </button>
              <button onClick={() => setIsModalOpen(true)} className="btn btn-primary">
                📋 Open Preferences Modal
              </button>
            </div>
          </div>

          <div className="action-card">
            <h3>Theme Controls</h3>
            <p>Apply different themes to see how the consent components look:</p>
            <div className="action-buttons">
              <button 
                onClick={() => {
                  console.log('Applying light theme...');
                  const lightTheme = {
                    primaryColor: '#3b82f6',
                    backgroundColor: '#ffffff',
                    textColor: '#1f2937',
                    borderRadius: '8px',
                    secondaryColor: '#6b7280',
                    borderColor: '#d1d5db',
                    fontFamily: 'system-ui',
                    fontSize: '14px',
                    buttonStyle: 'solid' as 'solid' | 'outlined' | 'ghost', // Fix type issue
                    shadow: true
                  };
                  console.log('Light theme config:', lightTheme);
                  applyConsentTheme(lightTheme);
                  
                  // Verify CSS variables were set
                  setTimeout(() => {
                    const root = document.documentElement;
                    console.log('CSS variables after light theme applied:', {
                      primaryColor: root.style.getPropertyValue('--consent-primary-color'),
                      backgroundColor: root.style.getPropertyValue('--consent-background-color'),
                      textColor: root.style.getPropertyValue('--consent-text-color')
                    });
                  }, 100);
                }}
                className="btn btn-secondary"
              >
                🌞 Light Theme
              </button>
              <button 
                onClick={() => {
                  console.log('Applying dark theme...');
                  const darkTheme = getDarkTheme();
                  console.log('Dark theme config:', darkTheme);
                  applyConsentTheme(darkTheme);
                  
                  // Verify CSS variables were set
                  setTimeout(() => {
                    const root = document.documentElement;
                    console.log('CSS variables after dark theme applied:', {
                      primaryColor: root.style.getPropertyValue('--consent-primary-color'),
                      backgroundColor: root.style.getPropertyValue('--consent-background-color'),
                      textColor: root.style.getPropertyValue('--consent-text-color')
                    });
                  }, 100);
                }}
                className="btn btn-secondary"
              >
                🌙 Dark Theme
              </button>
            </div>
            <div className="action-buttons" style={{ marginTop: '1rem' }}>
              <button 
                onClick={() => {
                  // Reset consent to force show banner
                  resetConsent();
                  console.log('Consent reset - banner should appear');
                }}
                className="btn btn-primary"
              >
                🔄 Reset Consent (Show Banner)
              </button>
              <button 
                onClick={() => {
                  showPreferences();
                  console.log('Preferences modal opened');
                }}
                className="btn btn-primary"
              >
                ⚙️ Show Preferences Modal
              </button>
            </div>
            <p style={{ fontSize: '0.875rem', color: '#6b7280', marginTop: '0.5rem' }}>
              💡 Reset consent or open preferences to see theme changes applied to the consent UI
            </p>
          </div>
        </div>
      </section>

      {/* Real-world Usage Examples */}
      <section className="demo-section">
        <h2>Real-world Usage Examples</h2>
        <div className="usage-examples">
          <div className="example-card">
            <h3>📊 Analytics Integration</h3>
            <pre className="code-example">
{`// Check if analytics consent is given
if (hasConsent('analytics')) {
  // Initialize Google Analytics
  gtag('config', 'GA_MEASUREMENT_ID');
  
  // Track page view
  gtag('event', 'page_view', {
    page_title: document.title,
    page_location: window.location.href
  });
}`}
            </pre>
            <div className="example-status">
              Status: {hasConsent('analytics') ? 
                <span className="status-enabled">Analytics Enabled ✅</span> : 
                <span className="status-disabled">Analytics Disabled ❌</span>
              }
            </div>
          </div>

          <div className="example-card">
            <h3>📢 Marketing Pixels</h3>
            <pre className="code-example">
{`// Conditional marketing pixel loading
if (hasConsent('marketing')) {
  // Load Facebook Pixel
  fbq('init', 'YOUR_PIXEL_ID');
  fbq('track', 'PageView');
  
  // Load Google Ads conversion tracking
  gtag('config', 'AW-CONVERSION_ID');
}`}
            </pre>
            <div className="example-status">
              Status: {hasConsent('marketing') ? 
                <span className="status-enabled">Marketing Enabled ✅</span> : 
                <span className="status-disabled">Marketing Disabled ❌</span>
              }
            </div>
          </div>

          <div className="example-card">
            <h3>🎯 Personalization Features</h3>
            <pre className="code-example">
{`// Enable personalization features
if (hasConsent('preferences')) {
  // Save user preferences
  localStorage.setItem('theme', 'dark');
  localStorage.setItem('language', 'en-US');
  
  // Enable recommendations
  loadPersonalizedContent();
}`}
            </pre>
            <div className="example-status">
              Status: {hasConsent('preferences') ? 
                <span className="status-enabled">Personalization Enabled ✅</span> : 
                <span className="status-disabled">Personalization Disabled ❌</span>
              }
            </div>
          </div>
        </div>
      </section>

      {/* Package Features */}
      <section className="demo-section">
        <h2>Package Features</h2>
        <div className="features-grid">
          <div className="feature-card">
            <h3>🏛️ Legal Compliance</h3>
            <ul>
              <li>✅ GDPR Article 7 compliant</li>
              <li>✅ CCPA Section 1798.135 ready</li>
              <li>✅ Consent versioning & records</li>
              <li>✅ Right to withdraw consent</li>
              <li>✅ Do Not Track support</li>
            </ul>
          </div>

          <div className="feature-card">
            <h3>🎨 Customization</h3>
            <ul>
              <li>✅ Multiple banner positions</li>
              <li>✅ Custom themes & colors</li>
              <li>✅ Flexible layouts</li>
              <li>✅ CSS variable integration</li>
              <li>✅ Mobile responsive</li>
            </ul>
          </div>

          <div className="feature-card">
            <h3>🔧 Developer Experience</h3>
            <ul>
              <li>✅ TypeScript first</li>
              <li>✅ React hooks API</li>
              <li>✅ Event callbacks</li>
              <li>✅ LocalStorage persistence</li>
              <li>✅ Zero dependencies</li>
            </ul>
          </div>

          <div className="feature-card">
            <h3>♿ Accessibility</h3>
            <ul>
              <li>✅ WCAG 2.1 AA compliant</li>
              <li>✅ Keyboard navigation</li>
              <li>✅ Screen reader support</li>
              <li>✅ Focus management</li>
              <li>✅ ARIA attributes</li>
            </ul>
          </div>
        </div>
      </section>

      {/* Debug Information */}
      {showConsentDebug && (
        <section className="demo-section debug-section">
          <h2>🐛 Debug Information</h2>
          <div className="debug-content">
            <div className="debug-card">
              <h3>Consent Record</h3>
              <pre className="debug-output">
                {JSON.stringify(getAllConsent(), null, 2)}
              </pre>
            </div>

            <div className="debug-card">
              <h3>Category Status Table</h3>
              <table className="debug-table">
                <thead>
                  <tr>
                    <th>Category</th>
                    <th>Status</th>
                    <th>Required</th>
                    <th>Has Consent</th>
                  </tr>
                </thead>
                <tbody>
                  {config.settings.categories.map((category: ConsentCategory) => (
                    <tr key={category.id}>
                      <td>{category.name}</td>
                      <td>
                        <span className={`status-badge status-${getConsent(category.id)}`}>
                          {getConsent(category.id)}
                        </span>
                      </td>
                      <td>{category.required ? 'Yes' : 'No'}</td>
                      <td>{hasConsent(category.id) ? 'Yes' : 'No'}</td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>

            <div className="debug-card">
              <h3>Configuration</h3>
              <pre className="debug-output">
                {JSON.stringify(config, null, 2)}
              </pre>
            </div>
          </div>
        </section>
      )}

      {/* Quick Integration Guide */}
      <section className="demo-section">
        <h2>📖 Quick Integration Guide</h2>
        <div className="integration-guide">
          <div className="step">
            <h3>1. Install Package</h3>
            <pre className="code-example">npm install @asafarim/react-privacy-consent</pre>
          </div>

          <div className="step">
            <h3>2. Basic Setup</h3>
            <pre className="code-example">
{`import { ConsentProvider, ConsentBanner, useConsent } from '@asafarim/react-privacy-consent';
import '@asafarim/react-privacy-consent/styles.css';

function App() {
  return (
    <ConsentProvider config={myConfig}>
      <YourApp />
      <ConsentBanner />
    </ConsentProvider>
  );
}

function Analytics() {
  const { hasConsent } = useConsent();
  
  if (!hasConsent('analytics')) {
    return null;
  }
  
  return <GoogleAnalytics />;
}`}
            </pre>
          </div>

          <div className="step">
            <h3>3. Configuration</h3>
            <pre className="code-example">
{`const config = {
  settings: {
    categories: [
      {
        id: 'necessary',
        name: 'Necessary',
        type: 'necessary',
        required: true,
        defaultValue: true
      },
      // ... more categories
    ],
    version: '1.0.0'
  },
  texts: {
    title: 'We value your privacy',
    description: 'Cookie notice text...'
  }
};`}
            </pre>
          </div>
        </div>
      </section>

      {/* Footer */}
      <footer className="demo-footer">
        <h3>Ready to implement privacy compliance?</h3>
        <p>
          Install @asafarim/react-privacy-consent and protect your users' privacy while staying compliant with regulations.
        </p>
        <div className="footer-links">
          <a 
            href="https://www.npmjs.com/package/@asafarim/react-privacy-consent"
            target="_blank"
            rel="noopener noreferrer"
            className="btn btn-primary"
          >
            📦 View on NPM
          </a>
          <a 
            href="https://github.com/AliSafari-IT/react-privacy-consent"
            target="_blank"
            rel="noopener noreferrer"
            className="btn btn-secondary"
          >
            🔗 View on GitHub
          </a>        </div>
      </footer>

      {/* Consent Components */}
      <ConsentBanner />
      <ConsentModal 
        isOpen={isPreferencesVisible || isModalOpen} 
        onClose={() => {
          hidePreferences();
          setIsModalOpen(false);
        }} 
      />

      <style>{`
        .privacy-consent-demo {
          max-width: 1200px;
          margin: 0 auto;
          padding: 2rem;
          font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', 'Roboto', sans-serif;
          line-height: 1.6;
        }

        .demo-header {
          text-align: center;
          margin-bottom: 3rem;
          padding: 2rem;
          background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
          color: white;
          border-radius: 12px;
        }

        .demo-header h1 {
          margin: 0 0 1rem 0;
          font-size: 2.5rem;
          font-weight: 700;
        }

        .demo-header p {
          margin: 0 0 1.5rem 0;
          font-size: 1.2rem;
          opacity: 0.9;
        }

        .demo-badges {
          display: flex;
          justify-content: center;
          gap: 0.75rem;
          flex-wrap: wrap;
        }

        .badge {
          background: rgba(255, 255, 255, 0.2);
          color: white;
          padding: 0.5rem 1rem;
          border-radius: 20px;
          font-size: 0.875rem;
          font-weight: 500;
        }

        .demo-nav {
          margin-bottom: 3rem;
        }

        .demo-controls {
          display: flex;
          gap: 1rem;
          flex-wrap: wrap;
          justify-content: center;
        }

        .demo-section {
          margin-bottom: 3rem;
          padding: 2rem;
          background: #f8fafc;
          border-radius: 12px;
          border: 1px solid #e2e8f0;
        }

        .demo-section h2 {
          margin: 0 0 1.5rem 0;
          color: #1a202c;
          font-size: 1.75rem;
          font-weight: 600;
        }

        .consent-status-grid {
          display: grid;
          grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
          gap: 1.5rem;
        }

        .consent-status-card {
          background: white;
          padding: 1.5rem;
          border-radius: 8px;
          border: 1px solid #d1d5db;
          box-shadow: 0 1px 3px rgba(0, 0, 0, 0.1);
        }

        .status-header {
          display: flex;
          justify-content: space-between;
          align-items: center;
          margin-bottom: 1rem;
        }

        .status-header h3 {
          margin: 0;
          color: #1f2937;
          font-size: 1.125rem;
          font-weight: 600;
        }

        .status-badge {
          padding: 0.25rem 0.75rem;
          border-radius: 12px;
          font-size: 0.75rem;
          font-weight: 600;
          text-transform: uppercase;
        }

        .status-badge.status-accepted {
          background: #d1fae5;
          color: #065f46;
        }

        .status-badge.status-rejected {
          background: #fee2e2;
          color: #991b1b;
        }

        .status-badge.status-pending {
          background: #fef3c7;
          color: #92400e;
        }

        .status-description {
          margin: 0 0 1rem 0;
          color: #6b7280;
          font-size: 0.875rem;
          line-height: 1.5;
        }

        .status-controls {
          display: flex;
          gap: 0.5rem;
        }

        .action-grid {
          display: grid;
          grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
          gap: 1.5rem;
        }

        .action-card {
          background: white;
          padding: 1.5rem;
          border-radius: 8px;
          border: 1px solid #d1d5db;
        }

        .action-card h3 {
          margin: 0 0 1rem 0;
          color: #1f2937;
          font-size: 1.125rem;
          font-weight: 600;
        }

        .action-buttons {
          display: flex;
          flex-direction: column;
          gap: 0.75rem;
        }

        .usage-examples {
          display: grid;
          grid-template-columns: repeat(auto-fit, minmax(400px, 1fr));
          gap: 1.5rem;
        }

        .example-card {
          background: white;
          padding: 1.5rem;
          border-radius: 8px;
          border: 1px solid #d1d5db;
        }

        .example-card h3 {
          margin: 0 0 1rem 0;
          color: #1f2937;
          font-size: 1.125rem;
          font-weight: 600;
        }

        .code-example {
          background: #1a202c;
          color: #e2e8f0;
          padding: 1rem;
          border-radius: 6px;
          font-size: 0.875rem;
          line-height: 1.5;
          overflow-x: auto;
          margin-bottom: 1rem;
          font-family: 'Monaco', 'Menlo', 'Ubuntu Mono', monospace;
        }

        .example-status {
          display: flex;
          align-items: center;
          gap: 0.5rem;
        }

        .status-enabled {
          color: #059669;
          font-weight: 600;
        }

        .status-disabled {
          color: #dc2626;
          font-weight: 600;
        }

        .features-grid {
          display: grid;
          grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
          gap: 1.5rem;
        }

        .feature-card {
          background: white;
          padding: 1.5rem;
          border-radius: 8px;
          border: 1px solid #d1d5db;
        }

        .feature-card h3 {
          margin: 0 0 1rem 0;
          color: #1f2937;
          font-size: 1.125rem;
          font-weight: 600;
        }

        .feature-card ul {
          margin: 0;
          padding: 0;
          list-style: none;
        }

        .feature-card li {
          margin-bottom: 0.5rem;
          font-size: 0.875rem;
          color: #374151;
        }

        .debug-section {
          background: #fef3c7;
          border-color: #d97706;
        }

        .debug-content {
          display: grid;
          gap: 1.5rem;
        }

        .debug-card {
          background: white;
          padding: 1.5rem;
          border-radius: 8px;
          border: 1px solid #d1d5db;
        }

        .debug-card h3 {
          margin: 0 0 1rem 0;
          color: #1f2937;
          font-size: 1.125rem;
          font-weight: 600;
        }

        .debug-output {
          background: #1a202c;
          color: #e2e8f0;
          padding: 1rem;
          border-radius: 6px;
          font-size: 0.75rem;
          line-height: 1.5;
          overflow-x: auto;
          max-height: 300px;
          overflow-y: auto;
          font-family: 'Monaco', 'Menlo', 'Ubuntu Mono', monospace;
        }

        .debug-table {
          width: 100%;
          border-collapse: collapse;
          font-size: 0.875rem;
        }

        .debug-table th,
        .debug-table td {
          padding: 0.75rem;
          text-align: left;
          border-bottom: 1px solid #e5e7eb;
        }

        .debug-table th {
          background: #f9fafb;
          font-weight: 600;
          color: #374151;
        }

        .integration-guide {
          display: grid;
          gap: 2rem;
        }

        .step {
          background: white;
          padding: 1.5rem;
          border-radius: 8px;
          border: 1px solid #d1d5db;
        }

        .step h3 {
          margin: 0 0 1rem 0;
          color: #1f2937;
          font-size: 1.125rem;
          font-weight: 600;
        }

        .demo-footer {
          text-align: center;
          padding: 2rem;
          background: white;
          border-radius: 8px;
          border: 1px solid #d1d5db;
          margin-bottom: 2rem;
        }

        .demo-footer h3 {
          margin: 0 0 1rem 0;
          color: #1f2937;
          font-size: 1.5rem;
          font-weight: 600;
        }

        .demo-footer p {
          margin: 0 0 1.5rem 0;
          color: #6b7280;
        }

        .footer-links {
          display: flex;
          justify-content: center;
          gap: 1rem;
          flex-wrap: wrap;
        }

        /* Button Styles */
        .btn {
          display: inline-flex;
          align-items: center;
          justify-content: center;
          padding: 0.75rem 1.5rem;
          border: none;
          border-radius: 6px;
          font-size: 0.875rem;
          font-weight: 500;
          text-decoration: none;
          cursor: pointer;
          transition: all 0.2s ease;
          white-space: nowrap;
        }

        .btn:hover {
          transform: translateY(-1px);
          box-shadow: 0 4px 12px rgba(0, 0, 0, 0.15);
        }

        .btn-primary {
          background: #3b82f6;
          color: white;
        }

        .btn-primary:hover {
          background: #2563eb;
        }

        .btn-secondary {
          background: #6b7280;
          color: white;
        }

        .btn-secondary:hover {
          background: #4b5563;
        }

        .btn-success {
          background: #10b981;
          color: white;
        }

        .btn-success:hover {
          background: #059669;
        }

        .btn-danger {
          background: #ef4444;
          color: white;
        }

        .btn-danger:hover {
          background: #dc2626;
        }

        .btn-info {
          background: #06b6d4;
          color: white;
        }

        .btn-info:hover {
          background: #0891b2;
        }

        .btn-outline {
          background: transparent;
          color: #6b7280;
          border: 1px solid #d1d5db;
        }

        .btn-outline:hover {
          background: #f9fafb;
          border-color: #9ca3af;
        }

        .btn:disabled {
          opacity: 0.5;
          cursor: not-allowed;
          transform: none;
        }

        .btn:disabled:hover {
          background: initial;
          box-shadow: none;
        }

        /* Responsive Design */
        @media (max-width: 768px) {
          .privacy-consent-demo {
            padding: 1rem;
          }

          .demo-header h1 {
            font-size: 2rem;
          }

          .demo-controls {
            flex-direction: column;
            align-items: stretch;
          }

          .demo-badges {
            flex-direction: column;
            align-items: center;
          }

          .footer-links {
            flex-direction: column;
            align-items: center;
          }

          .action-buttons {
            flex-direction: column;
          }
        }
      `}</style>
    </div>
  );
}

// Main component with provider
export default function PrivacyConsentDemo() {
  // Add debug logging to check localStorage on mount
  useEffect(() => {
    // Check if localStorage has the consent data
    const storageKey = demoConsentConfig.settings.storageKey;
    const savedConsent = localStorage.getItem(storageKey);
    
    console.log('[PrivacyConsentDemo] Component mounted');
    console.log(`[PrivacyConsentDemo] Checking localStorage for key: ${storageKey}`);
    console.log(`[PrivacyConsentDemo] Saved consent exists: ${Boolean(savedConsent)}`);
    
    if (savedConsent) {
      try {
        const parsedConsent = JSON.parse(savedConsent);
        console.log('[PrivacyConsentDemo] Saved consent version:', parsedConsent.version);
        console.log('[PrivacyConsentDemo] Current config version:', demoConsentConfig.settings.version);
        console.log('[PrivacyConsentDemo] Saved consent data:', parsedConsent);
        
        // Check expiration
        const expirationDate = new Date(parsedConsent.lastUpdated);
        expirationDate.setDate(expirationDate.getDate() + demoConsentConfig.settings.expirationDays);
        const isExpired = expirationDate <= new Date();
        console.log('[PrivacyConsentDemo] Consent expired:', isExpired);
        console.log('[PrivacyConsentDemo] Expiration date:', expirationDate.toISOString());
        console.log('[PrivacyConsentDemo] Current date:', new Date().toISOString());
        
        // Check if all categories are present
        const allCategoriesPresent = demoConsentConfig.settings.categories.every((category: ConsentCategory) =>
          parsedConsent.decisions.some((d: { categoryId: string }) => d.categoryId === category.id)
        );
        console.log('[PrivacyConsentDemo] All categories present:', allCategoriesPresent);
        
        if (!allCategoriesPresent) {
          console.log('[PrivacyConsentDemo] Missing categories - consent will be reset');
          const existingCategoryIds = parsedConsent.decisions.map((d: { categoryId: string }) => d.categoryId);
          const configCategoryIds = demoConsentConfig.settings.categories.map((c: { id: any; }) => c.id);
          console.log('[PrivacyConsentDemo] Existing categories:', existingCategoryIds);
          console.log('[PrivacyConsentDemo] Required categories:', configCategoryIds);
        }
      } catch (error) {
        console.error('[PrivacyConsentDemo] Error parsing saved consent:', error);
      }
    } else {
      console.log('[PrivacyConsentDemo] No saved consent found - banner will show');
    }
    
    // Add listener for storage changes
    const handleStorageChange = (e: StorageEvent) => {
      if (e.key === storageKey) {
        console.log(`[PrivacyConsentDemo] Storage changed for key: ${storageKey}`);
        console.log(`[PrivacyConsentDemo] Old value: ${e.oldValue ? 'existed' : 'null'}`);
        console.log(`[PrivacyConsentDemo] New value: ${e.newValue ? 'exists' : 'null'}`);
        if (e.newValue) {
          try {
            const newConsent = JSON.parse(e.newValue);
            console.log(`[PrivacyConsentDemo] New consent data:`, newConsent);
          } catch (error) {
            console.error('[PrivacyConsentDemo] Error parsing new consent:', error);
          }
        }
      }
    };
    
    window.addEventListener('storage', handleStorageChange);
    return () => window.removeEventListener('storage', handleStorageChange);
  }, []);
  
  return (
    <ConsentProvider config={demoConsentConfig}>
      <DemoContent />
    </ConsentProvider>
  );
}
