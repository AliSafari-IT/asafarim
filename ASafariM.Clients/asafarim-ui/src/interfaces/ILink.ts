export interface ILink {
  id: string;
  url: string;
  name: string;
  description?: string;
  projectId?: string;
  createdAt?: Date;
  updatedAt?: Date | null;
  isDeleted?: boolean;
  deletedBy?: string | null;
  deletedAt?: Date | null;
  deletedMessage?: string | null;
}

export default ILink;