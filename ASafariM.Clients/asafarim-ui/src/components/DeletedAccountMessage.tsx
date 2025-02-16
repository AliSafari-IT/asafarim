import React, { useState } from 'react';
import { requestAccountReactivation } from '../api/authapi';
import { logger } from '@/utils/logger';

interface DeletedAccountMessageProps {
  email: string;
  onClose: () => void;
}

const DeletedAccountMessage: React.FC<DeletedAccountMessageProps> = ({ email, onClose }) => {
  const [requestSent, setRequestSent] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const handleReactivationRequest = async () => {
    try {
      await requestAccountReactivation(email);
      logger.info('Reactivation request sent successfully');
      setRequestSent(true);
      setError(null);
    } catch (err) {
      logger.error('Failed to send reactivation request:'+ JSON.stringify(err));
      setError('Failed to send reactivation request. Please try again later.');
    }
  };

  return (
    <div className="fixed inset-0 bg-gray-600 bg-opacity-50 overflow-y-auto h-full w-full flex items-center justify-center">
      <div className="relative mx-auto p-8 w-full max-w-md bg-white rounded-lg shadow-2xl transform transition-all">
        <div className="text-center">
          {/* Warning Icon */}
          <div className="mx-auto flex items-center justify-center h-16 w-16 rounded-full bg-red-100 mb-6">
            <svg className="h-10 w-10 text-red-600" fill="none" stroke="currentColor" viewBox="0 0 24 24">
              <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M12 9v2m0 4h.01m-6.938 4h13.856c1.54 0 2.502-1.667 1.732-3L13.732 4c-.77-1.333-2.694-1.333-3.464 0L3.34 16c-.77 1.333.192 3 1.732 3z" />
            </svg>
          </div>

          <h2 className="text-2xl font-bold text-gray-900 mb-4">Account Deleted</h2>
          
          <div className="space-y-4">
            <p className="text-gray-600">
              This account ({email}) has been marked as deleted.
            </p>
            
            {!requestSent ? (
              <div className="space-y-4">
                <p className="text-gray-500">
                  If you believe this is a mistake, you can request reactivation:
                </p>
                <div className="flex flex-col gap-3">
                  <button
                    onClick={handleReactivationRequest}
                    className="w-full inline-flex justify-center items-center px-4 py-2 border border-transparent text-sm font-medium rounded-md text-white bg-blue-600 hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500 transition-colors"
                  >
                    Request Reactivation
                  </button>
                  <button
                    onClick={onClose}
                    className="w-full inline-flex justify-center items-center px-4 py-2 border border-gray-300 text-sm font-medium rounded-md text-gray-700 bg-white hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500 transition-colors"
                  >
                    Return to Login
                  </button>
                </div>
              </div>
            ) : (
              <div className="space-y-4">
                <div className="p-4 rounded-md bg-green-50 border border-green-200">
                  <div className="flex">
                    <div className="flex-shrink-0">
                      <svg className="h-5 w-5 text-green-400" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M5 13l4 4L19 7" />
                      </svg>
                    </div>
                    <div className="ml-3">
                      <p className="text-sm font-medium text-green-800">
                        Reactivation request sent successfully!
                      </p>
                    </div>
                  </div>
                </div>
                <button
                  onClick={onClose}
                  className="w-full inline-flex justify-center items-center px-4 py-2 border border-gray-300 text-sm font-medium rounded-md text-gray-700 bg-white hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500 transition-colors"
                >
                  Return to Login
                </button>
              </div>
            )}

            {error && (
              <div className="p-4 rounded-md bg-red-50 border border-red-200">
                <div className="flex">
                  <div className="flex-shrink-0">
                    <svg className="h-5 w-5 text-red-400" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                      <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M6 18L18 6M6 6l12 12" />
                    </svg>
                  </div>
                  <div className="ml-3">
                    <p className="text-sm font-medium text-red-800">{error}</p>
                  </div>
                </div>
              </div>
            )}
          </div>
        </div>
      </div>
    </div>
  );
};

export default DeletedAccountMessage;
