import { IRole } from "./IRole";

export interface ISitemap {
  id: string;
  pageName: string;
  description: string;
  slug: string;
  accessByRole: IRole;
}


