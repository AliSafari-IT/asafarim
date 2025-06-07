// test-utils.d.ts
import '@testing-library/jest-dom';

declare global {
  namespace Vi {
    interface Assertion {
      toBeInTheDocument(): void;
      toHaveAttribute(name: string, value?: string): void;
      toBeVisible(): void;
      toBeDisabled(): void;
      toBeEnabled(): void;
      toBeChecked(): void;
      toBePartiallyChecked(): void;
      toHaveClass(...classNames: string[]): void;
      toHaveFocus(): void;
      toHaveFormValues(values: Record<string, any>): void;
      toHaveStyle(css: Record<string, any>): void;
      toHaveTextContent(text: string | RegExp, options?: { normalizeWhitespace: boolean }): void;
      toHaveValue(value: string | string[] | number): void;
      toBeEmptyDOMElement(): void;
      toBeInvalid(): void;
      toBeRequired(): void;
      toBeValid(): void;
      toContainElement(element: HTMLElement | null): void;
      toContainHTML(htmlText: string): void;
      toHaveAccessibleDescription(description?: string | RegExp): void;
      toHaveAccessibleName(name?: string | RegExp): void;
      toHaveDisplayValue(value: string | RegExp | (string | RegExp)[]): void;
      toHaveErrorMessage(text?: string | RegExp): void;
    }
  }
}
