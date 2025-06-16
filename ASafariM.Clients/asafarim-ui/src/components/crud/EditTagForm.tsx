import React, { useState, useEffect } from 'react';
import { Button, makeStyles } from '@fluentui/react-components';
import { useNavigate, useParams } from 'react-router-dom';
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

interface Tag {
    id: string;
    name: string;
    slug: string;
    description: string;
}

const EditTagForm: React.FC = () => {
    const classes = useStyles();
    const navigate = useNavigate();
    const { id } = useParams<{ id: string }>();

    const [tag, setTag] = useState<Tag>({
        id: '',
        name: '',
        slug: '',
        description: ''
    });
    const [error, setError] = useState<string>('');
    const [loading, setLoading] = useState<boolean>(true);

    useEffect(() => {
        const fetchTag = async () => {
            if (!id) return;
            
            try {
                const data = await dashboardServices.fetchEntityById('tags', id) as Tag;
                setTag(data);
                setLoading(false);
            } catch (error) {
                logger.error('Error fetching tag:', error);
                if (isAxiosError(error)) {
                    setError(error.response?.data.message || 'Failed to fetch the tag. Please try again.');
                } else {
                    setError('An unexpected error occurred. Please try again later.');
                }
                setLoading(false);
            }
        };

        fetchTag();
    }, [id]);

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        setError('');

        if (!id) {
            setError('Invalid tag ID');
            return;
        }

        try {
            await dashboardServices.updateEntity('tag', id, {
                id,
                name: tag.name,
                slug: tag.slug,
                description: tag.description
            });
            navigate('/dashboard');
        } catch (error) {
            setError((error as Error).toString());
            if (isAxiosError(error)) {
                setError(error.response?.data.message || 'Failed to update the tag. Please try again.');
            } 
        }
    };

    const handleInputChange = (e: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const { name, value } = e.target as HTMLInputElement;
        setTag(prev => ({
            ...prev,
            [name]: value
        }));
    };

    if (loading) {
        return <Wrapper header={<h1>Loading...</h1>} />;
    }

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center">Edit Tag</h1>} error={error}>
            <div className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    <TextField
                        label="Tag Name"
                        name="name"
                        className={classes.formField}
                        value={tag.name}
                        onChange={handleInputChange}
                        required
                    />
                    <TextField
                        label="Tag Slug"
                        name="slug"
                        className={classes.formField}
                        value={tag.slug}
                        onChange={handleInputChange}
                        required
                    />
                    <TextField
                        label="Tag Description"
                        name="description"
                        className={classes.formField}
                        value={tag.description}
                        onChange={handleInputChange}
                        required
                    />

                    <Button type="submit" style={{ float: 'right', marginTop: '10px' }}>Update Tag</Button>
                </form>
            </div>
        </Wrapper>
    );
};

export default EditTagForm;