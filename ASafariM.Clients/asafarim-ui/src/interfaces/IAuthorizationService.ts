// src/interfaces/IAuthorizationService.ts
export interface IAuthorizationService {
  authorize(user: any, policyName: string): boolean;
  authorizeAsync(user: any, policyName: string): Promise<boolean>;
}