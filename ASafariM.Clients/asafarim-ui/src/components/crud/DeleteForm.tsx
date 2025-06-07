// DeleteForm.tsx
import React, { useEffect, useState } from 'react';
import { Button, FluentProvider, makeStyles, tokens, shorthands, mergeClasses, webDarkTheme, webLightTheme } from '@fluentui/react-components';
import { useNavigate, useParams } from 'react-router-dom';
import Wrapper from '../../layout/Wrapper';
import dashboardServices from '../../api/entityServices';
import { useTheme } from '@/contexts/ThemeContext';
import Alert from '../Containers/Alert/Alert';
import { logger } from '@/utils/logger';
import { isAxiosError } from 'axios';

const useStyles = makeStyles({
    formContainer: {
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        gap: '20px',
        padding: '20px',
        maxWidth: '600px',
        margin: '0 auto',
    },
    formField: {
        width: '100%',
        maxWidth: '300px',
    },
    deleteButton: {
      backgroundColor: tokens.colorPaletteRedBackground3,
      color: tokens.colorNeutralForegroundOnBrand,
      ...shorthands.border('none'),
      ...shorthands.padding('10px', '20px'),
      ...shorthands.borderRadius('4px'),
      cursor: 'pointer',
      transition: 'background-color 0.2s',
    },
    
    deleteButtonHover: {
      backgroundColor: tokens.colorPaletteRedBackground3,
    },
    
    deleteButtonDisabled: {
      backgroundColor: tokens.colorNeutralBackgroundDisabled,
      cursor: 'not-allowed',
    },
});

interface DeleteFormProps {
    entity: string;
}

const DeleteForm: React.FC<DeleteFormProps> = ({ entity }) => {
    const classes = useStyles();
    const navigate = useNavigate();
    const theme = useTheme();
    const currentTheme = theme.theme === 'dark' ? webDarkTheme : webLightTheme;
    const [id, setId] = useState<string>('');
    const [error, setError] = useState<string>('');
    const [loading, setLoading] = useState<boolean>(false);
    const [showConfirmation, setShowConfirmation] = useState<boolean>(true);

    const param = useParams<{ id: string }>();
    useEffect(() => {
        if (param.id) {
            setId(param.id);
        }
    }, [param.id]);

    const handleDelete = async () => {
        if (!id) {
            setError('No ID provided');
            return;
        }
        logger.info(`Starting delete operation for ID: ${id} of entity: ${entity}`);
        setLoading(true);
        try {
            await dashboardServices.deleteEntity(entity, id);
            logger.info(`Successfully deleted entity: ${entity} with ID: ${id}`);
            navigate(`/dashboard`);
        } catch (error) {
            if (isAxiosError(error)) {
                const serverMessage = error.response?.data || 'Internal server error';
                logger.error('Error deleting entity: ' + serverMessage);
                setError(`Axios ERR: ${serverMessage}`);
            } else {
                logger.error('Error deleting entity: ' + JSON.stringify(error));
                setError('Failed to delete entity: ' + JSON.stringify(error));
            }
        } finally {
            setLoading(false);
        }
    };

    return (
        <Wrapper>
            <FluentProvider theme={currentTheme}>
                <div className={classes.formContainer}>
                    {showConfirmation && (
                        <Alert
                            variant="warning"
                            onClose={() => setShowConfirmation(false)}
                        >
                            Are you sure you want to delete this {entity}? This action cannot be undone.
                        </Alert>
                    )}

                    {error && (
                        <Alert
                            variant="error"
                            onClose={() => setError('')}
                        >
                            {error}
                        </Alert>
                    )}

                    <Button
                      className={mergeClasses(
                        classes.formField,
                        classes.deleteButton,
                        !loading && showConfirmation && classes.deleteButtonHover,
                        (loading || !showConfirmation) && classes.deleteButtonDisabled
                      )}
                      onClick={handleDelete}
                      disabled={loading || !showConfirmation}
                    >
                      {loading ? 'Deleting...' : 'Delete'}
                    </Button>
                </div>
            </FluentProvider>
        </Wrapper>
    );
};

export default DeleteForm;