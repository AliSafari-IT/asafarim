import React, { useState, useEffect } from 'react';
import { useNavigate, useParams } from 'react-router-dom';
import { TextField, Dropdown, IDropdownOption, Toggle, makeStyles } from '@fluentui/react';
import { Button } from '@fluentui/react-components';
import Wrapper from '../../layout/Wrapper/Wrapper';
import dashboardServices from '../../api/entityServices';
import { isAxiosError } from 'axios';
import { ISitemapItem } from '@/interfaces/ISitemapItem';
import { IRoleEnum } from '@/interfaces/IRole';
import useAuth from '@/hooks/useAuth';
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
        width: '100%',
        maxWidth: '600px',
        marginBottom: '15px',
    },
    toggleField: {
        marginBottom: '15px',
    },
});

const roleOptions: IDropdownOption[] = [
    { key: IRoleEnum.Guest, text: 'Guest' },
    { key: IRoleEnum.StandardUser, text: 'Standard User' },
    { key: IRoleEnum.Admin, text: 'Admin' },
    { key: IRoleEnum.SuperAdmin, text: 'Super Admin' },
    { key: IRoleEnum.Editor, text: 'Editor' },
    { key: IRoleEnum.Moderator, text: 'Moderator' },
    { key: IRoleEnum.Developer, text: 'Developer' },
    { key: IRoleEnum.ProjectManager, text: 'Project Manager' },
    { key: IRoleEnum.ProjectCoordinator, text: 'Project Coordinator' },
    { key: IRoleEnum.ProjectLeader, text: 'Project Leader' },
    { key: IRoleEnum.ProjectManagerAssistant, text: 'Project Manager Assistant' },
    { key: IRoleEnum.ProjectManagerSpecialist, text: 'Project Manager Specialist' },
    { key: IRoleEnum.ProjectManagerSpecialistAssistant, text: 'Project Manager Specialist Assistant' },
];

const EditSitemapItemForm: React.FC = () => {
    const classes = useStyles();
    const navigate = useNavigate();
    const { id } = useParams<{ id: string }>();
    const { authenticatedUser } = useAuth();

    const [sitemapItem, setSitemapItem] = useState<ISitemapItem>({
        id: '',
        pageName: '',
        description: '',
        slug: '',
        accessByRole: IRoleEnum.StandardUser,
        parent: '',
        order: 0,
        icon: '',
        isActive: true,
        isExternalLink: false,
        externalLink: '',
        isHidden: false,
        isDisabled: false,
        isDeleted: false,
        createdBy: '',
    });

    const [parentOptions, setParentOptions] = useState<IDropdownOption[]>([]);
    const [error, setError] = useState<string>('');
    const [loading, setLoading] = useState<boolean>(true);

    useEffect(() => {
        const loadData = async () => {
            if (!id) return;

            try {
                // Load all sitemap items for parent selection
                const items = await dashboardServices.fetchEntities('sitemap') as unknown as ISitemapItem[];
                setParentOptions(items
                    .filter(item => item.id !== id) // Exclude current item from parent options
                    .map(item => ({ key: item.id, text: item.pageName }))
                );

                // Load the current sitemap item
                const data = await dashboardServices.fetchEntityById('sitemap', id) as ISitemapItem;
                setSitemapItem(data);
                setLoading(false);
            } catch (error) {
                logger.error('Error fetching sitemap item:', error);
                if (isAxiosError(error)) {
                    setError(error.response?.data.message || 'Failed to fetch the sitemap item. Please try again.');
                } else {
                    setError('An unexpected error occurred. Please try again later.');
                }
                setLoading(false);
            }
        };

        loadData();
    }, [id]);

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        setError('');

        try {
            await dashboardServices.updateEntity('sitemap', id!, {
                ...sitemapItem,
                updatedBy: authenticatedUser?.id || 'system'
            });
            alert('Sitemap item updated successfully!');
            navigate('/sitemaps');
        } catch (error) {
            logger.error('Error updating sitemap item:', error);
            if (isAxiosError(error)) {
                setError(error.response?.data.message || 'Failed to update the sitemap item. Please try again.');
            } else {
                setError('An unexpected error occurred. Please try again later.');
            }
        }
    };

    const handleInputChange = (e: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const { name, value } = e.target as HTMLInputElement;
        setSitemapItem(prev => ({
            ...prev,
            [name]: value
        }));
    };

    const handleToggleChange = (name: keyof ISitemapItem) => (_: unknown, checked?: boolean) => {
        setSitemapItem(prev => ({
            ...prev,
            [name]: checked
        }));
    };

    const handleDropdownChange = (fieldName: string) => (_: React.FormEvent<HTMLDivElement>, option?: IDropdownOption) => {
        if (option) {
            setSitemapItem(prev => ({
                ...prev,
                [fieldName]: option.key
            }));
        }
    };

    if (loading) {
        return <Wrapper header={<h1>Loading...</h1>} />;
    }

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center">Edit Sitemap Item</h1>} error={error}>
            <div className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    <TextField
                        label="Page Name"
                        name="pageName"
                        className={classes.formField}
                        value={sitemapItem.pageName}
                        onChange={handleInputChange}
                        required
                    />
                    <TextField
                        label="Description"
                        name="description"
                        className={classes.formField}
                        value={sitemapItem.description}
                        onChange={handleInputChange}
                        multiline
                        rows={3}
                    />
                    <TextField
                        label="Slug"
                        name="slug"
                        className={classes.formField}
                        value={sitemapItem.slug}
                        onChange={handleInputChange}
                        required
                    />
                    <Dropdown
                        label="Access Role"
                        selectedKey={sitemapItem.accessByRole}
                        options={roleOptions}
                        onChange={handleDropdownChange('accessByRole')}
                        className={classes.formField}
                    />
                    <Dropdown
                        label="Parent Item"
                        selectedKey={sitemapItem.parent}
                        options={parentOptions}
                        onChange={handleDropdownChange('parent')}
                        className={classes.formField}
                    />
                    <TextField
                        label="Order"
                        name="order"
                        type="number"
                        className={classes.formField}
                        value={sitemapItem.order?.toString()}
                        onChange={handleInputChange}
                    />
                    <TextField
                        label="Icon"
                        name="icon"
                        className={classes.formField}
                        value={sitemapItem.icon || ''}
                        onChange={handleInputChange}
                    />
                    <Toggle
                        label="Is External Link"
                        checked={sitemapItem.isExternalLink}
                        onChange={handleToggleChange('isExternalLink')}
                        className={classes.toggleField}
                    />
                    {sitemapItem.isExternalLink && (
                        <TextField
                            label="External Link URL"
                            name="externalLink"
                            className={classes.formField}
                            value={sitemapItem.externalLink || ''}
                            onChange={handleInputChange}
                        />
                    )}
                    <Toggle
                        label="Is Hidden"
                        checked={sitemapItem.isHidden}
                        onChange={handleToggleChange('isHidden')}
                        className={classes.toggleField}
                    />
                    <Toggle
                        label="Is Disabled"
                        checked={sitemapItem.isDisabled}
                        onChange={handleToggleChange('isDisabled')}
                        className={classes.toggleField}
                    />
                    <Toggle
                        label="Is Active"
                        checked={sitemapItem.isActive}
                        onChange={handleToggleChange('isActive')}
                        className={classes.toggleField}
                    />

                    <Button type="submit" style={{ float: 'right', marginTop: '10px' }}>Update Sitemap Item</Button>
                </form>
            </div>
        </Wrapper>
    );
};

export default EditSitemapItemForm;