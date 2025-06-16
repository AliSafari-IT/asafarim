import React from 'react';
import { ConnectionStatus } from '@/components/ConnectionStatus';
import Wrapper from '@/layout/Wrapper';
import Header from '@/layout/Header/Header';
import Footer from '@/layout/Footer/Footer';

const NetworkSettings: React.FC = () => {
  return (
    <Wrapper
      pageTitle="Network Settings"
      pageDescription="Configure network timeout and connection settings"
      header={<Header />}
      footer={<Footer />}
    >
      <div className="max-w-4xl mx-auto px-4 py-8">
        <div className="bg-white dark:bg-gray-800 rounded-lg shadow-lg p-6">
          <h1 className="text-3xl font-bold text-gray-900 dark:text-white mb-2">
            Network Settings
          </h1>
          <p className="text-gray-600 dark:text-gray-400 mb-8">
            Configure timeout settings and monitor your connection to optimize performance
          </p>

          <div className="grid grid-cols-1 lg:grid-cols-2 gap-8">
            {/* Connection Status and Configuration */}
            <div className="space-y-6">
              <div>
                <h2 className="text-xl font-semibold text-gray-900 dark:text-white mb-4">
                  Connection Configuration
                </h2>
                <ConnectionStatus showDetails={true} className="w-full" />
              </div>

              <div className="bg-blue-50 dark:bg-blue-900/20 border border-blue-200 dark:border-blue-800 rounded-lg p-4">
                <h3 className="text-sm font-medium text-blue-900 dark:text-blue-300 mb-2">
                  🔧 Configuration Tips
                </h3>
                <ul className="text-sm text-blue-800 dark:text-blue-400 space-y-1">
                  <li>• Fast networks: Use shorter timeouts (8-15 seconds)</li>
                  <li>• Slow/mobile networks: Use longer timeouts (20-30 seconds)</li>
                  <li>• Enable retries for unreliable connections</li>
                  <li>• Monitor connection health for automatic adjustments</li>
                </ul>
              </div>
            </div>

            {/* Information Panel */}
            <div className="space-y-6">
              <div>
                <h2 className="text-xl font-semibold text-gray-900 dark:text-white mb-4">
                  Performance Information
                </h2>
                <div className="bg-gray-50 dark:bg-gray-700 rounded-lg p-4 space-y-4">
                  <div>
                    <h3 className="text-sm font-medium text-gray-900 dark:text-white mb-2">
                      Current Configuration
                    </h3>
                    <div className="text-sm text-gray-600 dark:text-gray-400">
                      Your timeout settings are automatically optimized based on your connection speed and reliability.
                    </div>
                  </div>

                  <div>
                    <h3 className="text-sm font-medium text-gray-900 dark:text-white mb-2">
                      Automatic Adjustments
                    </h3>
                    <div className="text-sm text-gray-600 dark:text-gray-400">
                      The system monitors your connection and suggests optimal settings when issues are detected.
                    </div>
                  </div>

                  <div>
                    <h3 className="text-sm font-medium text-gray-900 dark:text-white mb-2">
                      Troubleshooting
                    </h3>
                    <div className="text-sm text-gray-600 dark:text-gray-400">
                      If you're experiencing frequent timeouts, try switching to "Slow Network" mode or increase the timeout manually.
                    </div>
                  </div>
                </div>
              </div>

              <div className="bg-green-50 dark:bg-green-900/20 border border-green-200 dark:border-green-800 rounded-lg p-4">
                <h3 className="text-sm font-medium text-green-900 dark:text-green-300 mb-2">
                  ✅ Timeout Resolution Features
                </h3>
                <ul className="text-sm text-green-800 dark:text-green-400 space-y-1">
                  <li>• Configurable timeout settings (1-60 seconds)</li>
                  <li>• Automatic retry with exponential backoff</li>
                  <li>• Real-time connection health monitoring</li>
                  <li>• Intelligent timeout recommendations</li>
                  <li>• Network speed detection and adaptation</li>
                </ul>
              </div>
            </div>
          </div>

          <div className="mt-8 pt-6 border-t border-gray-200 dark:border-gray-700">
            <div className="bg-yellow-50 dark:bg-yellow-900/20 border border-yellow-200 dark:border-yellow-800 rounded-lg p-4">
              <h3 className="text-sm font-medium text-yellow-900 dark:text-yellow-300 mb-2">
                ⚠️ Important Notes
              </h3>
              <div className="text-sm text-yellow-800 dark:text-yellow-400 space-y-1">
                <p>• Settings are saved locally in your browser</p>
                <p>• Changes take effect immediately for new requests</p>
                <p>• Reset to defaults if experiencing issues</p>
                <p>• Connection monitoring helps optimize performance automatically</p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </Wrapper>
  );
};

export default NetworkSettings;
