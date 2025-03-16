import React, { useEffect, useState } from 'react';
import {
  Stack,
  TextField,
  PrimaryButton,
  MessageBar,
  MessageBarType,
  Checkbox,
  Dropdown,
  IDropdownOption
} from '@fluentui/react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

import Wrapper from '@/layout/Wrapper/Wrapper';
import Header from '@/layout/Header/Header';
import apiUrls from '@/api/getApiUrls';
import './BlogPost.scss';
import { Label, makeStyles } from '@fluentui/react-components';
import { ITopic } from '@/interfaces/ITopic';
import { logger } from '@/utils/logger';
import Loading from '@/components/Loading/Loading';
import dashboardServices from '@/api/entityServices';


const useStyles = makeStyles({
  inputField: {
    width: '350px',
  },
  formContainer: {
    width: '500px',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    flexDirection: 'column',
    gap: '20px',
    padding: '40px',
    backgroundColor: 'var(--bg-primary)',
    borderRadius: '10px',
    boxShadow: '0 4px 8px rgba(0, 0, 0, 0.2)',
    margin: '0 auto',
  },
  label: {
    color: 'var(--text-primary)',
    fontWeight: 'bold',
    fontSize: '16px',
  },
  dropdown: {
    backgroundColor: 'var(--bg-secondary)',
  },
  submitButton: {
    width: '100%',
    backgroundColor: 'var(--button-primary)',
    color: 'var(--button-primary-text)',
  },
  
  submitButtonHover: {
    backgroundColor: 'var(--button-primary-hover)',
  },
});

interface ICreatePost {
  title: string;
  content: string;
  summary: string;
  excerpt: string;
  slug: string;
  topicId: string | undefined;           // We'll store as string, parse to GUID if valid
  difficultyLevel: number;   // numeric
  isPublished: boolean;
  isActive: boolean;
  isDraft: boolean;
  imageUrl: string;
  metaDescription: string;
  description: string;
  tagIds: string[];          // We'll store a string array of GUIDs
}

const difficultyOptions: IDropdownOption[] = [
  { key: 1, text: 'Easy' },
  { key: 2, text: 'Medium' },
  { key: 3, text: 'Hard' }
];
const topicUrl = apiUrls(window.location.hostname) + '/topics';

const CreatePost: React.FC = () => {
  const navigate = useNavigate();
  const classes = useStyles();
  const [topicId, setTopicId] = useState<string | undefined>(undefined);
  const [topics, setTopics] = useState<ITopic[]>([]);
  const [error, setError] = useState<string | null>(null);
  const [success, setSuccess] = useState(false);

  // track form inputs
  const [title, setTitle] = useState('');
  const [content, setContent] = useState('');
  const [summary, setSummary] = useState('');
  const [excerpt, setExcerpt] = useState('');
  const [slug, setSlug] = useState('');
  const [difficultyLevel, setDifficultyLevel] = useState<number>(1);
  const [isPublished, setIsPublished] = useState(false);
  const [isActive, setIsActive] = useState(false);
  const [isDraft, setIsDraft] = useState(true);
  const [imageUrl, setImageUrl] = useState('');
  const [metaDescription, setMetaDescription] = useState('');
  const [description, setDescription] = useState('');
  const [tagIds, setTagIds] = useState<string>(''); // comma-separated GUIDs?
  const [loading, setLoading] = useState<boolean>(false);

  const [contentLength, setContentLength] = useState(0);
  useEffect(() => {
    const fetchTopics = async () => {
      setLoading(true);
      try {
        const response = await axios.get(topicUrl);
        setTopics(response.data);
        logger.info('Fetched parent topics successfully: ' + JSON.stringify(response.data));
      } catch (error) {
        logger.error('Error fetching topics: ' + JSON.stringify(error));
      }
    };
    fetchTopics();
    setLoading(false);
  }, []);

  useEffect(() => {
    if (topics.length > 0) {
      setTopicId(topics[0].id);
    } else {
      setTopicId(undefined);
    }
  }, [topics]);

  useEffect(() => {
    document.title = 'Create New Post | ASafariM';
  }, []);

  useEffect(() => {
    if (isPublished) {
      setIsDraft(false);
      setIsActive(true);
    } else {
      setIsDraft(true);
      setIsActive(false);
    }
  }, [isPublished]);

  // For brevity, example to parse input into the correct shape
  const processFormData = (): ICreatePost => {
    const tagsArray = tagIds
      .split(',')
      .map(t => t.trim())
      .filter(t => t.length > 0); // no GUID validation here, but you could add some

    return {
      title,
      content,
      summary,
      excerpt,
      slug,
      topicId, // we store as string; server expects a valid GUID or empty
      difficultyLevel,
      isPublished,
      isActive,
      isDraft,
      imageUrl,
      metaDescription,
      description,
      tagIds: tagsArray
    };
  };

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    setError(null);
    setSuccess(false);
    setLoading(true);

    // Get the token from localStorage before submitting
    const authData = JSON.parse(localStorage.getItem('auth') || '{}');
    if (!authData?.token) {
      setError('Authentication required. Please log in.');
      return;
    }

    try {
      const postData = processFormData();
      logger.info('Processed form data successfully: ' + JSON.stringify(postData, null, 2));
      setLoading(true);

      const response = await dashboardServices.addEntity('posts', { postData });
      setLoading(false);

      if (response.success) {
        logger.info('Post created successfully: ' + JSON.stringify(response.data, null, 2));
        setSuccess(true);
        navigate('/posts');
      } else {
        setError(response.data?.message || 'Failed to create post');
      }
    } catch (err) {
      setLoading(false);
      logger.error('Error creating post:' + JSON.stringify(err));
      setError(err instanceof Error ? err.message : 'Error creating post');
    } finally {
      setLoading(false);
    }
  };


  const handleDropdownChange = (_: React.FormEvent<HTMLDivElement>, option?: IDropdownOption) => {
    setTopicId(option?.key as string);
  };

  return (
    <Wrapper className="create-post" id="create-post">
      <Stack tokens={{ padding: 20 }}>
        <Header size="text-4xl" className="font-extrabold text-center mb-6">
          ✨ Create a Stunning Post
        </Header>
        {loading && (
          <Loading />
        )}
        {error && (
          <MessageBar
            messageBarType={MessageBarType.error}
            className="animate-fadeIn"
          >
            {error}
          </MessageBar>
        )}
        {success && (
          <MessageBar
            messageBarType={MessageBarType.success}
            className="animate-fadeIn"
          >
            🎉 Post created successfully!
          </MessageBar>
        )}

        <form
          id="create-blog-post-form"
          onSubmit={handleSubmit}
          className="w-full max-w-3xl mx-auto p-8 bg-white/80 dark:bg-gray-900/80 
                     backdrop-blur-lg shadow-lg rounded-xl transition-all duration-300"
        >
          {/* Title, IsPublished, IsActive, IsDraft */}
          <div className="flex items-center gap-4 mb-6">
            <TextField
              label="Title"
              required
              value={title}
              onChange={(_e, v) => setTitle(v || '')}
              className="flex-1 dark:[&_.ms-Label]:text-gray-200"
            />
            <Checkbox
              label="Publish Now"
              checked={isPublished}
              onChange={(_e, checked) => {
                setIsPublished(checked ?? false);
                // optionally auto-uncheck draft if we publish
                if (checked) setIsDraft(false);
              }}
              className="text-lg dark:[&_.ms-Label]:text-gray-100"
            />
          </div>
          <div className="flex flex-col mb-6">
            <Label className={classes.label}>Parent Topic</Label>
            <Dropdown
              selectedKey={topicId || ''}
              onChange={handleDropdownChange}
              options={topics?.map(topic => ({ key: topic.id, text: topic.name }))}
              className={classes.dropdown}
            />
          </div>

          {/* Content */}
          <div className="flex flex-col mb-6">
            <TextField
              label={`Content (${contentLength}/2000)`}
              name="content"
              multiline
              rows={12}
              maxLength={2000}
              required
              value={content}
              onChange={e => {
                const val = (e.target as HTMLTextAreaElement).value;
                setContent(val);
                setContentLength(val.length);
              }}
              className="w-full dark:[&_.ms-Label]:text-gray-200"
            />
          </div>

          <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
            <TextField
              label="Slug"
              required
              value={slug}
              onChange={(_e, v) => setSlug(v || '')}
              className="dark:[&_.ms-Label]:text-gray-200"
            />

            <TextField
              label="Excerpt"
              multiline
              rows={2}
              required
              value={excerpt}
              onChange={(_e, v) => setExcerpt(v || '')}
              className="dark:[&_.ms-Label]:text-gray-200"
            />

            <TextField
              label="Summary"
              multiline
              rows={2}
              required
              value={summary}
              onChange={(_e, v) => setSummary(v || '')}
              className="dark:[&_.ms-Label]:text-gray-200"
            />

            <Dropdown
              label="Difficulty Level"
              required
              options={difficultyOptions}
              selectedKey={difficultyLevel}
              onChange={(_e, option) => {
                if (option?.key && typeof option.key === 'number') {
                  setDifficultyLevel(option.key);
                }
              }}
              className="dark:[&_.ms-Label]:text-gray-200"
            />


            <TextField
              label="Description"
              multiline
              rows={3}
              value={description}
              onChange={(_e, v) => setDescription(v || '')}
              className="dark:[&_.ms-Label]:text-gray-200"
            />
            <TextField
              label="Meta Description"
              multiline
              rows={2}
              value={metaDescription}
              onChange={(_e, v) => setMetaDescription(v || '')}
              className="dark:[&_.ms-Label]:text-gray-200"
            />
          </div>

          <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
            {/* TagIds as comma-separated GUIDs */}
            <TextField
              className="dark:[&_.ms-Label]:text-gray-200"
              label="Tag GUIDs (comma-separated)"
              value={tagIds}
              onChange={(_e, v) => setTagIds(v || '')}
              placeholder="e.g. guid1, guid2, guid3"
            />
            <TextField
              label="Image URL"
              value={imageUrl}
              onChange={(_e, v) => setImageUrl(v || '')}
              className="dark:[&_.ms-Label]:text-gray-200"
              placeholder="https://example.com/image.jpg"
            />

          </div>

          <div className="mt-8 flex justify-center">
            <PrimaryButton
              text={isPublished ? '🚀 Publish Now' : '💾 Save as Draft'}
              type="submit"
              className= {`${classes.submitButton} hover:${classes.submitButtonHover} px-8 py-3 text-lg font-semibold tracking-wide 
                         shadow-md bg-gradient-to-r from-blue-500 to-indigo-600 
                         text-white rounded-lg hover:opacity-90 transition-all duration-200`}
            />
          </div>
        </form>
      </Stack>
    </Wrapper>
  );
};

export default CreatePost;