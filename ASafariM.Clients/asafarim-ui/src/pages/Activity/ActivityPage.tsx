import React, { useState, useEffect } from 'react';
import { format } from 'date-fns';
import Layout from '../../layout/Layout';
import Header from '../../layout/Header/Header';
import Footer from '../../layout/Footer/Footer';
import axios from 'axios';
import { trackEvent } from '../../services/analyticsService';
import useAuth from '../../hooks/useAuth';

// Activity interface
interface Activity {
  id: number;
  type: string;
  title: string;
  description: string;
  timestamp: Date;
  user: {
    id: number;
    name: string;
    avatar: string;
  };
}

// Mock data for activities
const mockActivities: Activity[] = [
  {
    id: 1,
    type: 'blog_post',
    title: 'New Blog Post: Getting Started with React',
    description: 'A new blog post has been published about React fundamentals',
    timestamp: new Date(2025, 2, 10, 14, 30),
    user: {
      id: 101,
      name: 'Ali Safari',
      avatar: 'https://via.placeholder.com/40'
    }
  },
  {
    id: 2,
    type: 'project_update',
    title: 'Project Updated: ASafariM Website',
    description: 'The main website project has been updated with new features',
    timestamp: new Date(2025, 2, 12, 9, 15),
    user: {
      id: 102,
      name: 'John Doe',
      avatar: 'https://via.placeholder.com/40'
    }
  },
  {
    id: 3,
    type: 'comment',
    title: 'New Comment on "TypeScript Best Practices"',
    description: 'Someone commented on your TypeScript article',
    timestamp: new Date(2025, 2, 13, 16, 45),
    user: {
      id: 103,
      name: 'Jane Smith',
      avatar: 'https://via.placeholder.com/40'
    }
  },
  {
    id: 4,
    type: 'user_joined',
    title: 'New User Joined',
    description: 'A new user has registered on the platform',
    timestamp: new Date(2025, 2, 14, 8, 20),
    user: {
      id: 104,
      name: 'Robert Johnson',
      avatar: 'https://via.placeholder.com/40'
    }
  },
  {
    id: 5,
    type: 'system_update',
    title: 'System Maintenance Completed',
    description: 'The scheduled system maintenance has been completed successfully',
    timestamp: new Date(2025, 2, 14, 2, 0),
    user: {
      id: 105,
      name: 'System',
      avatar: 'https://via.placeholder.com/40'
    }
  }
];

// Activity type icons mapping
const activityIcons: Record<string, string> = {
  blog_post: '📝',
  project_update: '🚀',
  comment: '💬',
  user_joined: '👤',
  system_update: '🔧'
};

const ActivityPage: React.FC = () => {
  const [activities, setActivities] = useState<Activity[]>([]);
  const [filter, setFilter] = useState<string | null>(null);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);
  const { authenticated, token } = useAuth();

  // Track page view
  useEffect(() => {
    // Track this page view as an event
    trackEvent('page_interaction', 'view_activity_page');
  }, []);

  // Fetch activities data
  useEffect(() => {
    const fetchActivities = async () => {
      setLoading(true);
      try {
        // Try to fetch from API first
        const response = await axios.get('/api/activities', {
          headers: token ? { Authorization: `Bearer ${token}` } : {},
          timeout: 5000
        });
        
        // If successful, use the API data
        if (response.data && Array.isArray(response.data)) {
          const formattedActivities = response.data.map((activity: any) => ({
            ...activity,
            timestamp: new Date(activity.timestamp)
          }));
          setActivities(formattedActivities);
          setError(null);
        } else {
          // Fallback to mock data if API response is not as expected
          console.warn('API response format not as expected, using mock data');
          setActivities(mockActivities);
        }
      } catch (err) {
        console.warn('Error fetching activities, using mock data:', err);
        // If API call fails, use mock data
        setActivities(mockActivities);
        setError('Could not fetch real activity data. Showing mock data for demonstration.');
      } finally {
        setLoading(false);
      }
    };

    fetchActivities();
  }, [token]);

  // Filter activities by type
  const filteredActivities = filter 
    ? activities.filter(activity => activity.type === filter)
    : activities;

  return (
    <Layout header={<Header />} footer={<Footer />}>
      <div className="container mx-auto px-4 py-8">
        <h1 className="text-3xl font-bold mb-6">Activity Feed</h1>
        
        {/* Filter buttons */}
        <div className="mb-6 flex flex-wrap gap-2">
          <button 
            className={`px-4 py-2 rounded-md ${filter === null ? 'bg-primary text-white' : 'bg-gray-200 dark:bg-gray-700'}`}
            onClick={() => setFilter(null)}
          >
            All
          </button>
          <button 
            className={`px-4 py-2 rounded-md ${filter === 'blog_post' ? 'bg-primary text-white' : 'bg-gray-200 dark:bg-gray-700'}`}
            onClick={() => setFilter('blog_post')}
          >
            Blog Posts
          </button>
          <button 
            className={`px-4 py-2 rounded-md ${filter === 'project_update' ? 'bg-primary text-white' : 'bg-gray-200 dark:bg-gray-700'}`}
            onClick={() => setFilter('project_update')}
          >
            Project Updates
          </button>
          <button 
            className={`px-4 py-2 rounded-md ${filter === 'comment' ? 'bg-primary text-white' : 'bg-gray-200 dark:bg-gray-700'}`}
            onClick={() => setFilter('comment')}
          >
            Comments
          </button>
          <button 
            className={`px-4 py-2 rounded-md ${filter === 'user_joined' ? 'bg-primary text-white' : 'bg-gray-200 dark:bg-gray-700'}`}
            onClick={() => setFilter('user_joined')}
          >
            New Users
          </button>
          <button 
            className={`px-4 py-2 rounded-md ${filter === 'system_update' ? 'bg-primary text-white' : 'bg-gray-200 dark:bg-gray-700'}`}
            onClick={() => setFilter('system_update')}
          >
            System Updates
          </button>
        </div>
        
        {/* Error message */}
        {error && (
          <div className="bg-yellow-100 border-l-4 border-yellow-500 text-yellow-700 p-4 mb-6" role="alert">
            <p>{error}</p>
          </div>
        )}
        
        {/* Loading state */}
        {loading ? (
          <div className="flex justify-center items-center py-12">
            <div className="animate-spin rounded-full h-12 w-12 border-t-2 border-b-2 border-primary"></div>
          </div>
        ) : (
          /* Activity list */
          <div className="space-y-4">
            {filteredActivities.length > 0 ? (
              filteredActivities.map(activity => (
                <div key={activity.id} className="bg-white dark:bg-gray-800 rounded-lg shadow-md p-4 flex items-start">
                  <div className="mr-4 text-2xl" aria-hidden="true">
                    {activityIcons[activity.type] || '📌'}
                  </div>
                  <div className="flex-1">
                    <div className="flex items-center mb-2">
                      <img 
                        src={activity.user.avatar} 
                        alt={activity.user.name} 
                        className="w-6 h-6 rounded-full mr-2" 
                      />
                      <span className="font-medium text-sm">{activity.user.name}</span>
                      <span className="mx-2 text-gray-400">•</span>
                      <span className="text-sm text-gray-500 dark:text-gray-400">
                        {format(activity.timestamp, 'MMM d, yyyy h:mm a')}
                      </span>
                    </div>
                    <h3 className="font-semibold mb-1">{activity.title}</h3>
                    <p className="text-gray-600 dark:text-gray-300 text-sm">{activity.description}</p>
                  </div>
                </div>
              ))
            ) : (
              <div className="text-center py-8 text-gray-500 dark:text-gray-400">
                No activities found with the selected filter.
              </div>
            )}
          </div>
        )}
      </div>
    </Layout>
  );
};

export default ActivityPage;
