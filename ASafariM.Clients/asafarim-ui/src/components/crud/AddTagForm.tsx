import React, { useState } from 'react';
import { Button, makeStyles } from '@fluentui/react-components';
import { useNavigate } from 'react-router-dom';
import { TextField } from '@fluentui/react';
import Wrapper from '../../layout/Wrapper';
import dashboardServices from '../../api/entityServices';
import { isAxiosError } from 'axios';
import {logger} from '@/utils/logger';

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
    },
});

const AddTagForm: React.FC = () => {
    const classes = useStyles();
    const navigate = useNavigate();

    const [tagName, setTagName] = useState<string>('');
    const [tagSlug, setTagSlug] = useState<string>('');
    const [tagDescription, setTagDescription] = useState<string>('');
    const [error, setError] = useState<string>('');

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        setError(''); // Clear any previous errors

        try {
            // Add the tag to the database
            const newTag = await dashboardServices.addEntity('tags', { name: tagName, slug: tagSlug, description: tagDescription });
            logger.log('New tag added:', newTag); // Log the new tag for debugging
            setError(''); // Clear the error message after successful addition
            navigate('/dashboard');
        } catch (error) {
            logger.error('Error adding tag:', error);
            if (isAxiosError(error)) {
                setError(error.response?.data.message || 'Failed to add the tag. Please try again.');
            } else {
                setError('An unexpected error occurred. Please try again later.');
            }
        }
    };

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center">Add New Tag</h1>} error={error}>
            <div className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    <TextField
                        label="Tag Name"
                        name='name'
                        className={classes.formField}
                        value={tagName}
                        onChange={(e) => setTagName((e.target as HTMLInputElement).value)}
                        required
                    />
                    <TextField
                        label="Tag Slug"
                        name='slug'
                        className={classes.formField}
                        value={tagSlug}
                        onChange={(e) => setTagSlug((e.target as HTMLInputElement).value)}
                        required
                    />
                    <TextField
                        label="Tag Description"
                        name='description'
                        className={classes.formField}
                        value={tagDescription}
                        onChange={(e) => setTagDescription((e.target as HTMLInputElement).value)}
                        required
                    />

                    <Button type="submit" style={{ float: 'right', marginTop: '10px' }}>Add Tag</Button>
                </form>
            </div>
        </Wrapper>
    );
};

export default AddTagForm;