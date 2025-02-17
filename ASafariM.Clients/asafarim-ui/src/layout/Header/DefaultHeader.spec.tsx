import { render } from '@testing-library/react';
import { describe, it, expect } from 'vitest';
import Header from './Header';

describe('DefaultHeader', () => {
  it('should render successfully', () => {
    render(<Header />);
    expect(document.body).toBeTruthy();
  });
});