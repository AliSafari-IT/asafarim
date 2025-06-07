/// <reference types="vitest" />
import { describe, it, expect, vi, beforeEach } from 'vitest';
import { v4 as uuidv4 } from 'uuid';

// Create mock functions with vi.hoisted() to properly handle hoisting
const mockGet = vi.hoisted(() => vi.fn());
const mockPost = vi.hoisted(() => vi.fn());
const mockPut = vi.hoisted(() => vi.fn());
const mockDelete = vi.hoisted(() => vi.fn());
const mockUse = vi.hoisted(() => vi.fn());
const mockJwtDecode = vi.hoisted(() => vi.fn());

// Mock axios
vi.mock("axios", async () => {
    const actualAxios = await vi.importActual<typeof import("axios")>("axios");
    return {
      ...actualAxios,
      default: {
        ...actualAxios.default,
        create: vi.fn(() => ({
          interceptors: {
            request: { use: mockUse },
            response: { use: mockUse },
          },
          get: mockGet,
          post: mockPost,
          put: mockPut,
          delete: mockDelete,
          defaults: {},
        })),
      },
    };
});

// Mock localStorage
const mockLocalStorage = {
  getItem: vi.fn(),
  setItem: vi.fn(),
  clear: vi.fn(),
  removeItem: vi.fn(),
  length: 0,
  key: vi.fn()
};

// Mock jwt-decode
vi.mock('jwt-decode', () => ({
  jwtDecode: mockJwtDecode
}));

// Import the module after mocking
import dashboardServices from '../entityServices';

describe('dashboardServices', () => {
  const testEntityName = 'project';
  const testId = uuidv4();
  const testToken = 'test-jwt-token';
  const testAuthData = JSON.stringify({ token: testToken });
  
  beforeEach(() => {
    vi.resetAllMocks();
    
    // Setup localStorage mock
    Object.defineProperty(window, 'localStorage', { value: mockLocalStorage });
    mockLocalStorage.getItem.mockReturnValue(testAuthData);
  });

  describe('fetchEntities', () => {
    it('should fetch entities successfully when response is an array', async () => {
      // Arrange
      const mockEntities = [{ id: '1', name: 'Test Entity' }];
      mockGet.mockResolvedValue({ data: mockEntities, status: 200 });
      
      // Act
      const result = await dashboardServices.fetchEntities(testEntityName);
      
      // Assert
      expect(mockGet).toHaveBeenCalledWith('/projects');
      expect(result).toEqual(mockEntities);
    });
    
    it('should handle response with $values property', async () => {
      // Arrange
      const mockEntities = [{ id: '1', name: 'Test Entity' }];
      mockGet.mockResolvedValue({ 
        data: { $values: mockEntities },
        status: 200 
      });
      
      // Act
      const result = await dashboardServices.fetchEntities(testEntityName);
      
      // Assert
      expect(mockGet).toHaveBeenCalledWith('/projects');
      expect(result).toEqual(mockEntities);
    });
    
    it('should handle response with value property', async () => {
      // Arrange
      const mockEntities = [{ id: '1', name: 'Test Entity' }];
      mockGet.mockResolvedValue({ 
        data: { value: mockEntities },
        status: 200 
      });
      
      // Act
      const result = await dashboardServices.fetchEntities(testEntityName);
      
      // Assert
      expect(mockGet).toHaveBeenCalledWith('/projects');
      expect(result).toEqual(mockEntities);
    });
    
    it('should handle response with single object', async () => {
      // Arrange
      const mockEntity = { id: '1', name: 'Test Entity' };
      mockGet.mockResolvedValue({ data: mockEntity, status: 200 });
      
      // Act
      const result = await dashboardServices.fetchEntities(testEntityName);
      
      // Assert
      expect(mockGet).toHaveBeenCalledWith('/projects');
      expect(result).toEqual([mockEntity]);
    });
    
    it('should handle error when fetching entities', async () => {
      // Arrange
      const errorMessage = 'Network Error';
      mockGet.mockRejectedValue(new Error(errorMessage));
      
      // Act & Assert
      await expect(dashboardServices.fetchEntities(testEntityName))
        .rejects.toThrow(errorMessage);
    });
  });
  
  describe('fetchEntityById', () => {
    it('should fetch entity by id successfully', async () => {
      // Arrange
      const mockEntity = { id: testId, name: 'Test Entity' };
      mockGet.mockResolvedValue({ data: mockEntity, status: 200 });
      
      // Act
      const result = await dashboardServices.fetchEntityById(testEntityName, testId);
      
      // Assert
      expect(mockGet).toHaveBeenCalledWith(`/projects/${testId}`);
      expect(result).toEqual(mockEntity);
    });
    
    it('should handle error when fetching entity by id', async () => {
      // Arrange
      const errorMessage = 'Entity not found';
      mockGet.mockRejectedValue(new Error(errorMessage));
      
      // Act & Assert
      await expect(dashboardServices.fetchEntityById(testEntityName, testId))
        .rejects.toThrow(errorMessage);
    });
  });
  
  describe('addEntity', () => {
    it('should add entity successfully', async () => {
      // Arrange
      const mockEntityData = { name: 'New Entity', description: 'Test description' };
      const mockResponse = { id: testId, ...mockEntityData };
      mockPost.mockResolvedValue({ data: mockResponse, status: 201 });
      
      // Act
      const result = await dashboardServices.addEntity(testEntityName, mockEntityData);
      
      // Assert
      expect(mockPost).toHaveBeenCalledWith('/projects', mockEntityData);
      expect(result).toEqual(mockResponse);
    });
    
    it('should handle error when adding entity', async () => {
      // Arrange
      const mockEntityData = { name: 'New Entity' };
      const errorMessage = 'Validation Error';
      mockPost.mockRejectedValue(new Error(errorMessage));
      
      // Act & Assert
      await expect(dashboardServices.addEntity(testEntityName, mockEntityData))
        .rejects.toThrow(errorMessage);
    });
  });
  
  describe('updateEntity', () => {
    it('should update entity successfully', async () => {
      // Arrange
      const mockEntityData = { name: 'Updated Entity' };
      const mockResponse = { id: testId, ...mockEntityData };
      mockPut.mockResolvedValue({ data: mockResponse, status: 200 });
      
      // Act
      const result = await dashboardServices.updateEntity(testEntityName, testId, mockEntityData);
      
      // Assert
      expect(mockPut).toHaveBeenCalledWith(`/projects/${testId}`, mockEntityData);
      expect(result).toEqual(mockResponse);
    });
    
    it('should handle error when updating entity', async () => {
      // Arrange
      const mockEntityData = { name: 'Updated Entity' };
      const errorMessage = 'Entity not found';
      mockPut.mockRejectedValue(new Error(errorMessage));
      
      // Act & Assert
      await expect(dashboardServices.updateEntity(testEntityName, testId, mockEntityData))
        .rejects.toThrow(errorMessage);
    });
  });
  
  describe('deleteEntity', () => {
    it('should delete entity successfully', async () => {
      // Arrange
      mockDelete.mockResolvedValue({ status: 204 });
      
      // Act
      const result = await dashboardServices.deleteEntity(testEntityName, testId);
      
      // Assert
      expect(mockDelete).toHaveBeenCalledWith(`/projects/${testId}`);
      expect(result).toBe(true);
    });
    
    it('should handle error when deleting entity', async () => {
      // Arrange
      const errorMessage = 'Entity not found';
      mockDelete.mockRejectedValue(new Error(errorMessage));
      
      // Act & Assert
      await expect(dashboardServices.deleteEntity(testEntityName, testId))
        .rejects.toThrow(errorMessage);
    });
  });
  
  describe('hasAdminRole', () => {
    it('should return true when user has admin role', () => {
      // Arrange
      const mockDecodedToken = { 
        role: 'Admin',
        'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier': 'user123'
      };
      mockJwtDecode.mockReturnValue(mockDecodedToken);
      
      // Act
      const result = dashboardServices.hasAdminRole();
      
      // Assert
      expect(mockLocalStorage.getItem).toHaveBeenCalledWith('auth');
      expect(mockJwtDecode).toHaveBeenCalledWith(testToken);
      expect(result).toBe(true);
    });
    
    it('should return false when user does not have admin role', () => {
      // Arrange
      const mockDecodedToken = { 
        role: 'User',
        'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier': 'user123'
      };
      mockJwtDecode.mockReturnValue(mockDecodedToken);
      
      // Act
      const result = dashboardServices.hasAdminRole();
      
      // Assert
      expect(result).toBe(false);
    });
    
    it('should return false when no token exists', () => {
      // Arrange
      mockLocalStorage.getItem.mockReturnValue(null);
      
      // Act
      const result = dashboardServices.hasAdminRole();
      
      // Assert
      expect(result).toBe(false);
    });
    
    it('should return false when token decoding fails', () => {
      // Arrange
      mockJwtDecode.mockImplementation(() => {
        throw new Error('Invalid token');
      });
      
      // Act
      const result = dashboardServices.hasAdminRole();
      
      // Assert
      expect(result).toBe(false);
    });
  });
  
  describe('tableExistsInDb', () => {
    it('should return true when table exists', async () => {
      // Arrange
      mockGet.mockResolvedValue({ status: 200 });
      
      // Act
      const result = await dashboardServices.tableExistsInDb(testEntityName);
      
      // Assert
      expect(mockGet).toHaveBeenCalledWith('/projects');
      expect(result).toBe(true);
    });
    
    it('should return false when table does not exist', async () => {
      // Arrange
      mockGet.mockRejectedValue(new Error('Not Found'));
      
      // Act
      const result = await dashboardServices.tableExistsInDb(testEntityName);
      
      // Assert
      expect(mockGet).toHaveBeenCalledWith('/projects');
      expect(result).toBe(false);
    });
  });
  
  describe('fetchEntityRepoLinks', () => {
    it('should fetch entity repo links successfully', async () => {
      // Arrange
      const mockLinks = [{ id: '1', url: 'https://github.com/test/repo' }];
      mockGet.mockResolvedValue({ data: mockLinks, status: 200 });
      
      // Act
      const result = await dashboardServices.fetchEntityRepoLinks(testEntityName, testId);
      
      // Assert
      expect(mockGet).toHaveBeenCalledWith(`/projects/${testId}/links`);
      expect(result).toEqual(mockLinks);
    });
    
    it('should return empty array when fetching links fails', async () => {
      // Arrange
      mockGet.mockRejectedValue(new Error('Not Found'));
      
      // Act
      const result = await dashboardServices.fetchEntityRepoLinks(testEntityName, testId);
      
      // Assert
      expect(mockGet).toHaveBeenCalledWith(`/projects/${testId}/links`);
      expect(result).toEqual([]);
    });
  });
});
