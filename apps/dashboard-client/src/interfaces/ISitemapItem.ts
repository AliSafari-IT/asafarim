import { IRole } from "./IRole";

export interface ISitemapItem {
  id: string;
  pageName: string;
  description: string;
  slug: string;
  accessByRole: IRole;
}


