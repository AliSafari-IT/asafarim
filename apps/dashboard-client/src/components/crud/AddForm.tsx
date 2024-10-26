import React, { useState } from 'react';
import { Button, makeStyles } from '@fluentui/react-components';
import { useNavigate, useParams } from 'react-router-dom';
import { TextField } from '@fluentui/react';
import Wrapper from '../../layout/Wrapper/Wrapper';
import dashboardServices from '../../api/dashboardServices';
import fieldsService from '../../interfaces/fields';

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
    tagField: {
        display: 'flex',
        alignItems: 'center',
        gap: '5px',
        marginBottom: '10px'
    }
});

// Get the relevant fields for the model
const AddForm: React.FC = () => {
    const { model } = useParams(); // 'tags', 'topics', etc.
    const classes = useStyles();
    const navigate = useNavigate();
    const [data, setData] = useState<any>({
        tags: [''] // Initialize tags with an empty string
    });

    // Get the relevant fields for the model
    const attributes = fieldsService.getFields(model!);

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

    // Handle change for array fields (e.g., tags)
    const handleArrayChange = (index: number, value: string) => {
        const newTags = [...data.tags];
        newTags[index] = value;
        setData({ ...data, tags: newTags });
    };

    // Add a new tag input
    const addTagField = () => {
        setData({ ...data, tags: [...data.tags, ''] });
    };

    // Remove a tag input
    const removeTagField = (index: number) => {
        const newTags = [...data.tags];
        newTags.splice(index, 1); // Remove the tag at the given index
        setData({ ...data, tags: newTags });
    };

    const renderField = (field: { name: string, type: string, itemType?: string, readonly?: boolean }) => {
        const { name, type, itemType, readonly } = field;
        const isItem = itemType !== undefined;
        console.log("isItem", isItem);
        const label = name.charAt(0).toUpperCase() + name.slice(1);

        if (type === 'array') {
            // For array fields (like tags), render multiple text fields
            return (
                <div key={name}>
                    <label>{label}</label>
                    {data[name]?.map((tag: string, index: number) => (
                        <div key={index} className={classes.tagField}>
                            <TextField
                                className={classes.formField}
                                value={tag || ''}
                                onChange={(e) => handleArrayChange(index, (e.target as HTMLInputElement).value)}
                                required
                            />
                            <Button
                                appearance="primary"
                                type="button"
                                onClick={() => removeTagField(index)}
                                disabled={data[name]?.length <= 1}
                            >
                                Remove
                            </Button>
                        </div>
                    ))}
                    <Button
                        appearance="secondary"
                        type="button"
                        onClick={addTagField}
                    >
                        Add Tag
                    </Button>
                </div>
            );
        }

        return (
            <TextField
                key={name}
                label={label}
                className={classes.formField}
                type={type}
                value={data[name] || ''}
                onChange={(e) => setData({ ...data, [name]: (e.target as HTMLInputElement).value })}
                disabled={readonly} // Disable fields like 'id' if readonly is true
                required
            />
        );
    };

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center">Add New {model?.slice(0, -1).toUpperCase()}</h1>}>
            <div className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    {attributes.map((field) => renderField(field))}
                    <Button type="submit" style={{ float: 'right', marginTop: '10px' }}>
                        Add {model?.slice(0, -1).toUpperCase()}
                    </Button>
                </form>
            </div>
        </Wrapper>
    );
};

export default AddForm;
