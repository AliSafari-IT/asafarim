import { logger } from "@/utils/logger";
import dashboardServices from "../../api/entityServices";
import { useNavigate } from "react-router-dom";


const AddPostForm: React.FC = () => {
  const navigator = useNavigate();
  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    const formData = new FormData(e.currentTarget);
    
    const post = {
      Id: formData.get('id') as string,
      Title: formData.get('title') as string,
      Content: formData.get('content') as string,
      Summary: formData.get('summary') as string,
      Excerpt: formData.get('excerpt') as string,
      Slug: formData.get('slug') as string,
      PublishedDate: formData.get('publishedDate') as string,
      Author: formData.get('author') as string,
      ViewCount: parseInt(formData.get('viewCount') as string),
      CommentCount: parseInt(formData.get('commentCount') as string),
      IsPublished: formData.get('isPublished') === 'on',
      IsDraft: formData.get('isDraft') === 'on',
      ImageUrl: formData.get('imageUrl') as string,
      VideoUrl: formData.get('videoUrl') as string,
      AudioUrl: formData.get('audioUrl') as string,
      CreatedAt: formData.get('createdAt') as string,
      UpdatedAt: formData.get('updatedAt') as string,
      CreatedBy: formData.get('createdBy') as string,
      UpdatedBy: formData.get('updatedBy') as string,
      Status: parseInt(formData.get('status') as string),
      StatusMessage: formData.get('statusMessage') as string,
      StatusColor: formData.get('statusColor') as string,
      StatusIcon: formData.get('statusIcon') as string,
      StatusTooltip: formData.get('statusTooltip') as string,
      IsDeleted: formData.get('isDeleted') === 'on',
      DeletedAt: formData.get('deletedAt') as string,
      DeletedBy: formData.get('deletedBy') as string,
      DeletedMessage: formData.get('deletedMessage') as string,
      PostId: formData.get('postId') as string,
    };

    try {
      await dashboardServices.addEntity('posts', post);
      navigator('/dashboard');
    } catch (error) {
      logger.error('Error adding post:', error);
    }
  };

  return (
    <form onSubmit={handleSubmit} className="space-y-4 p-4 max-w-2xl">
      <div className="space-y-4">
        <div>
          <label htmlFor="title" className="block text-sm font-medium text-gray-700">
            Title
          </label>
          <input
            type="text"
            name="title"
            id="title"
            required
            className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
          />
        </div>

        <div>
          <label htmlFor="slug" className="block text-sm font-medium text-gray-700">
            Slug
          </label>
          <input
            type="text"
            name="slug"
            id="slug"
            className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
          />
        </div>

        <div>
          <label htmlFor="excerpt" className="block text-sm font-medium text-gray-700">
            Excerpt
          </label>
          <textarea
            name="excerpt"
            id="excerpt"
            rows={3}
            className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
          />
        </div>

        <div>
          <label htmlFor="summary" className="block text-sm font-medium text-gray-700">
            Summary
          </label>
          <textarea
            name="summary"
            id="summary"
            rows={4}
            className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
          />
        </div>

        <div>
          <label htmlFor="content" className="block text-sm font-medium text-gray-700">
            Content
          </label>
          <textarea
            name="content"
            id="content"
            required
            rows={8}
            className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
          />
        </div>

        <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
          <div>
            <label htmlFor="difficultyLevel" className="block text-sm font-medium text-gray-700">
              Difficulty Level
            </label>
            <select
              name="difficultyLevel"
              id="difficultyLevel"
              required
              className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
            >
              <option value="Easy">Easy</option>
              <option value="Medium">Medium</option>
              <option value="Hard">Hard</option>
            </select>
          </div>

          <div>
            <label htmlFor="imageUrl" className="block text-sm font-medium text-gray-700">
              Featured Image URL
            </label>
            <input
              type="url"
              name="imageUrl"
              id="imageUrl"
              className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
              placeholder="https://example.com/image.jpg"
            />
          </div>
        </div>

        <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
          <div>
            <label htmlFor="publishedDate" className="block text-sm font-medium text-gray-700">
              Published Date
            </label>
            <input
              type="datetime-local"
              name="publishedDate"
              id="publishedDate"
              className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
            />
          </div>

          <div>
            <label htmlFor="author" className="block text-sm font-medium text-gray-700">
              Author
            </label>
            <input
              type="text"
              name="author"
              id="author"
              className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
              placeholder="Enter author name"
            />
          </div>
        </div>

        <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
          <div>
            <label htmlFor="status" className="block text-sm font-medium text-gray-700">
              Status
            </label>
            <select
              name="status"
              id="status"
              className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
            >
              <option value="1">Draft</option>
              <option value="2">Pending Review</option>
              <option value="3">Published</option>
              <option value="4">Archived</option>
            </select>
          </div>

          <div>
            <label htmlFor="viewCount" className="block text-sm font-medium text-gray-700">
              View Count
            </label>
            <input
              type="number"
              name="viewCount"
              id="viewCount"
              defaultValue="0"
              className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
            />
          </div>
        </div>

        <div className="space-y-2">
          <div className="flex items-center">
            <input
              type="checkbox"
              name="isPublished"
              id="isPublished"
              className="h-4 w-4 text-blue-600 focus:ring-blue-500 border-gray-300 rounded"
            />
            <label htmlFor="isPublished" className="ml-2 block text-sm text-gray-700">
              Is Published
            </label>
          </div>

          <div className="flex items-center">
            <input
              type="checkbox"
              name="isDraft"
              id="isDraft"
              className="h-4 w-4 text-blue-600 focus:ring-blue-500 border-gray-300 rounded"
            />
            <label htmlFor="isDraft" className="ml-2 block text-sm text-gray-700">
              Is Draft
            </label>
          </div>

          <div className="flex items-center">
            <input
              type="checkbox"
              name="isActive"
              id="isActive"
              className="h-4 w-4 text-blue-600 focus:ring-blue-500 border-gray-300 rounded"
            />
            <label htmlFor="isActive" className="ml-2 block text-sm text-gray-700">
              Is Active
            </label>
          </div>

          <div className="flex items-center">
            <input
              type="checkbox"
              name="isDeleted"
              id="isDeleted"
              className="h-4 w-4 text-blue-600 focus:ring-blue-500 border-gray-300 rounded"
            />
            <label htmlFor="isDeleted" className="ml-2 block text-sm text-gray-700">
              Is Deleted
            </label>
          </div>
        </div>

        <div>
          <label htmlFor="tags" className="block text-sm font-medium text-gray-700">
            Tags (comma-separated)
          </label>
          <input
            type="text"
            name="tags"
            id="tags"
            className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
            placeholder="tag1, tag2, tag3"
          />
          <p className="text-sm text-gray-500 mt-1">Separate tags with commas</p>
        </div>

        <button
          type="submit"
          className="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-blue-600 hover:bg-blue-700"
        >
          Add Post
        </button>
      </div>
    </form>
  );
};

export default AddPostForm;