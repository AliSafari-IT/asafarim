import React from 'react';
import { ReactNode } from 'react';

export const ContactPageLayout = ({ children }: { children: ReactNode }) => {
  return (
    <div className='max-w-7xl mx-auto px-4 py-12'>
      {children}
    </div>
  );
};

export default ContactPageLayout;