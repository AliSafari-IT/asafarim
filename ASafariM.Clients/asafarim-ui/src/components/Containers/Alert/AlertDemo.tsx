import React from 'react';
import Alert from './Alert';
import {logger} from '@/utils/logger';

const AlertDemo: React.FC = () => {
  return (
    <div style={{ padding: '20px', maxWidth: '600px' }}>
      <Alert variant="info">
        This is an informational message with important details.
      </Alert>

      <Alert variant="success">
        Operation completed successfully! Your changes have been saved.
      </Alert>

      <Alert variant="warning" onClose={() => logger.log('Warning closed')}>
        Please be careful! This action cannot be undone.
      </Alert>

      <Alert variant="danger">
        You are about to delete this item permanently.
      </Alert>

      <Alert variant="error" onClose={() => logger.log('Error closed')}>
        An error occurred while processing your request. Please try again.
      </Alert>
    </div>
  );
};

export default AlertDemo;
