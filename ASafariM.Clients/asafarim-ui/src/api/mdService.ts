
// E:\ASafariM\ASafariM.Clients\asafarim-ui\src\api\mdService.ts

import axios from "axios";

export const createMarkdownFile = async (title: string, content: string, visibility: string) => {
    try {
        const auth = JSON.parse(localStorage.getItem('auth') || '{}');
        const response = await axios.post('/api/MarkdownFiles', {
            title,
            content,
            visibility,
            authorId: auth.userId // Include the author ID from auth
        }, {
            headers: { Authorization: `Bearer ${auth.token}` }
        });
        return response.data;
    } catch (error) {
        console.error('Error creating markdown file:', error);
        throw error;
    }
};

export const getMarkdownFileById = async (id: string) => {
    try {
        const auth = JSON.parse(localStorage.getItem('auth') || '{}');
        const response = await axios.get(`/api/MarkdownFiles/${id}`, {
            headers: { Authorization: `Bearer ${auth.token}` }
        });
        console.log('Markdown file retrieved:', response.data);
        return response.data;
    } catch (error) {
        console.error('Error retrieving markdown file:', error);
        throw error;
    }
};

export const updateMarkdownFile = async (id: string, title: string, content: string, visibility: string) => {
    try {
        const auth = JSON.parse(localStorage.getItem('auth') || '{}');
        const response = await axios.put(`/api/MarkdownFiles/${id}`, {
            title,
            content,
            visibility,
        }, {
            headers: { Authorization: `Bearer ${auth.token}` }
        });
        console.log('Markdown file updated:', response.data);
        return response.data;
    } catch (error) {
        console.error('Error updating markdown file:', error);
        throw error;
    }
};

export const deleteMarkdownFile = async (id: string) => {
    try {
        const auth = JSON.parse(localStorage.getItem('auth') || '{}');
        const response = await axios.delete(`/api/MarkdownFiles/${id}`, {
            headers: { Authorization: `Bearer ${auth.token}` }
        });
        console.log('Markdown file deleted:', response.data);
    } catch (error) {
        console.error('Error deleting markdown file:', error);
        throw error;
    }
};

export const deleteMarkdownFiles = async (ids: string[]) => {
    try {
        const auth = JSON.parse(localStorage.getItem('auth') || '{}');
        const response = await axios.delete(`/api/MarkdownFiles`, {
            headers: { Authorization: `Bearer ${auth.token}` },
            data: { ids }
        });
        console.log('Markdown files deleted:', response.data);
        return response.data;
    } catch (error) {
        console.error('Error deleting markdown files:', error);
        throw error;
    }
};
