import React, { useState, useEffect } from 'react';
import { ISitemapItem } from '@/interfaces/ISitemapItem';
import { TextField, PrimaryButton, Dropdown, IDropdownOption, makeStyles } from '@fluentui/react';
import { useNavigate } from 'react-router-dom';
import dashboardServices from '@/api/entityServices';
import { IRoleEnum } from '@/interfaces';
import Wrapper from '@/layout/Wrapper/Wrapper';
import { isAxiosError } from 'axios';
import { useAuth } from '@/contexts/AuthContext';
import {logger} from '@/utils/logger';

interface IAddSitemapItemFormProps {
    parentId?: string;
}

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

const AddSitemapItemForm: React.FC<IAddSitemapItemFormProps> = ({ parentId }) => {
    const classes = useStyles();
    const navigate = useNavigate();
    const { authenticatedUser } = useAuth();

    const [title, setTitle] = useState<string>(''); 
    const [url, setUrl] = useState<string>(''); 
    const [description, setDescription] = useState<string>(''); 
    const [parent, setParent] = useState<ISitemapItem | undefined>(undefined);
    const [parentOptions, setParentOptions] = useState<IDropdownOption[]>([]);
    const [error, setError] = useState<string>('');

    useEffect(() => {
        try {
            const loadParents = async () => {
                const data = await dashboardServices.fetchEntities('sitemap') as unknown as ISitemapItem[];
                setParentOptions(data.map(item => ({ key: item.id, text: item.pageName })));
            };
            loadParents();
            
            if (parentId) {
                dashboardServices.fetchEntityById('sitemap', parentId)
                    .then(data => setParent(data as ISitemapItem));
            }
        } catch (error) {
            logger.error('Error loading parent options:', error);
            setError('Failed to load parent options. Please try again later.');
        }
    }, [parentId]);

    const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
        event.preventDefault();
        setError('');

        try {
            const newSitemapItem= {
                id: '',
                pageName: title,
                slug: url,
                description,
                parent: parent?.id,
                order: 0,
                icon: '',
                isActive: true,
                isDeleted: false,
                accessByRole: IRoleEnum.StandardUser,
                createdBy: authenticatedUser?.id || 'system',
                updatedBy: authenticatedUser?.id || 'system'
            };

            await dashboardServices.addEntity('sitemaps', newSitemapItem);
            alert('Sitemap item added successfully!');
            navigate('/sitemaps');
        } catch (error) {
            logger.error('Error adding sitemap item:', error);
            if (isAxiosError(error)) {
                setError(error.response?.data.message || 'Failed to add the sitemap item. Please try again.');
            } else {
                setError('An unexpected error occurred. Please try again later.');
            }
        }
    };

    const handleDropdownChange = (_event: React.FormEvent<HTMLDivElement>, option?: IDropdownOption) => {
        if (option) {
            const selectedItem = parentOptions.find(item => item.key === option.key);
            if (selectedItem) {
                setParent(selectedItem as unknown as ISitemapItem);
            }
        }
    };

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center">Add New Sitemap Item</h1>} error={error}>
            <div className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    <TextField
                        label="Title"
                        name='title'
                        className={classes.formField}
                        value={title}
                        onChange={(e) => setTitle((e.target as HTMLInputElement).value)}
                        required
                    />
                    <TextField
                        label="URL"
                        name='url'
                        className={classes.formField}
                        value={url}
                        onChange={(e) => setUrl((e.target as HTMLInputElement).value)}
                        required
                    />
                    <TextField
                        label="Description"
                        name='description'
                        className={classes.formField}
                        value={description}
                        onChange={(e) => setDescription((e.target as HTMLInputElement).value)}
                        required
                    />
                    <Dropdown
                        label="Parent"
                        className={classes.formField}
                        selectedKey={parent?.id}
                        onChange={handleDropdownChange}
                        options={parentOptions}
                    />
                    <PrimaryButton type="submit" style={{ float: 'right', marginTop: '10px' }}>
                        Add Sitemap Item
                    </PrimaryButton>
                </form>
            </div>
        </Wrapper>
    );
};

export default AddSitemapItemForm;