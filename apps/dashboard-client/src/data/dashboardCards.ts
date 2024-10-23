// E:\asm\apps\dashboard-client\src\data\dashboardCards.ts
import { fetchTopics } from "../api/dashboardServices";
import { ITopic } from "../interfaces/ITopic";

const getTopics = async () => {
    const topics = await fetchTopics();
    return topics;
}

export default {
    "topics": getTopics() as Promise<ITopic[]>,
    "blogPosts": [
        
    ] ,
    "sitemap": [
        
    ],
   
 } as any;