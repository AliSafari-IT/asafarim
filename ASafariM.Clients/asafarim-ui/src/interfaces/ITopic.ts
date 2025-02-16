import { IPost } from "./post-types";

export interface ITopic {
  parentTopicId?: string | undefined;
  id: string;
  name: string;
  description?: string;
  slug?: string;
  topicId?: string;
  summary?: string;
  content?: string;
  title?: string;
  to?: string;
  icon?: React.ReactElement;
  technologyCategory?: string;
  difficultyLevel?: string;
  relatedPosts?: IPost[];
  updatedAt?: Date;
  createdAt?: Date;
};

