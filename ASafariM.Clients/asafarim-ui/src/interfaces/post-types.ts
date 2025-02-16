import { DifficultyLevelEnum } from "./DifficultyLevelEnum";
import { EFileVisibility } from "./EFileVisibility";

export interface IPost {
    difficultyLevel?: DifficultyLevelEnum;
    id: string;
    name: string;
    title?: string;
    content: string;
    summary?: string;
    publishedAt?: string;
    author: string;
    slug?: string;
    excerpt?: string;
    viewCount?: number;
    isPublished?: boolean;
    imageUrl?: string;
    visibility?: EFileVisibility;
    metaDescription?: string;
    tags?: string[]; // tagIds
    topic?: string; // topicId
    createdAt: Date;
    updatedAt: Date;
  }
