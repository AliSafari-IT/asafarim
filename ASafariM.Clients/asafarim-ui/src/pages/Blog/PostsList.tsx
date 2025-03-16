import React, { useEffect, useState } from 'react';
import {
    DetailsList,
    DetailsListLayoutMode,
    SelectionMode,
    IColumn,
    Spinner,
    SpinnerSize,
    MessageBar,
    MessageBarType,
    Stack,
    IconButton,
} from '@fluentui/react';
import Wrapper from '@/layout/Wrapper/Wrapper';
import Header from '@/layout/Header/Header';
import { IPost } from '@/interfaces/post-types';
import { Toolbar } from '@fluentui/react-components';
import {  useNavigate } from 'react-router-dom';
import { logger } from "@/utils/logger";

const PostsList: React.FC = () => {
    const navigate = useNavigate();
    const [posts, setPosts] = useState<IPost[]>([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState<string | null>(null);

    // Create a list of columns for the DetailsList component from properties given in IPost interface
    const generateColumns = (): IColumn[] => {
        return [
            { key: 'id', name: 'ID', fieldName: 'id', minWidth: 50, maxWidth: 100 },
            { key: 'name', name: 'Name', fieldName: 'name', minWidth: 100, maxWidth: 200 },
            { key: 'title', name: 'Title', fieldName: 'title', minWidth: 100, maxWidth: 200 },
            { key: 'author', name: 'Author', fieldName: 'author', minWidth: 100, maxWidth: 150 },
            { key: 'publishedAt', name: 'Published Date', fieldName: 'publishedAt', minWidth: 100, maxWidth: 150 },
            { key: 'difficultyLevel', name: 'Difficulty', fieldName: 'difficultyLevel', minWidth: 100, maxWidth: 150 },
            { key: 'viewCount', name: 'Views', fieldName: 'viewCount', minWidth: 70, maxWidth: 100 },
            { key: 'isPublished', name: 'Published', fieldName: 'isPublished', minWidth: 70, maxWidth: 100 },
            { key: 'visibility', name: 'Visibility', fieldName: 'visibility', minWidth: 100, maxWidth: 150 }
        ];
    };

    const columns: IColumn[] = generateColumns();

    // gotoAddNewPostPage
    const gotoAddNewPostPage = () => {
        navigate('/posts/create'); // Replace with the actual route for adding a new post
    };

    useEffect(() => {
        const fetchPosts = async () => {
            try {
                const response = await fetch('http://localhost:5000/api/Posts');
                if (!response.ok) {
                    throw new Error('Failed to fetch posts');
                }
                const data = await response.json();
                setPosts(data);
            } catch (err) {
                setError(err instanceof Error ? err.message : 'An error occurred while fetching posts');
            } finally {
                setLoading(false);
            }
        };

        fetchPosts();
    }, []);

    if (loading) {
        return (
            <Stack horizontalAlign="center" verticalAlign="center" styles={{ root: { minHeight: '400px' } }}>
                <Spinner size={SpinnerSize.large} label="Loading posts..." />
            </Stack>
        );
    }

    if (error) {
        return (
            <Stack tokens={{ padding: 20 }}>
                <MessageBar messageBarType={MessageBarType.error}>
                    {error}
                </MessageBar>
            </Stack>
        );
    }

    return (
        <Wrapper>
            <Stack tokens={{ padding: 20 }}>
                <Toolbar>
                    <Stack horizontal verticalAlign='center' horizontalAlign='space-between' style={{ width: '100%' }}>
                        <Header size="text-3xl" key={'display-posts'}>
                            Posts List
                        </Header>
                        <Stack horizontal tokens={{ childrenGap: 8 }}>
                            <IconButton iconProps={{ iconName: "Add" }} text="Add New" onClick={gotoAddNewPostPage} />
                            <IconButton iconProps={{ iconName: "Edit" }} text="Edit" onClick={() => logger.info('Edit button clicked')} />
                            <IconButton iconProps={{ iconName: "Delete", style: { color: 'red' } }} text="Delete" onClick={() => logger.info('Delete button clicked')} />
                            <IconButton iconProps={{ iconName: "View" }} text="View" onClick={() => logger.info('View button clicked')} />
                        </Stack>
                    </Stack>
                </Toolbar>
                <DetailsList
                    items={posts}
                    columns={columns}
                    selectionMode={SelectionMode.none}
                    layoutMode={DetailsListLayoutMode.justified}
                />
            </Stack>
        </Wrapper>
    );
};

export default PostsList;