import { useParams } from "react-router-dom";
import { useEffect, useState } from "react";
import axios from "axios";
import { IPost } from "../../interfaces/post-types";
import Wrapper from "../../layout/Wrapper";
import dashboardServices from "@/api/entityServices";
import { ITag } from "@fluentui/react";
import apiUrls from "@/api/getApiUrls";
import { logger } from "@/utils/logger";
import React from "react";

const PostDetail = () => {
    const { slug } = useParams<{ slug: string }>();
    const [post, setPost] = useState<IPost | null>(null);
    const [loading, setLoading] = useState<boolean>(true);
    const [error, setError] = useState<string | null>(null);
    const [tagNames, setTagNames] = useState<{name: string, id: string}[]>([]);
    const API_URL = apiUrls(window.location.hostname);
    logger.info(`API URL is: ${API_URL}`);

    useEffect(() => {
        axios
            .get(`${API_URL}/posts/${slug}`)
            .then((response) => {
                setPost(response.data);
                setLoading(false);
            })
            .catch((err) => {
                logger.error('Error loading post:', err);
                setError("Failed to load the post");
                setLoading(false);
            });
    }, [slug, API_URL]);

    useEffect(() => {
        const getTag = async (id: string) => {
            const tag = await dashboardServices.fetchEntityById("tags", id) as ITag;
            return {name: tag.name, id: String(tag.key)};
        };
        const getTagNames = async () => {
            if (post?.tags) {
                const tagPromises = post.tags.map(tag => getTag(tag));
                const tagNames = await Promise.all(tagPromises);
                setTagNames(tagNames);
            } else {
                setTagNames([]);
            }
        };
        getTagNames();
    }, [post]);

    if (loading) {
        return <p>Loading...</p>;
    }

    if (error || !post) {
        return <p>{error || "Post not found"}</p>;
    }

    const { title, content, author, publishedAt } = post;
    const formattedDate = publishedAt ? new Date(publishedAt).toLocaleDateString() : 'Date not available';
    const formattedTime = publishedAt ? new Date(publishedAt).toLocaleTimeString() : '';
    const formattedDateTime = formattedTime ? `${formattedDate} ${formattedTime}` : formattedDate;
    const formattedAuthor = author ? `Author: ${author}` : "";
    const formattedPostHeader = `${formattedDateTime} | ${formattedAuthor} `;
    const formattedContentWithBreaks = content.replace(/\n/g, "\n\n");
    const formattedPostHeaderWithBreaks = formattedPostHeader.replace(/\n/g, "\n\n");

    // Render the post header
    const header = (
        <div className="max-w-3xl mx-auto p-4">
            <h1 className="text-3xl font-bold mb-4">{title}</h1>
            <p className="text-gray-600 mb-6">{formattedPostHeaderWithBreaks}</p>
        </div>
    )
    // Render the post details
    return (
        <Wrapper pageTitle={post.title} header={header}>
            <div className="max-w-3xl mx-auto p-4">
                <div dangerouslySetInnerHTML={{ __html: formattedContentWithBreaks }} />
                <div>
                    <div className="tags space-x-4 mt-4">
                        Tags: {tagNames?.map(tag => (
                            <a key={tag.id} href={`/tags/${tag.id}`}>{tag.name}</a>
                        ))}
                    </div>
                </div>
            </div>
        </Wrapper>
    );
};

export default PostDetail;
