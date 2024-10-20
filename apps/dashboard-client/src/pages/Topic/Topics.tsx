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
    return [...topics].sort((a, b) => {
      // Ensure difficultyLevel is defined for comparison
      const difficultyA = a.difficultyLevel ?? '';
      const difficultyB = b.difficultyLevel ?? '';

      // First, sort by difficulty level
      const difficultyComparison = difficultyA.localeCompare(difficultyB);
      if (difficultyComparison !== 0) return difficultyComparison;

      // If difficulty levels are the same, sort by lastUpdated
      const lastUpdatedA = new Date(a.lastUpdated).getTime() || 0;
      const lastUpdatedB = new Date(b.lastUpdated).getTime() || 0;

      return lastUpdatedB - lastUpdatedA;
    });
  }, [topics]);

  return (
    <div className="flex flex-col space-y-4">
      {sortedTopics.map((topic: ITopic) => {
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
          <details key={topic.id} className="border rounded shadow-sm" open>
            <summary className="cursor-pointer bg-gray-900 p-4" aria-label={`Topic ${topic.name}`}>
              <h3 className="text-xl font-semibold">{topic.name}</h3>
              <p className="text-blue-200">{topic.description}</p>
            </summary>
            <div className="p-4 bg-gray-100 text-black">
              <p>
                <strong>Category:</strong> {topic.technologyCategory}
              </p>
              <p>
                <strong>Difficulty:</strong> {topic.difficultyLevel}
              </p>
              <p className="mt-2">
                <strong>Posts:</strong>
              </p>
              <ul className="list-disc list-inside">
                {sortedRelatedPosts.length > 0 ? (
                  sortedRelatedPosts.map((post: IBlogPost) => (
                    <li key={post.id}>
                      <Link to={`/posts/${post.slug}`} className="text-blue-600 hover:underline">
                        {post.title}
                      </Link>
                    </li>
                  ))
                ) : (
                  <li key={topic.id} className="text-gray-600 mt-2 list-none scroll-ml-6 ml-8">
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
      })}
    </div>
  );
};

export default Topics;
