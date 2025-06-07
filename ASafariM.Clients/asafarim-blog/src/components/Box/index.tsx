import React from 'react';
import styles from './styles.module.css';

/**
 * A simple Box component for wrapping content, especially images
 */
function Box({ children, className, ...props }) {
  return (
    <div className={`${styles.box} ${className || ''}`} {...props}>
      {children}
    </div>
  );
}

export default Box;
