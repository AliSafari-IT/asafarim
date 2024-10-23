// E:\asm\apps\dashboard-client\src\api\dashboardServices.ts
import axios from "axios";
import API_URL from "./getApiUrls";

// Get topics from the API
const fetchTopics = async () => {
    const response = await fetch(`${API_URL}/topics`);
    const topics = await response.json();
    return topics;
}

// Get blog posts from the API
const fetchBlogPosts = async () => {
    const response = await fetch(`${API_URL}/blogPosts`);
    const blogPosts = await response.json();
    return blogPosts;
}

// Get sitemap from the API
const fetchSitemap = async () => {
    const response = await fetch(`${API_URL}/sitemap`);
    const sitemap = await response.json();
    return sitemap;
}

// Get users from the API
const fetchUsers = async () => {
    const response = await fetch(`${API_URL}/users`);
    const users = await response.json();
    return users;
}

// Get roles from the API
const fetchRoles = async () => {
    const response = await fetch(`${API_URL}/roles`);
    const roles = await response.json();
    return roles;
}

// Get tags from the API
const fetchTags = async () => {
    try {
        const response = await axios.get(`${API_URL}/tags`);
        return response.data;
    } catch (error) {
        console.error('Error fetching tags:', error);
        return [];
    }
}

const addTag = async (tag: { name: string, title: string }) => {
    const { name: tagName, title: tagTitle } = tag;
    try {
        await axios.post(`${API_URL}/tags`, { name: tagName, title: tagTitle });
    } catch (error) {
        console.error('Error adding tag:', error);
    } finally {
        window.location.reload();
    }
}

const deleteTag = async (tagId: string) => {
    try {
        await axios.delete(`${API_URL}/tags/${tagId}`);
    } catch (error) {
        console.error('Error deleting tag:', error);
        throw new Error('Failed to delete tag');
    }
}

// deleteTopic
const deleteTopic = async (topicId: string) => {
    try {
        await axios.delete(`${API_URL}/topics/${topicId}`);
    } catch (error) {
        console.error('Error deleting topic:', error);
        throw new Error('Failed to delete topic');
    }
}

// deleteBlogPost
const deleteBlogPost = async (blogPostId: string) => {
    try {
        await axios.delete(`${API_URL}/blogPosts/${blogPostId}`);
    } catch (error) {
        console.error('Error deleting blog post:', error);
        throw new Error('Failed to delete blog post');
    }
}
const dashboardServices = { fetchTopics, fetchBlogPosts, fetchSitemap, fetchUsers, fetchRoles, fetchTags, addTag,
    deleteTag, deleteTopic, deleteBlogPost };

export default dashboardServices;