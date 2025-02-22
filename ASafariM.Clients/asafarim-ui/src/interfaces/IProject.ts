import { IUser } from "./IUser";

// Create Project Interface
export interface IProject {
  id: string;
  name: string;
  description: string;
  startDate: Date;
  endDate?: Date;
  isCompleted: boolean;
  budget?: number;
  clientId: string;
  client?: IUser;
  ownerId: string;
  owner?: IUser;
  dateCreated: Date;
  dateModified: Date;
  Visibility?: number; // Keep as numeric value from backend
  Status?: number;
  // Frontend presentation
  visibilityLabel?: string; // Add if needed
  statusLabel?: string;

  markAsCompleted?: () => void; // Add ? to make optional
  updateProjectDetails?: () => void;
  calculateDaysLeft: (startDate: string) => number;
}

export default IProject;
