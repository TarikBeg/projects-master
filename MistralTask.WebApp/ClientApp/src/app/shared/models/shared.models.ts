export interface PaginationInfo {
    page: number;
    pageSize: number;
    total: number;
}

export interface ApiErrorResponse {
    errors: any;
    title: string;
    status: number;
    traceId: string;
}

export interface ApiResponse<TEntity> {
    records: TEntity;
    paginationInfo: PaginationInfo;
}