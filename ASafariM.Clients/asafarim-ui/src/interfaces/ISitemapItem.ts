import { IRoleEnum } from "./IRole";
import { ITopic } from "./ITopic";

export interface ISitemapItem {
  id: string;
  pageName: string;
  description: string;
  slug: string;
  accessByRole?: IRoleEnum;
  parent?: string;  // SitemapItem Id
  topics?: ITopic[];
  children?: string[]; // SitemapItemIds
  order?: number;
  icon?: string;
  isActive: boolean;
  isExternalLink?: boolean;
  externalLink?: string;
  isHidden?: boolean;
  isDisabled?: boolean;
  isDeleted?: boolean;
  createdBy?: string;
  createdAt?: Date;
  updatedBy?: string;
  updatedAt?: Date;
  deletedBy?: string;
  deletedDate?: Date;
  version?: string;
  isPublished?: boolean;
  publishedBy?: string;
  publishedDate?: Date;
  unpublishBy?: string;
  unpublishDate?: Date;
  isUnpublished?: boolean;
  isDraft?: boolean;
  isArchived?: boolean;
  archivedBy?: string;
  archivedDate?: Date; 
}


