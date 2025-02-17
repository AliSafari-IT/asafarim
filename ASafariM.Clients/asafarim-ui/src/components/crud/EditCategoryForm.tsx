import React, { useState, useEffect } from 'react';
import { Button, makeStyles } from '@fluentui/react-components';
import { useNavigate, useParams } from 'react-router-dom';
import { TextField } from '@fluentui/react';
import Wrapper from '../../layout/Wrapper/Wrapper';
import dashboardServices from '../../api/entityServices';
import { isAxiosError } from 'axios';

const useStyles = makeStyles({
    formContainer: {
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        gap: '10px',
        padding: '20px',
    },
    formField: {
        width: '300px',
        marginBottom: '15px',
    },
});

interface Category {
    id: string;
    name: string;
    description?: string;
    slug?: string;
    parentCategoryId?: string;
}

const EditCategoryForm: React.FC = () => {
    const classes = useStyles();
    const navigate = useNavigate();
    const { id } = useParams<{ id: string }>();

    const [category, setCategory] = useState<Category>({
        id: '',
        name: '',
        description: '',
        slug: '',
        parentCategoryId: '',
    });
    
    const [error, setError] = useState<string>('');
    const [loading, setLoading] = useState<boolean>(true);

    useEffect(() => {
        const fetchCategory = async () => {
            if (!id) return;
            
            try {
                const data = await dashboardServices.fetchEntityById('categories', id) as Category;
                setCategory(data);
                setLoading(false);
            } catch (error) {
                console.error('Error fetching category:', error);
                if (isAxiosError(error)) {
                    setError(error.response?.data.message || 'Failed to fetch the category. Please try again.');
                } else {
                    setError('An unexpected error occurred. Please try again later.');
                }
                setLoading(false);
            }
        };

        fetchCategory();
    }, [id]);

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        setError('');

        try {
            await dashboardServices.updateEntity('categories', id!, {
                name: category.name,
                description: category.description,
                slug: category.slug,
                parentCategoryId: category.parentCategoryId,
            });
            alert('Category updated successfully!');
            navigate('/dashboard');
        } catch (error) {
            console.error('Error updating category:', error);
            if (isAxiosError(error)) {
                setError(error.response?.data.message || 'Failed to update the category. Please try again.');
            } else {
                setError('An unexpected error occurred. Please try again later.');
            }
        }
    };

    const handleInputChange = (e: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const { name, value } = e.target as HTMLInputElement;
        setCategory(prev => ({
            ...prev,
            [name]: value
        }));
    };

    if (loading) {
        return <Wrapper header={<h1>Loading...</h1>} />;
    }

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center">Edit Category</h1>} error={error}>
            <div className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    <TextField
                        label="Category Name"
                        name="name"
                        className={classes.formField}
                        value={category.name}
                        onChange={handleInputChange}
                        required
                    />
                    <TextField
                        label="Description"
                        name="description"
                        className={classes.formField}
                        value={category.description || ''}
                        onChange={handleInputChange}
                        multiline
                        rows={4}
                    />
                    <TextField
                        label="Slug"
                        name="slug"
                        className={classes.formField}
                        value={category.slug || ''}
                        onChange={handleInputChange}
                    />
                    <TextField
                        label="Parent Category ID"
                        name="parentCategoryId"
                        className={classes.formField}
                        value={category.parentCategoryId || ''}
                        onChange={handleInputChange}
                    />

                    <Button type="submit" style={{ float: 'right', marginTop: '10px' }}>Update Category</Button>
                </form>
            </div>
        </Wrapper>
    );
};

export default EditCategoryForm;
