import { EFileVisibility } from "./EFileVisibility";

export interface IMarkdownFile {
    id: string;
    name?: string;
    title?: string;
    content: string;
    projectId?: string;
    authorId?: string;
    dateCreated?: string;
    dateModified?: string;
    visibility?: EFileVisibility.OnlyMe | EFileVisibility.Public | EFileVisibility.Protected;
}

