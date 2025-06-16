import React, { ReactNode } from 'react';
import { InfoIcon, SuccessIcon, WarningIcon, ErrorIcon, CloseIcon } from './svgIcons';
import styles from './Alert.module.css';

export type AlertVariant = 'info' | 'success' | 'warning' | 'danger' | 'error';

interface AlertProps {
  variant: AlertVariant;
  children: ReactNode;
  className?: string;
  onClose?: () => void;
}

const Alert: React.FC<AlertProps> = ({ variant, children, className = '', onClose }) => {
  const getIcon = () => {
    switch (variant) {
      case 'info':
        return <InfoIcon className={styles.icon} />;
      case 'success':
        return <SuccessIcon className={styles.icon} />;
      case 'warning':
      case 'danger':
        return <WarningIcon className={styles.icon} />;
      case 'error':
        return <ErrorIcon className={styles.icon} />;
      default:
        return null;
    }
  };

  return (
    <div className={`${styles.alert} ${styles[variant]} ${className}`}>
      <div className={styles.content}>
        <div className={styles.iconWrapper}>{getIcon()}</div>
        <div className={styles.message}>{children}</div>
      </div>
      {onClose && (
        <button onClick={onClose} className={styles.closeButton}>
          <CloseIcon />
        </button>
      )}
    </div>
  );
};

export default Alert;
