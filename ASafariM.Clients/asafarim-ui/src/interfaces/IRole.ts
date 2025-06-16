export enum IRoleEnum {
  Guest = 0,
  StandardUser = 1,
  Admin = 2,
  SuperAdmin = 3,
  Editor = 4,
  Moderator = 5,
  Developer = 6,
  ProjectManager = 7,
  ProjectCoordinator = 8,
  ProjectLeader = 9,
  ProjectManagerAssistant = 10,
  ProjectManagerSpecialist = 11,
  ProjectManagerSpecialistAssistant = 12,
}

export interface IRole {
  id: string;       // Guid type as a string
  name: string;     // Role name
  description?: string; // Optional description
}
