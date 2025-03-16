import React, { useState, useEffect } from 'react';
import { Button, makeStyles } from '@fluentui/react-components';
import { useNavigate, useParams } from 'react-router-dom';
import { TextField, Dropdown, IDropdownOption } from '@fluentui/react';
import Wrapper from '../../layout/Wrapper/Wrapper';
import dashboardServices from '../../api/entityServices';
import { isAxiosError } from 'axios';
import { IPost } from '@/interfaces/post-types';
import { DifficultyLevelEnum } from '@/interfaces/DifficultyLevelEnum';
import { logger } from "@/utils/logger";

const useStyles = makeStyles({
    formContainer: {
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        gap: '10px',
        padding: '20px',
    },
    formField: {
        width: '100%',
        maxWidth: '600px',
        marginBottom: '15px',
    },
});

const difficultyOptions: IDropdownOption[] = [
    { key: DifficultyLevelEnum.Easy, text: 'Easy' },
    { key: DifficultyLevelEnum.Medium, text: 'Medium' },
    { key: DifficultyLevelEnum.Hard, text: 'Hard' },
];

const EditPostForm: React.FC = () => {
    const classes = useStyles();
    const navigate = useNavigate();
    const { id } = useParams<{ id: string }>();
    const [post, setPost] = useState<IPost | null>(null);
    const [error, setError] = useState<string>('');
    const [loading, setLoading] = useState<boolean>(true);

    useEffect(() => {
        const fetchPost = async () => {
            if (!id) return;
            
            try {
                const data = await dashboardServices.fetchEntityById('posts', id) as IPost;
                setPost(data);
            } catch (error) {
                logger.error('Error fetching post:', error);
                setError(isAxiosError(error) ? (error.response?.data.message || 'Failed to fetch the post.') : 'An unexpected error occurred.');
            } finally {
                setLoading(false);
            }
        };

        fetchPost();
    }, [id]);

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        setError('');

        try {
            if (!id || !post) return;
            await dashboardServices.updateEntity('posts', id, {post});
            alert('Post updated successfully!');
            navigate('/dashboard');
        } catch (error) {
            logger.error('Error updating post:', error);
            setError(isAxiosError(error) ? (error.response?.data.message || 'Failed to update the post.') : 'An unexpected error occurred.');
        }
    };

    const handleInputChange = (_: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>, newValue?: string) => {
        setPost(prev => prev ? { ...prev, [_.currentTarget.name]: newValue ?? '' } : prev);
    };

    const handleDifficultyChange = (_: React.FormEvent<HTMLDivElement>, option?: IDropdownOption) => {
        if (option) {
            setPost(prev => prev ? { ...prev, difficultyLevel: option.key as DifficultyLevelEnum } : prev);
        }
    };

    if (loading) {
        return <Wrapper header={<h1>Loading...</h1>} />;
    }

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center">Edit Post</h1>} error={error}>
            <div className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    <TextField label="Post Name" name="name" className={classes.formField} value={post?.name || ''} onChange={handleInputChange} required />
                    <TextField label="Title" name="title" className={classes.formField} value={post?.title || ''} onChange={handleInputChange} />
                    <TextField label="Content" name="content" className={classes.formField} value={post?.content || ''} onChange={handleInputChange} multiline rows={8} required />
                    <Dropdown label="Difficulty Level" selectedKey={post?.difficultyLevel} options={difficultyOptions} onChange={handleDifficultyChange} className={classes.formField} />
                    <Button type="submit" style={{ float: 'right', marginTop: '10px' }}>Update Post</Button>
                </form>
            </div>
        </Wrapper>
    );
};

export default EditPostForm;