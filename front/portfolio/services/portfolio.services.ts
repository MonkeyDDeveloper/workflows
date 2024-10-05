import { PortfolioApiService, PortfolioApiResponse } from "./api.interfaces";

class PortofioApi implements PortfolioApiService {
    public async get<U>(url: string): Promise<PortfolioApiResponse<U>> {
        try {
            const response = await fetch(url);
            const jsonResponse: PortfolioApiResponse<U> = await response.json();
            if (!jsonResponse.data) {
                throw new Error(`${jsonResponse.message || ''} - ${jsonResponse.detail || ''}`);
            }
            return jsonResponse
        }
        catch (err) {
            return {
                message: err.message
            }
        }
    }
}

export const portofioApi = new PortofioApi();