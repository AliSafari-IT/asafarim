import React, { useState } from "react";
import { createMarkdownFile } from "@/api/mdService";
import "./CreateMarkdownFile.css";

const CreateMarkdownFile = () => {
    const [title, setTitle] = useState("");
    const [content, setContent] = useState("");
    const [visibility, setVisibility] = useState("Public");

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        try {
            const data = await createMarkdownFile(title, content, visibility);
            console.log("Markdown file created:", data);
            // Clear the form after successful creation
            setTitle("");
            setContent("");
            setVisibility("Public");
        } catch (error: any) {
            console.error("Error creating markdown file:", error);
            if (error.response?.data?.errors) {
                // Handle validation errors
                console.error("Validation errors:", error.response.data.errors);
            }
        }
    };

    return (
        <div className="create-markdown-container">
            <h2 className="create-markdown-title">Create New Markdown File</h2>
            <form onSubmit={handleSubmit} className="create-markdown-form">
                <div className="form-group">
                    <label htmlFor="title" className="form-label">Title:</label>
                    <input
                        id="title"
                        type="text"
                        value={title}
                        onChange={(e) => setTitle(e.target.value)}
                        required
                        className="form-input"
                        placeholder="Enter title"
                    />
                </div>
                <div className="form-group">
                    <label htmlFor="content" className="form-label">Content:</label>
                    <textarea
                        id="content"
                        value={content}
                        onChange={(e) => setContent(e.target.value)}
                        required
                        className="form-textarea"
                        placeholder="Enter markdown content"
                        rows={10}
                    />
                </div>
                <div className="form-group">
                    <label htmlFor="visibility" className="form-label">Visibility:</label>
                    <select
                        id="visibility"
                        value={visibility}
                        onChange={(e) => setVisibility(e.target.value)}
                        className="form-select"
                    >
                        <option value="Public">Public</option>
                        <option value="MembersOnly">Members Only</option>
                    </select>
                </div>
                <button type="submit" className="submit-button">
                    Create Markdown File
                </button>
            </form>
        </div>
    );
};

export default CreateMarkdownFile;
