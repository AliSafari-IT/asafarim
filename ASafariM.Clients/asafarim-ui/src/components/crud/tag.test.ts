import dashboardServices from "@/api/entityServices";
import apiUrls from "@/api/getApiUrls";
import axios from "axios";
import { expect, it, vi } from "vitest";

const api = axios.create({
    baseURL: apiUrls(window.location.hostname)
});


it('should successfully update a tag entity when given valid id and data', async () => {
    const mockId = '123';
    const mockTagData = {
        id: mockId,
        name: 'Test Tag',
        description: 'Test Description',
        slug: 'test-tag'
    };
    const mockResponse = {
        data: { ...mockTagData }
    };

    api.put = vi.fn().mockResolvedValue(mockResponse);

    const result = await dashboardServices.updateEntity('tag', mockId, mockTagData);

    expect(api.put).toHaveBeenCalledWith('/tags/123', mockTagData);
    expect(result).toEqual({
        success: true,
        data: mockResponse.data
    });
});

