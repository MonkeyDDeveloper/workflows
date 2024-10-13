import { Responsabilitie } from "./Responsabilitie";
import { TechnologieExperience } from "./TechnologieExperience";
export interface ProfessionalExperience {
    id: number,
    title: string,
    description: string,
    startDate: string,
    endDate: string,
    responsabilities?: Responsabilitie[],
    technologieExperiences?: TechnologieExperience[]
}