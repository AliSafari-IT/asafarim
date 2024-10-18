import { Link } from "react-router-dom";
import { ITopic } from "../../interfaces/ITopic"; // Ensure you have IPost interface
import { NotebookSectionArrowRight24Regular } from "@fluentui/react-icons/fonts";
import { useMemo } from "react";
import { IBlogPost } from "../../interfaces/IBlogPost";

interface TopicsProps {
  topics: ITopic[];
}

const Topics = ({ topics }: TopicsProps) => {
  if (!topics || topics.length === 0) {
    return <p>Loading...</p>;
  }

  // Use useMemo to memoize sorted topics
  const sortedTopics = useMemo(() => {
    return [...topics].sort((a, b) => {
      // First, sort by difficulty level
      const difficultyComparison = a.difficultyLevel.localeCompare(b.difficultyLevel);
      if (difficultyComparison !== 0) return difficultyComparison;

      // If difficulty levels are the same, sort by lastUpdated
      return new Date(b.lastUpdated).getTime() - new Date(a.lastUpdated).getTime();
    });
  }, [topics]);

  return (
    <div className="flex flex-col space-y-4">
      {sortedTopics.map((topic: ITopic) => {
        // Sort relatedPosts based on difficultyLevel
        const sortedRelatedPosts = topic.relatedPosts
          ? [...topic.relatedPosts].sort((a: IBlogPost, b: IBlogPost) =>
              a.difficultyLevel.localeCompare(b.difficultyLevel)
            )
          : [];

        return (
          <details key={topic.id} className="border rounded shadow-sm">
            <summary className="cursor-pointer bg-gray-100 p-4" aria-label={`Topic ${topic.name}`}>
              <h3 className="text-xl font-semibold">{topic.name}</h3>
              <p className="text-gray-600">{topic.description}</p>
            </summary>
            <div className="p-4 bg-white">
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
                  <li
                    key={topic.id}
                    className="text-gray-600 mt-2 list-none scroll-ml-6 ml-8 "
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
      })}
    </div>
  );
};

export default Topics;
