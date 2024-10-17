import { Link } from "react-router-dom";
import { ITopic } from "../../interfaces/ITopic";

interface TopicsProps {
    topics: ITopic[];
}

const Topics = ({topics}: TopicsProps) => {

    return (
        <div className="flex flex-col space-y-4">
        {topics?.map((topic: ITopic) => (
          <details key={topic.id} className="border rounded shadow-sm">
            <summary className="cursor-pointer bg-gray-100 p-4">
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
                {topic.relatedPosts && topic.relatedPosts.length > 0 ? (
                  topic.relatedPosts.map((post) => (
                    <li key={post.id}>
                      <Link to={`/posts/${post.slug}`} className="text-blue-600 hover:underline">
                        {post.title}
                      </Link>
                    </li>
                  ))
                ) : (
                  <li>No posts available</li>
                )}
              </ul>
            </div>
          </details>
        ))}
      </div>
    );
}

export default Topics;