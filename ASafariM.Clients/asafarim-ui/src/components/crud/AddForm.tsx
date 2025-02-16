// E:\asm-fs\apps\frontends\asafarim-client\src\components\crud\AddForm.tsx 
import { IField } from '@/interfaces/IField';
import React, { useState } from 'react';
import Toolbar from '../Toolbars/Toolbar';
import { ActionButton } from '@fluentui/react';
import { IFormData } from '../../interfaces/IFormData';

interface AddFormProps {
    entityName: string;
    fields: IField[];
    submitHandler: (formData: FormData) => Promise<void>;
    onCancel: () => void;
    className?: string;
}

// We'll store errors in an object keyed by field name
type ErrorsType = { [fieldName: string]: string | undefined };

const AddForm: React.FC<AddFormProps> = ({ entityName, fields, submitHandler, onCancel, className }) => {
    const [errors, setErrors] = useState<ErrorsType>({});
    const [submitting, setSubmitting] = useState(false);
    // Initialize form data with default values
    const [formData, setFormData] = useState<IFormData>(() => {
        const initialData = Object.fromEntries(
            fields.map(field => [
                field.name,
                field.defaultValue !== undefined ? field.defaultValue : ''
            ])
        );
        return { ...initialData, delete: 'false' };
    });

    const handleValidateField = (field: IField, value: unknown) => {
        if (field.validate) {
            if (typeof value === 'string') {
                const errorMsg = field.validate(value);
                setErrors(prev => ({ ...prev, [field.name]: errorMsg }));
            } else {
                console.error(`Invalid value type for field ${field.name}. Expected string, but got ${typeof value}.`);
            }
        }
    };

    const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>) => {
        const { name, type, value, checked, files } = e.target as HTMLInputElement;
        const newValue = type === 'checkbox'
            ? checked
            : type === 'file'
                ? files?.[0]
                : value;

        // Update form data
        setFormData(prev => ({ ...prev, [name]: newValue }));

        // Validate the field if it has a validate function
        const field = fields.find(f => f.name === name);
        if (field) {
            handleValidateField(field, newValue);
        }

        // Also call any custom onChange logic
        if (field?.onChange) {
            // note: original code was (name, value) => ...
            field.onChange(e);
        }
    };

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        setSubmitting(true);

        // Validate all fields before submission
        const newErrors: ErrorsType = {};
        fields.forEach(field => {
            if (field.validate) {
                const error = field.validate(formData[field.name]);
                if (error) {
                    newErrors[field.name] = error;
                }
            }
        });

        if (Object.keys(newErrors).length > 0) {
            setErrors(newErrors);
            setSubmitting(false);
            return;
        }

        try {
            const formDataToSubmit = new FormData();
            // Iterate over the formData state instead of the empty FormData object
            Object.entries(formData).forEach(([key, value]) => {
                if (value !== undefined && value !== null) {
                    if (typeof value === 'object' && (value instanceof File || (value as object) instanceof FileList)) {
                        if (value instanceof FileList) {
                            formDataToSubmit.append(key, (value as unknown as FileList)[0]); // Append the first file
                        } else {
                            const dataTransfer = new DataTransfer();
                            dataTransfer.items.add(value as File);
                            const fileList: FileList = dataTransfer.files; // Now you have a FileList
                            formDataToSubmit.append(key, fileList[0]); // Append the File
                        }
                    } else {
                        formDataToSubmit.append(key, String(value));
                    }
                }
            });

            await submitHandler(formDataToSubmit);
            console.log(`${entityName} added successfully`);
            
            // Reset form with initial default values
            const resetData = {
                ...Object.fromEntries(
                    fields.map(field => [field.name, field.defaultValue ?? ''])
                ),
                delete: 'false'
            };
            setFormData(resetData);
            setErrors({});
        } catch (error) {
            console.error(`Error adding ${entityName}:`, error);
            setErrors({ submit: `Failed to add ${entityName}. Please try again.` });
        } finally {
            setSubmitting(false);
        }
    };

    const renderField = (field: IField) => {
        const fieldError = errors[field.name] || field.error; // prefer local validation error if any

        const {
            name,
            label,
            type,
            required,
            disabled,
            placeholder,
            options,
            accept,
            multiple,
            error,
            success
        } = field;

        const baseInputClasses = `
            mt-1 block w-full rounded-md 
            ${disabled ? 'bg-gray-100' : 'bg-white'} 
            border-gray-300 shadow-sm
            focus:border-indigo-500 focus:ring-indigo-500 sm:text-sm
            ${error ? 'border-red-500' : success ? 'border-green-500' : 'border-gray-300'}
        `;

        const feedbackClasses = `mt-1 text-sm ${error ? 'text-red-500' : success ? 'text-green-500' : ''}`;

        return (
            <div key={name} className={`col-span-6 sm:col-span-3 ${className}`} >
                <label htmlFor={name} className="block text-sm font-medium text-gray-700">
                    {label} {required && <span className="text-red-500">*</span>}
                </label>

                {type === 'textarea' ? (
                    <textarea
                        id={name}
                        name={name}
                        value={formData[name] as string}
                        onChange={handleChange}
                        disabled={disabled}
                        required={required}
                        placeholder={placeholder}
                        className={baseInputClasses}
                        rows={4}
                    />
                ) : type === 'select' ? (
                    <select
                        id={name}
                        name={name}
                        value={formData[name] as string}
                        onChange={handleChange}
                        disabled={disabled}
                        required={required}
                        className={baseInputClasses}
                    >
                        {options?.map((option) => (
                            <option key={option.value} value={option.value}>
                                {option.label}
                            </option>
                        ))}
                    </select>
                ) : (
                    <input
                        type={type}
                        id={name}
                        name={name}
                        value={type !== 'file' ? (formData[name] as string) : undefined}
                        onChange={handleChange}
                        disabled={disabled}
                        required={required}
                        placeholder={placeholder}
                        accept={accept}
                        multiple={multiple}
                        className={baseInputClasses}
                    />
                )}
                {fieldError && <p className="text-red-500">{fieldError}</p>}

                {(error || success) && (
                    <p className={feedbackClasses}>
                        {error || success}
                    </p>
                )}
            </div>
        );
    };

    return (
        <form onSubmit={handleSubmit} className={`add-entity-form ${className}`} autoComplete='on'>
            {fields.map((field, index) => {
                // Handle Is Admin and Is Active fields together
                if (field.name === 'isAdmin' && fields[index + 1]?.name === 'isActive') {
                    const activeField = fields[index + 1];
                    return (
                        <div key={field.name} className={"grid grid-cols-2 gap-4 mb-4" + className} >
                            <div className="col-span-1">
                                <label className="block text-sm font-medium text-gray-700 mb-1">
                                    {field.label} {field.required && <span className="text-red-500">*</span>}
                                </label>
                                <div className="flex gap-4">
                                    {field.options?.map(option => (
                                        <label key={option.value} className="inline-flex items-center">
                                            <input
                                                type="radio"
                                                name={field.name}
                                                value={option.value}
                                                checked={formData[field.name] === option.value}
                                                onChange={handleChange}
                                                disabled={field.disabled}
                                                className="h-4 w-4 text-indigo-600 border-gray-300 focus:ring-indigo-500"
                                            />
                                            <span className="ml-2 text-sm text-gray-700">{option.label}</span>
                                        </label>
                                    ))}
                                </div>
                            </div>
                            <div className="col-span-1">
                                <label className="block text-sm font-medium text-gray-700 mb-1">
                                    {activeField.label} {activeField.required && <span className="text-red-500">*</span>}
                                </label>
                                <div className="flex items-center">
                                    <input
                                        type="checkbox"
                                        id={activeField.name}
                                        name={activeField.name}
                                        checked={formData[activeField.name] as boolean}
                                        onChange={handleChange}
                                        disabled={activeField.disabled}
                                        className="h-4 w-4 text-indigo-600 border-gray-300 rounded focus:ring-indigo-500"
                                    />
                                </div>
                            </div>
                        </div>
                    );
                }
                // Skip Is Active field since it's handled above
                if (field.name === 'isActive') {
                    return null;
                }
                return renderField(field);
            })}
            <Toolbar aria-label='Add' className='flex justify-end'>
                <ActionButton type="submit" id='submit' className='w-24' disabled={submitting}>Submit</ActionButton>
                <ActionButton type="button" onClick={onCancel} id='cancel' className='w-24 btn-danger'>Cancel</ActionButton>
            </Toolbar>
        </form>
    );
};

export default AddForm;
