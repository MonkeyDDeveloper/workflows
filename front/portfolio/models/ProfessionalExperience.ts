import { CompanyExperience } from "./CompanyExperience";
import { Responsabilitie } from "./Responsabilitie";
import { TechnologieExperience } from "./TechnologieExperience";
export interface ProfessionalExperience {
    id: number,
    title: string,
    description: string,
    startDate: string,
    endDate: string,
    isCurrent: boolean,
    responsabilities?: Responsabilitie[],
    technologieExperiences?: TechnologieExperience[],
    companyExperience?: CompanyExperience
}