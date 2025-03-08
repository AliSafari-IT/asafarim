import { IUser } from "./IUser";

// Create Project Interface
export interface IProject {
  id: string;
  name: string;
  description: string;
  startDate?: Date;  // Made optional
  endDate?: Date;
  isCompleted?: boolean;  // Made optional
  budget?: number;
  clientId?: string;  // Made optional
  client?: IUser;
  ownerId: string;
  owner?: IUser;
  dateCreated?: Date;  // Made optional
  dateModified?: Date;  // Made optional
  visibility?: number;  // Changed to lowercase to match API
  status?: number;     // Changed to lowercase to match API
  // Frontend presentation
  visibilityLabel?: string;
  statusLabel?: string;
}

export default IProject;
