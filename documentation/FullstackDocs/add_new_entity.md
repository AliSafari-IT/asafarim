# Documentation: Add New Entity Form

This guide explains how to use the form for adding new entities like **Tags**, **Topics**, **Blog Posts**, etc., in the application. The form dynamically adapts to the entity type and supports different input types such as text, number, date, and array (e.g., tags).

## Table of Contents:
1. [Overview](#overview)
2. [Form Structure](#form-structure)
3. [Supported Field Types](#supported-field-types)
4. [Handling Array Fields](#handling-array-fields)
5. [Dynamic Form Generation](#dynamic-form-generation)
6. [Form Submission](#form-submission)
7. [How to Add a New Entity](#how-to-add-a-new-entity)

---

## Overview

The **Add New Entity** form is designed to handle various models (e.g., Tags, Topics, Blog Posts) and dynamically generates the appropriate input fields based on the model selected. It supports different field types such as text, number, date, and arrays (e.g., a list of tags).

## Form Structure

The form dynamically generates fields based on the selected model and the fields defined in `fields.ts`. Each field's type (e.g., text, number, date) is used to render the correct input element.

- **Fields Definition**: Fields for each model are defined in `fields.ts` and specify:
  - Field name
  - Field type (e.g., text, number, checkbox, array)
  - Whether the field is readonly or editable

Example of fields definition for `Topics`:

```ts
export const topicFields = [
    { name: 'id', type: 'text', readonly: true },
    { name: 'name', type: 'text' },
    { name: 'description', type: 'text' },
    { name: 'technologyCategory', type: 'text' },
    { name: 'difficultyLevel', type: 'text' },
    { name: 'tags', type: 'array', itemType: 'text' }, // Array of strings
    { name: 'postCount', type: 'number' },
    { name: 'createdDate', type: 'date' },
    { name: 'lastUpdated', type: 'datetime-local' }
];
```

## Supported Field Types

The form supports a variety of field types:

- **Text**: Standard text input.
- **Number**: Input for numeric values.
- **Date**: Input for dates.
- **Datetime-local**: Input for date and time.
- **Checkbox**: Boolean input (true/false).
- **Array (Tags)**: Supports multiple values (e.g., tags as an array of strings).

## Handling Array Fields

Fields such as `tags` are arrays, allowing multiple values. The form supports adding and removing items dynamically for array fields.

For example, the `tags` field allows users to:
- Add new tags
- Remove existing tags
- Edit individual tags

**Add New Tag Example:**
```tsx
<Button appearance="secondary" type="button" onClick={addTagField}>Add Tag</Button>
```

**Remove Tag Example:**
```tsx
<Button appearance="primary" type="button" onClick={() => removeTagField(index)} disabled={data[name]?.length <= 1}>Remove</Button>
```

## Dynamic Form Generation

The form automatically generates fields based on the model selected. This is achieved by dynamically fetching the fields from the `fields.ts` file using the `getFields` function. The fields are rendered in the form as appropriate input types.

**Rendering Logic:**
```tsx
const renderField = (field: { name: string, type: string, readonly?: boolean }) => {
    // Handle different field types (e.g., text, number, checkbox, array)
};
```

## Form Submission

On submission, the form gathers all the input values (including arrays like tags) and sends them to the backend API using the `dashboardServices.addEntity()` function.

**Submit Handler:**
```tsx
const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    try {
        await dashboardServices.addEntity(model!, data);
        alert(`${model?.slice(0, -1).toUpperCase()} added successfully!`);
        navigate('/dashboard');
    } catch (error) {
        console.error(`Error adding ${model?.slice(0, -1)}:`, error);
        alert(`Failed to add the ${model?.slice(0, -1)}.`);
    }
};
```

## How to Add a New Entity

Follow these steps to add a new entity using the dynamic form:

1. **Navigate to the Add Form**:
   - Use the route `/tags/add`, `/topics/add`, or `/blogPosts/add` based on the entity you want to add.

2. **Enter Field Values**:
   - The form will dynamically generate fields based on the model.
   - Fill in the values for text fields, numbers, dates, and arrays (e.g., tags).
   - For arrays like `tags`, you can add multiple tags by clicking "Add Tag".

3. **Submit the Form**:
   - Once all the fields are filled, click "Add" to submit the form.
   - The form will submit the data to the API and navigate back to the dashboard on success.

## Example Usage

**Example: Adding a New Topic**

- **URL**: `/topics/add`
- **Fields**:
  - Name: "React Basics"
  - Description: "A topic about React fundamentals."
  - Technology Category: "Frontend"
  - Difficulty Level: "Beginner"
  - Tags: ["JavaScript", "React"]

**Steps**:
1. Navigate to `/topics/add`.
2. Fill in the topic details.
3. Add tags using the "Add Tag" button.
4. Click "Add Topic" to submit.
