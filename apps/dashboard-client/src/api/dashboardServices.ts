// E:\asm\apps\dashboard-client\src\api\dashboardServices.ts
import axios from "axios";
import API_URL from "./getApiUrls";
import { ITag } from "../interfaces/ITag";

// CRUD operations for topics from the API
const fetchTopics = async () => {
    const response = await fetch(`${API_URL}/topics`);
    const topics = await response.json();
    return topics;
}

const fetchTopicById = async (topicId: string) => {
    const response = await fetch(`${API_URL}/topics/${topicId}`);
    const topic = await response.json();
    return topic;
}

const addTopic = async (topic: { name: string, title: string }) => {
    const { name: topicName, title: topicTitle } = topic;
    try {
        await axios.post(`${API_URL}/topics`, { name: topicName, title: topicTitle });
    } catch (error) {
        console.error('Error adding topic:', error);
        throw new Error('Failed to add topic');
    }
}

const deleteTopic = async (topicId: string) => {
    try {
        await axios.delete(`${API_URL}/topics/${topicId}`);
    } catch (error) {
        console.error('Error deleting topic:', error);
        throw new Error('Failed to delete topic');
    }
}

const updateTopic = async (topicId: string, topic: { name: string, title: string }) => {
    const { name: topicName, title: topicTitle } = topic;
    try {
        await axios.put(`${API_URL}/topics/${topicId}`, { name: topicName, title: topicTitle });
    } catch (error) {
        console.error('Error updating topic:', error);
        throw new Error('Failed to update topic');
    }
}

// CRUD operations for blog posts from the API
const fetchBlogPosts = async () => {
    const response = await fetch(`${API_URL}/blogPosts`);
    const blogPosts = await response.json();
    return blogPosts;
}

const fetchBlogPostById = async (blogPostId: string) => {
    const response = await fetch(`${API_URL}/blogPosts/${blogPostId}`);
    const blogPost = await response.json();
    return blogPost;
}

const addBlogPost = async (blogPost: { name: string, title: string }) => {
    const { name: blogPostName, title: blogPostTitle } = blogPost;
    try {
        await axios.post(`${API_URL}/blogPosts`, { name: blogPostName, title: blogPostTitle });
    } catch (error) {
        console.error('Error adding blog post:', error);
        throw new Error('Failed to add blog post');
    }
}
const deleteBlogPost = async (blogPostId: string) => {
    try {
        await axios.delete(`${API_URL}/blogPosts/${blogPostId}`);
    } catch (error) {
        console.error('Error deleting blog post:', error);
        throw new Error('Failed to delete blog post');
    }
}

const updateBlogPost = async (blogPostId: string, blogPost: { name: string, title: string }) => {
    const { name: blogPostName, title: blogPostTitle } = blogPost;
    try {
        await axios.put(`${API_URL}/blogPosts/${blogPostId}`, { name: blogPostName, title: blogPostTitle });
    } catch (error) {
        console.error('Error updating blog post:', error);
        throw new Error('Failed to update blog post');
    }
}

// CRUD operations for sitemap from the API
const fetchSitemap = async () => {
    const response = await fetch(`${API_URL}/sitemap`);
    const sitemap = await response.json();
    return sitemap;
}

// CRUD operations for users from the API
const fetchUsers = async () => {
    const response = await fetch(`${API_URL}/users`);
    const users = await response.json();
    return users;
}

// CRUD operations for roles from the API
const fetchRoles = async () => {
    const response = await fetch(`${API_URL}/roles`);
    const roles = await response.json();
    return roles;
}

// CRUD operations for tags from the API
const fetchTags = async () => {
    try {
        const response = await axios.get(`${API_URL}/tags`);
        return response.data;
    } catch (error) {
        console.error('Error fetching tags:', error);
        return [];
    }
}
const fetchTagById = (tagId: string) => {
    return axios.get(`${API_URL}/tags/${tagId}`);
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

const updateTag = async (tag: ITag) => {
    const { id, ...rest } = tag;
    return axios.put(`${API_URL}/tags/${id}`, rest)
        .catch(error => {
            console.error('Error updating tag:', error);
            throw new Error('Failed to update tag');
        });
}


// CRUD operations for entities from the API

const fetchEntities = async (entityTableName: string) => {
    return axios.get(`${API_URL}/${entityTableName}s`)
        .catch(error => {
            console.error('Error fetching entities:', error);
            throw new Error('Failed to fetch entities: ' + entityTableName);
        });
}

const fetchEntityById = async (entityTableName: string, id: string) => {
    console.log(`Fetching entity by ID from ${entityTableName}`, id);
    return axios.get(`${API_URL}/${entityTableName}/${id}`)
        .then(response => {
            console.log(`Fetched entity by ID from ${entityTableName}`, response.data);
            return response.data;
        })
        .catch(error => {
            console.error(`Error fetching entity by ID from ${entityTableName}`, error);
            throw new Error('Failed to fetch entity: ' + entityTableName);
        });
}


/**
 * Add a new entity to the specified table.
 * 
 * @param entityTableName - The name of the entity table.
 * @param data - The data of the entity to be added.
 * @throws Will throw an error if the request fails.
 */
const addEntity = async (entityTableName: string, data: any) => {
    console.log(`Adding entity to ${entityTableName}`, data);
    // Send a POST request to add a new entity
    return axios.post(`${API_URL}/${entityTableName}`, data)
        .then(response => {
            console.log(`Added entity to ${entityTableName}`, response.data);
            return response.data;
        })
        .catch(error => {
            console.error(`Error adding entity to ${entityTableName}`, error);
            // Throw a new error with a message indicating the failure
            throw new Error('Failed to add entity: ' + entityTableName);
        });
}
const updateEntity = async (entityTableName: string, id: string, data: any) => {
    const url = `${API_URL}/${entityTableName}/${id}`;
    console.log(`Updating entity in ${entityTableName}: ID: ${id}`, data); // Log the data being sent

    return axios.put(url, data)  // Do not include the 'id' in the data object
        .then(response => {
            console.log(`Updated entity in ${entityTableName}`, response.data);
            return response.data;
        })
        .catch(error => {
            console.error(`Error updating entity in ${entityTableName}`, error);
            throw new Error('Failed to update entity: ' + entityTableName);
        });
};


const deleteEntity = async (entityTableName: string, id: string) => {
    return axios.delete(`${API_URL}/${entityTableName}/${id}`)
        .catch(error => {
            console.error('Error deleting entity:', error);
            throw new Error('Failed to delete entity: ' + entityTableName);
        });
}


const dashboardServices = {
    // Entity
    fetchEntities, fetchEntityById, addEntity, updateEntity, deleteEntity, 
};

export default dashboardServices;

