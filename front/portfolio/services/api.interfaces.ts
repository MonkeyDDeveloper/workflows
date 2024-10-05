export interface PortfolioApiResponse<T> {
    message?: string,
    detail?: string,
    data?: T
}

export interface PortfolioApiService {
    get<T>(url: string): Promise<PortfolioApiResponse<T>>;
}


