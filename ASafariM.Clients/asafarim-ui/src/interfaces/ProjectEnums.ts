export enum VisibilityEnum {
    Public = 0,
    MembersOnly = 1,
    Private = 2
}

// Add type-safe getter functions
export const getVisibilityLabel = (value: number): string => {
    return VisibilityEnum[value as unknown as keyof typeof VisibilityEnum] as unknown as string || 'Unknown';
};

export type VisibilityEnumStrings = keyof typeof VisibilityEnum;
export type StatusEnumStrings = keyof typeof StatusEnum;

export enum StatusEnum {
    InProgress = 0,
    Completed = 1,
    Cancelled = 2,
    Paused = 3,
    Extended = 4
}

export const getStatusLabel = (value: number): string => {
    return StatusEnum[value as unknown as keyof typeof StatusEnum] as unknown as string || 'Unknown Status';
};