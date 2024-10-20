import { Link } from "react-router-dom";
import { ITopic } from "../../interfaces/ITopic";
import { NotebookSectionArrowRight24Regular } from "@fluentui/react-icons/fonts";
import { useMemo } from "react";
import { IBlogPost } from "../../interfaces/IBlogPost";
import Loading from "../../components/Loading/Loading";

interface TopicsProps {
  topics: ITopic[];
}

const Topics = ({ topics }: TopicsProps) => {
  // Check if topics are empty, display loading indicator
  if (!topics || topics.length === 0) {
    return <Loading size={50} color="#ff4500" />;
  }

  // Use useMemo to memoize sorted topics to avoid sorting on every render
  const sortedTopics = useMemo(() => {
    return [...topics]
      .filter(topic => topic.name && topic.difficultyLevel) // Filter out topics without required fields
      .sort((a, b) => {
        const difficultyA = a.difficultyLevel ?? '';
        const difficultyB = b.difficultyLevel ?? '';

        // Sort by difficulty level
        const difficultyComparison = difficultyA.localeCompare(difficultyB);
        if (difficultyComparison !== 0) return difficultyComparison;

        // Sort by lastUpdated if difficulty levels are the same
        const lastUpdatedA = new Date(a.lastUpdated).getTime() || 0;
        const lastUpdatedB = new Date(b.lastUpdated).getTime() || 0;

        return lastUpdatedB - lastUpdatedA;
      });
  }, [topics]);

  return (
    <div className="flex flex-col space-y-4">
      {sortedTopics.length > 0 ? (
        sortedTopics.map((topic: ITopic) => {
          // Sort relatedPosts based on difficultyLevel
          const sortedRelatedPosts = useMemo(() => {
            return topic.relatedPosts
              ? [...topic.relatedPosts].sort((a: IBlogPost, b: IBlogPost) => {
                  const difficultyA = a.difficultyLevel ?? '';
                  const difficultyB = b.difficultyLevel ?? '';
                  return difficultyA.localeCompare(difficultyB);
                })
              : [];
          }, [topic.relatedPosts]);

          return (
            <details
              key={topic.id}
              className="border rounded shadow-sm"
            >
              <summary className="cursor-pointer bg-gray-900 p-4" aria-label={`Topic ${topic.name ?? 'No Name'}`}>
                <h3 className="text-xl font-semibold">
                  {topic.name || 'Unnamed Topic'}
                </h3>
                <p className="text-blue-200">
                  {topic.description || 'No description available.'}
                </p>
              </summary>
              <div className="p-4 bg-gray-100 text-black">
                <p>
                  <strong>Category:</strong> {topic.technologyCategory || 'Not specified'}
                </p>
                <p>
                  <strong>Difficulty:</strong> {topic.difficultyLevel || 'Not specified'}
                </p>
                <p className="mt-2">
                  <strong>Posts:</strong>
                </p>
                <ul className="list-disc list-inside">
                  {sortedRelatedPosts.length > 0 ? (
                    sortedRelatedPosts.map((post: IBlogPost) => (
                      <li key={post.id}>
                        <Link to={`/posts/${post.slug}`} className="text-blue-600 hover:underline">
                          {post.title || 'Untitled Post'}
                        </Link>
                      </li>
                    ))
                  ) : (
                    <li
                      key={`${topic.id}-no-posts`}
                      className="text-gray-600 mt-2 list-none scroll-ml-6 ml-8"
                    >
                      <NotebookSectionArrowRight24Regular
                        style={{ color: "red", fontSize: "24px" }}
                      />
                      No posts found
                    </li>
                  )}
                </ul>
              </div>
            </details>
          );
        })
      ) : (
        <p className="text-center text-gray-500">No topics available.</p>
      )}
    </div>
  );
};

export default Topics;
