export interface IApiResponse<T> {
    $id?: string;
    $values?: T[];
    value?: T[];
    [key: string]: any;
}
