import { EFileVisibility } from "./EFileVisibility";


export interface IMarkdownFileUser {
    markdownFileId?: string;
    userId?: string;
    visibility?: EFileVisibility;
}
