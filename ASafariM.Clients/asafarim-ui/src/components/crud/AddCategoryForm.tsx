import { FC, useState } from "react";

const AddCategoryForm: FC = () => {
    const [categoryName, setCategoryName] = useState('');

    const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        try {
            const response = await fetch('/api/categories', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({ name: categoryName }),
            });
            const data = await response.json();
            if (response.ok) {
                setCategoryName('');
            } else {
                console.error(data);
            }
        } catch (error) {
            console.error(error);
        }
    };

    return (
        <form onSubmit={handleSubmit}>
            <label>
                Category Name:
                <input
                    type="text"
                    value={categoryName}
                    onChange={(e) => setCategoryName(e.target.value)}
                />
            </label>
            <button type="submit">Create Category</button>
        </form>
    );
};

export default AddCategoryForm;