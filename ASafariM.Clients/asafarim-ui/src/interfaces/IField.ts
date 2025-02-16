import { ChangeEventHandler } from "react";

export interface IField {
    name: string;
    label?: string;
    defaultValue?: string | number | boolean | File | FileList;
    type: 'text' | 'number' | 'date' | 'textarea' | 'email' | 'password' | 'file' | 'select' | 'checkbox' | 'radio' | 'color' | 'range' | 'button' | 'submit' | 'reset' | 'hidden' | 'image' | 'url' | 'tel' | 'search';
    required?: boolean;
    disabled?: boolean;
    options?: { value: string; label: string }[]; // For 'select' and 'radio'
    value?: string; // Default value for specific input types
    accept?: string; // For file inputs
    placeholder?: string; // Placeholder for inputs
    multiple?: boolean; // For file or select inputs
    onChange?: ChangeEventHandler<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>; // For dynamic input types
    feedback?: string; // Feedback for dynamic input types
    error?: string; // Error message for dynamic input types
    success?: string; // Success message for dynamic input types
    min?: number; // Minimum value for 'number' inputs
    max?: number; // Maximum value for 'number' inputs
    // Add a validation function (client-side)
    validate?: (value: string | number | boolean | undefined | File | FileList) => string | undefined;
}
