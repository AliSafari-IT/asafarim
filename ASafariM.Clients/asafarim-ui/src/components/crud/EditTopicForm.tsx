import React, { FC, useState, useEffect, FormEvent } from "react";
import axios from "axios";
import { useNavigate, useParams } from "react-router-dom";
import { TextField, Dropdown, IDropdownOption, PrimaryButton, Stack, Label } from "@fluentui/react";
import Wrapper from "@/layout/Wrapper";
import { makeStyles } from "@fluentui/react-components";
import { isAxiosError } from "axios";
import { ITopic } from "@/interfaces/ITopic";
import { apiUrls } from "@/api/getApiUrls";
import Alert from '../Containers/Alert/Alert';
import {logger} from '@/utils/logger';

const topicUrl = apiUrls(window.location.hostname) + '/topics';

const useStyles = makeStyles({
    inputField: {
        width: '350px',
    },
    formContainer: {
        width: "500px",
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        flexDirection: "column",
        gap: "20px",
        padding: "40px",
        backgroundColor: "var(--bg-primary)",
        borderRadius: "10px",
        boxShadow: "0 4px 8px rgba(0, 0, 0, 0.2)",
        margin: "0 auto",
    },
    label: {
        color: "var(--text-primary)",
        fontWeight: "bold",
        fontSize: "16px",
    },
    submitButton: {
      width: "100%",
      backgroundColor: "var(--button-primary)",
      color: "var(--button-primary-text)",
    },
    submitButtonHover: {
      backgroundColor: "var(--button-primary-hover)",
    },
});

const EditTopicForm: FC = () => {
    const classes = useStyles();
    const navigate = useNavigate();
    const { id } = useParams<{ id: string }>();

    const [parentTopicId, setParentTopicId] = useState<string | null>(null);
    const [parentTopics, setParentTopics] = useState<ITopic[]>([]);
    const [topic, setTopic] = useState<ITopic>();
    const [error, setError] = useState<string>("");
    const [loading, setLoading] = useState<boolean>(true);
    const [showSuccessAlert, setShowSuccessAlert] = useState<boolean>(false);
    const [showErrorAlert, setShowErrorAlert] = useState<boolean>(false);

    useEffect(() => {
        const fetchTopic = async () => {
            try {
                const { data } = await axios.get(`${topicUrl}/${id}`);
                setTopic(data);
                setParentTopicId(data?.parentTopicId?.toString() || null);
                setLoading(false);
            } catch (error) {
                logger.error("Error fetching topic:", error);
                if (isAxiosError(error)) {
                    setError(error.response?.data?.message || "Failed to fetch the topic. Please try again.");
                } else {
                    setError("An unexpected error occurred. Please try again later.");
                }
                setLoading(false);
            }
        };

        const fetchParentTopics = async () => {
            try {
                const response = await axios.get(topicUrl);
                setParentTopics(response.data);
            } catch (error) {
                logger.error("Error fetching parent topics:", error);
            }
        };

        fetchTopic();
        fetchParentTopics();
    }, [id]);

    const handleSubmit = async (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        setError("");

        if (!topic) {
            setError("Topic data is missing");
            return;
        }

        try {
            await axios.put(`${topicUrl}/${id}`, { ...topic, parentTopicId });
            setShowSuccessAlert(true);
            setTimeout(() => {
                setShowSuccessAlert(false);
                navigate("/dashboard");
            }, 3000);
        } catch (error) {
            logger.error("Error updating topic:", error);
            if (isAxiosError(error)) {
                const errorMessage = error.response?.data?.message || "Failed to update the topic. Please try again.";
                setError(errorMessage);
                setShowErrorAlert(true);
            } else {
                setError("An unexpected error occurred. Please try again later.");
                setShowErrorAlert(true);
            }
        }
    };

    const handleChange = (event: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>, newValue?: string) => {
        const target = event.target as HTMLInputElement | HTMLTextAreaElement;
        setTopic(prev => prev ? { ...prev, [target.name]: newValue !== undefined ? newValue : target.value } : prev);
    };

    const handleDropdownChange = (_: React.FormEvent<HTMLDivElement>, option?: IDropdownOption) => {
        setParentTopicId(option ? option.key.toString() : null);
    };

    const renderError = () => {
        if (!error) return null;
        return <div style={{ color: 'red', marginBottom: '1rem' }}>{error}</div>;
    };

    if (loading) {
        return <Wrapper header={<h1>Loading...</h1>} />;
    }

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center mb-8">Edit Topic</h1>}>
            {showSuccessAlert && <Alert variant="success">Topic updated successfully!</Alert>}
            {showErrorAlert && <Alert variant="error" onClose={() => setShowErrorAlert(false)}>{error}</Alert>}
            <Stack tokens={{ childrenGap: 20 }} className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    {renderError()}
                    <Stack tokens={{ childrenGap: 10 }}>
                        <Label className={classes.label}>Topic Name</Label>
                        <TextField name="name" onChange={handleChange} value={topic?.name} required className={classes.inputField} />
                        <Label className={classes.label}>Slug</Label>
                        <TextField name="slug" onChange={handleChange} value={topic?.slug} required className={classes.inputField} />
                        <Label className={classes.label}>Description</Label>
                        <TextField name="description" onChange={handleChange} multiline rows={4} value={topic?.description} required className={classes.inputField} />
                        {parentTopics.length > 0 && (
                            <>
                                <Label className={classes.label}>Parent Topic</Label>
                                <Dropdown
                                    selectedKey={parentTopicId || ''}
                                    onChange={handleDropdownChange}
                                    options={parentTopics.map(topic => ({ key: topic.id, text: topic.name }))}
                                    className={classes.inputField}
                                />
                            </>
                        )}
                        <PrimaryButton type="submit" className={`${classes.submitButton} hover:${classes.submitButtonHover}`}>Update Topic</PrimaryButton>
                    </Stack>
                </form>
            </Stack>
        </Wrapper>
    );
};

export default EditTopicForm;
