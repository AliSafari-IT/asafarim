import React, { useEffect, useState } from 'react';
import {
  Button,
  FluentProvider,
  makeStyles,
  webDarkTheme,
  webLightTheme,
} from '@fluentui/react-components';
import { DashCard } from './DashCard';
import { 
  ArrowLeft24Regular, 
  ArrowRight24Regular,
  Add24Regular as IconAdd,
  Search24Regular,
  Filter24Regular,
  Fire24Regular as Refresh24Regular
} from '@fluentui/react-icons';
import { ITopic } from '../../../interfaces/ITopic';
import { ITag } from '../../../interfaces/ITag';
import { useNavigate } from 'react-router-dom';
import dashboardServices from '../../../api/entityServices';
import Loading from '../../Loading/Loading';
import { useTheme } from '@/contexts/ThemeContext';
import './CardContainer.css';
import {logger} from '@/utils/logger';

const useStyles = makeStyles({
  container: {
    padding: '0',
    display: 'flex',
    flexDirection: 'column',
    width: '100%',
  },
  sectionHeader: {
    display: 'flex',
    justifyContent: 'space-between',
    alignItems: 'center',
    marginBottom: '1rem',
    padding: '0.5rem 0',
    borderBottom: '1px solid var(--border-primary)',
  },
  sectionTitle: {
    display: 'flex',
    alignItems: 'center',
    gap: '0.5rem',
    margin: '0',
    fontSize: '1.25rem',
    fontWeight: '600',
    color: 'var(--text-primary)',
  },
  actionButtons: {
    display: 'flex',
    gap: '0.5rem',
  },
  cardsWrapper: {
    display: 'grid',
    gridTemplateColumns: 'repeat(auto-fill, minmax(300px, 1fr))',
    gap: '1.25rem',
    marginBottom: '1.5rem',
  },
  pagination: {
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'center',
    gap: '0.75rem',
    padding: '0.75rem',
    background: 'var(--bg-primary)',
    borderRadius: '8px',
    marginBottom: '1.5rem',
  },
  pageInfo: {
    display: 'flex',
    alignItems: 'center',
    gap: '0.5rem',
    color: 'var(--text-secondary)',
    fontSize: '0.875rem',
  },
  pageButton: {
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'center',
    width: '36px',
    height: '36px',
    borderRadius: '50%',
    background: 'var(--bg-secondary)',
    border: '1px solid var(--border-primary)',
    cursor: 'pointer',
    transition: 'all 0.2s ease',
    color: 'var(--text-primary)',
    '&:hover': {
      background: 'var(--primary)',
      color: 'white',
    },
    '&:disabled': {
      opacity: 0.5,
      cursor: 'not-allowed',
    },
  },
  emptyState: {
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    justifyContent: 'center',
    padding: '3rem',
    background: 'var(--bg-primary)',
    borderRadius: '8px',
    textAlign: 'center',
    color: 'var(--text-secondary)',
  },
});

const CardContainer: React.FC = () => {
  const classes = useStyles();
  const { theme: appTheme } = useTheme();
  const theme = appTheme === 'dark' ? webDarkTheme : webLightTheme;

  const [topics, setTopics] = useState<ITopic[]>();
  const [currentTopicsPage, setCurrentTopicsPage] = useState<number>(1);
  const [currentTagsPage, setCurrentTagsPage] = useState<number>(1);
  const [tags, setTags] = useState<ITag[]>();
  const [inputPage, setInputPage] = useState<string>('');
  const [isLoading, setIsLoading] = useState<boolean>(true);
  const [refreshKey, setRefreshKey] = useState<number>(0);
  const cardsPerPage = 3;
  const navigate = useNavigate();

  useEffect(() => {
    const loadData = async () => {
      setIsLoading(true);
      try {
        const [fetchedTopics, fetchedTags] = await Promise.all([
          dashboardServices.fetchEntities('topics'),
          dashboardServices.fetchEntities('tags')
        ]);
        
        logger.log('Fetched topics:', fetchedTopics);
        setTopics(fetchedTopics);
        
        logger.log('Fetched tags:', fetchedTags);
        if (Array.isArray(fetchedTags)) {
          setTags(fetchedTags);
        } else {
          logger.error('Tags data is not an array:', fetchedTags);
        }
      } catch (error) {
        logger.error('Error fetching data:', error);
      } finally {
        setIsLoading(false);
      }
    };

    loadData();
  }, [refreshKey]);

  const refreshData = () => {
    setRefreshKey(prev => prev + 1);
  };

  const totalTopicCards = topics?.length || 0;
  const totalTopicPages = Math.max(1, Math.ceil(totalTopicCards / cardsPerPage));

  const totalTagCards = tags?.length || 0;
  const totalTagPages = Math.max(1, Math.ceil(totalTagCards / cardsPerPage));

  // Determine the topics to display on the current page
  const startTopicIndex = (currentTopicsPage - 1) * cardsPerPage;
  const currentTopics = topics?.slice(startTopicIndex, startTopicIndex + cardsPerPage);

  // Determine the tags to display on the current page
  const startTagIndex = (currentTagsPage - 1) * cardsPerPage;
  const currentTags = tags?.slice(startTagIndex, startTagIndex + cardsPerPage);

  const goToNextPage = (cardType = 'topic') => {
    switch (cardType) {
      case 'tag':
        setCurrentTagsPage((prev) => Math.min(prev + 1, totalTagPages));
        break;
      default:
        setCurrentTopicsPage((prev) => Math.min(prev + 1, totalTopicPages));
        break;
    }
  };

  const goToPreviousPage = (cardType = 'topic') => {
    switch (cardType) {
      case 'tag':
        setCurrentTagsPage((prev) => Math.max(prev - 1, 1));
        break;
      default:
        setCurrentTopicsPage((prev) => Math.max(prev - 1, 1));
        break;
    }
  };

  const _goToPage = (cardType = 'topic') => {
    const pageNumber = parseInt(inputPage, 10);
    let totalPages;

    switch (cardType) {
      case 'topic':
        totalPages = totalTopicPages;
        break;
      case 'tag':
        totalPages = totalTagPages;
        break;
      default:
        totalPages = totalTopicPages;
        break;
    }

    if (!isNaN(pageNumber) && pageNumber >= 1 && pageNumber <= totalPages) {
      switch (cardType) {
        case 'topic':
          setCurrentTopicsPage(pageNumber);
          setInputPage('');
          break;
        case 'tag':
          setCurrentTagsPage(pageNumber);
          setInputPage('');
          break;
      }
    } else {
      alert(`Please enter a valid page number between 1 and ${totalPages}.`);
    }
  };

  const renderTopics = () => {
    if (isLoading) {
      return (
        <div className="card-container__loading">
          <Loading size={50} color="var(--primary)" />
          <p>Loading topics...</p>
        </div>
      );
    }

    if (!topics || topics.length === 0) {
      return (
        <div className={classes.emptyState}>
          <img src="/empty-state.svg" alt="No topics" className="empty-state-icon" />
          <h3>No Topics Found</h3>
          <p>Start by adding your first topic</p>
          <Button 
            appearance="primary" 
            icon={<IconAdd />} 
            onClick={() => navigate('/topics/add')}
          >
            Add Topic
          </Button>
        </div>
      );
    }

    return (
      <div className={classes.cardsWrapper}>
        {currentTopics?.map((topic, index) => (
          <DashCard
            key={index}
            modelName='topic'
            modelId={topic.id}
            name={topic.name}
            title={topic.name}
            content={topic.technologyCategory}
            description={topic.description}
            imgPath="./TopicDefaultIcon.svg"
            imgAlt={topic.name}
          />
        ))}
      </div>
    );
  };

  const renderTags = () => {
    if (isLoading) {
      return (
        <div className="card-container__loading">
          <Loading size={50} color="var(--primary)" />
          <p>Loading tags...</p>
        </div>
      );
    }

    if (!tags || tags.length === 0) {
      return (
        <div className={classes.emptyState}>
          <img src="/empty-state.svg" alt="No tags" className="empty-state-icon" />
          <h3>No Tags Found</h3>
          <p>Start by adding your first tag</p>
          <Button 
            appearance="primary" 
            icon={<IconAdd />} 
            onClick={() => navigate('/tags/add')}
          >
            Add Tag
          </Button>
        </div>
      );
    }

    return (
      <div className={classes.cardsWrapper}>
        {currentTags?.map((tag) => (
          <DashCard
            key={tag.id}
            modelName='tag'
            modelId={tag.id}
            name={tag.name}
            title={tag.name}
            content={tag.slug}
            description={tag.description}
            imgPath="logoT.svg"
            imgAlt={tag.name}
          />
        ))}
      </div>
    );
  };

  const renderPagination = (currentPage: number, totalPages: number, type: string) => {
    if (totalPages <= 1) return null;

    return (
      <div className={classes.pagination}>
        <button 
          className="pagination-button prev"
          onClick={() => goToPreviousPage(type)}
          disabled={currentPage === 1}
          title="Previous Page"
        >
          <ArrowLeft24Regular />
        </button>
        
        <div className="pagination-pages">
          {Array.from({ length: Math.min(totalPages, 5) }, (_, i) => {
            // Logic to show pages around current page
            let pageNum;
            if (totalPages <= 5) {
              pageNum = i + 1;
            } else {
              const startPage = Math.max(1, currentPage - 2);
              const endPage = Math.min(totalPages, startPage + 4);
              pageNum = startPage + i;
              if (pageNum > endPage) return null;
            }
            
            return (
              <button 
                key={pageNum}
                className={`pagination-page ${pageNum === currentPage ? 'active' : ''}`}
                onClick={() => {
                  if (type === 'tag') {
                    setCurrentTagsPage(pageNum);
                  } else {
                    setCurrentTopicsPage(pageNum);
                  }
                }}
              >
                {pageNum}
              </button>
            );
          })}
        </div>
        
        <button 
          className="pagination-button next"
          onClick={() => goToNextPage(type)}
          disabled={currentPage === totalPages}
          title="Next Page"
        >
          <ArrowRight24Regular />
        </button>
        
        <div className="pagination-info">
          Page {currentPage} of {totalPages}
        </div>
      </div>
    );
  };

  return (
    <FluentProvider theme={theme}>
      <div className="card-container">
        {/* Topics Section */}
        <div className={classes.container}>
          <div className={classes.sectionHeader}>
            <h2 className={classes.sectionTitle}>
              <span className="section-icon topics">T</span>
              Topics
            </h2>
            <div className={classes.actionButtons}>
              <Button 
                icon={<Refresh24Regular />} 
                onClick={refreshData} 
                title="Refresh Data"
                className="action-button refresh"
              />
              <Button 
                icon={<Search24Regular />} 
                onClick={() => navigate('/topics/search')} 
                title="Search Topics"
                className="action-button search"
              />
              <Button 
                icon={<Filter24Regular />} 
                onClick={() => {}} 
                title="Filter Topics"
                className="action-button filter"
              />
              <Button 
                icon={<IconAdd />} 
                onClick={() => navigate('/topics/add')} 
                title="Add New Topic"
                appearance="primary"
                className="action-button add"
              >
                Add Topic
              </Button>
            </div>
          </div>
          
          {renderTopics()}
          {renderPagination(currentTopicsPage, totalTopicPages, 'topic')}
        </div>

        {/* Tags Section */}
        <div className={classes.container}>
          <div className={classes.sectionHeader}>
            <h2 className={classes.sectionTitle}>
              <span className="section-icon tags">T</span>
              Tags
            </h2>
            <div className={classes.actionButtons}>
              <Button 
                icon={<Refresh24Regular />} 
                onClick={refreshData} 
                title="Refresh Data"
                className="action-button refresh"
              />
              <Button 
                icon={<Search24Regular />} 
                onClick={() => navigate('/tags/search')} 
                title="Search Tags"
                className="action-button search"
              />
              <Button 
                icon={<Filter24Regular />} 
                onClick={() => {}} 
                title="Filter Tags"
                className="action-button filter"
              />
              <Button 
                icon={<IconAdd />} 
                onClick={() => navigate('/tags/add')} 
                title="Add New Tag"
                appearance="primary"
                className="action-button add"
              >
                Add Tag
              </Button>
            </div>
          </div>
          
          {renderTags()}
          {renderPagination(currentTagsPage, totalTagPages, 'tag')}
        </div>
      </div>
    </FluentProvider>
  );
};

export default CardContainer;
