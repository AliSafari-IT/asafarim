import { ITag } from "./ITag";
import { ITopic } from "./ITopic";

export interface IBlogPost {
    id: string;
    title: string;
    content: string;
    summary: string;
    publishedDate: string;
    author: string;
    slug: string;
    excerpt: string;
    viewCount: number;
    topicId: string;
    lastUpdated: string;
    isPublished: boolean;
    imageUrl: string;
    metaDescription: string;
    tags: ITag[];
    topic: ITopic; // Optional if you need topic info in posts
  }
  