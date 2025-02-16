import { Link } from "react-router-dom";
import { ITopic } from "../../interfaces/ITopic";
import { NotebookSectionArrowRight24Regular } from "@fluentui/react-icons";
import { useMemo } from "react";
import { IPost } from "../../interfaces/post-types";
import Loading from "../../components/Loading/Loading";

interface TopicsProps {
  topics: ITopic[];
}

const Topics = ({ topics }: TopicsProps) => {
  // Memoized sorted topics for better performance
  const sortedTopics = useMemo(() => {
    return topics?.map(topic => ({
      ...topic,
      relatedPosts: topic.relatedPosts
        ? ([...topic.relatedPosts] as IPost[]).sort((a, b) => 
            (a.difficultyLevel !== undefined ? a.difficultyLevel.toString() : '')
              .localeCompare(b.difficultyLevel !== undefined ? b.difficultyLevel.toString() : ''))
        : [],
    }));
  }, [topics]);

  // Render loading indicator if topics are not available
  if (!topics || topics.length === 0) {
    return <Loading size={50} color="#ff4500" message="Loading topics..." />;
  }

  return (
    <div className="flex flex-col space-y-4">
      {sortedTopics.map((topic, index) => (
        <details key={topic.id} className="border rounded shadow-sm" open={index === 0}>
          <summary className="cursor-pointer p-4" aria-label={`Topic: ${topic.name}`}>
            <h3 className="text-xl font-semibold">{topic.name}</h3>
            {topic.description && <p className="text-gray-600">{topic.description}</p>}
          </summary>
          <div className="p-4 bg-gray-50 dark:bg-gray-800 rounded-b">
            <p>
              <strong>Category:</strong> {topic.technologyCategory || "N/A"}
            </p>
            <p>
              <strong>Difficulty:</strong> {topic.difficultyLevel || "N/A"}
            </p>
            <div className="mt-2">
              <strong>Posts:</strong>
              <ul className="list-disc list-inside mt-2">
                {topic.relatedPosts.length > 0 ? (
                  topic.relatedPosts.map(post => (
                    <li key={post.id}>
                      <Link to={`/posts/${post.slug}`} className="hover:underline text-blue-500 dark:text-blue-300">
                        {post.title}
                      </Link>
                    </li>
                  ))
                ) : (
                  <li className="flex items-center mt-2 text-gray-500 dark:text-gray-400">
                    <NotebookSectionArrowRight24Regular className="mr-2 text-red-500" />
                    No posts available for this topic.
                  </li>
                )}
              </ul>
            </div>
          </div>
        </details>
      ))}
    </div>
  );
};

export default Topics;
