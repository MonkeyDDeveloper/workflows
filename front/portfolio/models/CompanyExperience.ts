import { Company } from "./Company";
export interface CompanyExperience {
    id: number;
    company_id: number;
    experience_id: number;
    company?: Company;
}