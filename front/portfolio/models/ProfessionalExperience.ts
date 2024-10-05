import { Responsabilitie } from "./Responsabilitie";
import { TechnologieExperience } from "./TechnologieExperience";
export interface ProfessionalExperience {
    Id: number,
    Title: string,
    Description: string,
    StartDate: Date,
    EndDate: Date,
    Responsabilities?: Responsabilitie[],
    TechnologieExperiences?: TechnologieExperience[]
}